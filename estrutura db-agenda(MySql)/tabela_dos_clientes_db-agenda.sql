create database if not exists db_agenda;

use db_agenda;

create table if not exists tb_cliente(
	nome varchar(40) not null,
    usuario varchar(30) primary key,
    telefone varchar(14),
    senha varchar(15) not null);
    
select * from tb_cliente;