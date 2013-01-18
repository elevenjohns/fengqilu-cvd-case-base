
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/26/2012 20:49:33
-- Generated from EDMX file: C:\YuQuan\FengQiLu\Models\CVD.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FengQiLu];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CVD]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CVD];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CVD'
CREATE TABLE [dbo].[CVD] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Instance_ID] int  NULL,
    [Patient_ID] nvarchar(max)  NULL,
    [Patient_Name] nvarchar(255)  NULL,
    [Patient_Gender] nvarchar(255)  NULL,
    [Patient_Birthday] datetime  NULL,
    [ExactAge] int  NULL,
    [Patient_Tel] nvarchar(max)  NULL,
    [Admission] datetime  NULL,
    [Discharge] datetime  NULL,
    [Diagnosis] nvarchar(max)  NOT NULL,
    [Complications_Diabetes] bit  NULL,
    [Complications_Hypertension] bit  NULL,
    [Complications_Hyperlipidemia] bit  NULL,
    [Complications_CI] bit  NULL,
    [Complications_CRI] bit  NULL,
    [Complications_PAD] bit  NULL,
    [StrokeExperience] bit  NULL,
    [OMI] bit  NULL,
    [FamilyHistoryFlag] bit  NULL,
    [Scenario_Smooking] bit  NULL,
    [Scenario_Anthropometrics_BodyHeight] float  NULL,
    [Scenario_Anthropometrics_BodyWeight] float  NULL,
    [Scenario_Anthropometrics_BMI] float  NULL,
    [Scenario_PhysiologicalParameters_HR] float  NULL,
    [Scenario_PhysiologicalParameters_BpSys] float  NULL,
    [Scenario_PhysiologicalParameters_BpDia] float  NULL,
    [Medication_Aspirin] bit  NULL,
    [Medication_Clopidogrel] bit  NULL,
    [Medication_TirofibanHydrochloride] bit  NULL,
    [Medication_Statins] bit  NULL,
    [Medication_Prolol] bit  NULL,
    [Medication_ACEIARB] bit  NULL,
    [PCI_SurgeryDay] datetime  NULL,
    [PCI_Emergency_PCI] bit  NULL,
    [PCI_CA_LAD_StenosisLevel] int  NULL,
    [PCI_CA_LAD_StenosisSegmentsRaw] int  NULL,
    [PCI_CA_DIAG_StenosisLevel] int  NULL,
    [PCI_CA_LCX_StenosisLevel] int  NULL,
    [PCI_CA_LCX_StenosisSegmentsRaw] int  NULL,
    [PCI_CA_OM_StenosisLevel] int  NULL,
    [PCI_CA_RCA_StenosisLevel] int  NULL,
    [PCI_CA_RCA_StenosisSegmentsRaw] int  NULL,
    [PCI_CA_LM_StenosisLevel] int  NULL,
    [PCI_CA_RenalArtery_StenosisLevel] int  NULL,
    [PCI_CA_LAD_PCI] int  NULL,
    [PCI_CA_DIAG_PCI] int  NULL,
    [PCI_CA_LCX_PCI] int  NULL,
    [PCI_CA_RCA_PCI] int  NULL,
    [PCI_CA_LM_PCI] int  NULL,
    [Scenario_Test_TC] float  NULL,
    [Scenario_Test_TG] float  NULL,
    [Scenario_Test_LDL] float  NULL,
    [Scenario_Test_HDL] float  NULL,
    [Scenario_Test_APOA1] float  NULL,
    [Scenario_Test_APOB] float  NULL,
    [Scenario_Test_a] float  NULL,
    [Scenario_Test_CRE] float  NULL,
    [Scenario_Test_BUN] float  NULL,
    [Scenario_Test_FBG] float  NULL,
    [Scenario_Test_CK] float  NULL,
    [Scenario_Test_CK_MB] float  NULL,
    [Scenario_Test_TNT] float  NULL,
    [Scenario_Test_HCY] float  NULL,
    [Scenario_Test_CYC] float  NULL,
    [Scenario_Test_UA] float  NULL,
    [Scenario_Test_BNP] float  NULL,
    [Scenario_Test_HGB] float  NULL,
    [Scenario_Test_WBC] float  NULL,
    [Scenario_Test_Neutrophil] float  NULL,
    [Scenario_Test_D_Dimer] float  NULL,
    [Scenario_Test_CRP] float  NULL,
    [Scenario_Test_IL_6] float  NULL,
    [Scenario_Test_CRE_48h] float  NULL,
    [Scenario_Test_BUN_48h] float  NULL,
    [Scenario_Echo_EF] float  NULL,
    [Scenario_Echo_LVDs] float  NULL,
    [Scenario_Echo_LVDd] float  NULL,
    [Scenario_Echo_IVS] float  NULL,
    [Scenario_Echo_LVPW] float  NULL,
    [Scenario_Echo_LAD] float  NULL,
    [Scenario_CarotidUS] nvarchar(max)  NULL,
    [Scenario_RenalArteryUS] nvarchar(max)  NULL,
    [FollowUp_Death] nvarchar(max)  NULL,
    [FollowUp_MI] nvarchar(max)  NULL,
    [FollowUp_Revascularization] nvarchar(max)  NULL,
    [FollowUp_HF] nvarchar(max)  NULL,
    [FollowUp_Readmission] nvarchar(max)  NULL,
    [FollowUp_FollowUpLabSheet] nvarchar(max)  NULL,
    [FollowUp_CardiacEvent] nvarchar(max)  NULL,
    [Scenario_Test_AST] float  NULL,
    [Scenario_Test_LDH] float  NULL,
    [Scenario_Test_LD1] float  NULL,
    [Scenario_Test_Mg] float  NULL,
    [Scenario_Test_PPBS] float  NULL,
    [Scenario_Echo_AOD] float  NULL,
    [Scenario_Echo_LVEF] float  NULL,
    [Scenario_Echo_IVSd] float  NULL,
    [Scenario_Echo_LVM] float  NULL,
    [Scenario_Echo_LVMI] float  NULL,
    [Scenario_Echo_RVDd] float  NULL,
    [Scenario_Echo_FS] float  NULL,
    [Scenario_Echo_RWT] float  NULL,
    [Scenario_Echo_PWDd] float  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'CVD'
ALTER TABLE [dbo].[CVD]
ADD CONSTRAINT [PK_CVD]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------