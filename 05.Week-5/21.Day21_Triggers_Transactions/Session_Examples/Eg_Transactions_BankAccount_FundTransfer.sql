--  *************** Transactions in SQL Server ************


CREATE DATABASE BankAppDb

USE BankAppDb



-- Accounts Table
CREATE TABLE Accounts (
    AccountID INT PRIMARY KEY,
    AccountHolder NVARCHAR(100),
    Balance DECIMAL(18, 2)
);


INSERT INTO Accounts (AccountID, AccountHolder, Balance)
VALUES
(101, 'Alice Johnson', 5000.00),
(102, 'Bob Smith', 3000.00),
(103, 'Charlie Green', 1000.00);


SELECT * FROM Accounts;






-- Transactions Log Table
CREATE TABLE FundTransferLog (
    LogID INT IDENTITY PRIMARY KEY,
    FromAccount INT,
    ToAccount INT,
    Amount DECIMAL(18, 2),
    TransferDate DATETIME,
    Status NVARCHAR(50)
);




DECLARE @FromAccount INT = 101;
DECLARE @ToAccount INT = 102;
DECLARE @Amount DECIMAL(18,2) = 3500.00;


BEGIN TRANSACTION;

BEGIN TRY

		DECLARE @ExistingBalance DECIMAL(18,2)

		SELECT @ExistingBalance = Balance FROM Accounts WHERE AccountID = @FromAccount;

		-- Step 1: Check Sufficient Balance
		IF @ExistingBalance < @Amount
		BEGIN
			RAISERROR('Insufficient Balance', 16, 1);
		END

		-- Step 2: Deduct from Sender
		UPDATE Accounts
		SET Balance = Balance - @Amount
		WHERE AccountID = @FromAccount;

		-- Step 3: Credit to Receiver
		UPDATE Accounts
		SET Balance = Balance + @Amount
		WHERE AccountID = @ToAccount;

		-- Step 4: Log the Transaction
			INSERT INTO FundTransferLog (FromAccount, ToAccount, Amount, TransferDate, Status)
			VALUES (@FromAccount, @ToAccount, @Amount, GETDATE(), 'Success');

		-- Step 5: Commit if all successful
		COMMIT;
		PRINT 'Fund transfer completed successfully.';
END TRY

BEGIN CATCH
	 -- Rollback if any error occurs
    ROLLBACK;

    -- Log failure
    INSERT INTO FundTransferLog (FromAccount, ToAccount, Amount, TransferDate, Status)
    VALUES (@FromAccount, @ToAccount, @Amount, GETDATE(), 'Failed: ' + ERROR_MESSAGE());

    PRINT 'Fund transfer failed: ' + ERROR_MESSAGE();
END CATCH;





SELECT * FROM Accounts;

SELECT * FROM FundTransferLog ORDER BY TransferDate DESC;


 