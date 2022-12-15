create schema F1;

create table F1.Teams(
id serial not null,
name varchar(50) not null,
base varchar(500) not null,
first_entry int not null,
chief varchar(50) not null,
primary key (id)
);

insert into F1.Teams(name, base, first_entry, chief) 
values ('Oracle Red Bull Racing','Milton Keynes, United Kingdom',1997,'Christian Horner'), 
('Scuderia Ferrari','Maranello, Italy',	1950,'Mattia Binotto'),
('Mercedes-AMG Petronas F1 Team','Brackley, United Kingdom',1970,'Toto Wolff'),
('BWT Alpine F1 Team','Enstone, United Kingdom',1986,'Otmar Szafnauer');

select * from F1.Teams;

create table F1.Drivers(
id serial not null,
name varchar(50) not null,
world_championships int not null,
country varchar(50) not null,
primary key (id),

team_id int,
CONSTRAINT fk_team_id
    foreign key(team_id)
        references F1.Teams(id)
);

insert into F1.Drivers(name, world_championships, country, team_id) 
values ('Fernando Alonso', 2,'Spain', 4),
('Max Verstappen', 2,'Netherlands', 1),
('Charles Leclerc', 0,'Monaco', 2),
('Lewis Hamilton', 7,'United Kingdom', 3);

select * from F1.Drivers;