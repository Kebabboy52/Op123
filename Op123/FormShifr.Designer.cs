namespace Op123
{
    partial class FormShifr
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
            panel1 = new Panel();
            buttonZash = new Button();
            buttonRead = new Button();
            label5 = new Label();
            DiamCh = new NumericUpDown();
            label2 = new Label();
            RazshivText = new TextBox();
            label4 = new Label();
            ZashCancel = new Button();
            buttonSaveSh = new Button();
            MainText = new TextBox();
            IshodText = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DiamCh).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(buttonZash);
            panel1.Controls.Add(buttonRead);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(DiamCh);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(RazshivText);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ZashCancel);
            panel1.Controls.Add(buttonSaveSh);
            panel1.Controls.Add(MainText);
            panel1.Controls.Add(IshodText);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 510);
            panel1.TabIndex = 2;
            // 
            // buttonZash
            // 
            buttonZash.BackColor = Color.GreenYellow;
            buttonZash.Location = new Point(294, 268);
            buttonZash.Name = "buttonZash";
            buttonZash.Size = new Size(102, 25);
            buttonZash.TabIndex = 14;
            buttonZash.Text = "Зашифровать";
            buttonZash.UseVisualStyleBackColor = false;
            buttonZash.Click += buttonZash_Click;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(535, 399);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(151, 35);
            buttonRead.TabIndex = 13;
            buttonRead.Text = "Прочитать";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(475, 122);
            label5.Name = "label5";
            label5.Size = new Size(91, 17);
            label5.TabIndex = 12;
            label5.Text = "Расшифровка";
            // 
            // DiamCh
            // 
            DiamCh.Location = new Point(118, 276);
            DiamCh.Name = "DiamCh";
            DiamCh.Size = new Size(120, 23);
            DiamCh.TabIndex = 11;
            DiamCh.ValueChanged += DiamCh_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 1;
            label2.Text = "Исходный текст";
            // 
            // RazshivText
            // 
            RazshivText.Location = new Point(475, 158);
            RazshivText.Multiline = true;
            RazshivText.Name = "RazshivText";
            RazshivText.Size = new Size(304, 85);
            RazshivText.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 339);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 9;
            label4.Text = "Зашифрованный текст";
            // 
            // ZashCancel
            // 
            ZashCancel.Location = new Point(628, 329);
            ZashCancel.Name = "ZashCancel";
            ZashCancel.Size = new Size(151, 36);
            ZashCancel.TabIndex = 8;
            ZashCancel.Text = "Прекратить работу";
            ZashCancel.UseVisualStyleBackColor = true;
            ZashCancel.Click += ZashCancel_Click;
            // 
            // buttonSaveSh
            // 
            buttonSaveSh.Location = new Point(449, 329);
            buttonSaveSh.Name = "buttonSaveSh";
            buttonSaveSh.Size = new Size(151, 35);
            buttonSaveSh.TabIndex = 7;
            buttonSaveSh.Text = "Сохранить";
            buttonSaveSh.UseVisualStyleBackColor = true;
            buttonSaveSh.Click += buttonSaveSh_Click;
            // 
            // MainText
            // 
            MainText.Location = new Point(12, 377);
            MainText.Multiline = true;
            MainText.Name = "MainText";
            MainText.Size = new Size(375, 72);
            MainText.TabIndex = 4;
            // 
            // IshodText
            // 
            IshodText.Location = new Point(12, 158);
            IshodText.Multiline = true;
            IshodText.Name = "IshodText";
            IshodText.Size = new Size(384, 85);
            IshodText.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 278);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Диаметр";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 100);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("NFS font", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(281, 37);
            label1.Name = "label1";
            label1.Size = new Size(252, 30);
            label1.TabIndex = 0;
            label1.Text = "Шифр Скитала";
            // 
            // FormShifr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 509);
            Controls.Add(panel1);
            Name = "FormShifr";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DiamCh).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox RazshivText;
        private Label label4;
        private Button ZashCancel;
        private Button buttonSaveSh;
        private TextBox MainText;
        private TextBox IshodText;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private NumericUpDown DiamCh;
        private Label label5;
        private Button buttonRead;
        private Button buttonZash;
    }
}