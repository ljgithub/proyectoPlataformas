
CREATE DATABASE [bdd_helpdesk]

GO
ALTER DATABASE [bdd_helpdesk] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET ARITHABORT OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [bdd_helpdesk] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bdd_helpdesk] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bdd_helpdesk] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bdd_helpdesk] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bdd_helpdesk] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bdd_helpdesk] SET  MULTI_USER 
GO
ALTER DATABASE [bdd_helpdesk] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bdd_helpdesk] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bdd_helpdesk] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bdd_helpdesk] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [bdd_helpdesk]
GO
/****** Object:  Table [dbo].[detail_process]    Script Date: 14/07/2018 6:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detail_process](
	[id_detproc] [int] NOT NULL,
	[date_detproc] [date] NOT NULL,
	[id_user] [int] NOT NULL,
	[obser_detproc] [varchar](300) NOT NULL,
	[id_pertenece] [int] NOT NULL,
	[state_detproc] [nchar](10) NULL,
	[archive_detproc] [varchar](300) NOT NULL,
	[hora_detproc] [time](7) NOT NULL,
	[datecu_detproc] [timestamp] NOT NULL,
	[id_proyect] [int] NOT NULL,
	[id_proccat] [int] NOT NULL,
	[id_userpro] [int] NOT NULL,
 CONSTRAINT [PK_detail_process] PRIMARY KEY CLUSTERED 
(
	[id_detproc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[form_question]    Script Date: 14/07/2018 6:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[form_question](
	[id_form] [int] NOT NULL,
	[id_question] [int] NOT NULL,
	[if_formquestion] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_form_question_1] PRIMARY KEY CLUSTERED 
(
	[if_formquestion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[formulario]    Script Date: 14/07/2018 6:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formulario](
	[id_form] [int] NOT NULL,
	[date_form] [date] NOT NULL,
	[quantityq_form] [int] NOT NULL,
	[state_form] [int] NOT NULL,
	[generate_form] [int] NOT NULL,
	[approved_form] [int] NOT NULL,
	[id_proyect] [int] NOT NULL,
 CONSTRAINT [PK_formulario] PRIMARY KEY CLUSTERED 
(
	[id_form] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[process_category]    Script Date: 14/07/2018 6:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[process_category](
	[id_proccat] [int] IDENTITY(1,1) NOT NULL,
	[name_proccat] [varchar](50) NOT NULL,
	[desc_proccat] [varchar](100) NOT NULL,
	[state_proccat] [int] NOT NULL,
 CONSTRAINT [PK_process_category] PRIMARY KEY CLUSTERED 
(
	[id_proccat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[proyect]    Script Date: 14/07/2018 6:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[proyect](
	[id_proyect] [int] IDENTITY(1,1) NOT NULL,
	[name_proyect] [int] NOT NULL,
	[datein_proyect] [date] NOT NULL,
	[datemsx_proyect] [date] NOT NULL,
	[estado_proyect] [nchar](10) NULL,
	[presupuesto_proyect] [float] NOT NULL,
	[percent_proyect] [float] NOT NULL,
	[desc_proyect] [varchar](500) NOT NULL,
	[id_tproy] [int] NOT NULL,
	[form_id] [int] NOT NULL,
	[link_proyect] [varchar](400) NOT NULL,
	[objetivo_proyect] [text] NULL,
	[state_proyect] [int] NOT NULL,
	[logo_proyect] [varchar](500) NOT NULL,
	[alcance_proyect] [text] NOT NULL,
 CONSTRAINT [PK_proyect] PRIMARY KEY CLUSTERED 
(
	[id_proyect] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[question]    Script Date: 14/07/2018 6:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[question](
	[id_question] [int] IDENTITY(1,1) NOT NULL,
	[text_question] [varchar](200) NOT NULL,
	[desc_question] [varchar](200) NOT NULL,
	[value_question] [float] NOT NULL,
	[id_tipeques] [int] NOT NULL,
	[id_questionpadre] [int] NOT NULL,
 CONSTRAINT [PK_question] PRIMARY KEY CLUSTERED 
(
	[id_question] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rol]    Script Date: 14/07/2018 6:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rol](
	[id_role] [int] IDENTITY(1,1) NOT NULL,
	[name_role] [varchar](50) NOT NULL,
	[permission_role] [varchar](50) NOT NULL,
	[state_role] [int] NOT NULL,
 CONSTRAINT [pk_role] PRIMARY KEY CLUSTERED 
(
	[id_role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipe_proyect]    Script Date: 14/07/2018 6:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipe_proyect](
	[id_tproy] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tproy] [varchar](100) NOT NULL,
	[estado_tproy] [int] NOT NULL,
	[desc_tproy] [varchar](200) NOT NULL,
 CONSTRAINT [PK_tipe_proyect] PRIMARY KEY CLUSTERED 
(
	[id_tproy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipe_question]    Script Date: 14/07/2018 6:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipe_question](
	[id_tipeques] [int] IDENTITY(1,1) NOT NULL,
	[name_tipeques] [varchar](100) NOT NULL,
	[desc_tipeques] [varchar](200) NOT NULL,
	[state_tipeques] [int] NULL,
 CONSTRAINT [PK_tipe_question] PRIMARY KEY CLUSTERED 
(
	[id_tipeques] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 14/07/2018 6:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[name_user] [varchar](50) NOT NULL,
	[lastname_user] [varchar](50) NOT NULL,
	[email_user] [varchar](100) NOT NULL,
	[pass_user] [varchar](200) NOT NULL,
	[state_user] [int] NOT NULL,
	[empresa_user] [varchar](50) NOT NULL,
	[phone_user] [varchar](50) NOT NULL,
	[phone2_user] [varchar](50) NOT NULL,
	[id_role] [int] NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario_proyect]    Script Date: 14/07/2018 6:25:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario_proyect](
	[id_userpro] [int] IDENTITY(1,1) NOT NULL,
	[id_user] [int] NOT NULL,
	[id_proyect] [int] NOT NULL,
 CONSTRAINT [PK_usuario_proyect] PRIMARY KEY CLUSTERED 
(
	[id_userpro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[usuario] ADD  CONSTRAINT [DF_usuario_pass_user]  DEFAULT ((4321)) FOR [pass_user]
GO
ALTER TABLE [dbo].[detail_process]  WITH CHECK ADD  CONSTRAINT [FK_detail_process_detail_process] FOREIGN KEY([id_pertenece])
REFERENCES [dbo].[detail_process] ([id_detproc])
GO
ALTER TABLE [dbo].[detail_process] CHECK CONSTRAINT [FK_detail_process_detail_process]
GO
ALTER TABLE [dbo].[detail_process]  WITH CHECK ADD  CONSTRAINT [FK_detail_process_process_category] FOREIGN KEY([id_proccat])
REFERENCES [dbo].[process_category] ([id_proccat])
GO
ALTER TABLE [dbo].[detail_process] CHECK CONSTRAINT [FK_detail_process_process_category]
GO
ALTER TABLE [dbo].[detail_process]  WITH CHECK ADD  CONSTRAINT [FK_detail_process_proyect] FOREIGN KEY([id_proyect])
REFERENCES [dbo].[proyect] ([id_proyect])
GO
ALTER TABLE [dbo].[detail_process] CHECK CONSTRAINT [FK_detail_process_proyect]
GO
ALTER TABLE [dbo].[detail_process]  WITH CHECK ADD  CONSTRAINT [FK_detail_process_usuario_proyect] FOREIGN KEY([id_userpro])
REFERENCES [dbo].[usuario_proyect] ([id_userpro])
GO
ALTER TABLE [dbo].[detail_process] CHECK CONSTRAINT [FK_detail_process_usuario_proyect]
GO
ALTER TABLE [dbo].[form_question]  WITH CHECK ADD  CONSTRAINT [FK_form_question_formulario] FOREIGN KEY([id_form])
REFERENCES [dbo].[formulario] ([id_form])
GO
ALTER TABLE [dbo].[form_question] CHECK CONSTRAINT [FK_form_question_formulario]
GO
ALTER TABLE [dbo].[form_question]  WITH CHECK ADD  CONSTRAINT [FK_form_question_question] FOREIGN KEY([id_question])
REFERENCES [dbo].[question] ([id_question])
GO
ALTER TABLE [dbo].[form_question] CHECK CONSTRAINT [FK_form_question_question]
GO
ALTER TABLE [dbo].[formulario]  WITH CHECK ADD  CONSTRAINT [FK_formulario_proyect] FOREIGN KEY([id_proyect])
REFERENCES [dbo].[proyect] ([id_proyect])
GO
ALTER TABLE [dbo].[formulario] CHECK CONSTRAINT [FK_formulario_proyect]
GO
ALTER TABLE [dbo].[proyect]  WITH CHECK ADD  CONSTRAINT [FK_proyect_tipe_proyect] FOREIGN KEY([id_tproy])
REFERENCES [dbo].[tipe_proyect] ([id_tproy])
GO
ALTER TABLE [dbo].[proyect] CHECK CONSTRAINT [FK_proyect_tipe_proyect]
GO
ALTER TABLE [dbo].[question]  WITH CHECK ADD  CONSTRAINT [FK_question_question] FOREIGN KEY([id_questionpadre])
REFERENCES [dbo].[question] ([id_question])
GO
ALTER TABLE [dbo].[question] CHECK CONSTRAINT [FK_question_question]
GO
ALTER TABLE [dbo].[question]  WITH CHECK ADD  CONSTRAINT [FK_question_tipe_question] FOREIGN KEY([id_tipeques])
REFERENCES [dbo].[tipe_question] ([id_tipeques])
GO
ALTER TABLE [dbo].[question] CHECK CONSTRAINT [FK_question_tipe_question]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [fk_rol] FOREIGN KEY([id_role])
REFERENCES [dbo].[rol] ([id_role])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [fk_rol]
GO
ALTER TABLE [dbo].[usuario_proyect]  WITH CHECK ADD  CONSTRAINT [FK_usuario_proyect_proyect] FOREIGN KEY([id_proyect])
REFERENCES [dbo].[proyect] ([id_proyect])
GO
ALTER TABLE [dbo].[usuario_proyect] CHECK CONSTRAINT [FK_usuario_proyect_proyect]
GO
ALTER TABLE [dbo].[usuario_proyect]  WITH CHECK ADD  CONSTRAINT [FK_usuario_proyect_usuario] FOREIGN KEY([id_user])
REFERENCES [dbo].[usuario] ([id_user])
GO
ALTER TABLE [dbo].[usuario_proyect] CHECK CONSTRAINT [FK_usuario_proyect_usuario]
GO
USE [master]
GO
ALTER DATABASE [bdd_helpdesk] SET  READ_WRITE 
GO

use  bdd_helpdesk

select * from rol

insert into rol (name_role, permission_role, state_role )
values ('admin','777','1')

select 'admin','777','1' from rol

insert into rol (id_role,)


INSERT INTO Usuario(name_user,lastname_user,pass_user,state_user,empresa_user,phone_user,phone2_user,id_role, email_user)
VALUES (
'ZULE',
'lema',
'123',
'1',
'Empresa 1',
'1123456',
'1123456',
'1',
'1212sd@gmail.com'
)


select * from usuario 

update usuario set email_user = 'zule@gmail.com' where id_user = '2'

490500510

update usuario set pass_user = 'MQAyADMA' where id_user = '2'







