use sarfaraz;

create view customer2 as select cid,cname from customer where cname="sarfaraz";
drop view customer2;
select * from customer;
insert into customer2(cid,cname) values(4,'sarfaraz');

desc customer;