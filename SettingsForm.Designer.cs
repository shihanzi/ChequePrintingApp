namespace ChequePrintingApp
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Save = new Button();
            nudNameX = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nudNameY = new NumericUpDown();
            label4 = new Label();
            nudDateY = new NumericUpDown();
            label5 = new Label();
            nudDateX = new NumericUpDown();
            label6 = new Label();
            nudAmountY = new NumericUpDown();
            label7 = new Label();
            nudAmountX = new NumericUpDown();
            label8 = new Label();
            nudWordFontSize = new NumericUpDown();
            label10 = new Label();
            nudWordY = new NumericUpDown();
            label11 = new Label();
            nudWordX = new NumericUpDown();
            label9 = new Label();
            nudAccPayeeY = new NumericUpDown();
            label12 = new Label();
            nudAccPayeeX = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudNameX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNameY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDateY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDateX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAmountY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAmountX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWordFontSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWordY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWordX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAccPayeeY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAccPayeeX).BeginInit();
            SuspendLayout();
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Save.Location = new Point(456, 376);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(104, 42);
            btn_Save.TabIndex = 1;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // nudNameX
            // 
            nudNameX.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudNameX.Location = new Point(158, 73);
            nudNameX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudNameX.Name = "nudNameX";
            nudNameX.Size = new Size(120, 29);
            nudNameX.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 75);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 3;
            label1.Text = "Name X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(195, 9);
            label2.Name = "label2";
            label2.Size = new Size(231, 25);
            label2.TabIndex = 4;
            label2.Text = "Print Position Adjustment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(43, 122);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 6;
            label3.Text = "Name Y";
            // 
            // nudNameY
            // 
            nudNameY.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudNameY.Location = new Point(158, 120);
            nudNameY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudNameY.Name = "nudNameY";
            nudNameY.Size = new Size(120, 29);
            nudNameY.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(43, 217);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 10;
            label4.Text = "Date Y";
            // 
            // nudDateY
            // 
            nudDateY.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudDateY.Location = new Point(158, 215);
            nudDateY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudDateY.Name = "nudDateY";
            nudDateY.Size = new Size(120, 29);
            nudDateY.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(43, 170);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 8;
            label5.Text = "Date X";
            // 
            // nudDateX
            // 
            nudDateX.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudDateX.Location = new Point(158, 168);
            nudDateX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudDateX.Name = "nudDateX";
            nudDateX.Size = new Size(120, 29);
            nudDateX.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(37, 312);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 14;
            label6.Text = " Amount Y";
            // 
            // nudAmountY
            // 
            nudAmountY.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudAmountY.Location = new Point(158, 310);
            nudAmountY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAmountY.Name = "nudAmountY";
            nudAmountY.Size = new Size(120, 29);
            nudAmountY.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(38, 265);
            label7.Name = "label7";
            label7.Size = new Size(87, 21);
            label7.TabIndex = 12;
            label7.Text = " Amount X";
            // 
            // nudAmountX
            // 
            nudAmountX.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudAmountX.Location = new Point(158, 263);
            nudAmountX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAmountX.Name = "nudAmountX";
            nudAmountX.Size = new Size(120, 29);
            nudAmountX.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(325, 265);
            label8.Name = "label8";
            label8.Size = new Size(76, 21);
            label8.TabIndex = 22;
            label8.Text = "Font Size";
            // 
            // nudWordFontSize
            // 
            nudWordFontSize.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudWordFontSize.Location = new Point(440, 263);
            nudWordFontSize.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudWordFontSize.Name = "nudWordFontSize";
            nudWordFontSize.Size = new Size(120, 29);
            nudWordFontSize.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(325, 122);
            label10.Name = "label10";
            label10.Size = new Size(71, 21);
            label10.TabIndex = 18;
            label10.Text = "Words Y";
            // 
            // nudWordY
            // 
            nudWordY.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudWordY.Location = new Point(440, 120);
            nudWordY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudWordY.Name = "nudWordY";
            nudWordY.Size = new Size(120, 29);
            nudWordY.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(325, 75);
            label11.Name = "label11";
            label11.Size = new Size(72, 21);
            label11.TabIndex = 16;
            label11.Text = "Words X";
            // 
            // nudWordX
            // 
            nudWordX.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudWordX.Location = new Point(440, 73);
            nudWordX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudWordX.Name = "nudWordX";
            nudWordX.Size = new Size(120, 29);
            nudWordX.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(324, 215);
            label9.Name = "label9";
            label9.Size = new Size(93, 21);
            label9.TabIndex = 26;
            label9.Text = "AccPayee Y";
            // 
            // nudAccPayeeY
            // 
            nudAccPayeeY.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudAccPayeeY.Location = new Point(439, 213);
            nudAccPayeeY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAccPayeeY.Name = "nudAccPayeeY";
            nudAccPayeeY.Size = new Size(120, 29);
            nudAccPayeeY.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(324, 168);
            label12.Name = "label12";
            label12.Size = new Size(94, 21);
            label12.TabIndex = 24;
            label12.Text = "AccPayee X";
            // 
            // nudAccPayeeX
            // 
            nudAccPayeeX.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudAccPayeeX.Location = new Point(439, 166);
            nudAccPayeeX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAccPayeeX.Name = "nudAccPayeeX";
            nudAccPayeeX.Size = new Size(120, 29);
            nudAccPayeeX.TabIndex = 23;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(label9);
            Controls.Add(nudAccPayeeY);
            Controls.Add(label12);
            Controls.Add(nudAccPayeeX);
            Controls.Add(label8);
            Controls.Add(nudWordFontSize);
            Controls.Add(label10);
            Controls.Add(nudWordY);
            Controls.Add(label11);
            Controls.Add(nudWordX);
            Controls.Add(label6);
            Controls.Add(nudAmountY);
            Controls.Add(label7);
            Controls.Add(nudAmountX);
            Controls.Add(label4);
            Controls.Add(nudDateY);
            Controls.Add(label5);
            Controls.Add(nudDateX);
            Controls.Add(label3);
            Controls.Add(nudNameY);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudNameX);
            Controls.Add(btn_Save);
            Name = "SettingsForm";
            Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)nudNameX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNameY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDateY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDateX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAmountY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAmountX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWordFontSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWordY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWordX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAccPayeeY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAccPayeeX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Save;
        private NumericUpDown nudNameX;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown nudNameY;
        private Label label4;
        private NumericUpDown nudDateY;
        private Label label5;
        private NumericUpDown nudDateX;
        private Label label6;
        private NumericUpDown nudAmountY;
        private Label label7;
        private NumericUpDown nudAmountX;
        private Label label8;
        private NumericUpDown nudWordFontSize;
        private Label label10;
        private NumericUpDown nudWordY;
        private Label label11;
        private NumericUpDown nudWordX;
        private Label label9;
        private NumericUpDown nudAccPayeeY;
        private Label label12;
        private NumericUpDown nudAccPayeeX;
    }
}