IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(128) NOT NULL,
        [ProviderKey] nvarchar(128) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(128) NOT NULL,
        [Name] nvarchar(128) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'00000000000000_CreateIdentitySchema', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306070629_AddDatabase')
BEGIN
    CREATE TABLE [Leagues] (
        [Id] int NOT NULL IDENTITY,
        [Country] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_Leagues] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306070629_AddDatabase')
BEGIN
    CREATE TABLE [Servers] (
        [Id] int NOT NULL IDENTITY,
        [Link] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_Servers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306070629_AddDatabase')
BEGIN
    CREATE TABLE [Clubs] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [LeagueId] int NULL,
        CONSTRAINT [PK_Clubs] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Clubs_Leagues_LeagueId] FOREIGN KEY ([LeagueId]) REFERENCES [Leagues] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306070629_AddDatabase')
BEGIN
    CREATE TABLE [Matches] (
        [Id] int NOT NULL IDENTITY,
        [club1Id] int NULL,
        [result1] int NOT NULL,
        [club2Id] int NULL,
        [result2] int NOT NULL,
        [date] datetime2 NOT NULL,
        [leagueId] int NULL,
        CONSTRAINT [PK_Matches] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Matches_Clubs_club1Id] FOREIGN KEY ([club1Id]) REFERENCES [Clubs] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Matches_Clubs_club2Id] FOREIGN KEY ([club2Id]) REFERENCES [Clubs] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Matches_Leagues_leagueId] FOREIGN KEY ([leagueId]) REFERENCES [Leagues] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306070629_AddDatabase')
BEGIN
    CREATE INDEX [IX_Clubs_LeagueId] ON [Clubs] ([LeagueId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306070629_AddDatabase')
BEGIN
    CREATE INDEX [IX_Matches_club1Id] ON [Matches] ([club1Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306070629_AddDatabase')
BEGIN
    CREATE INDEX [IX_Matches_club2Id] ON [Matches] ([club2Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306070629_AddDatabase')
BEGIN
    CREATE INDEX [IX_Matches_leagueId] ON [Matches] ([leagueId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306070629_AddDatabase')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220306070629_AddDatabase', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306070831_UpdateDatabase')
BEGIN
    ALTER TABLE [Servers] ADD [MatchId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306070831_UpdateDatabase')
BEGIN
    CREATE INDEX [IX_Servers_MatchId] ON [Servers] ([MatchId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306070831_UpdateDatabase')
BEGIN
    ALTER TABLE [Servers] ADD CONSTRAINT [FK_Servers_Matches_MatchId] FOREIGN KEY ([MatchId]) REFERENCES [Matches] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306070831_UpdateDatabase')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220306070831_UpdateDatabase', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306073801_UpdateDatabase1')
BEGIN
    ALTER TABLE [Clubs] ADD [Img] varbinary(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306073801_UpdateDatabase1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220306073801_UpdateDatabase1', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080100_UpdateDatabase2')
BEGIN
    ALTER TABLE [Clubs] DROP CONSTRAINT [FK_Clubs_Leagues_LeagueId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080100_UpdateDatabase2')
BEGIN
    ALTER TABLE [Matches] ADD [stadium] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080100_UpdateDatabase2')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Leagues]') AND [c].[name] = N'Name');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Leagues] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Leagues] ALTER COLUMN [Name] nvarchar(max) NOT NULL;
    ALTER TABLE [Leagues] ADD DEFAULT N'' FOR [Name];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080100_UpdateDatabase2')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Leagues]') AND [c].[name] = N'Country');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Leagues] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Leagues] ALTER COLUMN [Country] nvarchar(max) NOT NULL;
    ALTER TABLE [Leagues] ADD DEFAULT N'' FOR [Country];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080100_UpdateDatabase2')
BEGIN
    ALTER TABLE [Leagues] ADD [Img] varbinary(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080100_UpdateDatabase2')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Clubs]') AND [c].[name] = N'Name');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Clubs] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Clubs] ALTER COLUMN [Name] nvarchar(max) NOT NULL;
    ALTER TABLE [Clubs] ADD DEFAULT N'' FOR [Name];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080100_UpdateDatabase2')
BEGIN
    DROP INDEX [IX_Clubs_LeagueId] ON [Clubs];
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Clubs]') AND [c].[name] = N'LeagueId');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Clubs] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Clubs] ALTER COLUMN [LeagueId] int NOT NULL;
    ALTER TABLE [Clubs] ADD DEFAULT 0 FOR [LeagueId];
    CREATE INDEX [IX_Clubs_LeagueId] ON [Clubs] ([LeagueId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080100_UpdateDatabase2')
BEGIN
    ALTER TABLE [Clubs] ADD CONSTRAINT [FK_Clubs_Leagues_LeagueId] FOREIGN KEY ([LeagueId]) REFERENCES [Leagues] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080100_UpdateDatabase2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220306080100_UpdateDatabase2', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080915_UpdateDatabase3')
BEGIN
    ALTER TABLE [Clubs] DROP CONSTRAINT [FK_Clubs_Leagues_LeagueId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080915_UpdateDatabase3')
BEGIN
    DROP INDEX [IX_Clubs_LeagueId] ON [Clubs];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080915_UpdateDatabase3')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Clubs]') AND [c].[name] = N'LeagueId');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Clubs] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Clubs] ALTER COLUMN [LeagueId] nvarchar(max) NOT NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080915_UpdateDatabase3')
BEGIN
    ALTER TABLE [Clubs] ADD [LeagueId1] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080915_UpdateDatabase3')
BEGIN
    CREATE INDEX [IX_Clubs_LeagueId1] ON [Clubs] ([LeagueId1]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080915_UpdateDatabase3')
BEGIN
    ALTER TABLE [Clubs] ADD CONSTRAINT [FK_Clubs_Leagues_LeagueId1] FOREIGN KEY ([LeagueId1]) REFERENCES [Leagues] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306080915_UpdateDatabase3')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220306080915_UpdateDatabase3', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306082526_UpdateDatabase4')
BEGIN
    ALTER TABLE [Clubs] DROP CONSTRAINT [FK_Clubs_Leagues_LeagueId1];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306082526_UpdateDatabase4')
BEGIN
    DROP INDEX [IX_Clubs_LeagueId1] ON [Clubs];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306082526_UpdateDatabase4')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Clubs]') AND [c].[name] = N'LeagueId1');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Clubs] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Clubs] DROP COLUMN [LeagueId1];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306082526_UpdateDatabase4')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Clubs]') AND [c].[name] = N'LeagueId');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Clubs] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Clubs] ALTER COLUMN [LeagueId] int NOT NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306082526_UpdateDatabase4')
BEGIN
    CREATE INDEX [IX_Clubs_LeagueId] ON [Clubs] ([LeagueId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306082526_UpdateDatabase4')
BEGIN
    ALTER TABLE [Clubs] ADD CONSTRAINT [FK_Clubs_Leagues_LeagueId] FOREIGN KEY ([LeagueId]) REFERENCES [Leagues] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220306082526_UpdateDatabase4')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220306082526_UpdateDatabase4', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220309035042_update')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220309035042_update', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220309050856_update1')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Matches]') AND [c].[name] = N'date');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Matches] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Matches] ALTER COLUMN [date] time NOT NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220309050856_update1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220309050856_update1', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310023904_updateServer')
BEGIN
    ALTER TABLE [Servers] DROP CONSTRAINT [FK_Servers_Matches_MatchId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310023904_updateServer')
BEGIN
    DROP INDEX [IX_Servers_MatchId] ON [Servers];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310023904_updateServer')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Servers]') AND [c].[name] = N'Link');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Servers] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [Servers] DROP COLUMN [Link];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310023904_updateServer')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Servers]') AND [c].[name] = N'MatchId');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Servers] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [Servers] DROP COLUMN [MatchId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310023904_updateServer')
BEGIN
    DECLARE @var10 sysname;
    SELECT @var10 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Servers]') AND [c].[name] = N'Name');
    IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Servers] DROP CONSTRAINT [' + @var10 + '];');
    ALTER TABLE [Servers] ALTER COLUMN [Name] nvarchar(max) NOT NULL;
    ALTER TABLE [Servers] ADD DEFAULT N'' FOR [Name];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310023904_updateServer')
BEGIN
    DECLARE @var11 sysname;
    SELECT @var11 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Matches]') AND [c].[name] = N'date');
    IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Matches] DROP CONSTRAINT [' + @var11 + '];');
    ALTER TABLE [Matches] ALTER COLUMN [date] datetime2 NOT NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310023904_updateServer')
BEGIN
    DROP INDEX [IX_Matches_club2Id] ON [Matches];
    DECLARE @var12 sysname;
    SELECT @var12 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Matches]') AND [c].[name] = N'club2Id');
    IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Matches] DROP CONSTRAINT [' + @var12 + '];');
    ALTER TABLE [Matches] ALTER COLUMN [club2Id] int NOT NULL;
    ALTER TABLE [Matches] ADD DEFAULT 0 FOR [club2Id];
    CREATE INDEX [IX_Matches_club2Id] ON [Matches] ([club2Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310023904_updateServer')
BEGIN
    DROP INDEX [IX_Matches_club1Id] ON [Matches];
    DECLARE @var13 sysname;
    SELECT @var13 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Matches]') AND [c].[name] = N'club1Id');
    IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [Matches] DROP CONSTRAINT [' + @var13 + '];');
    ALTER TABLE [Matches] ALTER COLUMN [club1Id] int NOT NULL;
    ALTER TABLE [Matches] ADD DEFAULT 0 FOR [club1Id];
    CREATE INDEX [IX_Matches_club1Id] ON [Matches] ([club1Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310023904_updateServer')
BEGIN
    CREATE TABLE [MatchServerName] (
        [MatchesId] int NOT NULL,
        [serverNamesId] int NOT NULL,
        CONSTRAINT [PK_MatchServerName] PRIMARY KEY ([MatchesId], [serverNamesId]),
        CONSTRAINT [FK_MatchServerName_Matches_MatchesId] FOREIGN KEY ([MatchesId]) REFERENCES [Matches] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_MatchServerName_Servers_serverNamesId] FOREIGN KEY ([serverNamesId]) REFERENCES [Servers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310023904_updateServer')
BEGIN
    CREATE TABLE [ServerLink] (
        [Id] int NOT NULL IDENTITY,
        [Link] nvarchar(max) NOT NULL,
        [ServerNameId] int NULL,
        CONSTRAINT [PK_ServerLink] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ServerLink_Servers_ServerNameId] FOREIGN KEY ([ServerNameId]) REFERENCES [Servers] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310023904_updateServer')
BEGIN
    CREATE INDEX [IX_MatchServerName_serverNamesId] ON [MatchServerName] ([serverNamesId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310023904_updateServer')
BEGIN
    CREATE INDEX [IX_ServerLink_ServerNameId] ON [ServerLink] ([ServerNameId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310023904_updateServer')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220310023904_updateServer', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024106_updateServer1')
BEGIN
    ALTER TABLE [MatchServerName] DROP CONSTRAINT [FK_MatchServerName_Servers_serverNamesId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024106_updateServer1')
BEGIN
    ALTER TABLE [ServerLink] DROP CONSTRAINT [FK_ServerLink_Servers_ServerNameId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024106_updateServer1')
BEGIN
    ALTER TABLE [Servers] DROP CONSTRAINT [PK_Servers];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024106_updateServer1')
BEGIN
    ALTER TABLE [ServerLink] DROP CONSTRAINT [PK_ServerLink];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024106_updateServer1')
BEGIN
    EXEC sp_rename N'[Servers]', N'serverNames';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024106_updateServer1')
BEGIN
    EXEC sp_rename N'[ServerLink]', N'serverLinks';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024106_updateServer1')
BEGIN
    EXEC sp_rename N'[serverLinks].[IX_ServerLink_ServerNameId]', N'IX_serverLinks_ServerNameId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024106_updateServer1')
BEGIN
    ALTER TABLE [serverNames] ADD CONSTRAINT [PK_serverNames] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024106_updateServer1')
BEGIN
    ALTER TABLE [serverLinks] ADD CONSTRAINT [PK_serverLinks] PRIMARY KEY ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024106_updateServer1')
BEGIN
    ALTER TABLE [MatchServerName] ADD CONSTRAINT [FK_MatchServerName_serverNames_serverNamesId] FOREIGN KEY ([serverNamesId]) REFERENCES [serverNames] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024106_updateServer1')
BEGIN
    ALTER TABLE [serverLinks] ADD CONSTRAINT [FK_serverLinks_serverNames_ServerNameId] FOREIGN KEY ([ServerNameId]) REFERENCES [serverNames] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024106_updateServer1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220310024106_updateServer1', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024654_updateServer2')
BEGIN
    ALTER TABLE [serverLinks] DROP CONSTRAINT [FK_serverLinks_serverNames_ServerNameId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024654_updateServer2')
BEGIN
    DROP INDEX [IX_serverLinks_ServerNameId] ON [serverLinks];
    DECLARE @var14 sysname;
    SELECT @var14 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[serverLinks]') AND [c].[name] = N'ServerNameId');
    IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [serverLinks] DROP CONSTRAINT [' + @var14 + '];');
    ALTER TABLE [serverLinks] ALTER COLUMN [ServerNameId] int NOT NULL;
    ALTER TABLE [serverLinks] ADD DEFAULT 0 FOR [ServerNameId];
    CREATE INDEX [IX_serverLinks_ServerNameId] ON [serverLinks] ([ServerNameId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024654_updateServer2')
BEGIN
    ALTER TABLE [serverLinks] ADD CONSTRAINT [FK_serverLinks_serverNames_ServerNameId] FOREIGN KEY ([ServerNameId]) REFERENCES [serverNames] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310024654_updateServer2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220310024654_updateServer2', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310070211_updateserver3')
BEGIN
    ALTER TABLE [Matches] ADD [ServerNameId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220310070211_updateserver3')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220310070211_updateserver3', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311045027_UpdateLeague')
BEGIN
    ALTER TABLE [Matches] DROP CONSTRAINT [FK_Matches_Leagues_leagueId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311045027_UpdateLeague')
BEGIN
    EXEC sp_rename N'[Matches].[leagueId]', N'LeagueId', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311045027_UpdateLeague')
BEGIN
    EXEC sp_rename N'[Matches].[IX_Matches_leagueId]', N'IX_Matches_LeagueId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311045027_UpdateLeague')
BEGIN
    DROP INDEX [IX_Matches_LeagueId] ON [Matches];
    DECLARE @var15 sysname;
    SELECT @var15 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Matches]') AND [c].[name] = N'LeagueId');
    IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [Matches] DROP CONSTRAINT [' + @var15 + '];');
    ALTER TABLE [Matches] ALTER COLUMN [LeagueId] int NOT NULL;
    ALTER TABLE [Matches] ADD DEFAULT 0 FOR [LeagueId];
    CREATE INDEX [IX_Matches_LeagueId] ON [Matches] ([LeagueId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311045027_UpdateLeague')
BEGIN
    ALTER TABLE [Matches] ADD CONSTRAINT [FK_Matches_Leagues_LeagueId] FOREIGN KEY ([LeagueId]) REFERENCES [Leagues] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311045027_UpdateLeague')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220311045027_UpdateLeague', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311063811_updateServerName')
BEGIN
    DROP TABLE [MatchServerName];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311063811_updateServerName')
BEGIN
    ALTER TABLE [Matches] ADD [ServerNameId1] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311063811_updateServerName')
BEGIN
    CREATE INDEX [IX_Matches_ServerNameId] ON [Matches] ([ServerNameId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311063811_updateServerName')
BEGIN
    CREATE INDEX [IX_Matches_ServerNameId1] ON [Matches] ([ServerNameId1]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311063811_updateServerName')
BEGIN
    ALTER TABLE [Matches] ADD CONSTRAINT [FK_Matches_serverLinks_ServerNameId] FOREIGN KEY ([ServerNameId]) REFERENCES [serverLinks] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311063811_updateServerName')
BEGIN
    ALTER TABLE [Matches] ADD CONSTRAINT [FK_Matches_serverNames_ServerNameId1] FOREIGN KEY ([ServerNameId1]) REFERENCES [serverNames] ([Id]) ON DELETE NO ACTION;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311063811_updateServerName')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220311063811_updateServerName', N'5.0.14');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311064151_updateServerName1')
BEGIN
    ALTER TABLE [Matches] DROP CONSTRAINT [FK_Matches_serverLinks_ServerNameId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311064151_updateServerName1')
BEGIN
    ALTER TABLE [Matches] DROP CONSTRAINT [FK_Matches_serverNames_ServerNameId1];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311064151_updateServerName1')
BEGIN
    DROP INDEX [IX_Matches_ServerNameId1] ON [Matches];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311064151_updateServerName1')
BEGIN
    DECLARE @var16 sysname;
    SELECT @var16 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Matches]') AND [c].[name] = N'ServerNameId1');
    IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [Matches] DROP CONSTRAINT [' + @var16 + '];');
    ALTER TABLE [Matches] DROP COLUMN [ServerNameId1];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311064151_updateServerName1')
BEGIN
    ALTER TABLE [Matches] ADD CONSTRAINT [FK_Matches_serverNames_ServerNameId] FOREIGN KEY ([ServerNameId]) REFERENCES [serverNames] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220311064151_updateServerName1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220311064151_updateServerName1', N'5.0.14');
END;
GO

COMMIT;
GO

