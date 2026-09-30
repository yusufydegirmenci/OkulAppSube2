-- Database for the Windows Forms app (OkulAppSube2)
CREATE DATABASE OkulDbSube2;
GO
USE OkulDbSube2;
GO
CREATE TABLE tblogrenciler (
    Id     INT IDENTITY(1,1) PRIMARY KEY,
    Ad     VARCHAR(20) NOT NULL,
    Soyad  VARCHAR(20) NOT NULL,
    Numara VARCHAR(20) NOT NULL
);
