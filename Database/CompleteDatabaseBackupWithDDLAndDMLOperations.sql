CREATE DATABASE [moviesrent];
GO
USE [moviesrent]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 5/8/2021 3:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[cust_id] [int] IDENTITY(1100,1) NOT NULL,
	[first_name] [varchar](100) NULL,
	[last_name] [varchar](100) NULL,
	[address] [varchar](500) NULL,
	[phone_no] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwAllCustomer]    Script Date: 5/8/2021 3:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vwAllCustomer]
as
SELECT cust_id, first_name + ' ' + last_name AS name
FROM     dbo.customer;
GO
/****** Object:  Table [dbo].[movies]    Script Date: 5/8/2021 3:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movies](
	[movie_id] [int] IDENTITY(2100,1) NOT NULL,
	[title] [varchar](100) NULL,
	[rating] [float] NULL,
	[rental_cost] [float] NULL,
	[release_year] [int] NULL,
	[genre_name] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[movie_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwAllMovie]    Script Date: 5/8/2021 3:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vwAllMovie]
as
SELECT movie_id, title + ' $' + CAST(rental_cost AS varchar(10)) AS title
FROM     movies;
GO
/****** Object:  Table [dbo].[rented_movies]    Script Date: 5/8/2021 3:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rented_movies](
	[rent_id] [int] IDENTITY(1,1) NOT NULL,
	[movie_id] [int] NULL,
	[cust_id] [int] NULL,
	[date_rented] [datetime] NULL,
	[date_returned] [datetime] NULL,
	[rented_cost] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[rent_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customer] ON 
GO
INSERT [dbo].[customer] ([cust_id], [first_name], [last_name], [address], [phone_no]) VALUES (1100, N'Peter', N'Jackson', N'Street 9 Auckland New Zealand', N'6478989630')
GO
INSERT [dbo].[customer] ([cust_id], [first_name], [last_name], [address], [phone_no]) VALUES (1101, N'Edmund', N'Hillary', N'Stree 10 Auckland New Zealand', N'6478521369')
GO
INSERT [dbo].[customer] ([cust_id], [first_name], [last_name], [address], [phone_no]) VALUES (1102, N'Jacinda', N'Ardern', N'Stree 11 Auckland', N'6412365789')
GO
INSERT [dbo].[customer] ([cust_id], [first_name], [last_name], [address], [phone_no]) VALUES (1103, N'Russell', N'Crowe', N'Stree 12 Auckland', N'6412857469')
GO
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
SET IDENTITY_INSERT [dbo].[movies] ON 
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [genre_name]) VALUES (2100, N'Taken', 5, 2, 2009, N'Thriller')
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [genre_name]) VALUES (2101, N'Furious Seven', 4, 5, 2020, N'Sci-Fi')
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [genre_name]) VALUES (2102, N'Underworld: Awakening', 5, 2, 2012, N'Horror')
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [genre_name]) VALUES (2103, N'Safe House', 5, 5, 2019, N'Action')
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [genre_name]) VALUES (2104, N'Funny People', 5, 2, 2009, N'Comedy')
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [genre_name]) VALUES (2105, N'Twilight', 5, 2, 2011, N'Romance')
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [genre_name]) VALUES (2106, N'Avenger End Game', 5, 5, 2019, N'Sci-Fi')
GO
SET IDENTITY_INSERT [dbo].[movies] OFF
GO
SET IDENTITY_INSERT [dbo].[rented_movies] ON 
GO
INSERT [dbo].[rented_movies] ([rent_id], [movie_id], [cust_id], [date_rented], [date_returned], [rented_cost]) VALUES (1, 2100, 1100, CAST(N'2021-05-06T15:34:35.000' AS DateTime), NULL, 2)
GO
INSERT [dbo].[rented_movies] ([rent_id], [movie_id], [cust_id], [date_rented], [date_returned], [rented_cost]) VALUES (2, 2103, 1102, CAST(N'2021-05-02T15:35:43.000' AS DateTime), NULL, 5)
GO
INSERT [dbo].[rented_movies] ([rent_id], [movie_id], [cust_id], [date_rented], [date_returned], [rented_cost]) VALUES (3, 2104, 1102, CAST(N'2021-04-27T15:35:59.000' AS DateTime), NULL, 2)
GO
INSERT [dbo].[rented_movies] ([rent_id], [movie_id], [cust_id], [date_rented], [date_returned], [rented_cost]) VALUES (4, 2106, 1103, CAST(N'2021-05-06T15:36:09.000' AS DateTime), CAST(N'2021-05-08T15:40:40.353' AS DateTime), 5)
GO
SET IDENTITY_INSERT [dbo].[rented_movies] OFF
GO
ALTER TABLE [dbo].[rented_movies]  WITH CHECK ADD FOREIGN KEY([cust_id])
REFERENCES [dbo].[customer] ([cust_id])
GO
ALTER TABLE [dbo].[rented_movies]  WITH CHECK ADD FOREIGN KEY([movie_id])
REFERENCES [dbo].[movies] ([movie_id])
GO
/****** Object:  StoredProcedure [dbo].[prcDisplayRentedMovies]    Script Date: 5/8/2021 3:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[prcDisplayRentedMovies]
as
select rent_id, first_name + ' ' + last_name as name,address,phone_no, title , rm.rented_cost , date_rented, date_returned
from rented_movies rm join customer c on rm.cust_id = c.cust_id
join movies m on rm.movie_id = m.movie_id;
GO
/****** Object:  StoredProcedure [dbo].[prcDisplayRentedOutMovies]    Script Date: 5/8/2021 3:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[prcDisplayRentedOutMovies]
as
select rent_id, first_name + ' ' + last_name as name,address,phone_no, title , rm.rented_cost , date_rented, date_returned
from rented_movies rm join customer c on rm.cust_id = c.cust_id
join movies m on rm.movie_id = m.movie_id where date_returned is null;
GO
