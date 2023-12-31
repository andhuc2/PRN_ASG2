USE [master]
GO

CREATE DATABASE [Cinema]
GO

ALTER DATABASE [Cinema] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cinema].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cinema] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Cinema] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Cinema] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Cinema] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Cinema] SET ARITHABORT OFF
GO
ALTER DATABASE [Cinema] SET AUTO_CLOSE ON
GO
ALTER DATABASE [Cinema] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Cinema] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Cinema] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Cinema] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Cinema] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Cinema] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Cinema] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Cinema] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Cinema] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Cinema] SET  ENABLE_BROKER
GO
ALTER DATABASE [Cinema] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Cinema] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Cinema] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Cinema] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Cinema] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Cinema] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Cinema] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Cinema] SET  READ_WRITE
GO
ALTER DATABASE [Cinema] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Cinema] SET  MULTI_USER
GO
ALTER DATABASE [Cinema] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Cinema] SET DB_CHAINING OFF
GO
USE [Cinema]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 08/10/2021 15:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryCode] [nchar](3) NOT NULL,
	[CountryName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CountryCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ABW', N'Aruba')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'AFG', N'Afghanistan')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'AGO', N'Angola')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'AIA', N'Anguilla')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ALB', N'Albania')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'AND', N'Andorra')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ANT', N'Netherlands Antilles')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ARE', N'United Arab Emirates')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ARG', N'Argentina')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ARM', N'Armenia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ASM', N'American Samoa')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ATA', N'Antarctica')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ATG', N'Antigua and Barbuda')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'AUS', N'Australia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'AUT', N'Austria')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'AZE', N'Azerbaijan')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BDI', N'Burundi')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BEL', N'Belgium')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BEN', N'Benin')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BFA', N'Burkina Faso')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BGD', N'Bangladesh')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BGR', N'Bulgaria')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BHR', N'Bahrain')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BHS', N'Bahamas')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BIH', N'Bosnia and Herzegovina')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BLM', N'Saint Barthelemy')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BLR', N'Belarus')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BLZ', N'Belize')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BMU', N'Bermuda')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BOL', N'Bolivia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BRA', N'Brazil')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BRB', N'Barbados')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BRN', N'Brunei')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BTN', N'Bhutan')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'BWA', N'Botswana')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CAF', N'Central African Republic')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CAN', N'Canada')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CCK', N'Cocos (Keeling) Islands')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CHE', N'Switzerland')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CHL', N'Chile')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CHN', N'China')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CIV', N'Ivory Coast')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CMR', N'Cameroon')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'COD', N'Democratic Republic of the Congo')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'COG', N'Republic of the Congo')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'COK', N'Cook Islands')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'COL', N'Colombia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'COM', N'Comoros')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CPV', N'Cape Verde')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CRC', N'Costa Rica')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CUB', N'Cuba')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CXR', N'Christmas Island')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CYM', N'Cayman Islands')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CYP', N'Cyprus')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'CZE', N'Czech Republic')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'DEU', N'Germany')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'DJI', N'Djibouti')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'DMA', N'Dominica')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'DNK', N'Denmark')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'DOM', N'Dominican Republic')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'DZA', N'Algeria')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ECU', N'Ecuador')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'EGY', N'Egypt')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ERI', N'Eritrea')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ESH', N'Western Sahara')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ESP', N'Spain')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'EST', N'Estonia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ETH', N'Ethiopia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'FIN', N'Finland')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'FJI', N'Fiji')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'FLK', N'Falkland Islands')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'FRA', N'France')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'FRO', N'Faroe Islands')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'FSM', N'Micronesia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GAB', N'Gabon')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GBR', N'United Kingdom')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GEO', N'Georgia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GHA', N'Ghana')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GIB', N'Gibraltar')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GIN', N'Guinea')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GMB', N'Gambia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GNB', N'Guinea-Bissau')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GNQ', N'Equatorial Guinea')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GRC', N'Greece')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GRD', N'Grenada')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GRL', N'Greenland')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GTM', N'Guatemala')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GUM', N'Guam')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'GUY', N'Guyana')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'HKG', N'Hong Kong')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'HND', N'Honduras')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'HRV', N'Croatia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'HTI', N'Haiti')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'HUN', N'Hungary')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'IDN', N'Indonesia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'IMN', N'Isle of Man')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'IND', N'India')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'IOT', N'British Indian Ocean Territory')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'IRL', N'Ireland')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'IRN', N'Iran')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'IRQ', N'Iraq')
GO
print 'Processed 100 total records'
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ISR', N'Israel')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ITA', N'Italy')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'JAM', N'Jamaica')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'JEY', N'Jersey')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'JOR', N'Jordan')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'JPN', N'Japan')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'KAZ', N'Kazakhstan')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'KEN', N'Kenya')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'KGZ', N'Kyrgyzstan')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'KHM', N'Cambodia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'KIR', N'Kiribati')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'KNA', N'Saint Kitts and Nevis')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'KOR', N'South Korea')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'KWT', N'Kuwait')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'LAO', N'Laos')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'LBN', N'Lebanon')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'LBR', N'Liberia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'LBY', N'Libya')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'LCA', N'Saint Lucia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'LIE', N'Liechtenstein')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'LKA', N'Sri Lanka')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'LSO', N'Lesotho')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'LTU', N'Lithuania')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'LUX', N'Luxembourg')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'LVA', N'Latvia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MAC', N'Macau')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MAF', N'Saint Martin')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MAR', N'Morocco')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MCO', N'Monaco')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MDA', N'Moldova')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MDG', N'Madagascar')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MDV', N'Maldives')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MEX', N'Mexico')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MHL', N'Marshall Islands')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MKD', N'Macedonia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MLI', N'Mali')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MLT', N'Malta')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MMR', N'Burma (Myanmar)')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MNE', N'Montenegro')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MNG', N'Mongolia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MNP', N'Northern Mariana Islands')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MOZ', N'Mozambique')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MRT', N'Mauritania')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MSR', N'Montserrat')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MUS', N'Mauritius')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MWI', N'Malawi')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MYS', N'Malaysia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'MYT', N'Mayotte')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'NAM', N'Namibia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'NCL', N'New Caledonia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'NER', N'Niger')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'NFK', N'Norfolk Island')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'NGA', N'Nigeria')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'NIC', N'Nicaragua')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'NIU', N'Niue')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'NLD', N'Netherlands')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'NOR', N'Norway')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'NPL', N'Nepal')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'NRU', N'Nauru')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'NZL', N'New Zealand')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'OMN', N'Oman')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'PAK', N'Pakistan')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'PAN', N'Panama')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'PCN', N'Pitcairn Islands')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'PER', N'Peru')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'PHL', N'Philippines')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'PLW', N'Palau')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'PNG', N'Papua New Guinea')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'POL', N'Poland')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'PRI', N'Puerto Rico')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'PRK', N'North Korea')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'PRT', N'Portugal')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'PRY', N'Paraguay')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'PYF', N'French Polynesia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'QAT', N'Qatar')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ROU', N'Romania')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'RUS', N'Russia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'RWA', N'Rwanda')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SAU', N'Saudi Arabia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SDN', N'Sudan')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SEN', N'Senegal')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SGP', N'Singapore')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SHN', N'Saint Helena')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SJM', N'Svalbard')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SLB', N'Solomon Islands')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SLE', N'Sierra Leone')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SLV', N'El Salvador')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SMR', N'San Marino')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SOM', N'Somalia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SPM', N'Saint Pierre and Miquelon')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SRB', N'Serbia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'STP', N'Sao Tome and Principe')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SUR', N'Suriname')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SVK', N'Slovakia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SVN', N'Slovenia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SWE', N'Sweden')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SWZ', N'Swaziland')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SYC', N'Seychelles')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'SYR', N'Syria')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'TCA', N'Turks and Caicos Islands')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'TCD', N'Chad')
GO
print 'Processed 200 total records'
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'TGO', N'Togo')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'THA', N'Thailand')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'TJK', N'Tajikistan')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'TKL', N'Tokelau')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'TKM', N'Turkmenistan')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'TLS', N'Timor-Leste')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'TON', N'Tonga')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'TTO', N'Trinidad and Tobago')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'TUN', N'Tunisia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'TUR', N'Turkey')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'TUV', N'Tuvalu')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'TWN', N'Taiwan')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'TZA', N'Tanzania')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'UGA', N'Uganda')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'UKR', N'Ukraine')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'URY', N'Uruguay')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'USA', N'United States')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'UZB', N'Uzbekistan')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'VAT', N'Holy See (Vatican City)')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'VCT', N'Saint Vincent and the Grenadines')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'VEN', N'Venezuela')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'VGB', N'British Virgin Islands')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'VIR', N'US Virgin Islands')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'VNM', N'Vietnam')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'VUT', N'Vanuatu')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'WLF', N'Wallis and Futuna')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'WSM', N'Samoa')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'YEM', N'Yemen')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ZAF', N'South Africa')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ZMB', N'Zambia')
INSERT [dbo].[Countries] ([CountryCode], [CountryName]) VALUES (N'ZWE', N'Zimbabwe')
/****** Object:  Table [dbo].[Rooms]    Script Date: 08/10/2021 15:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[RoomID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[NumberRows] [int] NULL,
	[NumberCols] [int] NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Rooms] ON
INSERT [dbo].[Rooms] ([RoomID], [Name], [NumberRows], [NumberCols]) VALUES (1, N'Theatre A                                                                                           ', 10, 10)
INSERT [dbo].[Rooms] ([RoomID], [Name], [NumberRows], [NumberCols]) VALUES (2, N'Theatre B                                                                                           ', 10, 15)
INSERT [dbo].[Rooms] ([RoomID], [Name], [NumberRows], [NumberCols]) VALUES (3, N'Theatre C                                                                                           ', 10, 20)
SET IDENTITY_INSERT [dbo].[Rooms] OFF
/****** Object:  Table [dbo].[Genres]    Script Date: 08/10/2021 15:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genres](
	[GenreID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Genres] PRIMARY KEY CLUSTERED 
(
	[GenreID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Genres] ON
INSERT [dbo].[Genres] ([GenreID], [Name]) VALUES (1, N'Action                                            ')
INSERT [dbo].[Genres] ([GenreID], [Name]) VALUES (2, N'Adventure                                         ')
INSERT [dbo].[Genres] ([GenreID], [Name]) VALUES (3, N'Business                                          ')
INSERT [dbo].[Genres] ([GenreID], [Name]) VALUES (4, N'Children''s/Family                                 ')
INSERT [dbo].[Genres] ([GenreID], [Name]) VALUES (5, N'Comedy                                            ')
INSERT [dbo].[Genres] ([GenreID], [Name]) VALUES (6, N'Comedy Drama                                      ')
INSERT [dbo].[Genres] ([GenreID], [Name]) VALUES (7, N'Crime                                             ')
INSERT [dbo].[Genres] ([GenreID], [Name]) VALUES (8, N'Culture & Socienty                                ')
INSERT [dbo].[Genres] ([GenreID], [Name]) VALUES (9, N'Drama                                             ')
INSERT [dbo].[Genres] ([GenreID], [Name]) VALUES (10, N'Education                                         ')
INSERT [dbo].[Genres] ([GenreID], [Name]) VALUES (11, N'Family & Personal Relationship                    ')
INSERT [dbo].[Genres] ([GenreID], [Name]) VALUES (12, N'Helth & Fitness                                   ')
INSERT [dbo].[Genres] ([GenreID], [Name]) VALUES (13, N'Historical Film                                   ')
SET IDENTITY_INSERT [dbo].[Genres] OFF
/****** Object:  Table [dbo].[Films]    Script Date: 08/10/2021 15:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Films](
	[FilmID] [int] IDENTITY(1,1) NOT NULL,
	[GenreID] [int] NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Year] [int] NOT NULL,
	[CountryCode] [nchar](3) NOT NULL,
	[FilmUrl] [nvarchar](150) NULL,
 CONSTRAINT [PK_Films] PRIMARY KEY CLUSTERED 
(
	[FilmID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Films] ON
INSERT [dbo].[Films] ([FilmID], [GenreID], [Title], [Year], [CountryCode], [FilmUrl]) VALUES (1, 1, N'Iron man I                                                                                          ', 2010, N'USA', N'/Images/placeholder.gif')
INSERT [dbo].[Films] ([FilmID], [GenreID], [Title], [Year], [CountryCode], [FilmUrl]) VALUES (2, 1, N'Impossible mission                                                                                  ', 2010, N'USA', N'/Images/placeholder.gif')
INSERT [dbo].[Films] ([FilmID], [GenreID], [Title], [Year], [CountryCode], [FilmUrl]) VALUES (3, 1, N't2', 2010, N'USA', N'/Images/placeholder.gif')
INSERT [dbo].[Films] ([FilmID], [GenreID], [Title], [Year], [CountryCode], [FilmUrl]) VALUES (4, 1, N'God father II                                                                                       ', 2010, N'USA', N'/Images/placeholder.gif')
INSERT [dbo].[Films] ([FilmID], [GenreID], [Title], [Year], [CountryCode], [FilmUrl]) VALUES (7, 3, N'The best enterprise                                                                                 ', 2010, N'USA', N'/Images/placeholder.gif')
INSERT [dbo].[Films] ([FilmID], [GenreID], [Title], [Year], [CountryCode], [FilmUrl]) VALUES (9, 1, N'Hello AS                                                                                            ', 2010, N'USA', N'/Images/placeholder.gif')
INSERT [dbo].[Films] ([FilmID], [GenreID], [Title], [Year], [CountryCode], [FilmUrl]) VALUES (10, 1, N'Huong                                                                                               ', 2010, N'USA', N'/Images/placeholder.gif')
INSERT [dbo].[Films] ([FilmID], [GenreID], [Title], [Year], [CountryCode], [FilmUrl]) VALUES (11, 1, N'Hello AS                                                                                            ', 2010, N'USA', N'/Images/placeholder.gif')
INSERT [dbo].[Films] ([FilmID], [GenreID], [Title], [Year], [CountryCode], [FilmUrl]) VALUES (12, 1, N'gh                                                                                                  ', 2010, N'ESP', N'/Images/placeholder.gif')
INSERT [dbo].[Films] ([FilmID], [GenreID], [Title], [Year], [CountryCode], [FilmUrl]) VALUES (15, 1, N'Hello                                                                                               ', 2010, N'ESP', N'/Images/placeholder.gif')
INSERT [dbo].[Films] ([FilmID], [GenreID], [Title], [Year], [CountryCode], [FilmUrl]) VALUES (17, 1, N'Hello anh                                                                                           ', 2010, N'ESP', N'/Images/placeholder.gif')
INSERT [dbo].[Films] ([FilmID], [GenreID], [Title], [Year], [CountryCode], [FilmUrl]) VALUES (42, 1, N'NEW', 2017, N'ABW', N'/images/d6740852-ce95-47b2-a9e0-38a50d6e4605.jpg')
SET IDENTITY_INSERT [dbo].[Films] OFF
/****** Object:  Table [dbo].[Shows]    Script Date: 08/10/2021 15:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shows](
	[ShowID] [int] IDENTITY(1,1) NOT NULL,
	[RoomID] [int] NOT NULL,
	[FilmID] [int] NOT NULL,
	[ShowDate] [date] NULL,
	[Price] [money] NULL,
	[Status] [bit] NULL,
	[Slot] [int] NULL,
 CONSTRAINT [PK_Shows] PRIMARY KEY CLUSTERED 
(
	[ShowID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Shows] ON
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (55, 1, 1, CAST(0x07390B00 AS Date), 7.0000, 0, 1)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (56, 1, 1, CAST(0x07390B00 AS Date), 6.0000, 0, 2)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (57, 1, 1, CAST(0x07390B00 AS Date), 5.0000, 0, 3)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (58, 1, 1, CAST(0x06390B00 AS Date), 9.0000, 0, 1)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (59, 1, 1, CAST(0x06390B00 AS Date), 10.0000, 0, 2)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (60, 1, 1, CAST(0x0A410B00 AS Date), 10.0000, 0, 4)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (61, 1, 3, CAST(0x0A410B00 AS Date), 20.0000, 0, 2)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (62, 1, 4, CAST(0x0A410B00 AS Date), 20.0000, 0, 7)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (63, 1, 1, CAST(0x0A410B00 AS Date), 10.0000, 0, 9)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (64, 1, 3, CAST(0x0A410B00 AS Date), 10.0000, 0, 1)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (65, 1, 1, CAST(0x0A410B00 AS Date), 10.0000, 1, 3)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (69, 2, 1, CAST(0x0A410B00 AS Date), 10.0000, 1, 1)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (70, 1, 1, CAST(0x3E410B00 AS Date), 10.0000, 0, 1)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (73, 1, 1, CAST(0x3E410B00 AS Date), 10.0000, 1, 8)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (77, 2, 1, CAST(0x0A410B00 AS Date), 10.0000, 1, 3)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (102, 1, 1, CAST(0xBE410B00 AS Date), 10.0000, 0, 1)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (103, 1, 1, CAST(0xCC410B00 AS Date), 10.0000, 0, 1)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (104, 1, 1, CAST(0x57420B00 AS Date), 10.0000, 0, 1)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (108, 1, 1, CAST(0xD9420B00 AS Date), 100.0000, NULL, 2)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (109, 1, 1, CAST(0xD9420B00 AS Date), 100.0000, NULL, 4)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (110, 1, 1, CAST(0xD9420B00 AS Date), 100.0000, NULL, 3)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (111, 1, 1, CAST(0xD9420B00 AS Date), 100.0000, NULL, 1)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (112, 1, 1, CAST(0xD9420B00 AS Date), 100.0000, NULL, 5)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (132, 1, 1, CAST(0xD9420B00 AS Date), 100.0000, NULL, 6)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (133, 1, 1, CAST(0xD9420B00 AS Date), 10.0000, NULL, 7)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (134, 1, 1, CAST(0xD9420B00 AS Date), 10.0000, NULL, 8)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (135, 1, 1, CAST(0xD9420B00 AS Date), 10.0000, NULL, 9)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (136, 1, 1, CAST(0xDB420B00 AS Date), 100.0000, NULL, 9)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (137, 1, 1, CAST(0xDB420B00 AS Date), 10.0000, NULL, 2)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (138, 1, 1, CAST(0xDB420B00 AS Date), 10.0000, NULL, 3)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (139, 1, 1, CAST(0xDB420B00 AS Date), 10.0000, NULL, 4)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (140, 1, 1, CAST(0xDB420B00 AS Date), 10.0000, NULL, 5)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (141, 1, 1, CAST(0xDB420B00 AS Date), 10.0000, NULL, 6)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (142, 1, 1, CAST(0xDB420B00 AS Date), 10.0000, NULL, 7)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (143, 1, 1, CAST(0xDB420B00 AS Date), 10.0000, NULL, 8)
INSERT [dbo].[Shows] ([ShowID], [RoomID], [FilmID], [ShowDate], [Price], [Status], [Slot]) VALUES (147, 1, 1, CAST(0xDB420B00 AS Date), 100.0000, NULL, 1)
SET IDENTITY_INSERT [dbo].[Shows] OFF
/****** Object:  Table [dbo].[Bookings]    Script Date: 08/10/2021 15:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bookings](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[ShowID] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[SeatStatus] [nchar](1000) NULL,
	[Amount] [money] NULL,
 CONSTRAINT [PK_Bookings] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bookings] ON
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (156, 57, N'Lien                                                                                                ', N'0011000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 10.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (157, 57, N'Lam                                                                                                 ', N'1100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 10.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (158, 59, N'Lan                                                                                                 ', N'0000011000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 20.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (159, 59, N'Kien                                                                                                ', N'0011100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 30.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (160, 59, N'Minh                                                                                                ', N'0100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 10.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (161, 59, N'Huong                                                                                               ', N'1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 10.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (162, 57, N'Mai                                                                                                 ', N'0000110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 10.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (163, 60, N'huong', N'1110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 30.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (169, 63, N'lan', N'1110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 30.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (170, 65, N'k', N'1110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 30.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (184, 73, N'Minh', N'111                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     ', 30.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (187, 73, N'Lan', N'0000000000000000000111000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 30.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (195, 70, N'Lan', N'0000000000000000000011110000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 40.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (203, 69, N'Quang ', N'0000001111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 40.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (204, 70, N'Quang ', N'1111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 40.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (209, 69, N'Quang ', N'1110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 30.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (213, 60, N'Quang ', N'0000001111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 40.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (215, 102, N'huonh', N'1110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 30.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (216, 102, N'lan', N'3330000000000000000011100000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 30.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (217, 103, N'Quang ', N'1111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 40.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (218, 103, N' Lan', N'3333000000000000000011110000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 40.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (219, 104, N'Kien', N'1111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 40.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (220, 104, N'Mai', N'3333000000000000000000000001110000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 30.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (222, 108, N'huong', N'111000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   ', 10.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (223, 108, N'huong', N'000111000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ', 10.0000)
INSERT [dbo].[Bookings] ([BookingID], [ShowID], [Name], [SeatStatus], [Amount]) VALUES (226, 108, N'Mai', N'0000000000000000000011110000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ', 400.0000)
SET IDENTITY_INSERT [dbo].[Bookings] OFF
/****** Object:  ForeignKey [FK_Films_Countries]    Script Date: 08/10/2021 15:32:26 ******/
ALTER TABLE [dbo].[Films]  WITH CHECK ADD  CONSTRAINT [FK_Films_Countries] FOREIGN KEY([CountryCode])
REFERENCES [dbo].[Countries] ([CountryCode])
GO
ALTER TABLE [dbo].[Films] CHECK CONSTRAINT [FK_Films_Countries]
GO
/****** Object:  ForeignKey [FK_Films_Genres]    Script Date: 08/10/2021 15:32:26 ******/
ALTER TABLE [dbo].[Films]  WITH CHECK ADD  CONSTRAINT [FK_Films_Genres] FOREIGN KEY([GenreID])
REFERENCES [dbo].[Genres] ([GenreID])
GO
ALTER TABLE [dbo].[Films] CHECK CONSTRAINT [FK_Films_Genres]
GO
/****** Object:  ForeignKey [FK_Shows_Films]    Script Date: 08/10/2021 15:32:26 ******/
ALTER TABLE [dbo].[Shows]  WITH CHECK ADD  CONSTRAINT [FK_Shows_Films] FOREIGN KEY([FilmID])
REFERENCES [dbo].[Films] ([FilmID])
GO
ALTER TABLE [dbo].[Shows] CHECK CONSTRAINT [FK_Shows_Films]
GO
/****** Object:  ForeignKey [FK_Shows_Rooms]    Script Date: 08/10/2021 15:32:26 ******/
ALTER TABLE [dbo].[Shows]  WITH CHECK ADD  CONSTRAINT [FK_Shows_Rooms] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Rooms] ([RoomID])
GO
ALTER TABLE [dbo].[Shows] CHECK CONSTRAINT [FK_Shows_Rooms]
GO
/****** Object:  ForeignKey [FK_Bookings_Shows]    Script Date: 08/10/2021 15:32:26 ******/
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_Shows] FOREIGN KEY([ShowID])
REFERENCES [dbo].[Shows] ([ShowID])
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_Shows]
GO
