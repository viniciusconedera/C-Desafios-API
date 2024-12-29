using Tasknator.Communication.Responses;
using Tasknator.Communication.Enums;

namespace Tasknator.Application.UseCases.Task;

public class GetAllTaskUC
{
    public TaskAllShortResponses Execute()
    {
        TaskAllShortResponses response = new TaskAllShortResponses()
        {
            Tasks = [
                new TaskShortResponse()
                {
                    Id = 1,
                    Name = "Test",
                    Status = Status.em_andamento,
                    Prioridade = Priority.media
                },
                new TaskShortResponse()
                {
                    Id = 1,
                    Name = "Fazer coisa",
                    Status = Status.concluida,
                    Prioridade = Priority.alta
                }
            ]
        };
        return response;
    }
}
