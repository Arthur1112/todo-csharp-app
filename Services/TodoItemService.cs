using Models;

namespace Services;

public interface ITodoItemService
{
  Task<IEnumerable<TodoItem>> GetAllTodoItems();
  Task<TodoItem>GetTodoItemById(string id);
  Task<TodoItem>UpdateTodoItem(string id, TodoItem todoItem);

  Task<TodoItem> CreateTodoItem(TodoItem todoItem);
}

public class TodoItemService : ITodoItemService
{
  public Task<TodoItem> CreateTodoItem(TodoItem todoItem)
  {
    throw new NotImplementedException();
  }

  public Task<IEnumerable<TodoItem>> GetAllTodoItems()
  {
    throw new NotImplementedException();
  }

  public Task<TodoItem> GetTodoItemById(string id)
  {
    throw new NotImplementedException();
  }

  public Task<TodoItem> UpdateTodoItem(string id, TodoItem todoItem)
  {
    throw new NotImplementedException();
  }
}