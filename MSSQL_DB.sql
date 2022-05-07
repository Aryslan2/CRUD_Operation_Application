set dateformat mdy
create database kurs1
Go
Use kurs1
Go

create TABLE applicant --создание таблицы соискатель
(
applicant_id				int							identity(1,1)								primary key,
apname						varchar(50)																not null, --имя соискателя 
apsurname					varchar(50)																not null, --фамилия соискателя
appatronymic				varchar(50)																		, --отчество соискателя
ap_date_of_birth			smalldatetime															not null, --дата рождения соискателя
ap_gender					varchar(20)																not null, --пол соискателя
apphone						bigint																	not null, --номер телефона соискателя
apmail						varchar(50)																		, --электронная почта соискателя
apiin						char(50)														 not null unique, --ИИН соискателя
apaddres					varchar(50)																not null, --адрес соискателя
RWVR						ROWVERSION																
)




create TABLE customer --создания таблицы заказчик
(
customer_id					int							identity(1,1)								primary key,
cuname						varchar(50)																not null, --имя заказчика 
cusurname					varchar(50)																not null, --фамилия заказчика 
cupatronymic				varchar(50)																		, --отчество заказчика 
cuphone						bigint																	not null, --номер телефона заказчика 
cumail						varchar(50)																not null, --электронная почта заказчика 
cuiin						char(50)																not null unique, --ИИН заказчика 
RWVR						ROWVERSION
)




create TABLE staffagen --создания таблицы работник
(
staffagen_id				int							identity(1,1)								primary key,
stname						varchar(50)																not null, --имя работника
stsurname					varchar(50)																not null, --фамилия работника
stpatronymic				varchar(50)																		, --отчество работника
st_gender					varchar(50)																not null, --пол работника
stphone						bigint																	not null, --номер телефона работника
stiin						char(50)														 not null unique, --ИИН работника
stmail						varchar(50)																not null, --электронная почта работника
RWVR						ROWVERSION
)




create TABLE resum --создания таблицы резюме
(
resum_id					int							identity(1,1)								primary key,
fk_applicant				int																		not null, --соискатель 
spec						varchar(90)																not null, --специальность соискателя 
skill						varchar(90)																not null, --навыки соискателя 
workex						tinyint																		not null, --опыт работы соискателя 
RWVR						ROWVERSION
)




create TABLE candidatlog -- создание журнала 
(
candidatlog_id				int							identity(1,1)								primary key,
fk_staffagen				int																		not null, --работник
fk_castomer					int																		not null, --заказчик 
fk_applicant				int																		not null, --соискатель
date_meeting				smalldatetime															not null, --дата собеседования соискателя
scoreme						tinyint					check(scoreme>0 and scoreme<101) 				not null, --баллы собеседования соискателя
fk_status					int																		not null, --положение соискателя
RWVR						ROWVERSION
)


--НСИ таблицы для нормализации 
create TABLE statust --создания таблицы статус (НСИ)
(
statust_id					int					identity										primary key,
sta							varchar(20)																not null, --Статус соискателя
RWVR						ROWVERSION
)




--------------------------------------------------------------------------------------------------------------------
create TABLE Regist --создание таблицы регистрация (prg)
(
use_id						int						identity									 primary key,
log_user					varchar(50)																not null, --Логин пользователя 
pass_user					varchar(50)																not null, --Пароль пользователя
RWVR						ROWVERSION
)
--------------------------------------------------------------------------------------------------------------------




--внешние ключи
ALTER TABLE resum
ADD FOREIGN KEY (fk_applicant) references applicant (applicant_id)

ALTER TABLE candidatlog
ADD FOREIGN KEY (fk_staffagen) references staffagen (staffagen_id)

ALTER TABLE candidatlog
ADD FOREIGN KEY (fk_castomer) references customer (customer_id)

ALTER TABLE candidatlog
ADD FOREIGN KEY (fk_applicant) references applicant (applicant_id)

ALTER TABLE candidatlog
ADD FOREIGN KEY (fk_status) references statust (statust_id)





--Запись в таблицу регистраций пользователей
--------------------------------------------------------------------------------------------------------------------
INSERT INTO regist (log_user, pass_user)--регистрация 1 пользователя 
VALUES
('user1', 'admin')

INSERT INTO regist (log_user, pass_user)--регистрация 2 пользователя 
VALUES
('user2', 'admin')

INSERT INTO regist (log_user, pass_user)--регистрация 3 пользователя 
VALUES
('user3', 'admin')

INSERT INTO regist (log_user, pass_user)--регистрация 4 пользователя 
VALUES
('Aryslan', 'admin1')
--------------------------------------------------------------------------------------------------------------------




--НСИ статус после собеседования
DECLARE @statust1  tinyint, @statust2 tinyint
INSERT INTO statust (sta)
VALUES
( 'Прошел' )--1 состояние соискателя
SELECT @statust1  = @@identity

INSERT INTO statust (sta)
VALUES
( 'Не прошел' )--2 состояние соискателя
SELECT @statust2 = @@identity




--Запись в таблицу соискателей
DECLARE @applicant1 tinyint, @applicant2 tinyint,  @applicant3 tinyint, @applicant4 tinyint, @applicant5 tinyint
INSERT INTO applicant (apname, apsurname, appatronymic, ap_date_of_birth, ap_gender, apphone, apmail, apiin, apaddres)
VALUES
('Charles',		'Kudryavtsev',		'Sergeevich',		'01/10/82',		'Мужской',	87773462354,	'Charles@mail.ru',		'675328535371',		'Satpaev Street 29/6')--1
SELECT @applicant1 = @@identity

INSERT INTO applicant (apname, apsurname, appatronymic, ap_date_of_birth, ap_gender, apphone, apmail, apiin, apaddres)
VALUES
('Leona',		'Fedotov',			'Valentinova',		'07/16/82',		'Женский',	87772462574,	  'Leona@mail.ru',		'104876034835',		 'Dostyk Street 52/2')--2
SELECT @applicant2 = @@identity

INSERT INTO applicant (apname, apsurname, appatronymic, ap_date_of_birth, ap_gender, apphone, apmail, apiin, apaddres)
VALUES
('Panteon',		'Fedov',			'Charovich',		'03/22/92',		'Мужской',	87774638856,	  'Panteon@mail.ru',	'473820463827',		 'Abay Street 32/4'	 )--3
SELECT @applicant3 = @@identity

INSERT INTO applicant (apname, apsurname, appatronymic, ap_date_of_birth, ap_gender, apphone, apmail, apiin, apaddres)
VALUES
('Feder',		'Anatoli',			'Andreivich',		'10/03/79',		'Мужской',	87775874684,	  'Feder@mail.ru',		'840927593745',		 'Shevchenka Street 33')--4
SELECT @applicant4 = @@identity

INSERT INTO applicant (apname, apsurname, appatronymic, ap_date_of_birth, ap_gender, apphone, apmail, apiin, apaddres)
VALUES
('Ali',			'Burat',			'Akeychanuly',		'08/29/90',		'Мужской',	87776475744,	  'Ali@mail.ru',		'362918564638',		 'Shevchenka Street 111')--5
SELECT @applicant5 = @@identity




--Запись в таблицу заказчик
DECLARE @customer1 tinyint, @customer2 tinyint
INSERT INTO customer (cuname, cusurname, cupatronymic, cuphone, cumail, cuiin)
VALUES
('Serdyuk',		'Shamil',		'Anatolyevich',		87775475369,	'Serdyuk@mail.ru',		252375293196)--1
SELECT @customer1 = @@identity

INSERT INTO customer (cuname, cusurname, cupatronymic, cuphone, cumail, cuiin)
VALUES
('Vitaly',		'Frolov',		'Grigorievich',		87772456724,	'Vitaly@mail.ru',		842745028476)--2
SELECT @customer2 = @@identity




--Запись в таблицу рабочи персонал
DECLARE @staffagent1 tinyint, @staffagent2 tinyint, @staffagent3 tinyint, @staffagent4 tinyint, @staffagent5 tinyint, 
@staffagent6 tinyint, @staffagent7 tinyint, @staffagent8 tinyint, @staffagent9 tinyint, @staffagent10 tinyint
INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Trofim',		'Kopylov',			'Evgenievich',		'Мужской',	87774536454,	746593727642, 'Trofim@mail.ru')--1
SELECT @staffagent1 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Charles',		'Kudryavtsev',		'Sergeevich',		'Мужской',	87773462368,	373926593947, 'Charles@mail.ru')--2
SELECT @staffagent2 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Tomi',		'Jarvis',			'Anatolivich',		'Мужской',	87773957304,	489374658374, 'Tomi@mail.ru')--3
SELECT @staffagent3 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Ana',		'Evaliv',			'Valentinova',			'Женский',	87773884736,	490028364735, 'Ana@mail.ru')--4
SELECT @staffagent4 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Elena',		'Sagievna',			'Evovish',			'Женский',	87775938846,	263748936483, 'Elena@mail.ru')--5
SELECT @staffagent5 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Kail',		'Krein',			'',					'Мужской',	87774805847,	836252736453, 'Kail@mail.ru')--6
SELECT @staffagent6 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Judy',		'Merguit',			'Hoops',			'Женский',	87774995824,	249583687483, 'Judy@mail.ru')--7
SELECT @staffagent7 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Calliope',		'Mori',			'Shinigami',		'Женский',	87773566656,	257757866504, 'Calli@mail.ru')--8
SELECT @staffagent8 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Jaid',		'Zandra',			'Mervin',			'Женский',	87772888495,	385735592992, 'Jeid@mail.ru')--9
SELECT @staffagent9 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Gael',		'Shollz',			'Charington',		'Мужской',	87775005983,	465666382640, 'Gael@mail.ru')--10
SELECT @staffagent10 = @@identity





--Запись в таблицу резюме соискателя
DECLARE @resum1 tinyint, @resum2 tinyint
INSERT INTO resum (fk_applicant, spec, skill, workex)
VALUES
(@applicant1, 'technical consultants', 'understand the technique', 3)--1
SELECT @resum1 = @@identity

INSERT INTO resum (fk_applicant, spec, skill, workex)
VALUES
(@applicant2, 'dev programmer', 'coding C#', 5)--2
SELECT @resum2 = @@identity




--Запись в таблицу журнал информаций соискателей и их состояния 
DECLARE @candidatlog1 tinyint, @candidatlog2 tinyint
INSERT INTO candidatlog (fk_staffagen, fk_castomer, fk_applicant, date_meeting, scoreme, fk_status)
VALUES
(@staffagent1, @customer1, @applicant1, '11/26/22', 47, @statust1)--1
SELECT @candidatlog1 = @@identity

INSERT INTO candidatlog (fk_staffagen, fk_castomer, fk_applicant, date_meeting, scoreme, fk_status)
VALUES
(@staffagent2, @customer2, @applicant2, '11/20/22', 89, @statust2)--2
SELECT @candidatlog2 = @@identity


--прописака процедуры 
GO
CREATE PROC CustP --хранимая процедура
@сname						varchar(50), --процедура имя заказчика 
@сsurname					varchar(50), --фамилия заказчика 
@сpatronymic				varchar(50), --отчество заказчика 
@сcontact						bigint, --номер телефона заказчика 
@сemail						varchar(50), --электронная почта заказчика 
@сiin						char(50)   --ИИН заказчика 
AS
BEGIN
INSERT INTO customer (cuname, cusurname, cupatronymic, cuphone, cumail, cuiin) VALUES (@сname, @сsurname, @сpatronymic,@сcontact, @сemail, @сiin)
END


--Вывод таблиц
GO
SELECT * FROM regist		--+
SELECT * FROM statust		--1
SELECT * FROM applicant		--2
SELECT * FROM customer		--3
SELECT * FROM staffagen		--4
SELECT * FROM resum			--5
SELECT * FROM candidatlog	--6

--use master 
--Drop database kurs1