using System.Collections.Generic;
using System.Linq;

namespace Films._1;

public static class Search
{
    public static List<Movie> SearchText(string textToSearch)
    {
        return new DBFilmsContext().Movies.Where(a => a.Namemovie.StartsWith(textToSearch)).ToList();
    }
}