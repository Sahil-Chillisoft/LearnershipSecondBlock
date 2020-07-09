create database ChatApp

use ChatApp
go 

create table [Users]
(
	Id int not null primary key identity(1,1), 
	Username varchar(100) not null, 
	Password varchar(100) not null, 
	DateLastLoggedIn DateTime null
)

create table Channels
(
	Id int not null primary key identity(1,1), 
	[Name] varchar(100) not null, 
	DateCreated DateTime not null default getdate(), 
	UserIdCreatedBy int not null foreign key references [User](Id)
)

create table [Messages]
(
	Id int not null primary key identity(1,1), 
	AuthorUserId int not null foreign key references [User](Id), 
	RecipientUserId int not null foreign key references [User](Id), 
	[Message] varchar(500) not null, 
	DateTimeOfMessage DateTime not null default getdate()
)

create table ChannelMessages
(
	Id int not null primary key identity(1,1), 
	ChannelId int not null foreign key references Channel(Id), 
	AuthorUserId int not null foreign key references [User](Id), 
	[Message] varchar(500) not null, 
	DateTimeOfMessage DateTime not null default getdate()
)


create table ChannelMembers
(
	ChannelId int not null foreign key references Channel(Id), 
	UserId int not null foreign key references [User](Id), 
	DateJoined Date not null, 
	primary key(ChannelId, UserId)
)