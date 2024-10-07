using System;
using System.Collections.Generic;
using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccessObject
{
    public partial class SWP391_TicketResellPlatformContext : DbContext
    {
        public SWP391_TicketResellPlatformContext()
        {
        }

        public SWP391_TicketResellPlatformContext(DbContextOptions<SWP391_TicketResellPlatformContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<GenericTicket> GenericTickets { get; set; } = null!;
        public virtual DbSet<Hashtag> Hashtags { get; set; } = null!;
        public virtual DbSet<HashtagEvent> HashtagEvents { get; set; } = null!;
        public virtual DbSet<OrderTicket> OrderTickets { get; set; } = null!;
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; } = null!;
        public virtual DbSet<Policy> Policies { get; set; } = null!;
        public virtual DbSet<Rating> Ratings { get; set; } = null!;
        public virtual DbSet<ReportFraud> ReportFrauds { get; set; } = null!;
        public virtual DbSet<ReportType> ReportTypes { get; set; } = null!;
        public virtual DbSet<Staff> Staffs { get; set; } = null!;
        public virtual DbSet<StaffToken> StaffTokens { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<Token> Tokens { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;
        public virtual DbSet<TypePolicy> TypePolicies { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<VerificationUser> VerificationUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=SWP391_TicketResellPlatform;Uid=sa;Pwd=12345;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");

                entity.HasIndex(e => e.Name, "UKt8o6pivur7nn124jehx7cygw5")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("events");

                entity.HasIndex(e => e.Name, "UKfn2r8jg0sm5v6vhoa7yqw55vy")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Detail)
                    .HasMaxLength(1024)
                    .HasColumnName("detail");

                entity.Property(e => e.EndDate)
                    .HasPrecision(6)
                    .HasColumnName("end_date");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(256)
                    .HasColumnName("name");

                entity.Property(e => e.StartDate)
                    .HasPrecision(6)
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<GenericTicket>(entity =>
            {
                entity.ToTable("generic_tickets");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Area)
                    .HasMaxLength(128)
                    .HasColumnName("area");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .HasColumnName("description");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ExpiredDateTime)
                    .HasPrecision(6)
                    .HasColumnName("expired_date_time");

                entity.Property(e => e.IsPaper).HasColumnName("is_paper");

                entity.Property(e => e.LinkEvent)
                    .HasMaxLength(512)
                    .HasColumnName("link_event");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.SalePercent).HasColumnName("sale_percent");

                entity.Property(e => e.SellerId).HasColumnName("seller_id");

                entity.Property(e => e.TicketName)
                    .HasMaxLength(128)
                    .HasColumnName("ticket_name");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.GenericTickets)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK1gv11n0lqfk3ajfitu0nrlidh");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.GenericTickets)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FKkm5igngwohbt8qhtwrafw3nna");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.GenericTickets)
                    .HasForeignKey(d => d.PolicyId)
                    .HasConstraintName("FKqnwy8mnt8ub5nig4xubep9le2");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.GenericTickets)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("FKqfeq8g0kiwfskvppmehjckn4j");
            });

            modelBuilder.Entity<Hashtag>(entity =>
            {
                entity.ToTable("hashtags");

                entity.HasIndex(e => e.Name, "UKoed8qhhrhflqj7olh3oeii6ym")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<HashtagEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hashtag_event");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.HashtagId).HasColumnName("hashtag_id");

                entity.HasOne(d => d.Event)
                    .WithMany()
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKnqw7s13xxhrodsqdo7hu11sb2");

                entity.HasOne(d => d.Hashtag)
                    .WithMany()
                    .HasForeignKey(d => d.HashtagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK8eair4a1ov26vt04tkr3s77kn");
            });

            modelBuilder.Entity<OrderTicket>(entity =>
            {
                entity.HasKey(e => new { e.BuyerId, e.GenericTicketId })
                    .HasName("PK__order_ti__914A2F2A34B2ADA4");

                entity.ToTable("order_tickets");

                entity.Property(e => e.BuyerId).HasColumnName("buyer_id");

                entity.Property(e => e.GenericTicketId).HasColumnName("generic_ticket_id");

                entity.Property(e => e.IsAccepted)
                    .HasColumnName("is_accepted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Note)
                    .HasMaxLength(1024)
                    .HasColumnName("note");

                entity.Property(e => e.PaymentMethodId).HasColumnName("payment_method_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.TotalPrice).HasColumnName("total_price");

                entity.HasOne(d => d.Buyer)
                    .WithMany(p => p.OrderTickets)
                    .HasForeignKey(d => d.BuyerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK8rjxw9kxujn6asyv889w67p9n");

                entity.HasOne(d => d.GenericTicket)
                    .WithMany(p => p.OrderTickets)
                    .HasForeignKey(d => d.GenericTicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKpavnj7gxtbg3l71wcwdnenprr");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.OrderTickets)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FKp79lq298jckth15x85tbbq8k2");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.ToTable("payment_method");

                entity.HasIndex(e => e.Name, "UKai10u6l9urufl9pidfuhnmmcj")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Policy>(entity =>
            {
                entity.ToTable("policy");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TypePolicyId).HasColumnName("type_policy_id");

                entity.HasOne(d => d.TypePolicy)
                    .WithMany(p => p.Policies)
                    .HasForeignKey(d => d.TypePolicyId)
                    .HasConstraintName("FK1xk5mbrjuworjo0glmlcx7tqc");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.HasKey(e => new { e.BuyerId, e.GenericTicketId })
                    .HasName("PK__rating__914A2F2A5D9E3209");

                entity.ToTable("rating");

                entity.Property(e => e.BuyerId).HasColumnName("buyer_id");

                entity.Property(e => e.GenericTicketId).HasColumnName("generic_ticket_id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Stars).HasColumnName("stars");

                entity.HasOne(d => d.Buyer)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.BuyerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKqn4rbsx6kl9mp0jjwm9akgubk");

                entity.HasOne(d => d.GenericTicket)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.GenericTicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKdk1eqadiltic6sjvqlvqde268");
            });

            modelBuilder.Entity<ReportFraud>(entity =>
            {
                entity.ToTable("report_fraud");

                entity.HasIndex(e => e.TicketId, "UKqttx479mjscjdp4l42fryfvdu")
                    .IsUnique()
                    .HasFilter("([ticket_id] IS NOT NULL)");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccuserId).HasColumnName("accuser_id");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Proof).HasColumnName("proof");

                entity.Property(e => e.ReportProcess)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("report_process");

                entity.Property(e => e.ReportTypeId).HasColumnName("report_type_id");

                entity.Property(e => e.ReportedUserId).HasColumnName("reported_user_id");

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.Property(e => e.TicketId).HasColumnName("ticket_id");

                entity.HasOne(d => d.Accuser)
                    .WithMany(p => p.ReportFrauds)
                    .HasForeignKey(d => d.AccuserId)
                    .HasConstraintName("FK159p1duged0yssywllf2ske9b");

                entity.HasOne(d => d.ReportType)
                    .WithMany(p => p.ReportFrauds)
                    .HasForeignKey(d => d.ReportTypeId)
                    .HasConstraintName("FKbvw6sycfe7q7r8s5qxnbaoc3u");

                entity.HasOne(d => d.Ticket)
                    .WithOne(p => p.ReportFraud)
                    .HasForeignKey<ReportFraud>(d => d.TicketId)
                    .HasConstraintName("FKq3yt7i1l33agpwif7wrkfk0a9");
            });

            modelBuilder.Entity<ReportType>(entity =>
            {
                entity.ToTable("report_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("staffs");

                entity.HasIndex(e => e.Username, "UKqg61c9nc6gdr0nvteu2bl9o7o")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avatar).HasColumnName("avatar");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Email)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(128)
                    .HasColumnName("firstname");

                entity.Property(e => e.IsEnable)
                    .HasColumnName("is_enable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(128)
                    .HasColumnName("lastname");

                entity.Property(e => e.Password)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Revenue).HasColumnName("revenue");

                entity.Property(e => e.RoleCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("role_code");

                entity.Property(e => e.StaffCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("staff_code");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<StaffToken>(entity =>
            {
                entity.ToTable("staff_tokens");

                entity.HasIndex(e => e.Token, "UK46y2k1byh4prjbe78sgfw35we")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Expired).HasColumnName("expired");

                entity.Property(e => e.Revoked).HasColumnName("revoked");

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.Property(e => e.Token)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("token");

                entity.Property(e => e.TokenType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("token_type");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.StaffTokens)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FKfw9bxf7gwh4jxlkeduefjlbfl");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("tickets");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BoughtDate)
                    .HasPrecision(6)
                    .HasColumnName("bought_date");

                entity.Property(e => e.BuyerId).HasColumnName("buyer_id");

                entity.Property(e => e.GenericTicketId).HasColumnName("generic_ticket_id");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.IsBought)
                    .HasColumnName("is_bought")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsChecked)
                    .HasColumnName("is_checked")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsValid)
                    .HasColumnName("is_valid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Process)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("process");

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.Property(e => e.TicketSerial)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("ticket_serial");

                entity.HasOne(d => d.GenericTicket)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.GenericTicketId)
                    .HasConstraintName("FKjx4wk9qp2v88cu0o8hvi4ggs3");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FKp1lyafaiexw7ksa961ri7et0e");
            });

            modelBuilder.Entity<Token>(entity =>
            {
                entity.ToTable("tokens");

                entity.HasIndex(e => e.Token1, "UKna3v9f8s7ucnj16tylrs822qj")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Expired).HasColumnName("expired");

                entity.Property(e => e.Revoked).HasColumnName("revoked");

                entity.Property(e => e.Token1)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("token");

                entity.Property(e => e.TokenType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("token_type");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK2dylsfo39lgjyqml2tbe0b0ss");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transaction");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.IsDone).HasColumnName("is_done");

                entity.Property(e => e.TransDate)
                    .HasPrecision(6)
                    .HasColumnName("trans_date");

                entity.Property(e => e.TransType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("trans_type");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FKguvvvl4qry1w569qlognti4wr");
            });

            modelBuilder.Entity<TypePolicy>(entity =>
            {
                entity.ToTable("type_policy");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Username, "UKr43af9ap4edm43mmtq01oddj6")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Avatar).HasColumnName("avatar");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("customer_code");

                entity.Property(e => e.Email)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(128)
                    .HasColumnName("firstname");

                entity.Property(e => e.IsEnable)
                    .HasColumnName("is_enable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSeller)
                    .HasColumnName("is_seller")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(128)
                    .HasColumnName("lastname");

                entity.Property(e => e.Password)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Revenue).HasColumnName("revenue");

                entity.Property(e => e.RoleCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("role_code");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<VerificationUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__verifica__B9BE370F894E8330");

                entity.ToTable("verification_user");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.VerifiactionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("verifiaction_code");

                entity.Property(e => e.VerificationType)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("verification_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
