CREATE TABLE [dbo].[Robot] (
    [Code]        INT           IDENTITY (1, 1) NOT NULL,
    [XPosition]   VARCHAR (30)  NOT NULL,
    [YPosition]   VARCHAR (30)  NOT NULL,
    [HaveTheBall] INT           DEFAULT ((0)) NULL,
    [State]       NVARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([Code] ASC),
);

