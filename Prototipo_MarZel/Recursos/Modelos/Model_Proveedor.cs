using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Tls.Crypto.Impl;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prototipo_MarZel
{
    public abstract class Proveedor_Base
    {
        public static string Tabla = "TBL_PROVEEDORES";

        public abstract DataTable Cargar_Proveedores();

        public abstract void Eliminar_Proveedor(int Id_Proveedor);

        public abstract DataTable Buscar_En_Proveedores(string filtro);

        public abstract void Agregar_Proveedor(string RTN, string Nombre, string Direccion, string Celular, int Cant_Compras, decimal Importe);

        public abstract void Modificar_Proveedor(int Id_Proveedor, string RTN, string Nombre, string Direccion, string Celular);

        public abstract DataTable Cargar_Proveedor(int Id_Proveedor);

        public abstract DataTable Cargar_Proveedor(string RTN);

        public abstract bool Existe_RTN(string RTN);
    }
}