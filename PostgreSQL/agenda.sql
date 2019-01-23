-- Database: agenda

-- DROP DATABASE agenda;

CREATE DATABASE agenda
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Portuguese_Brazil.1252'
    LC_CTYPE = 'Portuguese_Brazil.1252'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;

USE AGENDA;

CREATE TABLE CONTATO(
	id serial NOT NULL,
    nome character varying(100),
    endereco character varying(100),
    bairro character varying(50),
    cidade character varying(70),
    estado character varying(2),
    numero character varying(20),
    cep character varying(20),
    status character varying(1),
	
	CONSTRAINT PK_CONTATO PRIMARY KEY(id)
);

CREATE TABLE TELEFONE(
	id serial NOT NULL,
    id_contato integer NOT NULL,
    telefone integer,
    email character varying(255),
    site character varying(255),
	
	CONSTRAINT PK_TELEFONE PRIMARY KEY(id),
	CONSTRAINT FK_TELEFONE_CONTATO FOREIGN KEY(id_contato)
		REFERENCES CONTATO(id)
);

CREATE TABLE USUARIO(
	id serial NOT NULL,
    nome character varying(100),
    login character varying(20),
    senha character varying(20),
    status character(1),
	
	CONSTRAINT PK_USUARIO PRIMARY KEY(id)
);