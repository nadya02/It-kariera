create database MinionsDB;
use MinionsDB;

create table countries
(
	id bigint not null unique identity, primary key(id),
	Name varchar(30) not null
);

create table Towns
(
	id bigint not null unique identity, primary key(id),
	Name varchar(30) not null,
	CountryCode bigint not null, foreign key(CountryCode) references countries(id)
);

create table Minions
(
	id bigint not null identity, primary key(id),
	Name varchar(30) not null,
	Age int not null,
	TownId bigint not null, foreign key(TownId) references Towns(id)
);

create table EvilnessFactors
(
	id bigint not null identity, primary key(id),
	Name varchar(30) not null,
);

create table Villians
(
	id bigint not null identity, primary key(id),
	Name varchar(30) not null,
	EvilnessFactorId bigint not null, foreign key(EvilnessFactorId) references EvilnessFactors(id)
);

create table MinionsVillians
(
	MinionId bigint not null, foreign key(MinionId) references Minions(id),
	VillianId bigint not null, foreign key(VillianId) references Villians(id)
);

drop database MinionsDB;


INSERT INTO Countries VALUES ('Bulgaria'), 
('United Kingdom'),
('United States of America'),
('France');

INSERT INTO Towns (Name, CountryCode) VALUES ('Sofia',1), 
('Burgas',1), 
('Varna', 1), 
('London', 2),
('Liverpool', 2),
('Ocean City', 3),
('Paris', 4);

INSERT INTO Minions (Name, Age, TownId) VALUES ('bob',10,1),
('kevin',12,2),
('stuart',9,3), 
('rob',22,3),
('michael',5,2),
('pep',3,2);

INSERT INTO EvilnessFactors (Name) VALUES ('Super Good'),
('Good'),
('Bad'),
('Evil'),
('Super Evil');

INSERT INTO Villians (Name, EvilnessFactorId) VALUES ('Gru', 2),
('Victor', 4),
('Simon Cat', 3),
('Pusheen', 1),
('Mammal', 5);

insert into Villians(Name, EvilnessFactorId) values ('Bro', 4);

INSERT INTO MinionsVillians (MinionId, VillianId) VALUES (1, 2),
(3, 1),
(1, 3),
(3, 3),
(4, 1),
(2, 2),
(1, 1),
(3, 4),
(1, 4),
(1, 5),
(5, 1);

INSERT INTO MinionsVillians (MinionId, VillianId) VALUES (3, 2),
(4, 2),
(6, 1),
(2, 1);

--Problem 2--

select v.Name, Count(MinionId) as c
from Villians as v
join MinionsVillians
on id = VillianId
group by v.Name
having Count(MinionId) >= 3
order by c desc;

select v.Name, 
(select count(*) from MinionsVillians where VillianId = v.id) as Minion_Count
from villians as v
where (select count(*) from MinionsVillians where VillianId = v.id) > 3
order by Minion_Count desc;

--Problem 3--

select id from villians where id = 6;  

select Name from villians where id = 2;

select m.Name, m.Age
from Minions as m
join MinionsVillians as mv
on mv.MinionId = m.id
where mv.VillianId = 6
order by m.Name asc;



--Problem 4--

select Name from Towns where Name = 'Sofia';
