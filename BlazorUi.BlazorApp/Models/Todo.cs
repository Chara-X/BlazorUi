namespace BlazorUi.BlazorApp.Models;

public class Todo
{
    public Guid Id { get; set; }
    public TodoType TodoType { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public DateTime CreateTime { get; set; }

    public Todo(Guid id, TodoType todoType, string? title, string? content)
    {
        Id = id;
        TodoType = todoType;
        Title = title;
        Content = content;
        CreateTime = DateTime.Now;
    }

    public Todo()
    {
        Id = Guid.NewGuid();
        CreateTime = DateTime.Now;
    }
}

public enum TodoType
{
    Life = 0,
    Study = 1,
    Work = 2,
}