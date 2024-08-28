namespace TestApplication1
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
            button1 = new Button();
            textEmail = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(337, 147);
            button1.Name = "button1";
            button1.Size = new Size(134, 78);
            button1.TabIndex = 0;
            button1.Text = "pay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(235, 47);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(410, 27);
            textEmail.TabIndex = 1;
            textEmail.Text = "Enter your Email";
            textEmail.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 54);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(235, 92);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(410, 27);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Enter Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 99);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(textEmail);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textEmail;
        private Label label1;
        private TextBox txtPassword;
        private Label label2;
    }
}
