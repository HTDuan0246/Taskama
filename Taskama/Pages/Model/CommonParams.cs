namespace Taskama.Pages.Model
{
    public enum TaskStatus
    {
        Backlog = 0,
        Todo = 1,
        InProgress = 2,
        Review = 3,
        Done = 4,
        Cancelled = 5
    }

    public enum Priority
    {
        Low = 0,
        Medium = 1,
        High = 2,
        Critical = 3
    }

    public enum ProjectStatus
    {
        Planning = 0,
        Active = 1,
        OnHold = 2,
        Completed = 3,
        Cancelled = 4
    }

    public enum ProjectMemberRole
    {
        Viewer = 0,
        Member = 1,
        Admin = 2,
        Owner = 3
    }
}