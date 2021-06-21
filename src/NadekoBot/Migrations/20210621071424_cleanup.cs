﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NadekoBot.Migrations
{
    public partial class cleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "DELETE FROM __EFMigrationsHistory WHERE __EFMigrationsHistory.MigrationId <> '20210621042359_squash'");
            
            migrationBuilder.DropForeignKey(
                name: "FK_GuildConfigs_Permission_RootPermissionId",
                table: "GuildConfigs");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Stakes");

            migrationBuilder.DropIndex(
                name: "IX_GuildConfigs_RootPermissionId",
                table: "GuildConfigs");

            migrationBuilder.DropColumn(
                name: "NotifyMessage",
                table: "XpSettings");

            migrationBuilder.DropColumn(
                name: "XpRoleRewardExclusive",
                table: "XpSettings");

            migrationBuilder.DropColumn(
                name: "Item",
                table: "WaifuItem");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "WaifuItem");

            migrationBuilder.DropColumn(
                name: "UseCount",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "ChannelCreated",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "ChannelDestroyed",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "ChannelId",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "ChannelUpdated",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "IsLogging",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "LogUserPresence",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "LogVoicePresence",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "MessageDeleted",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "MessageUpdated",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "UserBanned",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "UserJoined",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "UserLeft",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "UserPresenceChannelId",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "UserUnbanned",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "UserUpdated",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "VoicePresenceChannelId",
                table: "LogSettings");

            migrationBuilder.DropColumn(
                name: "AutoAssignRoleId",
                table: "GuildConfigs");

            migrationBuilder.DropColumn(
                name: "AutoDcFromVc",
                table: "GuildConfigs");

            migrationBuilder.DropColumn(
                name: "DefaultMusicVolume",
                table: "GuildConfigs");

            migrationBuilder.DropColumn(
                name: "RootPermissionId",
                table: "GuildConfigs");

            migrationBuilder.DropColumn(
                name: "VoicePlusTextEnabled",
                table: "GuildConfigs");

            migrationBuilder.DropColumn(
                name: "IsRegex",
                table: "CustomReactions");

            migrationBuilder.DropColumn(
                name: "OwnerOnly",
                table: "CustomReactions");

            migrationBuilder.DropColumn(
                name: "UseCount",
                table: "CustomReactions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NotifyMessage",
                table: "XpSettings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "XpRoleRewardExclusive",
                table: "XpSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Item",
                table: "WaifuItem",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "WaifuItem",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<ulong>(
                name: "UseCount",
                table: "Quotes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0ul);

            migrationBuilder.AddColumn<bool>(
                name: "ChannelCreated",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ChannelDestroyed",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<ulong>(
                name: "ChannelId",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0ul);

            migrationBuilder.AddColumn<bool>(
                name: "ChannelUpdated",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLogging",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LogUserPresence",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LogVoicePresence",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MessageDeleted",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MessageUpdated",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UserBanned",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UserJoined",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UserLeft",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<ulong>(
                name: "UserPresenceChannelId",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0ul);

            migrationBuilder.AddColumn<bool>(
                name: "UserUnbanned",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UserUpdated",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<ulong>(
                name: "VoicePresenceChannelId",
                table: "LogSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0ul);

            migrationBuilder.AddColumn<ulong>(
                name: "AutoAssignRoleId",
                table: "GuildConfigs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0ul);

            migrationBuilder.AddColumn<bool>(
                name: "AutoDcFromVc",
                table: "GuildConfigs",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "DefaultMusicVolume",
                table: "GuildConfigs",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "RootPermissionId",
                table: "GuildConfigs",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "VoicePlusTextEnabled",
                table: "GuildConfigs",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRegex",
                table: "CustomReactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OwnerOnly",
                table: "CustomReactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<ulong>(
                name: "UseCount",
                table: "CustomReactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0ul);

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: true),
                    NextId = table.Column<int>(type: "INTEGER", nullable: true),
                    PrimaryTarget = table.Column<int>(type: "INTEGER", nullable: false),
                    PrimaryTargetId = table.Column<ulong>(type: "INTEGER", nullable: false),
                    SecondaryTarget = table.Column<int>(type: "INTEGER", nullable: false),
                    SecondaryTargetName = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permission_Permission_NextId",
                        column: x => x.NextId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Amount = table.Column<long>(type: "INTEGER", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Source = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<ulong>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stakes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuildConfigs_RootPermissionId",
                table: "GuildConfigs",
                column: "RootPermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_NextId",
                table: "Permission",
                column: "NextId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GuildConfigs_Permission_RootPermissionId",
                table: "GuildConfigs",
                column: "RootPermissionId",
                principalTable: "Permission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
