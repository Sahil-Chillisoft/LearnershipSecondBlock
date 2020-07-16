create database ChatApp

use ChatApp
go 

create table [Users]
(
	Id int not null primary key identity(1,1),
    FirstName varchar(100) not null, 
	LastName varchar(100) not null, 
	Email varchar(100) not null unique, 
	[Password] varchar(100) not null, 
	DateLastLoggedIn DateTime null
)

create table Channels
(
	Id int not null primary key identity(1,1), 
	[Name] varchar(100) not null, 
	Description varchar(100) not null,
	DateCreated Date not null default cast(getdate() as date), 
	UserIdCreatedBy int not null foreign key references [Users](Id)
)

create table [Messages]
(
	Id int not null primary key identity(1,1), 
	AuthorUserId int not null foreign key references [Users](Id), 
	RecipientUserId int not null foreign key references [Users](Id), 
	[Message] varchar(500) not null, 
	DateTimeOfMessage DateTime not null default getdate()
)

create table ChannelMessages
(
	Id int not null primary key identity(1,1), 
	ChannelId int not null foreign key references Channels(Id), 
	AuthorUserId int not null foreign key references [Users](Id), 
	[Message] varchar(500) not null, 
	DateTimeOfMessage DateTime not null default getdate()
)

create table ChannelMembers
(
	ChannelId int not null foreign key references Channels(Id), 
	UserId int not null foreign key references [Users](Id), 
	DateJoined Date not null default cast(getdate() as date), 
	primary key(ChannelId, UserId)
)