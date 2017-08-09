using BE;
using PL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PL.ViewModel
{
    class DisplayOneTodoViewModel : INotifyPropertyChanged
    {
        DisplayOneTodoModel model;
        List<BE.TodoItem> itemList;
        TodoItem currentSelected;

        string id;
        string title;
        string desc;
        string address;
        string color;
        DateTime date = DateTime.Now;
        DateTime whenToRemind = DateTime.Now;
        //ICommand saveCommand;
        ICommand saveCommand;
        BE.colors platteColor;
        BE.TodoItem current = new TodoItem();

        public DisplayOneTodoViewModel(TodoItem item)
        {
            this.model = new DisplayOneTodoModel(this);

            this.Title = item.Title;
            this.Desc = item.Description;
            this.Color = item.Color;
            this.Id = item.Id;
            this.Address = item.Address;
            this.Date = item.Date.ToString("dd-MM-yyyy HH:mm");
            this.WhenToRemind = item.WhenToRemind.ToString("dd-MM-yyyy HH:mm");

            saveCommand = new CommandHandler(saveCurrentTodo, true);
            //current = item;
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
        private void saveCurrentTodo()
        {
            model.updateTodo(current);
            setColor(Views.ColorPlatte.color);
            MainWindowViewModel.doneAddingTodo(this, null);
        }

        public ICommand SaveCommand
        {
            get => saveCommand;
        }

        public string Id{ get => id; set { current.Id = value; id = value; } }
        public string Title { get => title; set { current.Title = value; title = value; } }
        public string Desc { get => desc; set { current.Description = value; desc = value; } }
        public string Address { get => address; set { current.Address = value; address = value; } }
        public string Color { get => color; set { current.Color = value; color = value; } }
        public string Date { get => date.ToString("dd-MM-yyyy HH:mm"); set { current.Date = Convert.ToDateTime(value); date = Convert.ToDateTime(value); } }
        public string WhenToRemind { get => whenToRemind.ToString("dd-MM-yyyy HH:mm"); set { current.WhenToRemind = Convert.ToDateTime(value); whenToRemind = Convert.ToDateTime(value); } }



        public List<TodoItem> ItemList { get => itemList; set { itemList = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemList")); } }

        public TodoItem CurrentSelected { get => currentSelected; set { currentSelected = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentSelected")); } }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
