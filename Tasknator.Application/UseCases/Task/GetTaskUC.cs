using Tasknator.Communication.Responses;
using Tasknator.Communication.Enums;

namespace Tasknator.Application.UseCases.Task;

public class GetTaskUC
{
    public TaskGetResponse Execute(int id)
    {
        TaskGetResponse response = new TaskGetResponse()
        {
            Id = id,
            Nome = "teste",
            Descricao = "tafera blabal",
            Prioridade = Priority.baixa,
            Status = Status.em_andamento,
            DataFinal = DateTime.Now,
        };
        return response;
    }
}
