using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TodoDBef
    {
        dbTodoContext context;
        static int id = 0;
        public TodoDBef()
        {
            context = new dbTodoContext();
            try
            {
                List<TodoItem> x = context.TodoItems.ToList();
                foreach (TodoItem item in x)
                {
                    if (int.Parse(item.Id) > id) id = int.Parse(item.Id);
                }
                id++;
            }
            catch(Exception ex)
            {

            }
        }
        public TodoItem getTodo(int ida)
        {
            foreach (var item in context.TodoItems.ToList())
            {
                if (item.Id == ida.ToString())
                {
                    return new TodoItem(item);
                }
            }
            return context.TodoItems.ToList()[0];
        }
        public bool addTodo(TodoItem item)
        {
            //try
            //{
                item.Id = (id++).ToString();
                context.TodoItems.Add(item);
                context.SaveChanges();
                return true;
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}
        }
        public bool deleteTodo(int id)
        {
            //try
            //{
                foreach (var item in context.TodoItems.ToList())
                {
                    if (item.Id == id.ToString())
                    {
                        context.TodoItems.Remove(item);
                        context.SaveChanges();
                    }
                }

                return true;
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}
        }
        public bool updateTodo(TodoItem item)
        {
            //try
            //{
                deleteTodo(int.Parse(item.Id));
                context.TodoItems.Add(item);
                context.SaveChanges();
                return true;
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}
        }
        public List<TodoItem> getAllTodo()
        {
            //try
            //{
                return context.TodoItems.ToList();
            //}
            //catch(Exception ex)
            //{
            //    return new List<TodoItem>();
            //}
        }
        public List<TodoItem> getAllTodo(Predicate<TodoItem> filter)
        {
            return context.TodoItems.ToList().FindAll(x => filter(x));
        }
    }
}
