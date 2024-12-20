-- Seed Customer for CustomerManagement database
INSERT INTO [CustomerManagement].[dbo].[Customer]
([CustomerId], [Name], [Address], [PostalCode], [City], [TelephoneNumber], [EmailAddress])
VALUES
('944db846166847eb88d6cabb75743a37', 'John Doe', '123 Main St', '12345', 'Example City', '555-1234', 'john.doe@example.com');

-- Seed Customer for WorkshopManagement database
INSERT INTO [WorkshopManagement].[dbo].[Customer]
([CustomerId], [Name], [TelephoneNumber])
VALUES
('944db846166847eb88d6cabb75743a37', 'John Doe', '555-1234');

-- Seed Vehicles
INSERT INTO [VehicleManagement].[dbo].[Vehicle]
([LicenseNumber], [Brand], [Type], [OwnerId])
VALUES
('ABC1234', 'Toyota', 'Sedan', '944db846166847eb88d6cabb75743a37'),
('XYZ9876', 'Honda', 'SUV', '944db846166847eb88d6cabb75743a37'),
('DEF4567', 'Ford', 'Truck', '944db846166847eb88d6cabb75743a37');

INSERT INTO [WorkshopManagement].[dbo].[Vehicle]
([LicenseNumber], [Brand], [OwnerId], [Type])
VALUES
('ABC1234', 'Toyota', '944db846166847eb88d6cabb75743a37', 'Sedan'),
('XYZ9876', 'Honda', '944db846166847eb88d6cabb75743a37', 'SUV'),
('DEF4567', 'Ford', '944db846166847eb88d6cabb75743a37', 'Truck');

-- Job IDs table
DECLARE @JobIds TABLE (JobId UNIQUEIDENTIFIER, LicensePlate NVARCHAR(10), MaintenanceDate DATE);

INSERT INTO [WorkshopManagement].[dbo].[MaintenanceJob]
([Id], [ActualEndTime], [ActualStartTime], [CustomerId], [Description], [EndTime], [Notes], [StartTime], [VehicleLicenseNumber], [WorkshopPlanningDate])
OUTPUT INSERTED.Id, INSERTED.VehicleLicenseNumber, INSERTED.ActualStartTime INTO @JobIds(JobId, LicensePlate, MaintenanceDate)
VALUES
(NEWID(), '2023-05-15 14:00:00', '2023-05-15 12:00:00', '944db846166847eb88d6cabb75743a37', 'Oil change and filter replacement', '2023-05-15 15:00:00', 'Performed by John Doe', '2023-05-15 12:00:00', 'ABC1234', '2023-05-14'),
(NEWID(), '2023-06-10 16:00:00', '2023-06-10 14:00:00', '944db846166847eb88d6cabb75743a37', 'Brake pad replacement', '2023-06-10 17:00:00', 'Checked brake fluid', '2023-06-10 14:00:00', 'ABC1234', '2023-06-09'),
(NEWID(), '2023-07-05 11:00:00', '2023-07-05 09:00:00', '944db846166847eb88d6cabb75743a37', 'Tire rotation', '2023-07-05 12:00:00', 'Aligned tires', '2023-07-05 09:00:00', 'ABC1234', '2023-07-04'),
(NEWID(), '2023-08-20 14:00:00', '2023-08-20 12:00:00', '944db846166847eb88d6cabb75743a37', 'Battery replacement', '2023-08-20 15:00:00', 'Checked charging system', '2023-08-20 12:00:00', 'XYZ9876', '2023-08-19'),
(NEWID(), '2023-09-15 16:00:00', '2023-09-15 14:00:00', '944db846166847eb88d6cabb75743a37', 'Engine diagnostic', '2023-09-15 18:00:00', 'Diagnostic complete, minor issues found', '2023-09-15 14:00:00', 'XYZ9876', '2023-09-14'),
(NEWID(), '2023-10-01 10:00:00', '2023-10-01 08:00:00', '944db846166847eb88d6cabb75743a37', 'Transmission fluid change', '2023-10-01 11:00:00', 'No issues found', '2023-10-01 08:00:00', 'XYZ9876', '2023-09-30'),
(NEWID(), '2024-01-10 13:00:00', '2024-01-10 11:00:00', '944db846166847eb88d6cabb75743a37', 'Coolant flush', '2024-01-10 14:00:00', 'Engine temperature optimized', '2024-01-10 11:00:00', 'DEF4567', '2024-01-09'),
(NEWID(), '2024-02-05 09:30:00', '2024-02-05 08:00:00', '944db846166847eb88d6cabb75743a37', 'Replace air filter', '2024-02-05 10:00:00', 'Improved air intake', '2024-02-05 08:00:00', 'DEF4567', '2024-02-04'),
(NEWID(), '2024-03-03 17:00:00', '2024-03-03 15:00:00', '944db846166847eb88d6cabb75743a37', 'Fuel injector cleaning', '2024-03-03 18:00:00', 'Fuel flow improved', '2024-03-03 15:00:00', 'DEF4567', '2024-03-02');

-- Enable IDENTITY_INSERT for the MaintenanceHistory table
SET IDENTITY_INSERT [MaintenanceHistory].[dbo].[MaintenanceHistory] ON;

INSERT INTO [MaintenanceHistory].[dbo].[MaintenanceHistory]
([LicenseNumber], [MaintenanceDate], [Description], [MaintenanceType], [MaintenanceJobId], [IsCompleted], [Id])
SELECT 
    j.LicensePlate,
    j.MaintenanceDate, -- Use the MaintenanceDate from @JobIds
    j.LicensePlate + ' maintenance description', -- Sample description
    CASE j.LicensePlate
        WHEN 'ABC1234' THEN 1
        WHEN 'XYZ9876' THEN 2
        WHEN 'DEF4567' THEN 3
        ELSE NULL END, -- Adjust as needed
    j.JobId, -- MaintenanceJobId from @JobIds table
    0, -- IsCompleted
    ROW_NUMBER() OVER (ORDER BY j.JobId) -- Unique Id for each row in MaintenanceHistory
FROM @JobIds j;

-- Disable IDENTITY_INSERT after insertion
SET IDENTITY_INSERT [MaintenanceHistory].[dbo].[MaintenanceHistory] OFF;

-- Enable IDENTITY_INSERT for the RepairPart table
set IDENTITY_INSERT [MaintenanceHistory].[dbo].[RepairParts] ON;

-- Create a CTE to generate unique IDs using ROW_NUMBER()
WITH RepairPartsCTE AS (
    SELECT
        ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Id,
            Name,
        Quantity,
        Price,
        WarrantyPeriod
    FROM (VALUES
              ('Oil filter', 150, 10.00, 5),
              ('Brake pads', 10, 50.00, 10),
              ('Tire', 120, 100.00, 15),
              ('Battery', 16, 150.00, 20),
              ('Engine diagnostic tool', 12, 500.00, 30),
              ('Transmission fluid', 500, 20.00, 5),
              ('Coolant', 200, 15.00, 5),
              ('Air filter', 40, 10.00, 5),
              ('Fuel injector cleaner', 6, 25.00, 5)
         ) AS Parts(Name, Quantity, Price, WarrantyPeriod)
)

-- Insert data from CTE into RepairPart table
INSERT INTO [MaintenanceHistory].[dbo].[RepairParts]
([Id], [Name], [Quantity], [Price], [WarrantyPeriod])
SELECT
    Id,
    Name,
    Quantity,
    Price,
    WarrantyPeriod
FROM RepairPartsCTE;

set IDENTITY_INSERT [MaintenanceHistory].[dbo].[RepairParts] OFF;
    
-- Enable IDENTITY_INSERT for the UsedParts table
SET IDENTITY_INSERT [MaintenanceHistory].[dbo].[UsedParts] ON;
    
-- Insert sample data into UsedParts table
-- Step 1: Select current MaintenanceHistory IDs
DECLARE @MaintenanceHistoryIds TABLE (Id INT);
INSERT INTO @MaintenanceHistoryIds (Id)
SELECT Id FROM [MaintenanceHistory].[dbo].[MaintenanceHistory];

-- Step 2: Create a CTE to generate sequential IDs and random assignments
WITH RandomUsedParts AS (
    SELECT
        ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Id,
            ABS(CHECKSUM(NEWID())) % 10 + 1 AS UsedQuantity, -- Random quantity between 1 and 10
    ABS(CHECKSUM(NEWID())) % (SELECT COUNT(*) FROM [MaintenanceHistory].[dbo].[RepairParts]) + 1 AS RepairPartId,
    Id AS MaintenanceHistoryId
FROM @MaintenanceHistoryIds
    )

-- Step 3: Insert data from CTE into UsedParts table
INSERT INTO [MaintenanceHistory].[dbo].[UsedParts]
([Id], [UsedQuantity], [RepairPartId], [MaintenanceHistoryId])
SELECT
    Id,
    UsedQuantity,
    RepairPartId,
    MaintenanceHistoryId
FROM RandomUsedParts;

-- Disable IDENTITY_INSERT after insertion
SET IDENTITY_INSERT [MaintenanceHistory].[dbo].[UsedParts] OFF;