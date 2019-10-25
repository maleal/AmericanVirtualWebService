using DataAccessLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
    public class UserLogic : BaseBusinessLayer<UserDTOReq, UserDTOResp>
    {
        DALayer dal = new DALayer();

        public override UserDTOResp Consultar(UserDTOReq req)
        {
            UserDTOResp resp = new UserDTOResp();
            switch (req.Operacion)
            {
                case Constantes.User.CONSULTAR_CON_NAME:
                    resp = ConsultarConUserName(req);
                    break;
                case Constantes.User.CONSULTAR_TODOS:
                    resp = ConsultarTodos();
                    break;
                default:
                    break;
            }

            return resp; // base.Consultar(req);
        }

        public UserDTOResp ConsultarConUserName(UserDTOReq req)
        {
            UserDTOResp resp = new UserDTOResp();
            resp.Users = dal.ObtenerUser(req.Users[0].UserName);
            return resp;
        }

        public UserDTOResp ConsultarTodos()
        {
            UserDTOResp resp = new UserDTOResp();
            resp.Users = dal.ObtenerUserTodos();
            return resp;
        }

        private UserDTOReq UserDTOResp()
        {
            throw new NotImplementedException();
        }
    }
}
