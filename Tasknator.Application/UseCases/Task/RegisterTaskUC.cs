using Tasknator.Communication.Requests;
using Tasknator.Communication.Responses;

namespace Tasknator.Application.UseCases.Task;

public class RegisterTaskUC
{
    public TaskRegisterResponse Execute(TaskRequest request)
    {
        TaskRegisterResponse response = new TaskRegisterResponse()
        {
            Id = 1,
            Nome = request.Nome
        };
        return response;
    }
}
