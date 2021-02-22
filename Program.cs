using System;
using System.Linq;
using tarea1Backend.modelos;

namespace tarea1Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext db = new NorthwindContext();

            var categorias = db.Categories;
            var categoriasLista = categorias.Select(x => x).ToList();

            categoriasLista.ForEach(x => Console.WriteLine(x.CategoryName));

            Console.WriteLine("/////////////////////////");


            var queryCustomer = new NorthwindContext().Customers.AsQueryable();
            var outpur = queryCustomer.ToList();


            outpur.ForEach(x => Console.WriteLine(x.CompanyName));

            var queryCategorias = new NorthwindContext().Categories.Select(x => new { 
                 x.CategoryId,
                 x.CategoryName,
                 x.Description
            }).AsQueryable();

            var salida = queryCategorias.ToList();

            salida.ForEach(x => Console.WriteLine("IDcategoria = "+x.CategoryId +" NombreCategoria = "+x.CategoryName+"  Descripcion="+x.Description));




            Console.ReadLine();
        }
    }
}
