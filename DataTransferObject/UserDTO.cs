using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    [DataContract]
    public class UserDTO : CatalogoBase
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string UserPasswordHash { get; set; }
        [DataMember]
        public string UserEmail { get; set; }
        [DataMember]
        public string UserStatus { get; set; }
        [DataMember]
        public System.DateTime UserCreationDate { get; set; }
    }

    [CollectionDataContract]
    public class ListaUsers : List<UserDTO>
    {
    }

    [DataContract]
    public class UserDTOReq : CatalogoReqBase
    {
        [DataMember]
        public ListaUsers Users { get; set; }
    }

    [DataContract]
    public class UserDTOResp : CatalogoRespBase
    {
        [DataMember]
        public ListaUsers Users { get; set; }
    }
}
