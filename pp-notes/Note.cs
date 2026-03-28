using System;
using System.Collections.Generic;
using System.Text;

namespace pp_notes
{
    public class Note
    {

        int id = -1;
        string title;
        string text;
        User author;

        public string Title
        {
            get { return this.title; } set { this.title = value; }
        }

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public User Author
        {
            get { return this.author; }
        }


        public Note(int id, string title, string text, User author)
        {
            this.id = id;
            this.title = title;
            this.text = text;
            this.author = author;
        }

    }
}
