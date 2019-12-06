using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupChat.Identity.Migrations.ConfigurationDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "IdentityResources",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ShowInDiscoveryDocument",
                table: "IdentityResources",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "Required",
                table: "IdentityResources",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "NonEditable",
                table: "IdentityResources",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "IdentityResources",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<bool>(
                name: "Enabled",
                table: "IdentityResources",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "Emphasize",
                table: "IdentityResources",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "IdentityResources",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "IdentityResources",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "IdentityResources",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "IdentityResources",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "IdentityProperties",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "IdentityProperties",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "IdentityResourceId",
                table: "IdentityProperties",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "IdentityProperties",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "IdentityClaims",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "IdentityResourceId",
                table: "IdentityClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "IdentityClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ClientSecrets",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ClientSecrets",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Expiration",
                table: "ClientSecrets",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ClientSecrets",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "ClientSecrets",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientSecrets",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientSecrets",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Scope",
                table: "ClientScopes",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientScopes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientScopes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "UserSsoLifetime",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserCodeType",
                table: "Clients",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "UpdateAccessTokenClaimsOnRefresh",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "SlidingRefreshTokenLifetime",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "RequirePkce",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "RequireConsent",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "RequireClientSecret",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "RefreshTokenUsage",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "RefreshTokenExpiration",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "ProtocolType",
                table: "Clients",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "PairWiseSubjectSalt",
                table: "Clients",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "NonEditable",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "LogoUri",
                table: "Clients",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastAccessed",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IncludeJwtId",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "IdentityTokenLifetime",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "FrontChannelLogoutUri",
                table: "Clients",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FrontChannelLogoutSessionRequired",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "Enabled",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "EnableLocalLogin",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "DeviceCodeLifetime",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Clients",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "ConsentLifetime",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientUri",
                table: "Clients",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientName",
                table: "Clients",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Clients",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ClientClaimsPrefix",
                table: "Clients",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BackChannelLogoutUri",
                table: "Clients",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "BackChannelLogoutSessionRequired",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizationCodeLifetime",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "AlwaysSendClientClaims",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "AlwaysIncludeUserClaimsInIdToken",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "AllowRememberConsent",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "AllowPlainTextPkce",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "AllowOfflineAccess",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "AllowAccessTokensViaBrowser",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "AccessTokenType",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "AccessTokenLifetime",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "AbsoluteRefreshTokenLifetime",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "RedirectUri",
                table: "ClientRedirectUris",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientRedirectUris",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientRedirectUris",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ClientProperties",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "ClientProperties",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientProperties",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientProperties",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PostLogoutRedirectUri",
                table: "ClientPostLogoutRedirectUris",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientPostLogoutRedirectUris",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientPostLogoutRedirectUris",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Provider",
                table: "ClientIdPRestrictions",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientIdPRestrictions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientIdPRestrictions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "GrantType",
                table: "ClientGrantTypes",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientGrantTypes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientGrantTypes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Origin",
                table: "ClientCorsOrigins",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientCorsOrigins",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientCorsOrigins",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ClientClaims",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ClientClaims",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ApiSecrets",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ApiSecrets",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Expiration",
                table: "ApiSecrets",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ApiSecrets",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "ApiSecrets",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "ApiResourceId",
                table: "ApiSecrets",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ApiSecrets",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "ShowInDiscoveryDocument",
                table: "ApiScopes",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "Required",
                table: "ApiScopes",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ApiScopes",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<bool>(
                name: "Emphasize",
                table: "ApiScopes",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "ApiScopes",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ApiScopes",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApiResourceId",
                table: "ApiScopes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ApiScopes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ApiScopeClaims",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "ApiScopeId",
                table: "ApiScopeClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ApiScopeClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "ApiResources",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "NonEditable",
                table: "ApiResources",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ApiResources",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastAccessed",
                table: "ApiResources",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Enabled",
                table: "ApiResources",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "ApiResources",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ApiResources",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "ApiResources",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ApiResources",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ApiProperties",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "ApiProperties",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "ApiResourceId",
                table: "ApiProperties",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ApiProperties",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ApiClaims",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "ApiResourceId",
                table: "ApiClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ApiClaims",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Updated",
                table: "IdentityResources",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ShowInDiscoveryDocument",
                table: "IdentityResources",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "Required",
                table: "IdentityResources",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "NonEditable",
                table: "IdentityResources",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "IdentityResources",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<bool>(
                name: "Enabled",
                table: "IdentityResources",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "Emphasize",
                table: "IdentityResources",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "IdentityResources",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "IdentityResources",
                type: "TEXT",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created",
                table: "IdentityResources",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "IdentityResources",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "IdentityProperties",
                type: "TEXT",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "IdentityProperties",
                type: "TEXT",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "IdentityResourceId",
                table: "IdentityProperties",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "IdentityProperties",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "IdentityClaims",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "IdentityResourceId",
                table: "IdentityClaims",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "IdentityClaims",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ClientSecrets",
                type: "TEXT",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ClientSecrets",
                type: "TEXT",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Expiration",
                table: "ClientSecrets",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ClientSecrets",
                type: "TEXT",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created",
                table: "ClientSecrets",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientSecrets",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientSecrets",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Scope",
                table: "ClientScopes",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientScopes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientScopes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "UserSsoLifetime",
                table: "Clients",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserCodeType",
                table: "Clients",
                type: "TEXT",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Updated",
                table: "Clients",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "UpdateAccessTokenClaimsOnRefresh",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "SlidingRefreshTokenLifetime",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "RequirePkce",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "RequireConsent",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "RequireClientSecret",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "RefreshTokenUsage",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "RefreshTokenExpiration",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ProtocolType",
                table: "Clients",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "PairWiseSubjectSalt",
                table: "Clients",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "NonEditable",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "LogoUri",
                table: "Clients",
                type: "TEXT",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastAccessed",
                table: "Clients",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IncludeJwtId",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "IdentityTokenLifetime",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "FrontChannelLogoutUri",
                table: "Clients",
                type: "TEXT",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FrontChannelLogoutSessionRequired",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "Enabled",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "EnableLocalLogin",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "DeviceCodeLifetime",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Clients",
                type: "TEXT",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created",
                table: "Clients",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "ConsentLifetime",
                table: "Clients",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientUri",
                table: "Clients",
                type: "TEXT",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientName",
                table: "Clients",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Clients",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ClientClaimsPrefix",
                table: "Clients",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BackChannelLogoutUri",
                table: "Clients",
                type: "TEXT",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "BackChannelLogoutSessionRequired",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "AuthorizationCodeLifetime",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "AlwaysSendClientClaims",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "AlwaysIncludeUserClaimsInIdToken",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "AllowRememberConsent",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "AllowPlainTextPkce",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "AllowOfflineAccess",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "AllowAccessTokensViaBrowser",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "AccessTokenType",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AccessTokenLifetime",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AbsoluteRefreshTokenLifetime",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "RedirectUri",
                table: "ClientRedirectUris",
                type: "TEXT",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientRedirectUris",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientRedirectUris",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ClientProperties",
                type: "TEXT",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "ClientProperties",
                type: "TEXT",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientProperties",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientProperties",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PostLogoutRedirectUri",
                table: "ClientPostLogoutRedirectUris",
                type: "TEXT",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientPostLogoutRedirectUris",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientPostLogoutRedirectUris",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Provider",
                table: "ClientIdPRestrictions",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientIdPRestrictions",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientIdPRestrictions",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "GrantType",
                table: "ClientGrantTypes",
                type: "TEXT",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientGrantTypes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientGrantTypes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Origin",
                table: "ClientCorsOrigins",
                type: "TEXT",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientCorsOrigins",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientCorsOrigins",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ClientClaims",
                type: "TEXT",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ClientClaims",
                type: "TEXT",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "ClientClaims",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ClientClaims",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ApiSecrets",
                type: "TEXT",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ApiSecrets",
                type: "TEXT",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Expiration",
                table: "ApiSecrets",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ApiSecrets",
                type: "TEXT",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created",
                table: "ApiSecrets",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "ApiResourceId",
                table: "ApiSecrets",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ApiSecrets",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "ShowInDiscoveryDocument",
                table: "ApiScopes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "Required",
                table: "ApiScopes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ApiScopes",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<bool>(
                name: "Emphasize",
                table: "ApiScopes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "ApiScopes",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ApiScopes",
                type: "TEXT",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApiResourceId",
                table: "ApiScopes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ApiScopes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ApiScopeClaims",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "ApiScopeId",
                table: "ApiScopeClaims",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ApiScopeClaims",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Updated",
                table: "ApiResources",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "NonEditable",
                table: "ApiResources",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ApiResources",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "LastAccessed",
                table: "ApiResources",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Enabled",
                table: "ApiResources",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "ApiResources",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ApiResources",
                type: "TEXT",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created",
                table: "ApiResources",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ApiResources",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ApiProperties",
                type: "TEXT",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "ApiProperties",
                type: "TEXT",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "ApiResourceId",
                table: "ApiProperties",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ApiProperties",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ApiClaims",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "ApiResourceId",
                table: "ApiClaims",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ApiClaims",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
