

	------------------------------------------
	-- Eg4: Procedure to insert a record in dept table   (includes Error Handling)
	--------------------------------------------------

	CREATE PROCEDURE  usp_insertDeptDetails   
	AS
	BEGIN
		BEGIN TRY
			INSERT INTO Dept VALUES(70, 'IT','Mumbai');	

			Print('New Department created successfully.');
		END TRY

		BEGIN CATCH
				DECLARE @ErrorMessage NVARCHAR(4000);
				DECLARE @ErrorSeverity INT;
				DECLARE @ErrorState INT;

				SELECT  @ErrorMessage = ERROR_MESSAGE(),
						@ErrorSeverity = ERROR_SEVERITY(),
						@ErrorState = ERROR_STATE();

				--RAISERROR('INSERT OPERATION FAILED DUE TO ERROR, Reason : '  + @ErrorMessage, @ErrorSeverity, @ErrorState );

				-- Prepare INSERT command to log the error details in another error log table 

				PRINT(@ErrorMessage)
		END CATCH
	END;


	EXEC usp_insertDeptDetails

	SELECT * FROM Dept
	
	DROP PROCEDURE usp_insertDeptDetails

