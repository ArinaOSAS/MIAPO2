using System.Collections.Generic;
using System.Linq;

namespace Films._1;

public static class ChangeStatus
{
    public static List<Movie> ChangeStatusYes(Movie selectFilm)
    {
        if (selectFilm.Fkstatus == 2)
        {
            new DBFilmsContext().Movies.First(a => a.Idmovie == selectFilm.Idmovie).Fkstatus = 1;//Заполнение таблицы)
            new DBFilmsContext().SaveChanges();   
        }
        return new DBFilmsContext().Movies.ToList();
    }

}
