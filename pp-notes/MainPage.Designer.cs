namespace pp_notes
{
    partial class MainPage
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
            MainUsername = new Label();
            MainSearch = new TextBox();
            MainAdd = new Button();
            MainFlowLayout = new FlowLayoutPanel();
            MainExit = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MainUsername
            // 
            MainUsername.AutoSize = true;
            MainUsername.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MainUsername.Location = new Point(129, 40);
            MainUsername.Name = "MainUsername";
            MainUsername.Size = new Size(110, 26);
            MainUsername.TabIndex = 0;
            MainUsername.Text = "Username";
            // 
            // MainSearch
            // 
            MainSearch.BackColor = Color.FromArgb(60, 60, 77);
            MainSearch.BorderStyle = BorderStyle.None;
            MainSearch.Font = new Font("Book Antiqua", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainSearch.ForeColor = Color.FromArgb(149, 149, 159);
            MainSearch.Location = new Point(774, 43);
            MainSearch.Multiline = true;
            MainSearch.Name = "MainSearch";
            MainSearch.PlaceholderText = "Поиск";
            MainSearch.Size = new Size(212, 29);
            MainSearch.TabIndex = 1;
            MainSearch.TextChanged += MainSearch_TextChanged;
            // 
            // MainAdd
            // 
            MainAdd.BackColor = Color.FromArgb(60, 60, 77);
            MainAdd.FlatAppearance.BorderSize = 0;
            MainAdd.FlatStyle = FlatStyle.Flat;
            MainAdd.Font = new Font("Book Antiqua", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainAdd.ForeColor = Color.FromArgb(149, 149, 159);
            MainAdd.Location = new Point(545, 43);
            MainAdd.Name = "MainAdd";
            MainAdd.Size = new Size(168, 29);
            MainAdd.TabIndex = 2;
            MainAdd.Text = "+ Запись";
            MainAdd.UseVisualStyleBackColor = false;
            MainAdd.Click += MainAdd_Click;
            // 
            // MainFlowLayout
            // 
            MainFlowLayout.AutoScroll = true;
            MainFlowLayout.Location = new Point(50, 102);
            MainFlowLayout.Name = "MainFlowLayout";
            MainFlowLayout.Padding = new Padding(9);
            MainFlowLayout.Size = new Size(936, 578);
            MainFlowLayout.TabIndex = 3;
            // 
            // MainExit
            // 
            MainExit.AutoSize = true;
            MainExit.Font = new Font("Book Antiqua", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainExit.ForeColor = Color.Gray;
            MainExit.Location = new Point(261, 46);
            MainExit.Name = "MainExit";
            MainExit.Size = new Size(67, 23);
            MainExit.TabIndex = 4;
            MainExit.Text = "Выход";
            MainExit.Click += MainExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(50, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 35, 55);
            Controls.Add(pictureBox1);
            Controls.Add(MainExit);
            Controls.Add(MainFlowLayout);
            Controls.Add(MainAdd);
            Controls.Add(MainSearch);
            Controls.Add(MainUsername);
            ForeColor = SystemColors.Control;
            Name = "MainPage";
            Size = new Size(1055, 747);
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainUsername;
        private TextBox MainSearch;
        private Button MainAdd;
        private FlowLayoutPanel MainFlowLayout;
        private Label MainExit;
        private PictureBox pictureBox1;
    }
}
