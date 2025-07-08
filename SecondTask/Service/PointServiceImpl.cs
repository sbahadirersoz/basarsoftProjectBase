using basarsoftProjectBase.FirstTask;
using basarsoftProjectBase.SecondTask.Dtos;

namespace basarsoftProjectBase.SecondTask.Service;

public class PointServiceImpl:IPointService
{
    /// <summary>
    /// Burdaki methodlar örnek olarak yazılmıştır lütfen kendiniz araştırarak doldurunuz
    /// Bu proje sadece Projenin nasıl ilerleyeceğini göstermek amaçlıdır
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public bool existById(long id)
    {
        
        return true;
    }
/// <summary>
/// Bu örnek bir methoddur Diğer delete update find create methodlarını siz doldurunuz
/// </summary>
/// <param name="id"></param>
/// <param name="list"></param>
/// <returns></returns>
/// <exception cref="Exception"></exception>
    public bool deleteById(PointDeleteByIdRequestDto dto, List<TaskPoint> list)
    {
        var point =  list.FirstOrDefault(t => t.id == dto.id);
        if (point != null)
        {
            list.Remove(point);
            return true;
        }

        throw new Exception("burda bir exception firlatilmalı");
    }

}