/*cria a base de dados*/
create database pizzeriadb
default character set utf8
default collate utf8_general_ci;

use pizzeriadb;

/*Cria a tabela*/
create table cliente(
id_cliente int not null auto_increment primary key,
nome_completo varchar(45),
data_nascimento datetime,
telefone varchar(9),
ddd varchar(2),
complemento varchar(60),
CEP varchar(8),
senha varchar(45)
);

/*Insere dados*/
insert into cliente(nome_completo,data_nascimento,telefone,ddd,complemento,CEP,senha) values
('Gabigol da Silva','2004-08-06','400289222','51','Casa amarela','12345679',123),
('Erick Sampaio','2005-03-04','230254789','55','Predio alto','87456321',123),
('Bhaiano','2003-01-08','414976320','51','Frente ao mar','25896314',123),
('Igor dos Santos','2004-06-09','585296305','40','Esquerda do museu','74125896',123),
('Jefersom Araujo','2005-10-09','412365830','51','Arvore caida','40028922',123),
('kaio Leonardo','2005-01-08','478965410','51','Ponto de táxi','65542813',123),
('Ismael Freitas','2004-09-19','420136970','51','Brigada militar','46523199',123),
('Felipe Miller','2004-01-08','401239476','55','Unisc','95135441',123),
('Gabriel Gomes','2006-06-03','015976348','51','Posto de gasolina','32159746',123),
('Daniel Kloh','2004-12-08','4030287914','51','Terreno baldio','95330699',123);


select *
from cliente;