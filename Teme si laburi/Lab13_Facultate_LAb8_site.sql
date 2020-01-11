--LAb13 Fac

--Lab 8 site

select * 
from user_tables;

select * 
from user_tables;
--Ex 1+18+2
create table ANGAJATI (
  cod_ang number(4) constraint ang_pk primary key, 
  nume varchar2(20) not null, 
  prenume varchar2(20), 
  email char(15) unique ,
  data_ang date default sysdate, 
  job varchar2(10), 
  cod_sef number(4) constraint cod_sef_fk references angajati(cod_ang) , 
  salariu number(8, 2) constraint verif_sal not null, 
  cod_dep number(2) constraint valid_dep check(cod_dep>0),
  comision number(2,2),
  constraint u_nume_pren unique (nume,prenume),
  constraint valid_com check (salariu > comision*100)
  );
  
insert into ANGAJATI
values (100,'Nume1','Prenume1',null,null,'Director',null,20000,10,null);

insert into ANGAJATI
values (101,'Nume2','Prenume2','Nume2',to_date('02-02-2004','dd-mm-yyyy'),'Inginer',100,20000,10,null);

insert into ANGAJATI
values (102,'Nume3','Prenume3','Nume3',to_date('05-06-2000','dd-mm-yyyy'),'Analist',101,5000,20,0.1);

insert into ANGAJATI
values (103,'Nume4','Prenume4',null,null,'Inginer',100,9000,20,null);

insert into ANGAJATI
values (104,'Nume5','Prenume5','Nume5',null,'Analist',101,3000,30,0.1);

--ex3
create table angajatii10
as
select *
from angajati
where cod_dep = 10;

--ex4
alter table angajati
add com number(4,2);
--ex 5
alter table angajati
modify (salariu number(6,2));
--ex 6
alter table angajati
modify (salariu number(8,2) default 1000);
--ex 7
alter table angajati
modify (com number(2,2), salariu number(10,2));

--ex 9
select nume, length(nume)
from angajati;

alter table angajati
modify email varchar(15);

--ex10
alter table angajati
add(nr_telefon varchar(10) default '0213182453');

alter table angajati
drop column nr_telefon;
--15
create table DEPARTAMENTE (
  cod_dep number(2) primary key, 
  nume varchar2(15) not null, 
  cod_director number(4) );
  
insert into departamente 
values (10,'Administrativ',100);
insert into departamente 
values (20,'Proiectare',101);
insert into departamente 
values (30,'Programare',null);

truncate table departamente;
commit;

alter table angajati
add constraint fk_cod_dep foreign key(cod_dep)
references  departamente(cod_dep) on delete cascade;

delete from departamente 
where cod_dep = 20;
rollback;

alter table angajati add check(salariu > 100000);





