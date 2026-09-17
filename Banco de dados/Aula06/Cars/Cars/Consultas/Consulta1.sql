USE Automoveis;
GO

;WITH SequenciaFotos AS
(
	SELECT
		Id,
		Tipo,
		ROW_NUMBER() OVER (PARTITION BY Tipo ORDER BY Id) AS NumeroSequencial
	FROM dbo.Estoque
)
UPDATE E
SET E.Foto = CASE S.Tipo
				WHEN 1 THEN CONCAT(N'C:\Users\FIC\Documents\DEVBACKEND\Banco de dados\Aula06\Cars\Cars\Fotos\Carros\Carro', S.NumeroSequencial, N'.jpg')
				WHEN 2 THEN CONCAT(N'C:\Users\FIC\Documents\DEVBACKEND\Banco de dados\Aula06\Cars\Cars\Fotos\Motos\Moto', S.NumeroSequencial, N'.jpg')
				ELSE E.Foto
			 END
FROM dbo.Estoque E
INNER JOIN SequenciaFotos S ON S.Id = E.Id;
GO
