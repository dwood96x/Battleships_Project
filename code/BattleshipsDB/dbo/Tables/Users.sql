CREATE TABLE Users 
	(userID INT identity NOT NULL PRIMARY KEY,
	 username varchar(30) NOT NULL,
	 password varchar(30) NOT NULL,
	 email varchar(50))