using basarsoftProjectBase.FirstTask;
using basarsoftProjectBase.SecondTask.Dtos;
using basarsoftProjectBase.SecondTask.Service;
using Microsoft.AspNetCore.Mvc;

namespace basarsoftProjectBase.SecondTask;

[ApiController]
[Route("/api/[controller]")]
public class SecondTaskController : Controller
{
    private readonly IPointService _service ;
    private static List<TaskPoint> pointList = new();
    public async Task<bool> Delete(PointDeleteByIdRequestDto dto)
    {
        return _service.deleteById(dto, pointList);
    }

}