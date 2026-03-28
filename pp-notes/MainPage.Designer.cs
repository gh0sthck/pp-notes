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
            SuspendLayout();
            // 
            // MainUsername
            // 
            MainUsername.AutoSize = true;
            MainUsername.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MainUsername.Location = new Point(119, 40);
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
            MainSearch.Location = new Point(719, 37);
            MainSearch.Multiline = true;
            MainSearch.Name = "MainSearch";
            MainSearch.PlaceholderText = "Поиск";
            MainSearch.Size = new Size(212, 29);
            MainSearch.TabIndex = 1;
            // 
            // MainAdd
            // 
            MainAdd.BackColor = Color.FromArgb(60, 60, 77);
            MainAdd.FlatAppearance.BorderSize = 0;
            MainAdd.FlatStyle = FlatStyle.Flat;
            MainAdd.Font = new Font("Book Antiqua", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainAdd.ForeColor = Color.FromArgb(149, 149, 159);
            MainAdd.Location = new Point(521, 37);
            MainAdd.Name = "MainAdd";
            MainAdd.Size = new Size(168, 29);
            MainAdd.TabIndex = 2;
            MainAdd.Text = "+ Запись";
            MainAdd.UseVisualStyleBackColor = false;
            // 
            // MainFlowLayout
            // 
            MainFlowLayout.AutoScroll = true;
            MainFlowLayout.Location = new Point(50, 102);
            MainFlowLayout.Margin = new Padding(5);
            MainFlowLayout.Name = "MainFlowLayout";
            MainFlowLayout.Size = new Size(896, 578);
            MainFlowLayout.TabIndex = 3;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 35, 55);
            Controls.Add(MainFlowLayout);
            Controls.Add(MainAdd);
            Controls.Add(MainSearch);
            Controls.Add(MainUsername);
            ForeColor = SystemColors.Control;
            Name = "MainPage";
            Size = new Size(986, 700);
            Load += MainPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainUsername;
        private TextBox MainSearch;
        private Button MainAdd;
        private FlowLayoutPanel MainFlowLayout;
    }
}
