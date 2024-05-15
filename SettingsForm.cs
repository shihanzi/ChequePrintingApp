using System.Text.Json;

namespace ChequePrintingApp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.Load += SettingsForm_Load;
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadSettingsIntoControls();
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string fileName = Path.Combine(@"C:\Journal", "printSettings.json");
            //MessageBox.Show("Using file path: " + fileName);
            PrintSettings settings = new PrintSettings()
            {
                NameX = (float)nudNameX.Value,
                NameY = (float)nudNameY.Value,
                DateX = (float)nudDateX.Value,
                DateY = (float)nudDateY.Value,
                AmountX = (float)nudAmountX.Value,
                AmountY = (float)nudAmountY.Value,
                WordsX = (float)nudWordX.Value,
                WordsY = (float)nudWordY.Value,
                FontSize = (float)nudWordFontSize.Value
            };

            string jsonString = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            try
            {
                File.WriteAllText(fileName, jsonString);
                MessageBox.Show("Settings saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save settings: " + ex.Message);
            }

        }

        public void LoadSettingsIntoControls()
        {
            PrintSettings settings = LoadSettings();

            SetNumericUpDownValue(nudNameX, (decimal)settings.NameX);
            SetNumericUpDownValue(nudNameY, (decimal)settings.NameY);
            SetNumericUpDownValue(nudDateX, (decimal)settings.DateX);
            SetNumericUpDownValue(nudDateY, (decimal)settings.DateY);
            SetNumericUpDownValue(nudAmountX, (decimal)settings.AmountX);
            SetNumericUpDownValue(nudAmountY, (decimal)settings.AmountY);
            SetNumericUpDownValue(nudWordX, (decimal)settings.WordsX);
            SetNumericUpDownValue(nudWordY, (decimal)settings.WordsY);
            SetNumericUpDownValue(nudWordFontSize, (decimal)settings.FontSize);
        }
        private void SetNumericUpDownValue(NumericUpDown numericUpDown, decimal value)
        {
            numericUpDown.Value = Math.Max(numericUpDown.Minimum, Math.Min(numericUpDown.Maximum, value));
        }

    }
}
