namespace pp_notes
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            LoginButton = new Button();
            LoginPasswordBox = new TextBox();
            LoginLoginBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 70, 111);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(LoginPasswordBox);
            panel1.Controls.Add(LoginLoginBox);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 700);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(182, 162);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 39);
            label1.TabIndex = 3;
            label1.Text = "Вход";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(148, 148, 188);
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Book Antiqua", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(135, 392);
            LoginButton.Margin = new Padding(4, 3, 4, 3);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(198, 36);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginPasswordBox
            // 
            LoginPasswordBox.BackColor = Color.FromArgb(148, 148, 188);
            LoginPasswordBox.BorderStyle = BorderStyle.None;
            LoginPasswordBox.Font = new Font("Book Antiqua", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginPasswordBox.ForeColor = Color.White;
            LoginPasswordBox.Location = new Point(119, 313);
            LoginPasswordBox.Margin = new Padding(4, 3, 4, 3);
            LoginPasswordBox.Name = "LoginPasswordBox";
            LoginPasswordBox.PlaceholderText = "Пароль";
            LoginPasswordBox.Size = new Size(226, 24);
            LoginPasswordBox.TabIndex = 1;
            LoginPasswordBox.UseSystemPasswordChar = true;
            // 
            // LoginLoginBox
            // 
            LoginLoginBox.BackColor = Color.FromArgb(148, 148, 188);
            LoginLoginBox.BorderStyle = BorderStyle.None;
            LoginLoginBox.Font = new Font("Book Antiqua", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginLoginBox.ForeColor = Color.White;
            LoginLoginBox.Location = new Point(119, 258);
            LoginLoginBox.Margin = new Padding(4, 3, 4, 3);
            LoginLoginBox.Name = "LoginLoginBox";
            LoginLoginBox.PlaceholderText = "Логин";
            LoginLoginBox.Size = new Size(226, 24);
            LoginLoginBox.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 35, 55);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Size = new Size(986, 700);
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox LoginLoginBox;
        private System.Windows.Forms.TextBox LoginPasswordBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
    }
}
