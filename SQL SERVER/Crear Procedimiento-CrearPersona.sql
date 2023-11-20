------crear persona para windows form
CREATE PROCEDURE [dbo].[CrearPersonaWF1](
	@Nombre NVARCHAR(100),
	@ApellidoPaterno NVARCHAR(100),
	@ApellidoMaterno NVARCHAR(100),
	@FechaNacimiento DATE, --VALIDAR
	@Email NVARCHAR(100), --VALIDAR
	@NumeroDOC NVARCHAR(10), --VALIDAR
	@Direccion NVARCHAR(100),
	@Telefono NVARCHAR(20),
	@Mensaje NVARCHAR (200) OUTPUT,
	@Error INT OUTPUT
)
AS 
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION;
		SET @Mensaje = '';
		SET @Error = 0;

		IF @FechaNacimiento >= GETDATE()
		BEGIN
			SET @Mensaje = 'la fecha de nacimeinto no debe ser mayor a la fecha actual.';
			set @Error = 1;
			THROW 51001, @Mensaje, 17
		END;

		IF LEN(@NumeroDOC) <> 8
		BEGIN 
			SET @Mensaje = 'El número de documento debe tener exactamente 8 caracteres';
			set @Error = 1;
			THROW 51002, @Mensaje, 17
		END;

		IF LEN(@Nombre) <= 2
		BEGIN
			SET @Mensaje = 'El nombre debe tener al menos 3 caracteres';
			set @Error = 1;
			THROW 51011, @Mensaje, 17;
		END;

		IF LEN(@ApellidoMaterno) <=2
			BEGIN
				SET @Mensaje = 'El apellido materno debe tener al menos 3 caracteres';
				set @Error = 1;
				THROW 51012, @Mensaje, 17;
		END;
		IF LEN(@Telefono) <> 9
			BEGIN
				SET @Mensaje = 'El numero de celular debe tener al menos 9 caracteres';
				set @Error = 1;
				THROW 51012, @Mensaje, 17;
		END;

		IF LEN(@ApellidoPaterno) <= 2
			BEGIN
				SET @Mensaje = 'El apellido paterno debe tener al menos 3 caracteres';
				set @Error = 1;
				THROW 51013, @Mensaje, 17;
		END;

		IF CHARINDEX('@', @Email) = 0
			BEGIN
				SET @Mensaje = 'El correo electrónico debe contener el símbolo @';
				set @Error = 1;
				THROW 51003, @Mensaje, 17;
			END;

		
		IF RIGHT(@Email, 10) != '@gmail.com'
		BEGIN
			SET @Mensaje = 'El correo electrónico debe tener el dominio @gmail.com';
			set @Error = 1;
			THROW 51004, @Mensaje, 17;
		END;

		IF NOT (
			LOWER(@Email) = LOWER(@Nombre) + '.' + LOWER(@ApellidoPaterno) + '@gmail.com' OR
			LOWER(@Email) = LOWER(@Nombre) + '.' + LOWER(@ApellidoMaterno) + '@gmail.com' 
		)
		BEGIN
			SET @Mensaje = 'La estructura del correo electrónico es incorrecta nombre.apellido';
			set @Error = 1;
			THROW 51006, @Mensaje, 17;
		END;
		INSERT INTO Personas ( Nombre, ApellidoPaterno,ApellidoMaterno, Direccion, Email, Telefono,NumeroDOC,FechaNacimiento)
		VALUES (@Nombre, @ApellidoPaterno,@ApellidoMaterno,@Direccion,@Email,@Telefono, @NumeroDOC, @FechaNacimiento);
		COMMIT;

	END TRY
	BEGIN CATCH
		PRINT 'INGRESO AL CATCH --GG';
		PRINT 'ERROR MENSAJE: ' + ERROR_MESSAGE(); 
		PRINT 'ERROR NUMERO: ' + CAST(ERROR_NUMBER() AS NVARCHAR(10)); 
		PRINT 'ERROR ESTADO: ' + CAST(ERROR_STATE() AS NVARCHAR(10)); 

		ROLLBACK;
	END CATCH
END;
