USE blazor_app_db;

DELETE userdata FROM
    (SELECT TOP 5 * FROM userdata) AS Selected

DROP TABLE userdata