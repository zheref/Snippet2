create table KEYWORD 
(
   KEY_IDD              int			          identity(1,1) not null,
   KEY_TAG              nvarchar(15)          not null,
   
   constraint PK_KEYWORD primary key (KEY_IDD)
);

create table SNIPPET 
(
	SNI_ID               int		          identity(1,1) not null,
	SNI_NOMBRE           nvarchar(100)        not null,
	SNI_DESCRIP          nvarchar(511)        null,
	SNI_FECHA            datetime             not null,
	SNI_ESTADO           nchar(2)             not null,
   
   constraint PK_SNIPPET primary key (SNI_ID)
);

create table KEYWORD_DETAIL 
(
   KEY_IDD              int                   not null,
   SNI_ID               int                   not null,
   
   constraint PK_KEYWORD_DETAIL primary key (KEY_IDD, SNI_ID),
   constraint FK_KEYWORD__COINCIDE__KEYWORD foreign key (KEY_IDD) references KEYWORD(KEY_IDD),
   constraint FK_KEYWORD__ES_APLICA_SNIPPET foreign key (SNI_ID) references SNIPPET(SNI_ID)
);

create table CATEGORIA 
(
   CAT_ID               int				              identity(1,1) not null,
   CAT_NOMBRE			nvarchar(20)				  not null,
   CAT_DESCRIP          nvarchar(511)	              null,
   
   constraint PK_CATEGORIA primary key (CAT_ID)
);

create table CATEGORIA_DETAIL 
(
   SNI_ID               int			                 not null,
   CAT_ID               int			                 not null,

   constraint PK_CATEGORIA_DETAIL primary key (SNI_ID, CAT_ID),
   constraint FK_CATEGORI_HACE_PART_CATEGORI foreign key (CAT_ID) references CATEGORIA(CAT_ID),
   constraint FK_CATEGORI_INCLUYE_SNIPPET foreign key (SNI_ID) references SNIPPET(SNI_ID)
);

create table DESARROLLADOR 
(
   DEV_ID               nvarchar(20)                  not null,
   DEV_PW               nvarchar(20)                  not null,
   DEV_NOMBRE           nvarchar(70)                  not null,
   DEV_FECHA            datetime                      not null,
   
   constraint PK_DESARROLLADOR primary key (DEV_ID)
);

create table SOLUCION 
(
   SOL_ID               int							  identity(1,1) not null,
   SNI_ID               int					          not null,
   DEV_ID               nvarchar(20)                  not null,
   SOL_FECHA            datetime                      not null,

   constraint PK_SOLUCION primary key (SOL_ID),
   constraint FK_SOLUCION_CREA_DESARROL foreign key (DEV_ID) references DESARROLLADOR(DEV_ID),
   constraint FK_SOLUCION_SOLUCIONA_SNIPPET foreign key (SNI_ID) references SNIPPET(SNI_ID)
);

create table CODIGO 
(
   COD_ID               int			                    identity(1,1) not null,
   SOL_ID               int					            not null,
   COD_CONTENT          nvarchar(4000)                  not null,
   
   constraint PK_CODIGO primary key (COD_ID),
   constraint FK_CODIGO_ES_ENCAPS_SOLUCION foreign key (SOL_ID) references SOLUCION(SOL_ID)
);

create table TECNOLOGIA 
(
   TEC_ID               int						         identity(1,1) not null,
   TEC_NOMBRE           nvarchar(20)                     not null,
   TEC_SOURCE           nvarchar(100)                     not null,
   
   constraint PK_TECNOLOGIA primary key (TEC_ID)
);

create table TECNOLOGIA_DT 
(
   SOL_ID               int				                 not null,
   TEC_ID               int					             not null,

   constraint PK_TECNOLOGIA_DT primary key (SOL_ID, TEC_ID),
   constraint FK_TECNOLOG_CONSTRUYE_SOLUCION foreign key (SOL_ID) references SOLUCION (SOL_ID),
   constraint FK_TECNOLOG_SE_CONSTR_TECNOLOG foreign key (TEC_ID) references TECNOLOGIA (TEC_ID)
);

create table LENGUAJE 
(
   LEN_ID               int						         identity(1,1) not null,
   LEN_NOMBRE           nvarchar(15)                     not null,
   LEN_ESPEC            nvarchar(100)                     null,
   
   constraint PK_LENGUAJE primary key (LEN_ID)
);

create table LENG_USAGE 
(
   SOL_ID               int							     not null,
   LEN_ID               int				                 not null,
   LEN_USAGEINDEX       tinyint			                 null,
   
   constraint PK_LENG_USAGE primary key (SOL_ID, LEN_ID),
   constraint FK_LENG_USA_ESCRITO_E_LENGUAJE foreign key (LEN_ID) references LENGUAJE (LEN_ID),
   constraint FK_LENG_USA_ES_USADO__SOLUCION foreign key (SOL_ID) references SOLUCION (SOL_ID)
);

create table LIBRERIA 
(
   LIB_ID               int								 identity(1,1) not null,
   LEN_ID               int						         not null,
   LIB_NOMBRE           nvarchar(15)                     not null,
   LIB_SOURCE           nvarchar(100)                     not null,

   constraint PK_LIBRERIA primary key (LIB_ID),
   constraint FK_LIBRERIA_HACE_USO__LENGUAJE foreign key (LEN_ID) references LENGUAJE (LEN_ID)
);

create table LIB_USAGE 
(
   LIB_ID               int			                     not null,
   SOL_ID               int						         not null,
   LIB_USAGEINDEX       int							     null,

   constraint PK_LIB_USAGE primary key (LIB_ID, SOL_ID),
   constraint FK_LIB_USAG_ES_USADA__SOLUCION foreign key (SOL_ID) references SOLUCION (SOL_ID),
   constraint FK_LIB_USAG_USA_LIBRERIA foreign key (LIB_ID) references LIBRERIA (LIB_ID)
);