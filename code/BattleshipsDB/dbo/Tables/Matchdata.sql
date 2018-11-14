CREATE TABLE Matchdata
	(matchID bigint identity PRIMARY KEY,
	playeroneID int FOREIGN KEY REFERENCES UserStats(UserID),
	playertwoID int FOREIGN KEY REFERENCES UserStats(UserID),
	winner int FOREIGN KEY REFERENCES UserStats(UserID),
	roundlength tinyint)