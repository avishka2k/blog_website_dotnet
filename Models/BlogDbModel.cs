namespace blogsite_asp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BlogDbModel : DbContext
    {
        public BlogDbModel()
            : base("name=BlogDbModel")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<BlogCategory> BlogCategories { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<BlogTag> BlogTags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<BlogCategory>()
                .Property(e => e.category_name)
                .IsUnicode(false);

            modelBuilder.Entity<BlogCategory>()
                .Property(e => e.category_image_url)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.blog_title)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.blog_category)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.publish_status)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.publish_date)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.blog_tags)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.blog_content)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.blog_imageurl)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.blog_owner)
                .IsUnicode(false);

            modelBuilder.Entity<BlogTag>()
                .Property(e => e.tag_name)
                .IsUnicode(false);
        }
    }
}
