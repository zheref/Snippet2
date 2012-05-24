﻿CREATE DATABASE [SnippetDB] ON  PRIMARY 
( NAME = N'SnippetDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\SnippetDB.mdf' , SIZE = 3072KB , FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SnippetDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\SnippetDB_log.ldf' , SIZE = 1024KB , FILEGROWTH = 10%)

USE [master]
GO
CREATE LOGIN [dbd] WITH PASSWORD=N'dbd' MUST_CHANGE, DEFAULT_DATABASE=[SnippetDB], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO

/*
SELECT SNIPPET.SNI_ID, 
       SNIPPET.SNI_NOMBRE, 
       SNIPPET.SNI_DESCRIP, 
       SNIPPET.SNI_FECHA, 
       SNIPPET.SNI_ESTADO,
	   CATEGORIA.CAT_NOMBRE
FROM SNIPPET, CATEGORIA_DETAIL INNER JOIN CATEGORIA ON CATEGORIA_DETAIL.SNI_ID = SNIPPET.SNI_ID AND CATEGORIA_DETAIL.CAT_ID = CATEGORIA.CAT_ID
WHERE CATEGORIA.CAT_ID = 2;

SELECT CATEGORIA.CAT_ID, 
       CATEGORIA.CAT_NOMBRE, 
       CATEGORIA.CAT_DESCRIP, 
	   SNIPPET.SNI_NOMBRE
FROM CATEGORIA, CATEGORIA_DETAIL INNER JOIN SNIPPET ON CATEGORIA_DETAIL.SNI_ID = SNIPPET.SNI_ID AND CATEGORIA_DETAIL.CAT_ID = CATEGORIA.CAT_ID
WHERE SNIPPET.SNI_ID = 4;
*/