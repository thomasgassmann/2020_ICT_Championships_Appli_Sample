drop database if exists TourCtrl;

go

create database TourCtrl;

go

use TourCtrl;

go

create table Game(
	ID integer primary key identity(1, 1),
	Name varchar(100) not null
);

create table Participant(
	ID integer primary key identity(1, 1),
	Name varchar(100) not null,
	IsTemporary bit not null,
	IsTeam bit not null
);	

create table Tournament(
	ID integer primary key identity(1, 1),
	Title varchar(100) not null,
	GameID integer foreign key references Game(ID),
	Size integer,
	WinnerParticipantID integer foreign key references Participant(ID),
	TournamentState integer not null
);

create table ParticipantInTournament(
	ID integer primary key identity(1, 1),
	TournamentID integer foreign key references Tournament(ID),
	ParticipantID integer foreign key references Participant(ID)
);

create table Match(
	ID integer primary key identity(1, 1),
	TournamentID integer foreign key references Tournament(ID),
	Participant1ID integer foreign key references Participant(ID),
	Participant2ID integer foreign key references Participant(ID),
	Stage integer not null,
	[Order] integer not null,
	WinnerParticipantID integer foreign key references Participant(ID)
);


insert into Game(Name) values ('Overwatch'), ('GTA');