using IntroduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionCsharp.Services
{
    public class PeliculasService
    {
        public List<Pelicula> ObtenerPelicula()
        {
            var Pelicula1 = new Pelicula()
            {
                Titulo = "Superman",
                Duracion = 120,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 5)
            };
            var Pelicula2 = new Pelicula()
            {
                Titulo = "Spiderman",
                Duracion = 111,
                Pais = "USA",
                Publicacion = new DateTime(2015, 05, 5)
            };
            return new List<Pelicula> { Pelicula1,  Pelicula2 };
        }
    }
}