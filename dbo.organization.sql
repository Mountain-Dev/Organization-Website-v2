CREATE TABLE [dbo].[organization] (
    [organization-id]   INT           NOT NULL,
    [organization-name] VARCHAR (100) NOT NULL,
    [organization-description] VARCHAR(200) NOT NULL, 
    [organization-email] VARCHAR(50) NOT NULL, 
    [organization-phone-number] VARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([organization-id] ASC)
);

