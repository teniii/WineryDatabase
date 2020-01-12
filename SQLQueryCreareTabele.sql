/*
create table crama..Concursuri (
	ID_Concurs int constraint id_conc_pk primary key,
	Nume_concurs varchar(20) constraint nume_nenul not null,
	Data date constraint data_nenula not null,
	Editie int constraint editie_nenula not null,
	Localitate varchar(15),
	Stat varchar(10) );

Create table crama..Vinuri (
	Cod_de_bare int constraint cod_bare_pk primary key,
	Tip varchar (10) constraint tip_nenul not null,
	Soi varchar (30),
	Culoare varchar(5) constraint culoare_nenula not null,
	Alcool tinyint constraint alc_nenul not null,
	Pret float constraint pret_nenul not null );

create table crama..Premii (
	ID_Concurs int constraint id_concurs_fk 
		references crama..Concursuri (ID_Concurs) on delete cascade,
	Cod_de_bare int constraint cod_bare_fk 
		references crama..Vinuri (Cod_de_bare) on delete cascade,
	Medalia varchar (10),
	Descriere varchar(30),
	constraint id_conc_cod_bare_pk primary key (ID_Concurs, Cod_de_bare) );

create table crama..Parcele (
	ID_Parcela int constraint id_parcela_pk primary key,
	Suprafata int constraint supraf_nenul not null,
	Tip_de_sol varchar (30),
	Cod_de_bare int constraint cod_de_bare_fk 
		references crama..Vinuri(Cod_de_bare) on delete set null );

Create table crama..Angajati (
	CNP_Angajat bigint constraint cnp_ang_pk primary key,
	Nume varchar (15) constraint nume_nenul not null,
	Prenume varchar (15) constraint prenume_nenul not null,
	Data_nasterii date constraint nastere_nenul not null,
	Salariu int  constraint salariu_valid check(salariu >=0) );


Create table crama..Repartizare_Parcele (
	ID_Parcela int constraint id_parcela_fk
		references crama..Parcele (ID_Parcela) on delete cascade,
	CNP_Angajat bigint constraint cnp_angajat_fk 
		references crama..Angajati (CNP_Angajat) on delete cascade,
	Functie varchar(15) constraint functie_nenula not null,
	Data_inceput date constraint data_nenula not null,
	constraint id_parc_cnp_ang_pk primary key (ID_Parcela, CNP_Angajat) );

create table crama..Utilaje (
	Serie_sasiu varchar(17) constraint sasiu_pk primary key,
	Marca varchar(15) constraint marca_nenula not null,
	Model varchar(15) constraint model_nenula not null,
	An_fabricatie int constraint an_fabr_nenul not null,
	Data_expirare_garantie date,
	Functie varchar(30) constraint functie_nenula not null ,
	CNP_Angajat bigint constraint cnp_ang_fk 
		references crama..Angajati (CNP_Angajat) on delete set null );

create table crama..Evenimente_interne (
	ID_Eveniment int constraint id_event_pk primary key,
	Data date constraint data_nenula not null,
	Scop varchar(20) constraint scop_nenul not null,
	Durata int constraint durata_nenula not null,
	CNP_Angajat bigint constraint Cnp_Angaj_fk 
		references crama..Angajati (CNP_Angajat) on delete set null );

create table crama..Clienti (
	CNP_Client bigint constraint cnp_client_pk primary key,
	Nume varchar(15) constraint nume_client_nenul not null,
	Prenume varchar(15) constraint prenume_client_nenul not null,
	Data_nasterii date,
	Data_inscrierii date constraint data_inscr_nenula not null ) ;

create table crama..Istoric_Evenimente (
	ID_Eveniment int constraint id_event_fk 
		references crama..Evenimente_Interne (ID_Eveniment) on delete cascade,
	CNP_Client bigint constraint cnp_client_fk 
		references crama..Clienti (CNP_Client) on delete cascade,
	Nota_feedback tinyint constraint nota_valida
		check(Nota_feedback >= 1 and Nota_feedback <= 10),
	constraint id_event_cnp_client_pk primary key (ID_Eveniment, CNP_Client) );
	*/


/*
insert into crama..Angajati
values (6010519243431,'Popescu','Ileana','2001-05-19',2000);
insert into crama..Angajati
values (1870516438160,'Dumitru','Laurentiu','1987-05-16',4500);
insert into crama..Angajati
values (1970617429782,'Petrescu','Marian','1997-06-17',3000);

insert into crama..Clienti
values (1980907417541,'Ionescu','Dimitrie','1998-09-07','2018-05-19');
insert into crama..Clienti
values (1871118319245,'Ionescu','Dimitrov','1965-03-15','2010-07-25');

insert into crama..Concursuri
values (1,'WineFest','2014-02-25',7,'Brasov','Romania');

insert into crama..Evenimente_interne
values (1,'2010-07-25','Degustare vin rosu',120,6010519243431);

insert into crama..Istoric_Evenimente
values (1,1871118319245, 7);

insert into crama..Parcele
values (1,400,'spodosol',36155654);

insert into crama..Premii
values (1,36155654, 'argint','un vin deosebit');

insert into crama..Repartizare_Parcele
values (1,1870516438160,'supervizor','2010-03-17');

insert into crama..Utilaje
values ('IHGCM82633A004352','JCB','535-95',2014, null,'transporta butoaiele',1970617429782);

insert into crama..Vinuri
values (36155654, 'demi-sec','riesling','alb',12,65);
*/




