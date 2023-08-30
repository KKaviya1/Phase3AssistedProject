create database Schools
use Schools

create table student (
    id int primary key,
    name varchar(100) not null,
    address varchar(100) not null,
    email varchar(75) not null,
    class varchar(5) not null
)

create table class (
    id int primary key,
    name varchar(50) not null
)

create table subject (
    id int primary key,
    name varchar(50) not null
)






