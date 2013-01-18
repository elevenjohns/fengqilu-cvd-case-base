//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace FengQiLu.Models
{
    public partial class CVD
    {
        public int ID { get; set; }
        public Nullable<int> Instance_ID { get; set; }
        public string Patient_ID { get; set; }
        public string Patient_Name { get; set; }
        public string Patient_Gender { get; set; }
        public Nullable<System.DateTime> Patient_Birthday { get; set; }
        public Nullable<int> ExactAge { get; set; }
        public string Patient_Tel { get; set; }
        public Nullable<System.DateTime> Admission { get; set; }
        public Nullable<System.DateTime> Discharge { get; set; }
        public string Diagnosis { get; set; }
        public Nullable<bool> Complications_Diabetes { get; set; }
        public Nullable<bool> Complications_Hypertension { get; set; }
        public Nullable<bool> Complications_Hyperlipidemia { get; set; }
        public Nullable<bool> Complications_CI { get; set; }
        public Nullable<bool> Complications_CRI { get; set; }
        public Nullable<bool> Complications_PAD { get; set; }
        public Nullable<bool> StrokeExperience { get; set; }
        public Nullable<bool> OMI { get; set; }
        public Nullable<bool> FamilyHistoryFlag { get; set; }
        public Nullable<bool> Scenario_Smooking { get; set; }
        public Nullable<double> Scenario_Anthropometrics_BodyHeight { get; set; }
        public Nullable<double> Scenario_Anthropometrics_BodyWeight { get; set; }
        public Nullable<double> Scenario_Anthropometrics_BMI { get; set; }
        public Nullable<double> Scenario_PhysiologicalParameters_HR { get; set; }
        public Nullable<double> Scenario_PhysiologicalParameters_BpSys { get; set; }
        public Nullable<double> Scenario_PhysiologicalParameters_BpDia { get; set; }
        public Nullable<bool> Medication_Aspirin { get; set; }
        public Nullable<bool> Medication_Clopidogrel { get; set; }
        public Nullable<bool> Medication_TirofibanHydrochloride { get; set; }
        public Nullable<bool> Medication_Statins { get; set; }
        public Nullable<bool> Medication_Prolol { get; set; }
        public Nullable<bool> Medication_ACEIARB { get; set; }
        public Nullable<System.DateTime> PCI_SurgeryDay { get; set; }
        public Nullable<bool> PCI_Emergency_PCI { get; set; }
        public Nullable<int> PCI_CA_LAD_StenosisLevel { get; set; }
        public Nullable<int> PCI_CA_LAD_StenosisSegmentsRaw { get; set; }
        public Nullable<int> PCI_CA_DIAG_StenosisLevel { get; set; }
        public Nullable<int> PCI_CA_LCX_StenosisLevel { get; set; }
        public Nullable<int> PCI_CA_LCX_StenosisSegmentsRaw { get; set; }
        public Nullable<int> PCI_CA_OM_StenosisLevel { get; set; }
        public Nullable<int> PCI_CA_RCA_StenosisLevel { get; set; }
        public Nullable<int> PCI_CA_RCA_StenosisSegmentsRaw { get; set; }
        public Nullable<int> PCI_CA_LM_StenosisLevel { get; set; }
        public Nullable<int> PCI_CA_RenalArtery_StenosisLevel { get; set; }
        public Nullable<int> PCI_CA_LAD_PCI { get; set; }
        public Nullable<int> PCI_CA_DIAG_PCI { get; set; }
        public Nullable<int> PCI_CA_LCX_PCI { get; set; }
        public Nullable<int> PCI_CA_RCA_PCI { get; set; }
        public Nullable<int> PCI_CA_LM_PCI { get; set; }
        public Nullable<double> Scenario_Test_TC { get; set; }
        public Nullable<double> Scenario_Test_TG { get; set; }
        public Nullable<double> Scenario_Test_LDL { get; set; }
        public Nullable<double> Scenario_Test_HDL { get; set; }
        public Nullable<double> Scenario_Test_APOA1 { get; set; }
        public Nullable<double> Scenario_Test_APOB { get; set; }
        public Nullable<double> Scenario_Test_a { get; set; }
        public Nullable<double> Scenario_Test_CRE { get; set; }
        public Nullable<double> Scenario_Test_BUN { get; set; }
        public Nullable<double> Scenario_Test_FBG { get; set; }
        public Nullable<double> Scenario_Test_CK { get; set; }
        public Nullable<double> Scenario_Test_CK_MB { get; set; }
        public Nullable<double> Scenario_Test_TNT { get; set; }
        public Nullable<double> Scenario_Test_HCY { get; set; }
        public Nullable<double> Scenario_Test_CYC { get; set; }
        public Nullable<double> Scenario_Test_UA { get; set; }
        public Nullable<double> Scenario_Test_BNP { get; set; }
        public Nullable<double> Scenario_Test_HGB { get; set; }
        public Nullable<double> Scenario_Test_WBC { get; set; }
        public Nullable<double> Scenario_Test_Neutrophil { get; set; }
        public Nullable<double> Scenario_Test_D_Dimer { get; set; }
        public Nullable<double> Scenario_Test_CRP { get; set; }
        public Nullable<double> Scenario_Test_IL_6 { get; set; }
        public Nullable<double> Scenario_Test_CRE_48h { get; set; }
        public Nullable<double> Scenario_Test_BUN_48h { get; set; }
        public Nullable<double> Scenario_Echo_EF { get; set; }
        public Nullable<double> Scenario_Echo_LVDs { get; set; }
        public Nullable<double> Scenario_Echo_LVDd { get; set; }
        public Nullable<double> Scenario_Echo_IVS { get; set; }
        public Nullable<double> Scenario_Echo_LVPW { get; set; }
        public Nullable<double> Scenario_Echo_LAD { get; set; }
        public string Scenario_CarotidUS { get; set; }
        public string Scenario_RenalArteryUS { get; set; }
        public string FollowUp_Death { get; set; }
        public string FollowUp_MI { get; set; }
        public string FollowUp_Revascularization { get; set; }
        public string FollowUp_HF { get; set; }
        public string FollowUp_Readmission { get; set; }
        public string FollowUp_FollowUpLabSheet { get; set; }
        public string FollowUp_CardiacEvent { get; set; }
        public Nullable<double> Scenario_Test_AST { get; set; }
        public Nullable<double> Scenario_Test_LDH { get; set; }
        public Nullable<double> Scenario_Test_LD1 { get; set; }
        public Nullable<double> Scenario_Test_Mg { get; set; }
        public Nullable<double> Scenario_Test_PPBS { get; set; }
        public Nullable<double> Scenario_Echo_AOD { get; set; }
        public Nullable<double> Scenario_Echo_LVEF { get; set; }
        public Nullable<double> Scenario_Echo_IVSd { get; set; }
        public Nullable<double> Scenario_Echo_LVM { get; set; }
        public Nullable<double> Scenario_Echo_LVMI { get; set; }
        public Nullable<double> Scenario_Echo_RVDd { get; set; }
        public Nullable<double> Scenario_Echo_FS { get; set; }
        public Nullable<double> Scenario_Echo_RWT { get; set; }
        public Nullable<double> Scenario_Echo_PWDd { get; set; }
    }
    
}