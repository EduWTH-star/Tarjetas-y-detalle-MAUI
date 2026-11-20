using CatalogoMaui.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoMaui.ViewModels
{
    internal class CatalogoViewModels
    {
        public List<Producto> Productos { get; } = new() {

                new Producto{
                Nombre = "Mochila",
                Descripcion = "Mochila para el uso escolar",
                Detalle = "Mochila de uso diario, con varios compartimientos y demas cosas aca chilas",
                Precio = 499.99m,
                Foto = "mochila.png"
                },

                 new Producto
                 {
                 Nombre = "Libreta A5",
                 Descripcion = "Libreta de 80 hojas.",
                 Detalle = "Libreta tamaño A5 con 80 hojas rayadas y pasta dura para proteger tus apuntes.",
                 Precio = 89.50m,
                 Foto = "cuaderno.png"
                 },

                new Producto
                {
                    Nombre = "Termo de acero",
                    Descripcion = "Botella reutilizable de 500 ml.",
                    Detalle = "Termo fabricado en acero con capacidad de 500 ml, ideal para transportar bebidas.",
                    Precio = 219.00m,
                    Foto = "termo.png"
                },

                new Producto
                {
                Nombre = "Audífonos RZ3000",
                Descripcion = "Audífonos inalámbricos.",
                Detalle = "Audífonos inalámbricos diseñados para escuchar música y atender llamadas.",
                Precio = 349.00m,
                Foto = "audifonos.jpg"
                }
        };
    }
}
