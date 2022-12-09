using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FixedAssetOm.Models;

namespace FixedAssetOm.Context
{
    public partial class FixedAssetContext : DbContext
    {
        public FixedAssetContext()
        {
        }

        public FixedAssetContext(DbContextOptions<FixedAssetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAmortise> TblAmortises { get; set; } = null!;
        public virtual DbSet<TblBankgl> TblBankgls { get; set; } = null!;
        public virtual DbSet<TblBranch> TblBranches { get; set; } = null!;
        public virtual DbSet<TblDepSchedule> TblDepSchedules { get; set; } = null!;
        public virtual DbSet<TblDepartment> TblDepartments { get; set; } = null!;
        public virtual DbSet<TblFaancilaryAmortSchedule> TblFaancilaryAmortSchedules { get; set; } = null!;
        public virtual DbSet<TblFaancilaryClass> TblFaancilaryClasses { get; set; } = null!;
        public virtual DbSet<TblFaancilaryCost> TblFaancilaryCosts { get; set; } = null!;
        public virtual DbSet<TblFaancilaryCostTran> TblFaancilaryCostTrans { get; set; } = null!;
        public virtual DbSet<TblFacategory> TblFacategories { get; set; } = null!;
        public virtual DbSet<TblFaclass> TblFaclasses { get; set; } = null!;
        public virtual DbSet<TblFacostAmortization> TblFacostAmortizations { get; set; } = null!;
        public virtual DbSet<TblFadepSchedule> TblFadepSchedules { get; set; } = null!;
        public virtual DbSet<TblFalocation> TblFalocations { get; set; } = null!;
        public virtual DbSet<TblFamaintenaceHist> TblFamaintenaceHists { get; set; } = null!;
        public virtual DbSet<TblFarecuringAmortSchedule> TblFarecuringAmortSchedules { get; set; } = null!;
        public virtual DbSet<TblFarecurringClass> TblFarecurringClasses { get; set; } = null!;
        public virtual DbSet<TblFarecurringCost> TblFarecurringCosts { get; set; } = null!;
        public virtual DbSet<TblFarecurringgCostTran> TblFarecurringgCostTrans { get; set; } = null!;
        public virtual DbSet<TblFarevaluation> TblFarevaluations { get; set; } = null!;
        public virtual DbSet<TblFaschMaintRecord> TblFaschMaintRecords { get; set; } = null!;
        public virtual DbSet<TblFawriteOff> TblFawriteOffs { get; set; } = null!;
        public virtual DbSet<TblFixedAsset> TblFixedAssets { get; set; } = null!;
        public virtual DbSet<TblRole> TblRoles { get; set; } = null!;
        public virtual DbSet<TblTransaction> TblTransactions { get; set; } = null!;
        public virtual DbSet<TblUserprofile> TblUserprofiles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-LKKLGQJ;Initial Catalog=FixedAsset;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAmortise>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_amortise");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Transtype)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("transtype");
            });

            modelBuilder.Entity<TblBankgl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bankgl");

                entity.Property(e => e.AcctName)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Authid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("authid")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Bbf)
                    .HasColumnType("decimal(22, 2)")
                    .HasColumnName("BBF");

                entity.Property(e => e.Bkbalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BKBalance");

                entity.Property(e => e.Blocked)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Closed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Currmondiff)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("currmondiff");

                entity.Property(e => e.DateOpened).HasColumnType("datetime");

                entity.Property(e => e.DtLstMonth)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_Lst_Month");

                entity.Property(e => e.GlClassCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Gl_ClassCode")
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Glnumber)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("GLNumber")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.LastEom1)
                    .HasColumnType("datetime")
                    .HasColumnName("last_eom1");

                entity.Property(e => e.LastEom2)
                    .HasColumnType("datetime")
                    .HasColumnName("last_eom2");

                entity.Property(e => e.LastMonthBalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Last_Month_Balance");

                entity.Property(e => e.LastMonthBalance1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("last_month_balance1");

                entity.Property(e => e.LastMonthBalance2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("last_month_balance2");

                entity.Property(e => e.LastNightBalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Last_Night_Balance");

                entity.Property(e => e.LastNightBalance2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("last_night_balance2");

                entity.Property(e => e.Lastmondiff)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lastmondiff");

                entity.Property(e => e.OldGlno)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("oldGLno")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Populate).HasColumnName("populate");

                entity.Property(e => e.Post).HasColumnName("post");

                entity.Property(e => e.ProdType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.ReconLen).HasColumnName("reconLen");

                entity.Property(e => e.TpostCredit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TpostDebit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TypeP)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("typeP")
                    .IsFixedLength()
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userid")
                    .UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<TblBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Branch");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("address2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Authid)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("authid");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cashaccount)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("cashaccount");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_dt");

                entity.Property(e => e.Createdate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("fax");

                entity.Property(e => e.InterBranchGl)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("InterBranchGL");

                entity.Property(e => e.MbranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MBranchCode");

                entity.Property(e => e.Phone)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("region");

                entity.Property(e => e.SbranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SBranchCode");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Subbranch).HasColumnName("subbranch");

                entity.Property(e => e.SuspenseCr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("suspenseCR");

                entity.Property(e => e.SuspenseDr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("suspenseDR");

                entity.Property(e => e.Userid)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDepSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_DepSchedule");

                entity.Property(e => e.AssetCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyDep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.YearlyDep).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Department");

                entity.Property(e => e.Authid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("authid");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptShortname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Deptid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<TblFaancilaryAmortSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FAAncilaryAmortSchedule");

                entity.Property(e => e.CostCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Facode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FACode");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MonthlyRunRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NextAmortDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<TblFaancilaryClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FAAncilaryClass");

                entity.Property(e => e.AuthId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthID");

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CostCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblFaancilaryCost>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FAAncilaryCost");

                entity.Property(e => e.AuthId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthID");

                entity.Property(e => e.CostCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CostDesc)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblFaancilaryCostTran>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FAAncilaryCostTrans");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AuthId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthID");

                entity.Property(e => e.CostCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Craccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRAccount");

                entity.Property(e => e.Draccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DRAccount");

                entity.Property(e => e.Facode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FACode");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MonthlyRunRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Narration)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NextAmortDate).HasColumnType("datetime");

                entity.Property(e => e.TranDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblFacategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FACategory");

                entity.Property(e => e.AuthId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthID");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CatDesc)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblFaclass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FAClass");

                entity.Property(e => e.AuthId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthID");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
                

                entity.Property(e => e.DepRate).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblFacostAmortization>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FACostAmortization");

                entity.Property(e => e.AccumAmortization).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FaCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MonthlyAmortization)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monthlyAmortization");

                entity.Property(e => e.NextAmortDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblFadepSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FADepSchedule");

                entity.Property(e => e.AssetCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MonthlyDep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.YearlyDep).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblFalocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FALocation");

                entity.Property(e => e.AccumDepGl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AccumDepGL");

                entity.Property(e => e.AssetGl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AssetGL");

                entity.Property(e => e.AuthId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthID");

                entity.Property(e => e.DateAllocated)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.DepExpenseGl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DepExpenseGL");

                entity.Property(e => e.Facode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FACode");

                entity.Property(e => e.FalocationCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("FALocationCode");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ReceiptBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblFamaintenaceHist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FAMaintenaceHist");

                entity.Property(e => e.AuthId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthID");

                entity.Property(e => e.Crgl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRGL");

                entity.Property(e => e.Drgl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DRGL");

                entity.Property(e => e.ExpMethod).HasColumnName("expMethod");

                entity.Property(e => e.Facode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FACode");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Narration)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TranDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tranamount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblFarecuringAmortSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FARecuringAmortSchedule");

                entity.Property(e => e.CostCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Facode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FACode");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MonthlyRunRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NextAmortDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<TblFarecurringClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FARecurringClass");

                entity.Property(e => e.AuthId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthID");

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CostCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblFarecurringCost>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FARecurringCost");

                entity.Property(e => e.CostCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CostDesc)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblFarecurringgCostTran>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FARecurringgCostTrans");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AuthId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthID");

                entity.Property(e => e.CostCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Craccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRAccount");

                entity.Property(e => e.Draccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DRAccount");

                entity.Property(e => e.Facode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FACode");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MonthlyRunRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Narration)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NextAmortDate).HasColumnType("datetime");

                entity.Property(e => e.TranDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblFarevaluation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FARevaluation");

                entity.Property(e => e.AuthId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthID");

                entity.Property(e => e.CurrentValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Facode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FACode");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PrevValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RevDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblFaschMaintRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FASchMaintRecord");

                entity.Property(e => e.AuthId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthID");

                entity.Property(e => e.Facode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FACode");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MaintDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.NextMaintDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblFawriteOff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FAWriteOff");

                entity.Property(e => e.AuthId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthID");

                entity.Property(e => e.Crgl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRGL");

                entity.Property(e => e.DisposalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Drgl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DRGL");

                entity.Property(e => e.Facode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FACode");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Narration)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OtherCostWriteoff).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TranDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblFixedAsset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FixedAsset");

                entity.Property(e => e.AccumDep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AccumDepGl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AccumDepGL");

                entity.Property(e => e.AuthId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthID");

                entity.Property(e => e.CatCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DepStartDate).HasColumnType("datetime");

                entity.Property(e => e.Deprate).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.DisposalAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpenseGl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ExpenseGL");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Facode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FACode");

                entity.Property(e => e.Facost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FACost");

                entity.Property(e => e.Faglaccount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FAGLAccount");

                entity.Property(e => e.Faname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FAName");

                entity.Property(e => e.FundingGl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FundingGL");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.ResidualVal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TranDate)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Role");

                entity.Property(e => e.AccessDays).HasColumnName("access_days");

                entity.Property(e => e.Authid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("authid");

                entity.Property(e => e.Canauth).HasColumnName("canauth");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Isoperation).HasColumnName("isoperation");

                entity.Property(e => e.ReqLimit).HasColumnName("reqLimit");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("role_id");

                entity.Property(e => e.RoleLevel).HasColumnName("role_level");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role_name");

                entity.Property(e => e.Roledesc)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("roledesc");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<TblTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_transactions");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Authid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("authid");

                entity.Property(e => e.BaseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Batchno)
                    .HasColumnType("decimal(22, 0)")
                    .HasColumnName("batchno");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("branchcode");

                entity.Property(e => e.Channel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Charge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("charge");

                entity.Property(e => e.Chknum)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("chknum");

                entity.Property(e => e.Crossrate)
                    .HasColumnType("decimal(10, 6)")
                    .HasColumnName("crossrate");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Deptcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("deptcode");

                entity.Property(e => e.Narration)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Overideid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("overideid");

                entity.Property(e => e.Postseq)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("postseq");

                entity.Property(e => e.Refno)
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("refno");

                entity.Property(e => e.ReversedTranRef).HasColumnName("Reversed_TranRef");

                entity.Property(e => e.Sn)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SN");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Subbranchcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("subbranchcode");

                entity.Property(e => e.Tellerno)
                    .HasColumnType("decimal(22, 0)")
                    .HasColumnName("tellerno");

                entity.Property(e => e.TranAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TranCurrency)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TranDate).HasColumnType("datetime");

                entity.Property(e => e.TranType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Trancode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Valuedate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblUserprofile>(entity =>
            {
                entity.ToTable("tbl_userprofile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthUserid)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Authid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("authid");

                entity.Property(e => e.Authorisedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("authorisedby");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("branchcode")
                    .IsFixedLength();

                entity.Property(e => e.Computername)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmPassword)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_date");

                entity.Property(e => e.Deptcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("deptcode")
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Emailalert).HasColumnName("emailalert");

                entity.Property(e => e.EnforcePwd).HasColumnName("enforce_pwd");

                entity.Property(e => e.Excemptlock).HasColumnName("excemptlock");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstname");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fullname");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ipaddress");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastname");

                entity.Property(e => e.Lockcount).HasColumnName("lockcount");

                entity.Property(e => e.Logincount).HasColumnName("logincount");

                entity.Property(e => e.Loginstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("loginstatus")
                    .IsFixedLength();

                entity.Property(e => e.Machaddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("machaddress");

                entity.Property(e => e.Multilogin).HasColumnName("multilogin");

                entity.Property(e => e.NextPasschangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Next_Passchange_date");

                entity.Property(e => e.Offlinealert).HasColumnName("offlinealert");

                entity.Property(e => e.Othername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("othername");

                entity.Property(e => e.PasschangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("passchange_date");

                entity.Property(e => e.PasswordResetCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phoneno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phoneno");

                entity.Property(e => e.PostGlAcctno)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("PostGL_Acctno");

                entity.Property(e => e.PostUserId)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Remotelogin).HasColumnName("remotelogin");

                entity.Property(e => e.ReportLevel)
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.Reportflag).HasColumnName("reportflag");

                entity.Property(e => e.RoleId).HasColumnName("Role_id");

                entity.Property(e => e.Sbu).HasColumnName("SBU");

                entity.Property(e => e.Sessionid).HasColumnName("sessionid");

                entity.Property(e => e.Smsalert).HasColumnName("smsalert");

                entity.Property(e => e.Sscode).HasColumnName("SScode");

                entity.Property(e => e.StaffStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Staff_status")
                    .IsFixedLength();

                entity.Property(e => e.Statement).HasColumnName("statement");

                entity.Property(e => e.Targetamt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("targetamt");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userpassword)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("userpassword");
            });

            modelBuilder.HasSequence<decimal>("transeq")
                .HasMin(-999999999999999999)
                .HasMax(999999999999999999);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
