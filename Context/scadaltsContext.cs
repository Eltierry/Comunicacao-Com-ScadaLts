using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ComunicaçãoComScadaLts.Models.ScadaLtsClass
{
    public partial class scadaltsContext : DbContext
    {
        public scadaltsContext()
        {
        }

        public scadaltsContext(DbContextOptions<scadaltsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryViewsHierarchy> CategoryViewsHierarchies { get; set; } = null!;
        public virtual DbSet<Compoundeventdetector> Compoundeventdetectors { get; set; } = null!;
        public virtual DbSet<Datapoint> Datapoints { get; set; } = null!;
        public virtual DbSet<Datapointuser> Datapointusers { get; set; } = null!;
        public virtual DbSet<Datapointusersprofile> Datapointusersprofiles { get; set; } = null!;
        public virtual DbSet<Datasource> Datasources { get; set; } = null!;
        public virtual DbSet<Datasourceuser> Datasourceusers { get; set; } = null!;
        public virtual DbSet<Datasourceusersprofile> Datasourceusersprofiles { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<Eventdetectortemplate> Eventdetectortemplates { get; set; } = null!;
        public virtual DbSet<Eventhandler> Eventhandlers { get; set; } = null!;
        public virtual DbSet<Flexproject> Flexprojects { get; set; } = null!;
        public virtual DbSet<Historyalarm> Historyalarms { get; set; } = null!;
        public virtual DbSet<Livealarm> Livealarms { get; set; } = null!;
        public virtual DbSet<Mailinglist> Mailinglists { get; set; } = null!;
        public virtual DbSet<Mailinglistinactive> Mailinglistinactives { get; set; } = null!;
        public virtual DbSet<Mailinglistmember> Mailinglistmembers { get; set; } = null!;
        public virtual DbSet<Maintenanceevent> Maintenanceevents { get; set; } = null!;
        public virtual DbSet<Mangoview> Mangoviews { get; set; } = null!;
        public virtual DbSet<Mangoviewuser> Mangoviewusers { get; set; } = null!;
        public virtual DbSet<MultiChangesHistory> MultiChangesHistories { get; set; } = null!;
        public virtual DbSet<Plcalarm> Plcalarms { get; set; } = null!;
        public virtual DbSet<Pointeventdetector> Pointeventdetectors { get; set; } = null!;
        public virtual DbSet<Pointhierarchy> Pointhierarchies { get; set; } = null!;
        public virtual DbSet<Pointlink> Pointlinks { get; set; } = null!;
        public virtual DbSet<Pointvalue> Pointvalues { get; set; } = null!;
        public virtual DbSet<Pointvalueannotation> Pointvalueannotations { get; set; } = null!;
        public virtual DbSet<Publisher> Publishers { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<Reportinstance> Reportinstances { get; set; } = null!;
        public virtual DbSet<Reportinstancedataannotation> Reportinstancedataannotations { get; set; } = null!;
        public virtual DbSet<Reportinstancedatum> Reportinstancedata { get; set; } = null!;
        public virtual DbSet<Reportinstanceevent> Reportinstanceevents { get; set; } = null!;
        public virtual DbSet<Reportinstancepoint> Reportinstancepoints { get; set; } = null!;
        public virtual DbSet<Reportinstanceusercomment> Reportinstanceusercomments { get; set; } = null!;
        public virtual DbSet<Scheduledevent> Scheduledevents { get; set; } = null!;
        public virtual DbSet<Scheduledexecuteinactiveevent> Scheduledexecuteinactiveevents { get; set; } = null!;
        public virtual DbSet<SchemaVersion> SchemaVersions { get; set; } = null!;
        public virtual DbSet<Script> Scripts { get; set; } = null!;
        public virtual DbSet<Synopticpanel> Synopticpanels { get; set; } = null!;
        public virtual DbSet<Systemsetting> Systemsettings { get; set; } = null!;
        public virtual DbSet<Templatesdetector> Templatesdetectors { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Usercomment> Usercomments { get; set; } = null!;
        public virtual DbSet<Userevent> Userevents { get; set; } = null!;
        public virtual DbSet<Usersprofile> Usersprofiles { get; set; } = null!;
        public virtual DbSet<Usersusersprofile> Usersusersprofiles { get; set; } = null!;
        public virtual DbSet<ValuesMultiChangesHistory> ValuesMultiChangesHistories { get; set; } = null!;
        public virtual DbSet<ViewsCategoryViewsHierarchy> ViewsCategoryViewsHierarchies { get; set; } = null!;
        public virtual DbSet<Viewusersprofile> Viewusersprofiles { get; set; } = null!;
        public virtual DbSet<Watchlist> Watchlists { get; set; } = null!;
        public virtual DbSet<Watchlistpoint> Watchlistpoints { get; set; } = null!;
        public virtual DbSet<Watchlistuser> Watchlistusers { get; set; } = null!;
        public virtual DbSet<Watchlistusersprofile> Watchlistusersprofiles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3308;userid=root;database=scadalts", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");

            modelBuilder.Entity<CategoryViewsHierarchy>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ParentId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("category_views_hierarchy");

                entity.HasIndex(e => e.Name, "name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ParentId).HasColumnName("parentId");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Compoundeventdetector>(entity =>
            {
                entity.ToTable("compoundeventdetectors");

                entity.HasIndex(e => e.Xid, "compoundEventDetectorsUn1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AlarmLevel).HasColumnName("alarmLevel");

                entity.Property(e => e.ConditionText)
                    .HasMaxLength(256)
                    .HasColumnName("conditionText");

                entity.Property(e => e.Disabled)
                    .HasMaxLength(1)
                    .HasColumnName("disabled")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.ReturnToNormal)
                    .HasMaxLength(1)
                    .HasColumnName("returnToNormal")
                    .IsFixedLength();

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");
            });

            modelBuilder.Entity<Datapoint>(entity =>
            {
                entity.ToTable("datapoints");

                entity.HasIndex(e => e.DataSourceId, "dataPointsFk1");

                entity.HasIndex(e => e.Xid, "dataPointsUn1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.DataSourceId).HasColumnName("dataSourceId");

                entity.Property(e => e.PlcAlarmLevel)
                    .HasColumnName("plcAlarmLevel")
                    .HasComment("1 - FAULT, 2 - ALARM");

                entity.Property(e => e.PointName)
                    .HasMaxLength(250)
                    .HasColumnName("pointName")
                    .HasComment("copy point name from data");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");

                entity.HasOne(d => d.DataSource)
                    .WithMany(p => p.Datapoints)
                    .HasForeignKey(d => d.DataSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dataPointsFk1");
            });

            modelBuilder.Entity<Datapointuser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("datapointusers");

                entity.HasIndex(e => e.DataPointId, "dataPointUsersFk1");

                entity.HasIndex(e => e.UserId, "dataPointUsersFk2");

                entity.Property(e => e.DataPointId).HasColumnName("dataPointId");

                entity.Property(e => e.Permission).HasColumnName("permission");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.DataPoint)
                    .WithMany()
                    .HasForeignKey(d => d.DataPointId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dataPointUsersFk1");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("dataPointUsersFk2");
            });

            modelBuilder.Entity<Datapointusersprofile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("datapointusersprofiles");

                entity.HasIndex(e => e.DataPointId, "dataPointUsersProfilesFk1");

                entity.HasIndex(e => e.UserProfileId, "dataPointUsersProfilesFk2");

                entity.Property(e => e.DataPointId).HasColumnName("dataPointId");

                entity.Property(e => e.Permission).HasColumnName("permission");

                entity.Property(e => e.UserProfileId).HasColumnName("userProfileId");

                entity.HasOne(d => d.DataPoint)
                    .WithMany()
                    .HasForeignKey(d => d.DataPointId)
                    .HasConstraintName("dataPointUsersProfilesFk1");

                entity.HasOne(d => d.UserProfile)
                    .WithMany()
                    .HasForeignKey(d => d.UserProfileId)
                    .HasConstraintName("dataPointUsersProfilesFk2");
            });

            modelBuilder.Entity<Datasource>(entity =>
            {
                entity.ToTable("datasources");

                entity.HasIndex(e => e.Xid, "dataSourcesUn1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.DataSourceType).HasColumnName("dataSourceType");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .HasColumnName("name");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");
            });

            modelBuilder.Entity<Datasourceuser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("datasourceusers");

                entity.HasIndex(e => e.DataSourceId, "dataSourceUsersFk1");

                entity.HasIndex(e => e.UserId, "dataSourceUsersFk2");

                entity.Property(e => e.DataSourceId).HasColumnName("dataSourceId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.DataSource)
                    .WithMany()
                    .HasForeignKey(d => d.DataSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dataSourceUsersFk1");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("dataSourceUsersFk2");
            });

            modelBuilder.Entity<Datasourceusersprofile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("datasourceusersprofiles");

                entity.HasIndex(e => e.DataSourceId, "dataSourceUsersProfilesFk1");

                entity.HasIndex(e => e.UserProfileId, "dataSourceUsersProfilesFk2");

                entity.Property(e => e.DataSourceId).HasColumnName("dataSourceId");

                entity.Property(e => e.UserProfileId).HasColumnName("userProfileId");

                entity.HasOne(d => d.DataSource)
                    .WithMany()
                    .HasForeignKey(d => d.DataSourceId)
                    .HasConstraintName("dataSourceUsersProfilesFk1");

                entity.HasOne(d => d.UserProfile)
                    .WithMany()
                    .HasForeignKey(d => d.UserProfileId)
                    .HasConstraintName("dataSourceUsersProfilesFk2");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("events");

                entity.HasIndex(e => e.AckUserId, "eventsFk1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AckTs).HasColumnName("ackTs");

                entity.Property(e => e.AckUserId).HasColumnName("ackUserId");

                entity.Property(e => e.ActiveTs).HasColumnName("activeTs");

                entity.Property(e => e.AlarmLevel).HasColumnName("alarmLevel");

                entity.Property(e => e.AlternateAckSource).HasColumnName("alternateAckSource");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.RtnApplicable)
                    .HasMaxLength(1)
                    .HasColumnName("rtnApplicable")
                    .IsFixedLength();

                entity.Property(e => e.RtnCause).HasColumnName("rtnCause");

                entity.Property(e => e.RtnTs).HasColumnName("rtnTs");

                entity.Property(e => e.ShortMessage).HasColumnName("shortMessage");

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.TypeRef1).HasColumnName("typeRef1");

                entity.Property(e => e.TypeRef2).HasColumnName("typeRef2");

                entity.HasOne(d => d.AckUser)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.AckUserId)
                    .HasConstraintName("eventsFk1");
            });

            modelBuilder.Entity<Eventdetectortemplate>(entity =>
            {
                entity.ToTable("eventdetectortemplates");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Eventhandler>(entity =>
            {
                entity.ToTable("eventhandlers");

                entity.HasIndex(e => e.Xid, "eventHandlersUn1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alias)
                    .HasMaxLength(255)
                    .HasColumnName("alias");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.EventTypeId).HasColumnName("eventTypeId");

                entity.Property(e => e.EventTypeRef1).HasColumnName("eventTypeRef1");

                entity.Property(e => e.EventTypeRef2).HasColumnName("eventTypeRef2");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");
            });

            modelBuilder.Entity<Flexproject>(entity =>
            {
                entity.ToTable("flexprojects");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .HasColumnName("name");

                entity.Property(e => e.XmlConfig)
                    .HasMaxLength(16384)
                    .HasColumnName("xmlConfig");
            });

            modelBuilder.Entity<Historyalarm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("historyalarms");

                entity.Property(e => e.AcknowledgeTime)
                    .HasMaxLength(19)
                    .HasColumnName("acknowledgeTime");

                entity.Property(e => e.ActiveTime)
                    .HasMaxLength(19)
                    .HasColumnName("activeTime");

                entity.Property(e => e.InactiveTime)
                    .HasMaxLength(19)
                    .HasColumnName("inactiveTime");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Livealarm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("livealarms");

                entity.Property(e => e.ActivationTime)
                    .HasMaxLength(19)
                    .HasColumnName("activation-time");

                entity.Property(e => e.DataPointId).HasColumnName("dataPointId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InactivationTime)
                    .HasMaxLength(19)
                    .HasColumnName("inactivation-time");

                entity.Property(e => e.Level)
                    .HasMaxLength(45)
                    .HasColumnName("level");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Mailinglist>(entity =>
            {
                entity.ToTable("mailinglists");

                entity.HasIndex(e => e.Xid, "mailingListsUn1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CollectInactiveEmails)
                    .HasMaxLength(1)
                    .HasColumnName("collectInactiveEmails")
                    .HasDefaultValueSql("'0x30'")
                    .IsFixedLength()
                    .HasComment("Collect inactive emails and send when activated");

                entity.Property(e => e.CronPattern)
                    .HasMaxLength(100)
                    .HasColumnName("cronPattern")
                    .HasComment("cron pattern");

                entity.Property(e => e.DailyLimitSentEmails)
                    .HasMaxLength(1)
                    .HasColumnName("dailyLimitSentEmails")
                    .HasDefaultValueSql("'0x30'")
                    .IsFixedLength()
                    .HasComment("Daily limit sent emails");

                entity.Property(e => e.DailyLimitSentEmailsNumber)
                    .HasColumnName("dailyLimitSentEmailsNumber")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Daily limit sent emails number");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .HasColumnName("name");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");
            });

            modelBuilder.Entity<Mailinglistinactive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mailinglistinactive");

                entity.HasIndex(e => e.MailingListId, "mailingListInactiveFk1");

                entity.Property(e => e.InactiveInterval).HasColumnName("inactiveInterval");

                entity.Property(e => e.MailingListId).HasColumnName("mailingListId");

                entity.HasOne(d => d.MailingList)
                    .WithMany()
                    .HasForeignKey(d => d.MailingListId)
                    .HasConstraintName("mailingListInactiveFk1");
            });

            modelBuilder.Entity<Mailinglistmember>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mailinglistmembers");

                entity.HasIndex(e => e.MailingListId, "mailingListMembersFk1");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.MailingListId).HasColumnName("mailingListId");

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.MailingList)
                    .WithMany()
                    .HasForeignKey(d => d.MailingListId)
                    .HasConstraintName("mailingListMembersFk1");
            });

            modelBuilder.Entity<Maintenanceevent>(entity =>
            {
                entity.ToTable("maintenanceevents");

                entity.HasIndex(e => e.DataSourceId, "maintenanceEventsFk1");

                entity.HasIndex(e => e.Xid, "maintenanceEventsUn1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActiveCron)
                    .HasMaxLength(25)
                    .HasColumnName("activeCron");

                entity.Property(e => e.ActiveDay).HasColumnName("activeDay");

                entity.Property(e => e.ActiveHour).HasColumnName("activeHour");

                entity.Property(e => e.ActiveMinute).HasColumnName("activeMinute");

                entity.Property(e => e.ActiveMonth).HasColumnName("activeMonth");

                entity.Property(e => e.ActiveSecond).HasColumnName("activeSecond");

                entity.Property(e => e.ActiveYear).HasColumnName("activeYear");

                entity.Property(e => e.AlarmLevel).HasColumnName("alarmLevel");

                entity.Property(e => e.Alias)
                    .HasMaxLength(255)
                    .HasColumnName("alias");

                entity.Property(e => e.DataSourceId).HasColumnName("dataSourceId");

                entity.Property(e => e.Disabled)
                    .HasMaxLength(1)
                    .HasColumnName("disabled")
                    .IsFixedLength();

                entity.Property(e => e.InactiveCron)
                    .HasMaxLength(25)
                    .HasColumnName("inactiveCron");

                entity.Property(e => e.InactiveDay).HasColumnName("inactiveDay");

                entity.Property(e => e.InactiveHour).HasColumnName("inactiveHour");

                entity.Property(e => e.InactiveMinute).HasColumnName("inactiveMinute");

                entity.Property(e => e.InactiveMonth).HasColumnName("inactiveMonth");

                entity.Property(e => e.InactiveSecond).HasColumnName("inactiveSecond");

                entity.Property(e => e.InactiveYear).HasColumnName("inactiveYear");

                entity.Property(e => e.ScheduleType).HasColumnName("scheduleType");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");

                entity.HasOne(d => d.DataSource)
                    .WithMany(p => p.Maintenanceevents)
                    .HasForeignKey(d => d.DataSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("maintenanceEventsFk1");
            });

            modelBuilder.Entity<Mangoview>(entity =>
            {
                entity.ToTable("mangoviews");

                entity.HasIndex(e => e.UserId, "mangoViewsFk1");

                entity.HasIndex(e => e.Xid, "mangoViewsUn1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnonymousAccess).HasColumnName("anonymousAccess");

                entity.Property(e => e.Background)
                    .HasMaxLength(255)
                    .HasColumnName("background");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.ModificationTime)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("modification_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Width).HasColumnName("width");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Mangoviews)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("mangoViewsFk1");
            });

            modelBuilder.Entity<Mangoviewuser>(entity =>
            {
                entity.HasKey(e => new { e.MangoViewId, e.UserId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("mangoviewusers");

                entity.HasIndex(e => e.UserId, "mangoViewUsersFk2");

                entity.Property(e => e.MangoViewId).HasColumnName("mangoViewId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.AccessType).HasColumnName("accessType");

                entity.HasOne(d => d.MangoView)
                    .WithMany(p => p.Mangoviewusers)
                    .HasForeignKey(d => d.MangoViewId)
                    .HasConstraintName("mangoViewUsersFk1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Mangoviewusers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("mangoViewUsersFk2");
            });

            modelBuilder.Entity<MultiChangesHistory>(entity =>
            {
                entity.ToTable("multi_changes_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InterpretedState)
                    .HasMaxLength(50)
                    .HasColumnName("interpretedState");

                entity.Property(e => e.Ts).HasColumnName("ts");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.ViewAndComponentIdentification)
                    .HasMaxLength(50)
                    .HasColumnName("viewAndComponentIdentification");
            });

            modelBuilder.Entity<Plcalarm>(entity =>
            {
                entity.ToTable("plcalarms");

                entity.HasIndex(e => new { e.DataPointId, e.InactiveTime }, "dataPointId")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcknowledgeTime)
                    .HasColumnName("acknowledgeTime")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ActiveTime)
                    .HasColumnName("activeTime")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DataPointId).HasColumnName("dataPointId");

                entity.Property(e => e.DataPointName)
                    .HasMaxLength(45)
                    .HasColumnName("dataPointName");

                entity.Property(e => e.DataPointType)
                    .HasMaxLength(45)
                    .HasColumnName("dataPointType");

                entity.Property(e => e.DataPointXid)
                    .HasMaxLength(50)
                    .HasColumnName("dataPointXid");

                entity.Property(e => e.InactiveTime)
                    .HasColumnName("inactiveTime")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.HasOne(d => d.DataPoint)
                    .WithMany(p => p.Plcalarms)
                    .HasForeignKey(d => d.DataPointId)
                    .HasConstraintName("plcalarms_ibfk_1");
            });

            modelBuilder.Entity<Pointeventdetector>(entity =>
            {
                entity.ToTable("pointeventdetectors");

                entity.HasIndex(e => e.DataPointId, "pointEventDetectorsFk1");

                entity.HasIndex(e => new { e.Xid, e.DataPointId }, "pointEventDetectorsUn1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AlarmLevel).HasColumnName("alarmLevel");

                entity.Property(e => e.Alias)
                    .HasMaxLength(255)
                    .HasColumnName("alias");

                entity.Property(e => e.AlphanumericState)
                    .HasMaxLength(128)
                    .HasColumnName("alphanumericState");

                entity.Property(e => e.BinaryState)
                    .HasMaxLength(1)
                    .HasColumnName("binaryState")
                    .IsFixedLength();

                entity.Property(e => e.ChangeCount).HasColumnName("changeCount");

                entity.Property(e => e.DataPointId).HasColumnName("dataPointId");

                entity.Property(e => e.DetectorType).HasColumnName("detectorType");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.DurationType).HasColumnName("durationType");

                entity.Property(e => e.MultistateState).HasColumnName("multistateState");

                entity.Property(e => e.StateLimit).HasColumnName("stateLimit");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");

                entity.HasOne(d => d.DataPoint)
                    .WithMany(p => p.Pointeventdetectors)
                    .HasForeignKey(d => d.DataPointId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pointEventDetectorsFk1");
            });

            modelBuilder.Entity<Pointhierarchy>(entity =>
            {
                entity.ToTable("pointhierarchy");

                entity.HasIndex(e => e.Xid, "idx_xid_point_hierarchy")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.ParentId).HasColumnName("parentId");

                entity.Property(e => e.Xid)
                    .HasMaxLength(100)
                    .HasColumnName("xid");
            });

            modelBuilder.Entity<Pointlink>(entity =>
            {
                entity.ToTable("pointlinks");

                entity.HasIndex(e => e.Xid, "pointLinksUn1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Disabled)
                    .HasMaxLength(1)
                    .HasColumnName("disabled")
                    .IsFixedLength();

                entity.Property(e => e.EventType).HasColumnName("eventType");

                entity.Property(e => e.Script).HasColumnName("script");

                entity.Property(e => e.SourcePointId).HasColumnName("sourcePointId");

                entity.Property(e => e.TargetPointId).HasColumnName("targetPointId");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");
            });

            modelBuilder.Entity<Pointvalue>(entity =>
            {
                entity.ToTable("pointvalues");

                entity.HasIndex(e => new { e.Ts, e.DataPointId }, "pointValuesIdx1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataPointId).HasColumnName("dataPointId");

                entity.Property(e => e.DataType).HasColumnName("dataType");

                entity.Property(e => e.PointValue1).HasColumnName("pointValue");

                entity.Property(e => e.Ts).HasColumnName("ts");

                entity.HasOne(d => d.DataPoint)
                    .WithMany(p => p.Pointvalues)
                    .HasForeignKey(d => d.DataPointId)
                    .HasConstraintName("pointValuesFk1");
            });

            modelBuilder.Entity<Pointvalueannotation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pointvalueannotations");

                entity.HasIndex(e => e.PointValueId, "pointValueAnnotationsFk1");

                entity.Property(e => e.PointValueId).HasColumnName("pointValueId");

                entity.Property(e => e.SourceId).HasColumnName("sourceId");

                entity.Property(e => e.SourceType).HasColumnName("sourceType");

                entity.Property(e => e.TextPointValueLong).HasColumnName("textPointValueLong");

                entity.Property(e => e.TextPointValueShort)
                    .HasMaxLength(128)
                    .HasColumnName("textPointValueShort");

                entity.HasOne(d => d.PointValue)
                    .WithMany()
                    .HasForeignKey(d => d.PointValueId)
                    .HasConstraintName("pointValueAnnotationsFk1");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("publishers");

                entity.HasIndex(e => e.Xid, "publishersUn1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("reports");

                entity.HasIndex(e => e.UserId, "reportsFk1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("reportsFk1");
            });

            modelBuilder.Entity<Reportinstance>(entity =>
            {
                entity.ToTable("reportinstances");

                entity.HasIndex(e => e.UserId, "reportInstancesFk1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IncludeEvents).HasColumnName("includeEvents");

                entity.Property(e => e.IncludeUserComments)
                    .HasMaxLength(1)
                    .HasColumnName("includeUserComments")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.PreventPurge)
                    .HasMaxLength(1)
                    .HasColumnName("preventPurge")
                    .IsFixedLength();

                entity.Property(e => e.RecordCount).HasColumnName("recordCount");

                entity.Property(e => e.ReportEndTime).HasColumnName("reportEndTime");

                entity.Property(e => e.ReportStartTime).HasColumnName("reportStartTime");

                entity.Property(e => e.RunEndTime).HasColumnName("runEndTime");

                entity.Property(e => e.RunStartTime).HasColumnName("runStartTime");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reportinstances)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("reportInstancesFk1");
            });

            modelBuilder.Entity<Reportinstancedataannotation>(entity =>
            {
                entity.HasKey(e => new { e.PointValueId, e.ReportInstancePointId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("reportinstancedataannotations");

                entity.Property(e => e.PointValueId).HasColumnName("pointValueId");

                entity.Property(e => e.ReportInstancePointId).HasColumnName("reportInstancePointId");

                entity.Property(e => e.SourceValue)
                    .HasMaxLength(128)
                    .HasColumnName("sourceValue");

                entity.Property(e => e.TextPointValueLong).HasColumnName("textPointValueLong");

                entity.Property(e => e.TextPointValueShort)
                    .HasMaxLength(128)
                    .HasColumnName("textPointValueShort");

                entity.HasOne(d => d.Reportinstancedatum)
                    .WithOne(p => p.Reportinstancedataannotation)
                    .HasForeignKey<Reportinstancedataannotation>(d => new { d.PointValueId, d.ReportInstancePointId })
                    .HasConstraintName("reportInstanceDataAnnotationsFk1");
            });

            modelBuilder.Entity<Reportinstancedatum>(entity =>
            {
                entity.HasKey(e => new { e.PointValueId, e.ReportInstancePointId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("reportinstancedata");

                entity.HasIndex(e => e.ReportInstancePointId, "reportInstanceDataFk1");

                entity.Property(e => e.PointValueId).HasColumnName("pointValueId");

                entity.Property(e => e.ReportInstancePointId).HasColumnName("reportInstancePointId");

                entity.Property(e => e.PointValue).HasColumnName("pointValue");

                entity.Property(e => e.Ts).HasColumnName("ts");

                entity.HasOne(d => d.ReportInstancePoint)
                    .WithMany(p => p.Reportinstancedata)
                    .HasForeignKey(d => d.ReportInstancePointId)
                    .HasConstraintName("reportInstanceDataFk1");
            });

            modelBuilder.Entity<Reportinstanceevent>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.ReportInstanceId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("reportinstanceevents");

                entity.HasIndex(e => e.ReportInstanceId, "reportInstanceEventsFk1");

                entity.Property(e => e.EventId).HasColumnName("eventId");

                entity.Property(e => e.ReportInstanceId).HasColumnName("reportInstanceId");

                entity.Property(e => e.AckTs).HasColumnName("ackTs");

                entity.Property(e => e.AckUsername)
                    .HasMaxLength(40)
                    .HasColumnName("ackUsername");

                entity.Property(e => e.ActiveTs).HasColumnName("activeTs");

                entity.Property(e => e.AlarmLevel).HasColumnName("alarmLevel");

                entity.Property(e => e.AlternateAckSource).HasColumnName("alternateAckSource");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.RtnApplicable)
                    .HasMaxLength(1)
                    .HasColumnName("rtnApplicable")
                    .IsFixedLength();

                entity.Property(e => e.RtnCause).HasColumnName("rtnCause");

                entity.Property(e => e.RtnTs).HasColumnName("rtnTs");

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.TypeRef1).HasColumnName("typeRef1");

                entity.Property(e => e.TypeRef2).HasColumnName("typeRef2");

                entity.HasOne(d => d.ReportInstance)
                    .WithMany(p => p.Reportinstanceevents)
                    .HasForeignKey(d => d.ReportInstanceId)
                    .HasConstraintName("reportInstanceEventsFk1");
            });

            modelBuilder.Entity<Reportinstancepoint>(entity =>
            {
                entity.ToTable("reportinstancepoints");

                entity.HasIndex(e => e.ReportInstanceId, "reportInstancePointsFk1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Colour)
                    .HasMaxLength(6)
                    .HasColumnName("colour");

                entity.Property(e => e.ConsolidatedChart)
                    .HasMaxLength(1)
                    .HasColumnName("consolidatedChart")
                    .IsFixedLength();

                entity.Property(e => e.DataSourceName)
                    .HasMaxLength(40)
                    .HasColumnName("dataSourceName");

                entity.Property(e => e.DataType).HasColumnName("dataType");

                entity.Property(e => e.PointName)
                    .HasMaxLength(100)
                    .HasColumnName("pointName");

                entity.Property(e => e.ReportInstanceId).HasColumnName("reportInstanceId");

                entity.Property(e => e.StartValue)
                    .HasMaxLength(4096)
                    .HasColumnName("startValue");

                entity.Property(e => e.TextRenderer).HasColumnName("textRenderer");

                entity.HasOne(d => d.ReportInstance)
                    .WithMany(p => p.Reportinstancepoints)
                    .HasForeignKey(d => d.ReportInstanceId)
                    .HasConstraintName("reportInstancePointsFk1");
            });

            modelBuilder.Entity<Reportinstanceusercomment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reportinstanceusercomments");

                entity.HasIndex(e => e.ReportInstanceId, "reportInstanceUserCommentsFk1");

                entity.Property(e => e.CommentText)
                    .HasMaxLength(1024)
                    .HasColumnName("commentText");

                entity.Property(e => e.CommentType).HasColumnName("commentType");

                entity.Property(e => e.ReportInstanceId).HasColumnName("reportInstanceId");

                entity.Property(e => e.Ts).HasColumnName("ts");

                entity.Property(e => e.TypeKey).HasColumnName("typeKey");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .HasColumnName("username");

                entity.HasOne(d => d.ReportInstance)
                    .WithMany()
                    .HasForeignKey(d => d.ReportInstanceId)
                    .HasConstraintName("reportInstanceUserCommentsFk1");
            });

            modelBuilder.Entity<Scheduledevent>(entity =>
            {
                entity.ToTable("scheduledevents");

                entity.HasIndex(e => e.Xid, "scheduledEventsUn1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActiveCron)
                    .HasMaxLength(25)
                    .HasColumnName("activeCron");

                entity.Property(e => e.ActiveDay).HasColumnName("activeDay");

                entity.Property(e => e.ActiveHour).HasColumnName("activeHour");

                entity.Property(e => e.ActiveMinute).HasColumnName("activeMinute");

                entity.Property(e => e.ActiveMonth).HasColumnName("activeMonth");

                entity.Property(e => e.ActiveSecond).HasColumnName("activeSecond");

                entity.Property(e => e.ActiveYear).HasColumnName("activeYear");

                entity.Property(e => e.AlarmLevel).HasColumnName("alarmLevel");

                entity.Property(e => e.Alias)
                    .HasMaxLength(255)
                    .HasColumnName("alias");

                entity.Property(e => e.Disabled)
                    .HasMaxLength(1)
                    .HasColumnName("disabled")
                    .IsFixedLength();

                entity.Property(e => e.InactiveCron)
                    .HasMaxLength(25)
                    .HasColumnName("inactiveCron");

                entity.Property(e => e.InactiveDay).HasColumnName("inactiveDay");

                entity.Property(e => e.InactiveHour).HasColumnName("inactiveHour");

                entity.Property(e => e.InactiveMinute).HasColumnName("inactiveMinute");

                entity.Property(e => e.InactiveMonth).HasColumnName("inactiveMonth");

                entity.Property(e => e.InactiveSecond).HasColumnName("inactiveSecond");

                entity.Property(e => e.InactiveYear).HasColumnName("inactiveYear");

                entity.Property(e => e.ReturnToNormal)
                    .HasMaxLength(1)
                    .HasColumnName("returnToNormal")
                    .IsFixedLength();

                entity.Property(e => e.ScheduleType).HasColumnName("scheduleType");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");
            });

            modelBuilder.Entity<Scheduledexecuteinactiveevent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("scheduledexecuteinactiveevent");

                entity.HasIndex(e => e.EventHandlerId, "eventHandlerId");

                entity.HasIndex(e => new { e.MailingListId, e.SourceEventId, e.EventHandlerId }, "mailingListId")
                    .IsUnique();

                entity.HasIndex(e => e.SourceEventId, "sourceEventId");

                entity.Property(e => e.EventHandlerId).HasColumnName("eventHandlerId");

                entity.Property(e => e.MailingListId).HasColumnName("mailingListId");

                entity.Property(e => e.SourceEventId).HasColumnName("sourceEventId");

                entity.HasOne(d => d.EventHandler)
                    .WithMany()
                    .HasForeignKey(d => d.EventHandlerId)
                    .HasConstraintName("scheduledexecuteinactiveevent_ibfk_3");

                entity.HasOne(d => d.MailingList)
                    .WithMany()
                    .HasForeignKey(d => d.MailingListId)
                    .HasConstraintName("scheduledexecuteinactiveevent_ibfk_2");

                entity.HasOne(d => d.SourceEvent)
                    .WithMany()
                    .HasForeignKey(d => d.SourceEventId)
                    .HasConstraintName("scheduledexecuteinactiveevent_ibfk_1");
            });

            modelBuilder.Entity<SchemaVersion>(entity =>
            {
                entity.HasKey(e => e.InstalledRank)
                    .HasName("PRIMARY");

                entity.ToTable("schema_version");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_0900_ai_ci");

                entity.HasIndex(e => e.Success, "schema_version_s_idx");

                entity.Property(e => e.InstalledRank)
                    .ValueGeneratedNever()
                    .HasColumnName("installed_rank");

                entity.Property(e => e.Checksum).HasColumnName("checksum");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("description");

                entity.Property(e => e.ExecutionTime).HasColumnName("execution_time");

                entity.Property(e => e.InstalledBy)
                    .HasMaxLength(100)
                    .HasColumnName("installed_by");

                entity.Property(e => e.InstalledOn)
                    .HasColumnType("timestamp")
                    .HasColumnName("installed_on")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Script)
                    .HasMaxLength(1000)
                    .HasColumnName("script");

                entity.Property(e => e.Success).HasColumnName("success");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<Script>(entity =>
            {
                entity.ToTable("scripts");

                entity.HasIndex(e => e.UserId, "scriptsFk1");

                entity.HasIndex(e => e.Xid, "scriptsUn1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .HasColumnName("name");

                entity.Property(e => e.Script1)
                    .HasMaxLength(16384)
                    .HasColumnName("script");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Scripts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("scriptsFk1");
            });

            modelBuilder.Entity<Synopticpanel>(entity =>
            {
                entity.ToTable("synopticpanels");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComponentData)
                    .HasColumnType("text")
                    .HasColumnName("componentData");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.VectorImage)
                    .HasColumnType("text")
                    .HasColumnName("vectorImage");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");
            });

            modelBuilder.Entity<Systemsetting>(entity =>
            {
                entity.HasKey(e => e.SettingName)
                    .HasName("PRIMARY");

                entity.ToTable("systemsettings");

                entity.Property(e => e.SettingName)
                    .HasMaxLength(32)
                    .HasColumnName("settingName");

                entity.Property(e => e.SettingValue).HasColumnName("settingValue");
            });

            modelBuilder.Entity<Templatesdetector>(entity =>
            {
                entity.ToTable("templatesdetectors");

                entity.HasIndex(e => e.EventDetectorTemplateId, "templatesDetectorsFk1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AlarmLevel).HasColumnName("alarmLevel");

                entity.Property(e => e.Alias)
                    .HasMaxLength(255)
                    .HasColumnName("alias");

                entity.Property(e => e.AlphanumericState)
                    .HasMaxLength(128)
                    .HasColumnName("alphanumericState");

                entity.Property(e => e.BinaryState)
                    .HasMaxLength(1)
                    .HasColumnName("binaryState")
                    .IsFixedLength();

                entity.Property(e => e.ChangeCount).HasColumnName("changeCount");

                entity.Property(e => e.DetectorType).HasColumnName("detectorType");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.DurationType).HasColumnName("durationType");

                entity.Property(e => e.EventDetectorTemplateId).HasColumnName("eventDetectorTemplateId");

                entity.Property(e => e.MultistateState).HasColumnName("multistateState");

                entity.Property(e => e.StateLimit).HasColumnName("stateLimit");

                entity.Property(e => e.Threshold).HasColumnName("threshold");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");

                entity.HasOne(d => d.EventDetectorTemplate)
                    .WithMany(p => p.Templatesdetectors)
                    .HasForeignKey(d => d.EventDetectorTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("templatesDetectorsFk1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Admin)
                    .HasMaxLength(1)
                    .HasColumnName("admin")
                    .IsFixedLength();

                entity.Property(e => e.Disabled)
                    .HasMaxLength(1)
                    .HasColumnName("disabled")
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("firstName")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HideMenu)
                    .HasColumnName("hideMenu")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HomeUrl)
                    .HasMaxLength(255)
                    .HasColumnName("homeUrl");

                entity.Property(e => e.LastLogin).HasColumnName("lastLogin");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("lastName")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(40)
                    .HasColumnName("phone");

                entity.Property(e => e.ReceiveAlarmEmails).HasColumnName("receiveAlarmEmails");

                entity.Property(e => e.ReceiveOwnAuditEvents)
                    .HasMaxLength(1)
                    .HasColumnName("receiveOwnAuditEvents")
                    .IsFixedLength();

                entity.Property(e => e.SelectedWatchList).HasColumnName("selectedWatchList");

                entity.Property(e => e.Theme)
                    .HasMaxLength(255)
                    .HasColumnName("theme")
                    .HasDefaultValueSql("'DEFAULT'");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Usercomment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usercomments");

                entity.HasIndex(e => e.UserId, "userCommentsFk1");

                entity.Property(e => e.CommentText)
                    .HasMaxLength(1024)
                    .HasColumnName("commentText");

                entity.Property(e => e.CommentType).HasColumnName("commentType");

                entity.Property(e => e.Ts).HasColumnName("ts");

                entity.Property(e => e.TypeKey).HasColumnName("typeKey");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("userCommentsFk1");
            });

            modelBuilder.Entity<Userevent>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.UserId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("userevents");

                entity.HasIndex(e => e.UserId, "userEventsFk2");

                entity.Property(e => e.EventId).HasColumnName("eventId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Silenced)
                    .HasMaxLength(1)
                    .HasColumnName("silenced")
                    .IsFixedLength();

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Userevents)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("userEventsFk1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userevents)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("userEventsFk2");
            });

            modelBuilder.Entity<Usersprofile>(entity =>
            {
                entity.ToTable("usersprofiles");

                entity.HasIndex(e => e.Xid, "usersProfilesUn1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");
            });

            modelBuilder.Entity<Usersusersprofile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usersusersprofiles");

                entity.HasIndex(e => e.UserProfileId, "usersUsersProfilesFk1");

                entity.HasIndex(e => e.UserId, "usersUsersProfilesFk2");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserProfileId).HasColumnName("userProfileId");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("usersUsersProfilesFk2");

                entity.HasOne(d => d.UserProfile)
                    .WithMany()
                    .HasForeignKey(d => d.UserProfileId)
                    .HasConstraintName("usersUsersProfilesFk1");
            });

            modelBuilder.Entity<ValuesMultiChangesHistory>(entity =>
            {
                entity.ToTable("values_multi_changes_history");

                entity.HasIndex(e => e.MultiChangesHistoryId, "index_multiChangesHistoryId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataPointId).HasColumnName("dataPointId");

                entity.Property(e => e.MultiChangesHistoryId).HasColumnName("multiChangesHistoryId");

                entity.Property(e => e.Ts).HasColumnName("ts");

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .HasColumnName("value");

                entity.Property(e => e.ValueId).HasColumnName("valueId");
            });

            modelBuilder.Entity<ViewsCategoryViewsHierarchy>(entity =>
            {
                entity.HasKey(e => e.ViewId)
                    .HasName("PRIMARY");

                entity.ToTable("views_category_views_hierarchy");

                entity.Property(e => e.ViewId)
                    .ValueGeneratedNever()
                    .HasColumnName("view_id");

                entity.Property(e => e.FolderViewsHierarchyId).HasColumnName("folder_views_hierarchy_id");
            });

            modelBuilder.Entity<Viewusersprofile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("viewusersprofiles");

                entity.HasIndex(e => e.ViewId, "viewUsersProfilesFk1");

                entity.HasIndex(e => e.UserProfileId, "viewUsersProfilesFk2");

                entity.Property(e => e.Permission).HasColumnName("permission");

                entity.Property(e => e.UserProfileId).HasColumnName("userProfileId");

                entity.Property(e => e.ViewId).HasColumnName("viewId");

                entity.HasOne(d => d.UserProfile)
                    .WithMany()
                    .HasForeignKey(d => d.UserProfileId)
                    .HasConstraintName("viewUsersProfilesFk2");

                entity.HasOne(d => d.View)
                    .WithMany()
                    .HasForeignKey(d => d.ViewId)
                    .HasConstraintName("viewUsersProfilesFk1");
            });

            modelBuilder.Entity<Watchlist>(entity =>
            {
                entity.ToTable("watchlists");

                entity.HasIndex(e => e.UserId, "watchListsFk1");

                entity.HasIndex(e => e.Xid, "watchListsUn1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Xid)
                    .HasMaxLength(50)
                    .HasColumnName("xid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Watchlists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("watchListsFk1");
            });

            modelBuilder.Entity<Watchlistpoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("watchlistpoints");

                entity.HasIndex(e => e.WatchListId, "watchListPointsFk1");

                entity.HasIndex(e => e.DataPointId, "watchListPointsFk2");

                entity.Property(e => e.DataPointId).HasColumnName("dataPointId");

                entity.Property(e => e.SortOrder).HasColumnName("sortOrder");

                entity.Property(e => e.WatchListId).HasColumnName("watchListId");

                entity.HasOne(d => d.DataPoint)
                    .WithMany()
                    .HasForeignKey(d => d.DataPointId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("watchListPointsFk2");

                entity.HasOne(d => d.WatchList)
                    .WithMany()
                    .HasForeignKey(d => d.WatchListId)
                    .HasConstraintName("watchListPointsFk1");
            });

            modelBuilder.Entity<Watchlistuser>(entity =>
            {
                entity.HasKey(e => new { e.WatchListId, e.UserId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("watchlistusers");

                entity.HasIndex(e => e.UserId, "watchListUsersFk2");

                entity.Property(e => e.WatchListId).HasColumnName("watchListId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.AccessType).HasColumnName("accessType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Watchlistusers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("watchListUsersFk2");

                entity.HasOne(d => d.WatchList)
                    .WithMany(p => p.Watchlistusers)
                    .HasForeignKey(d => d.WatchListId)
                    .HasConstraintName("watchListUsersFk1");
            });

            modelBuilder.Entity<Watchlistusersprofile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("watchlistusersprofiles");

                entity.HasIndex(e => e.WatchlistId, "watchlistUsersProfilesFk1");

                entity.HasIndex(e => e.UserProfileId, "watchlistUsersProfilesFk2");

                entity.Property(e => e.Permission).HasColumnName("permission");

                entity.Property(e => e.UserProfileId).HasColumnName("userProfileId");

                entity.Property(e => e.WatchlistId).HasColumnName("watchlistId");

                entity.HasOne(d => d.UserProfile)
                    .WithMany()
                    .HasForeignKey(d => d.UserProfileId)
                    .HasConstraintName("watchlistUsersProfilesFk2");

                entity.HasOne(d => d.Watchlist)
                    .WithMany()
                    .HasForeignKey(d => d.WatchlistId)
                    .HasConstraintName("watchlistUsersProfilesFk1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
