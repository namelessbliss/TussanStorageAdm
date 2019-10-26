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
        public const string OBTENER_EMPLEADO = "sp_selectEmpleado ?, ?";
        public const string OBTENER_EMPLEADO_POR_ID = "sp_selectEmpleadoPorId ?";
        public const string OBTENER_EMPLEADO_POR_CREDENCIALES = "sp_selectEmpleadoPorCredenciales ?, ?";
        public const string REGISTRAR_EMPLEADO = "sp_registrarEmpleado ?,?,?,?,?,?";
        public const string ACTUALIZAR_EMPLEADO = "sp_actualizarEmpleado ?,?,?,?,?,?,?";

        /**
         * ------------ Cliente --------------
         **/
        public const string OBTENER_CLIENTES = "sp_selectClientes";
        public const string OBTENER_CLIENTE_POR_ID = "sp_selectClientePorId ?";
        public const string REGISTRAR_CLIENTE = "sp_insertarCliente ?,?,?,?";
        public const string ACTUALIZAR_CLIENTE = "sp_actualizarCliente ?,?,?,?,?";


        /**
         * ------------ Tipo Mercaderia --------------
         **/
        public const string OBTENER_TIPOS_MERCADERIA = "sp_selectTipoMercaderia";
        public const string OBTENER_TIPO_MERCADERIA_POR_ID = "sp_selectMercaderiaPorId ?";
        public const string REGISTRAR_TIPO_MERCADERIA = "sp_insertarTipoMercaderia ?,?";
        public const string ACTUALIZAR_TIPO_MERCADERIA = "sp_actualizarMercaderia ?,?,?,?,?";

        /**
         * ------------ Mercaderia --------------
         **/
        public const string OBTENER_MERCADERIAS = "sp_selectMercaderias";
        public const string OBTENER_MERCADERIA_POR_ID = "sp_selectMercaderiaPorId ?";
        public const string REGISTRAR_MERCADERIA = "sp_insertarMercaderia ?,?,?,?,?,?,?";
        public const string ACTUALIZAR_MERCADERIA = "sp_actualizarMercaderia ?,?,?,?,?,?,?,?";

        /**
         * ------------ TipoRegistro --------------
         **/
        public const string OBTENER_TIPO_REGISTRO = "sp_selectTipoRegistro";
        public const string OBTENER_TIPO_REGISTRO_POR_ID = "sp_selectTipoRegistroPorId ?";
        public const string REGISTRAR_TIPO_REGISTRO = "sp_insertarTipoRegistro ?";

        /**
         * ------------ Registro --------------
         **/
        public const string OBTENER_GUIAS = "SELECT * FROM vistaGuias";
        public const string OBTENER_GUIA_ENTRADA = "SELECT * FROM vistaGuiaEntrada";
        public const string OBTENER_GUIA_SALIDA = "SELECT * FROM vistaGuiaSalida";
        public const string OBTENER_REGISTRO_POR_ID = "sp_selectRegistroPorId ?";
        public const string INSERTAR_REGISTRO = "sp_insertarRegistro ?,?,?,?,?,?,?,?";
        public const string ACTUALIZAR_REGISTRO = "sp_actualizarRegistro ?,?,?,?,?,?,?,?,?";

    }
}
