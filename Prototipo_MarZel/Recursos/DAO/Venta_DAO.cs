using iTextSharp.text;
using Org.BouncyCastle.Asn1.X500;
using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prototipo_MarZel
{
    public class Venta_DAO : Venta_Base
    {
        public override DataTable ObtenerUltimoFolio()
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                            SELECT TOP 1 FACTURA 
                            FROM TBL_VENTAS 
                            ORDER BY ID_VENTA DESC";
            return conexion.EjecutarConsulta(query, null);
         
        }
        public override DataTable Cargar_Ventas()
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  V.ID_VENTA, V.ID_CLIENTE, C.NOMBRE, V.FECHA, 
                        V.FACTURA, V.GRAVADO, V.ISV, V.EXENTO, V.TOTAL
                FROM    TBL_VENTAS V
                INNER JOIN TBL_CLIENTES C 
                ON      V.ID_CLIENTE = C.ID_CLIENTE";
            return conexion.EjecutarConsulta(query, null);
        }

        public override DataTable Buscar_En_Ventas(string filtro)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  V.ID_VENTA, V.ID_CLIENTE, C.NOMBRE, V.FECHA, 
                        V.FACTURA, V.GRAVADO, V.ISV, V.EXENTO, V.TOTAL
                FROM    TBL_VENTAS V
                INNER JOIN TBL_CLIENTES C 
                ON      V.ID_CLIENTE = C.ID_CLIENTE
                WHERE   V.FACTURA LIKE @FILTRO
                OR      C.NOMBRE LIKE @FILTRO";
            SqlParameter[] parametros =
            {
                new SqlParameter("@FILTRO", "%" + filtro + "%")
            };
            return conexion.EjecutarConsulta(query, parametros);
        }

        public override void Guardar_Cliente()
        {
            Cliente_Controller Cliente_Controller = new Cliente_Controller();
            Temp_Venta_Controller Temp_Venta_Controller = new Temp_Venta_Controller();

            //Obtener Datos de la Venta
            DataTable Venta = Temp_Venta_Controller.Cargar_Venta();
            string Rtn = Venta.Rows[0].Field<string>("RTN") ?? "";
            string Nombre = Venta.Rows[0].Field<string>("NOMBRE_CLIENTE") ?? "";
            string Direccion = Venta.Rows[0].Field<string>("DIRECCION") ?? "";
            string Celular = Venta.Rows[0].Field<string>("CELULAR") ?? "";
            int Cant_Compras = 1;
            decimal Importe = Venta.Rows[0].Field<decimal>("TOTAL");

            if (Venta.Rows[0]["ID_CLIENTE"] == DBNull.Value)
            {
                // Agregar Nuevo Cliente
                Cliente_Controller.Agregar_Cliente(Rtn, Nombre, Direccion, Celular, Cant_Compras, Importe);

                // Actualiza Id_Cliente en la tabla temporal.
                DataTable Cliente = Cliente_Controller.Cargar_Cliente(Rtn);
                int Id_Cliente = Cliente.Rows[0].Field<int>("ID_CLIENTE");
                Temp_Venta_Controller.Asignar_Id_Cliente(Id_Cliente);
            }
            else
            {
                // Obtener y actualizar valores del Cliente.
                int Id_Cliente = Venta.Rows[0].Field<int>("ID_CLIENTE");
                DataTable Cliente = Cliente_Controller.Cargar_Cliente(Id_Cliente);
                Cant_Compras += Cliente.Rows[0].Field<int>("CANT_COMPRAS");
                Importe += Cliente.Rows[0].Field<decimal>("IMPORTE");

                //Actualizar Cliente.
                Cliente_Controller.Modificar_Cliente(Id_Cliente, Rtn, Nombre, Direccion, Celular, Cant_Compras, Importe);
            }
        }

        public override void Guardar_Venta()
        {
            ConexionBD conexion = new ConexionBD();
            Temp_Venta_Controller Temp_Venta_Controller = new Temp_Venta_Controller();
            Venta_Controller Venta_Controller = new Venta_Controller();
            DataTable Venta;

            //Obtener Datos de la Venta
            Venta = Temp_Venta_Controller.Cargar_Venta();
            int Id_Usuario = Venta.Rows[0].Field<int>("ID_USUARIO");
            int Id_Cliente = Venta.Rows[0].Field<int>("ID_CLIENTE");
            DateTime Fecha = Venta.Rows[0].Field<DateTime>("FECHA");
            string Factura = Venta.Rows[0].Field<string>("FACTURA") ?? "";
            decimal Subtotal = Venta.Rows[0].Field<decimal>("SUBTOTAL");
            decimal Gravado = Venta.Rows[0].Field<decimal>("GRAVADO");
            decimal Isv = Venta.Rows[0].Field<decimal>("ISV");
            decimal Exento = Venta.Rows[0].Field<decimal>("EXENTO");
            decimal Total = Venta.Rows[0].Field<decimal>("TOTAL");
           
            string query = @"
                INSERT INTO TBL_VENTAS (
                    ID_USUARIO, ID_CLIENTE, FECHA, FACTURA, SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL
                ) VALUES (
                    @ID_USUARIO, @ID_CLIENTE, @FECHA, @FACTURA, @SUBTOTAL, @GRAVADO, @ISV, @EXENTO, @TOTAL
                )";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_USUARIO", Id_Usuario),
                new SqlParameter("@ID_CLIENTE", Id_Cliente),
                new SqlParameter("@FECHA", Fecha),
                new SqlParameter("@FACTURA", Factura),
                new SqlParameter("@SUBTOTAL", Subtotal),
                new SqlParameter("@GRAVADO", Gravado),
                new SqlParameter("@ISV", Isv),
                new SqlParameter("@EXENTO", Exento),
                new SqlParameter("@TOTAL", Total)
            };
            conexion.EjecutarComando(query, parametros);
            
            // Actualiza Id_Venta en las tablas temporales
            Venta = Venta_Controller.Cargar_Venta(Factura);
            int Id_Venta = Venta.Rows[0].Field<int>("ID_VENTA");
            Temp_Venta_Controller.Asignar_Id_Venta(Id_Venta);
        }

        public override DataTable Cargar_Venta(string Factura)
        {
            ConexionBD conexion = new ConexionBD();
            string query = $"SELECT * FROM TBL_VENTAS WHERE FACTURA = @FACTURA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@FACTURA", Factura)
            };
            return conexion.EjecutarConsulta(query, parametros);
        }

        public override void Guardar_Detalles()
        {
            Temp_Venta_Controller Temp_Venta_Controller = new Temp_Venta_Controller();
            Producto_Controller Producto_Controller = new Producto_Controller();
            Venta_Controller Venta_Controller = new Venta_Controller();

            //Obtener Registros de Temp_Detalles_Venta
            DataTable Productos = Temp_Venta_Controller.Cargar_Detalles();

            //Obtener los datos del producto en el detalle de venta temporal.
            foreach (DataRow row in Productos.Rows)
            {
                int Id_Venta = row.Field<int>("ID_VENTA");
                int Id_Producto = row.Field<int>("ID_PRODUCTO");
                int Cantidad = row.Field<int>("CANTIDAD");
                decimal Precio = row.Field<decimal>("PRECIO");
                decimal Descuento = row.Field<decimal>("DESCUENTO");
                decimal Importe = row.Field<decimal>("IMPORTE");
                int Existencia = row.Field<int>("EXISTENCIA");

                //Actualizar Existemcia del Producto
                Producto_Controller.Disminuir_Existencia(Id_Producto, Existencia);

                // Agregar el producto a Detalles de Venta.
                Venta_Controller.Agregar_Detalle(Id_Venta, Id_Producto, Cantidad, Precio, Descuento, Importe);
            }
        }

        public override void Agregar_Detalle(int Id_Venta, int Id_Producto, int Cantidad, decimal Precio, decimal Descuento, decimal Importe)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                INSERT INTO TBL_DETALLES_VENTA (
                    ID_VENTA, ID_PRODUCTO, CANTIDAD, PRECIO, DESCUENTO, IMPORTE
                ) VALUES (
                    @ID_VENTA, @ID_PRODUCTO, @CANTIDAD, @PRECIO, @DESCUENTO, @IMPORTE
                )";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_VENTA", Id_Venta),
                new SqlParameter("@ID_PRODUCTO", Id_Producto),
                new SqlParameter("@CANTIDAD", Cantidad),
                new SqlParameter("@PRECIO", Precio),
                new SqlParameter("@DESCUENTO", Descuento),
                new SqlParameter("@IMPORTE", Importe)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override void Actualizar_Cliente(int Id_Venta)
        {
            Disminuir_Cantidades_Cliente(Id_Venta);
            
            //Actualizar Nuevo Cliente
            Guardar_Cliente();
        }

        private void Disminuir_Cantidades_Cliente(int Id_Venta)
        {
            Cliente_Controller Cliente_Controller = new Cliente_Controller();
            Venta_Controller Venta_Controller = new Venta_Controller();

            // Obtener valores de la Compra Original.
            DataTable Venta = Venta_Controller.Cargar_Venta(Id_Venta);
            int Id_Cliente_1 = Venta.Rows[0].Field<int>("ID_CLIENTE");
            string Rtn_1 = Venta.Rows[0].Field<string>("RTN") ?? "";
            string Nombre_1 = Venta.Rows[0].Field<string>("NOMBRE") ?? "";
            string Direccion_1 = Venta.Rows[0].Field<string>("DIRECCION") ?? "";
            string Celular_1 = Venta.Rows[0].Field<string>("CELULAR") ?? "";
            int Cant_Compras_1 = Venta.Rows[0].Field<int>("CANT_COMPRAS");
            decimal Importe_1 = Venta.Rows[0].Field<decimal>("IMPORTE");
            decimal Total_1 = Venta.Rows[0].Field<decimal>("TOTAL");
            Cant_Compras_1 -= 1;
            Importe_1 = (Importe_1 - Total_1);

            //Actualizar Proveedor Original.
            Cliente_Controller.Modificar_Cliente(Id_Cliente_1, Rtn_1, Nombre_1, Direccion_1, Celular_1, Cant_Compras_1, Importe_1);
        }

        public override DataTable Cargar_Venta(int Id_Venta)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  V.*, C.RTN, C.NOMBRE, C.DIRECCION,
                        C.CELULAR, C.CANT_COMPRAS, C.IMPORTE
                FROM    TBL_VENTAS V
                INNER JOIN TBL_CLIENTES C
                ON V.ID_CLIENTE = C.ID_CLIENTE
                WHERE ID_VENTA = @ID_VENTA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_VENTA", Id_Venta)
            };
            return conexion.EjecutarConsulta(query, parametros);
        }       

        public override void Actualizar_Venta(int Id_Venta_Original)
        {
            ConexionBD conexion = new ConexionBD();
            Temp_Venta_Controller Temp_Venta_Controller = new Temp_Venta_Controller();
            Venta_Controller Venta_Controller = new Venta_Controller();

            //Obtener Datos de la Compra
            DataTable Temp_Venta = Temp_Venta_Controller.Cargar_Venta();
            int Id_Venta = Id_Venta_Original;
            int Id_Cliente = Temp_Venta.Rows[0].Field<int>("ID_CLIENTE");
            int Id_Usuario = Temp_Venta.Rows[0].Field<int>("ID_USUARIO");
            DateTime Fecha = Temp_Venta.Rows[0].Field<DateTime>("FECHA");
            string Factura = Temp_Venta.Rows[0].Field<string>("FACTURA") ?? "";
            decimal Subtotal = Temp_Venta.Rows[0].Field<decimal>("SUBTOTAL");
            decimal Gravado = Temp_Venta.Rows[0].Field<decimal>("GRAVADO");
            decimal Isv = Temp_Venta.Rows[0].Field<decimal>("ISV");
            decimal Exento = Temp_Venta.Rows[0].Field<decimal>("EXENTO");
            decimal Total = Temp_Venta.Rows[0].Field<decimal>("TOTAL");
            
            string query = @"
                UPDATE TBL_VENTAS
                SET ID_CLIENTE = @ID_CLIENTE,
                    ID_USUARIO = @ID_USUARIO,   
                    FECHA = @FECHA,
                    FACTURA = @FACTURA,
                    SUBTOTAL = @SUBTOTAL,
                    GRAVADO = @GRAVADO,
                    ISV = @ISV,
                    EXENTO = @EXENTO,
                    TOTAL = @TOTAL
                WHERE ID_VENTA = @ID_VENTA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_CLIENTE", Id_Cliente),
                new SqlParameter("@ID_USUARIO", Id_Usuario),
                new SqlParameter("@FECHA", Fecha),
                new SqlParameter("@FACTURA", Factura),
                new SqlParameter("@SUBTOTAL", Subtotal),
                new SqlParameter("@GRAVADO", Gravado),
                new SqlParameter("@ISV", Isv),
                new SqlParameter("@EXENTO", Exento),
                new SqlParameter("@TOTAL", Total),
                new SqlParameter("@ID_VENTA", Id_Venta)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override void Actualizar_Detalles(int Id_Venta)
        {
            Aumentar_Cantidades_Productos(Id_Venta);

            //Agregar los detalles de Compra Actuales.
            Guardar_Detalles();
        }

        private void Aumentar_Cantidades_Productos(int Id_Venta)
        {

            // Eliminar Detalles de Venta
            Venta_Controller Venta_Controller = new Venta_Controller();
            Temp_Venta_Controller Temp_Venta_Controller = new Temp_Venta_Controller();
            DataTable detalles;
            ConexionBD conexion = new ConexionBD();
            string query = string.Empty;

            //Obtener Registros de TBL_Detalles_Venta
            detalles = Venta_Controller.Cargar_Detalles(Id_Venta);
            foreach (DataRow row in detalles.Rows)
            {
                // Aumentar las cantidades compradas
                int Id_Producto = Convert.ToInt32(row["ID_PRODUCTO"]);
                int Existencia = Convert.ToInt32(row["EXISTENCIA"]);
                int Cantidad = Convert.ToInt32(row["CANTIDAD"]);
                Existencia += Cantidad;

                query = @"
                    UPDATE TBL_PRODUCTOS
                    SET EXISTENCIA = @EXISTENCIA
                    WHERE ID_PRODUCTO = @ID_PRODUCTO";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@EXISTENCIA", Existencia),
                    new SqlParameter("@ID_PRODUCTO", Id_Producto)
                };
                conexion.EjecutarComando(query, parametros);
            }

            //Eliminar Los Detalles de Venta Originales.
            Venta_Controller.Eliminar_Detalles(Id_Venta);
        }

        public override DataTable Cargar_Detalles(int Id_Venta)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  DV.*, P.EXISTENCIA 
                FROM    TBL_DETALLES_VENTA DV,
                        TBL_PRODUCTOS P
                WHERE   DV.ID_PRODUCTO = P.ID_PRODUCTO
                AND     DV.ID_VENTA = @ID_VENTA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_VENTA", Id_Venta)
            };
            return conexion.EjecutarConsulta(query, parametros);
        }

        public override void Eliminar_Detalles(int Id_Venta)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                DELETE FROM TBL_DETALLES_VENTA
                WHERE ID_VENTA = @ID_VENTA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_VENTA", Id_Venta)
            };
            conexion.EjecutarComando(query, parametros);
        }



        public override void Eliminar_Venta(int Id_Venta)
        {
            // Eliminar Detalles de Compra
            Aumentar_Cantidades_Productos(Id_Venta);

            // Actualizar Cliente
            Disminuir_Cantidades_Cliente(Id_Venta);

            // Eliminar Venta
            ConexionBD conexion = new ConexionBD();
            string query = @"
                DELETE FROM TBL_VENTAS 
                WHERE ID_VENTA = @ID_VENTA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_VENTA", Id_Venta)
            };
            conexion.EjecutarComando(query, parametros);
        }

      
    }
}