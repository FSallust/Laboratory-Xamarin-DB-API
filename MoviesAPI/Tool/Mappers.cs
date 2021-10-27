using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer = DAL.models;
using API = MoviesAPI.Models;

namespace DemoAPI.Tools
{
    public static class Mappers
    {
        public static API.Movie ToAPI(this DataAccessLayer.Movie c)
        {
            return new API.Movie
            {
                Id = c.Id,
                Title = c.Title,
                ReleaseYear = c.ReleaseYear,
                Synopsis = c.Synopsis,
                PosterUrl = c.PosterUrl,
                RealisatorId = c.RealisatorId,
                ScenaristId = c.ScenaristId,
                CategoryId = c.CategoryId,
                PersonalComment = c.PersonalComment
            };
        }

        public static DataAccessLayer.Movie ToDAL(this API.Movie c)
        {
            return new DataAccessLayer.Movie
            {
                Id = c.Id,
                Title = c.Title,
                ReleaseYear = c.ReleaseYear,
                Synopsis = c.Synopsis,
                PosterUrl = c.PosterUrl,
                RealisatorId = c.RealisatorId,
                ScenaristId = c.ScenaristId,
                CategoryId = c.CategoryId,
                PersonalComment = c.PersonalComment
            };
        }

        public static API.Casting ToAPI(this DataAccessLayer.Casting c)
        {
            return new API.Casting
            {
                Id = c.Id,
                MovieId = c.MovieId,
                PersonId = c.PersonId,
                Role = c.Role
            };
        }

        public static DataAccessLayer.Casting ToDAL(this API.Casting c)
        {
            return new DataAccessLayer.Casting
            {
                Id = c.Id,
                MovieId = c.MovieId,
                PersonId = c.PersonId,
                Role = c.Role
            };
        }

        public static API.Person ToAPI(this DataAccessLayer.Person c)
        {
            return new API.Person
            {
                Id = c.Id,
                LastName = c.LastName,
                FirstName = c.FirstName,
                PictureUrl = c.PictureUrl
            };
        }

        public static DataAccessLayer.Person ToDAL(this API.Person c)
        {
            return new DataAccessLayer.Person
            {
                Id = c.Id,
                LastName = c.LastName,
                FirstName = c.FirstName,
                PictureUrl = c.PictureUrl
            };
        }

        public static API.Category ToAPI(this DataAccessLayer.Category c)
        {
            return new API.Category
            {
                Id = c.Id,
                NameCat = c.NameCat
            };
        }

        public static DataAccessLayer.Category ToDAL(this API.Category c)
        {
            return new DataAccessLayer.Category
            {
                Id = c.Id,
                NameCat = c.NameCat
            };
        }
    }
}
