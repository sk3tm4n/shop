CREATE TABLE [dbo].[Remains] (
    [RemainID]   INT      IDENTITY (1, 1) NOT NULL,
    [ProductId]  INT      NOT NULL,
    [Quantity]   INT      NOT NULL,
    [CreateDate] DATETIME DEFAULT (getdate()) NOT NULL,
    [UpdateDate] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([RemainID] ASC),
    FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([ProductID])
);

