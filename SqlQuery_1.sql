
 --create database 
 CREATE DATABASE İntroWt1976Db;
 GO

 USE İntroWt1976Db;

 CREATE TABLE Cities(
  id INT primary key,
  CityNAme NVARCHAR(50)
 );

 -- view all of cities
SELECT * FROM Cities

-- new cities added
INSERT INTO Cities (id,CityName) values (5, N'Amasya');
INSERT INTO Cities (id,CityName) values (24, N'Erzincan');

-- manual add city

INSERT INTO Cities (id,CityName) VALUES (1, N'Adana');
INSERT INTO Cities (id,CityName) VALUES (2, N'Adıyaman');
INSERT INTO Cities (id,CityName) VALUES (6, N'Ankara');
INSERT INTO Cities (id,CityName) VALUES (7, N'Antalya');
INSERT INTO Cities (id,CityName) VALUES (17, N'Çanakkale');
INSERT INTO Cities (id,CityName) VALUES (21, N'Diyarbakır');
INSERT INTO Cities (id,CityName) VALUES (23, N'Elazığ');
INSERT INTO Cities (id,CityName) VALUES (25, N'Erzurum');
INSERT INTO Cities (id,CityName) VALUES (26, N'Eskişehir');
INSERT INTO Cities (id,CityName) VALUES (31, N'Hatay');
INSERT INTO Cities (id,CityName) VALUES (34, N'İstanbul');
INSERT INTO Cities (id,CityName) VALUES (35, N'İzmir');
INSERT INTO Cities (id,CityName) VALUES (36, N'Kars');
INSERT INTO Cities (id,CityName) VALUES (38, N'Kayseri');
INSERT INTO Cities (id,CityName) VALUES (41, N'Kocaeli');
INSERT INTO Cities (id,CityName) VALUES (42, N'Konya');
INSERT INTO Cities (id,CityName) VALUES (44, N'Malatya');
INSERT INTO Cities (id,CityName) VALUES (46, N'Kahramanmaraş');
INSERT INTO Cities (id,CityName) VALUES (48, N'Muğla');
INSERT INTO Cities (id,CityName) VALUES (51, N'Niğde');
INSERT INTO Cities (id,CityName) VALUES (54, N'Sakarya');
INSERT INTO Cities (id,CityName) VALUES (55, N'Samsun');
INSERT INTO Cities (id,CityName) VALUES (58, N'Sivas');
INSERT INTO Cities (id,CityName) VALUES (61, N'Trabzon');
INSERT INTO Cities (id,CityName) VALUES (65, N'Van');
INSERT INTO Cities (id,CityName) VALUES (76, N'Iğdır');
INSERT INTO Cities (id,CityName) VALUES (80, N'Osmaniye');
INSERT INTO Cities (id,CityName) VALUES (81, N'Düzce');


-- multiple cities added
 INSERT INTO Cities(id,CityName) 
 values (65, N'Van'),(33, N'Mersin'),(48, N'Muğla');

 --delete item
 DELETE FROM Cities WHERE id=3;


 --sum of the all of cities
 SELECT COUNT(*) FROM Cities;

 -- update proccess do Istanbul instaed of İstanbul
 UPDATE Cities SET CityName=N'Istanbul' where id=34;





