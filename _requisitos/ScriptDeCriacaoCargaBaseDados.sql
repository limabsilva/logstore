CREATE DATABASE [dbHungryPizza]
GO
USE [dbHungryPizza]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 29/08/2022 09:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[Telephone] [nvarchar](11) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[StreetName] [nvarchar](200) NOT NULL,
	[Number] [int] NOT NULL,
	[Complement] [nvarchar](100) NULL,
	[Neighborhood] [nvarchar](100) NOT NULL,
	[State] [nvarchar](100) NOT NULL,
	[City] [nvarchar](100) NOT NULL,
	[ZipCode] [nvarchar](20) NOT NULL,
	[Register] [datetime2](7) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemFlavors]    Script Date: 29/08/2022 09:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemFlavors](
	[ItemFlavorsID] [int] IDENTITY(1,1) NOT NULL,
	[OrderItemID] [int] NOT NULL,
	[PizzaFlavorID] [int] NOT NULL,
	[Register] [datetime2](7) NULL,
 CONSTRAINT [PK_ItemFlavors] PRIMARY KEY CLUSTERED 
(
	[ItemFlavorsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 29/08/2022 09:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[Description] [nvarchar](500) NULL,
	[DeliveryAddress] [nvarchar](500) NOT NULL,
	[PriceTotal] [decimal](18, 2) NOT NULL,
	[Register] [datetime2](7) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItem]    Script Date: 29/08/2022 09:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItem](
	[OrderItemID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[Comments] [nvarchar](500) NULL,
	[PriceItem] [decimal](18, 2) NOT NULL,
	[Register] [datetime2](7) NULL,
 CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED 
(
	[OrderItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PizzaFlavor]    Script Date: 29/08/2022 09:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PizzaFlavor](
	[PizzaFlavorID] [int] IDENTITY(1,1) NOT NULL,
	[Flavor] [nvarchar](200) NULL,
	[Ingredients] [nvarchar](500) NULL,
	[Available] [bit] NULL,
	[Register] [datetime2](7) NULL,
 CONSTRAINT [PK_PizzaFlavor] PRIMARY KEY CLUSTERED 
(
	[PizzaFlavorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PizzaFlavorsPrice]    Script Date: 29/08/2022 09:43:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PizzaFlavorsPrice](
	[PizzaFlavorsPriceID] [int] IDENTITY(1,1) NOT NULL,
	[PizzaFlavorEntityID] [int] NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Size] [nvarchar](20) NULL,
	[Register] [datetime2](7) NULL,
 CONSTRAINT [PK_PizzaFlavorsPrice] PRIMARY KEY CLUSTERED 
(
	[PizzaFlavorsPriceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Client] ON 
GO
INSERT [dbo].[Client] ([ClientID], [Telephone], [Name], [StreetName], [Number], [Complement], [Neighborhood], [State], [City], [ZipCode], [Register]) VALUES (1, N'11900000000', N'Cliente não registrado', N'Rua Recife', 916, N'', N'Cidade Nova', N'SP', N'Santa Barbara Doeste', N'13454369', CAST(N'2022-08-29T08:41:32.7057067' AS DateTime2))
GO
INSERT [dbo].[Client] ([ClientID], [Telephone], [Name], [StreetName], [Number], [Complement], [Neighborhood], [State], [City], [ZipCode], [Register]) VALUES (2, N'21987930138', N'Bruno de Lima Silva', N'Rua Recife', 916, N'', N'Cidade Nova', N'SP', N'Santa Barbara Doeste', N'13454369', CAST(N'2022-08-29T08:43:42.7376440' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[ItemFlavors] ON 
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (2, 2, 1, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (3, 3, 3, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (4, 4, 4, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (5, 4, 7, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (6, 5, 1, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (7, 6, 3, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (8, 7, 4, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (9, 7, 7, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (10, 8, 1, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (11, 9, 3, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (12, 10, 4, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (13, 10, 7, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (14, 11, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (15, 12, 4, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (16, 13, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (17, 13, 7, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (18, 14, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (19, 15, 4, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (20, 16, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (21, 16, 7, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (22, 17, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (23, 18, 4, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (24, 19, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (25, 19, 7, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (26, 20, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (27, 21, 4, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (28, 22, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (29, 22, 7, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (30, 23, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (31, 24, 4, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (32, 25, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (33, 25, 7, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (34, 26, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (35, 27, 7, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (36, 28, 7, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (37, 28, 7, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (38, 29, 1, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (39, 30, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (40, 31, 3, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (41, 31, 3, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (42, 32, 1, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (43, 33, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (44, 34, 3, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (45, 34, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (46, 35, 6, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (47, 36, 1, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (48, 37, 5, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (49, 37, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (50, 38, 6, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (51, 39, 1, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (52, 40, 5, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (53, 40, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (54, 41, 6, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (55, 42, 1, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (56, 43, 5, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (57, 43, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (58, 44, 6, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (59, 45, 1, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (60, 46, 5, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (61, 46, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (62, 47, 6, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (63, 48, 1, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (64, 49, 5, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (65, 49, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (66, 50, 6, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (67, 51, 1, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (68, 52, 5, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (69, 52, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (70, 53, 6, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (71, 54, 1, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (72, 55, 5, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (73, 55, 2, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (74, 56, 6, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (75, 57, 1, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (76, 58, 5, NULL)
GO
INSERT [dbo].[ItemFlavors] ([ItemFlavorsID], [OrderItemID], [PizzaFlavorID], [Register]) VALUES (77, 58, 2, NULL)
GO
SET IDENTITY_INSERT [dbo].[ItemFlavors] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (1, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(0.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:54:39.1112105' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (2, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(143.75 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:28.2450735' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (3, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(143.75 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:34.3557973' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (4, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(143.75 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:35.1712705' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (5, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(162.48 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:45.0488585' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (6, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(162.48 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:46.4594943' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (7, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(162.48 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:47.4513629' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (8, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(162.48 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:47.8988495' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (9, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(162.48 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:48.3766624' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (10, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(179.97 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:55.4325795' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (11, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(152.49 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:04.8114949' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (12, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(161.24 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:07.0433797' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (13, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(152.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:17.4864189' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (14, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(152.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:18.5309933' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (15, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(152.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:19.3771712' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (16, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(152.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:20.0320442' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (17, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(152.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:20.5829895' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (18, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(152.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:21.4119669' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (19, 2, N'Pago com PIX antecipadamente.', N'Rua Recife, 916 -   Cidade Nova - Santa Barbara Doeste - SP - 13454369', CAST(152.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:21.9689152' AS DateTime2))
GO
INSERT [dbo].[Order] ([OrderID], [ClientID], [Description], [DeliveryAddress], [PriceTotal], [Register]) VALUES (20, 1, N'Pago com PIX antecipadamente. - Cliente: Zé da Padaria', N'Rua Nova, 450 -   Santa Cruz - São Caetano - SP - 123454-20', CAST(152.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:59:24.0987511' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderItem] ON 
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (2, 2, N'Sem cebola', CAST(50.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:28.6448164' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (3, 2, N'Favor trocar muçarela por gorgonzola.', CAST(42.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:28.6944052' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (4, 2, N'Pouca cebola e sem azeitona.', CAST(51.25 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:28.7003674' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (5, 3, N'Sem cebola', CAST(50.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:34.3611067' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (6, 3, N'Favor trocar muçarela por gorgonzola.', CAST(42.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:34.3655690' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (7, 3, N'Pouca cebola e sem azeitona.', CAST(51.25 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:34.3711546' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (8, 4, N'Sem cebola', CAST(50.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:35.1753400' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (9, 4, N'Favor trocar muçarela por gorgonzola.', CAST(42.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:35.1807643' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (10, 4, N'Pouca cebola e sem azeitona.', CAST(51.25 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:35.1850032' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (11, 5, N'Sem cebola', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:45.0515703' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (12, 5, N'Favor trocar muçarela por gorgonzola.', CAST(42.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:45.0559188' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (13, 5, N'Pouca cebola e sem azeitona.', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:45.0619012' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (14, 6, N'Sem cebola', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:46.4621056' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (15, 6, N'Favor trocar muçarela por gorgonzola.', CAST(42.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:46.4681881' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (16, 6, N'Pouca cebola e sem azeitona.', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:46.4747729' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (17, 7, N'Sem cebola', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:47.4557565' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (18, 7, N'Favor trocar muçarela por gorgonzola.', CAST(42.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:47.4630527' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (19, 7, N'Pouca cebola e sem azeitona.', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:47.4682077' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (20, 8, N'Sem cebola', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:47.9030259' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (21, 8, N'Favor trocar muçarela por gorgonzola.', CAST(42.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:47.9099569' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (22, 8, N'Pouca cebola e sem azeitona.', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:47.9161108' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (23, 9, N'Sem cebola', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:48.3807922' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (24, 9, N'Favor trocar muçarela por gorgonzola.', CAST(42.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:48.3866520' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (25, 9, N'Pouca cebola e sem azeitona.', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:48.3925086' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (26, 10, N'Sem cebola', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:55.4365702' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (27, 10, N'Favor trocar muçarela por gorgonzola.', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:55.4438168' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (28, 10, N'Pouca cebola e sem azeitona.', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:57:55.4513787' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (29, 11, N'Sem cebola', CAST(50.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:04.8158442' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (30, 11, N'Favor trocar muçarela por gorgonzola.', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:04.8219761' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (31, 11, N'Pouca cebola e sem azeitona.', CAST(42.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:04.8293452' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (32, 12, N'Sem cebola', CAST(50.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:07.0485859' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (33, 12, N'Favor trocar muçarela por gorgonzola.', CAST(59.99 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:07.0549123' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (34, 12, N'Pouca cebola e sem azeitona.', CAST(51.25 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:07.0685143' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (35, 13, N'Sem cebola', CAST(45.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:17.4901080' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (36, 13, N'Favor trocar muçarela por gorgonzola.', CAST(50.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:17.4952612' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (37, 13, N'Pouca cebola e sem azeitona.', CAST(57.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:17.4995382' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (38, 14, N'Sem cebola', CAST(45.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:18.5357189' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (39, 14, N'Favor trocar muçarela por gorgonzola.', CAST(50.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:18.5431689' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (40, 14, N'Pouca cebola e sem azeitona.', CAST(57.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:18.5499196' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (41, 15, N'Sem cebola', CAST(45.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:19.3816015' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (42, 15, N'Favor trocar muçarela por gorgonzola.', CAST(50.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:19.3880222' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (43, 15, N'Pouca cebola e sem azeitona.', CAST(57.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:19.3952587' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (44, 16, N'Sem cebola', CAST(45.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:20.0353599' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (45, 16, N'Favor trocar muçarela por gorgonzola.', CAST(50.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:20.0425771' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (46, 16, N'Pouca cebola e sem azeitona.', CAST(57.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:20.0498860' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (47, 17, N'Sem cebola', CAST(45.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:20.5870647' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (48, 17, N'Favor trocar muçarela por gorgonzola.', CAST(50.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:20.5945573' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (49, 17, N'Pouca cebola e sem azeitona.', CAST(57.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:20.6015030' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (50, 18, N'Sem cebola', CAST(45.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:21.4153454' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (51, 18, N'Favor trocar muçarela por gorgonzola.', CAST(50.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:21.4202095' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (52, 18, N'Pouca cebola e sem azeitona.', CAST(57.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:21.4265342' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (53, 19, N'Sem cebola', CAST(45.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:21.9732434' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (54, 19, N'Favor trocar muçarela por gorgonzola.', CAST(50.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:21.9787080' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (55, 19, N'Pouca cebola e sem azeitona.', CAST(57.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:58:21.9835479' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (56, 20, N'Sem cebola', CAST(45.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:59:24.1022918' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (57, 20, N'Favor trocar muçarela por gorgonzola.', CAST(50.00 AS Decimal(18, 2)), CAST(N'2022-08-29T08:59:24.1168306' AS DateTime2))
GO
INSERT [dbo].[OrderItem] ([OrderItemID], [OrderID], [Comments], [PriceItem], [Register]) VALUES (58, 20, N'Pouca cebola e sem azeitona.', CAST(57.50 AS Decimal(18, 2)), CAST(N'2022-08-29T08:59:24.1208208' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[OrderItem] OFF
GO
SET IDENTITY_INSERT [dbo].[PizzaFlavor] ON 
GO
INSERT [dbo].[PizzaFlavor] ([PizzaFlavorID], [Flavor], [Ingredients], [Available], [Register]) VALUES (1, N'3 Queijos', N'Queijo prato, muçarela e catupiry.', 1, CAST(N'2022-08-29T08:46:33.1800010' AS DateTime2))
GO
INSERT [dbo].[PizzaFlavor] ([PizzaFlavorID], [Flavor], [Ingredients], [Available], [Register]) VALUES (2, N'Frango com requeijão', N'Frango, milho, requeijão e muçarela.', 1, CAST(N'2022-08-29T08:46:44.5986930' AS DateTime2))
GO
INSERT [dbo].[PizzaFlavor] ([PizzaFlavorID], [Flavor], [Ingredients], [Available], [Register]) VALUES (3, N'Muçarela', N'Muçarela com orégano.', 1, CAST(N'2022-08-29T08:47:47.6619828' AS DateTime2))
GO
INSERT [dbo].[PizzaFlavor] ([PizzaFlavorID], [Flavor], [Ingredients], [Available], [Register]) VALUES (4, N'Calabresa', N'Calabresa, cebola e muçarela.', 1, CAST(N'2022-08-29T08:47:55.4865358' AS DateTime2))
GO
INSERT [dbo].[PizzaFlavor] ([PizzaFlavorID], [Flavor], [Ingredients], [Available], [Register]) VALUES (5, N'Pepperoni', N'Pepperoni com orégano.', 1, CAST(N'2022-08-29T08:48:02.2971250' AS DateTime2))
GO
INSERT [dbo].[PizzaFlavor] ([PizzaFlavorID], [Flavor], [Ingredients], [Available], [Register]) VALUES (6, N'Portuguesa', N'Cebola, tomate, pimentação, ovos cozido e muçarela.', 1, CAST(N'2022-08-29T08:48:09.2367663' AS DateTime2))
GO
INSERT [dbo].[PizzaFlavor] ([PizzaFlavorID], [Flavor], [Ingredients], [Available], [Register]) VALUES (7, N'Veggie', N'Rúcula, alface, manjericão, molho de tomate, cebola.', 1, CAST(N'2022-08-29T08:48:16.4131377' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[PizzaFlavor] OFF
GO
SET IDENTITY_INSERT [dbo].[PizzaFlavorsPrice] ON 
GO
INSERT [dbo].[PizzaFlavorsPrice] ([PizzaFlavorsPriceID], [PizzaFlavorEntityID], [Price], [Size], [Register]) VALUES (1, 1, CAST(50.00 AS Decimal(18, 2)), N'FAMÍLIA', CAST(N'2022-08-29T08:46:33.2117503' AS DateTime2))
GO
INSERT [dbo].[PizzaFlavorsPrice] ([PizzaFlavorsPriceID], [PizzaFlavorEntityID], [Price], [Size], [Register]) VALUES (2, 2, CAST(59.99 AS Decimal(18, 2)), N'FAMÍLIA', CAST(N'2022-08-29T08:46:44.6034243' AS DateTime2))
GO
INSERT [dbo].[PizzaFlavorsPrice] ([PizzaFlavorsPriceID], [PizzaFlavorEntityID], [Price], [Size], [Register]) VALUES (3, 3, CAST(42.50 AS Decimal(18, 2)), N'FAMÍLIA', CAST(N'2022-08-29T08:47:47.7096331' AS DateTime2))
GO
INSERT [dbo].[PizzaFlavorsPrice] ([PizzaFlavorsPriceID], [PizzaFlavorEntityID], [Price], [Size], [Register]) VALUES (4, 4, CAST(42.50 AS Decimal(18, 2)), N'FAMÍLIA', CAST(N'2022-08-29T08:47:55.4934191' AS DateTime2))
GO
INSERT [dbo].[PizzaFlavorsPrice] ([PizzaFlavorsPriceID], [PizzaFlavorEntityID], [Price], [Size], [Register]) VALUES (5, 5, CAST(55.00 AS Decimal(18, 2)), N'FAMÍLIA', CAST(N'2022-08-29T08:48:02.3018512' AS DateTime2))
GO
INSERT [dbo].[PizzaFlavorsPrice] ([PizzaFlavorsPriceID], [PizzaFlavorEntityID], [Price], [Size], [Register]) VALUES (6, 6, CAST(45.00 AS Decimal(18, 2)), N'FAMÍLIA', CAST(N'2022-08-29T08:48:09.2512422' AS DateTime2))
GO
INSERT [dbo].[PizzaFlavorsPrice] ([PizzaFlavorsPriceID], [PizzaFlavorEntityID], [Price], [Size], [Register]) VALUES (7, 7, CAST(59.99 AS Decimal(18, 2)), N'FAMÍLIA', CAST(N'2022-08-29T08:48:16.4172373' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[PizzaFlavorsPrice] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Client_Telephone]    Script Date: 29/08/2022 09:43:33 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Client_Telephone] ON [dbo].[Client]
(
	[Telephone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ItemFlavors_OrderItemID]    Script Date: 29/08/2022 09:43:33 ******/
CREATE NONCLUSTERED INDEX [IX_ItemFlavors_OrderItemID] ON [dbo].[ItemFlavors]
(
	[OrderItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ItemFlavors_PizzaFlavorID]    Script Date: 29/08/2022 09:43:33 ******/
CREATE NONCLUSTERED INDEX [IX_ItemFlavors_PizzaFlavorID] ON [dbo].[ItemFlavors]
(
	[PizzaFlavorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Order_ClientID]    Script Date: 29/08/2022 09:43:33 ******/
CREATE NONCLUSTERED INDEX [IX_Order_ClientID] ON [dbo].[Order]
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderItem_OrderID]    Script Date: 29/08/2022 09:43:33 ******/
CREATE NONCLUSTERED INDEX [IX_OrderItem_OrderID] ON [dbo].[OrderItem]
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PizzaFlavorsPrice_PizzaFlavorEntityID]    Script Date: 29/08/2022 09:43:33 ******/
CREATE NONCLUSTERED INDEX [IX_PizzaFlavorsPrice_PizzaFlavorEntityID] ON [dbo].[PizzaFlavorsPrice]
(
	[PizzaFlavorEntityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ItemFlavors]  WITH CHECK ADD  CONSTRAINT [FK_ItemFlavors_OrderItem_OrderItemID] FOREIGN KEY([OrderItemID])
REFERENCES [dbo].[OrderItem] ([OrderItemID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ItemFlavors] CHECK CONSTRAINT [FK_ItemFlavors_OrderItem_OrderItemID]
GO
ALTER TABLE [dbo].[ItemFlavors]  WITH CHECK ADD  CONSTRAINT [FK_ItemFlavors_PizzaFlavor_PizzaFlavorID] FOREIGN KEY([PizzaFlavorID])
REFERENCES [dbo].[PizzaFlavor] ([PizzaFlavorID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ItemFlavors] CHECK CONSTRAINT [FK_ItemFlavors_PizzaFlavor_PizzaFlavorID]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Client_ClientID] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Client_ClientID]
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Order_OrderID] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderItem] CHECK CONSTRAINT [FK_OrderItem_Order_OrderID]
GO
ALTER TABLE [dbo].[PizzaFlavorsPrice]  WITH CHECK ADD  CONSTRAINT [FK_PizzaFlavorsPrice_PizzaFlavor_PizzaFlavorEntityID] FOREIGN KEY([PizzaFlavorEntityID])
REFERENCES [dbo].[PizzaFlavor] ([PizzaFlavorID])
GO
ALTER TABLE [dbo].[PizzaFlavorsPrice] CHECK CONSTRAINT [FK_PizzaFlavorsPrice_PizzaFlavor_PizzaFlavorEntityID]
GO
