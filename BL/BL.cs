using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using BE;


namespace BL
{
    public class BL
    {
        TodoDBef DB;
        public BL()
        {
            DB = DAL.Factory.getFactoryDB();
        }
        public TodoItem getTodo(int id)
        {
            return DB.getTodo(id);
        }
        public bool addTodo(TodoItem item)
        {
            if ((string.IsNullOrEmpty(item.Title) || string.IsNullOrEmpty(item.Description) || string.IsNullOrEmpty(item.Address) || string.IsNullOrEmpty(item.Color))) return false;
            return DB.addTodo(item);
        }
        public bool deleteTodo(int id)
        {
            return DB.deleteTodo(id);
        }
        public bool updateTodo(TodoItem item)
        {
            return DB.updateTodo(item);
        }
        public List<TodoItem> getAllTodo(Predicate<TodoItem> filter)
        {
            return DB.getAllTodo(filter);
        }
        public List<TodoItem> getAllTodo()
        {
            return DB.getAllTodo();
        }
    }
}
