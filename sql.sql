create database sarfaraz;
use sarfaraz;

create table customer(
	cid int primary key auto_increment,
    cname varchar(20) not null,
    caddress varchar(20) not null
    );
create table employee(
	eid int primary key auto_increment,
    ename varchar(20) not null,
    eaddress varchar(20) not null,
    cid int
    );
    create table staff(
    sid int primary key auto_increment,
    sname varchar(30) not null,
    ssalary bigint not null,
    saddress varchar(30) not null
    );
    alter table employee
    add constraint fk_cus foreign key(cid) references customer(cid);
    insert into staff(sname,ssalary,saddress) values ('ram','10000','ktm');
    insert into staff(sname,ssalary,saddress) values ('shyam','20000','lalitpur');
    insert into staff(sname,ssalary,saddress) values ('hari','30000','ktm');
    insert into staff(sname,ssalary,saddress) values ('rita','10000','lalitpur');
    insert into staff(sname,ssalary,saddress) values ('ajay','20000','chitwan');
    insert into staff(sname,ssalary,saddress) values ('aakash','40000','biratnagar');
    
    insert into customer(cname,caddress) values ('sarfaraz','bagbazar');
    insert into customer(cname,caddress) values ('dhiraj','kamalpokhari');
    insert into customer(cname,caddress) values ('anoop','naxal');
    insert into employee(ename,eaddress) values ('ram','hadigaun');
    insert into employee(ename,eaddress) values ('shyam','combodia');
    insert into employee(ename,eaddress) values ('hari','chickenbazar');
     update customer set caddress='nayabazar' where cid=2;
     delete from customer where cid=2;
     
     select sum(ssalary)from staff;
     select min(ssalary) from staff;
     select max(ssalary) from staff;
     select avg(ssalary) from staff;
     select sum(ssalary),sname from staff group by sname;
     select e.ename,e.eaddress from employee e where e.eid in (select cid from customer where eaddress='chickenbazar');
     select * from staff;
     select * from customer;
     select * from employee;
    
    