using System;
namespace DemoSimpleBlazorUserAndRoleManager.Models
{
    public class Opduser
	{
		public string Loginname { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Passweb { get; set; }
        public string Accessright { get; set; }
        public string Department { get; set; }
        public string Departmentposition { get; set; }
        public string Entryposition { get; set; }
        public string Picture { get; set; }
        public string Startfullscreen { get; set; }
        public string Doctorcode { get; set; }
        public int DrugAccessLevel { get; set; }
        public string Groupname { get; set; }
        public string VisibleMenu { get; set; }
        public string Viewallmenu { get; set; }
        public string LabStaff { get; set; }
        public int HospitalDepartmentId { get; set; }
        public string NhsoUser { get; set; }
        public string NhsoPassword { get; set; }
        public int MaxStation { get; set; }
        public string ShowTip { get; set; }
        public object PasswordExpireDate { get; set; }
        public int PasswordRecheckDate { get; set; }
        public object NewPasswordDate { get; set; }
        public object CheckLabPassword { get; set; }
        public object PcuUser { get; set; }
        public string AccountDisable { get; set; }
        public object RestrictWardAccess { get; set; }
        public object RealStaff { get; set; }
        public object RestrictClinicAccess { get; set; }
        public object NoLabResultDisplay { get; set; }
        public object NoDoctorConsultDisplay { get; set; }
        public object NoAnnounceDisplay { get; set; }
        public int AnnounceReadCount { get; set; }
        public object XrayStaff { get; set; }
        public object HosGuid { get; set; }
        public object LabCheckPassword { get; set; }
        public object Cid { get; set; }
        public object HosGuidExt { get; set; }
        public object AutoLogoutMinute { get; set; }
    }
}