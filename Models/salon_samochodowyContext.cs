using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarDealerSupportSystem.Models
{
    public partial class salon_samochodowyContext : DbContext
    {
        public salon_samochodowyContext()
        {
        }

        public salon_samochodowyContext(DbContextOptions<salon_samochodowyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Klienci> Klienci { get; set; }
        public virtual DbSet<Logi> Logi { get; set; }
        public virtual DbSet<Mozliweuslugisamochody> Mozliweuslugisamochody { get; set; }
        public virtual DbSet<PakietyPromocyjne> PakietyPromocyjne { get; set; }
        public virtual DbSet<PakietySamochody> PakietySamochody { get; set; }
        public virtual DbSet<PakietyUslugi> PakietyUslugi { get; set; }
        public virtual DbSet<Pracownicy> Pracownicy { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Salony> Salony { get; set; }
        public virtual DbSet<Samochody> Samochody { get; set; }
        public virtual DbSet<Uslugi> Uslugi { get; set; }
        public virtual DbSet<Zamowienia> Zamowienia { get; set; }
        public virtual DbSet<ZamowieniaSamochodyUslugi> ZamowieniaSamochodyUslugi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;database=cdss;uid=root", x => x.ServerVersion("10.4.28-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Klienci>(entity =>
            {
                entity.HasKey(e => e.IdKlienta)
                    .HasName("PRIMARY");

                entity.ToTable("klienci");

                entity.Property(e => e.IdKlienta)
                    .HasColumnName("id_klienta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Adres)
                    .HasColumnName("adres")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Imie)
                    .HasColumnName("imie")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Nazwisko)
                    .HasColumnName("nazwisko")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Telefon)
                    .HasColumnName("telefon")
                    .HasColumnType("varchar(9)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Logi>(entity =>
            {
                entity.HasKey(e => e.IdLogu)
                    .HasName("PRIMARY");

                entity.ToTable("logi");

                entity.Property(e => e.IdLogu)
                    .HasColumnName("id_logu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataGodzina)
                    .HasColumnName("Data_godzina")
                    .HasColumnType("datetime");

                entity.Property(e => e.Typ)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Wiadomosc)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Mozliweuslugisamochody>(entity =>
            {
                entity.HasKey(e => new { e.IdSamochodu, e.IdUslugi })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("mozliweuslugisamochody");

                entity.HasIndex(e => e.IdUslugi)
                    .HasName("FK_ASS_16");

                entity.Property(e => e.IdSamochodu)
                    .HasColumnName("id_samochodu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUslugi)
                    .HasColumnName("id_uslugi")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdSamochoduNavigation)
                    .WithMany(p => p.Mozliweuslugisamochody)
                    .HasForeignKey(d => d.IdSamochodu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASS_15");

                entity.HasOne(d => d.IdUslugiNavigation)
                    .WithMany(p => p.Mozliweuslugisamochody)
                    .HasForeignKey(d => d.IdUslugi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASS_16");
            });

            modelBuilder.Entity<PakietyPromocyjne>(entity =>
            {
                entity.HasKey(e => e.IdPakietu)
                    .HasName("PRIMARY");

                entity.ToTable("pakiety_promocyjne");

                entity.Property(e => e.IdPakietu)
                    .HasColumnName("id_pakietu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataRozpoczecia)
                    .HasColumnName("data_rozpoczecia")
                    .HasColumnType("date");

                entity.Property(e => e.DataZakonczenia)
                    .HasColumnName("data_zakonczenia")
                    .HasColumnType("date");

                entity.Property(e => e.NazwaPakietu)
                    .HasColumnName("nazwa_pakietu")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<PakietySamochody>(entity =>
            {
                entity.HasKey(e => new { e.IdSamochodu, e.IdPakietu })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pakiety_samochody");

                entity.HasIndex(e => e.IdPakietu)
                    .HasName("FK_ASS_2");

                entity.Property(e => e.IdSamochodu)
                    .HasColumnName("id_samochodu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPakietu)
                    .HasColumnName("id_pakietu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WysokoscPromocji)
                    .HasColumnName("wysokosc_promocji")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdPakietuNavigation)
                    .WithMany(p => p.PakietySamochody)
                    .HasForeignKey(d => d.IdPakietu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASS_2");

                entity.HasOne(d => d.IdSamochoduNavigation)
                    .WithMany(p => p.PakietySamochody)
                    .HasForeignKey(d => d.IdSamochodu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASS_1");
            });

            modelBuilder.Entity<PakietyUslugi>(entity =>
            {
                entity.HasKey(e => new { e.IdUslugi, e.IdPakietu })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pakiety_uslugi");

                entity.HasIndex(e => e.IdPakietu)
                    .HasName("FK_ASS_4");

                entity.Property(e => e.IdUslugi)
                    .HasColumnName("id_uslugi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPakietu)
                    .HasColumnName("id_pakietu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WysokoscPromocji)
                    .HasColumnName("wysokosc_promocji")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdPakietuNavigation)
                    .WithMany(p => p.PakietyUslugi)
                    .HasForeignKey(d => d.IdPakietu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASS_4");

                entity.HasOne(d => d.IdUslugiNavigation)
                    .WithMany(p => p.PakietyUslugi)
                    .HasForeignKey(d => d.IdUslugi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ASS_3");
            });

            modelBuilder.Entity<Pracownicy>(entity =>
            {
                entity.HasKey(e => e.IdPracownika)
                    .HasName("PRIMARY");

                entity.ToTable("pracownicy");

                entity.HasIndex(e => e.IdSalonu)
                    .HasName("Pracownicy_Salony_FK");

                entity.HasIndex(e => e.KodRoli)
                    .HasName("Pracownicy_Role_FK");

                entity.Property(e => e.IdPracownika)
                    .HasColumnName("id_pracownika")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Adres)
                    .HasColumnName("adres")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Haslo)
                    .HasColumnName("haslo")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IdSalonu)
                    .HasColumnName("id_salonu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Imie)
                    .HasColumnName("imie")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.KodRoli)
                    .IsRequired()
                    .HasColumnName("kod_roli")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Nazwisko)
                    .HasColumnName("nazwisko")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Telefon)
                    .HasColumnName("telefon")
                    .HasColumnType("varchar(9)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasOne(d => d.IdSalonuNavigation)
                    .WithMany(p => p.Pracownicy)
                    .HasForeignKey(d => d.IdSalonu)
                    .HasConstraintName("Pracownicy_Salony_FK");

                entity.HasOne(d => d.KodRoliNavigation)
                    .WithMany(p => p.Pracownicy)
                    .HasForeignKey(d => d.KodRoli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Pracownicy_Role_FK");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.KodRoli)
                    .HasName("PRIMARY");

                entity.ToTable("role");

                entity.Property(e => e.KodRoli)
                    .HasColumnName("kod_roli")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Nazwa)
                    .HasColumnName("nazwa")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Salony>(entity =>
            {
                entity.HasKey(e => e.IdSalonu)
                    .HasName("PRIMARY");

                entity.ToTable("salony");

                entity.Property(e => e.IdSalonu)
                    .HasColumnName("id_salonu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KodPocztowy)
                    .HasColumnName("kod_pocztowy")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Miejscowosc)
                    .HasColumnName("miejscowosc")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Ulica)
                    .HasColumnName("ulica")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Samochody>(entity =>
            {
                entity.HasKey(e => e.IdSamochodu)
                    .HasName("PRIMARY");

                entity.ToTable("samochody");

                entity.HasIndex(e => e.IdSalonu)
                    .HasName("Samochody_Salony_FK");

                entity.Property(e => e.IdSamochodu)
                    .HasColumnName("id_samochodu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CenaPodstawowa)
                    .HasColumnName("Cena_podstawowa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dostepnosc)
                    .HasColumnName("dostepnosc")
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IdSalonu)
                    .HasColumnName("id_salonu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IloscMiejsc)
                    .HasColumnName("ilosc_miejsc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Kolor)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LiczbaDrzwi)
                    .HasColumnName("liczba_drzwi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Marka)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MocSilnika)
                    .HasColumnName("Moc_silnika")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Model)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Rabat).HasColumnType("int(11)");

                entity.Property(e => e.RokProdukcji)
                    .HasColumnName("rok_produkcji")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SrednieSpalanie)
                    .HasColumnName("Srednie_spalanie")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypNadwozia)
                    .HasColumnName("Typ_nadwozia")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TypSilnika)
                    .HasColumnName("Typ_silnika")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Vin)
                    .HasColumnName("VIN")
                    .HasColumnType("varchar(17)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Wyposazenie)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Zdjecie)
                    .HasColumnName("zdjecie")
                    .HasColumnType("blob");

                entity.HasOne(d => d.IdSalonuNavigation)
                    .WithMany(p => p.Samochody)
                    .HasForeignKey(d => d.IdSalonu)
                    .HasConstraintName("Samochody_Salony_FK");
            });

            modelBuilder.Entity<Uslugi>(entity =>
            {
                entity.HasKey(e => e.IdUslugi)
                    .HasName("PRIMARY");

                entity.ToTable("uslugi");

                entity.Property(e => e.IdUslugi)
                    .HasColumnName("id_uslugi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CenaUslugi)
                    .HasColumnName("cena_uslugi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nazwa)
                    .HasColumnName("nazwa")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TypUslugi)
                    .HasColumnName("typ_uslugi")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Zamowienia>(entity =>
            {
                entity.HasKey(e => e.IdZamowienia)
                    .HasName("PRIMARY");

                entity.ToTable("zamowienia");

                entity.HasIndex(e => e.IdKlienta)
                    .HasName("Zamowienia_Klienci_FK");

                entity.HasIndex(e => e.IdPracownika)
                    .HasName("Zamowienia_Pracownicy_FK");

                entity.Property(e => e.IdZamowienia)
                    .HasColumnName("id_zamowienia")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CalkowityKoszt)
                    .HasColumnName("calkowity_koszt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("date");

                entity.Property(e => e.IdKlienta)
                    .HasColumnName("id_klienta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPracownika)
                    .HasColumnName("id_pracownika")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RodzajPlatnosci)
                    .HasColumnName("rodzaj_platnosci")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TypZamowienia)
                    .HasColumnName("typ_zamowienia")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasOne(d => d.IdKlientaNavigation)
                    .WithMany(p => p.Zamowienia)
                    .HasForeignKey(d => d.IdKlienta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Zamowienia_Klienci_FK");

                entity.HasOne(d => d.IdPracownikaNavigation)
                    .WithMany(p => p.Zamowienia)
                    .HasForeignKey(d => d.IdPracownika)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Zamowienia_Pracownicy_FK");
            });

            modelBuilder.Entity<ZamowieniaSamochodyUslugi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zamowienia_samochody_uslugi");

                entity.HasIndex(e => e.IdPracownika)
                    .HasName("zam_sam_usl_Prac_FK");

                entity.HasIndex(e => e.IdSamochodu)
                    .HasName("zam_sam_usl_Sam_FK");

                entity.HasIndex(e => e.IdUslugi)
                    .HasName("zam_sam_usl_Usl_FK");

                entity.HasIndex(e => e.IdZamowienia)
                    .HasName("zam_sam_usl_Zam_FK");

                entity.Property(e => e.IdPracownika)
                    .HasColumnName("id_pracownika")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSamochodu)
                    .HasColumnName("id_samochodu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUslugi)
                    .HasColumnName("id_uslugi")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdZamowienia)
                    .HasColumnName("id_zamowienia")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasOne(d => d.IdPracownikaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPracownika)
                    .HasConstraintName("zam_sam_usl_Prac_FK");

                entity.HasOne(d => d.IdSamochoduNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSamochodu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("zam_sam_usl_Sam_FK");

                entity.HasOne(d => d.IdUslugiNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUslugi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("zam_sam_usl_Usl_FK");

                entity.HasOne(d => d.IdZamowieniaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdZamowienia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("zam_sam_usl_Zam_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
