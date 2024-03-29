﻿namespace Prototype
{
    internal class Items
    {
        public string Title { get; set; } //Auto-gen Properties
        public string Author { get; set; }
        public int Id { get; set; }
        public Items(string title, 
                       string author, 
                       int id)
        {
            Title = title;
            Author = author;
            Id = id;
        }

        public override string? ToString()
        {
            return $"Title: { Title } \nAuthor: { Author } \nID: { Id } ";
        }

    }
}
