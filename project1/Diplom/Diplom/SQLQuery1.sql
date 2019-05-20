DROP TABLE IF EXISTS personals_files; 
DROP table if exists documents; 
DROP table if exists student; 
DROP TABLE IF EXISTS gender; 
drop table if exists groups; 
drop table if exists subjects; 
drop table if exists teachers; 
drop table if exists specialtes 
drop table if exists departments; 

create table departments( 
id int IDENTITY(1,1) primary key , 
d_name varchar(255) unique NOT NULL 
); 

create table specialtes( 
spec_id int IDENTITY(1,1) primary key , 
s_name varchar(255) unique, 
department int, 
foreign key (department) references departments(id) 
); 
create table teachers( 
id int IDENTITY(1,1) primary key , 
teach_name varchar(255) 
); 
create table subjects( 
id int IDENTITY(1,1) primary key, 
teacher int, 
sub_name varchar(255) unique, 
foreign key (teacher) references teachers(id) 
); 

create table groups( 
id int IDENTITY(1,1) primary key, 
s_id int, 
group_num varchar(255) unique, 
curator_id int, 
foreign key (s_id) references specialtes(spec_id), 
foreign key (curator_id) references teachers(id) 
); 

CREATE TABLE gender 
( 
id INT IDENTITY(1,1) primary key, 
gender_name VARCHAR(255) 
); 

create table student( 
id int IDENTITY(1,1) primary key, 
student_name varchar(255), 
student_surname varchar(255), 
student_secondname varchar(255), 
gender_id int, 
is_reservist bit, 
groupss int, 
foreign key (gender_id) references gender(id), 
foreign key (groupss) references groups(id), 
); 

create table documents( 
id int IDENTITY(1,1) primary key, 
document_numbers varchar(255) unique, 
is_archeve BIT,
student_id int, 
foreign key (student_id) references student(id) 
);
create table personals_files ( 
id int IDENTITY(1,1) primary key, 
entered date, 
deducted date, 
diploma_number varchar(255) unique, 
number_file varchar(255) unique, 
characteristic varchar(MAX), 
is_graduate BIT,
document_id INT, 
FOREIGN KEY (document_id) REFERENCES documents(id) 
); 