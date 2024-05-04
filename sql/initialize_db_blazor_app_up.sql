USE blazor_app_db;

CREATE TABLE userdata
(
    Id int IDENTITY (1 , 1) PRIMARY KEY NOT NULL,
	Username nvarchar(40),
    PhoneNumber nvarchar(11),
    Email nvarchar(30)
)

INSERT INTO userdata (Username, PhoneNumber, Email)
VALUES
    ('Ivanov Alexander', '79012345678', 'a.ivanov@ivanovmail.com'),
	('Petrov Ivan', '79868891257', 'petrov.i@petrushka.com'),
	('Egor Blanskiy', '79752115640', 'e.blanskiy@ghbdtn.ru'),
	('Pupa Sergey', '79957305559', 'pupa@buhgalterii.net'),
	('Lupa Zahar', '79942281489', 'lupa@buhgalterii.net')