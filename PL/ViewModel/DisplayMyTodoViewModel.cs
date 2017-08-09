using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using PL.Model;
using System.ComponentModel;

namespace PL.ViewModel
{
    public class DisplayMyTodoViewModel : INotifyPropertyChanged
    {
        //string title;

        DisplayMyTodoModel model;
        List<BE.TodoItem> itemList;
        TodoItem currentSelected;
        public DisplayMyTodoViewModel()
        {
            this.model = new DisplayMyTodoModel(this);
            itemList = model.getAllTodo(/*(x) => true*/);
        }
        public DisplayMyTodoViewModel(DateTime start, DateTime end)
        {
            this.model = new DisplayMyTodoModel(this);
            itemList = model.getAllTodo((obj)=>obj.Date >= start && obj.Date <= end);
        }

        public DisplayMyTodoViewModel(string SearchSyTopic)
        {
            this.model = new DisplayMyTodoModel(this);
            itemList = model.getAllTodo((item)=>item.Title.Contains(SearchSyTopic));
        }
        public List<TodoItem> ItemList { get => itemList; set { itemList = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemList")); } }

        public TodoItem CurrentSelected { get => currentSelected; set { currentSelected = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentSelected")); } }
    
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
