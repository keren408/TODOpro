using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Model;
using System.Windows.Input;
using System.ComponentModel;
using BE;

namespace PL.ViewModel
{
    public class AddTodoViewModel : INotifyPropertyChanged
    {
        AddTodoModel model;
        string title;
        string desc;
        string address;
        string color;
        DateTime date = DateTime.Now;
        DateTime whenToRemind = DateTime.Now;
        ICommand saveCommand;
        BE.colors platteColor;
        BE.TodoItem current;
        //bool clickable = false;

        public event PropertyChangedEventHandler PropertyChanged;

        public AddTodoViewModel()
        {
            this.model = new AddTodoModel(this);
            current = new BE.TodoItem();
            saveCommand = new CommandHandler(saveCurrentTodo, true);
        }
        /// <summary>
        /// Saving The Current Todo
        /// </summary>
        private void saveCurrentTodo()
        {
            model.addTodo(current);
            setColor(Views.ColorPlatte.color);
            MainWindowViewModel.doneAddingTodo(this, null);
        }

        public string Title { get => title; set { current.Title = value; title = value; } }
        public string Desc { get => desc; set { current.Description = value; desc = value; } }
        public string Address { get => address; set { current.Address = value; address = value; } }
        public string Color { get => color; set { current.Color = value; color = value; } }
        public string Date { get => date.ToString("dd-MM-yyyy HH:mm"); set { current.Date = Convert.ToDateTime(value); date = Convert.ToDateTime(value); } }
        public string WhenToRemind { get => whenToRemind.ToString("dd-MM-yyyy HH:mm"); set { current.WhenToRemind = Convert.ToDateTime(value); whenToRemind = Convert.ToDateTime(value); } }
        //public bool Clickable { get => check(); }
        //bool check()
        //{
        //    return (!(string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Desc) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Color)));
        //}

        public ICommand SaveCommand
        {
            get => saveCommand;
        }
       
        public colors PlatteColor
        {
            get => platteColor;
            set { setColor(value); platteColor = value; }
        }

        //public DateTime Date { get => date; set { current.Date = value; date = value; } }
        //public DateTime WhenToRemind { get => whenToRemind; set { current.WhenToRemind = value; whenToRemind = value; } }
        public void setColor(BE.colors color)
        {
            int x = 5;
            switch (color)
            {
                case colors.RED: // red
                    current.Color = "#c62828";
                    break;
                case colors.YELLOW: //yellow
                    current.Color = "#ffc400";
                    break;
                case colors.GREEN: // green
                    current.Color = "#00c853";
                    break;
                case colors.BLUE: // blue
                    current.Color = "#2979ff";
                    break;
                case colors.PINK: // pink
                    current.Color = "#f50057";
                    break;
                case colors.PURPLE: // purple
                    current.Color = "#aa00ff";
                    break;
            }
        }
    }
}
