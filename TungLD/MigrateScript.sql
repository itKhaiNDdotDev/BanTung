CREATE TABLE Services
(
	Id int PRIMARY KEY,
	Name NVarchar(255) NOT NULL
);

CREATE TABLE Roles
(
	Id int PRIMARY KEY,
	Name NVarchar(255) NOT NULL
);

CREATE TABLE SiginMethods
(
	Id int PRIMARY KEY,
	Name NVarchar(255) NOT NULL
);

CREATE TABLE Statuses
(
	Id int PRIMARY KEY,
	Name NVarchar(255) NOT NULL
);

CREATE TABLE Users
(
	UserId VARCHAR(100) PRIMARY KEY,
	RoleId int NOT NULL,
	SigninMethodId int NOT NULL,
	Status int NOT NULL,
	FOREIGN KEY (RoleId) REFERENCES Roles(Id),
	FOREIGN KEY (SigninMethodId) REFERENCES SiginMethods(Id),
	FOREIGN KEY (Status) REFERENCES Statuses(Id),
);

CREATE TABLE UserServices
(
	Id int PRIMARY KEY,
	UserId VARCHAR(100) NOT NULL,
	ServiceId int NOT NULL,
	FOREIGN KEY (UserId) REFERENCES Users(UserId),
	FOREIGN KEY (ServiceId) REFERENCES Services(Id)
);