namespace Op123
{
    partial class Regisrt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regisrt));
            panel1 = new Panel();
            textRepeatPass = new TextBox();
            label4 = new Label();
            buttonReg = new Button();
            buttonAuthSwap = new Button();
            pictureBox1 = new PictureBox();
            textBoxPassReg = new TextBox();
            textBoxLogReg = new TextBox();
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
            panel1.Controls.Add(textRepeatPass);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonReg);
            panel1.Controls.Add(buttonAuthSwap);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBoxPassReg);
            panel1.Controls.Add(textBoxLogReg);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 561);
            panel1.TabIndex = 1;
            // 
            // textRepeatPass
            // 
            textRepeatPass.Location = new Point(243, 344);
            textRepeatPass.Multiline = true;
            textRepeatPass.Name = "textRepeatPass";
            textRepeatPass.Size = new Size(217, 23);
            textRepeatPass.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(243, 298);
            label4.Name = "label4";
            label4.Size = new Size(146, 21);
            label4.TabIndex = 9;
            label4.Text = "Повторите  пароль";
            // 
            // buttonReg
            // 
            buttonReg.Location = new Point(420, 417);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(156, 35);
            buttonReg.TabIndex = 8;
            buttonReg.Text = "Зарегестрироваться";
            buttonReg.UseVisualStyleBackColor = true;
            buttonReg.Click += buttonReg_Click;
            // 
            // buttonAuthSwap
            // 
            buttonAuthSwap.Location = new Point(238, 417);
            buttonAuthSwap.Name = "buttonAuthSwap";
            buttonAuthSwap.Size = new Size(151, 35);
            buttonAuthSwap.TabIndex = 7;
            buttonAuthSwap.Text = "Авторизироваться";
            buttonAuthSwap.UseVisualStyleBackColor = true;
            buttonAuthSwap.Click += buttonAuthSwap_Click;
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
            // textBoxPassReg
            // 
            textBoxPassReg.Location = new Point(243, 254);
            textBoxPassReg.Multiline = true;
            textBoxPassReg.Name = "textBoxPassReg";
            textBoxPassReg.Size = new Size(217, 23);
            textBoxPassReg.TabIndex = 4;
            // 
            // textBoxLogReg
            // 
            textBoxLogReg.Location = new Point(243, 170);
            textBoxLogReg.Multiline = true;
            textBoxLogReg.Name = "textBoxLogReg";
            textBoxLogReg.Size = new Size(213, 22);
            textBoxLogReg.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(243, 217);
            label3.Name = "label3";
            label3.Size = new Size(154, 21);
            label3.TabIndex = 2;
            label3.Text = "Принумайте пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(243, 130);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 1;
            label2.Text = "Придумайте логин";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 100);
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
            label1.Click += label1_Click;
            // 
            // Regisrt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 562);
            Controls.Add(panel1);
            Name = "Regisrt";
            Text = "Regisrt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textRepeatPass;
        private Label label4;
        private Button buttonReg;
        private Button buttonAuthSwap;
        private PictureBox pictureBox1;
        private TextBox textBoxPassReg;
        private TextBox textBoxLogReg;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
    }
}