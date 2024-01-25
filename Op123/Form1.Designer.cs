namespace Op123
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            buttonSeePass = new Button();
            buttonRegSwap = new Button();
            buttonEnterReg = new Button();
            pictureBox1 = new PictureBox();
            textBoxPass = new TextBox();
            textBoxLog = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(buttonSeePass);
            panel1.Controls.Add(buttonRegSwap);
            panel1.Controls.Add(buttonEnterReg);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBoxPass);
            panel1.Controls.Add(textBoxLog);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 563);
            panel1.TabIndex = 2;
            // 
            // buttonSeePass
            // 
            buttonSeePass.Location = new Point(595, 144);
            buttonSeePass.Name = "buttonSeePass";
            buttonSeePass.Size = new Size(156, 35);
            buttonSeePass.TabIndex = 9;
            buttonSeePass.Text = "Показать/скрыть пароль";
            buttonSeePass.UseVisualStyleBackColor = true;
            buttonSeePass.Click += buttonSeePass_Click;
            // 
            // buttonRegSwap
            // 
            buttonRegSwap.Location = new Point(595, 297);
            buttonRegSwap.Name = "buttonRegSwap";
            buttonRegSwap.Size = new Size(156, 35);
            buttonRegSwap.TabIndex = 8;
            buttonRegSwap.Text = "Зарегестрироваться";
            buttonRegSwap.UseVisualStyleBackColor = true;
            buttonRegSwap.Click += buttonRegSwap_Click;
            // 
            // buttonEnterReg
            // 
            buttonEnterReg.Location = new Point(595, 217);
            buttonEnterReg.Name = "buttonEnterReg";
            buttonEnterReg.Size = new Size(151, 35);
            buttonEnterReg.TabIndex = 7;
            buttonEnterReg.Text = "Войти";
            buttonEnterReg.UseVisualStyleBackColor = true;
            buttonEnterReg.Click += buttonEnterReg_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(243, 254);
            textBoxPass.Multiline = true;
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(217, 23);
            textBoxPass.TabIndex = 4;
            // 
            // textBoxLog
            // 
            textBoxLog.Location = new Point(243, 170);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(213, 22);
            textBoxLog.TabIndex = 3;
            textBoxLog.TextChanged += textBoxLog_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(243, 217);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(243, 130);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(814, 100);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("NFS font", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(149, 32);
            label1.Name = "label1";
            label1.Size = new Size(360, 30);
            label1.TabIndex = 0;
            label1.Text = "Зарегестрироваться";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 543);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonSeePass;
        private Button buttonRegSwap;
        private Button buttonEnterReg;
        private PictureBox pictureBox1;
        private TextBox textBoxPass;
        private TextBox textBoxLog;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
    }
}
