using Tasknator.Communication.Enums;

namespace Tasknator.Communication.Responses;

public class TaskShortResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Priority Prioridade { get; set; }
    public Status Status { get; set; }
}
