using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_StringBuilder.Entites
{
    class Post
    {
        public DateTime Moment { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public Post()
        {

        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddCommnet(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveCommnet(Comment comment)
        {
            Comments.Remove(comment);
        }
        public override string ToString()
        {   
            //buildar uma string sem concatenar 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes.ToString());
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);

            //percorrer a lista
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
