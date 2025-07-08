using basarsoftProjectBase.FirstTask;
using basarsoftProjectBase.SecondTask.Dtos;

namespace basarsoftProjectBase.SecondTask.Service;

public interface IPointService
{
 public bool existById(long id);
 public bool deleteById(PointDeleteByIdRequestDto dto ,List<TaskPoint > list);
}