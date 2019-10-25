using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALayer
    {
        db_america_virtual_exerciseEntities en = new db_america_virtual_exerciseEntities();

        public ListaProduct ObtenerProduct(int Id)
        {
            ListaProduct prodList = new ListaProduct();
            var tableProd = from product in en.Product where product.Id == Id select product;
            ProductDTO pdto = new ProductDTO();
            foreach (var reg in tableProd)
            {
                pdto.Id = Id; //or reg.Id;
                pdto.ProductName = reg.ProductName;
                pdto.PrecioUnitario = reg.PrecioUnitario;
                pdto.Imagen = reg.Imagen;
                pdto.CategoryId = reg.CategoryId; //Otra forma pero mmm   pdto.Category.Id = reg.Categories.Id;
                //Agregamos a la lista el producto encontrado por Id
                prodList.Add(pdto);
            }
            return prodList;
        }

        public ListaProduct ObtenerProductTodos()
        {
            ListaProduct prodList = new ListaProduct();
            var tableProd = from product in en.Product select product;
            ProductDTO pdto = new ProductDTO();
            foreach (var reg in tableProd)
            {
                pdto.Id = reg.Id;
                pdto.ProductName = reg.ProductName;
                pdto.PrecioUnitario = reg.PrecioUnitario;
                pdto.Imagen = reg.Imagen;
                //Agregamos a la lista uno x uno los productos
                prodList.Add(pdto);
            }
            return prodList;
        }

        public ListaUsers ObtenerUser(string name)
        {
            ListaUsers userList = new ListaUsers();
            var tableUser = from users in en.AvUsers where users.UserName == name select users;

            UserDTO udto = new UserDTO();
            foreach (var reg in tableUser)
            {
                udto.Id = reg.Id;
                udto.UserEmail = reg.UserEmail;
                udto.UserStatus = reg.UserStatus;
                udto.UserName = reg.UserName;   /*Podría usar tambien name del parametro*/
                userList.Add(udto);             /*Agrego el usuario encontrado a la lista*/
            }
            return userList;
        }

        /* Agrego este metodo para obtener todos los User .. aunque America Virtual no lo solicita 
           pero como es una copia del anterior sin el where .. es rapido
        */
        public ListaUsers ObtenerUserTodos()
        {
            ListaUsers userList = new ListaUsers();
            var tableUser = from users in en.AvUsers select users;

            UserDTO udto = new UserDTO();
            foreach (var reg in tableUser)
            {
                udto.Id = reg.Id;
                udto.UserEmail = reg.UserEmail;
                udto.UserStatus = reg.UserStatus;
                udto.UserName = reg.UserName;
                userList.Add(udto);             /*Agrego el usuario encontrado a la lista*/
            }
            return userList;
        }


        public DALayer() { }

    }
}
