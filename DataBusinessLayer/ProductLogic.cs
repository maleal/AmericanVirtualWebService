using DataAccessLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
    public class ProductLogic : BaseBusinessLayer<ProductDTOReq, ProductDTOResp>
    {
        DALayer dal = new DALayer();

        public override ProductDTOResp Consultar(ProductDTOReq req)
        {
            ProductDTOResp resp = new ProductDTOResp();
            switch (req.Operacion)
            {
                case Constantes.Product.CONSULTAR_CON_ID:
                    resp = ConsultarConProductID(req);
                    break;
                case Constantes.Product.CONSULTAR_TODOS:
                    resp = ConsultarTodos();
                    break;
                default:
                    break;
            }

            return resp; // base.Consultar(req);
        }
        public ProductDTOResp ConsultarConProductID(ProductDTOReq req)
        {
            ProductDTOResp resp = new ProductDTOResp();
            resp.products = dal.ObtenerProduct(req.products[0].Id);
            return resp;
        }

        public ProductDTOResp ConsultarTodos()
        {
            ProductDTOResp resp = new ProductDTOResp();
            resp.products = dal.ObtenerProductTodos();
            return resp;
        }

    }
}
