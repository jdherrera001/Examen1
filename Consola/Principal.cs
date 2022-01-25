using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;

namespace Consola
{
    class Principal
    {
        static void Main(string[] args)
        {
            //lista de categorias
            Category c1 = new Category()
            {
                Name = "Comedia",
                Last_update = new DateTime(2022,01,24),              
            };
            //lista de categorias
            Category c2 = new Category()
            {
                Name = "Accion",
                Last_update = new DateTime(2022, 01, 24),
            };
            //lista de actores
            Actor a1 = new Actor()
            {
                First_Name = "Robert",
                Last_Name = "De Niro",
                Last_update = new DateTime(2022, 01, 24),
            };
            Actor a2 = new Actor()
            {
                First_Name = "Brad",
                Last_Name = "Pitt",
                Last_update = new DateTime(2022, 01, 24),
            };
            Actor a3 = new Actor()
            {
                First_Name = "Harrison",
                Last_Name = "Ford",
                Last_update = new DateTime(2022, 01, 24),
            };
            //lista de film_actor
            Film_actor fa1 = new Film_actor()
            {
                Actor=a1,
                Film_Id=1,
                Last_Update = new DateTime(2022, 01, 24),
            };
            Film_actor fa2 = new Film_actor()
            {
                Actor = a2,
                Film_Id=2,
                Last_Update = new DateTime(2022, 01, 24),
            };
            Film_actor fa3 = new Film_actor()
            {
                Actor = a3,
                Film_Id=3,
                Last_Update = new DateTime(2022, 01, 24),
            };
            Film_actor fa4 = new Film_actor()
            {
                Actor = a3,
                Film_Id=4,
                Last_Update = new DateTime(2022, 01, 24),
            };
            Film_actor fa5 = new Film_actor()
            {
                Actor = a1,
                Film_Id=5,
                Last_Update = new DateTime(2022, 01, 24),
            };
            Film_actor fa6 = new Film_actor()
            {
                Actor = a2,
                Film_Id=6,
                Last_Update = new DateTime(2022, 01, 24),
            };

            //grabar las listas de datos
                 Repositorio repos = new Repositorio();

                 repos.categories.Add(c1);
                 repos.categories.Add(c1);

                 repos.film_actors.Add(fa1);
                 repos.film_actors.Add(fa2);
                 repos.film_actors.Add(fa3);
                 repos.film_actors.Add(fa4);
                 repos.film_actors.Add(fa5);
                 repos.film_actors.Add(fa6);

            repos.SaveChanges();
        }
        
        
    }
}