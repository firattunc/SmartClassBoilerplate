using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartClass.Migrations
{
    public partial class createDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DersAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ils",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IlAd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Velis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Velis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Velis_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Konus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KonuAdi = table.Column<string>(nullable: true),
                    DersId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Konus_Ders_DersId",
                        column: x => x.DersId,
                        principalTable: "Ders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ilces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IlceAd = table.Column<string>(nullable: true),
                    IlId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilces_Ils_IlId",
                        column: x => x.IlId,
                        principalTable: "Ils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AltBasliklars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AltBaslikAdi = table.Column<string>(nullable: true),
                    KonuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltBasliklars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AltBasliklars_Konus_KonuId",
                        column: x => x.KonuId,
                        principalTable: "Konus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sorus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImgUrl = table.Column<string>(nullable: true),
                    Cevap = table.Column<string>(nullable: true),
                    DersId = table.Column<int>(nullable: false),
                    KonuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sorus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sorus_Ders_DersId",
                        column: x => x.DersId,
                        principalTable: "Ders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sorus_Konus_KonuId",
                        column: x => x.KonuId,
                        principalTable: "Konus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Okuls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OkulAdi = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    IlceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Okuls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Okuls_Ilces_IlceId",
                        column: x => x.IlceId,
                        principalTable: "Ilces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoruAltBasliks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AltBaslikId = table.Column<int>(nullable: false),
                    SoruId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoruAltBasliks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoruAltBasliks_AltBasliklars_AltBaslikId",
                        column: x => x.AltBaslikId,
                        principalTable: "AltBasliklars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoruAltBasliks_Sorus_SoruId",
                        column: x => x.SoruId,
                        principalTable: "Sorus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    No = table.Column<int>(nullable: false),
                    OkulId = table.Column<int>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Okuls_OkulId",
                        column: x => x.OkulId,
                        principalTable: "Okuls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ogrencis_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OkulId = table.Column<int>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogretmens_Okuls_OkulId",
                        column: x => x.OkulId,
                        principalTable: "Okuls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ogretmens_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenelIstatistiks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DogruSayisi = table.Column<int>(nullable: false),
                    OgrenciId = table.Column<int>(nullable: false),
                    AltBaslikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenelIstatistiks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenelIstatistiks_AltBasliklars_AltBaslikId",
                        column: x => x.AltBaslikId,
                        principalTable: "AltBasliklars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenelIstatistiks_Ogrencis_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrencis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciVelisis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VeliId = table.Column<int>(nullable: false),
                    OgrenciId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciVelisis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgrenciVelisis_Ogrencis_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrencis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciVelisis_Velis_VeliId",
                        column: x => x.VeliId,
                        principalTable: "Velis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TestSonucs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tarih = table.Column<DateTime>(nullable: false),
                    BitisTarih = table.Column<DateTime>(nullable: false),
                    DogruSayisi = table.Column<int>(nullable: false),
                    OgrenciId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSonucs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestSonucs_Ogrencis_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrencis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciOgretmenis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OgrenciId = table.Column<int>(nullable: false),
                    OgretmenId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciOgretmenis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgrenciOgretmenis_Ogrencis_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrencis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciOgretmenis_Ogretmens_OgretmenId",
                        column: x => x.OgretmenId,
                        principalTable: "Ogretmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cevaps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tarih = table.Column<DateTime>(nullable: false),
                    IsTrue = table.Column<string>(nullable: true),
                    SoruId = table.Column<int>(nullable: false),
                    OgrenciId = table.Column<int>(nullable: false),
                    TestSonucId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cevaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cevaps_Ogrencis_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrencis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cevaps_Sorus_SoruId",
                        column: x => x.SoruId,
                        principalTable: "Sorus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cevaps_TestSonucs_TestSonucId",
                        column: x => x.TestSonucId,
                        principalTable: "TestSonucs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Yorums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Metin = table.Column<string>(nullable: true),
                    Tarih = table.Column<DateTime>(nullable: false),
                    OgrenciId = table.Column<int>(nullable: false),
                    TestSonucId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yorums_Ogrencis_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrencis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yorums_TestSonucs_TestSonucId",
                        column: x => x.TestSonucId,
                        principalTable: "TestSonucs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AltBasliklars_KonuId",
                table: "AltBasliklars",
                column: "KonuId");

            migrationBuilder.CreateIndex(
                name: "IX_Cevaps_OgrenciId",
                table: "Cevaps",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_Cevaps_SoruId",
                table: "Cevaps",
                column: "SoruId");

            migrationBuilder.CreateIndex(
                name: "IX_Cevaps_TestSonucId",
                table: "Cevaps",
                column: "TestSonucId");

            migrationBuilder.CreateIndex(
                name: "IX_GenelIstatistiks_AltBaslikId",
                table: "GenelIstatistiks",
                column: "AltBaslikId");

            migrationBuilder.CreateIndex(
                name: "IX_GenelIstatistiks_OgrenciId",
                table: "GenelIstatistiks",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilces_IlId",
                table: "Ilces",
                column: "IlId");

            migrationBuilder.CreateIndex(
                name: "IX_Konus_DersId",
                table: "Konus",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciOgretmenis_OgrenciId",
                table: "OgrenciOgretmenis",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciOgretmenis_OgretmenId",
                table: "OgrenciOgretmenis",
                column: "OgretmenId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_OkulId",
                table: "Ogrencis",
                column: "OkulId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_UserId",
                table: "Ogrencis",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciVelisis_OgrenciId",
                table: "OgrenciVelisis",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciVelisis_VeliId",
                table: "OgrenciVelisis",
                column: "VeliId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmens_OkulId",
                table: "Ogretmens",
                column: "OkulId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmens_UserId",
                table: "Ogretmens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Okuls_IlceId",
                table: "Okuls",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_SoruAltBasliks_AltBaslikId",
                table: "SoruAltBasliks",
                column: "AltBaslikId");

            migrationBuilder.CreateIndex(
                name: "IX_SoruAltBasliks_SoruId",
                table: "SoruAltBasliks",
                column: "SoruId");

            migrationBuilder.CreateIndex(
                name: "IX_Sorus_DersId",
                table: "Sorus",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_Sorus_KonuId",
                table: "Sorus",
                column: "KonuId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSonucs_OgrenciId",
                table: "TestSonucs",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_Velis_UserId",
                table: "Velis",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorums_OgrenciId",
                table: "Yorums",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorums_TestSonucId",
                table: "Yorums",
                column: "TestSonucId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cevaps");

            migrationBuilder.DropTable(
                name: "GenelIstatistiks");

            migrationBuilder.DropTable(
                name: "OgrenciOgretmenis");

            migrationBuilder.DropTable(
                name: "OgrenciVelisis");

            migrationBuilder.DropTable(
                name: "SoruAltBasliks");

            migrationBuilder.DropTable(
                name: "Yorums");

            migrationBuilder.DropTable(
                name: "Ogretmens");

            migrationBuilder.DropTable(
                name: "Velis");

            migrationBuilder.DropTable(
                name: "AltBasliklars");

            migrationBuilder.DropTable(
                name: "Sorus");

            migrationBuilder.DropTable(
                name: "TestSonucs");

            migrationBuilder.DropTable(
                name: "Konus");

            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "Ders");

            migrationBuilder.DropTable(
                name: "Okuls");

            migrationBuilder.DropTable(
                name: "Ilces");

            migrationBuilder.DropTable(
                name: "Ils");
        }
    }
}
