USE blazor_app_db;

CREATE TABLE userdata
(
    Id int IDENTITY (1 , 1) PRIMARY KEY NOT NULL,
	Username nvarchar(40),
    RegistrationDate datetime2(0),
    UserRating int,
    PhoneNumber nvarchar(11),
    Email nvarchar(30)
)

INSERT INTO userdata (Username, RegistrationDate, UserRating, PhoneNumber, Email)
VALUES
    ('Ivanov Alexander', '11/15/2022', 0, '79012345678', 'a.ivanov@ivanovmail.com'),
	('Petrov Ivan', '01/10/2021', 11, '79868891257', 'petrov.i@petrushka.com'),
	('Egor Blanskiy', '06/12/2023', 100, '79752115640', 'e.blanskiy@ghbdtn.ru'),
	('Pupa Sergey', '04/20/2024', 69, '79957305559', 'pupa@buhgalterii.net'),
	('Lupa Zahar', '04/21/2024', -999, '79942281489', 'lupa@buhgalterii.net')