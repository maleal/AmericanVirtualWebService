# AmericanVirtualWebService
Ejercicio que solicita American Virtual RH para aplicar a su busqueda laboral.

Desarrollo de un Web Service basado en SOAP (con Xml como formato de transferencia de datos) con acceso
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



