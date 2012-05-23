insert into KEYWORD (KEY_TAG)
values				(N'csharp');

insert into KEYWORD (KEY_TAG)
values				(N'java');

insert into KEYWORD (KEY_TAG)
values				(N'etiquetado');

insert into KEYWORD (KEY_TAG)
values				(N'programacion');

insert into KEYWORD (KEY_TAG)
values				(N'etiquetado');

insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
VALUES				(
						N'Centrar ventana en pantalla', 
						N'Como centrar la ventana en todo el centro de la pantalla y/o de su ventana padre', 
						GETDATE(), 
						N'A'
					);
					
insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
VALUES				(
						N'Centrar ventana en pantalla', 
						N'Como centrar la ventana en todo el centro de la pantalla y/o de su ventana padre', 
						GETDATE(), 
						N'A'
					);
					
insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
VALUES				(
						N'Metodo de ordenamiento por inserción', 
						N'Como ordenar elementos numericos mediante el metodo de inserción', 
						GETDATE(), 
						N'A'
					);
					
insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
VALUES				(
						N'Extraer elemento de una colección', 
						N'Como extraer', 
						GETDATE(), 
						N'A'
					);
					
insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
VALUES				(
						N'Centrar ventana en pantalla', 
						N'Como centrar la ventana en todo el centro de la pantalla y/o de su ventana padre', 
						GETDATE(), 
						N'A'
					);
					
insert into KEYWORD_DETAIL (KEY_ID, SNI_ID)
values				       (1,1);

insert into CATEGORIA (CAT_NOMB, CAT_DESCRIP)
values      (N'GUI', N'Interfaces Gráficas de Usuario');

insert into CATEGORIA_DETAIL (SNI_ID, CAT_ID)
values				         (2,2);

insert into DESARROLLADOR (DEV_ID, DEV_PW, DEV_NOMBRE, DEV_FECHA)
values				      (N'hitsu', N'BYAKURAY', N'Toushiro Hitsugaya', GETDATE());

insert into SOLUCION (SNI_ID, DEV_ID, SOL_FECHA)
values			     (2, N'3', GETDATE());

