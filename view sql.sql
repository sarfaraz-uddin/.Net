use sarfaraz;

create view customer2 as select cid,cname,caddress from customer where cname="sarfaraz";
drop view customer2;
select * from customer2;
insert into customer2 (cid,cname,caddress) values(6,'anoop','kirtipur');

desc customer;
create table employee(
eid int primary key,
ename varchar(20) not null,
eaddress varchar(20) not null,
phoneno bigint
);