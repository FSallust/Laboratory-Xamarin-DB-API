using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface ICastingService
    {
        IEnumerable<Casting> GetAll();

        IEnumerable<Casting> GetByMovieId(int Id);
    }
}
