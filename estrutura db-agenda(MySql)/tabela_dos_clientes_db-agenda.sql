create database if not exists db_agenda;

use db_agenda;

create table if not exists tb_cliente(
	nome varchar(40) not null,
    usuario varchar(30) primary key,
    telefone varchar(14),
    senha varchar(15) not null);
    
create table if not exists tb_categoria(
	cod_categoria int primary key auto_increment,
    categoria varchar(35));


create table if not exists tb_log(
	id_log int auto_increment primary key,
	usuario varchar(50),
    data_hora datetime,
    descricao varchar(500));

DELIMITER $

create trigger trlogcategoriadelete
after delete on tb_categoria
for each row
begin
	insert into tb_log
		(usuario, data_hora, descricao)
        value (user(), current_timestamp(), concat("a categoria ",old.categoria, " foi excluida"));
end $

DELIMITER ;
DELIMITER $

create trigger trlogcategorianew
after insert on tb_categoria
for each row
begin
	insert into tb_log
		(usuario, data_hora, descricao)
        value (user(), current_timestamp(), concat("a categoria ",new.categoria, " foi adicionada"));
end $

DELIMITER ;
DELIMITER $

create trigger trlogcategoriaupdate
after update on tb_categoria
for each row
begin
	insert into tb_log
		(usuario, data_hora, descricao)
        value (user(), current_timestamp(), concat("a categoria ",old.categoria, " foi upgredada"));
end $

DELIMITER ;

select * from tb_log