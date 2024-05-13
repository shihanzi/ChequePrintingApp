using ChequePrintingApp.Helper;
using ClosedXML.Excel;
using System;
using System.Data;
using System.Text.Json;

namespace ChequePrintingApp
{
    public partial class frm_Cheque : Form
    {
        string filePath = @"C:\Journal\text.xlsx";
        public frm_Cheque()
        {
            InitializeComponent();
            LoadDataIntoDataGridView(filePath);
            InitializeDataGridView();
            SetDefaultCheckboxState();
            SetupPrintDocument();
        }
        private void LoadDataIntoDataGridView(string filePath)
        {
            DataTable dt = new DataTable();
            HashSet<string> uniqueNums = new HashSet<string>();
            HashSet<string> hasAmount = new HashSet<string>();

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);

                // Define the columns in the DataTable
                dt.Columns.Add("Date", typeof(string));
                dt.Columns.Add("Num", typeof(string));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Memo/Description", typeof(string));
                dt.Columns.Add("Account", typeof(string));
                dt.Columns.Add("Amount", typeof(string));

                // Populate the DataTable with data from the Excel file, ensuring 'Num' is unique
                foreach (IXLRow row in worksheet.RowsUsed().Skip(4)) // Skip the header rows
                {
                    string num = row.Cell(5).GetValue<string>().Trim(); // Assume 'Num' is in column 5
                    //string amount = row.Cell(9).GetValue<string>().Trim();

                    if (!uniqueNums.Contains(num)) // Check if 'Num' is already added
                    {
                        uniqueNums.Add(num); // Add 'Num' to the HashSet to track uniqueness

                        dt.Rows.Add(
                            row.Cell(4).GetValue<string>(),
                            num,
                            row.Cell(6).GetValue<string>(),
                            row.Cell(7).GetValue<string>(),
                            row.Cell(8).GetValue<string>(),
                            row.Cell(10).GetValue<string>()
                        );
                    }
                }
            }
            dgv_Cheque.DataSource = dt;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            PrintSettings printSettings = new PrintSettings();
            PrintSettings settings = LoadSettings();
            Font font = new Font("Arial", 15);
            Brush brush = Brushes.Black;
            float y = 100; // Start point for y, adjust as needed

            foreach (DataGridViewRow row in dgv_Cheque.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    // Example: Print each row's data
                    string payeeName = row.Cells["Name"].Value.ToString();
                    string amount = row.Cells["Amount"].Value.ToString();
                    string originalDate = row.Cells["Date"].Value.ToString();
                    string formattedDate = FormatDateForCheque(originalDate);
                    string amountInWords = AmountInWords.NumberToWords(Convert.ToDouble(amount));

                    // Adjust `x` and `y` to match your cheque layout
                    graphics.DrawString(payeeName, font, brush, settings.NameX, settings.NameY);
                    graphics.DrawString(formattedDate, font, brush, settings.DateX, /*y*/ + settings.DateY);
                    graphics.DrawString(amount, font, brush, settings.AmountX, /*y*/ + settings.AmountY);
                    graphics.DrawString(amountInWords + " only", font, brush, settings.WordsX, /*y*/ + settings.WordsY);

                    //y += 60; // Increment y for the next row, adjust spacing as necessary
                }
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            SetupPrintDocument(); // Ensure settings are applied before printing
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            SetupPrintDocument();
            PrintPreview.Document = printDocument1;
            PrintPreview.ShowDialog();
        }

        private void InitializeDataGridView()
        {
            // Assuming dgv_Cheque is your DataGridView
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Selected";
            checkBoxColumn.Width = 70;
            checkBoxColumn.Name = "checkBoxColumn";
            dgv_Cheque.Columns.Insert(0, checkBoxColumn); // Inserts at the first position
        }

        private void SetDefaultCheckboxState()
        {
            foreach (DataGridViewRow row in dgv_Cheque.Rows)
            {
                row.Cells["checkBoxColumn"].Value = false;
            }
        }
        private string FormatDateForCheque(string date)
        {
            // Remove any non-numeric characters
            string numericDate = new string(date.Where(char.IsDigit).ToArray());

            // Insert spaces between each character
            return string.Join(" ", numericDate);
        }

        private void SetupPrintDocument()
        {
            // Assuming printDocument1 is your PrintDocument component
            printDocument1.DefaultPageSettings.Landscape = true;
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }

        public static PrintSettings LoadSettings()
        {
            string fileName = Path.Combine(@"C:\Journal", "printSettings.json");
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Default settings loaded. Configuration file not found.");
                return new PrintSettings(); // Return default settings if no config file found
            }

            try
            {
                string jsonString = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<PrintSettings>(jsonString);
            }
            catch (JsonException je)
            {
                MessageBox.Show("Error parsing settings: " + je.Message);
                return new PrintSettings(); // Return default if parsing fails
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading settings: " + ex.Message);
                return new PrintSettings(); // Return default if any other error
            }

            //string jsonString = File.ReadAllText("printSettings.json");
            //return JsonSerializer.Deserialize<PrintSettings>(jsonString);
        }
    }
}
