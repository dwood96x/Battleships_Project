CREATE TABLE Metadata
	(matchID bigint PRIMARY KEY FOREIGN KEY REFERENCES Matchdata(matchID),
	data datetime,
	version varchar)