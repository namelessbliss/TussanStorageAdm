using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS {
    public class Constantes {

        public const string BASE_DE_DATOS = "tussanbd";
        public const string USER_ADM = "administrador";
        public const string USER_ADM_PASS = "Almacen$";
        public const string USER_OPERARIO = "operario";
        public const string USER_OPERARIO_PASS = "Almacen$";
        public const string SERVIDOR = "tussanbd.database.windows.net";

        /**
         * PROCEDIMIENTOS ALMACENADOS
         **/

        /**
         * ------------ EMPLEADOS --------------
         **/
        public const string OBTENER_EMPLEADOS = "sp_selectEmpleados";
        public const string OBTENER_EMPLEADO_POR_ID = "sp_selectEmpleadoPorId ?";
        public const string REGISTRAR_EMPLEADO = "sp_registrarEmpleado ?,?,?,?,?,?";
        public const string ACTUALIZAR_EMPLEADO = "sp_actualizarEmpleado ?,?,?,?,?,?,?";

        /**
         * ------------ Transportista --------------
         **/
        public const string OBTENER_TRANSPORTISTAS = "sp_selectTransportistas";
        public const string OBTENER_TRANSPORTISTA_POR_DNI = "sp_selectTransportistaPorDNI ?";
        public const string REGISTRAR_TRANSPORTISTA = "sp_insertarTransportista ?,?";
        public const string ACTUALIZAR_TRANSPORTISTA = "sp_actualizarTransportista ?,?";
        public const string OBTENER_VISTA_TRANSPORTISTAS = "select * from vistaTransportista";

        /**
         * ------------ Vehiculo --------------
         **/
        public const string OBTENER_VEHICULOS = "sp_selectVehiculos";
        public const string OBTENER_VEHICULO_POR_PLACA = "sp_selectVehiculoPorPlaca ?";
        public const string REGISTRAR_VEHICULO = "sp_insertarVehiculo ?,?";
        public const string ACTUALIZAR_VEHICULO = "sp_actualizarVehiculo ?,?";

        /**
         * ------------ Cliente --------------
         **/
        public const string OBTENER_CLIENTES = "sp_selectClientes";
        public const string OBTENER_CLIENTE_POR_ID = "sp_selectClientePorId ?";
        public const string REGISTRAR_CLIENTE = "sp_insertarCliente ?,?,?,?";
        public const string ACTUALIZAR_CLIENTE = "sp_actualizarCliente ?,?,?,?,?";

        /**
         * ------------ Mercaderia --------------
         **/
        public const string OBTENER_MERCADERIAS = "sp_selectMercaderias";
        public const string OBTENER_MERCADERIA_POR_ID = "sp_selectMercaderiaPorId ?";
        public const string REGISTRAR_MERCADERIA = "sp_insertarMercaderia ?,?,?,?";
        public const string ACTUALIZAR_MERCADERIA = "sp_actualizarMercaderia ?,?,?,?,?";

        /**
         * ------------ TipoRegistro --------------
         **/
        public const string OBTENER_TIPO_REGISTRO = "sp_selectTipoRegistro";
        public const string OBTENER_TIPO_REGISTRO_POR_ID = "sp_selectTipoRegistroPorId ?";
        public const string REGISTRAR_TIPO_REGISTRO = "sp_insertarTipoRegistro ?";

        /**
         * ------------ Registro --------------
         **/
        public const string OBTENER_REGISTROS = "sp_selectRegistros";
        public const string OBTENER_REGISTRO_POR_ID = "sp_selectRegistroPorId ?";
        public const string REGISTRAR_REGISTRO = "sp_insertarRegistro ?,?,?,?,?";
        public const string ACTUALIZAR_REGISTRO = "sp_actualizarRegistro ?,?,?,?,?,?";

        /**
         * ------------ Detalle Registro --------------
         **/
        public const string OBTENER_DETALLE_REGISTRO = "sp_selectDetalleRegistro";
        public const string OBTENER_DETALLE_REGISTRO_POR_ID = "sp_selectDetalleRegistroPorId ?";
        public const string REGISTRAR_DETALLE_REGISTRO = "sp_insertarDetalleRegistro ?,?,?,?";
    }
}
