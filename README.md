# AmericanVirtualWebService
Ejercicio que solicita American Virtual RH para aplicar a su busqueda laboral.

Desarrollé de un Web Service basado en SOAP (con Xml como formato de transferencia de datos) con acceso
a una base de datos SQLExpress con Windows Authentication.
Los scripts para la creacion de la base y tablas estan en el proyecto, bajo la carpera "SQL Script".

El Gol e este desarrollo esta en la aplicacion del Patron de N-Capas o n-Layer para el desarrollo del Servicio y Acceso a la base de datos.
Construyo 3 capas
. AccessDataLayer: la inmediata superior a la base de datos es la Access Layer, construida con Entity Framework 6 Data Base First con ,
en esta capa 'DataAccessLayer'construyo los metodos para acceder/buscar un Usuario por Id 'ObtenerUser(string name)' y agrego otro que traería todos los usuarios 
de la tabla 'ObtenerUserTodos()'. Tambien desarrollo los metodos para los Productos, uno para acceder por Id 'ObtenerProduct(int Id)' y otro para
traer todos los productos 'ObtenerProductTodos()'.
. DataTransferObject: En esta desarrollo el catalogo base donde se definen los modelo de transferenca de datos Request y Responce, basados en una lista
de donde derivarán UserDTO y ProductDTO (este ultimo tambien nos trae las Categorías, ya que un producto pertenece a una categoría, como
por ejemplo ECommerce o Blog u otras).
. DataBusinessObject: En la capa de negocio se resulve la logica de negocio que pide el ejercicio. El gol en esta capa esta en que
uso UN Solo metodo de Consulta, esto es, la interface del servicio solo expondra "Consulta" para su consumo.

Logueo:
El Logueo de Errores o de las operaciones se hacen en un Archivo de Texto y esta implementado en el proyecto 'Helpers'


Consumo del Web Services desde un cliente web:
. Se debe agregar la referencia al web service 'Service1', por ejemplo, en local host, si le agrega a la solucion un proyecto web, debe ir a referencias y hacer add service reference, luego en Discover podra ver esto 'http://localhost:56223/Service1.svc' despues 
puede cambiarle a la referencia (es el Namespace:) de ServiceReference1 a AVServiceReference. De esta forma 'AVServiceReference' sera la referencia al web services ahora en adelante.
. El siguiente código es un ejemplo de como consumirlo si necesitáramos consultar info de un Usuario logeado, por ejemplo el de     'mariolealfuentes'(debe estar en la base de datos para q' traiga info):
            
            //Instanciamos el objeto UserDTOReq e instanciamos tambien la lista User.
            //Instanciamos tambien los objetos DTO y DTOResp.
          
            AVServiceReference.UserDTOReq req = new AVServiceReference.UserDTOReq()
            {
                Users = new AVServiceReference.ListaUsers(),
            };
            AVServiceReference.UserDTO dto = new AVServiceReference.UserDTO();
            AVServiceReference.UserDTOResp resp = new AVServiceReference.UserDTOResp();

            using (AVServiceReference.Service1Client service1 = new AVServiceReference.Service1Client())
            {
                req.Operacion = Constantes.User.CONSULTAR_CON_NAME;
                //
                dto.UserName = TempData["mario_leal_fuentes"] as string;
                req.Users.Add(dto);
                resp = service1.UserConsultar(req);
            }
            
            //Si obtuvimos respuesta
            if (resp.Users != null && resp.Users.Count() > 0)
            {
                dto = resp.Users[0];
            }
    . La informacion obtenida en el objeto dto es la siguiente.
    dto.UserEmail
    dto.UserCreationDate //DateTime de creacion
    dto.UserStatus       //'E' es que está enable en nuestro caso.
    dto.Id
    
            
