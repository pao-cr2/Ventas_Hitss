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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        // METODOS PARA LA CLASE PRODUCTO
        [OperationContract]
        bool InsertProducto(Producto pro);

        [OperationContract]
        List<Producto> GetProductos();
        /*
        [OperationContract]
        List<Producto> GetProductosDelimitador(int deliminador);
        */
        [OperationContract]
        List<Producto> BuscarProducto(int id);

        [OperationContract]
        int UpdateProducto(Producto pro);

        [OperationContract]
        int deleteProducto(int id);

        //METODOS PARA LA CLASE CLIENTE

        [OperationContract]
        bool InsertCliente(Cliente cli);

        [OperationContract]
        List<Cliente> GetClientes();

        [OperationContract]
        List<Cliente> GetClientesDelimitador(int deliminador);

        [OperationContract]
        List<Cliente> BuscarCliente(int id);

        [OperationContract]
        int UpdateCliente(Cliente cli);

        [OperationContract]
        int deleteCliente(int id);
    }

    
    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    
}
