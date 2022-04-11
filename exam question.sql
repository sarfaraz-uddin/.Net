create database examque;
use examque;
create table employee(
employee_name varchar(20) primary key,
street varchar(40),
city varchar(40)
);
create table company(
company_name varchar(40) primary key,
city varchar(40)
);
create table works(
employee_name varchar(40),
company_name varchar(40),
salary int,
primary key(employee_name,company_name),
foreign key(employee_name)references employee(employee_name),
foreign key(company_name)references company(company_name)
);
insert into employee values("anoop","naxal","kathmandu");
insert into company values("xyz","bhaktapur");
insert into works values("anoop","xyz",90000);
select employee_name,street,city from employee where employee_name in(select employee_name from works where company_name="xyz" and salary>35000);
select employee_name from employee where employee_name in (select employee_name from works where company_name="xyz" and salary<5000);
