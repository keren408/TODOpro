using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum colors { RED,YELLOW,GREEN,BLUE,PINK,PURPLE}
    public class TodoItem
    {
        private string address;
        private string place;
        private DateTime date = DateTime.Now;
        private DateTime whenToRemind = DateTime.Now;
        private string title;
        private string description;
        private string color;
        private string id;

        public TodoItem() { Color = "YELLOW"; }
        public TodoItem(TodoItem item)
        {
            this.Title = item.Title;
            this.Description = item.Description;
            this.Color = item.Color;
            this.Id = item.Id;
            this.Address = item.Address;
            this.Place = item.Place;
            this.Date = item.Date;
            this.WhenToRemind = item.WhenToRemind;
        }
        

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Color { get => color; set { color = value; } }
        public string Id { get => id; set => id = value; }
        public string Address { get => address; set => address = value; }
        public string Place { get => place; set => place = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime WhenToRemind { get => whenToRemind; set => whenToRemind= value; }




    }
}
