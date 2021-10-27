using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAll();

        IEnumerable<Movie> GetByCategoryId(int Id);
    }
}
