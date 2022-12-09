using System;
using System.Collections.Generic;

namespace FixedAssetOm.Models
{
    public partial class TblRole
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string? Roledesc { get; set; }
        public int? AccessDays { get; set; }
        public DateTime? Createdate { get; set; }
        public int? Isoperation { get; set; }
        public int? ReqLimit { get; set; }
        public int? Status { get; set; }
        public string? Authid { get; set; }
        public string? Userid { get; set; }
        public int? Canauth { get; set; }
        public int? RoleLevel { get; set; }
        public bool? Commitee { get; set; }
    }
}
