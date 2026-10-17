using System.Collections.Generic;
using System.Linq;
using Sistema_Biblioteca.Data;
using Sistema_Biblioteca.Modelos;

namespace Sistema_Biblioteca.Controladores;

public static class CatalogoLibrosControlador
{
    public static List<CatalogoLibrosListadoModelo> GetAll()
    {
        using var context = new LibraryContext();

        return (
            from catalogo in context.CatalogoLibros
            join libro in context.Libros
                on catalogo.id_libros equals libro.id_libros
            select new CatalogoLibrosListadoModelo
            {
                id_catalogolibros = catalogo.id_catalogolibros,
                id_libros = catalogo.id_libros,
                titulo = libro.titulo,
                codigo_ejemplar = catalogo.codigo_ejemplar,
                ubicacion_estante = catalogo.ubicacion_estante,
                numero_edicion = catalogo.numero_edicion,
                disponible = catalogo.disponible,
                estado = catalogo.estado,
                fecha_registro = catalogo.fecha_registro
            }
        ).ToList();
    }

    public static void Create(CatalogoLibrosModelo catalogo)
    {
        using var context = new LibraryContext();
        context.CatalogoLibros.Add(catalogo);
        context.SaveChanges();
    }

    public static void Update(CatalogoLibrosModelo catalogo)
    {
        using var context = new LibraryContext();
        context.CatalogoLibros.Update(catalogo);
        context.SaveChanges();
    }
}
