﻿using AnimeNotificationsBot.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AnimeNotificationsBot.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<Anime> Animes { get; set; } = null!;
        public DbSet<AnimeComment> AnimeComments { get; set; } = null!;
        public DbSet<AnimeNotification> AnimeNotifications { get; set; } = null!;
        public DbSet<Dubbing> Dubbing { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Studio> Studios { get; set; } = null!;
        public DbSet<MpaaRate> MpaaRates { get; set; } = null!;
        public DbSet<AnimeType> AnimeTypes { get; set; } = null!;
        public DbSet<AnimeStatus> AnimeStatuses { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<BotMessage> BotMessages { get; set; } = null!;
        public DbSet<BotMessageGroup> BotMessageGroups { get; set; } = null!;
        public DbSet<CallbackQueryData> CallbackQueryData { get; set; } = null!;
        public DbSet<AnimeSubscription> AnimeSubscriptions { get; set; } = null!;
        public DbSet<Feedback> Feedbacks { get; set; } = null!;
        public DbSet<Episode> Episodes { get; set; } = null!;
        public DbSet<VideoProvider> VideoProviders { get; set; }
        public DbSet<VideoInfo> VideoInfo { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimeComment>()
                .HasMany(x => x.Children)
                .WithOne(x => x.ParentComment)
                .HasForeignKey(x => x.ParentCommentId);

            modelBuilder.Entity<Dubbing>().HasIndex(x => x.Title).IsUnique();

            modelBuilder.Entity<Genre>().HasIndex(x => x.Title).IsUnique();

            modelBuilder.Entity<Studio>().HasIndex(x => x.Title).IsUnique();

            modelBuilder.Entity<MpaaRate>().HasIndex(x => x.Title).IsUnique();

            modelBuilder.Entity<AnimeType>().HasIndex(x => x.Title).IsUnique();

            modelBuilder.Entity<AnimeStatus>().HasIndex(x => x.Title).IsUnique();

            modelBuilder.Entity<VideoProvider>().HasIndex(x => x.Name).IsUnique();

            modelBuilder.Entity<Anime>().HasIndex(x => x.AnimeIdFromAnimeGo).IsUnique();

            modelBuilder.Entity<User>().HasIndex(x => x.TelegramUserId).IsUnique();
            modelBuilder.Entity<User>().HasIndex(x => x.TelegramChatId).IsUnique();

            modelBuilder.Entity<AnimeNotification>().HasIndex(x => new { x.AnimeId, x.DubbingId, x.EpisodeId }).IsUnique();

            modelBuilder.Entity<BotMessage>().HasIndex(x => x.MessageId).IsUnique();

            modelBuilder.Entity<Episode>().HasIndex(x => x.EpisodeIdFromAnimeGo).IsUnique();
        }

        public static void Configure(DbContextOptionsBuilder optionsBuilder, string dbSettings)
        {
            optionsBuilder.UseNpgsql(dbSettings, options => options.MigrationsAssembly(typeof(DataContext).Assembly.GetName().Name));

            optionsBuilder.UseSnakeCaseNamingConvention();

        }
    }
}
