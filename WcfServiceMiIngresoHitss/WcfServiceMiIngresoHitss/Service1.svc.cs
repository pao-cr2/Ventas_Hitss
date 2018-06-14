using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceMiIngresoHitss.Modelo;

namespace WcfServiceMiIngresoHitss
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        HitssEntities3 datos;

        //ACCIONES DE LA CLASE PRODUCTO
        public Service1()
        {
            datos = new HitssEntities3();
        }

        public bool InsertProducto(Producto pro)
        {
            pro = new Producto
            {
                Descripcion_pro = pro.Descripcion_pro,
                PrecioUnitario = pro.PrecioUnitario,
                Id_Categoria = pro.Id_Categoria
         
            };

            datos.Producto.Add(pro);
            if (datos.SaveChanges() > 0)
            {
                return true;
            }
            return false;

        }


        public List<Producto> GetProductos()
        {
            //ORDER BY id DESC
            return datos.Producto.OrderByDescending(x => x.Id_Producto).ToList();
        }

        /*
        public List<Cliente> GetProductosDelimitador(int deliminador)
        {
            //SELECT TOP deliminador * FROM Contacto ORDER BY id DESC
            return datos.Producto.Take(deliminador).OrderByDescending(x => x.Id_Producto).ToList();
        }
        */

        public List<Producto> BuscarProducto(int id)
        {
            //SELECT * FROM CONTACTOS WHERE ID='id'
            return datos.Producto.Where(x => x.Id_Producto.Equals(id)).OrderByDescending(x => x.Id_Producto).ToList();
        
        }


        public int UpdateProducto(Producto pro)
        {
            //Obtenemos la entidad
            var c = (from prod in datos.Producto
                     where prod.Id_Producto == pro.Id_Producto
                     select prod).First();
            //modificamos
            c.Descripcion_pro = pro.Descripcion_pro;
            c.PrecioUnitario = pro.PrecioUnitario;
            c.Id_Categoria = pro.Id_Categoria;

            //Guardamos los cambios
            return datos.SaveChanges();


        }


        public int deleteProducto(int id)
        {
            var c = (from prod in datos.Producto
                     where prod.Id_Producto == id
                     select prod).First();

            //Eliminamos la entidad
            datos.Producto.Remove(c);
            //guardamos los cambios
            return datos.SaveChanges();
        }


        //ACCIONES DE LA CLASE CLIENTES

        public bool InsertCliente(Cliente cli)
        {
            cli = new Cliente
            {
               Nombre_cli = cli.Nombre_cli,
               Apellido_cli = cli.Apellido_cli,
               Direccion_cli = cli.Direccion_cli,
               Telefono_cli = cli.Direccion_cli,
               DNI_cli = cli.DNI_cli

            };

            datos.Cliente.Add(cli);
            if (datos.SaveChanges() > 0)
            {
                return true;
            }
            return false;

        }


        public List<Cliente> GetClientes()
        {
            //ORDER BY id DESC
            return datos.Cliente.OrderByDescending(x => x.Id_Cliente).ToList();
         
        }


        public List<Cliente> GetClientesDelimitador(int deliminador)
        {
            //SELECT TOP deliminador * FROM Contacto ORDER BY id DESC
            return datos.Cliente.Take(deliminador).OrderByDescending(x => x.Id_Cliente).ToList();
        }


        public List<Cliente> BuscarCliente(int id)
        {
            //SELECT * FROM CONTACTOS WHERE ID='id'
            return datos.Cliente.Where(x => x.Id_Cliente.Equals(id)).OrderByDescending(x => x.Id_Cliente).ToList();

        }


        public int UpdateCliente(Cliente cli)
        {
            //Obtenemos la entidad
            var c = (from clie in datos.Cliente
                     where clie.Id_Cliente == clie.Id_Cliente
                     select clie).First();
            //modificamos
            c.Nombre_cli = cli.Nombre_cli;
            c.Apellido_cli = cli.Apellido_cli;
            c.Direccion_cli = cli.Direccion_cli;
            c.Telefono_cli = cli.Direccion_cli;
            c.DNI_cli = cli.DNI_cli;

            //Guardamos los cambios
            return datos.SaveChanges();


        }


        public int deleteCliente(int id)
        {
            var c = (from clie in datos.Cliente
                     where clie.Id_Cliente == id
                     select clie).First();

            //Eliminamos la entidad
            datos.Cliente.Remove(c);
            //guardamos los cambios
            return datos.SaveChanges();
        }

    }
}
