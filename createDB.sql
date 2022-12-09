GO
CREATE SCHEMA [ABN-Amro_Assignment]


GO
CREATE TABLE FizzBuzzValues (
    index_number int,
    index_value varchar(50)
);


GO
CREATE PROCEDURE FizzBuzzCalculationSP
	@firstName varchar(25),
	@lastName varchar(25)
AS
    DECLARE @Counter INT = 1

	IF EXISTS (SELECT 1 FROM FizzBuzzValues)
	DELETE FizzBuzzValues;
	  WHILE @Counter <= 100
	  BEGIN
		IF (@Counter % 3) = 0 AND (@Counter % 5) = 0 
		  INSERT INTO FizzBuzzValues (index_number, index_value) VALUES (@Counter, @firstName +' '+@lastName);
		ELSE 
		 IF (@Counter % 3) = 0 
		  INSERT INTO FizzBuzzValues (index_number, index_value) VALUES (@Counter, @firstName);
		 ELSE  
		  IF (@Counter % 5) = 0 
			 INSERT INTO FizzBuzzValues (index_number, index_value) VALUES (@Counter,@lastName);  

			 ELSE  
			 INSERT INTO FizzBuzzValues (index_number, index_value) VALUES (@Counter,@Counter);
	  SET @Counter = @Counter + 1;
	  END
