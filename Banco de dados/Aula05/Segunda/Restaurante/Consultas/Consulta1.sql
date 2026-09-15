UPDATE Pratos

SET Foto_do_prato = CASE Id
 WHEN 1 THEN N'C:\Users\FIC\Documents\DEVBACKEND\Banco de dados\Aula05\Segunda\Restaurante\Fotos\Foto1.png'
   WHEN 2 THEN N'C:\Users\FIC\Documents\DEVBACKEND\Banco de Dados\Aula05\Segunda\Restaurante\Fotos\Foto2.jpg'
   WHEN 3 THEN N'C:\Users\FIC\Documents\DEVBACKEND\Banco de Dados\Aula05\Segunda\Restaurante\Fotos\Foto3.jpg'
   WHEN 4 THEN N'C:\Users\FIC\Documents\DEVBACKEND\Banco de Dados\Aula05\Segunda\Restaurante\Fotos\Foto4.jpg'
   WHEN 5 THEN N'C:\Users\FIC\Documents\DEVBACKEND\Banco de Dados\Aula05\Segunda\Restaurante\Fotos\Foto5.jpg'
   WHEN 6 THEN N'C:\Users\FIC\Documents\DEVBACKEND\Banco de Dados\Aula05\Segunda\Restaurante\Fotos\Foto6.jpg'
   WHEN 7 THEN N'C:\Users\FIC\Documents\DEVBACKEND\Banco de Dados\Aula05\Segunda\Restaurante\Fotos\Foto7.jpg'
   WHEN 8 THEN N'C:\Users\FIC\Documents\DEVBACKEND\Banco de Dados\Aula05\Segunda\Restaurante\Fotos\Foto8.jpg'
   WHEN 9 THEN N'C:\Users\FIC\Documents\DEVBACKEND\Banco de Dados\Aula05\Segunda\Restaurante\Fotos\Foto9.jpg'
   WHEN 10 THEN N'C:\Users\FIC\Documents\DEVBACKEND\Banco de Dados\Aula05\Segunda\Restaurante\Fotos\Foto10.jpg'

END
GO


