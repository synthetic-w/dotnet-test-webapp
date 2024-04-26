USE blazor_app_db;

CREATE TABLE userdata
(
    Id int IDENTITY (1 , 1) PRIMARY KEY NOT NULL,
	RegistrationDate datetime2(0),
    Username nvarchar(40),
    UserRating int,
    PhoneNumber nvarchar(11),
    Email nvarchar(30)
)

INSERT INTO userdata (RegistrationDate, Username, UserRating, PhoneNumber, Email)
VALUES
    ('11/15/2022', 'Ivanov Alexander', 0, '79012345678', 'a.ivanov@ivanovmail.com'),
	('01/10/2021', 'Petrov Ivan', 11, '79868891257', 'petrov.i@petrushka.com'),
	('06/12/2023', 'Egor Blanskiy', 100, '79752115640', 'e.blanskiy@ghbdtn.ru'),
	('04/20/2024', 'Pupa Sergey', 69, '79957305559', 'pupa@buhgalterii.net'),
	('04/21/2024', 'Lupa Zahar', -999, '79942281489', 'lupa@buhgalterii.net')