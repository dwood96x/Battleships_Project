Use Battleships;

DROP TABLE IF EXISTS MetaData, Matchdata, UserStats, Users;

CREATE TABLE Users 
	(userID INT identity NOT NULL PRIMARY KEY,
	 username varchar NOT NULL,
	 password varchar NOT NULL,
	 email varchar)

CREATE TABLE UserStats 
	(userID INT identity NOT NULL PRIMARY KEY FOREIGN KEY REFERENCES Users(userID),
	 totalgames smallint,
	 gameswon smallint,
	 gameslost smallint)

CREATE TABLE Matchdata
	(matchID bigint identity PRIMARY KEY,
	playeroneID int FOREIGN KEY REFERENCES UserStats(UserID),
	playertwoID int FOREIGN KEY REFERENCES UserStats(UserID),
	winner int FOREIGN KEY REFERENCES UserStats(UserID),
	roundlength tinyint)

CREATE TABLE Metadata
	(matchID bigint PRIMARY KEY FOREIGN KEY REFERENCES Matchdata(matchID),
	data datetime,
	version varchar)

SELECT * FROM Users;