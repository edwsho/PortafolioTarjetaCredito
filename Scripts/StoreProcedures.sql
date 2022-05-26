USE TarejtaCreditoDb;  
GO  
CREATE PROCEDURE GetAllCreditCards      
AS   

    SET NOCOUNT ON;  
    SELECT *  
    FROM dbo.TarjetaCredito
GO  

CREATE PROCEDURE InsertUserCreditCard(@Nombre NVarchar(20), @NumeroTarjeta NVarchar(20), @FechaExp NVarchar(10), @Cvv NVarchar(3))
AS
            INSERT INTO dbo.TarjetaCredito
                        (
                         Nombre,
                         numeroTarjeta,
                         fechaExp  ,
                         cvv)
            VALUES     ( 
						 @Nombre,
                         @NumeroTarjeta ,
                         @FechaExp ,
                         @Cvv)
GO

USE TarejtaCreditoDb;  
GO  
CREATE PROCEDURE UpdateUserCreditCard(@Id int, @Nombre NVarchar(20), @NumeroTarjeta NVarchar(20), @FechaExp NVarchar(10), @Cvv NVarchar(3))
AS
            UPDATE     dbo.TarjetaCredito
            SET Nombre         = @Nombre,
				numeroTarjeta  = @NumeroTarjeta,
				fechaExp       = @FechaExp,
				cvv            = @Cvv
			WHERE id =  @Id
GO

CREATE PROCEDURE DeleteUserCreditCard(@Id int)
AS
            DELETE  FROM  dbo.TarjetaCredito WHERE id =  @Id
GO