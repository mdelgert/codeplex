-- =============================================
-- Script Template
-- =============================================

USE [MSTestProject]
GO

/****** Object:  Table [dbo].[ContactsTestData]    Script Date: 07/17/2012 22:12:59 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContactsTestData]') AND type in (N'U'))
DROP TABLE [dbo].[ContactsTestData]
GO

USE [MSTestProject]
GO

/****** Object:  Table [dbo].[ContactsTestData]    Script Date: 07/17/2012 22:12:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ContactsTestData](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[EmailAddress] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](25) NOT NULL,
	[AddressLine] [nvarchar](60) NOT NULL,
	[City] [nvarchar](30) NOT NULL,
	[StateProvince] [nvarchar](50) NOT NULL,
	[CountryRegion] [nvarchar](50) NOT NULL,
	[PostalCode] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_ContactTestData] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [MSTestProject];
SET NOCOUNT ON;
SET XACT_ABORT ON;
GO

SET IDENTITY_INSERT [dbo].[ContactsTestData] ON;

BEGIN TRANSACTION;
INSERT INTO [dbo].[ContactsTestData]([ContactID], [FirstName], [MiddleName], [LastName], [EmailAddress], [Phone], [AddressLine], [City], [StateProvince], [CountryRegion], [PostalCode])
SELECT 1, N'Catherine', N'R.', N'Abel', N'catherine0@adventure-works.com', N'747-555-0171', N'57251 Serene Blvd', N'Van Nuys', N'California', N'United States', N'91411' UNION ALL
SELECT 2, N'Kim', NULL, N'Abercrombie', N'kim2@adventure-works.com', N'334-555-0137', N'Tanger Factory', N'Branch', N'Minnesota', N'United States', N'55056' UNION ALL
SELECT 3, N'Frances', N'B.', N'Adams', N'frances0@adventure-works.com', N'991-555-0183', N'6900 Sisk Road', N'Modesto', N'California', N'United States', N'95354' UNION ALL
SELECT 4, N'Margaret', N'J.', N'Smith', N'margaret0@adventure-works.com', N'959-555-0151', N'Lewiston Mall', N'Lewiston', N'Idaho', N'United States', N'83501' UNION ALL
SELECT 5, N'Jay', NULL, N'Adams', N'jay1@adventure-works.com', N'158-555-0142', N'Blue Ridge Mall', N'Kansas City', N'Missouri', N'United States', N'64106' UNION ALL
SELECT 6, N'Robert', N'E.', N'Ahlering', N'robert1@adventure-works.com', N'678-555-0175', N'6500 East Grant Road', N'Tucson', N'Arizona', N'United States', N'85701' UNION ALL
SELECT 7, N'François', NULL, N'Ferrier', N'françois1@adventure-works.com', N'571-555-0128', N'Eastridge Mall', N'Casper', N'Wyoming', N'United States', N'82601' UNION ALL
SELECT 8, N'Paul', N'L.', N'Alcorn', N'paul2@adventure-works.com', N'331-555-0162', N'White Mountain Mall', N'Rock Springs', N'Wyoming', N'United States', N'82901' UNION ALL
SELECT 9, N'Michelle', NULL, N'Alexander', N'michelle0@adventure-works.com', N'115-555-0175', N'22589 West Craig Road', N'North Las Vegas', N'Nevada', N'United States', N'89030' UNION ALL
SELECT 10, N'Sean', N'P.', N'Jacobson', N'sean2@adventure-works.com', N'555-555-0162', N'2551 East Warner Road', N'Gilbert', N'Arizona', N'United States', N'85233' UNION ALL
SELECT 11, N'Marvin', N'N.', N'Allen', N'marvin0@adventure-works.com', N'447-555-0110', N'First Colony Mall', N'Sugar Land', N'Texas', N'United States', N'77478' UNION ALL
SELECT 12, N'Oscar', N'L.', N'Alpuerto', N'oscar0@adventure-works.com', N'855-555-0174', N'Rocky Mountain Pines Outlet', N'Loveland', N'Colorado', N'United States', N'80537' UNION ALL
SELECT 13, N'Ramona', N'J.', N'Antrim', N'ramona0@adventure-works.com', N'327-555-0148', N'998 Forest Road', N'Saginaw', N'Michigan', N'United States', N'48601' UNION ALL
SELECT 14, N'Tom', N'H', N'Johnston', N'tom1@adventure-works.com', N'883-555-0177', N'Belz Factory Outlet', N'Las Vegas', N'Nevada', N'United States', N'89106' UNION ALL
SELECT 15, N'Thomas', N'B.', N'Armstrong', N'thomas1@adventure-works.com', N'226-555-0146', N'Fox Hills', N'Culver City', N'California', N'United States', N'90232' UNION ALL
SELECT 16, N'John', NULL, N'Arthur', N'john6@adventure-works.com', N'149-555-0113', N'2345 North Freeway', N'Houston', N'Texas', N'United States', N'77003' UNION ALL
SELECT 17, N'Chris', NULL, N'Ashton', N'chris3@adventure-works.com', N'556-555-0145', N'70 N.W. Plaza', N'Saint Ann', N'Missouri', N'United States', N'63074' UNION ALL
SELECT 18, N'Teresa', NULL, N'Atkinson', N'teresa0@adventure-works.com', N'129-555-0110', N'The Citadel Commerce Plaza', N'City Of Commerce', N'California', N'United States', N'90040' UNION ALL
SELECT 19, N'Stephen', N'M.', N'Ayers', N'stephen1@adventure-works.com', N'818-555-0171', N'2533 Eureka Rd.', N'Southgate', N'Michigan', N'United States', N'48195' UNION ALL
SELECT 20, N'Cory', N'K.', N'Booth', N'cory0@adventure-works.com', N'121-555-0157', N'Eastern Beltway Center', N'Las Vegas', N'Nevada', N'United States', N'89106' UNION ALL
SELECT 21, N'James', N'B.', N'Bailey', N'james3@adventure-works.com', N'234-555-0112', N'Southgate Mall', N'Missoula', N'Montana', N'United States', N'59801' UNION ALL
SELECT 22, N'Douglas', N'A.', N'Baldwin', N'douglas1@adventure-works.com', N'583-555-0130', N'Horizon Outlet Center', N'Holland', N'Michigan', N'United States', N'49423' UNION ALL
SELECT 23, N'Wayne', N'N.', N'Banack', N'wayne0@adventure-works.com', N'640-555-0189', N'48255 I-10 E. @ Eastpoint Blvd.', N'Baytown', N'Texas', N'United States', N'77520' UNION ALL
SELECT 24, N'Robert', N'L.', N'Barker', N'robert3@adventure-works.com', N'241-555-0112', N'6789 Warren Road', N'Westland', N'Michigan', N'United States', N'48185' UNION ALL
SELECT 25, N'John', N'A.', N'Beaver', N'john8@adventure-works.com', N'521-555-0195', N'1318 Lasalle Street', N'Bothell', N'Washington', N'United States', N'98011' UNION ALL
SELECT 26, N'John', N'A.', N'Beaver', N'john8@adventure-works.com', N'521-555-0195', N'99300 223rd Southeast', N'Bothell', N'Washington', N'United States', N'98011' UNION ALL
SELECT 27, N'Stanley', N'A.', N'Alan', N'stanley0@adventure-works.com', N'156-555-0126', N'567 Sw Mcloughlin Blvd', N'Milwaukie', N'Oregon', N'United States', N'97222' UNION ALL
SELECT 28, N'Edna', N'J.', N'Benson', N'edna0@adventure-works.com', N'789-555-0189', N'Po Box 8035996', N'Dallas', N'Texas', N'United States', N'75201' UNION ALL
SELECT 29, N'Payton', N'P.', N'Benson', N'payton0@adventure-works.com', N'528-555-0183', N'997000 Telegraph Rd.', N'Southfield', N'Michigan', N'United States', N'48034' UNION ALL
SELECT 30, N'Robert', N'M.', N'Bernacchi', N'robert4@adventure-works.com', N'449-555-0176', N'2681 Eagle Peak', N'Bellevue', N'Washington', N'United States', N'98004' UNION ALL
SELECT 31, N'Robert', N'M.', N'Bernacchi', N'robert4@adventure-works.com', N'449-555-0176', N'25915 140th Ave Ne', N'Bellevue', N'Washington', N'United States', N'98004' UNION ALL
SELECT 32, N'Matthias', NULL, N'Berndt', N'matthias1@adventure-works.com', N'384-555-0169', N'Escondido', N'Escondido', N'California', N'United States', N'92025' UNION ALL
SELECT 33, N'Steven', N'B.', N'Brown', N'steven1@adventure-works.com', N'280-555-0124', N'5500 Grossmont Center Drive', N'La Mesa', N'California', N'United States', N'91941' UNION ALL
SELECT 34, N'Jimmy', NULL, N'Bischoff', N'jimmy1@adventure-works.com', N'992-555-0111', N'3065 Santa Margarita Parkway', N'Trabuco Canyon', N'California', N'United States', N'92679' UNION ALL
SELECT 35, N'Mae', N'M.', N'Black', N'mae1@adventure-works.com', N'264-555-0143', N'Redford Plaza', N'Redford', N'Michigan', N'United States', N'48239' UNION ALL
SELECT 36, N'Donald', N'L.', N'Blanton', N'donald0@adventure-works.com', N'357-555-0161', N'Corporate Office', N'El Segundo', N'California', N'United States', N'90245' UNION ALL
SELECT 37, N'Linda', N'E.', N'Burnett', N'linda4@adventure-works.com', N'121-555-0121', N'2505 Gateway Drive', N'North Sioux City', N'South Dakota', N'United States', N'57049' UNION ALL
SELECT 38, N'Michael', N'Greg', N'Blythe', N'michael11@adventure-works.com', N'126-555-0172', N'9903 Highway 6 South', N'Houston', N'Texas', N'United States', N'77003' UNION ALL
SELECT 39, N'Gabriel', N'L.', N'Bockenkamp', N'gabriel0@adventure-works.com', N'763-555-0145', N'67 Rainer Ave S', N'Renton', N'Washington', N'United States', N'98055' UNION ALL
SELECT 40, N'Luis', NULL, N'Bonifaz', N'luis0@adventure-works.com', N'688-555-0113', N'72502 Eastern Ave.', N'Bell Gardens', N'California', N'United States', N'90201' UNION ALL
SELECT 41, N'Randall', NULL, N'Boseman', N'randall0@adventure-works.com', N'383-555-0117', N'2500 North Stemmons Freeway', N'Dallas', N'Texas', N'United States', N'75201' UNION ALL
SELECT 42, N'Cornelius', N'L.', N'Brandon', N'cornelius0@adventure-works.com', N'229-555-0114', N'789 West Alameda', N'Westminster', N'Colorado', N'United States', N'80030' UNION ALL
SELECT 43, N'Richard', NULL, N'Bready', N'richard1@adventure-works.com', N'340-555-0131', N'4251 First Avenue', N'Seattle', N'Washington', N'United States', N'98104' UNION ALL
SELECT 44, N'Ted', NULL, N'Bremer', N'ted0@adventure-works.com', N'962-555-0166', N'Bldg. 9n/99298', N'Redmond', N'Washington', N'United States', N'98052' UNION ALL
SELECT 45, N'Alan', NULL, N'Brewer', N'alan1@adventure-works.com', N'494-555-0134', N'4255 East Lies Road', N'Carol Stream', N'Illinois', N'United States', N'60188' UNION ALL
SELECT 46, N'Walter', N'J.', N'Brian', N'walter0@adventure-works.com', N'163-555-0155', N'25136 Jefferson Blvd.', N'Culver City', N'California', N'United States', N'90232' UNION ALL
SELECT 47, N'Christopher', N'M.', N'Bright', N'christopher2@adventure-works.com', N'162-555-0166', N'Washington Square', N'Portland', N'Oregon', N'United States', N'97205' UNION ALL
SELECT 48, N'Willie', N'P.', N'Brooks', N'willie0@adventure-works.com', N'525-555-0174', N'Holiday Village Mall', N'Great Falls', N'Montana', N'United States', N'59401' UNION ALL
SELECT 49, N'Jo', NULL, N'Brown', N'jo2@adventure-works.com', N'689-555-0130', N'250000 Eight Mile Road', N'Detroit', N'Michigan', N'United States', N'48226' UNION ALL
SELECT 50, N'Robert', NULL, N'Brown', N'robert5@adventure-works.com', N'575-555-0189', N'250880 Baur Blvd', N'Saint Louis', N'Missouri', N'United States', N'63103'
COMMIT;
RAISERROR (N'[dbo].[ContactsTestData]: Insert Batch: 1.....Done!', 10, 1) WITH NOWAIT;
GO

BEGIN TRANSACTION;
INSERT INTO [dbo].[ContactsTestData]([ContactID], [FirstName], [MiddleName], [LastName], [EmailAddress], [Phone], [AddressLine], [City], [StateProvince], [CountryRegion], [PostalCode])
SELECT 51, N'Mary', N'K.', N'Browning', N'mary5@adventure-works.com', N'658-555-0146', N'Noah Lane', N'Chicago', N'Illinois', N'United States', N'60610' UNION ALL
SELECT 52, N'Michael', NULL, N'Brundage', N'michael13@adventure-works.com', N'128-555-0148', N'22555 Paseo De Las Americas', N'San Diego', N'California', N'United States', N'92102' UNION ALL
SELECT 53, N'Shirley', N'R.', N'Bruner', N'shirley0@adventure-works.com', N'383-555-0155', N'4781 Highway 95', N'Sandpoint', N'Idaho', N'United States', N'83864' UNION ALL
SELECT 54, N'June', N'B.', N'Brunner', N'june0@adventure-works.com', N'249-555-0172', N'678 Eastman Ave.', N'Midland', N'Michigan', N'United States', N'48640' UNION ALL
SELECT 55, N'Megan', N'E.', N'Burke', N'megan0@adventure-works.com', N'148-555-0149', N'Arcadia Crossing', N'Phoenix', N'Arizona', N'United States', N'85004' UNION ALL
SELECT 56, N'Karren', N'K.', N'Burkhardt', N'karren0@adventure-works.com', N'652-555-0132', N'2502 Evergreen Ste E', N'Everett', N'Washington', N'United States', N'98201' UNION ALL
SELECT 57, N'Jared', N'L.', N'Bustamante', N'jared0@adventure-works.com', N'164-555-0147', N'3307 Evergreen Blvd', N'Washougal', N'Washington', N'United States', N'98671' UNION ALL
SELECT 58, N'Barbara', N'J.', N'Calone', N'barbara2@adventure-works.com', N'145-555-0152', N'25306 Harvey Rd.', N'College Station', N'Texas', N'United States', N'77840' UNION ALL
SELECT 59, N'Lindsey', N'R.', N'Camacho', N'lindsey0@adventure-works.com', N'827-555-0143', N'S Sound Ctr Suite 25300', N'Lacey', N'Washington', N'United States', N'98503' UNION ALL
SELECT 60, N'Henry', N'L.', N'Campen', N'henry0@adventure-works.com', N'635-555-0126', N'2507 Pacific Ave S', N'Tacoma', N'Washington', N'United States', N'98403' UNION ALL
SELECT 61, N'Chris', NULL, N'Cannon', N'chris5@adventure-works.com', N'118-555-0131', N'Lakewood Mall', N'Lakewood', N'California', N'United States', N'90712' UNION ALL
SELECT 62, N'Jane', N'N.', N'Carmichael', N'jane0@adventure-works.com', N'716-555-0167', N'5967 W Las Positas Blvd', N'Pleasanton', N'California', N'United States', N'94566' UNION ALL
SELECT 63, N'Jovita', N'A.', N'Carmody', N'jovita0@adventure-works.com', N'646-555-0137', N'253950 N.E. 178th Place', N'Woodinville', N'Washington', N'United States', N'98072' UNION ALL
SELECT 64, N'Rob', NULL, N'Caron', N'rob2@adventure-works.com', N'620-555-0117', N'Ward Parkway Center', N'Kansas City', N'Missouri', N'United States', N'64106' UNION ALL
SELECT 65, N'Andy', NULL, N'Carothers', N'andy1@adventure-works.com', N'944-555-0148', N'566 S. Main', N'Cedar City', N'Utah', N'United States', N'84720' UNION ALL
SELECT 66, N'Donna', N'F.', N'Carreras', N'donna0@adventure-works.com', N'279-555-0130', N'12345 Sterling Avenue', N'Irving', N'Texas', N'United States', N'75061' UNION ALL
SELECT 67, N'Rosmarie', N'J.', N'Carroll', N'rosmarie0@adventure-works.com', N'244-555-0112', N'39933 Mission Oaks Blvd', N'Camarillo', N'California', N'United States', N'93010' UNION ALL
SELECT 68, N'Raul', N'E.', N'Casts', N'raul0@adventure-works.com', N'362-555-0162', N'99040 California Avenue', N'Sand City', N'California', N'United States', N'93955' UNION ALL
SELECT 69, N'Matthew', N'J.', N'Cavallari', N'matthew1@adventure-works.com', N'695-555-0161', N'North 93270 Newport Highway', N'Spokane', N'Washington', N'United States', N'99202' UNION ALL
SELECT 70, N'Andrew', NULL, N'Cencini', N'andrew2@adventure-works.com', N'644-555-0111', N'558 S 6th St', N'Klamath Falls', N'Oregon', N'United States', N'97601' UNION ALL
SELECT 71, N'Stacey', N'M.', N'Cereghino', N'stacey0@adventure-works.com', N'351-555-0131', N'220 Mercy Drive', N'Garland', N'Texas', N'United States', N'75040' UNION ALL
SELECT 72, N'Forrest', N'J.', N'Chandler', N'forrest0@adventure-works.com', N'448-555-0179', N'The Quad @ WestView', N'Whittier', N'California', N'United States', N'90605' UNION ALL
SELECT 73, N'Lee', N'J.', N'Chapla', N'lee0@adventure-works.com', N'223-555-0184', N'99433 S. Greenbay Rd.', N'Racine', N'Wisconsin', N'United States', N'53182' UNION ALL
SELECT 74, N'Pei', NULL, N'Chow', N'pei0@adventure-works.com', N'789-555-0184', N'4660 Rodeo Road', N'Santa Fe', N'New Mexico', N'United States', N'87501' UNION ALL
SELECT 75, N'Yao-Qiang', NULL, N'Cheng', N'yao-qiang0@adventure-works.com', N'344-555-0181', N'25 N State St', N'Chicago', N'Illinois', N'United States', N'60610' UNION ALL
SELECT 76, N'Nicky', N'E.', N'Chesnut', N'nicky0@adventure-works.com', N'264-555-0164', N'9920 North Telegraph Rd.', N'Pontiac', N'Michigan', N'United States', N'48342' UNION ALL
SELECT 77, N'Ruth', N'A.', N'Choin', N'ruth1@adventure-works.com', N'273-555-0181', N'7760 N. Pan Am Expwy', N'San Antonio', N'Texas', N'United States', N'78204' UNION ALL
SELECT 78, N'Anthony', NULL, N'Chor', N'anthony0@adventure-works.com', N'429-555-0145', N'Riverside', N'Sherman Oaks', N'California', N'United States', N'91403' UNION ALL
SELECT 79, N'Jill', N'J.', N'Christie', N'jill1@adventure-works.com', N'927-555-0198', N'54254 Pacific Ave.', N'Stockton', N'California', N'United States', N'95202' UNION ALL
SELECT 80, N'Alice', NULL, N'Clark', N'alice1@adventure-works.com', N'221-555-0141', N'42500 W 76th St', N'Chicago', N'Illinois', N'United States', N'60610' UNION ALL
SELECT 81, N'Connie', N'L.', N'Coffman', N'connie0@adventure-works.com', N'426-555-0181', N'25269 Wood Dale Rd.', N'Wood Dale', N'Illinois', N'United States', N'60191' UNION ALL
SELECT 82, N'John', N'L.', N'Colon', N'john14@adventure-works.com', N'397-555-0144', N'77 Beale Street', N'San Francisco', N'California', N'United States', N'94109' UNION ALL
SELECT 83, N'Scott', N'A.', N'Colvin', N'scott1@adventure-works.com', N'119-555-0144', N'25550 Executive Dr', N'Elgin', N'Illinois', N'United States', N'60120' UNION ALL
SELECT 84, N'Scott', NULL, N'Cooper', N'scott2@adventure-works.com', N'773-555-0182', N'Pavillion @ Redlands', N'Redlands', N'California', N'United States', N'92373' UNION ALL
SELECT 85, N'Eva', NULL, N'Corets', N'eva0@adventure-works.com', N'542-555-0164', N'2540 Dell Range Blvd', N'Cheyenne', N'Wyoming', N'United States', N'82001' UNION ALL
SELECT 86, N'Marlin', N'M.', N'Coriell', N'marlin0@adventure-works.com', N'941-555-0155', N'99800 Tittabawasee Rd.', N'Saginaw', N'Michigan', N'United States', N'48601' UNION ALL
SELECT 87, N'Jack', NULL, N'Creasey', N'jack2@adventure-works.com', N'539-555-0182', N'Factory Merchants', N'Barstow', N'California', N'United States', N'92311' UNION ALL
SELECT 88, N'Grant', NULL, N'Culbertson', N'grant1@adventure-works.com', N'859-555-0173', N'399700 John R. Rd.', N'Madison Heights', N'Michigan', N'United States', N'48071' UNION ALL
SELECT 89, N'Scott', NULL, N'Culp', N'scott3@adventure-works.com', N'119-555-0167', N'750 Lakeway Dr', N'Bellingham', N'Washington', N'United States', N'98225' UNION ALL
SELECT 90, N'Conor', NULL, N'Cunningham', N'conor0@adventure-works.com', N'115-555-0113', N'Sports Store At Park City', N'Park City', N'Utah', N'United States', N'84098' UNION ALL
SELECT 91, N'Megan', N'N.', N'Davis', N'megan1@adventure-works.com', N'839-555-0198', N'48995 Evergreen Wy.', N'Everett', N'Washington', N'United States', N'98201' UNION ALL
SELECT 92, N'Alvaro', NULL, N'De Matos Miranda Filho', N'alvaro0@adventure-works.com', N'551-555-0155', N'Mountain Square', N'Upland', N'California', N'United States', N'91786' UNION ALL
SELECT 93, N'Aidan', NULL, N'Delaney', N'aidan0@adventure-works.com', N'358-555-0188', N'Corporate Office', N'Garland', N'Texas', N'United States', N'75040' UNION ALL
SELECT 94, N'Stefan', NULL, N'Delmarco', N'stefan0@adventure-works.com', N'819-555-0186', N'Incom Sports Center', N'Ontario', N'California', N'United States', N'91764' UNION ALL
SELECT 95, N'Prashanth', NULL, N'Desai', N'prashanth0@adventure-works.com', N'138-555-0156', N'Sapp Road West', N'Round Rock', N'Texas', N'United States', N'78664' UNION ALL
SELECT 96, N'Bev', N'L.', N'Desalvo', N'bev0@adventure-works.com', N'143-555-0113', N'7009 Sw Hall Blvd.', N'Tigard', N'Oregon', N'United States', N'97223' UNION ALL
SELECT 97, N'Brenda', NULL, N'Diaz', N'brenda2@adventure-works.com', N'147-555-0192', N'2560 E. Newlands Dr', N'Fernley', N'Nevada', N'United States', N'89408' UNION ALL
SELECT 98, N'Blaine', NULL, N'Dockter', N'blaine0@adventure-works.com', N'156-555-0187', N'99000 S. Avalon Blvd. Suite 750', N'Carson', N'California', N'United States', N'90746' UNION ALL
SELECT 99, N'Cindy', N'M.', N'Dodd', N'cindy0@adventure-works.com', N'706-555-0140', N'994 Sw Cherry Park Rd', N'Troutdale', N'Oregon', N'United States', N'97060' UNION ALL
SELECT 100, N'Patricia', NULL, N'Doyle', N'patricia0@adventure-works.com', N'899-555-0134', N'225 South 314th Street', N'Federal Way', N'Washington', N'United States', N'98003'
COMMIT;
RAISERROR (N'[dbo].[ContactsTestData]: Insert Batch: 2.....Done!', 10, 1) WITH NOWAIT;
GO

BEGIN TRANSACTION;
INSERT INTO [dbo].[ContactsTestData]([ContactID], [FirstName], [MiddleName], [LastName], [EmailAddress], [Phone], [AddressLine], [City], [StateProvince], [CountryRegion], [PostalCode])
SELECT 101, N'Gerald', N'M.', N'Drury', N'gerald0@adventure-works.com', N'169-555-0178', N'4635 S. Harrison Blvd.', N'Ogden', N'Utah', N'United States', N'84401' UNION ALL
SELECT 102, N'Bart', NULL, N'Duncan', N'bart0@adventure-works.com', N'539-555-0121', N'99295 S.e. Tualatin Valley_hwy.', N'Hillsboro', N'Oregon', N'United States', N'97123' UNION ALL
SELECT 103, N'Maciej', NULL, N'Dusza', N'maciej1@adventure-works.com', N'962-555-0144', N'2564 S. Redwood Rd.', N'Riverton', N'Utah', N'United States', N'84065' UNION ALL
SELECT 104, N'Carol', N'B.', N'Elliott', N'carol2@adventure-works.com', N'847-555-0151', N'25220 Airline Road', N'Corpus Christi', N'Texas', N'United States', N'78404' UNION ALL
SELECT 105, N'Shannon', N'P.', N'Elliott', N'shannon0@adventure-works.com', N'425-555-0158', N'Factory Stores/tucson', N'Tucson', N'Arizona', N'United States', N'85701' UNION ALL
SELECT 106, N'John', NULL, N'Emory', N'john16@adventure-works.com', N'691-555-0149', N'Medford', N'Medford', N'Oregon', N'United States', N'97504' UNION ALL
SELECT 107, N'Gail', NULL, N'Erickson', N'gail1@adventure-works.com', N'834-555-0132', N'44025 W. Empire', N'Denby', N'South Dakota', N'United States', N'57716' UNION ALL
SELECT 108, N'Mark', N'B', N'Erickson', N'mark2@adventure-works.com', N'962-555-0112', N'Factory Stores Of America', N'Mesa', N'Arizona', N'United States', N'85201' UNION ALL
SELECT 109, N'Twanna', N'R.', N'Evans', N'twanna0@adventure-works.com', N'554-555-0124', N'Lewis County Mall', N'Chehalis', N'Washington', N'United States', N'98532' UNION ALL
SELECT 110, N'Ann', N'R.', N'Evans', N'ann1@adventure-works.com', N'252-555-0127', N'Ring Plaza', N'Norridge', N'Illinois', N'United States', N'60706' UNION ALL
SELECT 111, N'John', NULL, N'Evans', N'john17@adventure-works.com', N'581-555-0172', N'7709 West Virginia Avenue', N'Phoenix', N'Arizona', N'United States', N'85004' UNION ALL
SELECT 112, N'Carolyn', NULL, N'Farino', N'carolyn0@adventure-works.com', N'957-555-0125', N'3250 South Meridian', N'Puyallup', N'Washington', N'United States', N'98371' UNION ALL
SELECT 113, N'Geri', N'P.', N'Farrell', N'geri0@adventure-works.com', N'329-555-0183', N'49925 Crestview Drive N.E.', N'Rio Rancho', N'New Mexico', N'United States', N'87124' UNION ALL
SELECT 114, N'Kathie', NULL, N'Flood', N'kathie1@adventure-works.com', N'627-555-0192', N'705 SE Mall Parkway', N'Everett', N'Washington', N'United States', N'98201' UNION ALL
SELECT 115, N'Garth', NULL, N'Fort', N'garth0@adventure-works.com', N'768-555-0125', N'3250 Baldwin Park Blvd', N'Baldwin Park', N'California', N'United States', N'91706' UNION ALL
SELECT 116, N'Dorothy', N'J.', N'Fox', N'dorothy1@adventure-works.com', N'191-555-0198', N'Lakeline Mall', N'Cedar Park', N'Texas', N'United States', N'78613' UNION ALL
SELECT 117, N'Mihail', NULL, N'Frintu', N'mihail1@adventure-works.com', N'777-555-0163', N'Bayshore Mall', N'Eureka', N'California', N'United States', N'95501' UNION ALL
SELECT 118, N'John', NULL, N'Ford', N'john19@adventure-works.com', N'596-555-0153', N'23025 S.W. Military Rd.', N'San Antonio', N'Texas', N'United States', N'78204' UNION ALL
SELECT 119, N'Paul', N'J.', N'Fulton', N'paul3@adventure-works.com', N'492-555-0146', N'Horizon Outlet Center', N'Monroe', N'Michigan', N'United States', N'98272' UNION ALL
SELECT 120, N'Michael', NULL, N'Galos', N'michael15@adventure-works.com', N'912-555-0149', N'West Park Plaza', N'Irvine', N'California', N'United States', N'92614' UNION ALL
SELECT 121, N'Jon', NULL, N'Ganio', N'jon0@adventure-works.com', N'672-555-0112', N'3900 S. 997th St.', N'Milwaukee', N'Wisconsin', N'United States', N'53202' UNION ALL
SELECT 122, N'Dominic', N'P.', N'Gash', N'dominic0@adventure-works.com', N'192-555-0173', N'5420 West 22500 South', N'Salt Lake City', N'Utah', N'United States', N'84101' UNION ALL
SELECT 123, N'Janet', N'M.', N'Gates', N'janet1@adventure-works.com', N'710-555-0173', N'165 North Main', N'Austin', N'Texas', N'United States', N'78701' UNION ALL
SELECT 124, N'Janet', N'M.', N'Gates', N'janet1@adventure-works.com', N'710-555-0173', N'800 Interchange Blvd.', N'Austin', N'Texas', N'United States', N'78701' UNION ALL
SELECT 125, N'Orlando', N'N.', N'Gee', N'orlando0@adventure-works.com', N'245-555-0173', N'2251 Elliot Avenue', N'Seattle', N'Washington', N'United States', N'98104' UNION ALL
SELECT 126, N'Darren', NULL, N'Gehring', N'darren0@adventure-works.com', N'417-555-0182', N'509 Nafta Boulevard', N'Laredo', N'Texas', N'United States', N'78040' UNION ALL
SELECT 127, N'Jim', NULL, N'Geist', N'jim1@adventure-works.com', N'724-555-0161', N'35525-9th Street Sw', N'Puyallup', N'Washington', N'United States', N'98371' UNION ALL
SELECT 128, N'Guy', NULL, N'Gilbert', N'guy0@adventure-works.com', N'583-555-0198', N'Vista Marketplace', N'Alhambra', N'California', N'United States', N'91801' UNION ALL
SELECT 129, N'Janet', N'J.', N'Gilliat', N'janet2@adventure-works.com', N'521-555-0183', N'9995 West Central Entrance', N'Duluth', N'Minnesota', N'United States', N'55802' UNION ALL
SELECT 130, N'Mary', N'M.', N'Gimmi', N'mary6@adventure-works.com', N'149-555-0196', N'5525 South Hover Road', N'Longmont', N'Colorado', N'United States', N'80501' UNION ALL
SELECT 131, N'Jeanie', N'R.', N'Glenn', N'jeanie0@adventure-works.com', N'669-555-0149', N'9909 W. Ventura Boulevard', N'Camarillo', N'California', N'United States', N'93010' UNION ALL
SELECT 132, N'Scott', NULL, N'Gode', N'scott4@adventure-works.com', N'164-555-0145', N'2583 Se 272nd St', N'Kent', N'Washington', N'United States', N'98031' UNION ALL
SELECT 133, N'Mete', NULL, N'Goktepe', N'mete0@adventure-works.com', N'637-555-0120', N'Hanford Mall', N'Hanford', N'California', N'United States', N'93230' UNION ALL
SELECT 134, N'Abigail', N'J.', N'Gonzalez', N'abigail0@adventure-works.com', N'121-555-0139', N'99450 Highway 59 North', N'Humble', N'Texas', N'United States', N'77338' UNION ALL
SELECT 135, N'Michael', NULL, N'Graff', N'michael16@adventure-works.com', N'132-555-0150', N'9700 Sisk Road', N'Modesto', N'California', N'United States', N'95354' UNION ALL
SELECT 136, N'Douglas', NULL, N'Groncki', N'douglas2@adventure-works.com', N'385-555-0140', N'70259 West Sunnyview Ave', N'Visalia', N'California', N'United States', N'93291' UNION ALL
SELECT 137, N'Brian', NULL, N'Groth', N'brian5@adventure-works.com', N'461-555-0118', N'Gateway', N'Portland', N'Oregon', N'United States', N'97205' UNION ALL
SELECT 138, N'Erin', N'M.', N'Hagens', N'erin1@adventure-works.com', N'244-555-0127', N'25001 Montague Expressway', N'Milpitas', N'California', N'United States', N'95035' UNION ALL
SELECT 139, N'Betty', N'M.', N'Haines', N'betty0@adventure-works.com', N'867-555-0114', N'640 South 994th St. W.', N'Billings', N'Montana', N'United States', N'59101' UNION ALL
SELECT 140, N'Kerim', NULL, N'Hanif', N'kerim0@adventure-works.com', N'216-555-0122', N'60025 Bollinger Canyon Road', N'San Ramon', N'California', N'United States', N'94583' UNION ALL
SELECT 141, N'Jean', N'P.', N'Handley', N'jean1@adventure-works.com', N'582-555-0113', N'259826 Russell Rd. South', N'Kent', N'Washington', N'United States', N'98031' UNION ALL
SELECT 142, N'Lucy', NULL, N'Harrington', N'lucy0@adventure-works.com', N'828-555-0186', N'482505 Warm Springs Blvd.', N'Fremont', N'California', N'United States', N'94536' UNION ALL
SELECT 143, N'Keith', NULL, N'Harris', N'keith0@adventure-works.com', N'170-555-0127', N'7943 Walnut Ave', N'Renton', N'Washington', N'United States', N'98055' UNION ALL
SELECT 144, N'Keith', NULL, N'Harris', N'keith0@adventure-works.com', N'170-555-0127', N'3207 S Grady Way', N'Renton', N'Washington', N'United States', N'98055' UNION ALL
SELECT 145, N'Roger', NULL, N'Harui', N'roger0@adventure-works.com', N'774-555-0133', N'9927 N. Main St.', N'Tooele', N'Utah', N'United States', N'84074' UNION ALL
SELECT 146, N'Ann', N'T.', N'Hass', N'ann2@adventure-works.com', N'713-555-0168', N'Medford Outlet Center', N'Medford', N'Minnesota', N'United States', N'55049' UNION ALL
SELECT 147, N'John', NULL, N'Hanson', N'john20@adventure-works.com', N'107-555-0117', N'825 W 500 S', N'Bountiful', N'Utah', N'United States', N'84010' UNION ALL
SELECT 148, N'Valerie', N'M.', N'Hendricks', N'valerie0@adventure-works.com', N'859-555-0140', N'Kansas City Factory Outlet', N'Odessa', N'Missouri', N'United States', N'64076' UNION ALL
SELECT 149, N'Cheryl', N'M.', N'Herring', N'cheryl0@adventure-works.com', N'158-555-0154', N'Corp Ofc Accts Payable', N'El Segundo', N'California', N'United States', N'90245' UNION ALL
SELECT 150, N'Ronald', N'K.', N'Heymsfield', N'ronald1@adventure-works.com', N'784-555-0120', N'250775 SW Hillsdale Hwy', N'Beaverton', N'Oregon', N'United States', N'97005'
COMMIT;
RAISERROR (N'[dbo].[ContactsTestData]: Insert Batch: 3.....Done!', 10, 1) WITH NOWAIT;
GO

BEGIN TRANSACTION;
INSERT INTO [dbo].[ContactsTestData]([ContactID], [FirstName], [MiddleName], [LastName], [EmailAddress], [Phone], [AddressLine], [City], [StateProvince], [CountryRegion], [PostalCode])
SELECT 151, N'Mike', NULL, N'Hines', N'mike3@adventure-works.com', N'454-555-0160', N'25250 N 90th St', N'Scottsdale', N'Arizona', N'United States', N'85257' UNION ALL
SELECT 152, N'Matthew', NULL, N'Hink', N'matthew3@adventure-works.com', N'146-555-0176', N'No. 60 Bellis Fair Parkway', N'Bellingham', N'Washington', N'United States', N'98225' UNION ALL
SELECT 153, N'David', NULL, N'Hodgson', N'david16@adventure-works.com', N'969-555-0117', N'99700 Bell Road', N'Auburn', N'California', N'United States', N'95603' UNION ALL
SELECT 154, N'Helge', NULL, N'Hoeing', N'helge0@adventure-works.com', N'850-555-0198', N'Cedar Creek Stores', N'Mosinee', N'Wisconsin', N'United States', N'54455' UNION ALL
SELECT 155, N'Bob', NULL, N'Hodges', N'bob2@adventure-works.com', N'129-555-0120', N'Ohms Road', N'Houston', N'Texas', N'United States', N'77003' UNION ALL
SELECT 156, N'Juanita', N'J.', N'Holman', N'juanita0@adventure-works.com', N'996-555-0196', N'Lake Elisnor Place', N'Lake Elsinore', N'California', N'United States', N'92530' UNION ALL
SELECT 157, N'Peter', NULL, N'Houston', N'peter3@adventure-works.com', N'632-555-0171', N'1200 First Ave.', N'Joliet', N'Illinois', N'United States', N'60433' UNION ALL
SELECT 158, N'George', N'M.', N'Huckaby', N'george1@adventure-works.com', N'851-555-0127', N'3390 South 23rd St.', N'Tacoma', N'Washington', N'United States', N'98403' UNION ALL
SELECT 159, N'Joshua', N'J.', N'Huff', N'joshua0@adventure-works.com', N'190-555-0186', N'Management Mall', N'San Antonio', N'Texas', N'United States', N'78204' UNION ALL
SELECT 160, N'Phyllis', N'R.', N'Huntsman', N'phyllis1@adventure-works.com', N'153-555-0195', N'City Center', N'Minneapolis', N'Minnesota', N'United States', N'55402' UNION ALL
SELECT 161, N'Phyllis', N'R.', N'Huntsman', N'phyllis1@adventure-works.com', N'153-555-0195', N'99 Front Street', N'Minneapolis', N'Minnesota', N'United States', N'55402' UNION ALL
SELECT 162, N'Lawrence', N'E.', N'Hurkett', N'lawrence0@adventure-works.com', N'129-555-0185', N'6753 Howard Hughes Parkway', N'Las Vegas', N'Nevada', N'United States', N'89106' UNION ALL
SELECT 163, N'Lucio', NULL, N'Iallo', N'lucio0@adventure-works.com', N'199-555-0135', N'Simi @ The Plaza', N'Simi Valley', N'California', N'United States', N'93065' UNION ALL
SELECT 164, N'Richard', N'L.', N'Irwin', N'richard4@adventure-works.com', N'367-555-0124', N'99828 Routh Street, Suite 825', N'Dallas', N'Texas', N'United States', N'75201' UNION ALL
SELECT 165, N'Erik', NULL, N'Ismert', N'erik0@adventure-works.com', N'116-555-0163', N'4927 S Meridian Ave Ste D', N'Puyallup', N'Washington', N'United States', N'98371' UNION ALL
SELECT 166, N'Eric', N'A.', N'Jacobsen', N'eric5@adventure-works.com', N'703-555-0120', N'Topanga Plaza', N'Canoga Park', N'California', N'United States', N'91303' UNION ALL
SELECT 167, N'Jodan', N'M.', N'Jacobson', N'jodan0@adventure-works.com', N'652-555-0189', N'6030 Robinson Road', N'Jefferson City', N'Missouri', N'United States', N'65101' UNION ALL
SELECT 168, N'Mary', NULL, N'Alexander', N'mary7@adventure-works.com', N'344-555-0133', N'2345 West Spencer Road', N'Lynnwood', N'Washington', N'United States', N'98036' UNION ALL
SELECT 169, N'Joyce', NULL, N'Jarvis', N'joyce0@adventure-works.com', N'458-555-0179', N'955 E. County Line Rd.', N'Englewood', N'Colorado', N'United States', N'80110' UNION ALL
SELECT 170, N'Barry', NULL, N'Johnson', N'barry1@adventure-works.com', N'858-555-0140', N'2530 South Colorado Blvd.', N'Denver', N'Colorado', N'United States', N'80203' UNION ALL
SELECT 171, N'Barry', NULL, N'Johnson', N'barry1@adventure-works.com', N'858-555-0140', N'2000 300th Street', N'Denver', N'Colorado', N'United States', N'80203' UNION ALL
SELECT 172, N'Brian', NULL, N'Johnson', N'brian6@adventure-works.com', N'320-555-0134', N'625 W Jackson Blvd. Unit 2502', N'Chicago', N'Illinois', N'United States', N'60610' UNION ALL
SELECT 173, N'David', NULL, N'Johnson', N'david18@adventure-works.com', N'476-555-0139', N'7990 Ocean Beach Hwy.', N'Longview', N'Washington', N'United States', N'98632' UNION ALL
SELECT 174, N'Jean', NULL, N'Jordan', N'jean3@adventure-works.com', N'207-555-0129', N'440 West Huntington Dr.', N'Monrovia', N'California', N'United States', N'91016' UNION ALL
SELECT 175, N'Peggy', N'J.', N'Justice', N'peggy0@adventure-works.com', N'170-555-0189', N'15 East Main', N'Port Orchard', N'Washington', N'United States', N'98366' UNION ALL
SELECT 176, N'Diane', N'F.', N'Krane', N'diane4@adventure-works.com', N'224-555-0126', N'46460 West Oaks Drive', N'Novi', N'Michigan', N'United States', N'48375' UNION ALL
SELECT 177, N'Sandeep', NULL, N'Kaliyath', N'sandeep1@adventure-works.com', N'495-555-0113', N'630 N. Capitol Ave.', N'San Jose', N'California', N'United States', N'95112' UNION ALL
SELECT 178, N'Kay', N'E.', N'Krane', N'kay0@adventure-works.com', N'731-555-0187', N'Prime Outlets', N'Phoenix', N'Arizona', N'United States', N'85004' UNION ALL
SELECT 179, N'Kay', N'E.', N'Krane', N'kay0@adventure-works.com', N'731-555-0187', N'9228 Via Del Sol', N'Phoenix', N'Arizona', N'United States', N'85004' UNION ALL
SELECT 180, N'Sandeep', NULL, N'Katyal', N'sandeep2@adventure-works.com', N'928-555-0117', N'765 Delridge Way Sw', N'Seattle', N'Washington', N'United States', N'98104' UNION ALL
SELECT 181, N'John', NULL, N'Kelly', N'john22@adventure-works.com', N'330-555-0116', N'Pacific West Outlet', N'Gilroy', N'California', N'United States', N'95020' UNION ALL
SELECT 182, N'Robert', NULL, N'Kelly', N'robert7@adventure-works.com', N'510-555-0123', N'6425 Nw Loop 410', N'San Antonio', N'Texas', N'United States', N'78204' UNION ALL
SELECT 183, N'Kevin', NULL, N'Kennedy', N'kevin4@adventure-works.com', N'275-555-0179', N'2550 Ne Sandy Blvd', N'Portland', N'Oregon', N'United States', N'97205' UNION ALL
SELECT 184, N'Imtiaz', NULL, N'Khan', N'imtiaz0@adventure-works.com', N'249-555-0179', N'25095 W. Florissant', N'Ferguson', N'Missouri', N'United States', N'63135' UNION ALL
SELECT 185, N'Karan', NULL, N'Khanna', N'karan1@adventure-works.com', N'390-555-0150', N'755 W Washington Ave Ste D', N'Sequim', N'Washington', N'United States', N'98382' UNION ALL
SELECT 186, N'Anton', NULL, N'Kirilov', N'anton0@adventure-works.com', N'608-555-0162', N'2575 Rocky Mountain Ave.', N'Loveland', N'Colorado', N'United States', N'80537' UNION ALL
SELECT 187, N'Christian', NULL, N'Kleinerman', N'christian1@adventure-works.com', N'362-555-0177', N'25150 El Camino Real', N'San Bruno', N'California', N'United States', N'94066' UNION ALL
SELECT 188, N'Andrew', N'P.', N'Kobylinski', N'andrew5@adventure-works.com', N'129-555-0185', N'2526a Tri-Lake Blvd Ne', N'Kirkland', N'Washington', N'United States', N'98033' UNION ALL
SELECT 189, N'Eugene', NULL, N'Kogan', N'eugene2@adventure-works.com', N'136-555-0134', N'6756 Mowry', N'Newark', N'California', N'United States', N'94560' UNION ALL
SELECT 190, N'Scott', NULL, N'Konersmann', N'scott6@adventure-works.com', N'556-555-0192', N'52500 Liberty Way', N'Fort Worth', N'Texas', N'United States', N'76102' UNION ALL
SELECT 191, N'Joy', N'R.', N'Koski', N'joy0@adventure-works.com', N'810-555-0198', N'258101 Nw Evergreen Parkway', N'Beaverton', N'Oregon', N'United States', N'97005' UNION ALL
SELECT 192, N'Mitch', NULL, N'Kennedy', N'mitch0@adventure-works.com', N'996-555-0192', N'C/O Starpak, Inc.', N'Greeley', N'Colorado', N'United States', N'80631' UNION ALL
SELECT 193, N'Margaret', N'T.', N'Krupka', N'margaret1@adventure-works.com', N'107-555-0132', N'Great Northwestern', N'North Bend', N'Washington', N'United States', N'98045' UNION ALL
SELECT 194, N'Jeffrey', NULL, N'Kurtz', N'jeffrey3@adventure-works.com', N'452-555-0179', N'Receiving', N'Fullerton', N'California', N'United States', N'92831' UNION ALL
SELECT 195, N'Peter', NULL, N'Kurniawan', N'peter4@adventure-works.com', N'436-555-0160', N'63 W Monroe', N'Chicago', N'Illinois', N'United States', N'60610' UNION ALL
SELECT 196, N'Eric', NULL, N'Lang', N'eric6@adventure-works.com', N'932-555-0163', N'25300 Biddle Road', N'Medford', N'Oregon', N'United States', N'97504' UNION ALL
SELECT 197, N'Elsa', NULL, N'Leavitt', N'elsa0@adventure-works.com', N'482-555-0174', N'2575 West 2700 South', N'Salt Lake City', N'Utah', N'United States', N'84101' UNION ALL
SELECT 198, N'Michael', N'J.', N'Lee', N'michael18@adventure-works.com', N'396-555-0139', N'25718 Se Sunnyside Rd', N'Clackamas', N'Oregon', N'United States', N'97015-6403' UNION ALL
SELECT 199, N'Marjorie', N'M.', N'Lee', N'marjorie0@adventure-works.com', N'306-555-0166', N'2509 W. Frankford', N'Carrollton', N'Texas', N'United States', N'75006' UNION ALL
SELECT 200, N'Frank', NULL, N'Campbell', N'frank4@adventure-works.com', N'491-555-0132', N'251340 E. South St.', N'Cerritos', N'California', N'United States', N'90703'
COMMIT;
RAISERROR (N'[dbo].[ContactsTestData]: Insert Batch: 4.....Done!', 10, 1) WITH NOWAIT;
GO

BEGIN TRANSACTION;
INSERT INTO [dbo].[ContactsTestData]([ContactID], [FirstName], [MiddleName], [LastName], [EmailAddress], [Phone], [AddressLine], [City], [StateProvince], [CountryRegion], [PostalCode])
SELECT 201, N'Roger', NULL, N'Lengel', N'roger1@adventure-works.com', N'947-555-0143', N'490 Ne 4th St', N'Renton', N'Washington', N'United States', N'98055' UNION ALL
SELECT 202, N'A.', N'Francesca', N'Leonetti', N'a0@adventure-works.com', N'645-555-0193', N'5700 Legacy Dr', N'Plano', N'Texas', N'United States', N'75074' UNION ALL
SELECT 203, N'Bonnie', N'B.', N'Lepro', N'bonnie2@adventure-works.com', N'354-555-0130', N'25600 E St Andrews Pl', N'Santa Ana', N'California', N'United States', N'92701' UNION ALL
SELECT 204, N'Elsie', N'L.', N'Lewin', N'elsie0@adventure-works.com', N'803-555-0116', N'P.O. Box 6256916', N'Dallas', N'Texas', N'United States', N'75201' UNION ALL
SELECT 205, N'George', N'Z.', N'Li', N'george3@adventure-works.com', N'699-555-0183', N'910 Main Street.', N'Sparks', N'Nevada', N'United States', N'89431' UNION ALL
SELECT 206, N'Joseph', N'M.', N'Lique', N'joseph2@adventure-works.com', N'119-555-0195', N'257700 Ne 76th Street', N'Redmond', N'Washington', N'United States', N'98052' UNION ALL
SELECT 207, N'Paulo', N'H.', N'Lisboa', N'paulo0@adventure-works.com', N'380-555-0116', N'9178 Jumping St.', N'Dallas', N'Texas', N'United States', N'75201' UNION ALL
SELECT 208, N'Paulo', N'H.', N'Lisboa', N'paulo0@adventure-works.com', N'380-555-0116', N'Po Box 8259024', N'Dallas', N'Texas', N'United States', N'75201' UNION ALL
SELECT 209, N'David', N'J.', N'Liu', N'david20@adventure-works.com', N'440-555-0132', N'855 East Main Avenue', N'Zeeland', N'Michigan', N'United States', N'49464' UNION ALL
SELECT 210, N'Jinghao', NULL, N'Liu', N'jinghao1@adventure-works.com', N'928-555-0116', N'90025 Sterling St', N'Irving', N'Texas', N'United States', N'75061' UNION ALL
SELECT 211, N'Kevin', NULL, N'Liu', N'kevin5@adventure-works.com', N'926-555-0164', N'9992 Whipple Rd', N'Union City', N'California', N'United States', N'94587' UNION ALL
SELECT 212, N'Sharon', N'J.', N'Looney', N'sharon2@adventure-works.com', N'377-555-0132', N'74400 France Avenue South', N'Edina', N'Minnesota', N'United States', N'55436' UNION ALL
SELECT 213, N'Judy', N'R.', N'Lundahl', N'judy1@adventure-works.com', N'260-555-0130', N'25149 Howard Dr', N'West Chicago', N'Illinois', N'United States', N'60185' UNION ALL
SELECT 214, N'Denise', N'R.', N'Maccietto', N'denise1@adventure-works.com', N'537-555-0190', N'Port Huron', N'Port Huron', N'Michigan', N'United States', N'48060' UNION ALL
SELECT 215, N'Scott', NULL, N'MacDonald', N'scott7@adventure-works.com', N'470-555-0171', N'St. Louis Marketplace', N'Saint Louis', N'Missouri', N'United States', N'63103' UNION ALL
SELECT 216, N'Walter', N'J.', N'Mays', N'walter1@adventure-works.com', N'245-555-0191', N'Po Box 252525', N'Santa Ana', N'California', N'United States', N'92701' UNION ALL
SELECT 217, N'Kathy', N'R.', N'Marcovecchio', N'kathy0@adventure-works.com', N'942-555-0141', N'9905 Three Rivers Drive', N'Kelso', N'Washington', N'United States', N'98626' UNION ALL
SELECT 218, N'Melissa', N'R.', N'Marple', N'melissa0@adventure-works.com', N'685-555-0117', N'603 Gellert Blvd', N'Daly City', N'California', N'United States', N'94015' UNION ALL
SELECT 219, N'Frank', NULL, N'Mart¡nez', N'frank5@adventure-works.com', N'171-555-0147', N'870 N. 54th Ave.', N'Chandler', N'Arizona', N'United States', N'85225' UNION ALL
SELECT 220, N'Chris', NULL, N'Maxwell', N'chris6@adventure-works.com', N'642-555-0187', N'3025 E Waterway Blvd', N'Shelton', N'Washington', N'United States', N'98584' UNION ALL
SELECT 221, N'Sandra', N'B.', N'Maynard', N'sandra4@adventure-works.com', N'993-555-0179', N'9952 E. Lohman Ave.', N'Las Cruces', N'New Mexico', N'United States', N'88001' UNION ALL
SELECT 222, N'Lola', N'M.', N'McCarthy', N'lola0@adventure-works.com', N'173-555-0151', N'1050 Oak Street', N'Seattle', N'Washington', N'United States', N'98104' UNION ALL
SELECT 223, N'Jane', N'A.', N'McCarty', N'jane3@adventure-works.com', N'529-555-0195', N'409 Santa Monica Blvd.', N'Santa Monica', N'California', N'United States', N'90401' UNION ALL
SELECT 224, N'Yvonne', NULL, N'McKay', N'yvonne1@adventure-works.com', N'623-555-0144', N'Horizon Outlet', N'Woodbury', N'Minnesota', N'United States', N'55125' UNION ALL
SELECT 225, N'Nkenge', NULL, N'McLin', N'nkenge0@adventure-works.com', N'158-555-0123', N'Frontier Mall', N'Cheyenne', N'Wyoming', N'United States', N'82001' UNION ALL
SELECT 226, N'R. Morgan', N'L.', N'Mendoza', N'rmorgan0@adventure-works.com', N'963-555-0146', N'Johnson Creek', N'Johnson Creek', N'Wisconsin', N'United States', N'53038' UNION ALL
SELECT 227, N'Helen', N'M.', N'Meyer', N'helen2@adventure-works.com', N'519-555-0112', N'7505 Laguna Boulevard', N'Elk Grove', N'California', N'United States', N'95624' UNION ALL
SELECT 228, N'Virginia', N'L.', N'Miller', N'virginia0@adventure-works.com', N'918-555-0127', N'25111 228th St Sw', N'Bothell', N'Washington', N'United States', N'98011' UNION ALL
SELECT 229, N'Virginia', N'L.', N'Miller', N'virginia0@adventure-works.com', N'918-555-0127', N'8713 Yosemite Ct.', N'Bothell', N'Washington', N'United States', N'98011' UNION ALL
SELECT 230, N'Dylan', NULL, N'Miller', N'dylan1@adventure-works.com', N'140-555-0192', N'Parkway Plaza', N'El Cajon', N'California', N'United States', N'92020' UNION ALL
SELECT 231, N'Frank', NULL, N'Miller', N'frank6@adventure-works.com', N'118-555-0184', N'123 W. Lake Ave.', N'Peoria', N'Illinois', N'United States', N'61606' UNION ALL
SELECT 232, N'Neva', N'M.', N'Mitchell', N'neva0@adventure-works.com', N'992-555-0134', N'2528 Meridian E', N'Puyallup', N'Washington', N'United States', N'98371' UNION ALL
SELECT 233, N'Joseph', N'P.', N'Mitzner', N'joseph4@adventure-works.com', N'129-555-0164', N'123 Camelia Avenue', N'Oxnard', N'California', N'United States', N'93030' UNION ALL
SELECT 234, N'Laura', N'C.', N'Steele', N'laura3@adventure-works.com', N'741-555-0173', N'253731 West Bell Road', N'Surprise', N'Arizona', N'United States', N'85374' UNION ALL
SELECT 235, N'Alan', NULL, N'Steiner', N'alan4@adventure-works.com', N'792-555-0194', N'2255 254th Avenue Se', N'Albany', N'Oregon', N'United States', N'97321' UNION ALL
SELECT 236, N'Derik', NULL, N'Stenerson', N'derik0@adventure-works.com', N'441-555-0144', N'Factory Merchants', N'Branson', N'Missouri', N'United States', N'65616' UNION ALL
SELECT 237, N'Vassar', N'J.', N'Stern', N'vassar0@adventure-works.com', N'328-555-0123', N'25130 South State Street', N'Sandy', N'Utah', N'United States', N'84070' UNION ALL
SELECT 238, N'Wathalee', N'R.', N'Steuber', N'wathalee0@adventure-works.com', N'517-555-0120', N'700 Se Sunnyside Road', N'Clackamas', N'Oregon', N'United States', N'97015' UNION ALL
SELECT 239, N'Alice', N'M.', N'Steiner', N'alice4@adventure-works.com', N'355-555-0180', N'Lone Star Factory', N'La Marque', N'Texas', N'United States', N'77568' UNION ALL
SELECT 240, N'Liza Marie', N'N.', N'Stevens', N'lizamarie0@adventure-works.com', N'366-555-0110', N'7750 E Marching Rd', N'Scottsdale', N'Arizona', N'United States', N'85257' UNION ALL
SELECT 241, N'Robert', N'B.', N'Stotka', N'robert12@adventure-works.com', N'493-555-0185', N'Sports Stores @ Tuscola', N'Tuscola', N'Illinois', N'United States', N'61953' UNION ALL
SELECT 242, N'Kayla', N'M.', N'Stotler', N'kayla0@adventure-works.com', N'315-555-0131', N'9980 S Alma School Road', N'Chandler', N'Arizona', N'United States', N'85225' UNION ALL
SELECT 243, N'Ruth', N'J.', N'Suffin', N'ruth2@adventure-works.com', N'924-555-0195', N'Lancaster Mall', N'Salem', N'Oregon', N'United States', N'97301' UNION ALL
SELECT 244, N'Elizabeth', N'J.', N'Sullivan', N'elizabeth4@adventure-works.com', N'306-555-0112', N'Town East Center', N'Mesquite', N'Texas', N'United States', N'75149' UNION ALL
SELECT 245, N'Michael', NULL, N'Sullivan', N'michael24@adventure-works.com', N'323-555-0113', N'5867 Sunrise Boulevard', N'Citrus Heights', N'California', N'United States', N'95610' UNION ALL
SELECT 246, N'Brad', NULL, N'Sutton', N'brad0@adventure-works.com', N'688-555-0115', N'Three Rivers Mall', N'Kelso', N'Washington', N'United States', N'98626' UNION ALL
SELECT 247, N'Abraham', N'L.', N'Swearengin', N'abraham0@adventure-works.com', N'926-555-0136', N'9920 Bridgepointe Parkway', N'San Mateo', N'California', N'United States', N'94404' UNION ALL
SELECT 248, N'Julie', NULL, N'Taft-Rider', N'julie1@adventure-works.com', N'145-555-0194', N'6996 South Lindbergh', N'Saint Louis', N'Missouri', N'United States', N'63103' UNION ALL
SELECT 249, N'Clarence', N'R.', N'Tatman', N'clarence0@adventure-works.com', N'787-555-0128', N'San Diego Factory', N'San Ysidro', N'California', N'United States', N'92173' UNION ALL
SELECT 250, N'Chad', N'J.', N'Tedford', N'chad1@adventure-works.com', N'588-555-0128', N'9500b E. Central Texas Expressway', N'Killeen', N'Texas', N'United States', N'76541'
COMMIT;
RAISERROR (N'[dbo].[ContactsTestData]: Insert Batch: 5.....Done!', 10, 1) WITH NOWAIT;
GO

BEGIN TRANSACTION;
INSERT INTO [dbo].[ContactsTestData]([ContactID], [FirstName], [MiddleName], [LastName], [EmailAddress], [Phone], [AddressLine], [City], [StateProvince], [CountryRegion], [PostalCode])
SELECT 251, N'Vanessa', N'J.', N'Tench', N'vanessa0@adventure-works.com', N'785-555-0163', N'2500 N Serene Blvd', N'El Segundo', N'California', N'United States', N'90245' UNION ALL
SELECT 252, N'Judy', N'J.', N'Thames', N'judy3@adventure-works.com', N'799-555-0118', N'25102 Springwater', N'Wenatchee', N'Washington', N'United States', N'98801' UNION ALL
SELECT 253, N'Donald', N'M.', N'Thompson', N'donald1@adventure-works.com', N'273-555-0111', N'25472 Marlay Ave', N'Fontana', N'California', N'United States', N'92335' UNION ALL
SELECT 254, N'Kendra', N'N.', N'Thompson', N'kendra0@adventure-works.com', N'464-555-0188', N'22571 South 2500 East', N'Idaho Falls', N'Idaho', N'United States', N'83402' UNION ALL
SELECT 255, N'Daniel', N'P.', N'Thompson', N'daniel2@adventure-works.com', N'247-555-0197', N'755 Nw Grandstand', N'Issaquah', N'Washington', N'United States', N'98027' UNION ALL
SELECT 256, N'Diane', NULL, N'Tibbott', N'diane5@adventure-works.com', N'847-555-0184', N'8525 South Parker Road', N'Parker', N'Colorado', N'United States', N'80138' UNION ALL
SELECT 257, N'Delia', N'B.', N'Toone', N'delia0@adventure-works.com', N'328-555-0192', N'755 Columbia Ctr Blvd', N'Kennewick', N'Washington', N'United States', N'99337' UNION ALL
SELECT 258, N'Michael John', N'R.', N'Troyer', N'michaeljohn0@adventure-works.com', N'308-555-0175', N'Oxnard Outlet', N'Oxnard', N'California', N'United States', N'93030' UNION ALL
SELECT 259, N'Christie', N'J.', N'Trujillo', N'christie0@adventure-works.com', N'686-555-0180', N'One Dancing, Rr No. 25', N'Round Rock', N'Texas', N'United States', N'78664' UNION ALL
SELECT 260, N'Sairaj', NULL, N'Uddin', N'sairaj1@adventure-works.com', N'767-555-0193', N'Natomas Marketplace', N'Sacramento', N'California', N'United States', N'95814' UNION ALL
SELECT 261, N'Sunil', NULL, N'Uppal', N'sunil0@adventure-works.com', N'184-555-0187', N'25500 Old Spanish Trail', N'Houston', N'Texas', N'United States', N'77003' UNION ALL
SELECT 262, N'Jessie', N'E.', N'Valerio', N'jessie0@adventure-works.com', N'103-555-0179', N'Mall Of Orange', N'Orange', N'California', N'United States', N'92867' UNION ALL
SELECT 263, N'Gregory', N'T.', N'Vanderbout', N'gregory1@adventure-works.com', N'684-555-0134', N'950 Gateway Street', N'Springfield', N'Oregon', N'United States', N'97477' UNION ALL
SELECT 264, N'Michael', NULL, N'Vanderhyde', N'michael25@adventure-works.com', N'918-555-0141', N'Lincoln Square', N'Arlington', N'Texas', N'United States', N'76010' UNION ALL
SELECT 265, N'Margaret', N'J.', N'Vanderkamp', N'margaret2@adventure-works.com', N'265-555-0143', N'62500 Neil Road', N'Reno', N'Nevada', N'United States', N'89502' UNION ALL
SELECT 266, N'Nieves', N'J.', N'Vargas', N'nieves0@adventure-works.com', N'371-555-0184', N'Kensington Valley Shops', N'Howell', N'Michigan', N'United States', N'48843' UNION ALL
SELECT 267, N'Gary', N'T', N'Vargas', N'gary6@adventure-works.com', N'112-555-0176', N'Stevens Creek Shopping Center', N'San Jose', N'California', N'United States', N'95112' UNION ALL
SELECT 268, N'Ranjit', N'Rudra', N'Varkey Chudukatil', N'ranjit1@adventure-works.com', N'810-555-0160', N'455 256th St.', N'Moline', N'Illinois', N'United States', N'61265' UNION ALL
SELECT 269, N'Patricia', N'M.', N'Vasquez', N'patricia2@adventure-works.com', N'490-555-0132', N'409 S. Main Ste. 25', N'Ellensburg', N'Washington', N'United States', N'98926' UNION ALL
SELECT 270, N'Wanda', N'F.', N'Vernon', N'wanda0@adventure-works.com', N'433-555-0168', N'Ontario Mills', N'Ontario', N'California', N'United States', N'91764' UNION ALL
SELECT 271, N'Robert', N'R.', N'Vessa', N'robert13@adventure-works.com', N'560-555-0171', N'72540 Blanco Rd.', N'San Antonio', N'Texas', N'United States', N'78204' UNION ALL
SELECT 272, N'Caroline', N'A.', N'Vicknair', N'caroline0@adventure-works.com', N'695-555-0158', N'660 Lindbergh', N'Saint Louis', N'Missouri', N'United States', N'63103'
COMMIT;
RAISERROR (N'[dbo].[ContactsTestData]: Insert Batch: 6.....Done!', 10, 1) WITH NOWAIT;
GO

SET IDENTITY_INSERT [dbo].[ContactsTestData] OFF;

