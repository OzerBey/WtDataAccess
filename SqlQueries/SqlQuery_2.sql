--CREATE DATABASE AddressBookDb;
--GO

USE AddressBookDb;

CREATE TABLE Addresses(
id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(50) NOT NULL,
LastName NVARCHAR(50),
PhoneNumber NVARCHAR(15),
Address NVARCHAR (400)
);

INSERT INTO Addresses(FirstName,LastName,PhoneNumber,Address) VALUES 
(N'Yasin',N'Özer',N'+905061239999',N'Bahçelievler Mah.'),
(N'Eda',N'Yılmaz',N'+905061239998',N'Sahil Mah.'),
(N'Zeynep Nur',N'Özer',N'+905061239997',N'Dereli Mah.'),
(N'Gizem',N'Bayrak',N'+905061239996',N'Şirinevler Mah.'),
(N'Can',N'Deniz',N'+905061239995',N'Riches Mah.');
