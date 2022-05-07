set dateformat mdy
create database kurs1
Go
Use kurs1
Go

create TABLE applicant --�������� ������� ����������
(
applicant_id				int							identity(1,1)								primary key,
apname						varchar(50)																not null, --��� ���������� 
apsurname					varchar(50)																not null, --������� ����������
appatronymic				varchar(50)																		, --�������� ����������
ap_date_of_birth			smalldatetime															not null, --���� �������� ����������
ap_gender					varchar(20)																not null, --��� ����������
apphone						bigint																	not null, --����� �������� ����������
apmail						varchar(50)																		, --����������� ����� ����������
apiin						char(50)														 not null unique, --��� ����������
apaddres					varchar(50)																not null, --����� ����������
RWVR						ROWVERSION																
)




create TABLE customer --�������� ������� ��������
(
customer_id					int							identity(1,1)								primary key,
cuname						varchar(50)																not null, --��� ��������� 
cusurname					varchar(50)																not null, --������� ��������� 
cupatronymic				varchar(50)																		, --�������� ��������� 
cuphone						bigint																	not null, --����� �������� ��������� 
cumail						varchar(50)																not null, --����������� ����� ��������� 
cuiin						char(50)																not null unique, --��� ��������� 
RWVR						ROWVERSION
)




create TABLE staffagen --�������� ������� ��������
(
staffagen_id				int							identity(1,1)								primary key,
stname						varchar(50)																not null, --��� ���������
stsurname					varchar(50)																not null, --������� ���������
stpatronymic				varchar(50)																		, --�������� ���������
st_gender					varchar(50)																not null, --��� ���������
stphone						bigint																	not null, --����� �������� ���������
stiin						char(50)														 not null unique, --��� ���������
stmail						varchar(50)																not null, --����������� ����� ���������
RWVR						ROWVERSION
)




create TABLE resum --�������� ������� ������
(
resum_id					int							identity(1,1)								primary key,
fk_applicant				int																		not null, --���������� 
spec						varchar(90)																not null, --������������� ���������� 
skill						varchar(90)																not null, --������ ���������� 
workex						tinyint																		not null, --���� ������ ���������� 
RWVR						ROWVERSION
)




create TABLE candidatlog -- �������� ������� 
(
candidatlog_id				int							identity(1,1)								primary key,
fk_staffagen				int																		not null, --��������
fk_castomer					int																		not null, --�������� 
fk_applicant				int																		not null, --����������
date_meeting				smalldatetime															not null, --���� ������������� ����������
scoreme						tinyint					check(scoreme>0 and scoreme<101) 				not null, --����� ������������� ����������
fk_status					int																		not null, --��������� ����������
RWVR						ROWVERSION
)


--��� ������� ��� ������������ 
create TABLE statust --�������� ������� ������ (���)
(
statust_id					int					identity										primary key,
sta							varchar(20)																not null, --������ ����������
RWVR						ROWVERSION
)




--------------------------------------------------------------------------------------------------------------------
create TABLE Regist --�������� ������� ����������� (prg)
(
use_id						int						identity									 primary key,
log_user					varchar(50)																not null, --����� ������������ 
pass_user					varchar(50)																not null, --������ ������������
RWVR						ROWVERSION
)
--------------------------------------------------------------------------------------------------------------------




--������� �����
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





--������ � ������� ����������� �������������
--------------------------------------------------------------------------------------------------------------------
INSERT INTO regist (log_user, pass_user)--����������� 1 ������������ 
VALUES
('user1', 'admin')

INSERT INTO regist (log_user, pass_user)--����������� 2 ������������ 
VALUES
('user2', 'admin')

INSERT INTO regist (log_user, pass_user)--����������� 3 ������������ 
VALUES
('user3', 'admin')

INSERT INTO regist (log_user, pass_user)--����������� 4 ������������ 
VALUES
('Aryslan', 'admin1')
--------------------------------------------------------------------------------------------------------------------




--��� ������ ����� �������������
DECLARE @statust1  tinyint, @statust2 tinyint
INSERT INTO statust (sta)
VALUES
( '������' )--1 ��������� ����������
SELECT @statust1  = @@identity

INSERT INTO statust (sta)
VALUES
( '�� ������' )--2 ��������� ����������
SELECT @statust2 = @@identity




--������ � ������� �����������
DECLARE @applicant1 tinyint, @applicant2 tinyint,  @applicant3 tinyint, @applicant4 tinyint, @applicant5 tinyint
INSERT INTO applicant (apname, apsurname, appatronymic, ap_date_of_birth, ap_gender, apphone, apmail, apiin, apaddres)
VALUES
('Charles',		'Kudryavtsev',		'Sergeevich',		'01/10/82',		'�������',	87773462354,	'Charles@mail.ru',		'675328535371',		'Satpaev Street 29/6')--1
SELECT @applicant1 = @@identity

INSERT INTO applicant (apname, apsurname, appatronymic, ap_date_of_birth, ap_gender, apphone, apmail, apiin, apaddres)
VALUES
('Leona',		'Fedotov',			'Valentinova',		'07/16/82',		'�������',	87772462574,	  'Leona@mail.ru',		'104876034835',		 'Dostyk Street 52/2')--2
SELECT @applicant2 = @@identity

INSERT INTO applicant (apname, apsurname, appatronymic, ap_date_of_birth, ap_gender, apphone, apmail, apiin, apaddres)
VALUES
('Panteon',		'Fedov',			'Charovich',		'03/22/92',		'�������',	87774638856,	  'Panteon@mail.ru',	'473820463827',		 'Abay Street 32/4'	 )--3
SELECT @applicant3 = @@identity

INSERT INTO applicant (apname, apsurname, appatronymic, ap_date_of_birth, ap_gender, apphone, apmail, apiin, apaddres)
VALUES
('Feder',		'Anatoli',			'Andreivich',		'10/03/79',		'�������',	87775874684,	  'Feder@mail.ru',		'840927593745',		 'Shevchenka Street 33')--4
SELECT @applicant4 = @@identity

INSERT INTO applicant (apname, apsurname, appatronymic, ap_date_of_birth, ap_gender, apphone, apmail, apiin, apaddres)
VALUES
('Ali',			'Burat',			'Akeychanuly',		'08/29/90',		'�������',	87776475744,	  'Ali@mail.ru',		'362918564638',		 'Shevchenka Street 111')--5
SELECT @applicant5 = @@identity




--������ � ������� ��������
DECLARE @customer1 tinyint, @customer2 tinyint
INSERT INTO customer (cuname, cusurname, cupatronymic, cuphone, cumail, cuiin)
VALUES
('Serdyuk',		'Shamil',		'Anatolyevich',		87775475369,	'Serdyuk@mail.ru',		252375293196)--1
SELECT @customer1 = @@identity

INSERT INTO customer (cuname, cusurname, cupatronymic, cuphone, cumail, cuiin)
VALUES
('Vitaly',		'Frolov',		'Grigorievich',		87772456724,	'Vitaly@mail.ru',		842745028476)--2
SELECT @customer2 = @@identity




--������ � ������� ������ ��������
DECLARE @staffagent1 tinyint, @staffagent2 tinyint, @staffagent3 tinyint, @staffagent4 tinyint, @staffagent5 tinyint, 
@staffagent6 tinyint, @staffagent7 tinyint, @staffagent8 tinyint, @staffagent9 tinyint, @staffagent10 tinyint
INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Trofim',		'Kopylov',			'Evgenievich',		'�������',	87774536454,	746593727642, 'Trofim@mail.ru')--1
SELECT @staffagent1 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Charles',		'Kudryavtsev',		'Sergeevich',		'�������',	87773462368,	373926593947, 'Charles@mail.ru')--2
SELECT @staffagent2 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Tomi',		'Jarvis',			'Anatolivich',		'�������',	87773957304,	489374658374, 'Tomi@mail.ru')--3
SELECT @staffagent3 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Ana',		'Evaliv',			'Valentinova',			'�������',	87773884736,	490028364735, 'Ana@mail.ru')--4
SELECT @staffagent4 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Elena',		'Sagievna',			'Evovish',			'�������',	87775938846,	263748936483, 'Elena@mail.ru')--5
SELECT @staffagent5 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Kail',		'Krein',			'',					'�������',	87774805847,	836252736453, 'Kail@mail.ru')--6
SELECT @staffagent6 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Judy',		'Merguit',			'Hoops',			'�������',	87774995824,	249583687483, 'Judy@mail.ru')--7
SELECT @staffagent7 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Calliope',		'Mori',			'Shinigami',		'�������',	87773566656,	257757866504, 'Calli@mail.ru')--8
SELECT @staffagent8 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Jaid',		'Zandra',			'Mervin',			'�������',	87772888495,	385735592992, 'Jeid@mail.ru')--9
SELECT @staffagent9 = @@identity

INSERT INTO staffagen (stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail)
VALUES
('Gael',		'Shollz',			'Charington',		'�������',	87775005983,	465666382640, 'Gael@mail.ru')--10
SELECT @staffagent10 = @@identity





--������ � ������� ������ ����������
DECLARE @resum1 tinyint, @resum2 tinyint
INSERT INTO resum (fk_applicant, spec, skill, workex)
VALUES
(@applicant1, 'technical consultants', 'understand the technique', 3)--1
SELECT @resum1 = @@identity

INSERT INTO resum (fk_applicant, spec, skill, workex)
VALUES
(@applicant2, 'dev programmer', 'coding C#', 5)--2
SELECT @resum2 = @@identity




--������ � ������� ������ ���������� ����������� � �� ��������� 
DECLARE @candidatlog1 tinyint, @candidatlog2 tinyint
INSERT INTO candidatlog (fk_staffagen, fk_castomer, fk_applicant, date_meeting, scoreme, fk_status)
VALUES
(@staffagent1, @customer1, @applicant1, '11/26/22', 47, @statust1)--1
SELECT @candidatlog1 = @@identity

INSERT INTO candidatlog (fk_staffagen, fk_castomer, fk_applicant, date_meeting, scoreme, fk_status)
VALUES
(@staffagent2, @customer2, @applicant2, '11/20/22', 89, @statust2)--2
SELECT @candidatlog2 = @@identity


--��������� ��������� 
GO
CREATE PROC CustP --�������� ���������
@�name						varchar(50), --��������� ��� ��������� 
@�surname					varchar(50), --������� ��������� 
@�patronymic				varchar(50), --�������� ��������� 
@�contact						bigint, --����� �������� ��������� 
@�email						varchar(50), --����������� ����� ��������� 
@�iin						char(50)   --��� ��������� 
AS
BEGIN
INSERT INTO customer (cuname, cusurname, cupatronymic, cuphone, cumail, cuiin) VALUES (@�name, @�surname, @�patronymic,@�contact, @�email, @�iin)
END


--����� ������
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