select 
u.UsuarioID,
p.Nombre,
p.ApellidoPaterno,
p.ApellidoMaterno,
p.Email,
p.NumeroDOC,
u.Rol
from Usuarios as u 
	inner join Personas as p on u.PersonaID = p.PersonaID
	where Usuario=@usuario and Contrasenia = @contrasenia;

SELECT * FROM Personas;
SELECT * FROM Usuarios;
ALTER TABLE Usuarios
ADD Rol NVARCHAR(20);













