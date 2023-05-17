using System.Collections.Generic;
using System.Linq;

namespace Films._1;

public class Selection
{
    public static List<Movie> SelectionComboBox(Genre selectComboBox)
    {
        return new DBFilmsContext().Movies.Where(a => a.Fkgenre == selectComboBox.Idgenre).ToList();
    }

}