using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace DAL
{
    public class TodoDB
    {
        static int id = 0;
        public TodoDB()
        {

        }
        public TodoItem getTodo(int ida)
        {
            foreach (var item in Class1.list)
            {
                if (item.Id == ida.ToString())
                {
                    return new TodoItem(item);
                }
            }
            return Class1.list[0];
        }
        public bool addTodo(TodoItem item)
        {
            try
            {
                item.Id = (id++).ToString();
                Class1.list.Add(item);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool deleteTodo(int id)
        {
            try
            {
                foreach (var item in Class1.list)
                {
                    if (item.Id == id.ToString())
                    {
                        Class1.list.Remove(item);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool updateTodo(TodoItem item)
        {
            try
            {
                deleteTodo(int.Parse(item.Id));
                Class1.list.Add(item);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<TodoItem> getAllTodo()
        {
            return Class1.list;
        }
        public List<TodoItem> getAllTodo(Predicate<TodoItem> filter)
        {
           // return Class1.list.FindAll(x => filter(x));
            List<TodoItem> list = Class1.list;
            List<TodoItem> newList = new List<TodoItem>();
            foreach (var item in list)
            {
                if (filter(item))
                    newList.Add(item);
            }
            return newList;
        }
    }
}
