using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace esg_mcp_server.Data;

public partial class DbHcisContext : DbContext
{
    public DbHcisContext()
    {
    }

    public DbHcisContext(DbContextOptions<DbHcisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Baapconfig> Baapconfigs { get; set; }

    public virtual DbSet<BacodeD> BacodeDs { get; set; }

    public virtual DbSet<BacodeDlang> BacodeDlangs { get; set; }

    public virtual DbSet<BacodeM> BacodeMs { get; set; }

    public virtual DbSet<Bacompany> Bacompanies { get; set; }

    public virtual DbSet<BacompanyName> BacompanyNames { get; set; }

    public virtual DbSet<Badept> Badepts { get; set; }

    public virtual DbSet<BadeptName> BadeptNames { get; set; }

    public virtual DbSet<BamenuList> BamenuLists { get; set; }

    public virtual DbSet<BamenuName> BamenuNames { get; set; }

    public virtual DbSet<Baotuser> Baotusers { get; set; }

    public virtual DbSet<BaotuserResetLog> BaotuserResetLogs { get; set; }

    public virtual DbSet<BarptField> BarptFields { get; set; }

    public virtual DbSet<BarptFieldLang> BarptFieldLangs { get; set; }

    public virtual DbSet<BarptSub> BarptSubs { get; set; }

    public virtual DbSet<Bauser> Bausers { get; set; }

    public virtual DbSet<BauserGroup> BauserGroups { get; set; }

    public virtual DbSet<BauserMenuAuth> BauserMenuAuths { get; set; }

    public virtual DbSet<EsgCourse> EsgCourses { get; set; }

    public virtual DbSet<EsgCustSat> EsgCustSats { get; set; }

    public virtual DbSet<EsgDept> EsgDepts { get; set; }

    public virtual DbSet<EsgDeptYearSet> EsgDeptYearSets { get; set; }

    public virtual DbSet<EsgEnergyRe> EsgEnergyRes { get; set; }

    public virtual DbSet<EsgFin> EsgFins { get; set; }

    public virtual DbSet<EsgFireSafe> EsgFireSaves { get; set; }

    public virtual DbSet<EsgGhGa> EsgGhGas { get; set; }

    public virtual DbSet<EsgLicense> EsgLicenses { get; set; }

    public virtual DbSet<EsgNonGhGa> EsgNonGhGas { get; set; }

    public virtual DbSet<EsgOsh> EsgOshes { get; set; }

    public virtual DbSet<EsgOshyfy> EsgOshyfies { get; set; }

    public virtual DbSet<EsgProcurment> EsgProcurments { get; set; }

    public virtual DbSet<EsgProdInfo> EsgProdInfos { get; set; }

    public virtual DbSet<EsgProdInfoYfy> EsgProdInfoYfies { get; set; }

    public virtual DbSet<EsgRawMaterial> EsgRawMaterials { get; set; }

    public virtual DbSet<EsgUserAuth> EsgUserAuths { get; set; }

    public virtual DbSet<EsgWaste> EsgWastes { get; set; }

    public virtual DbSet<EsgWaterRe> EsgWaterRes { get; set; }

    public virtual DbSet<MaiAgentContact> MaiAgentContacts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Baapconfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BAAPConfig", "Base");

            entity.Property(e => e.ApkeyId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("APKeyID");
            entity.Property(e => e.CEnable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cEnable");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.IsEncrypt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<BacodeD>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BACodeD", "Base");

            entity.Property(e => e.CEnable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cEnable");
            entity.Property(e => e.CodeField)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ContentDesc).HasMaxLength(80);
            entity.Property(e => e.ContentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ContentID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<BacodeDlang>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BACodeDLang", "Base");

            entity.Property(e => e.CSort).HasColumnName("cSort");
            entity.Property(e => e.CodeField)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ContentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ContentID");
            entity.Property(e => e.ContentName).HasMaxLength(60);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.LanguageId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LanguageID");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<BacodeM>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BACodeM", "Base");

            entity.Property(e => e.CEnable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cEnable");
            entity.Property(e => e.CodeField)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodeFixFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodeName).HasMaxLength(40);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.SysMain)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sysMain");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<Bacompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BACompany", "Base");

            entity.Property(e => e.AccCom)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Bgid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BGID");
            entity.Property(e => e.CEnable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cEnable");
            entity.Property(e => e.CompArea)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CompDesc).HasMaxLength(50);
            entity.Property(e => e.CompType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CountryId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CountryID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CurrencyID");
            entity.Property(e => e.EiscompId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("EISCompID");
            entity.Property(e => e.FaxNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImkeyId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("IMKeyID");
            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxId)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TaxID");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<BacompanyName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BACompanyName", "Base");

            entity.Property(e => e.CompAddr).HasMaxLength(200);
            entity.Property(e => e.CompName).HasMaxLength(100);
            entity.Property(e => e.CompNameS).HasMaxLength(30);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.LanguageId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LanguageID");
            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<Badept>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BADept", "Base");

            entity.Property(e => e.CEnable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cEnable");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CountryId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CountryID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.CurrencyId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CurrencyID");
            entity.Property(e => e.DeptArea)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DeptDesc).HasMaxLength(50);
            entity.Property(e => e.EiscompId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("EISCompID");
            entity.Property(e => e.EisdeptId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EISDeptID");
            entity.Property(e => e.Eisopid)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EISOPID");
            entity.Property(e => e.IsBranch)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<BadeptName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BADeptName", "Base");

            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.BranchNameS).HasMaxLength(30);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.DeptName).HasMaxLength(100);
            entity.Property(e => e.DeptNameS).HasMaxLength(30);
            entity.Property(e => e.LanguageId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LanguageID");
            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<BamenuList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BAMenuList", "Base");

            entity.Property(e => e.CControl)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cControl");
            entity.Property(e => e.CEnable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cEnable");
            entity.Property(e => e.CSort).HasColumnName("cSort");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.MenuDesc).HasMaxLength(50);
            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.MenuNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MenuType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ParentMenuId).HasColumnName("ParentMenuID");
            entity.Property(e => e.SysArea)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<BamenuName>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BAMenuName", "Base");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.LanguageId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LanguageID");
            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.MenuName).HasMaxLength(60);
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<Baotuser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BAOTUser", "Base");

            entity.Property(e => e.CEnable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cEnable");
            entity.Property(e => e.CodeUserKind)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.LastPassword)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.OtuserId)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("OTUserID");
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PasswordHint)
                .HasMaxLength(50)
                .HasColumnName("PasswordHInt");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<BaotuserResetLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BAOTUserResetLog", "Base");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.OtuserId)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("OTUserID");
        });

        modelBuilder.Entity<BarptField>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BARptField", "Base");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.FieldDesc).HasMaxLength(50);
            entity.Property(e => e.FieldId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FieldID");
            entity.Property(e => e.ReportId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ReportID");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<BarptFieldLang>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BARptFieldLang", "Base");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.FieldId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FieldID");
            entity.Property(e => e.FieldName).HasMaxLength(100);
            entity.Property(e => e.LanguageId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LanguageID");
            entity.Property(e => e.ReportId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ReportID");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<BarptSub>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BARptSub", "Base");

            entity.Property(e => e.Bcc)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CEnable).HasColumnName("cEnable");
            entity.Property(e => e.Cc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CC");
            entity.Property(e => e.Comment)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FileFormat)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Priority)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ReplyTo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReportId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ReportID");
            entity.Property(e => e.Subject)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.To)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Bauser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BAUser", "Base");

            entity.Property(e => e.CEnable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cEnable");
            entity.Property(e => e.CodeUserKind)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.LanguageId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LanguageID");
            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.OpId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("OpID");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
            entity.Property(e => e.UserGroupId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UserGroupID");
            entity.Property(e => e.UserId)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(40);
            entity.Property(e => e.UserTitle).HasMaxLength(40);
        });

        modelBuilder.Entity<BauserGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BAUserGroup", "Base");

            entity.Property(e => e.CEnable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cEnable");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.LockId).HasColumnName("LockID");
            entity.Property(e => e.SysArea)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
            entity.Property(e => e.UserGroupId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UserGroupID");
            entity.Property(e => e.UserGroupName).HasMaxLength(30);
        });

        modelBuilder.Entity<BauserMenuAuth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BAUserMenuAuth", "Base");

            entity.Property(e => e.CModify)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cModify");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.SecKind)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
            entity.Property(e => e.UserGroupId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("UserGroupID");
            entity.Property(e => e.UserId)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<EsgCourse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgCourse", "HC");

            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.CourseHours).HasColumnType("decimal(5, 1)");
            entity.Property(e => e.CourseName).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.Memo).HasMaxLength(200);
            entity.Property(e => e.OpName).HasMaxLength(100);
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<EsgCustSat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgCustSat", "HC");

            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.Freq).HasMaxLength(100);
            entity.Property(e => e.FreqMemo).HasMaxLength(100);
            entity.Property(e => e.Method).HasMaxLength(100);
            entity.Property(e => e.MethodMemo).HasMaxLength(100);
            entity.Property(e => e.OpName).HasMaxLength(100);
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SatiQtyMemo).HasMaxLength(100);
            entity.Property(e => e.SatiRatio).HasColumnType("decimal(5, 1)");
            entity.Property(e => e.SatiRatioMemo).HasMaxLength(100);
            entity.Property(e => e.Scoring).HasMaxLength(100);
            entity.Property(e => e.ScoringMemo).HasMaxLength(100);
            entity.Property(e => e.SurveyObj).HasMaxLength(100);
            entity.Property(e => e.SurveyObjMemo).HasMaxLength(100);
            entity.Property(e => e.TotalQtyMemo).HasMaxLength(100);
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<EsgDept>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgDept", "HC");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.EsgBg)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EsgBG");
            entity.Property(e => e.EsgBgarea)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EsgBGArea");
            entity.Property(e => e.EsgBgareaType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("EsgBGAreaType");
            entity.Property(e => e.MfBaseYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MfBaseYN");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<EsgDeptYearSet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgDeptYearSet", "HC");

            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.EsgGhGasType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EsgWpress)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EsgWPress");
            entity.Property(e => e.ModYn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ModYN");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<EsgEnergyRe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgEnergyRes", "HC");

            entity.Property(e => e.AfHydrogenGj).HasColumnName("AfHydrogenGJ");
            entity.Property(e => e.AfHydrogenHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AfHydrogenHV");
            entity.Property(e => e.AfHydrogenMwh).HasColumnName("AfHydrogenMWh");
            entity.Property(e => e.AfMudGj).HasColumnName("AfMudGJ");
            entity.Property(e => e.AfMudHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AfMudHV");
            entity.Property(e => e.AfMudMwh).HasColumnName("AfMudMWh");
            entity.Property(e => e.AfRubberGj).HasColumnName("AfRubberGJ");
            entity.Property(e => e.AfRubberHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AfRubberHV");
            entity.Property(e => e.AfRubberMwh).HasColumnName("AfRubberMWh");
            entity.Property(e => e.AfSlagGj).HasColumnName("AfSlagGJ");
            entity.Property(e => e.AfSlagHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AfSlagHV");
            entity.Property(e => e.AfSlagMwh).HasColumnName("AfSlagMWh");
            entity.Property(e => e.AfSrf).HasColumnName("AfSRF");
            entity.Property(e => e.AfSrfgj).HasColumnName("AfSRFGJ");
            entity.Property(e => e.AfSrfhv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AfSRFHV");
            entity.Property(e => e.AfSrfmwh).HasColumnName("AfSRFMWh");
            entity.Property(e => e.BioArgGj).HasColumnName("BioArgGJ");
            entity.Property(e => e.BioArgHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BioArgHV");
            entity.Property(e => e.BioArgMwh).HasColumnName("BioArgMWh");
            entity.Property(e => e.BioBarkGj).HasColumnName("BioBarkGJ");
            entity.Property(e => e.BioBarkHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BioBarkHV");
            entity.Property(e => e.BioBarkMwh).HasColumnName("BioBarkMWh");
            entity.Property(e => e.BioWoodGj).HasColumnName("BioWoodGJ");
            entity.Property(e => e.BioWoodHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BioWoodHV");
            entity.Property(e => e.BioWoodMwh).HasColumnName("BioWoodMWh");
            entity.Property(e => e.BioWpelt).HasColumnName("BioWPelt");
            entity.Property(e => e.BioWpeltGj).HasColumnName("BioWPeltGJ");
            entity.Property(e => e.BioWpeltHv)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("BioWPeltHV");
            entity.Property(e => e.BioWpeltMwh).HasColumnName("BioWPeltMWh");
            entity.Property(e => e.BiogasGj).HasColumnName("BiogasGJ");
            entity.Property(e => e.BiogasHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BiogasHV");
            entity.Property(e => e.BiogasMwh).HasColumnName("BiogasMWh");
            entity.Property(e => e.BiothickGj).HasColumnName("BiothickGJ");
            entity.Property(e => e.BiothickHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BiothickHV");
            entity.Property(e => e.BiothickMwh).HasColumnName("BiothickMWh");
            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.ConSumGj).HasColumnName("ConSumGJ");
            entity.Property(e => e.ConSumMwh).HasColumnName("ConSumMWh");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.EcChangeMemo).HasMaxLength(300);
            entity.Property(e => e.EcFutureMemo).HasMaxLength(300);
            entity.Property(e => e.EcOpGenGj).HasColumnName("EcOpGenGJ");
            entity.Property(e => e.EcOpGenHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EcOpGenHV");
            entity.Property(e => e.EcOpGenMwh).HasColumnName("EcOpGenMWh");
            entity.Property(e => e.EcOpRegGj).HasColumnName("EcOpRegGJ");
            entity.Property(e => e.EcOpRegHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EcOpRegHV");
            entity.Property(e => e.EcOpRegMwh).HasColumnName("EcOpRegMWh");
            entity.Property(e => e.EcOpSumGj).HasColumnName("EcOpSumGJ");
            entity.Property(e => e.EcOpSumMwh).HasColumnName("EcOpSumMWh");
            entity.Property(e => e.EcSelfBioGj).HasColumnName("EcSelfBioGJ");
            entity.Property(e => e.EcSelfBioHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EcSelfBioHV");
            entity.Property(e => e.EcSelfBioMwh).HasColumnName("EcSelfBioMWh");
            entity.Property(e => e.EcSelfGenGj).HasColumnName("EcSelfGenGJ");
            entity.Property(e => e.EcSelfGenHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EcSelfGenHV");
            entity.Property(e => e.EcSelfGenMwh).HasColumnName("EcSelfGenMWh");
            entity.Property(e => e.EcSelfRegGj).HasColumnName("EcSelfRegGJ");
            entity.Property(e => e.EcSelfRegHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EcSelfRegHV");
            entity.Property(e => e.EcSelfRegMwh).HasColumnName("EcSelfRegMWh");
            entity.Property(e => e.EcSelfSumGj).HasColumnName("EcSelfSumGJ");
            entity.Property(e => e.EcSelfSumMwh).HasColumnName("EcSelfSumMWh");
            entity.Property(e => e.EcSumGj).HasColumnName("EcSumGJ");
            entity.Property(e => e.EcSumMwh).HasColumnName("EcSumMWh");
            entity.Property(e => e.EngSumGj).HasColumnName("EngSumGJ");
            entity.Property(e => e.EngSumMwh).HasColumnName("EngSumMWh");
            entity.Property(e => e.EsgEngType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FfCoalGj).HasColumnName("FfCoalGJ");
            entity.Property(e => e.FfCoalHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FfCoalHV");
            entity.Property(e => e.FfCoalMwh).HasColumnName("FfCoalMWh");
            entity.Property(e => e.FfLpgGj).HasColumnName("FfLpgGJ");
            entity.Property(e => e.FfLpgHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FfLpgHV");
            entity.Property(e => e.FfLpgMwh).HasColumnName("FfLpgMWh");
            entity.Property(e => e.FfNgGj).HasColumnName("FfNgGJ");
            entity.Property(e => e.FfNgHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FfNgHV");
            entity.Property(e => e.FfNgMwh).HasColumnName("FfNgMWh");
            entity.Property(e => e.FfOilGj).HasColumnName("FfOilGJ");
            entity.Property(e => e.FfOilHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FfOilHV");
            entity.Property(e => e.FfOilMwh).HasColumnName("FfOilMWh");
            entity.Property(e => e.Ffdiesel).HasColumnName("FFDiesel");
            entity.Property(e => e.FfdieselGj).HasColumnName("FFDieselGJ");
            entity.Property(e => e.FfdieselHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FFDieselHV");
            entity.Property(e => e.FfdieselMwh).HasColumnName("FFDieselMWh");
            entity.Property(e => e.FuelChangeMemo).HasMaxLength(300);
            entity.Property(e => e.FuelFutureMemo).HasMaxLength(300);
            entity.Property(e => e.FuelSumGj).HasColumnName("FuelSumGJ");
            entity.Property(e => e.FuelSumMwh).HasColumnName("FuelSumMWh");
            entity.Property(e => e.OpName).HasMaxLength(100);
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RfOpGj).HasColumnName("RfOpGJ");
            entity.Property(e => e.RfOpHv)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("RfOpHV");
            entity.Property(e => e.RfOpMwh).HasColumnName("RfOpMWh");
            entity.Property(e => e.RfSelfGj).HasColumnName("RfSelfGJ");
            entity.Property(e => e.RfSelfHv)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("RfSelfHV");
            entity.Property(e => e.RfSelfMwh).HasColumnName("RfSelfMWh");
            entity.Property(e => e.SecBioGj).HasColumnName("SecBioGJ");
            entity.Property(e => e.SecBioHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SecBioHV");
            entity.Property(e => e.SecBioMwh).HasColumnName("SecBioMWh");
            entity.Property(e => e.SecChangeMemo).HasMaxLength(300);
            entity.Property(e => e.SecFutureMemo).HasMaxLength(300);
            entity.Property(e => e.SecNonRegGj).HasColumnName("SecNonRegGJ");
            entity.Property(e => e.SecNonRegHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SecNonRegHV");
            entity.Property(e => e.SecNonRegMwh).HasColumnName("SecNonRegMWh");
            entity.Property(e => e.SecRegGj).HasColumnName("SecRegGJ");
            entity.Property(e => e.SecRegHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SecRegHV");
            entity.Property(e => e.SecRegMwh).HasColumnName("SecRegMWh");
            entity.Property(e => e.SecSumGj).HasColumnName("SecSumGJ");
            entity.Property(e => e.SecSumMwh).HasColumnName("SecSumMWh");
            entity.Property(e => e.SstGj).HasColumnName("SstGJ");
            entity.Property(e => e.SstHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SstHV");
            entity.Property(e => e.SstMwh).HasColumnName("SstMWh");
            entity.Property(e => e.StChangeMemo).HasMaxLength(300);
            entity.Property(e => e.StFutureMemo).HasMaxLength(300);
            entity.Property(e => e.StOpGenGj).HasColumnName("StOpGenGJ");
            entity.Property(e => e.StOpGenHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("StOpGenHV");
            entity.Property(e => e.StOpGenMwh).HasColumnName("StOpGenMWh");
            entity.Property(e => e.StOpRegGj).HasColumnName("StOpRegGJ");
            entity.Property(e => e.StOpRegHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("StOpRegHV");
            entity.Property(e => e.StOpRegMwh).HasColumnName("StOpRegMWh");
            entity.Property(e => e.StOpSumGj).HasColumnName("StOpSumGJ");
            entity.Property(e => e.StOpSumMwh).HasColumnName("StOpSumMWh");
            entity.Property(e => e.StSelfBioGj).HasColumnName("StSelfBioGJ");
            entity.Property(e => e.StSelfBioHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("StSelfBioHV");
            entity.Property(e => e.StSelfBioMwh).HasColumnName("StSelfBioMWh");
            entity.Property(e => e.StSelfGenGj).HasColumnName("StSelfGenGJ");
            entity.Property(e => e.StSelfGenHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("StSelfGenHV");
            entity.Property(e => e.StSelfGenMwh).HasColumnName("StSelfGenMWh");
            entity.Property(e => e.StSelfRegGj).HasColumnName("StSelfRegGJ");
            entity.Property(e => e.StSelfRegHv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("StSelfRegHV");
            entity.Property(e => e.StSelfRegMwh).HasColumnName("StSelfRegMWh");
            entity.Property(e => e.StSelfSumGj).HasColumnName("StSelfSumGJ");
            entity.Property(e => e.StSelfSumMwh).HasColumnName("StSelfSumMWh");
            entity.Property(e => e.StSumGj).HasColumnName("StSumGJ");
            entity.Property(e => e.StSumMwh).HasColumnName("StSumMWh");
            entity.Property(e => e.TmOpGj).HasColumnName("TmOpGJ");
            entity.Property(e => e.TmOpHv)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("TmOpHV");
            entity.Property(e => e.TmOpMwh).HasColumnName("TmOpMWh");
            entity.Property(e => e.TmSelfGj).HasColumnName("TmSelfGJ");
            entity.Property(e => e.TmSelfHv)
                .HasColumnType("decimal(18, 9)")
                .HasColumnName("TmSelfHV");
            entity.Property(e => e.TmSelfMwh).HasColumnName("TmSelfMWh");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<EsgFin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgFin", "HC");

            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.OpIncome).HasColumnType("decimal(15, 0)");
            entity.Property(e => e.OpIncomeMemo).HasMaxLength(200);
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<EsgFireSafe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgFireSafe", "HC");

            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.DamageAmtMemo).HasMaxLength(200);
            entity.Property(e => e.DamageCurr)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.DeathQtyMemo).HasMaxLength(200);
            entity.Property(e => e.FireQtyMemo).HasMaxLength(200);
            entity.Property(e => e.IjuredQtyMemo).HasMaxLength(200);
            entity.Property(e => e.Improve).HasMaxLength(200);
            entity.Property(e => e.ImproveMemo).HasMaxLength(200);
            entity.Property(e => e.OpName).HasMaxLength(100);
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<EsgGhGa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgGhGas", "HC");

            entity.Property(e => e.Bm).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.Ch4)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CH4");
            entity.Property(e => e.ChpCt).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ChpPulp).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Co2)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CO2");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.Gas1).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Gas2).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GasSum).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Hfcs)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("HFCS");
            entity.Property(e => e.Memo).HasMaxLength(200);
            entity.Property(e => e.MemoFu).HasMaxLength(200);
            entity.Property(e => e.N2o)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("N2O");
            entity.Property(e => e.Nf3)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("NF3");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Pfcs)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PFCS");
            entity.Property(e => e.PulpCtMemo).HasMaxLength(200);
            entity.Property(e => e.Sf6)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SF6");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<EsgLicense>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgLicense", "HC");

            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.Fsc)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("FSC");
            entity.Property(e => e.Fscunit)
                .HasMaxLength(50)
                .HasColumnName("FSCUnit");
            entity.Property(e => e.Iso14001)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("ISO14001");
            entity.Property(e => e.Iso14001unit)
                .HasMaxLength(50)
                .HasColumnName("ISO14001Unit");
            entity.Property(e => e.Iso14064)
                .HasMaxLength(100)
                .HasColumnName("ISO14064");
            entity.Property(e => e.Iso14067)
                .HasMaxLength(100)
                .HasColumnName("ISO14067");
            entity.Property(e => e.Iso45001)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("ISO45001");
            entity.Property(e => e.Iso45001unit)
                .HasMaxLength(50)
                .HasColumnName("ISO45001Unit");
            entity.Property(e => e.Iso50001)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("ISO50001");
            entity.Property(e => e.Iso50001unit)
                .HasMaxLength(50)
                .HasColumnName("ISO50001Unit");
            entity.Property(e => e.Iso9001)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("ISO9001");
            entity.Property(e => e.Iso9001unit)
                .HasMaxLength(50)
                .HasColumnName("ISO9001Unit");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Other).HasMaxLength(200);
            entity.Property(e => e.Pefc)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PEFC");
            entity.Property(e => e.Pefcunit)
                .HasMaxLength(50)
                .HasColumnName("PEFCUnit");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<EsgNonGhGa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgNonGhGas", "HC");

            entity.Property(e => e.Arsenic).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ArsenicMemo).HasMaxLength(100);
            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.Cadmium).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CadmiumMemo).HasMaxLength(100);
            entity.Property(e => e.Cfcs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CFCs");
            entity.Property(e => e.CfcsMemo)
                .HasMaxLength(100)
                .HasColumnName("CFCsMemo");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.Dioxin).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DioxinMemo).HasMaxLength(100);
            entity.Property(e => e.Hcfcs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HCFCs");
            entity.Property(e => e.HcfcsMemo)
                .HasMaxLength(100)
                .HasColumnName("HCFCsMemo");
            entity.Property(e => e.Hex).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.HexMemo).HasMaxLength(100);
            entity.Property(e => e.Hln)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HLN");
            entity.Property(e => e.Hlnmemo)
                .HasMaxLength(100)
                .HasColumnName("HLNMemo");
            entity.Property(e => e.LeadMemo).HasMaxLength(100);
            entity.Property(e => e.Leads).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Mbx).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MbxMemo).HasMaxLength(100);
            entity.Property(e => e.Mercury).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MercuryMemo).HasMaxLength(100);
            entity.Property(e => e.Nox).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NoxMemo).HasMaxLength(100);
            entity.Property(e => e.OpName).HasMaxLength(100);
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Pm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PM");
            entity.Property(e => e.Pmmemo)
                .HasMaxLength(100)
                .HasColumnName("PMMemo");
            entity.Property(e => e.Sox).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SoxMemo).HasMaxLength(100);
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
            entity.Property(e => e.Vocs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VOCs");
            entity.Property(e => e.VocsMemo)
                .HasMaxLength(100)
                .HasColumnName("VOCsMemo");
        });

        modelBuilder.Entity<EsgOsh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgOSH", "HC");

            entity.Property(e => e.A01yn)
                .HasMaxLength(100)
                .HasColumnName("A01YN");
            entity.Property(e => e.A02desc)
                .HasMaxLength(100)
                .HasColumnName("A02Desc");
            entity.Property(e => e.A03desc)
                .HasMaxLength(100)
                .HasColumnName("A03Desc");
            entity.Property(e => e.A04desc)
                .HasMaxLength(100)
                .HasColumnName("A04Desc");
            entity.Property(e => e.A05desc)
                .HasMaxLength(100)
                .HasColumnName("A05Desc");
            entity.Property(e => e.A06desc)
                .HasMaxLength(100)
                .HasColumnName("A06Desc");
            entity.Property(e => e.A07desc)
                .HasMaxLength(100)
                .HasColumnName("A07Desc");
            entity.Property(e => e.A08desc)
                .HasMaxLength(100)
                .HasColumnName("A08Desc");
            entity.Property(e => e.A09desc)
                .HasMaxLength(100)
                .HasColumnName("A09Desc");
            entity.Property(e => e.A10desc)
                .HasMaxLength(100)
                .HasColumnName("A10Desc");
            entity.Property(e => e.A11desc)
                .HasMaxLength(100)
                .HasColumnName("A11Desc");
            entity.Property(e => e.A12desc)
                .HasMaxLength(100)
                .HasColumnName("A12Desc");
            entity.Property(e => e.B01desc)
                .HasMaxLength(100)
                .HasColumnName("B01Desc");
            entity.Property(e => e.B02num).HasColumnName("B02Num");
            entity.Property(e => e.B03num).HasColumnName("B03Num");
            entity.Property(e => e.B04num).HasColumnName("B04Num");
            entity.Property(e => e.B05num).HasColumnName("B05Num");
            entity.Property(e => e.B06num).HasColumnName("B06Num");
            entity.Property(e => e.B07num).HasColumnName("B07Num");
            entity.Property(e => e.B08desc)
                .HasMaxLength(100)
                .HasColumnName("B08Desc");
            entity.Property(e => e.B09desc)
                .HasMaxLength(100)
                .HasColumnName("B09Desc");
            entity.Property(e => e.B10num).HasColumnName("B10Num");
            entity.Property(e => e.B11num).HasColumnName("B11Num");
            entity.Property(e => e.B12num).HasColumnName("B12Num");
            entity.Property(e => e.B13num).HasColumnName("B13Num");
            entity.Property(e => e.B14num).HasColumnName("B14Num");
            entity.Property(e => e.B15num).HasColumnName("B15Num");
            entity.Property(e => e.B16num).HasColumnName("B16Num");
            entity.Property(e => e.B17num).HasColumnName("B17Num");
            entity.Property(e => e.B18num).HasColumnName("B18Num");
            entity.Property(e => e.B19num).HasColumnName("B19Num");
            entity.Property(e => e.B20num).HasColumnName("B20Num");
            entity.Property(e => e.B21num).HasColumnName("B21Num");
            entity.Property(e => e.B22num).HasColumnName("B22Num");
            entity.Property(e => e.C01desc)
                .HasMaxLength(100)
                .HasColumnName("C01Desc");
            entity.Property(e => e.C02num).HasColumnName("C02Num");
            entity.Property(e => e.C03num).HasColumnName("C03Num");
            entity.Property(e => e.C04desc)
                .HasMaxLength(100)
                .HasColumnName("C04Desc");
            entity.Property(e => e.C05num).HasColumnName("C05Num");
            entity.Property(e => e.C06desc)
                .HasMaxLength(100)
                .HasColumnName("C06Desc");
            entity.Property(e => e.C07num).HasColumnName("C07Num");
            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.D01yn)
                .HasMaxLength(100)
                .HasColumnName("D01YN");
            entity.Property(e => e.D02desc)
                .HasMaxLength(100)
                .HasColumnName("D02Desc");
            entity.Property(e => e.D04desc)
                .HasMaxLength(100)
                .HasColumnName("D04Desc");
            entity.Property(e => e.D05desc)
                .HasMaxLength(100)
                .HasColumnName("D05Desc");
            entity.Property(e => e.D06num).HasColumnName("D06Num");
            entity.Property(e => e.D07num).HasColumnName("D07Num");
            entity.Property(e => e.D08num).HasColumnName("D08Num");
            entity.Property(e => e.E01num).HasColumnName("E01Num");
            entity.Property(e => e.E02num).HasColumnName("E02Num");
            entity.Property(e => e.E03num).HasColumnName("E03Num");
            entity.Property(e => e.E04num).HasColumnName("E04Num");
            entity.Property(e => e.E05num).HasColumnName("E05Num");
            entity.Property(e => e.E06num).HasColumnName("E06Num");
            entity.Property(e => e.E07num).HasColumnName("E07Num");
            entity.Property(e => e.E08desc)
                .HasMaxLength(100)
                .HasColumnName("E08Desc");
            entity.Property(e => e.F01desc)
                .HasMaxLength(100)
                .HasColumnName("F01Desc");
            entity.Property(e => e.F02num).HasColumnName("F02Num");
            entity.Property(e => e.F03desc)
                .HasMaxLength(100)
                .HasColumnName("F03Desc");
            entity.Property(e => e.G01num).HasColumnName("G01Num");
            entity.Property(e => e.G02num).HasColumnName("G02Num");
            entity.Property(e => e.G03num).HasColumnName("G03Num");
            entity.Property(e => e.G04num).HasColumnName("G04Num");
            entity.Property(e => e.H01num).HasColumnName("H01Num");
            entity.Property(e => e.H02desc)
                .HasMaxLength(100)
                .HasColumnName("H02Desc");
            entity.Property(e => e.H03num).HasColumnName("H03Num");
            entity.Property(e => e.H04num).HasColumnName("H04Num");
            entity.Property(e => e.H05desc)
                .HasMaxLength(100)
                .HasColumnName("H05Desc");
            entity.Property(e => e.H06desc)
                .HasMaxLength(100)
                .HasColumnName("H06Desc");
            entity.Property(e => e.J01num).HasColumnName("J01Num");
            entity.Property(e => e.J02desc)
                .HasMaxLength(100)
                .HasColumnName("J02Desc");
            entity.Property(e => e.J03num).HasColumnName("J03Num");
            entity.Property(e => e.J04desc)
                .HasMaxLength(100)
                .HasColumnName("J04Desc");
            entity.Property(e => e.J05desc)
                .HasMaxLength(100)
                .HasColumnName("J05Desc");
            entity.Property(e => e.J06num).HasColumnName("J06Num");
            entity.Property(e => e.J07num).HasColumnName("J07Num");
            entity.Property(e => e.K01num).HasColumnName("K01Num");
            entity.Property(e => e.K02desc)
                .HasMaxLength(100)
                .HasColumnName("K02Desc");
            entity.Property(e => e.K03num).HasColumnName("K03Num");
            entity.Property(e => e.K04desc)
                .HasMaxLength(100)
                .HasColumnName("K04Desc");
            entity.Property(e => e.K05desc)
                .HasMaxLength(100)
                .HasColumnName("K05Desc");
            entity.Property(e => e.K06num).HasColumnName("K06Num");
            entity.Property(e => e.K07num).HasColumnName("K07Num");
            entity.Property(e => e.L01num).HasColumnName("L01Num");
            entity.Property(e => e.L02num).HasColumnName("L02Num");
            entity.Property(e => e.M01num).HasColumnName("M01Num");
            entity.Property(e => e.M02num).HasColumnName("M02Num");
            entity.Property(e => e.M03num).HasColumnName("M03Num");
            entity.Property(e => e.M04desc)
                .HasMaxLength(100)
                .HasColumnName("M04Desc");
            entity.Property(e => e.OpName).HasMaxLength(100);
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<EsgOshyfy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgOSHYFY", "HC");

            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.EmpInjType).HasMaxLength(100);
            entity.Property(e => e.NempAccNum).HasColumnName("NEmpAccNum");
            entity.Property(e => e.NempDisNum).HasColumnName("NEmpDisNum");
            entity.Property(e => e.NempInjType)
                .HasMaxLength(100)
                .HasColumnName("NEmpInjType");
            entity.Property(e => e.NempWorkHr).HasColumnName("NEmpWorkHr");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<EsgProcurment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgProcurment", "HC");

            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.CtFscCoc100Memo).HasMaxLength(100);
            entity.Property(e => e.CtFscCocCwMemo).HasMaxLength(100);
            entity.Property(e => e.CtFscCocMixMemo).HasMaxLength(100);
            entity.Property(e => e.CtFscCocRcMemo).HasMaxLength(100);
            entity.Property(e => e.CtFscFm).HasColumnName("CtFscFM");
            entity.Property(e => e.CtFscFmmemo)
                .HasMaxLength(100)
                .HasColumnName("CtFscFMMemo");
            entity.Property(e => e.CtNoneMemo).HasMaxLength(100);
            entity.Property(e => e.CtOtMemo).HasMaxLength(100);
            entity.Property(e => e.CtPefc).HasColumnName("CtPEFC");
            entity.Property(e => e.CtPefcmemo)
                .HasMaxLength(100)
                .HasColumnName("CtPEFCMemo");
            entity.Property(e => e.CtTqyMemo).HasMaxLength(100);
            entity.Property(e => e.OpName).HasMaxLength(100);
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PulpFscCoc100Memo).HasMaxLength(100);
            entity.Property(e => e.PulpFscCocCwMemo).HasMaxLength(100);
            entity.Property(e => e.PulpFscCocMixMemo).HasMaxLength(100);
            entity.Property(e => e.PulpFscCocRcMemo).HasMaxLength(100);
            entity.Property(e => e.PulpFscFm).HasColumnName("PulpFscFM");
            entity.Property(e => e.PulpFscFmmemo)
                .HasMaxLength(100)
                .HasColumnName("PulpFscFMMemo");
            entity.Property(e => e.PulpNoneMemo).HasMaxLength(100);
            entity.Property(e => e.PulpOtMemo).HasMaxLength(100);
            entity.Property(e => e.PulpPefc).HasColumnName("PulpPEFC");
            entity.Property(e => e.PulpPefcmemo)
                .HasMaxLength(100)
                .HasColumnName("PulpPEFCMemo");
            entity.Property(e => e.PulpTqyMemo).HasMaxLength(100);
            entity.Property(e => e.SfNoneMemo).HasMaxLength(100);
            entity.Property(e => e.SfOtMemo).HasMaxLength(100);
            entity.Property(e => e.SfRspoMemo).HasMaxLength(100);
            entity.Property(e => e.SfTqyMemo).HasMaxLength(100);
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
            entity.Property(e => e.WfFscFm).HasColumnName("WfFscFM");
            entity.Property(e => e.WfPefc).HasColumnName("WfPEFC");
            entity.Property(e => e.WoodFscCoc100Memo).HasMaxLength(100);
            entity.Property(e => e.WoodFscCocCwMemo).HasMaxLength(100);
            entity.Property(e => e.WoodFscCocMixMemo).HasMaxLength(100);
            entity.Property(e => e.WoodFscCocRcMemo).HasMaxLength(100);
            entity.Property(e => e.WoodFscFm).HasColumnName("WoodFscFM");
            entity.Property(e => e.WoodFscFmmemo)
                .HasMaxLength(100)
                .HasColumnName("WoodFscFMMemo");
            entity.Property(e => e.WoodNoneMemo).HasMaxLength(100);
            entity.Property(e => e.WoodOtMemo).HasMaxLength(100);
            entity.Property(e => e.WoodPefc).HasColumnName("WoodPEFC");
            entity.Property(e => e.WoodPefcmemo)
                .HasMaxLength(100)
                .HasColumnName("WoodPEFCMemo");
            entity.Property(e => e.WoodTqyMemo).HasMaxLength(100);
            entity.Property(e => e.WpHumMemo).HasMaxLength(100);
            entity.Property(e => e.WpOtMemo).HasMaxLength(100);
            entity.Property(e => e.WpTqyMemo).HasMaxLength(100);
        });

        modelBuilder.Entity<EsgProdInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgProdInfo", "HC");

            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.CartonAdt).HasColumnName("CartonADT");
            entity.Property(e => e.CartonAdtmemo)
                .HasMaxLength(100)
                .HasColumnName("CartonADTMemo");
            entity.Property(e => e.CartonMt).HasColumnName("CartonMT");
            entity.Property(e => e.CartonMtmemo)
                .HasMaxLength(100)
                .HasColumnName("CartonMTMemo");
            entity.Property(e => e.ChpHouseAdt).HasColumnName("ChpHouseADT");
            entity.Property(e => e.ChpHouseAdt2).HasColumnName("ChpHouseADT2");
            entity.Property(e => e.ChpHouseAdtmemo)
                .HasMaxLength(100)
                .HasColumnName("ChpHouseADTMemo");
            entity.Property(e => e.ChpHouseMt).HasColumnName("ChpHouseMT");
            entity.Property(e => e.ChpHouseMt2).HasColumnName("ChpHouseMT2");
            entity.Property(e => e.ChpHouseMtmemo)
                .HasMaxLength(100)
                .HasColumnName("ChpHouseMTMemo");
            entity.Property(e => e.CleanMt).HasColumnName("CleanMT");
            entity.Property(e => e.CleanMtmemo)
                .HasMaxLength(100)
                .HasColumnName("CleanMTMemo");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.GreenMemo).HasMaxLength(100);
            entity.Property(e => e.GreenMt).HasColumnName("GreenMT");
            entity.Property(e => e.HouseAdt).HasColumnName("HouseADT");
            entity.Property(e => e.HouseAdtmemo)
                .HasMaxLength(100)
                .HasColumnName("HouseADTMemo");
            entity.Property(e => e.HouseMt).HasColumnName("HouseMT");
            entity.Property(e => e.HouseMtmemo)
                .HasMaxLength(100)
                .HasColumnName("HouseMTMemo");
            entity.Property(e => e.OpName).HasMaxLength(100);
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PaperAdt).HasColumnName("PaperADT");
            entity.Property(e => e.PaperAdt2).HasColumnName("PaperADT2");
            entity.Property(e => e.PaperAdtmemo)
                .HasMaxLength(100)
                .HasColumnName("PaperADTMemo");
            entity.Property(e => e.PaperMt).HasColumnName("PaperMT");
            entity.Property(e => e.PaperMt2).HasColumnName("PaperMT2");
            entity.Property(e => e.PaperMtmemo)
                .HasMaxLength(100)
                .HasColumnName("PaperMTMemo");
            entity.Property(e => e.ProAdt).HasColumnName("ProADT");
            entity.Property(e => e.ProAdtmemo)
                .HasMaxLength(100)
                .HasColumnName("ProADTMemo");
            entity.Property(e => e.ProMt).HasColumnName("ProMT");
            entity.Property(e => e.ProMtmemo)
                .HasMaxLength(100)
                .HasColumnName("ProMTMemo");
            entity.Property(e => e.ProSk).HasColumnName("ProSK");
            entity.Property(e => e.ProSkmemo)
                .HasMaxLength(100)
                .HasColumnName("ProSKMemo");
            entity.Property(e => e.PulpAdt).HasColumnName("PulpADT");
            entity.Property(e => e.PulpAdt2).HasColumnName("PulpADT2");
            entity.Property(e => e.PulpAdtmemo)
                .HasMaxLength(100)
                .HasColumnName("PulpADTMemo");
            entity.Property(e => e.PulpMt).HasColumnName("PulpMT");
            entity.Property(e => e.PulpMt2).HasColumnName("PulpMT2");
            entity.Property(e => e.PulpMtmemo)
                .HasMaxLength(100)
                .HasColumnName("PulpMTMemo");
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<EsgProdInfoYfy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgProdInfoYFY", "HC");

            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.ChpCartonMt).HasColumnName("ChpCartonMT");
            entity.Property(e => e.ChpPaperMt).HasColumnName("ChpPaperMT");
            entity.Property(e => e.ChpPulpMt).HasColumnName("ChpPulpMT");
            entity.Property(e => e.CpgcleanMt).HasColumnName("CPGCleanMT");
            entity.Property(e => e.CpghouseMt).HasColumnName("CPGHouseMT");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
            entity.Property(e => e.YpcartonMt).HasColumnName("YPCartonMT");
            entity.Property(e => e.YpproMt).HasColumnName("YPProMT");
        });

        modelBuilder.Entity<EsgRawMaterial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgRawMaterial", "HC");

            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.GnonReg).HasColumnName("GNonReg");
            entity.Property(e => e.GnonRegDesc)
                .HasMaxLength(200)
                .HasColumnName("GNonRegDesc");
            entity.Property(e => e.GnonRegDescMemo)
                .HasMaxLength(200)
                .HasColumnName("GNonRegDescMemo");
            entity.Property(e => e.GnonRegMemo)
                .HasMaxLength(200)
                .HasColumnName("GNonRegMemo");
            entity.Property(e => e.Greg).HasColumnName("GReg");
            entity.Property(e => e.GregDesc)
                .HasMaxLength(200)
                .HasColumnName("GRegDesc");
            entity.Property(e => e.GregDescMemo)
                .HasMaxLength(200)
                .HasColumnName("GRegDescMemo");
            entity.Property(e => e.GregMemo)
                .HasMaxLength(200)
                .HasColumnName("GRegMemo");
            entity.Property(e => e.Mct).HasColumnName("MCt");
            entity.Property(e => e.MctMemo)
                .HasMaxLength(200)
                .HasColumnName("MCtMemo");
            entity.Property(e => e.Mpulp).HasColumnName("MPulp");
            entity.Property(e => e.MpulpMemo)
                .HasMaxLength(200)
                .HasColumnName("MPulpMemo");
            entity.Property(e => e.Mstarch).HasColumnName("MStarch");
            entity.Property(e => e.MstarchMemo)
                .HasMaxLength(200)
                .HasColumnName("MStarchMemo");
            entity.Property(e => e.Mwood).HasColumnName("MWood");
            entity.Property(e => e.MwoodMemo)
                .HasMaxLength(200)
                .HasColumnName("MWoodMemo");
            entity.Property(e => e.Mwp).HasColumnName("MWp");
            entity.Property(e => e.MwpC).HasColumnName("MWpC");
            entity.Property(e => e.MwpCmemo)
                .HasMaxLength(200)
                .HasColumnName("MWpCMemo");
            entity.Property(e => e.MwpMemo)
                .HasMaxLength(200)
                .HasColumnName("MWpMemo");
            entity.Property(e => e.MwpW).HasColumnName("MWpW");
            entity.Property(e => e.MwpWmemo)
                .HasMaxLength(200)
                .HasColumnName("MWpWMemo");
            entity.Property(e => e.OpName).HasMaxLength(100);
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OtMdesc)
                .HasMaxLength(200)
                .HasColumnName("OtMDesc");
            entity.Property(e => e.OtMdescMemo)
                .HasMaxLength(200)
                .HasColumnName("OtMDescMemo");
            entity.Property(e => e.OtMmemo)
                .HasMaxLength(200)
                .HasColumnName("OtMMemo");
            entity.Property(e => e.PackMetalMemo).HasMaxLength(200);
            entity.Property(e => e.PackPaperMemo).HasMaxLength(200);
            entity.Property(e => e.PackPlasticMemo).HasMaxLength(200);
            entity.Property(e => e.SubIsaltMemo).HasMaxLength(200);
            entity.Property(e => e.SubLimeMemo).HasMaxLength(200);
            entity.Property(e => e.SubMsMemo).HasMaxLength(200);
            entity.Property(e => e.SubOtDesc).HasMaxLength(200);
            entity.Property(e => e.SubOtDescMemo).HasMaxLength(200);
            entity.Property(e => e.SubOtMemo).HasMaxLength(200);
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<EsgUserAuth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgUserAuth", "HC");

            entity.Property(e => e.CMemo).HasColumnName("cMemo");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UserId)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<EsgWaste>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgWaste", "HC");

            entity.Property(e => e.AaltSum).HasColumnName("AAltSum");
            entity.Property(e => e.AburnSum).HasColumnName("ABurnSum");
            entity.Property(e => e.AburySum).HasColumnName("ABurySum");
            entity.Property(e => e.Adesc)
                .HasMaxLength(100)
                .HasColumnName("ADesc");
            entity.Property(e => e.AdisposeSum).HasColumnName("ADisposeSum");
            entity.Property(e => e.AfdAlt).HasColumnName("AFdAlt");
            entity.Property(e => e.AfdBurn).HasColumnName("AFdBurn");
            entity.Property(e => e.AfdBury).HasColumnName("AFdBury");
            entity.Property(e => e.AfdOt).HasColumnName("AFdOt");
            entity.Property(e => e.AfdRec).HasColumnName("AFdRec");
            entity.Property(e => e.AfdReuse).HasColumnName("AFdReuse");
            entity.Property(e => e.AfdSum).HasColumnName("AFdSum");
            entity.Property(e => e.AosAlt).HasColumnName("AOsAlt");
            entity.Property(e => e.AosBurn).HasColumnName("AOsBurn");
            entity.Property(e => e.AosBury).HasColumnName("AOsBury");
            entity.Property(e => e.AosOt).HasColumnName("AOsOt");
            entity.Property(e => e.AosRec).HasColumnName("AOsRec");
            entity.Property(e => e.AosReuse).HasColumnName("AOsReuse");
            entity.Property(e => e.AosSum).HasColumnName("AOsSum");
            entity.Property(e => e.AotSum).HasColumnName("AOtSum");
            entity.Property(e => e.ArecSum).HasColumnName("ARecSum");
            entity.Property(e => e.AreuseSum).HasColumnName("AReuseSum");
            entity.Property(e => e.AselfAlt).HasColumnName("ASelfAlt");
            entity.Property(e => e.AselfBurn).HasColumnName("ASelfBurn");
            entity.Property(e => e.AselfBury).HasColumnName("ASelfBury");
            entity.Property(e => e.AselfOt).HasColumnName("ASelfOt");
            entity.Property(e => e.AselfRec).HasColumnName("ASelfRec");
            entity.Property(e => e.AselfReuse).HasColumnName("ASelfReuse");
            entity.Property(e => e.AselfSum).HasColumnName("ASelfSum");
            entity.Property(e => e.Asum).HasColumnName("ASum");
            entity.Property(e => e.AtransSum).HasColumnName("ATransSum");
            entity.Property(e => e.BaltSum).HasColumnName("BAltSum");
            entity.Property(e => e.BburnSum).HasColumnName("BBurnSum");
            entity.Property(e => e.BburySum).HasColumnName("BBurySum");
            entity.Property(e => e.Bdesc)
                .HasMaxLength(100)
                .HasColumnName("BDesc");
            entity.Property(e => e.BdisposeSum).HasColumnName("BDisposeSum");
            entity.Property(e => e.BfdAlt).HasColumnName("BFdAlt");
            entity.Property(e => e.BfdBurn).HasColumnName("BFdBurn");
            entity.Property(e => e.BfdBury).HasColumnName("BFdBury");
            entity.Property(e => e.BfdOt).HasColumnName("BFdOt");
            entity.Property(e => e.BfdRec).HasColumnName("BFdRec");
            entity.Property(e => e.BfdReuse).HasColumnName("BFdReuse");
            entity.Property(e => e.BfdSum).HasColumnName("BFdSum");
            entity.Property(e => e.BosAlt).HasColumnName("BOsAlt");
            entity.Property(e => e.BosBurn).HasColumnName("BOsBurn");
            entity.Property(e => e.BosBury).HasColumnName("BOsBury");
            entity.Property(e => e.BosOt).HasColumnName("BOsOt");
            entity.Property(e => e.BosRec).HasColumnName("BOsRec");
            entity.Property(e => e.BosReuse).HasColumnName("BOsReuse");
            entity.Property(e => e.BosSum).HasColumnName("BOsSum");
            entity.Property(e => e.BotSum).HasColumnName("BOtSum");
            entity.Property(e => e.BrecSum).HasColumnName("BRecSum");
            entity.Property(e => e.BreuseSum).HasColumnName("BReuseSum");
            entity.Property(e => e.BselfAlt).HasColumnName("BSelfAlt");
            entity.Property(e => e.BselfBurn).HasColumnName("BSelfBurn");
            entity.Property(e => e.BselfBury).HasColumnName("BSelfBury");
            entity.Property(e => e.BselfOt).HasColumnName("BSelfOt");
            entity.Property(e => e.BselfRec).HasColumnName("BSelfRec");
            entity.Property(e => e.BselfReuse).HasColumnName("BSelfReuse");
            entity.Property(e => e.BselfSum).HasColumnName("BSelfSum");
            entity.Property(e => e.Bsum).HasColumnName("BSum");
            entity.Property(e => e.BtransSum).HasColumnName("BTransSum");
            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.CaltSum).HasColumnName("CAltSum");
            entity.Property(e => e.CburnSum).HasColumnName("CBurnSum");
            entity.Property(e => e.CburySum).HasColumnName("CBurySum");
            entity.Property(e => e.Cdesc)
                .HasMaxLength(100)
                .HasColumnName("CDesc");
            entity.Property(e => e.CdisposeSum).HasColumnName("CDisposeSum");
            entity.Property(e => e.CfdAlt).HasColumnName("CFdAlt");
            entity.Property(e => e.CfdBurn).HasColumnName("CFdBurn");
            entity.Property(e => e.CfdBury).HasColumnName("CFdBury");
            entity.Property(e => e.CfdOt).HasColumnName("CFdOt");
            entity.Property(e => e.CfdRec).HasColumnName("CFdRec");
            entity.Property(e => e.CfdReuse).HasColumnName("CFdReuse");
            entity.Property(e => e.CfdSum).HasColumnName("CFdSum");
            entity.Property(e => e.CosAlt).HasColumnName("COsAlt");
            entity.Property(e => e.CosBurn).HasColumnName("COsBurn");
            entity.Property(e => e.CosBury).HasColumnName("COsBury");
            entity.Property(e => e.CosOt).HasColumnName("COsOt");
            entity.Property(e => e.CosRec).HasColumnName("COsRec");
            entity.Property(e => e.CosReuse).HasColumnName("COsReuse");
            entity.Property(e => e.CosSum).HasColumnName("COsSum");
            entity.Property(e => e.CotSum).HasColumnName("COtSum");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.CrecSum).HasColumnName("CRecSum");
            entity.Property(e => e.CreuseSum).HasColumnName("CReuseSum");
            entity.Property(e => e.CselfAlt).HasColumnName("CSelfAlt");
            entity.Property(e => e.CselfBurn).HasColumnName("CSelfBurn");
            entity.Property(e => e.CselfBury).HasColumnName("CSelfBury");
            entity.Property(e => e.CselfOt).HasColumnName("CSelfOt");
            entity.Property(e => e.CselfRec).HasColumnName("CSelfRec");
            entity.Property(e => e.CselfReuse).HasColumnName("CSelfReuse");
            entity.Property(e => e.CselfSum).HasColumnName("CSelfSum");
            entity.Property(e => e.Csum).HasColumnName("CSum");
            entity.Property(e => e.CtransSum).HasColumnName("CTransSum");
            entity.Property(e => e.DaltSum).HasColumnName("DAltSum");
            entity.Property(e => e.DburnSum).HasColumnName("DBurnSum");
            entity.Property(e => e.DburySum).HasColumnName("DBurySum");
            entity.Property(e => e.Ddesc)
                .HasMaxLength(100)
                .HasColumnName("DDesc");
            entity.Property(e => e.DdisposeSum).HasColumnName("DDisposeSum");
            entity.Property(e => e.DfdAlt).HasColumnName("DFdAlt");
            entity.Property(e => e.DfdBurn).HasColumnName("DFdBurn");
            entity.Property(e => e.DfdBury).HasColumnName("DFdBury");
            entity.Property(e => e.DfdOt).HasColumnName("DFdOt");
            entity.Property(e => e.DfdRec).HasColumnName("DFdRec");
            entity.Property(e => e.DfdReuse).HasColumnName("DFdReuse");
            entity.Property(e => e.DfdSum).HasColumnName("DFdSum");
            entity.Property(e => e.DosAlt).HasColumnName("DOsAlt");
            entity.Property(e => e.DosBurn).HasColumnName("DOsBurn");
            entity.Property(e => e.DosBury).HasColumnName("DOsBury");
            entity.Property(e => e.DosOt).HasColumnName("DOsOt");
            entity.Property(e => e.DosRec).HasColumnName("DOsRec");
            entity.Property(e => e.DosReuse).HasColumnName("DOsReuse");
            entity.Property(e => e.DosSum).HasColumnName("DOsSum");
            entity.Property(e => e.DotSum).HasColumnName("DOtSum");
            entity.Property(e => e.DrecSum).HasColumnName("DRecSum");
            entity.Property(e => e.DreuseSum).HasColumnName("DReuseSum");
            entity.Property(e => e.DselfAlt).HasColumnName("DSelfAlt");
            entity.Property(e => e.DselfBurn).HasColumnName("DSelfBurn");
            entity.Property(e => e.DselfBury).HasColumnName("DSelfBury");
            entity.Property(e => e.DselfOt).HasColumnName("DSelfOt");
            entity.Property(e => e.DselfRec).HasColumnName("DSelfRec");
            entity.Property(e => e.DselfReuse).HasColumnName("DSelfReuse");
            entity.Property(e => e.DselfSum).HasColumnName("DSelfSum");
            entity.Property(e => e.Dsum).HasColumnName("DSum");
            entity.Property(e => e.DtransSum).HasColumnName("DTransSum");
            entity.Property(e => e.EaltSum)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EAltSum");
            entity.Property(e => e.EburnSum)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EBurnSum");
            entity.Property(e => e.EburySum)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EBurySum");
            entity.Property(e => e.Edesc)
                .HasMaxLength(100)
                .HasColumnName("EDesc");
            entity.Property(e => e.EdisposeSum)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EDisposeSum");
            entity.Property(e => e.EfdAlt)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EFdAlt");
            entity.Property(e => e.EfdBurn)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EFdBurn");
            entity.Property(e => e.EfdBury)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EFdBury");
            entity.Property(e => e.EfdOt)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EFdOt");
            entity.Property(e => e.EfdRec)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EFdRec");
            entity.Property(e => e.EfdReuse)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EFdReuse");
            entity.Property(e => e.EfdSum)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EFdSum");
            entity.Property(e => e.EosAlt)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EOsAlt");
            entity.Property(e => e.EosBurn)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EOsBurn");
            entity.Property(e => e.EosBury)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EOsBury");
            entity.Property(e => e.EosOt)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EOsOt");
            entity.Property(e => e.EosRec)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EOsRec");
            entity.Property(e => e.EosReuse)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EOsReuse");
            entity.Property(e => e.EosSum)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EOsSum");
            entity.Property(e => e.EotSum)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EOtSum");
            entity.Property(e => e.ErecSum)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ERecSum");
            entity.Property(e => e.EreuseSum)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("EReuseSum");
            entity.Property(e => e.EselfAlt)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ESelfAlt");
            entity.Property(e => e.EselfBurn)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ESelfBurn");
            entity.Property(e => e.EselfBury)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ESelfBury");
            entity.Property(e => e.EselfOt)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ESelfOt");
            entity.Property(e => e.EselfRec)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ESelfRec");
            entity.Property(e => e.EselfReuse)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ESelfReuse");
            entity.Property(e => e.EselfSum)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ESelfSum");
            entity.Property(e => e.Esum)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ESum");
            entity.Property(e => e.EtransSum)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("ETransSum");
            entity.Property(e => e.OpName).HasMaxLength(100);
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<EsgWaterRe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EsgWaterRes", "HC");

            entity.Property(e => e.ActAn).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ActAnMemo).HasMaxLength(100);
            entity.Property(e => e.ActBod).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ActBodMemo).HasMaxLength(100);
            entity.Property(e => e.ActCod).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ActCodMemo).HasMaxLength(100);
            entity.Property(e => e.ActCodTotal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ActCodTotalMemo).HasMaxLength(100);
            entity.Property(e => e.ActDio).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ActDioMemo).HasMaxLength(100);
            entity.Property(e => e.ActSs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ActSsMemo).HasMaxLength(100);
            entity.Property(e => e.ActStoredMemo).HasMaxLength(100);
            entity.Property(e => e.ActTcc).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ActTccMemo).HasMaxLength(100);
            entity.Property(e => e.CYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cYear");
            entity.Property(e => e.ColDisYn)
                .HasMaxLength(100)
                .HasColumnName("ColDisYN");
            entity.Property(e => e.ColDisYnmemo)
                .HasMaxLength(100)
                .HasColumnName("ColDisYNMemo");
            entity.Property(e => e.ColLoc).HasMaxLength(100);
            entity.Property(e => e.ColLocMemo).HasMaxLength(100);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasMaxLength(30);
            entity.Property(e => e.CustAnMemo).HasMaxLength(100);
            entity.Property(e => e.CustBase).HasMaxLength(120);
            entity.Property(e => e.CustBaseMemo).HasMaxLength(100);
            entity.Property(e => e.CustBodMemo).HasMaxLength(100);
            entity.Property(e => e.CustCodMemo).HasMaxLength(100);
            entity.Property(e => e.CustDioMemo).HasMaxLength(100);
            entity.Property(e => e.CustSsMemo).HasMaxLength(100);
            entity.Property(e => e.CustStdDaysMemo).HasMaxLength(100);
            entity.Property(e => e.CustTccMemo).HasMaxLength(100);
            entity.Property(e => e.CwCoolTowerMemo).HasMaxLength(100);
            entity.Property(e => e.CwInsideMemo).HasMaxLength(100);
            entity.Property(e => e.CwRecycledMemo).HasMaxLength(100);
            entity.Property(e => e.CwTotalMemo).HasMaxLength(100);
            entity.Property(e => e.Deg1stMemo).HasMaxLength(100);
            entity.Property(e => e.Deg2ndMemo).HasMaxLength(100);
            entity.Property(e => e.Deg3rdMemo).HasMaxLength(100);
            entity.Property(e => e.DegNonMemo).HasMaxLength(100);
            entity.Property(e => e.DrReleaseMemo).HasMaxLength(100);
            entity.Property(e => e.DrSewageMemo).HasMaxLength(100);
            entity.Property(e => e.DrThridMemo).HasMaxLength(100);
            entity.Property(e => e.EexLoc).HasMaxLength(100);
            entity.Property(e => e.EexLocMemo).HasMaxLength(100);
            entity.Property(e => e.Mang01Desc).HasMaxLength(100);
            entity.Property(e => e.Mang01DescMemo).HasMaxLength(100);
            entity.Property(e => e.Mang02Desc).HasMaxLength(100);
            entity.Property(e => e.Mang02DescMemo).HasMaxLength(100);
            entity.Property(e => e.Mang03Desc).HasMaxLength(100);
            entity.Property(e => e.Mang03DescMemo).HasMaxLength(100);
            entity.Property(e => e.Mang04Desc).HasMaxLength(100);
            entity.Property(e => e.Mang04DescMemo).HasMaxLength(100);
            entity.Property(e => e.Mang05Desc).HasMaxLength(100);
            entity.Property(e => e.Mang05DescMemo).HasMaxLength(100);
            entity.Property(e => e.Mang06Desc).HasMaxLength(100);
            entity.Property(e => e.Mang06DescMemo).HasMaxLength(100);
            entity.Property(e => e.Mang07Desc).HasMaxLength(100);
            entity.Property(e => e.Mang07DescMemo).HasMaxLength(100);
            entity.Property(e => e.Mang08Desc).HasMaxLength(100);
            entity.Property(e => e.Mang08DescMemo).HasMaxLength(100);
            entity.Property(e => e.Mang09Desc).HasMaxLength(100);
            entity.Property(e => e.Mang09DescMemo).HasMaxLength(100);
            entity.Property(e => e.Mang10Desc).HasMaxLength(100);
            entity.Property(e => e.Mang10DescMemo).HasMaxLength(100);
            entity.Property(e => e.MaxStoredMemo).HasMaxLength(100);
            entity.Property(e => e.OpName).HasMaxLength(100);
            entity.Property(e => e.OrgCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.R1).HasColumnType("decimal(5, 1)");
            entity.Property(e => e.R1memo)
                .HasMaxLength(100)
                .HasColumnName("R1Memo");
            entity.Property(e => e.R2).HasColumnType("decimal(5, 1)");
            entity.Property(e => e.R2memo)
                .HasMaxLength(100)
                .HasColumnName("R2Memo");
            entity.Property(e => e.R3).HasColumnType("decimal(5, 1)");
            entity.Property(e => e.R3memo)
                .HasMaxLength(100)
                .HasColumnName("R3Memo");
            entity.Property(e => e.R4).HasColumnType("decimal(5, 1)");
            entity.Property(e => e.R4memo)
                .HasMaxLength(100)
                .HasColumnName("R4Memo");
            entity.Property(e => e.RecycledTotalMemo).HasMaxLength(100);
            entity.Property(e => e.RegAnMemo).HasMaxLength(100);
            entity.Property(e => e.RegBodMemo).HasMaxLength(100);
            entity.Property(e => e.RegCodMemo).HasMaxLength(100);
            entity.Property(e => e.RegDioMemo).HasMaxLength(100);
            entity.Property(e => e.RegSsMemo).HasMaxLength(100);
            entity.Property(e => e.RegTccMemo).HasMaxLength(100);
            entity.Property(e => e.ReusedTotalMemo).HasMaxLength(100);
            entity.Property(e => e.TakeExtMemo).HasMaxLength(100);
            entity.Property(e => e.TakeGroundNr).HasColumnName("TakeGroundNR");
            entity.Property(e => e.TakeGroundNrmemo)
                .HasMaxLength(100)
                .HasColumnName("TakeGroundNRMemo");
            entity.Property(e => e.TakeGroundRmemo)
                .HasMaxLength(100)
                .HasColumnName("TakeGroundRMemo");
            entity.Property(e => e.TakeRainMemo).HasMaxLength(100);
            entity.Property(e => e.TakeSurfaceMemo).HasMaxLength(100);
            entity.Property(e => e.TakeTapMemo).HasMaxLength(100);
            entity.Property(e => e.TransDate).HasColumnType("datetime");
            entity.Property(e => e.TransUser).HasMaxLength(30);
        });

        modelBuilder.Entity<MaiAgentContact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PK__MaiAgent__5C6625BBC8E803A2");

            entity.ToTable("MaiAgentContact", "Base");

            entity.HasIndex(e => e.UserId, "IX_MaiAgentContact_UserID");

            entity.Property(e => e.ContactId)
                .ValueGeneratedNever()
                .HasColumnName("ContactID");
            entity.Property(e => e.UserId)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
