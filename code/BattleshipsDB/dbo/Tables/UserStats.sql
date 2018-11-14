CREATE TABLE UserStats 
	(userID INT identity NOT NULL PRIMARY KEY FOREIGN KEY REFERENCES Users(userID),
	 totalgames smallint,
	 gameswon smallint,
	 gameslost smallint)