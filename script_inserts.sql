-- 1
insert into KEYWORD (KEY_TAG)
values				(N'csharp');

-- 2
insert into KEYWORD (KEY_TAG)
values				(N'java');

-- 3
insert into KEYWORD (KEY_TAG)
values				(N'etiquetado');

-- 4
insert into KEYWORD (KEY_TAG)
values				(N'programacion');

-- 5
insert into KEYWORD (KEY_TAG)
values				(N'etiquetado');

-- 6
insert into KEYWORD (KEY_TAG)
values				(N'sql');

-- 7
insert into KEYWORD (KEY_TAG)
values				(N'socket');

-- 8
insert into KEYWORD (KEY_TAG)
values				(N'thread');

-- 9
insert into KEYWORD (KEY_TAG)
values				(N'port');

-- 10
insert into KEYWORD (KEY_TAG)
values				(N'lpt');

-- 11
insert into KEYWORD (KEY_TAG)
values				(N'parallel');

-- 12
insert into KEYWORD (KEY_TAG)
values				(N'html');

-- 13
insert into KEYWORD (KEY_TAG)
values				(N'javascript');

-- 14
insert into KEYWORD (KEY_TAG)
values				(N'style');

-- 15
insert into KEYWORD (KEY_TAG)
values				(N'matlab');

-- 16
insert into KEYWORD (KEY_TAG)
values				(N'window');

-- 17
insert into KEYWORD (KEY_TAG)
values				(N'frame');

-- 18
insert into KEYWORD (KEY_TAG)
values				(N'center');

-- 19
insert into KEYWORD (KEY_TAG)
values				(N'parent');

-- 20
insert into KEYWORD (KEY_TAG)
values				(N'comments');

-- 21
insert into KEYWORD (KEY_TAG)
values				(N'sorting');

-- 22
insert into KEYWORD (KEY_TAG)
values				(N'insertion');

-- 23
insert into KEYWORD (KEY_TAG)
values				(N'collection');

-- 24
insert into KEYWORD (KEY_TAG)
values				(N'sqlserver');

-- 25
insert into KEYWORD (KEY_TAG)
values				(N'connection string');

-- 26
insert into KEYWORD (KEY_TAG)
values				(N'select');

-- 27
insert into KEYWORD (KEY_TAG)
values				(N'retrieval');

-- 1
insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
values				(
						N'Centrar ventana en pantalla', 
						N'Como centrar la ventana en todo el centro de la pantalla y/o de su ventana padre', 
						GETDATE(), 
						N'A'
					);

-- 2
insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
values				(
						N'Crear y configurar un cliente y un servidor con Sockets', 
						N'Codigo para ejemplo basico de comunicacion cliente-servidor usando Sockets e hilos. Por ejemplo un chat.', 
						GETDATE(), 
						N'A'
					);

-- 3
insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
values				(
						N'Metodo de ordenamiento por inserción', 
						N'Como ordenar elementos numericos mediante el metodo de inserción', 
						GETDATE(), 
						N'A'
					);

-- 4
insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
values				(
						N'Extraer elemento de una colección', 
						N'Como extraer elementos individuales de una colección basada en las clases Collection del SDK de .NET', 
						GETDATE(), 
						N'A'
					);

-- 5
insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
VALUES				(
						N'Ejecutar metodos o funciones en distintos hilos (threads) de ejecución', 
						N'Código que nos permite ejecutar rutinas en hilos de ejecución en paralelo e independientemente.', 
						GETDATE(), 
						N'A'
					);

-- 6
insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
VALUES				(
						N'Autogenerar ConnectionStrings para SQL Server', 
						N'Código que mediante ciertos atributos nos permite generar una cadena de conexión apropiada para conectarnos a una base de datos externa.', 
						GETDATE(), 
						N'A'
					);

-- 7
insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
VALUES				(
						N'Realizar consultas SELECT a SQL Server', 
						N'Código fuente que nos permite realizar retrievals de datos a una base de datos SQL Server', 
						GETDATE(), 
						N'A'
					);

-- 8
insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
VALUES				(
						N'Comentarios en SQL', 
						N'Como comentar en el codigo bajo las distintas versiones SQL de los distintos servidores de bases de datos', 
						GETDATE(), 
						N'A'
					);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (16,1);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (17,1);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (18,1);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (19,1);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (1,2);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (7,2);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (21,3);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (22,3);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (23,4);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (8,5);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (24,6);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (25,6);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (24,7);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (6,7);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (26,7);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (27,7);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (6,8);

insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (20,8);

-- 1
insert into CATEGORIA (CAT_NOMB, CAT_DESCRIP)
values      (N'GUI', N'Interfaces Gráficas de Usuario');

-- 2
insert into CATEGORIA (CAT_NOMB, CAT_DESCRIP)
values      (N'Process', N'Procesamiento, hilos, consumo, rendimiento y memoria');

-- 3
insert into CATEGORIA (CAT_NOMB, CAT_DESCRIP)
values      (N'Algoritmia', N'Todo lo referente a la forma efectiva de solucionar problemas logicos puntuales.');

-- 4
insert into CATEGORIA (CAT_NOMB, CAT_DESCRIP)
values      (N'Bases de Datos', N'Todo lo referente propiamente a las bases de datos.');

-- 5
insert into CATEGORIA (CAT_NOMB, CAT_DESCRIP)
values      (N'Redes', N'Todo lo referente a arquitecturas cliente-servidor usando redes intranet e internet con los distintos protocolos existentes.');

-- 6
insert into CATEGORIA (CAT_NOMB, CAT_DESCRIP)
values      (N'Arreglos de datos', N'Todo lo referente al procesamiento de colecciones y arreglos de datos dentro del lenguaje y con los elementos propios de cada lenguaje.');

insert into CATEGORIA_DETAIL (SNI_ID, CAT_ID)
values				         (1,1);

insert into CATEGORIA_DETAIL (SNI_ID, CAT_ID)
values				         (2,5);

insert into CATEGORIA_DETAIL (SNI_ID, CAT_ID)
values				         (3,3);

insert into CATEGORIA_DETAIL (SNI_ID, CAT_ID)
values				         (4,6);

insert into CATEGORIA_DETAIL (SNI_ID, CAT_ID)
values				         (5,2);

insert into CATEGORIA_DETAIL (SNI_ID, CAT_ID)
values				         (6,4);

insert into CATEGORIA_DETAIL (SNI_ID, CAT_ID)
values				         (7,4);

insert into CATEGORIA_DETAIL (SNI_ID, CAT_ID)
values				         (8,4);

insert into DESARROLLADOR (DEV_ID, DEV_PW, DEV_NOMBRE, DEV_FECHA)
values				      (N'spiderman', N'SPIDDY', N'Peter Parker', GETDATE());

insert into DESARROLLADOR (DEV_ID, DEV_PW, DEV_NOMBRE, DEV_FECHA)
values				      (N'hulk', N'VERDe', N'Bruce Banner', GETDATE());

insert into DESARROLLADOR (DEV_ID, DEV_PW, DEV_NOMBRE, DEV_FECHA)
values				      (N'zheref', N'YUGIOH', N'Sergio Daniel Lozano', GETDATE());

insert into DESARROLLADOR (DEV_ID, DEV_PW, DEV_NOMBRE, DEV_FECHA)
values				      (N'capitanamerica', N'capitanamerica01', N'Steve Rogers', GETDATE());

insert into DESARROLLADOR (DEV_ID, DEV_PW, DEV_NOMBRE, DEV_FECHA)
values				      (N'ironman', N'starkINDUSTRIES', N'Tony Stark', GETDATE());

-- 1
insert into SOLUCION (SNI_ID, DEV_ID, SOL_FECHA)
values			     (1, N'spiderman', GETDATE());

-- 2
insert into SOLUCION (SNI_ID, DEV_ID, SOL_FECHA)
values			     (1, N'zheref', GETDATE());

-- 3
insert into SOLUCION (SNI_ID, DEV_ID, SOL_FECHA)
values			     (2, N'capitanamerica', GETDATE());

-- 4
insert into SOLUCION (SNI_ID, DEV_ID, SOL_FECHA)
values			     (3, N'ironman', GETDATE());

-- 5
insert into SOLUCION (SNI_ID, DEV_ID, SOL_FECHA)
values			     (4, N'hulk', GETDATE());

-- 6
insert into SOLUCION (SNI_ID, DEV_ID, SOL_FECHA)
values			     (4, N'capitanamerica', GETDATE());

-- 7
insert into SOLUCION (SNI_ID, DEV_ID, SOL_FECHA)
values			     (4, N'zheref', GETDATE());

-- 8
insert into SOLUCION (SNI_ID, DEV_ID, SOL_FECHA)
values			     (5, N'ironman', GETDATE());

-- 9
insert into SOLUCION (SNI_ID, DEV_ID, SOL_FECHA)
values			     (5, N'capitanamerica', GETDATE());

-- 10
insert into SOLUCION (SNI_ID, DEV_ID, SOL_FECHA)
values			     (6, N'hulk', GETDATE());

-- 11
insert into SOLUCION (SNI_ID, DEV_ID, SOL_FECHA)
values			     (7, N'spiderman', GETDATE());

-- 12
insert into SOLUCION (SNI_ID, DEV_ID, SOL_FECHA)
values			     (8, N'spiderman', GETDATE());

-- 13
insert into SOLUCION (SNI_ID, DEV_ID, SOL_FECHA)
values			     (8, N'hulk', GETDATE());

-- 1
insert into LENGUAJE (LEN_NOMBRE, LEN_ESPEC)
values				 (N'C#', N'http://msdn.microsoft.com/es-es/library/618ayhy6(v=vs.80).aspx');

-- 2
insert into LENGUAJE (LEN_NOMBRE, LEN_ESPEC)
values				 (N'Java', N'http://docs.oracle.com/javase/');

-- 3
insert into LENGUAJE (LEN_NOMBRE, LEN_ESPEC)
values				 (N'JavaScript', N'http://www.ecma-international.org/publications/standards/Ecma-262.htm');

-- 4
insert into LENGUAJE (LEN_NOMBRE, LEN_ESPEC)
values				 (N'Objective-C', N'https://developer.apple.com/library/mac/documentation/cocoa/conceptual/objectivec/objc.pdf');

-- 5
insert into LENGUAJE (LEN_NOMBRE, LEN_ESPEC)
values				 (N'PHP', N'http://php.net/docs.php');

-- 6
insert into LENGUAJE (LEN_NOMBRE, LEN_ESPEC)
values				 (N'SQL', N'http://www.w3schools.com/sql/sql_quickref.asp');

insert into LENG_USAGE  (SOL_ID, LEN_ID, LEN_USAGEINDEX)
values					(1, 2, 1);

insert into LENG_USAGE  (SOL_ID, LEN_ID, LEN_USAGEINDEX)
values					(2, 1, 1);

insert into LENG_USAGE  (SOL_ID, LEN_ID, LEN_USAGEINDEX)
values					(3, 1, 1);

insert into LENG_USAGE  (SOL_ID, LEN_ID, LEN_USAGEINDEX)
values					(4, 5, 1);

insert into LENG_USAGE  (SOL_ID, LEN_ID, LEN_USAGEINDEX)
values					(5, 3, 1);

insert into LENG_USAGE  (SOL_ID, LEN_ID, LEN_USAGEINDEX)
values					(6, 4, 1);

insert into LENG_USAGE  (SOL_ID, LEN_ID, LEN_USAGEINDEX)
values					(7, 1, 1);

insert into LENG_USAGE  (SOL_ID, LEN_ID, LEN_USAGEINDEX)
values					(8, 4, 1);

insert into LENG_USAGE  (SOL_ID, LEN_ID, LEN_USAGEINDEX)
values					(9, 5, 1);

insert into LENG_USAGE  (SOL_ID, LEN_ID, LEN_USAGEINDEX)
values					(10, 1, 1);

insert into LENG_USAGE  (SOL_ID, LEN_ID, LEN_USAGEINDEX)
values					(11, 6, 1);

insert into LENG_USAGE  (SOL_ID, LEN_ID, LEN_USAGEINDEX)
values					(12, 6, 1);

insert into LENG_USAGE  (SOL_ID, LEN_ID, LEN_USAGEINDEX)
values					(13, 6, 1);

-- 1
insert into LIBRERIA (LEN_ID, LIB_NOMBRE, LIB_SOURCE)
values		         (1, N'ADO.NET', N'http://www.microsoft.com/en-us/download/details.aspx?id=5412');

-- 2
insert into LIBRERIA (LEN_ID, LIB_NOMBRE, LIB_SOURCE)
values		         (1, N'JSON.NET', N'http://json.codeplex.com/');

-- 3
insert into LIBRERIA (LEN_ID, LIB_NOMBRE, LIB_SOURCE)
values		         (3, N'JQuery', N'http://jquery.com/');

-- 4
insert into LIBRERIA (LEN_ID, LIB_NOMBRE, LIB_SOURCE)
values		         (5, N'Zend SDK', N'http://code.google.com/p/zend-sdk/');

-- 5
insert into LIBRERIA (LEN_ID, LIB_NOMBRE, LIB_SOURCE)
values		         (2, N'JMonkey Engine', N'http://code.google.com/p/jmonkeyengine/');

insert into LIB_USAGE (LIB_ID, SOL_ID, LIB_USAGEINDEX)
values		          (1, 10, 1);

-- 1
insert into TECNOLOGIA  (TEC_NOMBRE, TEC_SOURCE)
values			        (N'WPF', N'http://windowsclient.net/downloads/');

-- 2
insert into TECNOLOGIA  (TEC_NOMBRE, TEC_SOURCE)
values			        (N'JSF', N'http://www.oracle.com/technetwork/java/javaee/download-139288.html');

-- 3
insert into TECNOLOGIA  (TEC_NOMBRE, TEC_SOURCE)
values			        (N'GWT', N'https://developers.google.com/web-toolkit/download');

-- 4
insert into TECNOLOGIA  (TEC_NOMBRE, TEC_SOURCE)
values			        (N'HTML5', N'http://dev.w3.org/html5/html-author/');

-- 5
insert into TECNOLOGIA  (TEC_NOMBRE, TEC_SOURCE)
values			        (N'ASP.NET Web Forms', N'http://www.asp.net/downloads/essential');

insert into TECNOLOGIA_DT (SOL_ID, TEC_ID)
values			          (1, 1);