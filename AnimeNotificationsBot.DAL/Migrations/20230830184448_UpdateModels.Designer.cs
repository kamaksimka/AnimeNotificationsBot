﻿// <auto-generated />
using System;
using AnimeNotificationsBot.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AnimeNotificationsBot.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230830184448_UpdateModels")]
    partial class UpdateModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AnimeDubbing", b =>
                {
                    b.Property<long>("AnimesId")
                        .HasColumnType("bigint")
                        .HasColumnName("animes_id");

                    b.Property<long>("DubbingId")
                        .HasColumnType("bigint")
                        .HasColumnName("dubbing_id");

                    b.HasKey("AnimesId", "DubbingId")
                        .HasName("pk_anime_dubbing");

                    b.HasIndex("DubbingId")
                        .HasDatabaseName("ix_anime_dubbing_dubbing_id");

                    b.ToTable("anime_dubbing", (string)null);
                });

            modelBuilder.Entity("AnimeDubbing1", b =>
                {
                    b.Property<long>("DubbingFromFirstEpisodeId")
                        .HasColumnType("bigint")
                        .HasColumnName("dubbing_from_first_episode_id");

                    b.Property<long>("FirstEpisodeAnimesId")
                        .HasColumnType("bigint")
                        .HasColumnName("first_episode_animes_id");

                    b.HasKey("DubbingFromFirstEpisodeId", "FirstEpisodeAnimesId")
                        .HasName("pk_anime_dubbing1");

                    b.HasIndex("FirstEpisodeAnimesId")
                        .HasDatabaseName("ix_anime_dubbing1_first_episode_animes_id");

                    b.ToTable("anime_dubbing1", (string)null);
                });

            modelBuilder.Entity("AnimeGenre", b =>
                {
                    b.Property<long>("AnimesId")
                        .HasColumnType("bigint")
                        .HasColumnName("animes_id");

                    b.Property<long>("GenresId")
                        .HasColumnType("bigint")
                        .HasColumnName("genres_id");

                    b.HasKey("AnimesId", "GenresId")
                        .HasName("pk_anime_genre");

                    b.HasIndex("GenresId")
                        .HasDatabaseName("ix_anime_genre_genres_id");

                    b.ToTable("anime_genre", (string)null);
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.Anime", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int?>("Completed")
                        .HasColumnType("integer")
                        .HasColumnName("completed");

                    b.Property<int?>("CountEpisode")
                        .HasColumnType("integer")
                        .HasColumnName("count_episode");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int?>("Dropped")
                        .HasColumnType("integer")
                        .HasColumnName("dropped");

                    b.Property<string>("Duration")
                        .HasColumnType("text")
                        .HasColumnName("duration");

                    b.Property<string>("Href")
                        .HasColumnType("text")
                        .HasColumnName("href");

                    b.Property<long?>("IdForComments")
                        .HasColumnType("bigint")
                        .HasColumnName("id_for_comments");

                    b.Property<long>("IdFromAnimeGo")
                        .HasColumnType("bigint")
                        .HasColumnName("id_from_anime_go");

                    b.Property<string>("ImgHref")
                        .HasColumnType("text")
                        .HasColumnName("img_href");

                    b.Property<long?>("MpaaRateId")
                        .HasColumnType("bigint")
                        .HasColumnName("mpaa_rate_id");

                    b.Property<string>("NextEpisode")
                        .HasColumnType("text")
                        .HasColumnName("next_episode");

                    b.Property<int?>("OnHold")
                        .HasColumnType("integer")
                        .HasColumnName("on_hold");

                    b.Property<int?>("Planned")
                        .HasColumnType("integer")
                        .HasColumnName("planned");

                    b.Property<double?>("Rate")
                        .HasColumnType("double precision")
                        .HasColumnName("rate");

                    b.Property<long?>("StatusId")
                        .HasColumnType("bigint")
                        .HasColumnName("status_id");

                    b.Property<string>("TitleEn")
                        .HasColumnType("text")
                        .HasColumnName("title_en");

                    b.Property<string>("TitleRu")
                        .HasColumnType("text")
                        .HasColumnName("title_ru");

                    b.Property<long?>("TypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("type_id");

                    b.Property<int?>("Watching")
                        .HasColumnType("integer")
                        .HasColumnName("watching");

                    b.Property<int?>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.HasKey("Id")
                        .HasName("pk_animes");

                    b.HasIndex("IdFromAnimeGo")
                        .IsUnique()
                        .HasDatabaseName("ix_animes_id_from_anime_go");

                    b.HasIndex("MpaaRateId")
                        .HasDatabaseName("ix_animes_mpaa_rate_id");

                    b.HasIndex("StatusId")
                        .HasDatabaseName("ix_animes_status_id");

                    b.HasIndex("TypeId")
                        .HasDatabaseName("ix_animes_type_id");

                    b.ToTable("animes", (string)null);
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.AnimeComment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AnimeId")
                        .HasColumnType("bigint")
                        .HasColumnName("anime_id");

                    b.Property<string>("AuthorName")
                        .HasColumnType("text")
                        .HasColumnName("author_name");

                    b.Property<string>("Comment")
                        .HasColumnType("text")
                        .HasColumnName("comment");

                    b.Property<long>("CommentId")
                        .HasColumnType("bigint")
                        .HasColumnName("comment_id");

                    b.Property<DateTimeOffset?>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<long?>("ParentCommentId")
                        .HasColumnType("bigint")
                        .HasColumnName("parent_comment_id");

                    b.Property<int?>("Score")
                        .HasColumnType("integer")
                        .HasColumnName("score");

                    b.HasKey("Id")
                        .HasName("pk_anime_comments");

                    b.HasIndex("AnimeId")
                        .HasDatabaseName("ix_anime_comments_anime_id");

                    b.HasIndex("CommentId")
                        .IsUnique()
                        .HasDatabaseName("ix_anime_comments_comment_id");

                    b.HasIndex("ParentCommentId")
                        .HasDatabaseName("ix_anime_comments_parent_comment_id");

                    b.ToTable("anime_comments", (string)null);
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.AnimeNotification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AnimeId")
                        .HasColumnType("bigint")
                        .HasColumnName("anime_id");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<long>("DubbingId")
                        .HasColumnType("bigint")
                        .HasColumnName("dubbing_id");

                    b.Property<string>("Href")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("href");

                    b.Property<bool>("IsNotified")
                        .HasColumnType("boolean")
                        .HasColumnName("is_notified");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("integer")
                        .HasColumnName("serial_number");

                    b.Property<string>("TitleAnime")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title_anime");

                    b.HasKey("Id")
                        .HasName("pk_anime_notifications");

                    b.HasIndex("AnimeId")
                        .HasDatabaseName("ix_anime_notifications_anime_id");

                    b.HasIndex("DubbingId")
                        .HasDatabaseName("ix_anime_notifications_dubbing_id");

                    b.ToTable("anime_notifications", (string)null);
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.AnimeStatus", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("boolean")
                        .HasColumnName("is_removed");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_anime_statuses");

                    b.HasIndex("Title")
                        .IsUnique()
                        .HasDatabaseName("ix_anime_statuses_title");

                    b.ToTable("anime_statuses", (string)null);
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.AnimeSubscription", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AnimeId")
                        .HasColumnType("bigint")
                        .HasColumnName("anime_id");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<long>("DubbingId")
                        .HasColumnType("bigint")
                        .HasColumnName("dubbing_id");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("boolean")
                        .HasColumnName("is_removed");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_anime_subscription");

                    b.HasIndex("AnimeId")
                        .HasDatabaseName("ix_anime_subscription_anime_id");

                    b.HasIndex("DubbingId")
                        .HasDatabaseName("ix_anime_subscription_dubbing_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_anime_subscription_user_id");

                    b.ToTable("anime_subscription", (string)null);
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.AnimeType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("boolean")
                        .HasColumnName("is_removed");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_anime_types");

                    b.HasIndex("Title")
                        .IsUnique()
                        .HasDatabaseName("ix_anime_types_title");

                    b.ToTable("anime_types", (string)null);
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.Dubbing", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("boolean")
                        .HasColumnName("is_removed");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_dubbing");

                    b.HasIndex("Title")
                        .IsUnique()
                        .HasDatabaseName("ix_dubbing_title");

                    b.ToTable("dubbing", (string)null);
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.Genre", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("boolean")
                        .HasColumnName("is_removed");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_genres");

                    b.HasIndex("Title")
                        .IsUnique()
                        .HasDatabaseName("ix_genres_title");

                    b.ToTable("genres", (string)null);
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.MpaaRate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("boolean")
                        .HasColumnName("is_removed");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_mpaa_rates");

                    b.HasIndex("Title")
                        .IsUnique()
                        .HasDatabaseName("ix_mpaa_rates_title");

                    b.ToTable("mpaa_rates", (string)null);
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.Studio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("boolean")
                        .HasColumnName("is_removed");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_studios");

                    b.HasIndex("Title")
                        .IsUnique()
                        .HasDatabaseName("ix_studios_title");

                    b.ToTable("studios", (string)null);
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("boolean")
                        .HasColumnName("is_removed");

                    b.Property<string>("LastName")
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<long>("TelegramChatId")
                        .HasColumnType("bigint")
                        .HasColumnName("telegram_chat_id");

                    b.Property<long>("TelegramUserId")
                        .HasColumnType("bigint")
                        .HasColumnName("telegram_user_id");

                    b.Property<string>("UserName")
                        .HasColumnType("text")
                        .HasColumnName("user_name");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("TelegramChatId")
                        .IsUnique()
                        .HasDatabaseName("ix_users_telegram_chat_id");

                    b.HasIndex("TelegramUserId")
                        .IsUnique()
                        .HasDatabaseName("ix_users_telegram_user_id");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("AnimeStudio", b =>
                {
                    b.Property<long>("AnimesId")
                        .HasColumnType("bigint")
                        .HasColumnName("animes_id");

                    b.Property<long>("StudiosId")
                        .HasColumnType("bigint")
                        .HasColumnName("studios_id");

                    b.HasKey("AnimesId", "StudiosId")
                        .HasName("pk_anime_studio");

                    b.HasIndex("StudiosId")
                        .HasDatabaseName("ix_anime_studio_studios_id");

                    b.ToTable("anime_studio", (string)null);
                });

            modelBuilder.Entity("AnimeDubbing", b =>
                {
                    b.HasOne("AnimeNotificationsBot.DAL.Entities.Anime", null)
                        .WithMany()
                        .HasForeignKey("AnimesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_anime_dubbing_animes_animes_id");

                    b.HasOne("AnimeNotificationsBot.DAL.Entities.Dubbing", null)
                        .WithMany()
                        .HasForeignKey("DubbingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_anime_dubbing_dubbing_dubbing_id");
                });

            modelBuilder.Entity("AnimeDubbing1", b =>
                {
                    b.HasOne("AnimeNotificationsBot.DAL.Entities.Dubbing", null)
                        .WithMany()
                        .HasForeignKey("DubbingFromFirstEpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_anime_dubbing1_dubbing_dubbing_from_first_episode_id");

                    b.HasOne("AnimeNotificationsBot.DAL.Entities.Anime", null)
                        .WithMany()
                        .HasForeignKey("FirstEpisodeAnimesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_anime_dubbing1_animes_first_episode_animes_id");
                });

            modelBuilder.Entity("AnimeGenre", b =>
                {
                    b.HasOne("AnimeNotificationsBot.DAL.Entities.Anime", null)
                        .WithMany()
                        .HasForeignKey("AnimesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_anime_genre_animes_animes_id");

                    b.HasOne("AnimeNotificationsBot.DAL.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_anime_genre_genres_genres_id");
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.Anime", b =>
                {
                    b.HasOne("AnimeNotificationsBot.DAL.Entities.MpaaRate", "MpaaRate")
                        .WithMany("Animes")
                        .HasForeignKey("MpaaRateId")
                        .HasConstraintName("fk_animes_mpaa_rates_mpaa_rate_id");

                    b.HasOne("AnimeNotificationsBot.DAL.Entities.AnimeStatus", "Status")
                        .WithMany("Animes")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("fk_animes_anime_statuses_status_id");

                    b.HasOne("AnimeNotificationsBot.DAL.Entities.AnimeType", "Type")
                        .WithMany("Animes")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("fk_animes_anime_types_type_id");

                    b.Navigation("MpaaRate");

                    b.Navigation("Status");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.AnimeComment", b =>
                {
                    b.HasOne("AnimeNotificationsBot.DAL.Entities.Anime", "Anime")
                        .WithMany("Comments")
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_anime_comments_animes_anime_id");

                    b.HasOne("AnimeNotificationsBot.DAL.Entities.AnimeComment", "ParentComment")
                        .WithMany("Children")
                        .HasForeignKey("ParentCommentId")
                        .HasConstraintName("fk_anime_comments_anime_comments_parent_comment_id");

                    b.Navigation("Anime");

                    b.Navigation("ParentComment");
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.AnimeNotification", b =>
                {
                    b.HasOne("AnimeNotificationsBot.DAL.Entities.Anime", "Anime")
                        .WithMany()
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_anime_notifications_animes_anime_id");

                    b.HasOne("AnimeNotificationsBot.DAL.Entities.Dubbing", "Dubbing")
                        .WithMany("AnimeNotifications")
                        .HasForeignKey("DubbingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_anime_notifications_dubbing_dubbing_id");

                    b.Navigation("Anime");

                    b.Navigation("Dubbing");
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.AnimeSubscription", b =>
                {
                    b.HasOne("AnimeNotificationsBot.DAL.Entities.Anime", "Anime")
                        .WithMany("AnimeSubscriptions")
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_anime_subscription_animes_anime_id");

                    b.HasOne("AnimeNotificationsBot.DAL.Entities.Dubbing", "Dubbing")
                        .WithMany("AnimeSubscriptions")
                        .HasForeignKey("DubbingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_anime_subscription_dubbing_dubbing_id");

                    b.HasOne("AnimeNotificationsBot.DAL.Entities.User", "User")
                        .WithMany("AnimeSubscriptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_anime_subscription_users_user_id");

                    b.Navigation("Anime");

                    b.Navigation("Dubbing");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AnimeStudio", b =>
                {
                    b.HasOne("AnimeNotificationsBot.DAL.Entities.Anime", null)
                        .WithMany()
                        .HasForeignKey("AnimesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_anime_studio_animes_animes_id");

                    b.HasOne("AnimeNotificationsBot.DAL.Entities.Studio", null)
                        .WithMany()
                        .HasForeignKey("StudiosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_anime_studio_studios_studios_id");
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.Anime", b =>
                {
                    b.Navigation("AnimeSubscriptions");

                    b.Navigation("Comments");
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.AnimeComment", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.AnimeStatus", b =>
                {
                    b.Navigation("Animes");
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.AnimeType", b =>
                {
                    b.Navigation("Animes");
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.Dubbing", b =>
                {
                    b.Navigation("AnimeNotifications");

                    b.Navigation("AnimeSubscriptions");
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.MpaaRate", b =>
                {
                    b.Navigation("Animes");
                });

            modelBuilder.Entity("AnimeNotificationsBot.DAL.Entities.User", b =>
                {
                    b.Navigation("AnimeSubscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
