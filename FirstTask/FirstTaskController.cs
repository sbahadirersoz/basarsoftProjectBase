using Microsoft.AspNetCore.Mvc;

namespace basarsoftProjectBase.FirstTask;

[ApiController]
[Route("api/[controller]")]
public class FirstTaskController : Controller
{
    private readonly List<PointFirstTask> pointList = new();
    [HttpPost("create")]
    public Task<PointFirstTask> Create(PointFirstTask task)
    {
        pointList.Add(task);
        return Task.FromResult(task) ;
    }

    [HttpGet("{id:guid}")]
    public async Task<PointFirstTask> GetById(long  id)
    {
        var point =  pointList.FirstOrDefault(t => t.id == id);

        if (point != null)
        {
            return point;
        }

        throw new Exception("Hatalı");
    }

    [HttpGet("all")]
    public async Task<List<PointFirstTask>> GetAll()
    {
        return pointList;
    }

    [HttpDelete("{id:guid}")]
    public async Task<bool> Delete(long id)
    {
        var pointer = pointList.FirstOrDefault(t => t.id == id);
        if (pointer != null)
        {
            return true;
        }

        return false;
    }
    
    // Geri kalan Crud Operasyonları Ödev

}