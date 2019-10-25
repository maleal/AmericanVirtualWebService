using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace DataTransferObject
{
    [DataContract]
    [Serializable]
    public class CatalogoBase
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Key { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public int Estado { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public int Id_Usuario { get; set; }
    }

    [DataContract]
    [Serializable]
    public class Paginacion
    {
        [DataMember]
        public int RegistrosPorPagina { get; set; }

        [DataMember]
        public int Pagina { get; set; }

        [DataMember]
        public int CantidadRegistros { get; set; }
    }

    [DataContract]
    public class CatalogoReqBase
    {
        [DataMember]
        public Accion TipoOperacion { get; set; }

        [DataMember]
        public string Usuario { get; set; }

        [DataMember]
        public Paginacion Paginacion { get; set; }

        [DataMember]
        public string Control { get; set; }

        [DataMember]
        public string Seguridad { get; set; }

        [DataMember]
        public int Operacion { get; set; }
    }

    [DataContract]
    public class CatalogoRespBase
    {
        [DataMember]
        public string Usuario { get; set; }

        [DataMember]
        public bool EsExitosa { get; set; }

        [DataMember]
        public int TotalRegistros { get; set; }

        [DataMember]
        public ListaErrores Errores { get; set; }
    }

    public enum Accion
    {
        [EnumMember]
        Crear = 0,
        [EnumMember]
        Actualizar = 1,
        [EnumMember]
        Cancelar = 2,
        [EnumMember]
        Eliminar = 3,
        [EnumMember]
        Activar = 4,
        [EnumMember]
        Desactivar = 5,
        [EnumMember]
        Consultar = 6,
        [EnumMember]
        Autorizar = 7,
        [EnumMember]
        CrearMasivo = 8,
        [EnumMember]
        Anular = 9,
        [EnumMember]
        Generar = 10,
        [EnumMember]
        Confirmar = 11,
        [EnumMember]
        Transferir = 12
    }

    [DataContract]
    public class Error
    {
        [DataMember]
        public string Mensaje { get; set; }
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public Exception ExcepcionInterna { get; set; }
        [DataMember]
        public int Fila { get; set; }
    }

    [CollectionDataContract]
    public class ListaErrores : List<Error>
    {
    }
}
