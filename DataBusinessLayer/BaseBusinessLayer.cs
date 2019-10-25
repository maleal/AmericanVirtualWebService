using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using WorkSpace_PreAltaClientes.DataModel;

namespace DataBusinessLayer
{
    public abstract class BaseBusinessLayer<DTOREQ, DTORESP>
        where DTOREQ : CatalogoReqBase
        where DTORESP : CatalogoRespBase
    {
        //public ILogger log = Logger.Crear();

        public virtual DTORESP Crear(DTOREQ req) { return null; }
        public virtual DTORESP Actualizar(DTOREQ req) { return null; }
        public virtual DTORESP Eliminar(DTOREQ req) { return null; }
        public virtual DTORESP Anular(DTOREQ req) { return null; }
        public virtual DTORESP ObtenerPorId(DTOREQ req) { return null; }
        public virtual DTORESP ObtenerFiltrado(DTOREQ req) { return null; }
        public virtual DTORESP Consultar(DTOREQ req) { return null; }
        public virtual DTORESP Activar(DTOREQ req) { return null; }
        public virtual DTORESP Desactivar(DTOREQ req) { return null; }
        public virtual DTORESP Autorizar(DTOREQ req) { return null; }
        public virtual DTORESP CrearMasivo(DTOREQ req) { return null; }
        public virtual DTORESP Generar(DTOREQ req) { return null; }
        public virtual DTORESP Confirmar(DTOREQ req) { return null; }
        public virtual DTORESP Transferir(DTOREQ req) { return null; }

        /// <summary>
        /// De acuerdo al tipo de operación especificada deriva la operación
        /// </summary>
        /// <param name="DTOREQ">DTO con la informacion necesaria para ejecutar la acción</param>
        /// <returns>Retorna una entidad del tipo CatalogoRespBase con la información de retorno de la acción </returns>
        public DTORESP Ejecutar(DTOREQ entidad)
        {
            DTORESP resp = null;
            switch (entidad.TipoOperacion)
            {
                case (Accion.Crear):
                    {
                        resp = Crear(entidad);
                        break;
                    }
                case (Accion.Actualizar):
                    {
                        resp = Actualizar(entidad);
                        break;
                    }
                case (Accion.Eliminar):
                    {
                        resp = Eliminar(entidad);
                        break;
                    }
                case (Accion.Transferir):
                    {
                        resp = Transferir(entidad);
                        break;
                    }
                case (Accion.Desactivar):
                    {
                        resp = Desactivar(entidad);
                        break;
                    }
                case (Accion.Autorizar):
                    {
                        resp = Autorizar(entidad);
                        break;
                    }
                case (Accion.CrearMasivo):
                    {
                        resp = CrearMasivo(entidad);
                        break;
                    }
                case (Accion.Activar):
                    {
                        resp = Activar(entidad);
                        break;
                    }
                case (Accion.Anular):
                    {
                        resp = Anular(entidad);
                        break;
                    }
                case (Accion.Generar):
                    {
                        resp = Generar(entidad);
                        break;
                    }
                case (Accion.Confirmar):
                    {
                        resp = Confirmar(entidad);
                        break;
                    }
                case (Accion.Consultar):
                    {
                        resp = Consultar(entidad);
                        break;
                    }

            }
            return resp;
        }

    }
}
