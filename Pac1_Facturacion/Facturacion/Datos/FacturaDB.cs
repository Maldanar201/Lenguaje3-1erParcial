using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class FacturaDB
    {
        string cadena = "server=localhost; user=root; database=factura; password=123456;"; // direcion y datos para conectar a la base de datos

        public bool Guardar(Factura factura, List<DetalleFactura> facturas) 
        {
            bool inserto = false;
            int idFactura = 0;

            try
            {
                StringBuilder sqlFactura = new StringBuilder(); // abre un objeto para capturar y ordenar sencias sql largas
                sqlFactura.Append(" INSERT INTO factura VALUES (@fecha, @IDcliente, @CodigoUsuario, @ISV, @Descuento, @SubTotal, @Total); "); // asigna tarea al objeto para insertar datos en la tabla sql
                sqlFactura.Append(" SELECT LAST_INSERT_ID(); "); // captura y devuelve el ultimo numero de la llave primaria que se ejecuto

                StringBuilder sqlDetalle = new StringBuilder();
                sqlDetalle.Append(" INSERT INTO detallefactura VALUES (@IDfactura, @CodigoProducto, @Precio, @Cantidad, Total); ");

                StringBuilder sqlExistencia = new StringBuilder();
                sqlExistencia.Append(" UPDATE producto SET Existencia = Existencia - @Cantidad WHERE Codigo = @Codigo");
            }
            catch (Exception)
            {                
            }
            return inserto
        }
    }
}
