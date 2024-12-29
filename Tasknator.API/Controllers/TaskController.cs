using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tasknator.Application.UseCases.Task;
using Tasknator.Communication.Requests;
using Tasknator.Communication.Responses;

namespace Tasknator.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(TaskRegisterResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ErrorsResponse), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] TaskRequest request)
    {
        RegisterTaskUC registerTask = new RegisterTaskUC();
        TaskRegisterResponse response = registerTask.Execute(request);
        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ErrorsResponse), StatusCodes.Status404NotFound)]
    public IActionResult Update([FromRoute] int id, [FromBody] TaskRequest request)
    {
        UpdateTaskUC updateTask = new UpdateTaskUC();
        updateTask.Execute(id, request);
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(TaskAllShortResponses), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        GetAllTaskUC getAllTask = new GetAllTaskUC();
        TaskAllShortResponses response = getAllTask.Execute();
        if (response.Tasks.Any())
        {
            return Ok(response);
        }
        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(TaskGetResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorsResponse), StatusCodes.Status404NotFound)]
    public IActionResult Get([FromRoute] int id)
    {
        GetTaskUC getTask = new GetTaskUC();
        TaskGetResponse response = getTask.Execute(id);
        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ErrorsResponse), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        DeleteTaskUC deleteTask = new DeleteTaskUC();
        deleteTask.Execute(id);
        return NoContent();
    }
}
