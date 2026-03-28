namespace pp_notes
{
    partial class NoteDetail
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
            NDTitle = new Label();
            NDText = new Label();
            NDBack = new Label();
            NDEdit = new Label();
            SuspendLayout();
            // 
            // NDTitle
            // 
            NDTitle.AutoSize = true;
            NDTitle.Font = new Font("Book Antiqua", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NDTitle.ForeColor = Color.White;
            NDTitle.Location = new Point(98, 103);
            NDTitle.Name = "NDTitle";
            NDTitle.Size = new Size(132, 38);
            NDTitle.TabIndex = 0;
            NDTitle.Text = "NDTitle";
            // 
            // NDText
            // 
            NDText.AutoSize = true;
            NDText.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NDText.ForeColor = Color.White;
            NDText.Location = new Point(103, 173);
            NDText.Name = "NDText";
            NDText.Size = new Size(88, 27);
            NDText.TabIndex = 1;
            NDText.Text = "NDText";
            // 
            // NDBack
            // 
            NDBack.AutoSize = true;
            NDBack.Font = new Font("Book Antiqua", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NDBack.ForeColor = Color.Gray;
            NDBack.Location = new Point(103, 56);
            NDBack.Name = "NDBack";
            NDBack.Size = new Size(72, 26);
            NDBack.TabIndex = 2;
            NDBack.Text = "Назад";
            NDBack.Click += NDBack_Click;
            // 
            // NDEdit
            // 
            NDEdit.AutoSize = true;
            NDEdit.Font = new Font("Book Antiqua", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NDEdit.ForeColor = Color.Gray;
            NDEdit.Location = new Point(781, 56);
            NDEdit.Name = "NDEdit";
            NDEdit.Size = new Size(109, 26);
            NDEdit.TabIndex = 3;
            NDEdit.Text = "Изменить";
            NDEdit.Click += NDEdit_Click;
            // 
            // NoteDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 35, 55);
            Controls.Add(NDEdit);
            Controls.Add(NDBack);
            Controls.Add(NDText);
            Controls.Add(NDTitle);
            Name = "NoteDetail";
            Size = new Size(986, 700);
            Load += NoteDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NDTitle;
        private Label NDText;
        private Label NDBack;
        private Label NDEdit;
    }
}
