CREATE TABLE [dbo].[Match] (
    [Id]            INT        IDENTITY (1, 1) NOT NULL,
    [IdTeamA]       INT        NOT NULL,
    [IdTeamB]       INT        NOT NULL,
    [IdFootPitch]   INT        NULL,
    [MatchDateTime] DATETIME   NULL,
    [NbGoalsTeamA]  INT        NULL,
    [NbGoalsTeamB]  INT        NULL,
    [State]         NCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Match_ToFootPitch] FOREIGN KEY ([IdFootPitch]) REFERENCES [dbo].[FootPitch] ([id]),
    CONSTRAINT [FK_Match_ToTeamA] FOREIGN KEY ([IdTeamA]) REFERENCES [dbo].[Team] ([Id]),
    CONSTRAINT [FK_Match_ToTeamB] FOREIGN KEY ([IdTeamB]) REFERENCES [dbo].[Team] ([Id])
);

