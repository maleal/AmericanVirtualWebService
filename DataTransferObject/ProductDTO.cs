using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    [DataContract]
    public class ProductDTO
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal PrecioUnitario { get; set; }
        public byte[] Imagen { get; set; }

        public CategoryDTO Category { get; set; }
    }

    [CollectionDataContract]
    public class ListaProduct : List<ProductDTO>
    {
    }

    [DataContract]
    public class ProductDTOReq : CatalogoReqBase
    {
        [DataMember]
        public ListaProduct products { get; set; }
    }

    [DataContract]
    public class ProductDTOResp : CatalogoRespBase
    {
        [DataMember]
        public ListaProduct products { get; set; }
    }
}
