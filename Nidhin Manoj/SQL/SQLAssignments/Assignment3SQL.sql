--- Create Worker table
CREATE TABLE Worker (
    WORKER_ID INT PRIMARY KEY IDENTITY(1,1),
    FIRST_NAME VARCHAR(25),
    LAST_NAME VARCHAR(25),
    SALARY INT,
    JOINING_DATE DATETIME,
    DEPARTMENT CHAR(25)
);
 
-- Create Bonus table
CREATE TABLE Bonus (
    WORKER_REF_ID INT,
    BONUS_AMOUNT INT,
    BONUS_DATE DATETIME,
    FOREIGN KEY (WORKER_REF_ID) REFERENCES Worker(WORKER_ID) ON DELETE CASCADE
);
 
-- Create Title table
CREATE TABLE Title (
    WORKER_REF_ID INT,
    WORKER_TITLE CHAR(25),
    AFFECTED_FROM DATETIME,
    FOREIGN KEY (WORKER_REF_ID) REFERENCES Worker(WORKER_ID) ON DELETE CASCADE
);
-- Insert data into Worker table
INSERT INTO Worker (FIRST_NAME, LAST_NAME, SALARY, JOINING_DATE, DEPARTMENT)
VALUES
('Monika', 'Arora', 100000, '2014-02-20 09:00:00', 'HR'),
('Niharika', 'Verma', 80000, '2014-06-11 09:00:00', 'Admin'),
('Vishal', 'Singhal', 300000, '2014-02-20 09:00:00', 'HR'),
('Amitabh', 'Singh', 500000, '2014-02-20 09:00:00', 'Admin'),
('Vivek', 'Bhati', 500000, '2014-06-11 09:00:00', 'Admin'),
('Vipul', 'Diwan', 200000, '2014-06-11 09:00:00', 'Account'),
('Satish', 'Kumar', 75000, '2014-01-20 09:00:00', 'Account'),
('Geetika', 'Chauhan', 90000, '2014-04-11 09:00:00', 'Admin');
 
-- Insert data into Bonus table
INSERT INTO Bonus (WORKER_REF_ID, BONUS_AMOUNT, BONUS_DATE)
VALUES
(1, 5000, '2016-02-20 00:00:00'),
(2, 3000, '2016-06-11 00:00:00'),
(3, 4000, '2016-02-20 00:00:00'),
(1, 4500, '2016-02-20 00:00:00'),
(2, 3500, '2016-06-11 00:00:00');
 
-- Insert data into Title table
INSERT INTO Title (WORKER_REF_ID, WORKER_TITLE, AFFECTED_FROM)
VALUES
(1, 'Manager', '2016-02-20 00:00:00'),
(2, 'Executive', '2016-06-11 00:00:00'),
(8, 'Executive', '2016-06-11 00:00:00'),
(5, 'Manager', '2016-06-11 00:00:00'),
(4, 'Asst. Manager', '2016-06-11 00:00:00'),
(7, 'Executive', '2016-06-11 00:00:00'),
(6, 'Lead', '2016-06-11 00:00:00'),
(3, 'Lead', '2016-06-11 00:00:00');
 
-- Question1
select FIRST_NAME as WORKER_NAME from Worker;
 
-- Question2
select UPPER(FIRST_NAME) as FIRST_NAME_UPPER from Worker;
 
-- Question3
select DISTINCT DEPARTMENT from Worker;
 
-- Question4
select LEFT(FIRST_NAME, 3) as FIRSTNAME from Worker;
 
-- Question5
select CHARINDEX('A', 'Amitabh') as MatchPosition from Worker where FIRST_NAME='Amitabh';
 
-- Question6
select RTRIM(FIRST_NAME) as FIRSTNAME FROM Worker;
 
-- Question7
select LTRIM(DEPARTMENT) as DEPARTMENT_NO FROM Worker;
-- Question8
select DEPARTMENT, LEN(DEPARTMENT) from Worker GROUP BY DEPARTMENT;
 
-- Question9
select REPLACE(FIRST_NAME, 'a', 'A') AS FIRSTNAME from Worker;
 
-- Question10
select FIRST_NAME + ' ' + LAST_NAME as FULLNAME from Worker;
 
-- -- Question11
SELECT * from Worker ORDER BY FIRST_NAME ASC;
 
-- Question12
select * from Worker ORDER BY FIRST_NAME ASC, DEPARTMENT DESC;
 
-- Question13
select * FROM Worker where FIRST_NAME IN ('Vipul', 'Satish');
 
-- Question14
select * from Worker where FIRST_NAME NOT IN ('Vipul', 'Satish');
 
-- Question15
select * from Worker where DEPARTMENT = 'Admin';
 
-- Question16
select * from Worker where FIRST_NAME LIKE '%a%';
 
-- Question17
select * from Worker where FIRST_NAME LIKE '%a';
 
-- Question18
select * from Worker where FIRST_NAME LIKE '_____h';
 
-- Question19
select * from Worker where SALARY BETWEEN 100000 AND 500000;
 
-- Question20
select * from Worker where JOINING_DATE >= '2014-02-01' AND JOINING_DATE < '2014-03-01';
 
-- Question21
select FIRST_NAME from Worker where SALARY BETWEEN 50000 AND 100000;
 
-- Question22
select Department, count(*) as workerCount from Worker group by Department order by workerCount desc;
-- Question23
select * from worker join Title t on worker.WORKER_ID=t.WORKER_REF_ID where t.WORKER_TITLE ='Manager';
-- Question24
select GETDATE() as currentDate ;
-- Question25
select top 10 * from Worker;