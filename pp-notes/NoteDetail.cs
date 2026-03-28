using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pp_notes
{
    public partial class NoteDetail : UserControl
    {
        public Note note;
        public event Action? OnBack;
        public event Action? OnEdit;

        public NoteDetail()
        {
            InitializeComponent();
        }

        private void NoteDetail_Load(object sender, EventArgs e)
        {
            NDTitle.Text = note.Title;
            NDText.Text = note.Text;
        }

        private void NDBack_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke();
        }

        private void NDEdit_Click(object sender, EventArgs e)
        {
            OnEdit?.Invoke();
        }
    }
}
