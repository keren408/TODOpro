using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Model;
using System.Windows.Input;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows;
using BE;

namespace PL.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        MainWindowModel model;
        ICommand newTodoCommand;
        ICommand topicCommand;
        ICommand dateCommand;
        ICommand deleteTodoCommand;
        ICommand viewAllTodoCommand;
        ICommand updateTodoCommand;
        Page currentPage;
        //Page changeTodo;
        public static EventHandler doneAddingTodo;
        public MainWindowViewModel()
        {
            this.model = new MainWindowModel(this);
            NewTodoCommand = new CommandHandler(addTodoAction , true);
            TopicCommand = new CommandHandler(SearchByTopicAction , true);
            DateCommand = new CommandHandler(SearchByDateAction, true);
            DeleteTodoCommand = new CommandHandler(DeleteTodo, true);
            ViewAllTodoCommand = new CommandHandler(viewAllTodo, true);
            UpdateTodoCommand = new CommandHandler(UpdateTodo, true);
            CurrentPage = new Views.DisplayMyTodo();
            doneAddingTodo += navigatingToDisplayPage;
        }

        private void viewAllTodo()
        {
            navigatingToDisplayPage(null,null);
        }

        public ICommand NewTodoCommand
        {
            get
            {
                return newTodoCommand;
            }
            private set
            {
                newTodoCommand = value;
            }
        }
        public ICommand TopicCommand
        {
            get
            {
                return topicCommand;
            }
            private set
            {
                topicCommand = value;
            }
        }
        public ICommand DateCommand
        {
            get
            {
                return dateCommand;
            }
            private set
            {
                dateCommand = value;
            }
        }
        public ICommand DeleteTodoCommand
        {
            get
            {
                return deleteTodoCommand;
            }
            set
            {
                deleteTodoCommand = value;
            }
        }
        public ICommand UpdateTodoCommand
        {
            get
            {
                return updateTodoCommand;
            }
            set
            {
                updateTodoCommand = value;
            }
        }
        public ICommand ViewAllTodoCommand
        {
            get
            {
                return viewAllTodoCommand;
            }
            set
            {
                viewAllTodoCommand = value;
            }
        }

        private void SearchByDateAction()
        {
            BE.DatesWrapper wrapper = new BE.DatesWrapper();
            (new Views.searchByDate(wrapper)).ShowDialog();

            CurrentPage = new Views.DisplayMyTodo(wrapper.startDate, wrapper.endDate);
        }

        private void DeleteTodo()
        {
            TodoItem item = getSelectedItem();
            model.delete(item);
            navigatingToDisplayPage(null, null);            
        }

        private TodoItem getSelectedItem()
        {
            Views.DisplayMyTodo thisPage = null;
            if (currentPage is Views.DisplayMyTodo)
            {
                thisPage = currentPage as Views.DisplayMyTodo;

                DisplayMyTodoViewModel vm = thisPage.getViewModel();
                TodoItem item = vm.CurrentSelected;
                return item;

            }
            else
                return null;
        }

        private void UpdateTodo()
        {
            TodoItem item = getSelectedItem();
            navigatingToDisplayOneTodoPage(item);
            //navigatingToDisplayPage(null, null);
        }
            
        private void SearchByTopicAction()
        {
            BE.StringWrapper wrapper = new BE.StringWrapper();
           (new Views.searchByTopic(wrapper)).ShowDialog();
            if (wrapper.topic != null)
                CurrentPage = new Views.DisplayMyTodo(wrapper.topic);
            else
            {
                CurrentPage = new Views.DisplayMyTodo();
                //MessageBox.Show("you must fill the topic");
            }
        }

        public void addTodoAction()
        {
            //move to addtodo page  
            CurrentPage = new Views.AddTodoPage();
        }

        private void navigatingToDisplayPage(object sender, EventArgs e)
        {
            CurrentPage = new Views.DisplayMyTodo();
        }


        private void navigatingToDisplayOneTodoPage(TodoItem item)
        {
            if (item != null)
                CurrentPage = new Views.DisplayOneTodoPage(new TodoItem(item));
        }

        public Page CurrentPage {
            get
            {
                return currentPage;
            }
            set {
                currentPage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPage"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
   
    }
}
