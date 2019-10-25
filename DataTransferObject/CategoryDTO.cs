using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    [DataContract]
    public class CategoryDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string catry_name { get; set; }
        [DataMember]
        public string catry_description { get; set; }
        [DataMember]
        public string catry_status { get; set; }
    }

    [CollectionDataContract]
    public class ListaCategory : List<CategoryDTO>
    {
    }
}
