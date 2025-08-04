using Org.BouncyCastle.Asn1.X500;
using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prototipo_MarZel
{
    public class Compra_DAO : Compra_Base
    {


        public override DataTable Cargar_Compras()
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  C.ID_COMPRA, C.ID_PROVEEDOR, P.NOMBRE, C.FECHA, 
                        C.FACTURA, C.GRAVADO, C.ISV, C.EXENTO, C.TOTAL
                FROM    TBL_COMPRAS C
                INNER JOIN TBL_PROVEEDORES P 
                ON      C.ID_PROVEEDOR = P.ID_PROVEEDOR";
            return conexion.EjecutarConsulta(query, null);
        }

        public override DataTable Cargar_Compra(string Factura)
        {
            ConexionBD conexion = new ConexionBD();
            string query = $"SELECT * FROM TBL_COMPRAS WHERE FACTURA = @FACTURA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@FACTURA", Factura)
            };
            return conexion.EjecutarConsulta(query, parametros);
        }

        public override DataTable Cargar_Compra(int Id_Compra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  C.*, P.RTN, P.NOMBRE, P.DIRECCION,
                        P.CELULAR, P.CANT_COMPRAS, P.IMPORTE
                FROM    TBL_COMPRAS C
                INNER JOIN TBL_PROVEEDORES P 
                ON      C.ID_PROVEEDOR = P.ID_PROVEEDOR
                WHERE   C.ID_COMPRA = @ID_COMPRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_COMPRA", Id_Compra)
            };
            return conexion.EjecutarConsulta(query, parametros);
        }

        public override void Guardar_Proveedor()
        {
            Proveedor_Controller Proveedor_Controller = new Proveedor_Controller();
            Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();

            //Obtener Datos de la Compra
            DataTable compra = Temp_Compra_Controller.Cargar_Compra();
            string RTN = compra.Rows[0]["RTN"].ToString() ?? "";
            string NOMBRE = compra.Rows[0]["NOMBRE"].ToString() ?? "";
            string DIRECCION = compra.Rows[0]["DIRECCION"].ToString() ?? "";
            string CELULAR = compra.Rows[0]["CELULAR"].ToString() ?? "";
            int CANT_COMPRAS = 1;
            decimal IMPORTE = Convert.ToDecimal(compra.Rows[0]["TOTAL"]);

            if (compra.Rows[0]["ID_PROVEEDOR"] == DBNull.Value)
            {
                // Agregar Nuevo Proveedor
                Proveedor_Controller.Agregar_Proveedor(RTN, NOMBRE, DIRECCION, CELULAR, CANT_COMPRAS, IMPORTE);

                // Actualiza Id_Proveedor en la tabla temporal.
                DataTable Proveedor = Proveedor_Controller.Cargar_Proveedor(RTN);
                int Id_Proveedor = Convert.ToInt32(Proveedor.Rows[0]["ID_PROVEEDOR"]);
                Temp_Compra_Controller.Asignar_ID_Proveedor(Id_Proveedor);
            }
            else
            {
                // Obtener y actualizar valores del Proveedor.
                int Id_Proveedor = Convert.ToInt32(compra.Rows[0]["ID_PROVEEDOR"]);
                DataTable Proveedor = Proveedor_Controller.Cargar_Proveedor(Id_Proveedor);
                int Cant_Compras = Proveedor.Rows[0].Field<int>("CANT_COMPRAS") + CANT_COMPRAS;
                decimal Importe = Proveedor.Rows[0].Field<decimal>("IMPORTE") + IMPORTE;

                //Actualizar Proveedor.
                Proveedor_Controller.Modificar_Proveedor(Id_Proveedor, RTN, NOMBRE, DIRECCION, CELULAR, Cant_Compras, Importe);
            }
        }

        public override void Guardar_Compra()
        {
            ConexionBD conexion = new ConexionBD();
            Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();
            Compra_Controller Compra_Controller = new Compra_Controller();

            //Obtener Datos de la Compra
            DataTable compra = Temp_Compra_Controller.Cargar_Compra();
            int ID_PROVEEDOR = Convert.ToInt32(compra.Rows[0]["ID_PROVEEDOR"]);
            DateTime FECHA = Convert.ToDateTime(compra.Rows[0]["FECHA"]);
            string FACTURA = compra.Rows[0]["FACTURA"].ToString() ?? "";
            decimal SUBTOTAL = Convert.ToDecimal(compra.Rows[0]["SUBTOTAL"]);
            decimal GRAVADO = Convert.ToDecimal(compra.Rows[0]["GRAVADO"]);
            decimal ISV = Convert.ToDecimal(compra.Rows[0]["ISV"]);
            decimal EXENTO = Convert.ToDecimal(compra.Rows[0]["EXENTO"]);
            decimal TOTAL = Convert.ToDecimal(compra.Rows[0]["TOTAL"]);

            string query = @"
                INSERT INTO TBL_COMPRAS (
                    ID_PROVEEDOR, FECHA, FACTURA, SUBTOTAL, GRAVADO, ISV, EXENTO, TOTAL
                ) VALUES (
                    @ID_PROVEEDOR, @FECHA, @FACTURA, @SUBTOTAL, @GRAVADO, @ISV, @EXENTO, @TOTAL
                )";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_PROVEEDOR", ID_PROVEEDOR),
                new SqlParameter("@FECHA", FECHA),
                new SqlParameter("@FACTURA", FACTURA),
                new SqlParameter("@SUBTOTAL", SUBTOTAL),
                new SqlParameter("@GRAVADO", GRAVADO),
                new SqlParameter("@ISV", ISV),
                new SqlParameter("@EXENTO", EXENTO),
                new SqlParameter("@TOTAL", TOTAL)
            };
            conexion.EjecutarComando(query, parametros);

            // Actualiza Id_Compra en las tablas temporales
            DataTable Compra = Compra_Controller.Cargar_Compra(FACTURA);
            int Id_Compra = Convert.ToInt32(Compra.Rows[0]["ID_COMPRA"]);
            Temp_Compra_Controller.Asignar_ID_Compra(Id_Compra);
        }

        public override void Guardar_Detalles()
        {
            Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();
            Producto_Controller Producto_Controller = new Producto_Controller();
            Compra_Controller Compra_Controller = new Compra_Controller();
            ConexionBD conexion = new ConexionBD();

            //Obtener Registros de Temp_Detalles_Compra
            DataTable detalles = Temp_Compra_Controller.Cargar_Detalles();
            foreach (DataRow row in detalles.Rows)
            {
                int Id_Producto;
                int Id_Compra = Convert.ToInt32(row["ID_COMPRA"]);
                string Codigo_Barra = row["CODIGO_BARRA"].ToString() ?? "";
                string Descripcion = row["DESCRIPCION"].ToString() ?? "";
                int Cantidad = Convert.ToInt32(row["CANTIDAD"]);
                decimal Costo = Convert.ToDecimal(row["COSTO"]);
                int Id_ISV = Convert.ToInt32(row["ID_ISV"]);
                decimal Descuento = Convert.ToDecimal(row["DESCUENTO"]);
                decimal Importe = Convert.ToDecimal(row["IMPORTE"]);
                decimal Precio_Completo = Convert.ToDecimal(row["PRECIO_COMPLETO"]);
                decimal Precio_Unitario = Convert.ToDecimal(row["PRECIO_UNITARIO"]);
                decimal Desc = 0.0m;
                int Id_Categoria = Convert.ToInt32(row["ID_CATEGORIA"]);
                DateTime Fecha_Creacion = Convert.ToDateTime(row["FECHA_CREACION"]);

                if (row["ID_PRODUCTO"] == DBNull.Value)
                {
                    // Agregar Nuevo Producto
                    Producto_Controller.Agregar_Producto(Codigo_Barra, Descripcion, Id_ISV, Precio_Completo, Precio_Unitario, Id_Categoria, Desc, Cantidad);

                    // Actualiza Id_Producto en la tabla temporal.
                    DataTable Producto = Producto_Controller.Cargar_Producto(Codigo_Barra);
                    Id_Producto = Convert.ToInt32(Producto.Rows[0]["ID_PRODUCTO"]);
                    Temp_Compra_Controller.Asignar_ID_Producto(Id_Producto, Codigo_Barra);
                }
                else
                {
                    // Obtener y actualizar valores del producto.
                    Id_Producto = Convert.ToInt32(row["ID_PRODUCTO"]);
                    DataTable Producto = Producto_Controller.Cargar_Producto(Id_Producto);
                    int Existencia = Producto.Rows[0].Field<int>("EXISTENCIA") + Cantidad;

                    //Actualizar Producto.
                    Producto_Controller.Modificar_Producto(Id_Producto, Codigo_Barra, Descripcion, Id_ISV, Precio_Completo, Precio_Unitario, Id_Categoria, Desc, Existencia);
                }

                // Agregar a Detalles de Compra.
                Compra_Controller.Agregar_Detalle(Id_Compra, Id_Producto, Cantidad, Costo, Descuento, Importe);
            }
        }

        public override void Agregar_Detalle(int Id_Compra, int Id_Producto, int Cantidad, decimal Costo, decimal Descuento, decimal Importe)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                INSERT INTO TBL_DETALLES_COMPRA (
                    ID_COMPRA, ID_PRODUCTO, CANTIDAD, COSTO, DESCUENTO, IMPORTE
                ) VALUES (
                    @ID_COMPRA, @ID_PRODUCTO, @CANTIDAD, @COSTO, @DESCUENTO, @IMPORTE
                )";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_COMPRA", Id_Compra),
                new SqlParameter("@ID_PRODUCTO", Id_Producto),
                new SqlParameter("@CANTIDAD", Cantidad),
                new SqlParameter("@COSTO", Costo),
                new SqlParameter("@DESCUENTO", Descuento),
                new SqlParameter("@IMPORTE", Importe)
            };
            conexion.EjecutarComando(query, parametros);
        }

        private void Disminuir_Cantidades_Proveedor(int Id_Compra)
        {
            Proveedor_Controller Proveedor_Controller = new Proveedor_Controller();
            Compra_Controller Compra_Controller = new Compra_Controller();

            // Obtener valores de la Compra Original.
            DataTable Compra = Compra_Controller.Cargar_Compra(Id_Compra);
            int Id_Proveedor_1 = Compra.Rows[0].Field<int>("ID_PROVEEDOR");
            string Rtn_1 = Compra.Rows[0].Field<string>("RTN") ?? "";
            string Nombre_1 = Compra.Rows[0].Field<string>("NOMBRE") ?? "";
            string Direccion_1 = Compra.Rows[0].Field<string>("DIRECCION") ?? "";
            string Celular_1 = Compra.Rows[0].Field<string>("CELULAR") ?? "";
            int Cant_Compras_1 = Compra.Rows[0].Field<int>("CANT_COMPRAS");
            decimal Importe_1 = Compra.Rows[0].Field<decimal>("IMPORTE");
            decimal Total_1 = Compra.Rows[0].Field<decimal>("TOTAL");
            Cant_Compras_1 -= 1;
            Importe_1 = (Importe_1 - Total_1);

            //Actualizar Proveedor Original.
            Proveedor_Controller.Modificar_Proveedor(Id_Proveedor_1, Rtn_1, Nombre_1, Direccion_1, Celular_1, Cant_Compras_1, Importe_1);


        }
        public override void Actualizar_Proveedor(int Id_Compra)
        {
            Disminuir_Cantidades_Proveedor(Id_Compra);

            //Actualizar Nuevo Proveedor
            Guardar_Proveedor();
        }

        public override void Actualizar_Compra(int Id_Compra_Original)
        {
            ConexionBD conexion = new ConexionBD();
            Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();
            Compra_Controller Compra_Controller = new Compra_Controller();

            //Obtener Datos de la Compra
            DataTable Temp_Compra = Temp_Compra_Controller.Cargar_Compra();
            int Id_Compra = Id_Compra_Original;
            int Id_Proveedor = Temp_Compra.Rows[0].Field<int>("ID_PROVEEDOR");
            DateTime Fecha = Temp_Compra.Rows[0].Field<DateTime>("FECHA");
            string Factura = Temp_Compra.Rows[0].Field<string>("FACTURA") ?? "";
            decimal Subtotal = Temp_Compra.Rows[0].Field<decimal>("SUBTOTAL");
            decimal Gravado = Temp_Compra.Rows[0].Field<decimal>("GRAVADO");
            decimal Isv = Temp_Compra.Rows[0].Field<decimal>("ISV");
            decimal Exento = Temp_Compra.Rows[0].Field<decimal>("EXENTO");
            decimal Total = Temp_Compra.Rows[0].Field<decimal>("TOTAL");

            string query = @"
                UPDATE TBL_COMPRAS 
                SET ID_PROVEEDOR = @ID_PROVEEDOR,
                    FECHA = @FECHA,
                    FACTURA = @FACTURA,
                    SUBTOTAL = @SUBTOTAL,
                    GRAVADO = @GRAVADO,
                    ISV = @ISV,
                    EXENTO = @EXENTO,
                    TOTAL = @TOTAL
                WHERE ID_COMPRA = @ID_COMPRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_PROVEEDOR", Id_Proveedor),
                new SqlParameter("@FECHA", Fecha),
                new SqlParameter("@FACTURA", Factura),
                new SqlParameter("@SUBTOTAL", Subtotal),
                new SqlParameter("@GRAVADO", Gravado),
                new SqlParameter("@ISV", Isv),
                new SqlParameter("@EXENTO", Exento),
                new SqlParameter("@TOTAL", Total),
                new SqlParameter("@ID_COMPRA", Id_Compra)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override DataTable Cargar_Detalles(int Id_Compra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT DC.*, P.EXISTENCIA 
                FROM    TBL_DETALLES_COMPRA DC,
                        TBL_PRODUCTOS P
                WHERE   DC.ID_PRODUCTO = P.ID_PRODUCTO
                AND     DC.ID_COMPRA = @ID_COMPRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_COMPRA", Id_Compra)
            };
            return conexion.EjecutarConsulta(query, parametros);
        }

        public override void Eliminar_Detalles(int Id_Compra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                DELETE FROM TBL_DETALLES_COMPRA
                WHERE ID_COMPRA = @ID_COMPRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_COMPRA", Id_Compra)
            };
            conexion.EjecutarComando(query, parametros);
        }

        public override bool Buscar_En_Detalles_Compra(string Codigo_Barra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  1 
                FROM    TBL_DETALLES_COMPRA 
                WHERE   CODIGO_BARRA = @CODIGO_BARRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@CODIGO_BARRA", Codigo_Barra)
            };
            return conexion.EjecutarConsulta(query, parametros).Rows.Count > 0;
        }

        private void Disminuir_Cantidades_Productos(int Id_Compra)
        {

            // Eliminar Detalles de Compra
            Compra_Controller Compra_Controller = new Compra_Controller();
            Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();
            DataTable detalles;
            ConexionBD conexion = new ConexionBD();
            string query = string.Empty;

            //Obtener Registros de TBL_Detalles_Compra
            detalles = Compra_Controller.Cargar_Detalles(Id_Compra);
            foreach (DataRow row in detalles.Rows)
            {
                // Disminuir las cantidades compradas
                int Id_Producto = Convert.ToInt32(row["ID_PRODUCTO"]);
                int Existencia = Convert.ToInt32(row["EXISTENCIA"]);
                int Cantidad = Convert.ToInt32(row["CANTIDAD"]);
                Existencia -= Cantidad;

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

            //Eliminar Los Detalles de Compra Originales.
            Compra_Controller.Eliminar_Detalles(Id_Compra);
        }

        public override void Actualizar_Detalles(int Id_Compra)
        {
            Disminuir_Cantidades_Productos(Id_Compra);

            //Agregar los detalles de Compra Actuales.
            Guardar_Detalles();
        }

        public override DataTable Buscar_En_Compras(string filtro)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT  C.ID_COMPRA, C.ID_PROVEEDOR, P.NOMBRE, C.FECHA, 
                        C.FACTURA, C.GRAVADO, C.ISV, C.EXENTO, C.TOTAL
                FROM    TBL_COMPRAS C
                INNER JOIN TBL_PROVEEDORES P 
                ON      C.ID_PROVEEDOR = P.ID_PROVEEDOR
                WHERE   C.FACTURA LIKE @FILTRO
                OR      P.NOMBRE LIKE @FILTRO";
            SqlParameter[] parametros =
            {
                new SqlParameter("@FILTRO", "%" + filtro + "%")
            };
            return conexion.EjecutarConsulta(query, parametros);
        }

        public override void Eliminar_Compra(int Id_Compra)
        {
            // Eliminar Detalles de Compra
            Disminuir_Cantidades_Productos(Id_Compra);

            // Actualizar Proveedor
            Disminuir_Cantidades_Proveedor(Id_Compra);

            // Eliminar Compra
            ConexionBD conexion = new ConexionBD();
            string query = @"
                DELETE FROM TBL_COMPRAS 
                WHERE ID_COMPRA = @ID_COMPRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@ID_COMPRA", Id_Compra)
            };
            conexion.EjecutarComando(query, parametros);
        }
    }
}