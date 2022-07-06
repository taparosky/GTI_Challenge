USE [GTI_DB]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 7/5/2022 9:12:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CPF] [varchar](11) NOT NULL,
	[Nome] [varchar](250) NOT NULL,
	[RG] [varchar](20) NULL,
	[DataExpedicao] [datetime] NULL,
	[OrgaoExpedicao] [varchar](250) NULL,
	[UF] [varchar](2) NULL,
	[DataNascimento] [datetime] NOT NULL,
	[Sexo] [varchar](20) NOT NULL,
	[EstadoCivil] [varchar](30) NOT NULL,
	[CEP] [varchar](8) NOT NULL,
	[Logradouro] [varchar](max) NOT NULL,
	[Numero] [int] NOT NULL,
	[Complemento] [varchar](50) NULL,
	[Bairro] [varchar](50) NOT NULL,
	[Cidade] [varchar](100) NOT NULL,
	[UfEndereco] [varchar](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CPF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


