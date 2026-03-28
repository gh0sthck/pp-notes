namespace pp_notes
{
    partial class NoteEdit
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
            NETitle = new TextBox();
            NEText = new TextBox();
            NEConfirm = new Label();
            NEBack = new Label();
            NEDelete = new Label();
            SuspendLayout();
            // 
            // NETitle
            // 
            NETitle.BackColor = Color.FromArgb(77, 75, 101);
            NETitle.BorderStyle = BorderStyle.None;
            NETitle.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NETitle.ForeColor = Color.White;
            NETitle.Location = new Point(108, 119);
            NETitle.Name = "NETitle";
            NETitle.Size = new Size(329, 26);
            NETitle.TabIndex = 0;
            // 
            // NEText
            // 
            NEText.BackColor = Color.FromArgb(77, 75, 101);
            NEText.BorderStyle = BorderStyle.None;
            NEText.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NEText.ForeColor = Color.White;
            NEText.Location = new Point(108, 193);
            NEText.Multiline = true;
            NEText.Name = "NEText";
            NEText.Size = new Size(699, 435);
            NEText.TabIndex = 1;
            // 
            // NEConfirm
            // 
            NEConfirm.AutoSize = true;
            NEConfirm.Font = new Font("Book Antiqua", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NEConfirm.ForeColor = Color.Gray;
            NEConfirm.Location = new Point(108, 50);
            NEConfirm.Name = "NEConfirm";
            NEConfirm.Size = new Size(140, 26);
            NEConfirm.TabIndex = 3;
            NEConfirm.Text = "Подтвердить";
            NEConfirm.Click += NEConfirm_Click;
            // 
            // NEBack
            // 
            NEBack.AutoSize = true;
            NEBack.Font = new Font("Book Antiqua", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NEBack.ForeColor = Color.Gray;
            NEBack.Location = new Point(735, 50);
            NEBack.Name = "NEBack";
            NEBack.Size = new Size(72, 26);
            NEBack.TabIndex = 4;
            NEBack.Text = "Назад";
            NEBack.Click += NEBack_Click;
            // 
            // NEDelete
            // 
            NEDelete.AutoSize = true;
            NEDelete.Font = new Font("Book Antiqua", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NEDelete.ForeColor = Color.IndianRed;
            NEDelete.Location = new Point(712, 97);
            NEDelete.Name = "NEDelete";
            NEDelete.Size = new Size(95, 26);
            NEDelete.TabIndex = 5;
            NEDelete.Text = "Удалить";
            // 
            // NoteEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 35, 55);
            Controls.Add(NEDelete);
            Controls.Add(NEBack);
            Controls.Add(NEConfirm);
            Controls.Add(NEText);
            Controls.Add(NETitle);
            Name = "NoteEdit";
            Size = new Size(986, 700);
            Load += NoteEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NETitle;
        private TextBox NEText;
        private Label NEConfirm;
        private Label NEBack;
        private Label NEDelete;
    }
}
