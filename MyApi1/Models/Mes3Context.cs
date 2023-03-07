using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyApi1.Models;

public partial class Mes3Context : DbContext
{
    public Mes3Context()
    {
    }

    public Mes3Context(DbContextOptions<Mes3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Box> Boxes { get; set; }

    public virtual DbSet<Box1> Boxes1 { get; set; }

    public virtual DbSet<Boxlog> Boxlogs { get; set; }

    public virtual DbSet<Boxlog1> Boxlogs1 { get; set; }

    public virtual DbSet<Boxpart> Boxparts { get; set; }

    public virtual DbSet<Boxpart1> Boxparts1 { get; set; }

    public virtual DbSet<Carton> Cartons { get; set; }

    public virtual DbSet<Carton1> Cartons1 { get; set; }

    public virtual DbSet<Ct> Cts { get; set; }

    public virtual DbSet<Ct1> Cts1 { get; set; }

    public virtual DbSet<Decision> Decisions { get; set; }

    public virtual DbSet<Decision1> Decisions1 { get; set; }

    public virtual DbSet<Dn> Dns { get; set; }

    public virtual DbSet<Dn1> Dns1 { get; set; }

    public virtual DbSet<Dnlog> Dnlogs { get; set; }

    public virtual DbSet<Dnlog1> Dnlogs1 { get; set; }

    public virtual DbSet<Lcpmachinestatus> Lcpmachinestatuses { get; set; }

    public virtual DbSet<Lcpmachinestatus1> Lcpmachinestatuses1 { get; set; }

    public virtual DbSet<Pallet> Pallets { get; set; }

    public virtual DbSet<Pallet1> Pallets1 { get; set; }

    public virtual DbSet<Polog> Pologs { get; set; }

    public virtual DbSet<Polog1> Pologs1 { get; set; }

    public virtual DbSet<Postatus> Postatuses { get; set; }

    public virtual DbSet<Postatus1> Postatuses1 { get; set; }

    public virtual DbSet<Printlog> Printlogs { get; set; }

    public virtual DbSet<Printlog1> Printlogs1 { get; set; }

    public virtual DbSet<Releaseorder> Releaseorders { get; set; }

    public virtual DbSet<Releaseorder1> Releaseorders1 { get; set; }

    public virtual DbSet<Seal> Seals { get; set; }

    public virtual DbSet<Seal1> Seals1 { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<Setting1> Settings1 { get; set; }

    public virtual DbSet<Snseq> Snseqs { get; set; }

    public virtual DbSet<Terminal> Terminals { get; set; }

    public virtual DbSet<Terminal1> Terminals1 { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<Unit1> Units1 { get; set; }

    public virtual DbSet<Unitdefect> Unitdefects { get; set; }

    public virtual DbSet<Unitdefect1> Unitdefects1 { get; set; }

    public virtual DbSet<Unitdefectrepair> Unitdefectrepairs { get; set; }

    public virtual DbSet<Unitdefectrepair1> Unitdefectrepairs1 { get; set; }

    public virtual DbSet<Unitlog> Unitlogs { get; set; }

    public virtual DbSet<Unitlog1> Unitlogs1 { get; set; }

    public virtual DbSet<Unitpart> Unitparts { get; set; }

    public virtual DbSet<Unitpart1> Unitparts1 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(" server=SQT-COMM-DB.ipt.inventec.net,1433;Database=MES3;User=MES3_User;Password=Mes@Passw0rd.#$;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Box>(entity =>
        {
            entity.HasKey(e => e.Boxno).HasName("pk_box");

            entity.ToTable("box");

            entity.Property(e => e.Boxno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("boxno");
            entity.Property(e => e.Cartoncode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cartoncode");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Inspecting).HasColumnName("inspecting");
            entity.Property(e => e.Linecode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("linecode");
            entity.Property(e => e.Modelcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modelcode");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Packqty).HasColumnName("packqty");
            entity.Property(e => e.Partstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("partstatus");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('open')")
                .HasColumnName("status");
            entity.Property(e => e.Udt).HasColumnName("udt");
            entity.Property(e => e.Units).HasColumnName("units");
        });

        modelBuilder.Entity<Box1>(entity =>
        {
            entity.HasKey(e => e.Boxno).HasName("pk_box");

            entity.ToTable("box", "stress");

            entity.Property(e => e.Boxno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("boxno");
            entity.Property(e => e.Cartoncode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cartoncode");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Inspecting).HasColumnName("inspecting");
            entity.Property(e => e.Linecode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("linecode");
            entity.Property(e => e.Modelcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modelcode");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Packqty).HasColumnName("packqty");
            entity.Property(e => e.Partstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("partstatus");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('open')")
                .HasColumnName("status");
            entity.Property(e => e.Udt).HasColumnName("udt");
            entity.Property(e => e.Units).HasColumnName("units");
        });

        modelBuilder.Entity<Boxlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_boxlog");

            entity.ToTable("boxlog");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Boxno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("boxno");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Detail).HasColumnName("detail");
            entity.Property(e => e.Inputtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('auto')")
                .HasColumnName("inputtype");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Result)
                .HasDefaultValueSql("((1))")
                .HasColumnName("result");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Traceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("traceid");
            entity.Property(e => e.Transaction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transaction");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Boxlog1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_boxlog");

            entity.ToTable("boxlog", "stress");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Boxno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("boxno");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Detail).HasColumnName("detail");
            entity.Property(e => e.Inputtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('auto')")
                .HasColumnName("inputtype");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Result)
                .HasDefaultValueSql("((1))")
                .HasColumnName("result");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Traceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("traceid");
            entity.Property(e => e.Transaction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transaction");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Boxpart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_boxpart");

            entity.ToTable("boxpart");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("action");
            entity.Property(e => e.Attribute).HasColumnName("attribute");
            entity.Property(e => e.Boxno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("boxno");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Commodity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("commodity");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Partsn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("partsn");
            entity.Property(e => e.Parttype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parttype");
            entity.Property(e => e.Pn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pn");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasColumnName("remark");
            entity.Property(e => e.Scanpn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("scanpn");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Traceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("traceid");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Boxpart1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_boxpart");

            entity.ToTable("boxpart", "stress");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("action");
            entity.Property(e => e.Attribute).HasColumnName("attribute");
            entity.Property(e => e.Boxno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("boxno");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Commodity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("commodity");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Partsn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("partsn");
            entity.Property(e => e.Parttype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parttype");
            entity.Property(e => e.Pn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pn");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasColumnName("remark");
            entity.Property(e => e.Scanpn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("scanpn");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Traceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("traceid");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Carton>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_carton");

            entity.ToTable("carton");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Base).HasColumnName("base");
            entity.Property(e => e.Boxno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("boxno");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Innerbox)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("innerbox");
            entity.Property(e => e.Inspecting).HasColumnName("inspecting");
            entity.Property(e => e.Midbox)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("midbox");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('initial')")
                .HasColumnName("status");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Carton1>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_carton");

            entity.ToTable("carton", "stress");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Base).HasColumnName("base");
            entity.Property(e => e.Boxno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("boxno");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Innerbox)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("innerbox");
            entity.Property(e => e.Inspecting).HasColumnName("inspecting");
            entity.Property(e => e.Midbox)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("midbox");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('initial')")
                .HasColumnName("status");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Ct>(entity =>
        {
            entity.HasKey(e => e.Ctsn).HasName("pk_ct");

            entity.ToTable("ct");

            entity.Property(e => e.Ctsn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ctsn");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Commodity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("commodity");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Pn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pn");
            entity.Property(e => e.Pocode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pocode");
            entity.Property(e => e.Sparepn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sparepn");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('open')")
                .HasColumnName("status");
            entity.Property(e => e.Supplier)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("supplier");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Warrantycode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("warrantycode");
        });

        modelBuilder.Entity<Ct1>(entity =>
        {
            entity.HasKey(e => e.Ctsn).HasName("pk_ct");

            entity.ToTable("ct", "stress");

            entity.Property(e => e.Ctsn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ctsn");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Commodity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("commodity");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Pn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pn");
            entity.Property(e => e.Pocode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pocode");
            entity.Property(e => e.Sparepn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sparepn");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('open')")
                .HasColumnName("status");
            entity.Property(e => e.Supplier)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("supplier");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Warrantycode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("warrantycode");
        });

        modelBuilder.Entity<Decision>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_decision");

            entity.ToTable("decision");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Customer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("customer");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Param).HasColumnName("param");
            entity.Property(e => e.Project)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("project");
            entity.Property(e => e.Rev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rev");
            entity.Property(e => e.Stage)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stage");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Decision1>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_decision");

            entity.ToTable("decision", "stress");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Customer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("customer");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Param).HasColumnName("param");
            entity.Property(e => e.Project)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("project");
            entity.Property(e => e.Rev)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rev");
            entity.Property(e => e.Stage)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stage");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Dn>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_dn");

            entity.ToTable("dn");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Ishold).HasColumnName("ishold");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Process).HasColumnName("process");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('initial')")
                .HasColumnName("status");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Dn1>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_dn");

            entity.ToTable("dn", "stress");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Ishold).HasColumnName("ishold");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Process).HasColumnName("process");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('initial')")
                .HasColumnName("status");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Dnlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dnlog");

            entity.ToTable("dnlog");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Detail).HasColumnName("detail");
            entity.Property(e => e.Dncode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dncode");
            entity.Property(e => e.Inputtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('auto')")
                .HasColumnName("inputtype");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Result)
                .HasDefaultValueSql("((1))")
                .HasColumnName("result");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Traceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("traceid");
            entity.Property(e => e.Transaction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transaction");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Dnlog1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_dnlog");

            entity.ToTable("dnlog", "stress");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Detail).HasColumnName("detail");
            entity.Property(e => e.Dncode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dncode");
            entity.Property(e => e.Inputtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('auto')")
                .HasColumnName("inputtype");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Result)
                .HasDefaultValueSql("((1))")
                .HasColumnName("result");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Traceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("traceid");
            entity.Property(e => e.Transaction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transaction");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Lcpmachinestatus>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_lcpmachinestatus");

            entity.ToTable("lcpmachinestatus");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Basicpressure).HasColumnName("basicpressure");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Unit).HasColumnName("unit");
        });

        modelBuilder.Entity<Lcpmachinestatus1>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_lcpmachinestatus");

            entity.ToTable("lcpmachinestatus", "stress");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Basicpressure).HasColumnName("basicpressure");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Unit).HasColumnName("unit");
        });

        modelBuilder.Entity<Pallet>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_pallet");

            entity.ToTable("pallet");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Base).HasColumnName("base");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Dimension).HasColumnName("dimension");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('initial')")
                .HasColumnName("status");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Udt).HasColumnName("udt");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<Pallet1>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_pallet");

            entity.ToTable("pallet", "stress");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Base).HasColumnName("base");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Dimension).HasColumnName("dimension");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('initial')")
                .HasColumnName("status");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Udt).HasColumnName("udt");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<Polog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_polog");

            entity.ToTable("polog");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Detail).HasColumnName("detail");
            entity.Property(e => e.Inputtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('auto')")
                .HasColumnName("inputtype");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Result)
                .HasDefaultValueSql("((1))")
                .HasColumnName("result");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Transaction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transaction");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Polog1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_polog");

            entity.ToTable("polog", "stress");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Detail).HasColumnName("detail");
            entity.Property(e => e.Inputtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('auto')")
                .HasColumnName("inputtype");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Result)
                .HasDefaultValueSql("((1))")
                .HasColumnName("result");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Transaction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transaction");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Postatus>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_postatus");

            entity.ToTable("postatus");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Base).HasColumnName("base");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Printstatus).HasColumnName("printstatus");
            entity.Property(e => e.Process).HasColumnName("process");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Postatus1>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_postatus");

            entity.ToTable("postatus", "stress");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Base).HasColumnName("base");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Printstatus).HasColumnName("printstatus");
            entity.Property(e => e.Process).HasColumnName("process");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Printlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_printlog");

            entity.ToTable("printlog");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Dn)
                .IsUnicode(false)
                .HasColumnName("dn");
            entity.Property(e => e.Input).HasColumnName("input");
            entity.Property(e => e.Isreprint).HasColumnName("isreprint");
            entity.Property(e => e.Key)
                .IsUnicode(false)
                .HasColumnName("key");
            entity.Property(e => e.Keytype)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("keytype");
            entity.Property(e => e.Labelid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("labelid");
            entity.Property(e => e.Labeltype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("labeltype");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Output).HasColumnName("output");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Printlog1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_printlog");

            entity.ToTable("printlog", "stress");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Dn)
                .IsUnicode(false)
                .HasColumnName("dn");
            entity.Property(e => e.Input).HasColumnName("input");
            entity.Property(e => e.Isreprint).HasColumnName("isreprint");
            entity.Property(e => e.Key)
                .IsUnicode(false)
                .HasColumnName("key");
            entity.Property(e => e.Keytype)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("keytype");
            entity.Property(e => e.Labelid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("labelid");
            entity.Property(e => e.Labeltype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("labeltype");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Output).HasColumnName("output");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Releaseorder>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_releaseorder");

            entity.ToTable("releaseorder");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Driver)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("driver");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Truckid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("truckid");
            entity.Property(e => e.Trucktype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("trucktype");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Releaseorder1>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_releaseorder");

            entity.ToTable("releaseorder", "stress");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Driver)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("driver");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Truckid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("truckid");
            entity.Property(e => e.Trucktype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("trucktype");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Seal>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_seal");

            entity.ToTable("seal");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Base).HasColumnName("base");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Gpsid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gpsid");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Releaseordercode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("releaseordercode");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('initial')")
                .HasColumnName("status");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Truckid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("truckid");
            entity.Property(e => e.Trucktype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("trucktype");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Seal1>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_seal");

            entity.ToTable("seal", "stress");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Base).HasColumnName("base");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Gpsid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gpsid");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Releaseordercode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("releaseordercode");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('initial')")
                .HasColumnName("status");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Truckid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("truckid");
            entity.Property(e => e.Trucktype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("trucktype");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.Datatype).HasName("pk_setting");

            entity.ToTable("setting");

            entity.Property(e => e.Datatype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("datatype");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Setting1>(entity =>
        {
            entity.HasKey(e => e.Datatype).HasName("pk_setting");

            entity.ToTable("setting", "stress");

            entity.Property(e => e.Datatype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("datatype");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Snseq>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_snseq");

            entity.ToTable("snseq");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Prefix)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prefix");
            entity.Property(e => e.Seq)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("seq");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Terminal>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_terminal");

            entity.ToTable("terminal");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Line).HasColumnName("line");
            entity.Property(e => e.Linecode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("linecode");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Setting).HasColumnName("setting");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Terminal1>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("pk_terminal");

            entity.ToTable("terminal", "stress");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Line).HasColumnName("line");
            entity.Property(e => e.Linecode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("linecode");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Setting).HasColumnName("setting");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.Sn).HasName("pk_unit");

            entity.ToTable("unit");

            entity.Property(e => e.Sn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sn");
            entity.Property(e => e.Attribute).HasColumnName("attribute");
            entity.Property(e => e.Boxno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("boxno");
            entity.Property(e => e.Cartoncode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cartoncode");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Child).HasColumnName("child");
            entity.Property(e => e.Custattribute).HasColumnName("custattribute");
            entity.Property(e => e.Dncode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dncode");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Parent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parent");
            entity.Property(e => e.Pocode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pocode");
            entity.Property(e => e.Runtime).HasColumnName("runtime");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('msn')")
                .HasColumnName("type");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Unit1>(entity =>
        {
            entity.HasKey(e => e.Sn).HasName("pk_unit");

            entity.ToTable("unit", "stress");

            entity.Property(e => e.Sn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sn");
            entity.Property(e => e.Attribute).HasColumnName("attribute");
            entity.Property(e => e.Boxno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("boxno");
            entity.Property(e => e.Cartoncode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cartoncode");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Child).HasColumnName("child");
            entity.Property(e => e.Custattribute).HasColumnName("custattribute");
            entity.Property(e => e.Dncode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dncode");
            entity.Property(e => e.Index).HasColumnName("index");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Parent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parent");
            entity.Property(e => e.Pocode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pocode");
            entity.Property(e => e.Runtime).HasColumnName("runtime");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('msn')")
                .HasColumnName("type");
            entity.Property(e => e.Udt).HasColumnName("udt");
        });

        modelBuilder.Entity<Unitdefect>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_unitdefect");

            entity.ToTable("unitdefect");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Defectcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("defectcode");
            entity.Property(e => e.Donewc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("donewc");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Pic).HasColumnName("pic");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasColumnName("remark");
            entity.Property(e => e.Repairer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("repairer");
            entity.Property(e => e.Repairtraceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("repairtraceid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('open')")
                .HasColumnName("status");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Testlogpath)
                .HasMaxLength(500)
                .HasColumnName("testlogpath");
            entity.Property(e => e.Traceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("traceid");
            entity.Property(e => e.Udt).HasColumnName("udt");
            entity.Property(e => e.Unitsn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unitsn");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Unitdefect1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_unitdefect");

            entity.ToTable("unitdefect", "stress");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Defectcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("defectcode");
            entity.Property(e => e.Donewc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("donewc");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Pic).HasColumnName("pic");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasColumnName("remark");
            entity.Property(e => e.Repairer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("repairer");
            entity.Property(e => e.Repairtraceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("repairtraceid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('open')")
                .HasColumnName("status");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Testlogpath)
                .HasMaxLength(500)
                .HasColumnName("testlogpath");
            entity.Property(e => e.Traceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("traceid");
            entity.Property(e => e.Udt).HasColumnName("udt");
            entity.Property(e => e.Unitsn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unitsn");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Unitdefectrepair>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_unitdefectrepair");

            entity.ToTable("unitdefectrepair");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Causecode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("causecode");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Commodity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("commodity");
            entity.Property(e => e.Correctiveaction)
                .HasMaxLength(500)
                .HasColumnName("correctiveaction");
            entity.Property(e => e.Defectcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("defectcode");
            entity.Property(e => e.Defectid).HasColumnName("defectid");
            entity.Property(e => e.Donewc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("donewc");
            entity.Property(e => e.Failpn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("failpn");
            entity.Property(e => e.Failsno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("failsno");
            entity.Property(e => e.Isfaultypart)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("isfaultypart");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Newpn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("newpn");
            entity.Property(e => e.Newsno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("newsno");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Partattribute).HasColumnName("partattribute");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasColumnName("remark");
            entity.Property(e => e.Repairaction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("repairaction");
            entity.Property(e => e.Rootcause)
                .HasMaxLength(500)
                .HasColumnName("rootcause");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('open')")
                .HasColumnName("status");
            entity.Property(e => e.Subcommodity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subcommodity");
            entity.Property(e => e.Udt).HasColumnName("udt");
            entity.Property(e => e.Unbind).HasColumnName("unbind");
        });

        modelBuilder.Entity<Unitdefectrepair1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_unitdefectrepair");

            entity.ToTable("unitdefectrepair", "stress");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Causecode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("causecode");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Commodity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("commodity");
            entity.Property(e => e.Correctiveaction)
                .HasMaxLength(500)
                .HasColumnName("correctiveaction");
            entity.Property(e => e.Defectcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("defectcode");
            entity.Property(e => e.Defectid).HasColumnName("defectid");
            entity.Property(e => e.Donewc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("donewc");
            entity.Property(e => e.Failpn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("failpn");
            entity.Property(e => e.Failsno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("failsno");
            entity.Property(e => e.Isfaultypart)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("isfaultypart");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Newpn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("newpn");
            entity.Property(e => e.Newsno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("newsno");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Partattribute).HasColumnName("partattribute");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasColumnName("remark");
            entity.Property(e => e.Repairaction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("repairaction");
            entity.Property(e => e.Rootcause)
                .HasMaxLength(500)
                .HasColumnName("rootcause");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('open')")
                .HasColumnName("status");
            entity.Property(e => e.Subcommodity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subcommodity");
            entity.Property(e => e.Udt).HasColumnName("udt");
            entity.Property(e => e.Unbind).HasColumnName("unbind");
        });

        modelBuilder.Entity<Unitlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_unitlog");

            entity.ToTable("unitlog");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Detail).HasColumnName("detail");
            entity.Property(e => e.Inputtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('auto')")
                .HasColumnName("inputtype");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Result)
                .HasDefaultValueSql("((1))")
                .HasColumnName("result");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Traceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("traceid");
            entity.Property(e => e.Transaction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transaction");
            entity.Property(e => e.Unitsn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unitsn");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Unitlog1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_unitlog");

            entity.ToTable("unitlog", "stress");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Detail).HasColumnName("detail");
            entity.Property(e => e.Inputtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('auto')")
                .HasColumnName("inputtype");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Result)
                .HasDefaultValueSql("((1))")
                .HasColumnName("result");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Traceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("traceid");
            entity.Property(e => e.Transaction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transaction");
            entity.Property(e => e.Unitsn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unitsn");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Unitpart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_unitpart");

            entity.ToTable("unitpart");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("action");
            entity.Property(e => e.Attribute).HasColumnName("attribute");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Commodity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("commodity");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Partsn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("partsn");
            entity.Property(e => e.Parttype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parttype");
            entity.Property(e => e.Pn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pn");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasColumnName("remark");
            entity.Property(e => e.Scanpn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("scanpn");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Traceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("traceid");
            entity.Property(e => e.Unitsn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unitsn");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        modelBuilder.Entity<Unitpart1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_unitpart");

            entity.ToTable("unitpart", "stress");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("action");
            entity.Property(e => e.Attribute).HasColumnName("attribute");
            entity.Property(e => e.Cdt).HasColumnName("cdt");
            entity.Property(e => e.Commodity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("commodity");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Opid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("opid");
            entity.Property(e => e.Partsn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("partsn");
            entity.Property(e => e.Parttype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parttype");
            entity.Property(e => e.Pn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pn");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .HasColumnName("remark");
            entity.Property(e => e.Scanpn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("scanpn");
            entity.Property(e => e.Terminalcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminalcode");
            entity.Property(e => e.Traceid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("traceid");
            entity.Property(e => e.Unitsn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unitsn");
            entity.Property(e => e.Wc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wc");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
