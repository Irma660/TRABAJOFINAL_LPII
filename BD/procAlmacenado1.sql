USE [BDSISTR]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[Mostrar]

SELECT	'Return Value' = @return_value

GO
