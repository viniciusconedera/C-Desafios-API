using Tasknator.Communication.Enums;

namespace Tasknator.Communication.Responses;

public class TaskGetResponse
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public Priority Prioridade { get; set; }
    public DateTime? DataFinal { get; set; }
    public Status Status { get; set; }
}
