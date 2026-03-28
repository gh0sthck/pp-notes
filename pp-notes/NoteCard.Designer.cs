namespace pp_notes
{
    partial class NoteCard
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
            NoteCardTitle = new Label();
            NoteCardText = new Label();
            SuspendLayout();
            // 
            // NoteCardTitle
            // 
            NoteCardTitle.AutoSize = true;
            NoteCardTitle.Font = new Font("Book Antiqua", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NoteCardTitle.ForeColor = Color.White;
            NoteCardTitle.Location = new Point(24, 191);
            NoteCardTitle.Name = "NoteCardTitle";
            NoteCardTitle.Size = new Size(62, 23);
            NoteCardTitle.TabIndex = 0;
            NoteCardTitle.Text = "label1";
            // 
            // NoteCardText
            // 
            NoteCardText.AutoSize = true;
            NoteCardText.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NoteCardText.ForeColor = Color.White;
            NoteCardText.Location = new Point(24, 228);
            NoteCardText.Name = "NoteCardText";
            NoteCardText.Size = new Size(52, 20);
            NoteCardText.TabIndex = 1;
            NoteCardText.Text = "label2";
            // 
            // NoteCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 84, 122);
            Controls.Add(NoteCardText);
            Controls.Add(NoteCardTitle);
            Name = "NoteCard";
            Size = new Size(247, 278);
            Load += NoteCard_Load;
            Click += NoteCard_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NoteCardTitle;
        private Label NoteCardText;
    }
}
