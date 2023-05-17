using System.Collections.Generic;
using System.Linq;

namespace Films._1;

public static class ConclusionDataGrid
{
    public static List<Movie> GridData()
    {
        return new DBFilmsContext().Movies.ToList();
    }
    public static List<Genre> ComboBox()
    {
        return new DBFilmsContext().Genres.ToList();
    }
}
