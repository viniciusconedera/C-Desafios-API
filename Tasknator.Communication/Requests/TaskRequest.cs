using Tasknator.Communication.Enums;

namespace Tasknator.Communication.Requests;

public class TaskRequest
{
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public Priority Prioridade { get; set; }
    public DateTime? DataFinal { get; set; }
    public Status Status { get; set; }
}
