namespace ChequePrintingApp
{
    partial class frm_Cheque
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cheque));
            btn_Print = new Button();
            dgv_Cheque = new DataGridView();
            label1 = new Label();
            btn_Close = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            PrintPreview = new PrintPreviewDialog();
            btnPrintPreview = new Button();
            btn_Settings = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Cheque).BeginInit();
            SuspendLayout();
            // 
            // btn_Print
            // 
            btn_Print.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Print.Location = new Point(781, 465);
            btn_Print.Name = "btn_Print";
            btn_Print.Size = new Size(104, 42);
            btn_Print.TabIndex = 0;
            btn_Print.Text = "Print";
            btn_Print.UseVisualStyleBackColor = true;
            btn_Print.Click += btn_Print_Click;
            // 
            // dgv_Cheque
            // 
            dgv_Cheque.AllowUserToAddRows = false;
            dgv_Cheque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cheque.Location = new Point(39, 68);
            dgv_Cheque.Name = "dgv_Cheque";
            dgv_Cheque.RowTemplate.Height = 25;
            dgv_Cheque.Size = new Size(958, 378);
            dgv_Cheque.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(342, 21);
            label1.Name = "label1";
            label1.Size = new Size(365, 30);
            label1.TabIndex = 2;
            label1.Text = "EasyPack Solutions - Cheque Printing";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_Close
            // 
            btn_Close.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Close.Location = new Point(891, 465);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(104, 42);
            btn_Close.TabIndex = 3;
            btn_Close.Text = "Close";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // PrintPreview
            // 
            PrintPreview.AutoScrollMargin = new Size(0, 0);
            PrintPreview.AutoScrollMinSize = new Size(0, 0);
            PrintPreview.ClientSize = new Size(400, 300);
            PrintPreview.Enabled = true;
            PrintPreview.Icon = (Icon)resources.GetObject("PrintPreview.Icon");
            PrintPreview.Name = "printPreviewDialog1";
            PrintPreview.Visible = false;
            // 
            // btnPrintPreview
            // 
            btnPrintPreview.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrintPreview.Location = new Point(612, 465);
            btnPrintPreview.Name = "btnPrintPreview";
            btnPrintPreview.Size = new Size(148, 42);
            btnPrintPreview.TabIndex = 4;
            btnPrintPreview.Text = "Print Preview";
            btnPrintPreview.UseVisualStyleBackColor = true;
            btnPrintPreview.Click += btnPrintPreview_Click;
            // 
            // btn_Settings
            // 
            btn_Settings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Settings.BackColor = Color.Transparent;
            btn_Settings.Image = (Image)resources.GetObject("btn_Settings.Image");
            btn_Settings.Location = new Point(939, 6);
            btn_Settings.Name = "btn_Settings";
            btn_Settings.Size = new Size(56, 56);
            btn_Settings.TabIndex = 5;
            btn_Settings.UseVisualStyleBackColor = false;
            btn_Settings.Click += btn_Settings_Click;
            // 
            // frm_Cheque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1037, 544);
            Controls.Add(btn_Settings);
            Controls.Add(btnPrintPreview);
            Controls.Add(btn_Close);
            Controls.Add(label1);
            Controls.Add(dgv_Cheque);
            Controls.Add(btn_Print);
            Name = "frm_Cheque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cheque Print";
            ((System.ComponentModel.ISupportInitialize)dgv_Cheque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Print;
        private DataGridView dgv_Cheque;
        private Label label1;
        private Button btn_Close;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog PrintPreview;
        private Button btnPrintPreview;
        private Button btn_Settings;
    }
}
