using System;
using System.Collections.Generic;

namespace FixedAssetOm.Models
{
    public partial class TblUserprofile
    {
        public int Id { get; set; }
        public string? Userid { get; set; }
        public string? Userpassword { get; set; }
        public string? Fullname { get; set; }
        public string? Deptcode { get; set; }
        public int? RoleId { get; set; }
        public string? Ipaddress { get; set; }
        public string? Loginstatus { get; set; }
        public int? Authoriser { get; set; }
        public string? Branchcode { get; set; }
        public string? StaffStatus { get; set; }
        public string? PostGlAcctno { get; set; }
        public DateTime? PasschangeDate { get; set; }
        public DateTime? NextPasschangeDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? Sscode { get; set; }
        public int? Sessionid { get; set; }
        public string? Computername { get; set; }
        public string? Machaddress { get; set; }
        public int? Lockcount { get; set; }
        public string? ReportLevel { get; set; }
        public string? AuthUserid { get; set; }
        public string? PostUserId { get; set; }
        public string? Email { get; set; }
        public string? Phoneno { get; set; }
        public int? Status { get; set; }
        public string? Authid { get; set; }
        public int? Smsalert { get; set; }
        public int? Emailalert { get; set; }
        public int? Offlinealert { get; set; }
        public string? Authorisedby { get; set; }
        public int? EnforcePwd { get; set; }
        public int? Excemptlock { get; set; }
        public int? Statement { get; set; }
        public int? Remotelogin { get; set; }
        public decimal? Targetamt { get; set; }
        public int? Logincount { get; set; }
        public int? Multilogin { get; set; }
        public int? Sbu { get; set; }
        public int? Reportflag { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? PasswordResetCode { get; set; }
        public bool? IsEmailVerified { get; set; }
        public Guid? ActivationCode { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Othername { get; set; }
    }
}
