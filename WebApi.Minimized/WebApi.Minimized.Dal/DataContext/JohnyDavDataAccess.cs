using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApi.Minimized.Core.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApi.Minimized.Dal.DataContext
{
    public partial class JohnyDavDataAccess : DbContext
    {
        public JohnyDavDataAccess()
        {
        }

        public JohnyDavDataAccess(DbContextOptions<JohnyDavDataAccess> options)
            : base(options)
        {
        }

        public virtual DbSet<Accom> Accom { get; set; }
        public virtual DbSet<AccomDisc> AccomDisc { get; set; }
        public virtual DbSet<AccomGuest> AccomGuest { get; set; }
        public virtual DbSet<AccomRoom> AccomRoom { get; set; }
        public virtual DbSet<AccomSupp> AccomSupp { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AdvRoute> AdvRoute { get; set; }
        public virtual DbSet<AgrLogin> AgrLogin { get; set; }
        public virtual DbSet<AgrProxy> AgrProxy { get; set; }
        public virtual DbSet<Agreement> Agreement { get; set; }
        public virtual DbSet<AirTicket> AirTicket { get; set; }
        public virtual DbSet<Airline> Airline { get; set; }
        public virtual DbSet<Airport> Airport { get; set; }
        public virtual DbSet<AkkCountry> AkkCountry { get; set; }
        public virtual DbSet<AkkCtg> AkkCtg { get; set; }
        public virtual DbSet<AkkDate> AkkDate { get; set; }
        public virtual DbSet<AkkImg> AkkImg { get; set; }
        public virtual DbSet<AkkLink> AkkLink { get; set; }
        public virtual DbSet<AkkProd> AkkProd { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Bus> Bus { get; set; }
        public virtual DbSet<BusCity> BusCity { get; set; }
        public virtual DbSet<BusPrice> BusPrice { get; set; }
        public virtual DbSet<BusProgram> BusProgram { get; set; }
        public virtual DbSet<BusRoute> BusRoute { get; set; }
        public virtual DbSet<BusSeat> BusSeat { get; set; }
        public virtual DbSet<BusTrip> BusTrip { get; set; }
        public virtual DbSet<BusTripSeat> BusTripSeat { get; set; }
        public virtual DbSet<BusType> BusType { get; set; }
        public virtual DbSet<CarHire> CarHire { get; set; }
        public virtual DbSet<Chflight> Chflight { get; set; }
        public virtual DbSet<ChflightSeat> ChflightSeat { get; set; }
        public virtual DbSet<Chmap> Chmap { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactInfo> ContactInfo { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<CorpClient> CorpClient { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Dest> Dest { get; set; }
        public virtual DbSet<Discuss> Discuss { get; set; }
        public virtual DbSet<Doc> Doc { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Excursion> Excursion { get; set; }
        public virtual DbSet<Extra> Extra { get; set; }
        public virtual DbSet<Flight> Flight { get; set; }
        public virtual DbSet<FlightCost> FlightCost { get; set; }
        public virtual DbSet<FlightDay> FlightDay { get; set; }
        public virtual DbSet<FlightSched> FlightSched { get; set; }
        public virtual DbSet<GroupItem> GroupItem { get; set; }
        public virtual DbSet<GroupMember> GroupMember { get; set; }
        public virtual DbSet<Hbcsv> Hbcsv { get; set; }
        public virtual DbSet<Hbdest> Hbdest { get; set; }
        public virtual DbSet<Hbhotel> Hbhotel { get; set; }
        public virtual DbSet<HbhotelDet> HbhotelDet { get; set; }
        public virtual DbSet<HbhotelFac> HbhotelFac { get; set; }
        public virtual DbSet<Hoohotel> Hoohotel { get; set; }
        public virtual DbSet<HotOffer> HotOffer { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<HotelImage> HotelImage { get; set; }
        public virtual DbSet<Insurance> Insurance { get; set; }
        public virtual DbSet<Ipaddress> Ipaddress { get; set; }
        public virtual DbSet<Keyword> Keyword { get; set; }
        public virtual DbSet<Link> Link { get; set; }
        public virtual DbSet<Markup> Markup { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MessageBody> MessageBody { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Newsletter> Newsletter { get; set; }
        public virtual DbSet<Newsletter2> Newsletter2 { get; set; }
        public virtual DbSet<ObjectLog> ObjectLog { get; set; }
        public virtual DbSet<Ownhotel> Ownhotel { get; set; }
        public virtual DbSet<OwnhotelDet> OwnhotelDet { get; set; }
        public virtual DbSet<OwnhotelFac> OwnhotelFac { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<PageAccess> PageAccess { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PkgDate> PkgDate { get; set; }
        public virtual DbSet<PkgExtra> PkgExtra { get; set; }
        public virtual DbSet<Referral> Referral { get; set; }
        public virtual DbSet<ReqInfo> ReqInfo { get; set; }
        public virtual DbSet<ReqNotify> ReqNotify { get; set; }
        public virtual DbSet<ReqPassport> ReqPassport { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<Seo> Seo { get; set; }
        public virtual DbSet<Seo2> Seo2 { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<SettingValue> SettingValue { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Testimonial> Testimonial { get; set; }
        public virtual DbSet<Transfer> Transfer { get; set; }
        public virtual DbSet<Translate> Translate { get; set; }
        public virtual DbSet<Ttcountry> Ttcountry { get; set; }
        public virtual DbSet<Tthotel> Tthotel { get; set; }
        public virtual DbSet<Ttresort> Ttresort { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=johny_dav_db;Integrated Security=true;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accom>(entity =>
            {
                entity.HasIndex(e => e.AgencyId)
                    .HasName("IF3_Accom");

                entity.HasIndex(e => e.BookingId)
                    .HasName("IF5_Accom");

                entity.HasIndex(e => e.HotelId)
                    .HasName("IF4_Accom");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IF1_Accom");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IF2_Accom");

                entity.Property(e => e.AccomId)
                    .HasColumnName("Accom_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccomAdded)
                    .HasColumnName("Accom_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AccomAdults)
                    .HasColumnName("Accom_Adults")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AccomAgencyCommision)
                    .HasColumnName("Accom_AgencyCommision")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AccomAgencyPaidDate)
                    .HasColumnName("Accom_AgencyPaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccomAgencyRefNo)
                    .HasColumnName("Accom_AgencyRefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.AccomArrival)
                    .HasColumnName("Accom_Arrival")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccomCancellationPolicy)
                    .HasColumnName("Accom_CancellationPolicy")
                    .HasColumnType("ntext");

                entity.Property(e => e.AccomChildAges)
                    .HasColumnName("Accom_ChildAges")
                    .HasMaxLength(32);

                entity.Property(e => e.AccomChildren).HasColumnName("Accom_Children");

                entity.Property(e => e.AccomCurrency)
                    .IsRequired()
                    .HasColumnName("Accom_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.AccomDeparture)
                    .HasColumnName("Accom_Departure")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccomDestination)
                    .IsRequired()
                    .HasColumnName("Accom_Destination")
                    .HasMaxLength(256);

                entity.Property(e => e.AccomDuration)
                    .HasColumnName("Accom_Duration")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AccomHotel)
                    .IsRequired()
                    .HasColumnName("Accom_Hotel")
                    .HasMaxLength(64);

                entity.Property(e => e.AccomHotelAddress)
                    .HasColumnName("Accom_HotelAddress")
                    .HasMaxLength(256);

                entity.Property(e => e.AccomHotelCategory)
                    .HasColumnName("Accom_HotelCategory")
                    .HasMaxLength(32);

                entity.Property(e => e.AccomHotelPhone)
                    .HasColumnName("Accom_HotelPhone")
                    .HasMaxLength(32);

                entity.Property(e => e.AccomImportantInfo)
                    .HasColumnName("Accom_ImportantInfo")
                    .HasColumnType("ntext");

                entity.Property(e => e.AccomInfants).HasColumnName("Accom_Infants");

                entity.Property(e => e.AccomNetCost)
                    .HasColumnName("Accom_NetCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AccomNote)
                    .HasColumnName("Accom_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.AccomOrigin)
                    .HasColumnName("Accom_Origin")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AccomPaidDate)
                    .HasColumnName("Accom_PaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccomPwd)
                    .IsRequired()
                    .HasColumnName("Accom_Pwd")
                    .HasMaxLength(32);

                entity.Property(e => e.AccomRefNo)
                    .IsRequired()
                    .HasColumnName("Accom_RefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.AccomRooms)
                    .HasColumnName("Accom_Rooms")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AccomSpecialRequest)
                    .HasColumnName("Accom_SpecialRequest")
                    .HasColumnType("ntext");

                entity.Property(e => e.AccomStatus)
                    .HasColumnName("Accom_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AccomSupplierPaidDate)
                    .HasColumnName("Accom_SupplierPaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccomSupplierRefNo)
                    .HasColumnName("Accom_SupplierRefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.AccomTotalCost)
                    .HasColumnName("Accom_TotalCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AccomTotalPaid)
                    .HasColumnName("Accom_TotalPaid")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AgencyId)
                    .HasColumnName("Agency_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BookingId)
                    .HasColumnName("Booking_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HotelId)
                    .HasColumnName("Hotel_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PersonId)
                    .HasColumnName("Person_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("Supplier_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.AccomAgency)
                    .HasForeignKey(d => d.AgencyId)
                    .HasConstraintName("FK__Accom__Agency_ID__703EA55A");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.Accom)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK__Accom__Booking_I__6E565CE8");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.Accom)
                    .HasForeignKey(d => d.HotelId)
                    .HasConstraintName("FK__Accom__Hotel_ID__6F4A8121");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Accom)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Accom__Person_ID__7226EDCC");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.AccomSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK__Accom__Supplier___7132C993");
            });

            modelBuilder.Entity<AccomDisc>(entity =>
            {
                entity.HasIndex(e => e.AccomId)
                    .HasName("IF1_AccomDisc");

                entity.Property(e => e.AccomDiscId)
                    .HasColumnName("AccomDisc_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccomDiscAdded)
                    .HasColumnName("AccomDisc_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AccomDiscDescription)
                    .HasColumnName("AccomDisc_Description")
                    .HasMaxLength(128);

                entity.Property(e => e.AccomDiscDiscount)
                    .HasColumnName("AccomDisc_Discount")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AccomDiscNote)
                    .HasColumnName("AccomDisc_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.AccomId)
                    .HasColumnName("Accom_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Accom)
                    .WithMany(p => p.AccomDisc)
                    .HasForeignKey(d => d.AccomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccomDisc__Accom__731B1205");
            });

            modelBuilder.Entity<AccomGuest>(entity =>
            {
                entity.HasIndex(e => e.AccomId)
                    .HasName("IF1_AccomGuest");

                entity.Property(e => e.AccomGuestId)
                    .HasColumnName("AccomGuest_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccomGuestAge).HasColumnName("AccomGuest_Age");

                entity.Property(e => e.AccomGuestFirstName)
                    .IsRequired()
                    .HasColumnName("AccomGuest_FirstName")
                    .HasMaxLength(32);

                entity.Property(e => e.AccomGuestLastName)
                    .IsRequired()
                    .HasColumnName("AccomGuest_LastName")
                    .HasMaxLength(32);

                entity.Property(e => e.AccomGuestTitle)
                    .HasColumnName("AccomGuest_Title")
                    .HasMaxLength(8);

                entity.Property(e => e.AccomId)
                    .HasColumnName("Accom_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<AccomRoom>(entity =>
            {
                entity.HasIndex(e => e.AccomId)
                    .HasName("IF1_AccomRoom");

                entity.Property(e => e.AccomRoomId)
                    .HasColumnName("AccomRoom_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccomId)
                    .HasColumnName("Accom_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccomRoomAdded)
                    .HasColumnName("AccomRoom_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AccomRoomAdults).HasColumnName("AccomRoom_Adults");

                entity.Property(e => e.AccomRoomBoard)
                    .IsRequired()
                    .HasColumnName("AccomRoom_Board")
                    .HasMaxLength(64);

                entity.Property(e => e.AccomRoomBoardCode)
                    .IsRequired()
                    .HasColumnName("AccomRoom_BoardCode")
                    .HasMaxLength(16);

                entity.Property(e => e.AccomRoomChildAges)
                    .HasColumnName("AccomRoom_ChildAges")
                    .HasMaxLength(32);

                entity.Property(e => e.AccomRoomChildren).HasColumnName("AccomRoom_Children");

                entity.Property(e => e.AccomRoomInfants).HasColumnName("AccomRoom_Infants");

                entity.Property(e => e.AccomRoomLeadName)
                    .HasColumnName("AccomRoom_LeadName")
                    .HasMaxLength(64);

                entity.Property(e => e.AccomRoomNetCost)
                    .HasColumnName("AccomRoom_NetCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AccomRoomNote)
                    .HasColumnName("AccomRoom_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.AccomRoomRoom)
                    .IsRequired()
                    .HasColumnName("AccomRoom_Room")
                    .HasMaxLength(64);

                entity.Property(e => e.AccomRoomRoomCode)
                    .IsRequired()
                    .HasColumnName("AccomRoom_RoomCode")
                    .HasMaxLength(16);

                entity.Property(e => e.AccomRoomTotalCost)
                    .HasColumnName("AccomRoom_TotalCost")
                    .HasColumnType("numeric(14, 4)");

                entity.HasOne(d => d.Accom)
                    .WithMany(p => p.AccomRoom)
                    .HasForeignKey(d => d.AccomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccomRoom__Accom__740F363E");
            });

            modelBuilder.Entity<AccomSupp>(entity =>
            {
                entity.HasIndex(e => e.AccomId)
                    .HasName("IF1_AccomSupp");

                entity.Property(e => e.AccomSuppId)
                    .HasColumnName("AccomSupp_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccomId)
                    .HasColumnName("Accom_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AccomSuppAdded)
                    .HasColumnName("AccomSupp_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AccomSuppDescription)
                    .IsRequired()
                    .HasColumnName("AccomSupp_Description")
                    .HasMaxLength(128);

                entity.Property(e => e.AccomSuppNetCost)
                    .HasColumnName("AccomSupp_NetCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AccomSuppNote)
                    .HasColumnName("AccomSupp_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.AccomSuppTotalCost)
                    .HasColumnName("AccomSupp_TotalCost")
                    .HasColumnType("numeric(14, 4)");

                entity.HasOne(d => d.Accom)
                    .WithMany(p => p.AccomSupp)
                    .HasForeignKey(d => d.AccomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccomSupp__Accom__75035A77");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.CompanyId)
                    .HasName("IF3_Address");

                entity.HasIndex(e => e.CountryId)
                    .HasName("IF1_Address");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IF4_Address");

                entity.HasIndex(e => e.StateId)
                    .HasName("IF2_Address");

                entity.Property(e => e.AddressId)
                    .HasColumnName("Address_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddressAdded)
                    .HasColumnName("Address_Added")
                    .HasColumnType("datetime");

                entity.Property(e => e.AddressAddedById)
                    .HasColumnName("Address_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AddressAddress1)
                    .IsRequired()
                    .HasColumnName("Address_Address1")
                    .HasMaxLength(256);

                entity.Property(e => e.AddressAddress2)
                    .HasColumnName("Address_Address2")
                    .HasMaxLength(256);

                entity.Property(e => e.AddressAddress3)
                    .HasColumnName("Address_Address3")
                    .HasMaxLength(256);

                entity.Property(e => e.AddressCreated)
                    .HasColumnName("Address_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AddressNote)
                    .HasColumnName("Address_Note")
                    .HasMaxLength(1024);

                entity.Property(e => e.AddressPostalCode)
                    .IsRequired()
                    .HasColumnName("Address_PostalCode")
                    .HasMaxLength(16);

                entity.Property(e => e.AddressPrimary).HasColumnName("Address_Primary");

                entity.Property(e => e.AddressStateText)
                    .HasColumnName("Address_StateText")
                    .HasMaxLength(64);

                entity.Property(e => e.AddressTitle)
                    .IsRequired()
                    .HasColumnName("Address_Title")
                    .HasMaxLength(64);

                entity.Property(e => e.AddressTown)
                    .IsRequired()
                    .HasColumnName("Address_Town")
                    .HasMaxLength(64);

                entity.Property(e => e.AddressUpdated)
                    .HasColumnName("Address_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.AddressUpdatedById)
                    .HasColumnName("Address_UpdatedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PersonId)
                    .HasColumnName("Person_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StateId)
                    .HasColumnName("State_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__Address__Company__76EBA2E9");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Address__Country__78D3EB5B");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Address__Person___75F77EB0");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__Address__State_I__77DFC722");
            });

            modelBuilder.Entity<AdvRoute>(entity =>
            {
                entity.Property(e => e.AdvRouteId)
                    .HasColumnName("AdvRoute_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdvRouteAdded)
                    .HasColumnName("AdvRoute_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AdvRouteCountry)
                    .IsRequired()
                    .HasColumnName("AdvRoute_Country")
                    .HasMaxLength(32);

                entity.Property(e => e.AdvRouteRank).HasColumnName("AdvRoute_Rank");

                entity.Property(e => e.AdvRouteTitle)
                    .IsRequired()
                    .HasColumnName("AdvRoute_Title")
                    .HasMaxLength(256);

                entity.Property(e => e.AdvRouteUrl)
                    .IsRequired()
                    .HasColumnName("AdvRoute_URL")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AgrLogin>(entity =>
            {
                entity.HasIndex(e => e.AgreementId)
                    .HasName("IF1_AgrLogin");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IF2_AgrLogin");

                entity.Property(e => e.AgrLoginId)
                    .HasColumnName("AgrLogin_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AgrLoginAdded)
                    .HasColumnName("AgrLogin_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AgrLoginAddedById)
                    .HasColumnName("AgrLogin_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgrLoginArchived).HasColumnName("AgrLogin_Archived");

                entity.Property(e => e.AgrLoginExt)
                    .HasColumnName("AgrLogin_Ext")
                    .HasMaxLength(64);

                entity.Property(e => e.AgrLoginNote)
                    .HasColumnName("AgrLogin_Note")
                    .HasMaxLength(256);

                entity.Property(e => e.AgrLoginPrimary).HasColumnName("AgrLogin_Primary");

                entity.Property(e => e.AgrLoginPwd)
                    .IsRequired()
                    .HasColumnName("AgrLogin_Pwd")
                    .HasMaxLength(64);

                entity.Property(e => e.AgrLoginUpdated)
                    .HasColumnName("AgrLogin_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.AgrLoginUpdatedById)
                    .HasColumnName("AgrLogin_UpdatedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgrLoginUrl)
                    .IsRequired()
                    .HasColumnName("AgrLogin_URL")
                    .HasMaxLength(256);

                entity.Property(e => e.AgrLoginUserName)
                    .IsRequired()
                    .HasColumnName("AgrLogin_UserName")
                    .HasMaxLength(64);

                entity.Property(e => e.AgreementId)
                    .HasColumnName("Agreement_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ManagerId)
                    .HasColumnName("Manager_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Agreement)
                    .WithMany(p => p.AgrLogin)
                    .HasForeignKey(d => d.AgreementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AgrLogin__Agreem__7ABC33CD");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.AgrLogin)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AgrLogin__Manage__7BB05806");
            });

            modelBuilder.Entity<AgrProxy>(entity =>
            {
                entity.HasIndex(e => e.AgreementId)
                    .HasName("IF1_AgrProxy");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IF2_AgrProxy");

                entity.Property(e => e.AgrProxyId)
                    .HasColumnName("AgrProxy_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AgrProxyAdded)
                    .HasColumnName("AgrProxy_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AgrProxyAddedById)
                    .HasColumnName("AgrProxy_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgrProxyByPerson)
                    .IsRequired()
                    .HasColumnName("AgrProxy_ByPerson")
                    .HasMaxLength(128);

                entity.Property(e => e.AgrProxyDate)
                    .HasColumnName("AgrProxy_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AgrProxyNote)
                    .HasColumnName("AgrProxy_Note")
                    .HasMaxLength(256);

                entity.Property(e => e.AgrProxyNumber)
                    .IsRequired()
                    .HasColumnName("AgrProxy_Number")
                    .HasMaxLength(32);

                entity.Property(e => e.AgrProxyTitle)
                    .IsRequired()
                    .HasColumnName("AgrProxy_Title")
                    .HasMaxLength(128);

                entity.Property(e => e.AgrProxyUpdated)
                    .HasColumnName("AgrProxy_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.AgrProxyUpdatedById)
                    .HasColumnName("AgrProxy_UpdatedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgrProxyValidTill)
                    .HasColumnName("AgrProxy_ValidTill")
                    .HasColumnType("datetime");

                entity.Property(e => e.AgreementId)
                    .HasColumnName("Agreement_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ManagerId)
                    .HasColumnName("Manager_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Agreement)
                    .WithMany(p => p.AgrProxy)
                    .HasForeignKey(d => d.AgreementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AgrProxy__Agreem__7CA47C3F");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.AgrProxy)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AgrProxy__Manage__7D98A078");
            });

            modelBuilder.Entity<Agreement>(entity =>
            {
                entity.HasIndex(e => e.CompanyId)
                    .HasName("IF1_Agreement");

                entity.Property(e => e.AgreementId)
                    .HasColumnName("Agreement_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AgreementAccount)
                    .HasColumnName("Agreement_Account")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.AgreementAccount2)
                    .HasColumnName("Agreement_Account2")
                    .HasMaxLength(64);

                entity.Property(e => e.AgreementAdded)
                    .HasColumnName("Agreement_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AgreementAddedById)
                    .HasColumnName("Agreement_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgreementAddress)
                    .HasColumnName("Agreement_Address")
                    .HasMaxLength(256);

                entity.Property(e => e.AgreementAddressReal)
                    .HasColumnName("Agreement_AddressReal")
                    .HasMaxLength(256);

                entity.Property(e => e.AgreementArchived).HasColumnName("Agreement_Archived");

                entity.Property(e => e.AgreementBank)
                    .HasColumnName("Agreement_Bank")
                    .HasMaxLength(128);

                entity.Property(e => e.AgreementBank2)
                    .HasColumnName("Agreement_Bank2")
                    .HasMaxLength(128);

                entity.Property(e => e.AgreementByDirector)
                    .HasColumnName("Agreement_ByDirector")
                    .HasMaxLength(128);

                entity.Property(e => e.AgreementByDirectorTitle)
                    .HasColumnName("Agreement_ByDirectorTitle")
                    .HasMaxLength(64);

                entity.Property(e => e.AgreementCompany)
                    .HasColumnName("Agreement_Company")
                    .HasMaxLength(128);

                entity.Property(e => e.AgreementDate)
                    .HasColumnName("Agreement_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AgreementDirector)
                    .HasColumnName("Agreement_Director")
                    .HasMaxLength(128);

                entity.Property(e => e.AgreementEdrpou)
                    .HasColumnName("Agreement_EDRPOU")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgreementEmail)
                    .HasColumnName("Agreement_Email")
                    .HasMaxLength(128);

                entity.Property(e => e.AgreementFax)
                    .HasColumnName("Agreement_Fax")
                    .HasMaxLength(32);

                entity.Property(e => e.AgreementGuid)
                    .HasColumnName("Agreement_GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AgreementIpaddress)
                    .HasColumnName("Agreement_IPAddress")
                    .HasMaxLength(32);

                entity.Property(e => e.AgreementLicense)
                    .HasColumnName("Agreement_License")
                    .HasMaxLength(256);

                entity.Property(e => e.AgreementLogin)
                    .HasColumnName("Agreement_Login")
                    .HasMaxLength(32);

                entity.Property(e => e.AgreementLoginExt)
                    .HasColumnName("Agreement_LoginExt")
                    .HasMaxLength(32);

                entity.Property(e => e.AgreementLoginUrl)
                    .HasColumnName("Agreement_LoginURL")
                    .HasMaxLength(256);

                entity.Property(e => e.AgreementMfo)
                    .HasColumnName("Agreement_MFO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgreementMfo2)
                    .HasColumnName("Agreement_MFO2")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgreementNote)
                    .HasColumnName("Agreement_Note")
                    .HasMaxLength(1024);

                entity.Property(e => e.AgreementNumber)
                    .HasColumnName("Agreement_Number")
                    .HasMaxLength(32);

                entity.Property(e => e.AgreementPhone)
                    .HasColumnName("Agreement_Phone")
                    .HasMaxLength(32);

                entity.Property(e => e.AgreementPhone2)
                    .HasColumnName("Agreement_Phone2")
                    .HasMaxLength(32);

                entity.Property(e => e.AgreementPwd)
                    .HasColumnName("Agreement_Pwd")
                    .HasMaxLength(32);

                entity.Property(e => e.AgreementStatus)
                    .HasColumnName("Agreement_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AgreementStatute)
                    .HasColumnName("Agreement_Statute")
                    .HasMaxLength(128);

                entity.Property(e => e.AgreementTax)
                    .HasColumnName("Agreement_Tax")
                    .HasMaxLength(128);

                entity.Property(e => e.AgreementTaxNumber)
                    .HasColumnName("Agreement_TaxNumber")
                    .HasMaxLength(128);

                entity.Property(e => e.AgreementTitle)
                    .IsRequired()
                    .HasColumnName("Agreement_Title")
                    .HasMaxLength(128);

                entity.Property(e => e.AgreementType).HasColumnName("Agreement_Type");

                entity.Property(e => e.AgreementUpdated)
                    .HasColumnName("Agreement_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.AgreementUpdatedById)
                    .HasColumnName("Agreement_UpdatedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgreementUrl)
                    .HasColumnName("Agreement_URL")
                    .HasMaxLength(128);

                entity.Property(e => e.AgreementValidTill)
                    .HasColumnName("Agreement_ValidTill")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Agreement)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Agreement__Compa__79C80F94");
            });

            modelBuilder.Entity<AirTicket>(entity =>
            {
                entity.HasIndex(e => e.AirlineId)
                    .HasName("IF3_AirTicket");

                entity.HasIndex(e => e.FromDestId)
                    .HasName("IF1_AirTicket");

                entity.HasIndex(e => e.ToDestId)
                    .HasName("IF2_AirTicket");

                entity.Property(e => e.AirTicketId)
                    .HasColumnName("AirTicket_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AirTicketAdded)
                    .HasColumnName("AirTicket_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AirTicketCurrency)
                    .IsRequired()
                    .HasColumnName("AirTicket_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.AirTicketFeatured)
                    .HasColumnName("AirTicket_Featured")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AirTicketFlight)
                    .HasColumnName("AirTicket_Flight")
                    .HasMaxLength(64);

                entity.Property(e => e.AirTicketOwpriceFrom)
                    .HasColumnName("AirTicket_OWPriceFrom")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AirTicketPublished)
                    .HasColumnName("AirTicket_Published")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AirTicketRt1011priceFrom)
                    .HasColumnName("AirTicket_RT1011PriceFrom")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AirTicketRt14priceFrom)
                    .HasColumnName("AirTicket_RT14PriceFrom")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AirTicketRt21priceFrom)
                    .HasColumnName("AirTicket_RT21PriceFrom")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AirTicketRt28priceFrom)
                    .HasColumnName("AirTicket_RT28PriceFrom")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AirTicketRt7priceFrom)
                    .HasColumnName("AirTicket_RT7PriceFrom")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AirTicketRtpriceFrom)
                    .HasColumnName("AirTicket_RTPriceFrom")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AirTicketStatus)
                    .HasColumnName("AirTicket_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AirTicketText)
                    .HasColumnName("AirTicket_Text")
                    .HasMaxLength(256);

                entity.Property(e => e.AirTicketType)
                    .HasColumnName("AirTicket_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AirlineId)
                    .HasColumnName("Airline_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FromDestId)
                    .HasColumnName("FromDest_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ToDestId)
                    .HasColumnName("ToDest_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Airline)
                    .WithMany(p => p.AirTicket)
                    .HasForeignKey(d => d.AirlineId)
                    .HasConstraintName("FK__AirTicket__Airli__7E8CC4B1");

                entity.HasOne(d => d.FromDest)
                    .WithMany(p => p.AirTicketFromDest)
                    .HasForeignKey(d => d.FromDestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AirTicket__FromD__00750D23");

                entity.HasOne(d => d.ToDest)
                    .WithMany(p => p.AirTicketToDest)
                    .HasForeignKey(d => d.ToDestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AirTicket__ToDes__7F80E8EA");
            });

            modelBuilder.Entity<Airline>(entity =>
            {
                entity.Property(e => e.AirlineId)
                    .HasColumnName("Airline_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AirlineAdded)
                    .HasColumnName("Airline_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AirlineAddress)
                    .HasColumnName("Airline_Address")
                    .HasMaxLength(256);

                entity.Property(e => e.AirlineAirplanes)
                    .HasColumnName("Airline_Airplanes")
                    .HasColumnType("ntext");

                entity.Property(e => e.AirlineBaseAirports)
                    .HasColumnName("Airline_BaseAirports")
                    .HasColumnType("ntext");

                entity.Property(e => e.AirlineCountry)
                    .IsRequired()
                    .HasColumnName("Airline_Country")
                    .HasMaxLength(64);

                entity.Property(e => e.AirlineCountryMl)
                    .HasColumnName("Airline_Country_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.AirlineDesc)
                    .HasColumnName("Airline_Desc")
                    .HasMaxLength(256);

                entity.Property(e => e.AirlineDescMl)
                    .HasColumnName("Airline_Desc_ML")
                    .HasMaxLength(256);

                entity.Property(e => e.AirlineEmail)
                    .HasColumnName("Airline_Email")
                    .HasMaxLength(128);

                entity.Property(e => e.AirlineFax)
                    .HasColumnName("Airline_Fax")
                    .HasMaxLength(64);

                entity.Property(e => e.AirlineFlightsCis)
                    .HasColumnName("Airline_FlightsCIS")
                    .HasColumnType("ntext");

                entity.Property(e => e.AirlineFlightsDom)
                    .HasColumnName("Airline_FlightsDom")
                    .HasColumnType("ntext");

                entity.Property(e => e.AirlineFlightsInt)
                    .HasColumnName("Airline_FlightsInt")
                    .HasColumnType("ntext");

                entity.Property(e => e.AirlineIataCode)
                    .HasColumnName("Airline_IATA_Code")
                    .HasMaxLength(3);

                entity.Property(e => e.AirlineIcaoCode)
                    .HasColumnName("Airline_ICAO_Code")
                    .HasMaxLength(4);

                entity.Property(e => e.AirlineName)
                    .IsRequired()
                    .HasColumnName("Airline_Name")
                    .HasMaxLength(128);

                entity.Property(e => e.AirlineNameMl)
                    .HasColumnName("Airline_Name_ML")
                    .HasMaxLength(128);

                entity.Property(e => e.AirlinePhone)
                    .HasColumnName("Airline_Phone")
                    .HasMaxLength(64);

                entity.Property(e => e.AirlinePhoneLocal)
                    .HasColumnName("Airline_PhoneLocal")
                    .HasMaxLength(64);

                entity.Property(e => e.AirlinePublished)
                    .HasColumnName("Airline_Published")
                    .HasColumnType("datetime");

                entity.Property(e => e.AirlineRank).HasColumnName("Airline_Rank");

                entity.Property(e => e.AirlineType)
                    .HasColumnName("Airline_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AirlineUpdated)
                    .HasColumnName("Airline_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.AirlineUrl)
                    .HasColumnName("Airline_URL")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Airport>(entity =>
            {
                entity.HasIndex(e => e.AirportCity)
                    .HasName("AK_Airport_City");

                entity.HasIndex(e => e.AirportCityMl)
                    .HasName("AK_Airport_City_ML");

                entity.HasIndex(e => e.AirportCountry)
                    .HasName("AK_Airport_Country");

                entity.HasIndex(e => e.AirportCountryCode)
                    .HasName("AK_Airport_Country_Code");

                entity.HasIndex(e => e.AirportCountryMl)
                    .HasName("AK_Airport_Country_ML");

                entity.HasIndex(e => e.AirportIataCode)
                    .HasName("AK_Airport_IATA_Code");

                entity.HasIndex(e => e.AirportIcaoCode)
                    .HasName("AK_Airport_ICAO_Code");

                entity.HasIndex(e => e.AirportName)
                    .HasName("AK_Airport_Name");

                entity.HasIndex(e => e.AirportNameMl)
                    .HasName("AK_Airport_Name_ML");

                entity.Property(e => e.AirportId)
                    .HasColumnName("Airport_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AirportCity)
                    .IsRequired()
                    .HasColumnName("Airport_City")
                    .HasMaxLength(64);

                entity.Property(e => e.AirportCityIata)
                    .HasColumnName("Airport_City_IATA")
                    .HasMaxLength(3);

                entity.Property(e => e.AirportCityMl)
                    .HasColumnName("Airport_City_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.AirportCityMl1)
                    .HasColumnName("Airport_City_ML1")
                    .HasMaxLength(128);

                entity.Property(e => e.AirportCityMl1prefix)
                    .HasColumnName("Airport_City_ML1Prefix")
                    .HasMaxLength(8);

                entity.Property(e => e.AirportCityMl2)
                    .HasColumnName("Airport_City_ML2")
                    .HasMaxLength(128);

                entity.Property(e => e.AirportCountry)
                    .IsRequired()
                    .HasColumnName("Airport_Country")
                    .HasMaxLength(64);

                entity.Property(e => e.AirportCountryCode)
                    .IsRequired()
                    .HasColumnName("Airport_Country_Code")
                    .HasMaxLength(2);

                entity.Property(e => e.AirportCountryMl)
                    .HasColumnName("Airport_Country_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.AirportCountryMl1)
                    .HasColumnName("Airport_Country_ML1")
                    .HasMaxLength(64);

                entity.Property(e => e.AirportCountryMl1prefix)
                    .HasColumnName("Airport_Country_ML1Prefix")
                    .HasMaxLength(8);

                entity.Property(e => e.AirportCountryMl2)
                    .HasColumnName("Airport_Country_ML2")
                    .HasMaxLength(64);

                entity.Property(e => e.AirportEmail)
                    .HasColumnName("Airport_Email")
                    .HasMaxLength(64);

                entity.Property(e => e.AirportFax)
                    .HasColumnName("Airport_Fax")
                    .HasMaxLength(32);

                entity.Property(e => e.AirportFeatured)
                    .HasColumnName("Airport_Featured")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AirportGmt)
                    .HasColumnName("Airport_GMT")
                    .HasMaxLength(8);

                entity.Property(e => e.AirportIataCode)
                    .IsRequired()
                    .HasColumnName("Airport_IATA_Code")
                    .HasMaxLength(3);

                entity.Property(e => e.AirportIcaoCode)
                    .HasColumnName("Airport_ICAO_Code")
                    .HasMaxLength(4);

                entity.Property(e => e.AirportLatitude)
                    .HasColumnName("Airport_Latitude")
                    .HasMaxLength(32);

                entity.Property(e => e.AirportLongitude)
                    .HasColumnName("Airport_Longitude")
                    .HasMaxLength(32);

                entity.Property(e => e.AirportMorpherXmlru)
                    .HasColumnName("Airport_MorpherXMLRU")
                    .HasMaxLength(3000);

                entity.Property(e => e.AirportMorpherXmlua)
                    .HasColumnName("Airport_MorpherXMLUA")
                    .HasMaxLength(3000);

                entity.Property(e => e.AirportName)
                    .IsRequired()
                    .HasColumnName("Airport_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.AirportNameMl)
                    .HasColumnName("Airport_Name_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.AirportPhone)
                    .HasColumnName("Airport_Phone")
                    .HasMaxLength(128);

                entity.Property(e => e.AirportRank)
                    .HasColumnName("Airport_Rank")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AirportRunwayElevation).HasColumnName("Airport_Runway_Elevation");

                entity.Property(e => e.AirportRunwayLength).HasColumnName("Airport_Runway_Length");

                entity.Property(e => e.AirportViewed)
                    .HasColumnName("Airport_Viewed")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AirportWebsite)
                    .HasColumnName("Airport_Website")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AkkCountry>(entity =>
            {
                entity.Property(e => e.AkkCountryId)
                    .HasColumnName("AkkCountry_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AkkCountryAdded)
                    .HasColumnName("AkkCountry_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AkkCountryName)
                    .IsRequired()
                    .HasColumnName("AkkCountry_Name")
                    .HasMaxLength(256);

                entity.Property(e => e.AkkCountryStatus)
                    .HasColumnName("AkkCountry_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AkkCountryUpdated)
                    .HasColumnName("AkkCountry_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DestId)
                    .HasColumnName("Dest_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<AkkCtg>(entity =>
            {
                entity.Property(e => e.AkkCtgId)
                    .HasColumnName("AkkCtg_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AkkCtgAdded)
                    .HasColumnName("AkkCtg_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AkkCtgName)
                    .IsRequired()
                    .HasColumnName("AkkCtg_Name")
                    .HasMaxLength(256);

                entity.Property(e => e.AkkCtgParentId)
                    .HasColumnName("AkkCtg_ParentID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AkkCtgStatus)
                    .HasColumnName("AkkCtg_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AkkCtgUpdated)
                    .HasColumnName("AkkCtg_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.PackageSubtype).HasColumnName("Package_Subtype");
            });

            modelBuilder.Entity<AkkDate>(entity =>
            {
                entity.HasIndex(e => e.AkkProdId)
                    .HasName("IF1_AkkDate");

                entity.Property(e => e.AkkDateId)
                    .HasColumnName("AkkDate_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AkkDateAdded)
                    .HasColumnName("AkkDate_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AkkDateDate)
                    .HasColumnName("AkkDate_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AkkDateDateTo)
                    .HasColumnName("AkkDate_DateTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.AkkDateSpecial)
                    .HasColumnName("AkkDate_Special")
                    .HasMaxLength(32);

                entity.Property(e => e.AkkDateUpdated)
                    .HasColumnName("AkkDate_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.AkkProdId)
                    .HasColumnName("AkkProd_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.AkkProd)
                    .WithMany(p => p.AkkDate)
                    .HasForeignKey(d => d.AkkProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AkkDate__AkkProd__0169315C");
            });

            modelBuilder.Entity<AkkImg>(entity =>
            {
                entity.HasIndex(e => e.AkkProdId)
                    .HasName("IF1_AkkImg");

                entity.Property(e => e.AkkImgId)
                    .HasColumnName("AkkImg_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AkkImgAdded)
                    .HasColumnName("AkkImg_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AkkImgUpdated)
                    .HasColumnName("AkkImg_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.AkkImgUrl)
                    .HasColumnName("AkkImg_URL")
                    .HasMaxLength(512);

                entity.Property(e => e.AkkProdId)
                    .HasColumnName("AkkProd_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.AkkProd)
                    .WithMany(p => p.AkkImg)
                    .HasForeignKey(d => d.AkkProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AkkImg__AkkProd___025D5595");
            });

            modelBuilder.Entity<AkkLink>(entity =>
            {
                entity.HasIndex(e => e.AkkCountryId)
                    .HasName("IF2_AkkLink");

                entity.HasIndex(e => e.AkkCtgId)
                    .HasName("IF4_AkkLink");

                entity.HasIndex(e => e.AkkProdId)
                    .HasName("IF3_AkkLink");

                entity.Property(e => e.AkkLinkId)
                    .HasColumnName("AkkLink_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AkkCountryId)
                    .HasColumnName("AkkCountry_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AkkCtgId)
                    .HasColumnName("AkkCtg_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AkkLinkAdded)
                    .HasColumnName("AkkLink_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AkkLinkProdLoaded)
                    .HasColumnName("AkkLink_ProdLoaded")
                    .HasColumnType("datetime");

                entity.Property(e => e.AkkLinkStatus)
                    .HasColumnName("AkkLink_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AkkLinkUpdated)
                    .HasColumnName("AkkLink_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.AkkProdId)
                    .HasColumnName("AkkProd_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.AkkCountry)
                    .WithMany(p => p.AkkLink)
                    .HasForeignKey(d => d.AkkCountryId)
                    .HasConstraintName("FK__AkkLink__AkkCoun__035179CE");

                entity.HasOne(d => d.AkkCtg)
                    .WithMany(p => p.AkkLink)
                    .HasForeignKey(d => d.AkkCtgId)
                    .HasConstraintName("FK__AkkLink__AkkCtg___0539C240");

                entity.HasOne(d => d.AkkProd)
                    .WithMany(p => p.AkkLink)
                    .HasForeignKey(d => d.AkkProdId)
                    .HasConstraintName("FK__AkkLink__AkkProd__04459E07");
            });

            modelBuilder.Entity<AkkProd>(entity =>
            {
                entity.Property(e => e.AkkProdId)
                    .HasColumnName("AkkProd_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AkkProdAdded)
                    .HasColumnName("AkkProd_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AkkProdCategories)
                    .HasColumnName("AkkProd_Categories")
                    .HasMaxLength(256);

                entity.Property(e => e.AkkProdCountries)
                    .HasColumnName("AkkProd_Countries")
                    .HasMaxLength(512);

                entity.Property(e => e.AkkProdCurrency)
                    .HasColumnName("AkkProd_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.AkkProdDates)
                    .HasColumnName("AkkProd_Dates")
                    .HasColumnType("ntext");

                entity.Property(e => e.AkkProdDatesRaw)
                    .HasColumnName("AkkProd_DatesRaw")
                    .HasColumnType("ntext");

                entity.Property(e => e.AkkProdDescription)
                    .HasColumnName("AkkProd_Description")
                    .HasColumnType("ntext");

                entity.Property(e => e.AkkProdNights).HasColumnName("AkkProd_Nights");

                entity.Property(e => e.AkkProdNightsTo).HasColumnName("AkkProd_NightsTo");

                entity.Property(e => e.AkkProdPrice)
                    .HasColumnName("AkkProd_Price")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AkkProdPriceEur)
                    .HasColumnName("AkkProd_PriceEUR")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AkkProdPriceUsd)
                    .HasColumnName("AkkProd_PriceUSD")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.AkkProdPrices)
                    .HasColumnName("AkkProd_Prices")
                    .HasColumnType("ntext");

                entity.Property(e => e.AkkProdPrices2)
                    .HasColumnName("AkkProd_Prices2")
                    .HasColumnType("ntext");

                entity.Property(e => e.AkkProdRoute)
                    .HasColumnName("AkkProd_Route")
                    .HasMaxLength(512);

                entity.Property(e => e.AkkProdTitle)
                    .IsRequired()
                    .HasColumnName("AkkProd_Title")
                    .HasMaxLength(256);

                entity.Property(e => e.AkkProdTmp).HasColumnName("AkkProd_tmp");

                entity.Property(e => e.AkkProdTourType)
                    .HasColumnName("AkkProd_TourType")
                    .HasMaxLength(32);

                entity.Property(e => e.AkkProdTourUrl)
                    .HasColumnName("AkkProd_TourURL")
                    .HasMaxLength(256);

                entity.Property(e => e.AkkProdTravelType)
                    .HasColumnName("AkkProd_TravelType")
                    .HasMaxLength(32);

                entity.Property(e => e.AkkProdUpdated)
                    .HasColumnName("AkkProd_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.AkkProdUpdatedScript)
                    .HasColumnName("AkkProd_UpdatedScript")
                    .HasColumnType("datetime");

                entity.Property(e => e.AkkProdVisaCountryId)
                    .HasColumnName("AkkProd_VisaCountryID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AkkProdXml)
                    .HasColumnName("AkkProd_XML")
                    .HasColumnType("ntext");

                entity.Property(e => e.PackageId)
                    .HasColumnName("Package_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasIndex(e => e.PersonId)
                    .HasName("IF1_Booking");

                entity.Property(e => e.BookingId)
                    .HasColumnName("Booking_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BookingAdded)
                    .HasColumnName("Booking_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BookingAdults).HasColumnName("Booking_Adults");

                entity.Property(e => e.BookingChildren).HasColumnName("Booking_Children");

                entity.Property(e => e.BookingCurrency)
                    .IsRequired()
                    .HasColumnName("Booking_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.BookingInfants).HasColumnName("Booking_Infants");

                entity.Property(e => e.BookingNetCost)
                    .HasColumnName("Booking_NetCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.BookingNote)
                    .HasColumnName("Booking_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.BookingOrigin).HasColumnName("Booking_Origin");

                entity.Property(e => e.BookingPaidDate)
                    .HasColumnName("Booking_PaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BookingPwd)
                    .IsRequired()
                    .HasColumnName("Booking_Pwd")
                    .HasMaxLength(32);

                entity.Property(e => e.BookingRefNo)
                    .IsRequired()
                    .HasColumnName("Booking_RefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.BookingStatus).HasColumnName("Booking_Status");

                entity.Property(e => e.BookingTitle)
                    .IsRequired()
                    .HasColumnName("Booking_Title")
                    .HasMaxLength(128);

                entity.Property(e => e.BookingTotalCost)
                    .HasColumnName("Booking_TotalCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.BookingTotalPaid)
                    .HasColumnName("Booking_TotalPaid")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.PersonId)
                    .HasColumnName("Person_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Booking__Person___062DE679");
            });

            modelBuilder.Entity<Bus>(entity =>
            {
                entity.HasIndex(e => e.BusTypeId)
                    .HasName("IF1_Bus");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IF2_Bus");

                entity.Property(e => e.BusId)
                    .HasColumnName("Bus_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BusAdded)
                    .HasColumnName("Bus_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BusArchived).HasColumnName("Bus_Archived");

                entity.Property(e => e.BusEuroType).HasColumnName("Bus_EuroType");

                entity.Property(e => e.BusFloors)
                    .HasColumnName("Bus_Floors")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BusNumDir)
                    .HasColumnName("Bus_NumDir")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BusNumber)
                    .IsRequired()
                    .HasColumnName("Bus_Number")
                    .HasMaxLength(32);

                entity.Property(e => e.BusRank).HasColumnName("Bus_Rank");

                entity.Property(e => e.BusSeatsQty).HasColumnName("Bus_SeatsQty");

                entity.Property(e => e.BusTypeId)
                    .HasColumnName("BusType_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BusUpdated)
                    .HasColumnName("Bus_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusYearProd).HasColumnName("Bus_YearProd");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.BusType)
                    .WithMany(p => p.Bus)
                    .HasForeignKey(d => d.BusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bus__BusType_ID__07220AB2");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Bus)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bus__Company_ID__08162EEB");
            });

            modelBuilder.Entity<BusCity>(entity =>
            {
                entity.HasIndex(e => e.BusRouteId)
                    .HasName("IF2_BusCity");

                entity.HasIndex(e => e.CityId)
                    .HasName("IF1_BusCity");

                entity.Property(e => e.BusCityId)
                    .HasColumnName("BusCity_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BusCityAdded)
                    .HasColumnName("BusCity_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BusCityDay).HasColumnName("BusCity_Day");

                entity.Property(e => e.BusCityDesc)
                    .HasColumnName("BusCity_Desc")
                    .HasMaxLength(256);

                entity.Property(e => e.BusCityDescMl)
                    .HasColumnName("BusCity_Desc_ML")
                    .HasMaxLength(256);

                entity.Property(e => e.BusCityEnabled)
                    .IsRequired()
                    .HasColumnName("BusCity_Enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BusCityNote)
                    .HasColumnName("BusCity_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.BusCityRank).HasColumnName("BusCity_Rank");

                entity.Property(e => e.BusCityTime)
                    .IsRequired()
                    .HasColumnName("BusCity_Time")
                    .HasMaxLength(16);

                entity.Property(e => e.BusCityUpdated)
                    .HasColumnName("BusCity_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusRouteId)
                    .HasColumnName("BusRoute_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CityId)
                    .HasColumnName("City_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.BusRoute)
                    .WithMany(p => p.BusCity)
                    .HasForeignKey(d => d.BusRouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BusCity__BusRout__09FE775D");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.BusCity)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BusCity__City_ID__090A5324");
            });

            modelBuilder.Entity<BusPrice>(entity =>
            {
                entity.HasIndex(e => e.BusRouteId)
                    .HasName("IF1_BusPrice");

                entity.HasIndex(e => e.GroupItemId)
                    .HasName("IF2_BusPrice");

                entity.Property(e => e.BusPriceId)
                    .HasColumnName("BusPrice_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BusPriceAdded)
                    .HasColumnName("BusPrice_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BusPriceArchived).HasColumnName("BusPrice_Archived");

                entity.Property(e => e.BusPriceCurrency)
                    .IsRequired()
                    .HasColumnName("BusPrice_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.BusPriceDaysMax).HasColumnName("BusPrice_DaysMax");

                entity.Property(e => e.BusPriceDaysMin)
                    .HasColumnName("BusPrice_DaysMin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BusPriceEnabled).HasColumnName("BusPrice_Enabled");

                entity.Property(e => e.BusPriceFromDate)
                    .HasColumnName("BusPrice_FromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusPriceLabel)
                    .HasColumnName("BusPrice_Label")
                    .HasMaxLength(64);

                entity.Property(e => e.BusPricePrice)
                    .HasColumnName("BusPrice_Price")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.BusPriceRank).HasColumnName("BusPrice_Rank");

                entity.Property(e => e.BusPriceSeatNumMax).HasColumnName("BusPrice_SeatNumMax");

                entity.Property(e => e.BusPriceSeatNumMin)
                    .HasColumnName("BusPrice_SeatNumMin")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BusPriceToDate)
                    .HasColumnName("BusPrice_ToDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusPriceTripQtyTill)
                    .HasColumnName("BusPrice_TripQtyTill")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BusPriceType)
                    .IsRequired()
                    .HasColumnName("BusPrice_Type")
                    .HasMaxLength(2);

                entity.Property(e => e.BusPriceUpdated)
                    .HasColumnName("BusPrice_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusRouteId)
                    .HasColumnName("BusRoute_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GroupItemId)
                    .HasColumnName("GroupItem_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.BusRoute)
                    .WithMany(p => p.BusPrice)
                    .HasForeignKey(d => d.BusRouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BusPrice__BusRou__0AF29B96");

                entity.HasOne(d => d.GroupItem)
                    .WithMany(p => p.BusPrice)
                    .HasForeignKey(d => d.GroupItemId)
                    .HasConstraintName("FK__BusPrice__GroupI__0BE6BFCF");
            });

            modelBuilder.Entity<BusProgram>(entity =>
            {
                entity.HasIndex(e => e.CountryId)
                    .HasName("IF1_BusProgram");

                entity.Property(e => e.BusProgramId)
                    .HasColumnName("BusProgram_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BusProgramAdded)
                    .HasColumnName("BusProgram_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BusProgramArchived).HasColumnName("BusProgram_Archived");

                entity.Property(e => e.BusProgramDateEnd)
                    .HasColumnName("BusProgram_DateEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusProgramDateStart)
                    .HasColumnName("BusProgram_DateStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusProgramEnabled)
                    .HasColumnName("BusProgram_Enabled")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BusProgramName)
                    .IsRequired()
                    .HasColumnName("BusProgram_Name")
                    .HasMaxLength(128);

                entity.Property(e => e.BusProgramNameMl)
                    .HasColumnName("BusProgram_Name_ML")
                    .HasMaxLength(128);

                entity.Property(e => e.BusProgramNote)
                    .HasColumnName("BusProgram_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.BusProgramUpdated)
                    .HasColumnName("BusProgram_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.BusProgram)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BusProgra__Count__0CDAE408");
            });

            modelBuilder.Entity<BusRoute>(entity =>
            {
                entity.HasIndex(e => e.BusProgramId)
                    .HasName("IF3_BusRoute");

                entity.HasIndex(e => e.CityIdfrom)
                    .HasName("IF1_BusRoute");

                entity.HasIndex(e => e.CityIdto)
                    .HasName("IF2_BusRoute");

                entity.Property(e => e.BusRouteId)
                    .HasColumnName("BusRoute_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BusProgramId)
                    .HasColumnName("BusProgram_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BusRouteAdded)
                    .HasColumnName("BusRoute_Added")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusRouteDateEnd)
                    .HasColumnName("BusRoute_DateEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusRouteDateStart)
                    .HasColumnName("BusRoute_DateStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusRouteDuration).HasColumnName("BusRoute_Duration");

                entity.Property(e => e.BusRouteEnabled)
                    .IsRequired()
                    .HasColumnName("BusRoute_Enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BusRouteName)
                    .IsRequired()
                    .HasColumnName("BusRoute_Name")
                    .HasMaxLength(128);

                entity.Property(e => e.BusRouteNameMl)
                    .HasColumnName("BusRoute_Name_ML")
                    .HasMaxLength(128);

                entity.Property(e => e.BusRouteNote)
                    .HasColumnName("BusRoute_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.BusRouteUpdated)
                    .HasColumnName("BusRoute_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.CityIdfrom)
                    .HasColumnName("City_IDFrom")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CityIdto)
                    .HasColumnName("City_IDTo")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.BusProgram)
                    .WithMany(p => p.BusRoute)
                    .HasForeignKey(d => d.BusProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BusRoute__BusPro__0FB750B3");

                entity.HasOne(d => d.CityIdfromNavigation)
                    .WithMany(p => p.BusRouteCityIdfromNavigation)
                    .HasForeignKey(d => d.CityIdfrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BusRoute__City_I__0DCF0841");

                entity.HasOne(d => d.CityIdtoNavigation)
                    .WithMany(p => p.BusRouteCityIdtoNavigation)
                    .HasForeignKey(d => d.CityIdto)
                    .HasConstraintName("FK__BusRoute__City_I__0EC32C7A");
            });

            modelBuilder.Entity<BusSeat>(entity =>
            {
                entity.HasIndex(e => e.BusId)
                    .HasName("IF1_BusSeat");

                entity.Property(e => e.BusSeatId)
                    .HasColumnName("BusSeat_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BusId)
                    .HasColumnName("Bus_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BusSeatAdded)
                    .HasColumnName("BusSeat_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BusSeatCol1Num).HasColumnName("BusSeat_Col1Num");

                entity.Property(e => e.BusSeatCol1Tv).HasColumnName("BusSeat_Col1TV");

                entity.Property(e => e.BusSeatCol1Type)
                    .IsRequired()
                    .HasColumnName("BusSeat_Col1Type")
                    .HasMaxLength(1);

                entity.Property(e => e.BusSeatCol2Num).HasColumnName("BusSeat_Col2Num");

                entity.Property(e => e.BusSeatCol2Tv).HasColumnName("BusSeat_Col2TV");

                entity.Property(e => e.BusSeatCol2Type)
                    .IsRequired()
                    .HasColumnName("BusSeat_Col2Type")
                    .HasMaxLength(1);

                entity.Property(e => e.BusSeatCol3Num).HasColumnName("BusSeat_Col3Num");

                entity.Property(e => e.BusSeatCol3Tv).HasColumnName("BusSeat_Col3TV");

                entity.Property(e => e.BusSeatCol3Type)
                    .IsRequired()
                    .HasColumnName("BusSeat_Col3Type")
                    .HasMaxLength(1);

                entity.Property(e => e.BusSeatCol4Num).HasColumnName("BusSeat_Col4Num");

                entity.Property(e => e.BusSeatCol4Tv).HasColumnName("BusSeat_Col4TV");

                entity.Property(e => e.BusSeatCol4Type)
                    .IsRequired()
                    .HasColumnName("BusSeat_Col4Type")
                    .HasMaxLength(1);

                entity.Property(e => e.BusSeatCol5Num).HasColumnName("BusSeat_Col5Num");

                entity.Property(e => e.BusSeatCol5Tv).HasColumnName("BusSeat_Col5TV");

                entity.Property(e => e.BusSeatCol5Type)
                    .IsRequired()
                    .HasColumnName("BusSeat_Col5Type")
                    .HasMaxLength(1);

                entity.Property(e => e.BusSeatFloor).HasColumnName("BusSeat_Floor");

                entity.Property(e => e.BusSeatRank).HasColumnName("BusSeat_Rank");

                entity.Property(e => e.BusSeatRow).HasColumnName("BusSeat_Row");

                entity.Property(e => e.BusSeatUpdated)
                    .HasColumnName("BusSeat_Updated")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.BusSeat)
                    .HasForeignKey(d => d.BusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BusSeat__Bus_ID__10AB74EC");
            });

            modelBuilder.Entity<BusTrip>(entity =>
            {
                entity.HasIndex(e => e.BusId)
                    .HasName("IF2_BusTrip");

                entity.HasIndex(e => e.BusRouteId)
                    .HasName("IF1_BusTrip");

                entity.Property(e => e.BusTripId)
                    .HasColumnName("BusTrip_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BusId)
                    .HasColumnName("Bus_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BusRouteId)
                    .HasColumnName("BusRoute_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BusTripAdded)
                    .HasColumnName("BusTrip_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BusTripArchived).HasColumnName("BusTrip_Archived");

                entity.Property(e => e.BusTripDate)
                    .HasColumnName("BusTrip_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusTripEnabled).HasColumnName("BusTrip_Enabled");

                entity.Property(e => e.BusTripNote)
                    .HasColumnName("BusTrip_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.BusTripUpdated)
                    .HasColumnName("BusTrip_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusTriptArchived).HasColumnName("BusTript_Archived");

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.BusTrip)
                    .HasForeignKey(d => d.BusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BusTrip__Bus_ID__1293BD5E");

                entity.HasOne(d => d.BusRoute)
                    .WithMany(p => p.BusTrip)
                    .HasForeignKey(d => d.BusRouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BusTrip__BusRout__119F9925");
            });

            modelBuilder.Entity<BusTripSeat>(entity =>
            {
                entity.HasIndex(e => e.BusTripId)
                    .HasName("IF6_BusTripSeat");

                entity.HasIndex(e => e.CityIdfrom1)
                    .HasName("IF7_BusTripSeat");

                entity.HasIndex(e => e.CityIdfrom2)
                    .HasName("IF9_BusTripSeat");

                entity.HasIndex(e => e.CityIdfrom3)
                    .HasName("IF11_BusTripSeat");

                entity.HasIndex(e => e.CityIdfrom4)
                    .HasName("IF13_BusTripSeat");

                entity.HasIndex(e => e.CityIdfrom5)
                    .HasName("IF15_BusTripSeat");

                entity.HasIndex(e => e.CityIdto1)
                    .HasName("IF8_BusTripSeat");

                entity.HasIndex(e => e.CityIdto2)
                    .HasName("IF10_BusTripSeat");

                entity.HasIndex(e => e.CityIdto3)
                    .HasName("IF12_BusTripSeat");

                entity.HasIndex(e => e.CityIdto4)
                    .HasName("IF14_BusTripSeat");

                entity.HasIndex(e => e.CityIdto5)
                    .HasName("IF16_BusTripSeat");

                entity.HasIndex(e => e.ReqPassportId1)
                    .HasName("IF1_BusTripSeat");

                entity.HasIndex(e => e.ReqPassportId2)
                    .HasName("IF2_BusTripSeat");

                entity.HasIndex(e => e.ReqPassportId3)
                    .HasName("IF3_BusTripSeat");

                entity.HasIndex(e => e.ReqPassportId4)
                    .HasName("IF4_BusTripSeat");

                entity.HasIndex(e => e.ReqPassportId5)
                    .HasName("IF5_BusTripSeat");

                entity.Property(e => e.BusTripSeatId)
                    .HasColumnName("BusTripSeat_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BusTripId)
                    .HasColumnName("BusTrip_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BusTripSeatAdded)
                    .HasColumnName("BusTripSeat_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BusTripSeatCol1Note)
                    .HasColumnName("BusTripSeat_Col1Note")
                    .HasMaxLength(32);

                entity.Property(e => e.BusTripSeatCol1Num).HasColumnName("BusTripSeat_Col1Num");

                entity.Property(e => e.BusTripSeatCol1Tv).HasColumnName("BusTripSeat_Col1TV");

                entity.Property(e => e.BusTripSeatCol1Type)
                    .IsRequired()
                    .HasColumnName("BusTripSeat_Col1Type")
                    .HasMaxLength(1);

                entity.Property(e => e.BusTripSeatCol2Note)
                    .HasColumnName("BusTripSeat_Col2Note")
                    .HasMaxLength(32);

                entity.Property(e => e.BusTripSeatCol2Num).HasColumnName("BusTripSeat_Col2Num");

                entity.Property(e => e.BusTripSeatCol2Tv).HasColumnName("BusTripSeat_Col2TV");

                entity.Property(e => e.BusTripSeatCol2Type)
                    .IsRequired()
                    .HasColumnName("BusTripSeat_Col2Type")
                    .HasMaxLength(1);

                entity.Property(e => e.BusTripSeatCol3Note)
                    .HasColumnName("BusTripSeat_Col3Note")
                    .HasMaxLength(32);

                entity.Property(e => e.BusTripSeatCol3Num).HasColumnName("BusTripSeat_Col3Num");

                entity.Property(e => e.BusTripSeatCol3Tv).HasColumnName("BusTripSeat_Col3TV");

                entity.Property(e => e.BusTripSeatCol3Type)
                    .IsRequired()
                    .HasColumnName("BusTripSeat_Col3Type")
                    .HasMaxLength(1);

                entity.Property(e => e.BusTripSeatCol4Note)
                    .HasColumnName("BusTripSeat_Col4Note")
                    .HasMaxLength(32);

                entity.Property(e => e.BusTripSeatCol4Num).HasColumnName("BusTripSeat_Col4Num");

                entity.Property(e => e.BusTripSeatCol4Tv).HasColumnName("BusTripSeat_Col4TV");

                entity.Property(e => e.BusTripSeatCol4Type)
                    .IsRequired()
                    .HasColumnName("BusTripSeat_Col4Type")
                    .HasMaxLength(1);

                entity.Property(e => e.BusTripSeatCol5Note)
                    .HasColumnName("BusTripSeat_Col5Note")
                    .HasMaxLength(32);

                entity.Property(e => e.BusTripSeatCol5Num).HasColumnName("BusTripSeat_Col5Num");

                entity.Property(e => e.BusTripSeatCol5Tv).HasColumnName("BusTripSeat_Col5TV");

                entity.Property(e => e.BusTripSeatCol5Type)
                    .IsRequired()
                    .HasColumnName("BusTripSeat_Col5Type")
                    .HasMaxLength(1);

                entity.Property(e => e.BusTripSeatFloor).HasColumnName("BusTripSeat_Floor");

                entity.Property(e => e.BusTripSeatRank).HasColumnName("BusTripSeat_Rank");

                entity.Property(e => e.BusTripSeatRow).HasColumnName("BusTripSeat_Row");

                entity.Property(e => e.BusTripSeatUpdated)
                    .HasColumnName("BusTripSeat_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.CityIdfrom1)
                    .HasColumnName("City_IDFrom1")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CityIdfrom2)
                    .HasColumnName("City_IDFrom2")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CityIdfrom3)
                    .HasColumnName("City_IDFrom3")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CityIdfrom4)
                    .HasColumnName("City_IDFrom4")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CityIdfrom5)
                    .HasColumnName("City_IDFrom5")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CityIdto1)
                    .HasColumnName("City_IDTo1")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CityIdto2)
                    .HasColumnName("City_IDTo2")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CityIdto3)
                    .HasColumnName("City_IDTo3")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CityIdto4)
                    .HasColumnName("City_IDTo4")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CityIdto5)
                    .HasColumnName("City_IDTo5")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqPassportId1)
                    .HasColumnName("ReqPassport_ID1")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqPassportId2)
                    .HasColumnName("ReqPassport_ID2")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqPassportId3)
                    .HasColumnName("ReqPassport_ID3")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqPassportId4)
                    .HasColumnName("ReqPassport_ID4")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqPassportId5)
                    .HasColumnName("ReqPassport_ID5")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.BusTrip)
                    .WithMany(p => p.BusTripSeat)
                    .HasForeignKey(d => d.BusTripId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BusTripSe__BusTr__20E1DCB5");

                entity.HasOne(d => d.CityIdfrom1Navigation)
                    .WithMany(p => p.BusTripSeatCityIdfrom1Navigation)
                    .HasForeignKey(d => d.CityIdfrom1)
                    .HasConstraintName("FK__BusTripSe__City___21D600EE");

                entity.HasOne(d => d.CityIdfrom2Navigation)
                    .WithMany(p => p.BusTripSeatCityIdfrom2Navigation)
                    .HasForeignKey(d => d.CityIdfrom2)
                    .HasConstraintName("FK__BusTripSe__City___23BE4960");

                entity.HasOne(d => d.CityIdfrom3Navigation)
                    .WithMany(p => p.BusTripSeatCityIdfrom3Navigation)
                    .HasForeignKey(d => d.CityIdfrom3)
                    .HasConstraintName("FK__BusTripSe__City___16644E42");

                entity.HasOne(d => d.CityIdfrom4Navigation)
                    .WithMany(p => p.BusTripSeatCityIdfrom4Navigation)
                    .HasForeignKey(d => d.CityIdfrom4)
                    .HasConstraintName("FK__BusTripSe__City___184C96B4");

                entity.HasOne(d => d.CityIdfrom5Navigation)
                    .WithMany(p => p.BusTripSeatCityIdfrom5Navigation)
                    .HasForeignKey(d => d.CityIdfrom5)
                    .HasConstraintName("FK__BusTripSe__City___1A34DF26");

                entity.HasOne(d => d.CityIdto1Navigation)
                    .WithMany(p => p.BusTripSeatCityIdto1Navigation)
                    .HasForeignKey(d => d.CityIdto1)
                    .HasConstraintName("FK__BusTripSe__City___22CA2527");

                entity.HasOne(d => d.CityIdto2Navigation)
                    .WithMany(p => p.BusTripSeatCityIdto2Navigation)
                    .HasForeignKey(d => d.CityIdto2)
                    .HasConstraintName("FK__BusTripSe__City___15702A09");

                entity.HasOne(d => d.CityIdto3Navigation)
                    .WithMany(p => p.BusTripSeatCityIdto3Navigation)
                    .HasForeignKey(d => d.CityIdto3)
                    .HasConstraintName("FK__BusTripSe__City___1758727B");

                entity.HasOne(d => d.CityIdto4Navigation)
                    .WithMany(p => p.BusTripSeatCityIdto4Navigation)
                    .HasForeignKey(d => d.CityIdto4)
                    .HasConstraintName("FK__BusTripSe__City___1940BAED");

                entity.HasOne(d => d.CityIdto5Navigation)
                    .WithMany(p => p.BusTripSeatCityIdto5Navigation)
                    .HasForeignKey(d => d.CityIdto5)
                    .HasConstraintName("FK__BusTripSe__City___1B29035F");

                entity.HasOne(d => d.ReqPassportId1Navigation)
                    .WithMany(p => p.BusTripSeatReqPassportId1Navigation)
                    .HasForeignKey(d => d.ReqPassportId1)
                    .HasConstraintName("FK__BusTripSe__ReqPa__1C1D2798");

                entity.HasOne(d => d.ReqPassportId2Navigation)
                    .WithMany(p => p.BusTripSeatReqPassportId2Navigation)
                    .HasForeignKey(d => d.ReqPassportId2)
                    .HasConstraintName("FK__BusTripSe__ReqPa__1D114BD1");

                entity.HasOne(d => d.ReqPassportId3Navigation)
                    .WithMany(p => p.BusTripSeatReqPassportId3Navigation)
                    .HasForeignKey(d => d.ReqPassportId3)
                    .HasConstraintName("FK__BusTripSe__ReqPa__1E05700A");

                entity.HasOne(d => d.ReqPassportId4Navigation)
                    .WithMany(p => p.BusTripSeatReqPassportId4Navigation)
                    .HasForeignKey(d => d.ReqPassportId4)
                    .HasConstraintName("FK__BusTripSe__ReqPa__1EF99443");

                entity.HasOne(d => d.ReqPassportId5Navigation)
                    .WithMany(p => p.BusTripSeatReqPassportId5Navigation)
                    .HasForeignKey(d => d.ReqPassportId5)
                    .HasConstraintName("FK__BusTripSe__ReqPa__1FEDB87C");
            });

            modelBuilder.Entity<BusType>(entity =>
            {
                entity.Property(e => e.BusTypeId)
                    .HasColumnName("BusType_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BusTypeAdded)
                    .HasColumnName("BusType_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BusTypeEuroType).HasColumnName("BusType_EuroType");

                entity.Property(e => e.BusTypeFloors)
                    .HasColumnName("BusType_Floors")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BusTypeModel)
                    .IsRequired()
                    .HasColumnName("BusType_Model")
                    .HasMaxLength(64);

                entity.Property(e => e.BusTypeModelMl)
                    .HasColumnName("BusType_Model_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.BusTypeNumDir)
                    .HasColumnName("BusType_NumDir")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BusTypeRank).HasColumnName("BusType_Rank");

                entity.Property(e => e.BusTypeRows)
                    .IsRequired()
                    .HasColumnName("BusType_Rows")
                    .HasMaxLength(512);

                entity.Property(e => e.BusTypeSeatsQty).HasColumnName("BusType_SeatsQty");

                entity.Property(e => e.BusTypeUpdated)
                    .HasColumnName("BusType_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusTypeYearProd).HasColumnName("BusType_YearProd");
            });

            modelBuilder.Entity<CarHire>(entity =>
            {
                entity.HasIndex(e => e.AgencyId)
                    .HasName("IF4_CarHire");

                entity.HasIndex(e => e.BookingId)
                    .HasName("IF5_CarHire");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IF1_CarHire");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IF3_CarHire");

                entity.Property(e => e.CarHireId)
                    .HasColumnName("CarHire_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AgencyId)
                    .HasColumnName("Agency_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BookingId)
                    .HasColumnName("Booking_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CarHireAdded)
                    .HasColumnName("CarHire_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CarHireAdults)
                    .HasColumnName("CarHire_Adults")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CarHireAgencyCommision)
                    .HasColumnName("CarHire_AgencyCommision")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.CarHireAgencyPaidDate)
                    .HasColumnName("CarHire_AgencyPaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CarHireAgencyRefNo)
                    .HasColumnName("CarHire_AgencyRefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.CarHireCancellationPolicy)
                    .HasColumnName("CarHire_CancellationPolicy")
                    .HasColumnType("ntext");

                entity.Property(e => e.CarHireCarType)
                    .IsRequired()
                    .HasColumnName("CarHire_CarType")
                    .HasMaxLength(32);

                entity.Property(e => e.CarHireChildAges)
                    .HasColumnName("CarHire_ChildAges")
                    .HasMaxLength(32);

                entity.Property(e => e.CarHireChildren).HasColumnName("CarHire_Children");

                entity.Property(e => e.CarHireCurrency)
                    .IsRequired()
                    .HasColumnName("CarHire_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.CarHireDropOffDate)
                    .HasColumnName("CarHire_DropOffDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CarHireDropOffLocation)
                    .IsRequired()
                    .HasColumnName("CarHire_DropOffLocation")
                    .HasMaxLength(32);

                entity.Property(e => e.CarHireDropOffTime)
                    .IsRequired()
                    .HasColumnName("CarHire_DropOffTime")
                    .HasMaxLength(16);

                entity.Property(e => e.CarHireImportantInfo)
                    .HasColumnName("CarHire_ImportantInfo")
                    .HasColumnType("ntext");

                entity.Property(e => e.CarHireInfants).HasColumnName("CarHire_Infants");

                entity.Property(e => e.CarHireNetCost)
                    .HasColumnName("CarHire_NetCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.CarHireNote)
                    .HasColumnName("CarHire_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.CarHireOrigin)
                    .HasColumnName("CarHire_Origin")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CarHirePaidDate)
                    .HasColumnName("CarHire_PaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CarHirePickUpDate)
                    .HasColumnName("CarHire_PickUpDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CarHirePickUpLocation)
                    .IsRequired()
                    .HasColumnName("CarHire_PickUpLocation")
                    .HasMaxLength(32);

                entity.Property(e => e.CarHirePickUpTime)
                    .IsRequired()
                    .HasColumnName("CarHire_PickUpTime")
                    .HasMaxLength(16);

                entity.Property(e => e.CarHirePwd)
                    .IsRequired()
                    .HasColumnName("CarHire_Pwd")
                    .HasMaxLength(32);

                entity.Property(e => e.CarHireRefNo)
                    .IsRequired()
                    .HasColumnName("CarHire_RefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.CarHireSpecialRequest)
                    .HasColumnName("CarHire_SpecialRequest")
                    .HasMaxLength(32);

                entity.Property(e => e.CarHireStatus)
                    .HasColumnName("CarHire_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CarHireSupplierPaidDate)
                    .HasColumnName("CarHire_SupplierPaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CarHireSupplierRefNo)
                    .HasColumnName("CarHire_SupplierRefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.CarHireTotalCost)
                    .HasColumnName("CarHire_TotalCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.CarHireTotalPaid)
                    .HasColumnName("CarHire_TotalPaid")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.PersonId)
                    .HasColumnName("Person_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("Supplier_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.CarHireAgency)
                    .HasForeignKey(d => d.AgencyId)
                    .HasConstraintName("FK__CarHire__Agency___25A691D2");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.CarHire)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK__CarHire__Booking__24B26D99");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.CarHire)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CarHire__Person___278EDA44");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.CarHireSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK__CarHire__Supplie__269AB60B");
            });

            modelBuilder.Entity<Chflight>(entity =>
            {
                entity.ToTable("CHFlight");

                entity.HasIndex(e => e.AirlineId)
                    .HasName("IF3_CHFlight");

                entity.HasIndex(e => e.FromAirportId)
                    .HasName("IF1_CHFlight");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IF4_CHFlight");

                entity.HasIndex(e => e.ToAirportId)
                    .HasName("IF2_CHFlight");

                entity.Property(e => e.ChflightId)
                    .HasColumnName("CHFlight_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AirlineId)
                    .HasColumnName("Airline_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ChflightAdded)
                    .HasColumnName("CHFlight_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ChflightBoardBasisOw)
                    .HasColumnName("CHFlight_BoardBasisOW")
                    .HasColumnType("money");

                entity.Property(e => e.ChflightCurrency)
                    .IsRequired()
                    .HasColumnName("CHFlight_Currency")
                    .HasMaxLength(3);

                entity.Property(e => e.ChflightDate)
                    .HasColumnName("CHFlight_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChflightFlightBack)
                    .IsRequired()
                    .HasColumnName("CHFlight_FlightBack")
                    .HasMaxLength(12);

                entity.Property(e => e.ChflightFlightBackArr)
                    .HasColumnName("CHFlight_FlightBackArr")
                    .HasMaxLength(12);

                entity.Property(e => e.ChflightFlightBackDep)
                    .HasColumnName("CHFlight_FlightBackDep")
                    .HasMaxLength(12);

                entity.Property(e => e.ChflightFlightThere)
                    .IsRequired()
                    .HasColumnName("CHFlight_FlightThere")
                    .HasMaxLength(12);

                entity.Property(e => e.ChflightFlightThereArr)
                    .IsRequired()
                    .HasColumnName("CHFlight_FlightThereArr")
                    .HasMaxLength(12);

                entity.Property(e => e.ChflightFlightThereDep)
                    .IsRequired()
                    .HasColumnName("CHFlight_FlightThereDep")
                    .HasMaxLength(12);

                entity.Property(e => e.ChflightFromAirportTax)
                    .HasColumnName("CHFlight_FromAirportTax")
                    .HasColumnType("money");

                entity.Property(e => e.ChflightPrice1011)
                    .HasColumnName("CHFlight_Price1011")
                    .HasColumnType("money");

                entity.Property(e => e.ChflightPrice14)
                    .HasColumnName("CHFlight_Price14")
                    .HasColumnType("money");

                entity.Property(e => e.ChflightPrice21)
                    .HasColumnName("CHFlight_Price21")
                    .HasColumnType("money");

                entity.Property(e => e.ChflightPrice7)
                    .HasColumnName("CHFlight_Price7")
                    .HasColumnType("money");

                entity.Property(e => e.ChflightSeatsBack).HasColumnName("CHFlight_SeatsBack");

                entity.Property(e => e.ChflightSeatsThere).HasColumnName("CHFlight_SeatsThere");

                entity.Property(e => e.ChflightTariff)
                    .HasColumnName("CHFlight_Tariff")
                    .HasColumnType("money");

                entity.Property(e => e.ChflightTitle)
                    .IsRequired()
                    .HasColumnName("CHFlight_Title")
                    .HasMaxLength(32);

                entity.Property(e => e.ChflightToAirportTax)
                    .HasColumnName("CHFlight_ToAirportTax")
                    .HasColumnType("money");

                entity.Property(e => e.ChflightUpdated)
                    .HasColumnName("CHFlight_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromAirportId)
                    .HasColumnName("FromAirport_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("Supplier_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ToAirportId)
                    .HasColumnName("ToAirport_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Airline)
                    .WithMany(p => p.Chflight)
                    .HasForeignKey(d => d.AirlineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHFlight__Airlin__2A6B46EF");

                entity.HasOne(d => d.FromAirport)
                    .WithMany(p => p.ChflightFromAirport)
                    .HasForeignKey(d => d.FromAirportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHFlight__FromAi__2882FE7D");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Chflight)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHFlight__Suppli__2B5F6B28");

                entity.HasOne(d => d.ToAirport)
                    .WithMany(p => p.ChflightToAirport)
                    .HasForeignKey(d => d.ToAirportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHFlight__ToAirp__297722B6");
            });

            modelBuilder.Entity<ChflightSeat>(entity =>
            {
                entity.ToTable("CHFlightSeat");

                entity.HasIndex(e => e.ChflightId)
                    .HasName("IF1_CHFlightSeat");

                entity.HasIndex(e => e.ParentChflightSeatId)
                    .HasName("IF2_CHFlightSeat");

                entity.Property(e => e.ChflightSeatId)
                    .HasColumnName("CHFlightSeat_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ChflightId)
                    .HasColumnName("CHFlight_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ChflightSeatAdded)
                    .HasColumnName("CHFlightSeat_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ChflightSeatNote)
                    .HasColumnName("CHFlightSeat_Note")
                    .HasMaxLength(256);

                entity.Property(e => e.ChflightSeatStatus).HasColumnName("CHFlightSeat_Status");

                entity.Property(e => e.ChflightSeatType).HasColumnName("CHFlightSeat_Type");

                entity.Property(e => e.ChflightSeatUpdated)
                    .HasColumnName("CHFlightSeat_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentChflightSeatId)
                    .HasColumnName("ParentCHFlightSeat_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Chflight)
                    .WithMany(p => p.ChflightSeat)
                    .HasForeignKey(d => d.ChflightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHFlightS__CHFli__2C538F61");

                entity.HasOne(d => d.ParentChflightSeat)
                    .WithMany(p => p.InverseParentChflightSeat)
                    .HasForeignKey(d => d.ParentChflightSeatId)
                    .HasConstraintName("FK__CHFlightS__Paren__2D47B39A");
            });

            modelBuilder.Entity<Chmap>(entity =>
            {
                entity.ToTable("CHMap");

                entity.HasIndex(e => e.AirlineId)
                    .HasName("IF3_CHMap");

                entity.HasIndex(e => e.FromAirportId)
                    .HasName("IF1_CHMap");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IF4_CHMap");

                entity.HasIndex(e => e.ToAirportId)
                    .HasName("IF2_CHMap");

                entity.Property(e => e.ChmapId)
                    .HasColumnName("CHMap_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AirlineId)
                    .HasColumnName("Airline_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ChmapAdded)
                    .HasColumnName("CHMap_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ChmapBoardBasisOw)
                    .HasColumnName("CHMap_BoardBasisOW")
                    .HasColumnType("money");

                entity.Property(e => e.ChmapCurrency)
                    .IsRequired()
                    .HasColumnName("CHMap_Currency")
                    .HasMaxLength(3);

                entity.Property(e => e.ChmapEvery)
                    .IsRequired()
                    .HasColumnName("CHMap_Every")
                    .HasMaxLength(12);

                entity.Property(e => e.ChmapFlightBack)
                    .IsRequired()
                    .HasColumnName("CHMap_FlightBack")
                    .HasMaxLength(12);

                entity.Property(e => e.ChmapFlightBackArr)
                    .HasColumnName("CHMap_FlightBackArr")
                    .HasMaxLength(12);

                entity.Property(e => e.ChmapFlightBackDep)
                    .HasColumnName("CHMap_FlightBackDep")
                    .HasMaxLength(12);

                entity.Property(e => e.ChmapFlightThere)
                    .IsRequired()
                    .HasColumnName("CHMap_FlightThere")
                    .HasMaxLength(12);

                entity.Property(e => e.ChmapFlightThereArr)
                    .IsRequired()
                    .HasColumnName("CHMap_FlightThereArr")
                    .HasMaxLength(12);

                entity.Property(e => e.ChmapFlightThereDep)
                    .IsRequired()
                    .HasColumnName("CHMap_FlightThereDep")
                    .HasMaxLength(12);

                entity.Property(e => e.ChmapFlightsTotal)
                    .IsRequired()
                    .HasColumnName("CHMap_FlightsTotal")
                    .HasMaxLength(32);

                entity.Property(e => e.ChmapFromAirportTax)
                    .HasColumnName("CHMap_FromAirportTax")
                    .HasColumnType("money");

                entity.Property(e => e.ChmapFromDate)
                    .HasColumnName("CHMap_FromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChmapSeats).HasColumnName("CHMap_Seats");

                entity.Property(e => e.ChmapTariff)
                    .HasColumnName("CHMap_Tariff")
                    .HasColumnType("money");

                entity.Property(e => e.ChmapTitle)
                    .IsRequired()
                    .HasColumnName("CHMap_Title")
                    .HasMaxLength(32);

                entity.Property(e => e.ChmapToAirportTax)
                    .HasColumnName("CHMap_ToAirportTax")
                    .HasColumnType("money");

                entity.Property(e => e.ChmapToDate)
                    .HasColumnName("CHMap_ToDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChmapUpdated)
                    .HasColumnName("CHMap_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromAirportId)
                    .HasColumnName("FromAirport_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("Supplier_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ToAirportId)
                    .HasColumnName("ToAirport_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Airline)
                    .WithMany(p => p.Chmap)
                    .HasForeignKey(d => d.AirlineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHMap__Airline_I__30242045");

                entity.HasOne(d => d.FromAirport)
                    .WithMany(p => p.ChmapFromAirport)
                    .HasForeignKey(d => d.FromAirportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHMap__FromAirpo__2E3BD7D3");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Chmap)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHMap__Supplier___3118447E");

                entity.HasOne(d => d.ToAirport)
                    .WithMany(p => p.ChmapToAirport)
                    .HasForeignKey(d => d.ToAirportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHMap__ToAirport__2F2FFC0C");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasIndex(e => e.CountryId)
                    .HasName("IF1_City");

                entity.HasIndex(e => e.StateId)
                    .HasName("IF2_City");

                entity.Property(e => e.CityId)
                    .HasColumnName("City_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CityEnabled)
                    .IsRequired()
                    .HasColumnName("City_Enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("City_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.CityNameMl)
                    .HasColumnName("City_Name_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.CityRank).HasColumnName("City_Rank");

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StateId)
                    .HasColumnName("State_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__City__Country_ID__320C68B7");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__City__State_ID__33008CF0");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyAccess).HasColumnName("Company_Access");

                entity.Property(e => e.CompanyAdded)
                    .HasColumnName("Company_Added")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompanyAddedById)
                    .HasColumnName("Company_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyAgrDate)
                    .HasColumnName("Company_AgrDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompanyAgrLogin)
                    .HasColumnName("Company_AgrLogin")
                    .HasMaxLength(32);

                entity.Property(e => e.CompanyAgrLoginExt)
                    .HasColumnName("Company_AgrLoginExt")
                    .HasMaxLength(32);

                entity.Property(e => e.CompanyAgrLoginUrl)
                    .HasColumnName("Company_AgrLoginURL")
                    .HasMaxLength(256);

                entity.Property(e => e.CompanyAgrNote)
                    .HasColumnName("Company_AgrNote")
                    .HasColumnType("ntext");

                entity.Property(e => e.CompanyAgrNumber)
                    .HasColumnName("Company_AgrNumber")
                    .HasMaxLength(32);

                entity.Property(e => e.CompanyAgrPwd)
                    .HasColumnName("Company_AgrPwd")
                    .HasMaxLength(32);

                entity.Property(e => e.CompanyAgrValidTill)
                    .HasColumnName("Company_AgrValidTill")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompanyArchived).HasColumnName("Company_Archived");

                entity.Property(e => e.CompanyCreated)
                    .HasColumnName("Company_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CompanyEdrpou)
                    .HasColumnName("Company_EDRPOU")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyEmail)
                    .IsRequired()
                    .HasColumnName("Company_Email")
                    .HasMaxLength(128);

                entity.Property(e => e.CompanyEmailInfo)
                    .HasColumnName("Company_EmailInfo")
                    .HasMaxLength(128);

                entity.Property(e => e.CompanyEmailSales)
                    .HasColumnName("Company_EmailSales")
                    .HasMaxLength(128);

                entity.Property(e => e.CompanyFax)
                    .HasColumnName("Company_Fax")
                    .HasMaxLength(32);

                entity.Property(e => e.CompanyLabel)
                    .HasColumnName("Company_Label")
                    .HasMaxLength(32);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company_Name")
                    .HasMaxLength(256);

                entity.Property(e => e.CompanyNote)
                    .HasColumnName("Company_Note")
                    .HasMaxLength(1024);

                entity.Property(e => e.CompanyPhone)
                    .IsRequired()
                    .HasColumnName("Company_Phone")
                    .HasMaxLength(32);

                entity.Property(e => e.CompanyPhone2)
                    .HasColumnName("Company_Phone2")
                    .HasMaxLength(32);

                entity.Property(e => e.CompanyRank).HasColumnName("Company_Rank");

                entity.Property(e => e.CompanyStatus)
                    .HasColumnName("Company_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyTitle)
                    .HasColumnName("Company_Title")
                    .HasMaxLength(32);

                entity.Property(e => e.CompanyType).HasColumnName("Company_Type");

                entity.Property(e => e.CompanyUpdated)
                    .HasColumnName("Company_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompanyUpdatedById)
                    .HasColumnName("Company_UpdatedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CompanyUrl)
                    .HasColumnName("Company_URL")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.ContactId)
                    .HasColumnName("Contact_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContactAdded)
                    .HasColumnName("Contact_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ContactCompany)
                    .HasColumnName("Contact_Company")
                    .HasMaxLength(64);

                entity.Property(e => e.ContactEmail)
                    .HasColumnName("Contact_Email")
                    .HasMaxLength(128);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasColumnName("Contact_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.ContactNote)
                    .HasColumnName("Contact_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContactPhone)
                    .HasColumnName("Contact_Phone")
                    .HasMaxLength(32);

                entity.Property(e => e.ContactPhone2)
                    .HasColumnName("Contact_Phone2")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<ContactInfo>(entity =>
            {
                entity.HasIndex(e => e.ContactId)
                    .HasName("IF1_ContactInfo");

                entity.Property(e => e.ContactInfoId)
                    .HasColumnName("ContactInfo_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContactId)
                    .HasColumnName("Contact_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContactInfoAdded)
                    .HasColumnName("ContactInfo_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ContactInfoBooking).HasColumnName("ContactInfo_Booking");

                entity.Property(e => e.ContactInfoBudget)
                    .HasColumnName("ContactInfo_Budget")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.ContactInfoCurrency)
                    .HasColumnName("ContactInfo_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.ContactInfoDestination)
                    .IsRequired()
                    .HasColumnName("ContactInfo_Destination")
                    .HasMaxLength(64);

                entity.Property(e => e.ContactInfoDetails)
                    .HasColumnName("ContactInfo_Details")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContactInfoFromDate)
                    .HasColumnName("ContactInfo_FromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContactInfoNotified).HasColumnName("ContactInfo_Notified");

                entity.Property(e => e.ContactInfoNotify)
                    .HasColumnName("ContactInfo_Notify")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContactInfoToDate)
                    .HasColumnName("ContactInfo_ToDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContactInfoType)
                    .HasColumnName("ContactInfo_Type")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactInfo)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ContactIn__Conta__33F4B129");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.HasIndex(e => e.ContentQueryString)
                    .HasName("AK_Content_QUERY_STRING");

                entity.HasIndex(e => e.ContentScriptName)
                    .HasName("AK_Content_SCRIPT_NAME");

                entity.HasIndex(e => e.ContentTag)
                    .HasName("AK_Content_Tag");

                entity.HasIndex(e => e.ContentType)
                    .HasName("AK_Content_Type");

                entity.Property(e => e.ContentId)
                    .HasColumnName("Content_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContentAdded)
                    .HasColumnName("Content_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ContentAddedById)
                    .HasColumnName("Content_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContentHtml)
                    .HasColumnName("Content_HTML")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContentKeywords)
                    .HasColumnName("Content_Keywords")
                    .HasMaxLength(1024);

                entity.Property(e => e.ContentLang)
                    .HasColumnName("Content_Lang")
                    .HasMaxLength(8);

                entity.Property(e => e.ContentPublished)
                    .HasColumnName("Content_Published")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ContentQueryString)
                    .HasColumnName("Content_QUERY_STRING")
                    .HasMaxLength(256);

                entity.Property(e => e.ContentScriptName)
                    .HasColumnName("Content_SCRIPT_NAME")
                    .HasMaxLength(256);

                entity.Property(e => e.ContentSeourl)
                    .HasColumnName("Content_SEOURL")
                    .HasMaxLength(256);

                entity.Property(e => e.ContentServerName)
                    .HasColumnName("Content_SERVER_NAME")
                    .HasMaxLength(256);

                entity.Property(e => e.ContentStatus)
                    .HasColumnName("Content_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ContentTag)
                    .HasColumnName("Content_Tag")
                    .HasMaxLength(64);

                entity.Property(e => e.ContentTagValue)
                    .HasColumnName("Content_TagValue")
                    .HasMaxLength(64);

                entity.Property(e => e.ContentText)
                    .HasColumnName("Content_Text")
                    .HasMaxLength(1024);

                entity.Property(e => e.ContentTextInit)
                    .HasColumnName("Content_TextInit")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContentTitle)
                    .IsRequired()
                    .HasColumnName("Content_Title")
                    .HasMaxLength(512);

                entity.Property(e => e.ContentType)
                    .HasColumnName("Content_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ContentUpdated)
                    .HasColumnName("Content_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContentUpdatedById)
                    .HasColumnName("Content_UpdatedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContentUrl)
                    .HasColumnName("Content_URL")
                    .HasMaxLength(512);

                entity.Property(e => e.ContentViewed).HasColumnName("Content_Viewed");
            });

            modelBuilder.Entity<CorpClient>(entity =>
            {
                entity.Property(e => e.CorpClientId)
                    .HasColumnName("CorpClient_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CorpClientAdded)
                    .HasColumnName("CorpClient_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CorpClientAdvNum).HasColumnName("CorpClient_AdvNum");

                entity.Property(e => e.CorpClientAdvSent)
                    .HasColumnName("CorpClient_AdvSent")
                    .HasColumnType("datetime");

                entity.Property(e => e.CorpClientEmail)
                    .IsRequired()
                    .HasColumnName("CorpClient_Email")
                    .HasMaxLength(128);

                entity.Property(e => e.CorpClientName)
                    .IsRequired()
                    .HasColumnName("CorpClient_Name")
                    .HasMaxLength(128);

                entity.Property(e => e.CorpClientPhone)
                    .IsRequired()
                    .HasColumnName("CorpClient_Phone")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CountryAbrv)
                    .IsRequired()
                    .HasColumnName("Country_Abrv")
                    .HasMaxLength(8);

                entity.Property(e => e.CountryEnabled)
                    .IsRequired()
                    .HasColumnName("Country_Enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("Country_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.CountryNameMl)
                    .HasColumnName("Country_Name_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.CountryPostalCodeName)
                    .IsRequired()
                    .HasColumnName("Country_PostalCodeName")
                    .HasMaxLength(32);

                entity.Property(e => e.CountryPostalCodeNameMl)
                    .HasColumnName("Country_PostalCodeName_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.CountryPostalCodeNameRu)
                    .HasColumnName("Country_PostalCodeName_RU")
                    .HasMaxLength(32);

                entity.Property(e => e.CountryRank).HasColumnName("Country_Rank");

                entity.Property(e => e.CountryStateName)
                    .IsRequired()
                    .HasColumnName("Country_StateName")
                    .HasMaxLength(32);

                entity.Property(e => e.CountryStateNameMl)
                    .HasColumnName("Country_StateName_ML")
                    .HasMaxLength(32);

                entity.Property(e => e.CountryStateRequired).HasColumnName("Country_StateRequired");
            });

            modelBuilder.Entity<Dest>(entity =>
            {
                entity.HasIndex(e => e.DestCountry)
                    .HasName("AK_Dest_Country");

                entity.HasIndex(e => e.DestCountryMl)
                    .HasName("AK_Dest_Country_RU");

                entity.HasIndex(e => e.DestDest)
                    .HasName("AK_Dest_Dest");

                entity.HasIndex(e => e.DestDestMl)
                    .HasName("AK_Dest_Dest_RU");

                entity.HasIndex(e => e.DestZone)
                    .HasName("AK_Dest_Zone");

                entity.HasIndex(e => e.DestZoneMl)
                    .HasName("AK_Dest_Zone_RU");

                entity.HasIndex(e => e.HbdestId)
                    .HasName("IF1_Dest");

                entity.HasIndex(e => e.TtresortId)
                    .HasName("IF3_Dest");

                entity.Property(e => e.DestId)
                    .HasColumnName("Dest_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DestAdded)
                    .HasColumnName("Dest_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DestCapital).HasColumnName("Dest_Capital");

                entity.Property(e => e.DestCountry)
                    .IsRequired()
                    .HasColumnName("Dest_Country")
                    .HasMaxLength(64);

                entity.Property(e => e.DestCountryIso2)
                    .HasColumnName("Dest_Country_ISO2")
                    .HasMaxLength(2);

                entity.Property(e => e.DestCountryMl)
                    .HasColumnName("Dest_Country_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.DestCountryMl1)
                    .HasColumnName("Dest_Country_ML1")
                    .HasMaxLength(64);

                entity.Property(e => e.DestCountryMl2)
                    .HasColumnName("Dest_Country_ML2")
                    .HasMaxLength(64);

                entity.Property(e => e.DestCountrySl)
                    .HasColumnName("Dest_Country_SL")
                    .HasMaxLength(64);

                entity.Property(e => e.DestCountrySl1)
                    .HasColumnName("Dest_Country_SL1")
                    .HasMaxLength(64);

                entity.Property(e => e.DestCountrySl2)
                    .HasColumnName("Dest_Country_SL2")
                    .HasMaxLength(64);

                entity.Property(e => e.DestDest)
                    .HasColumnName("Dest_Dest")
                    .HasMaxLength(64);

                entity.Property(e => e.DestDestMl)
                    .HasColumnName("Dest_Dest_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.DestDestMl1)
                    .HasColumnName("Dest_Dest_ML1")
                    .HasMaxLength(64);

                entity.Property(e => e.DestDestMl2)
                    .HasColumnName("Dest_Dest_ML2")
                    .HasMaxLength(64);

                entity.Property(e => e.DestDestSl)
                    .HasColumnName("Dest_Dest_SL")
                    .HasMaxLength(64);

                entity.Property(e => e.DestDestSl1)
                    .HasColumnName("Dest_Dest_SL1")
                    .HasMaxLength(64);

                entity.Property(e => e.DestDestSl2)
                    .HasColumnName("Dest_Dest_SL2")
                    .HasMaxLength(64);

                entity.Property(e => e.DestFeatured).HasColumnName("Dest_Featured");

                entity.Property(e => e.DestFroogle).HasColumnName("Dest_Froogle");

                entity.Property(e => e.DestIsland).HasColumnName("Dest_Island");

                entity.Property(e => e.DestLatitude)
                    .HasColumnName("Dest_Latitude")
                    .HasMaxLength(32);

                entity.Property(e => e.DestLongitude)
                    .HasColumnName("Dest_Longitude")
                    .HasMaxLength(32);

                entity.Property(e => e.DestSearchType)
                    .HasColumnName("Dest_SearchType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DestText)
                    .HasColumnName("Dest_Text")
                    .HasColumnType("ntext");

                entity.Property(e => e.DestUpdated)
                    .HasColumnName("Dest_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DestViewed).HasColumnName("Dest_Viewed");

                entity.Property(e => e.DestZone)
                    .HasColumnName("Dest_Zone")
                    .HasMaxLength(64);

                entity.Property(e => e.DestZoneMl)
                    .HasColumnName("Dest_Zone_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.DestZoneMl1)
                    .HasColumnName("Dest_Zone_ML1")
                    .HasMaxLength(64);

                entity.Property(e => e.DestZoneMl2)
                    .HasColumnName("Dest_Zone_ML2")
                    .HasMaxLength(64);

                entity.Property(e => e.DestZoneSl)
                    .HasColumnName("Dest_Zone_SL")
                    .HasMaxLength(64);

                entity.Property(e => e.DestZoneSl1)
                    .HasColumnName("Dest_Zone_SL1")
                    .HasMaxLength(64);

                entity.Property(e => e.DestZoneSl2)
                    .HasColumnName("Dest_Zone_SL2")
                    .HasMaxLength(64);

                entity.Property(e => e.HbdestId)
                    .HasColumnName("HBDest_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IttourCountryId)
                    .HasColumnName("ITTour_CountryID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TtresortId)
                    .HasColumnName("TTResort_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Hbdest)
                    .WithMany(p => p.Dest)
                    .HasForeignKey(d => d.HbdestId)
                    .HasConstraintName("FK__Dest__HBDest_ID__34E8D562");

                entity.HasOne(d => d.Ttresort)
                    .WithMany(p => p.Dest)
                    .HasForeignKey(d => d.TtresortId)
                    .HasConstraintName("FK__Dest__TTResort_I__35DCF99B");
            });

            modelBuilder.Entity<Discuss>(entity =>
            {
                entity.Property(e => e.DiscussId)
                    .HasColumnName("Discuss_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DiscussAdded)
                    .HasColumnName("Discuss_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiscussAddedById)
                    .HasColumnName("Discuss_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DiscussArchived).HasColumnName("Discuss_Archived");

                entity.Property(e => e.DiscussCalculation)
                    .HasColumnName("Discuss_Calculation")
                    .HasMaxLength(32);

                entity.Property(e => e.DiscussComments)
                    .HasColumnName("Discuss_Comments")
                    .HasMaxLength(4000);

                entity.Property(e => e.DiscussDates)
                    .HasColumnName("Discuss_Dates")
                    .HasMaxLength(32);

                entity.Property(e => e.DiscussDestination)
                    .HasColumnName("Discuss_Destination")
                    .HasMaxLength(32);

                entity.Property(e => e.DiscussEmail)
                    .HasColumnName("Discuss_Email")
                    .HasMaxLength(256);

                entity.Property(e => e.DiscussName)
                    .IsRequired()
                    .HasColumnName("Discuss_Name")
                    .HasMaxLength(32);

                entity.Property(e => e.DiscussNotify)
                    .HasColumnName("Discuss_Notify")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiscussPhone)
                    .HasColumnName("Discuss_Phone")
                    .HasMaxLength(32);

                entity.Property(e => e.DiscussPhone2)
                    .HasColumnName("Discuss_Phone2")
                    .HasMaxLength(32);

                entity.Property(e => e.DiscussPhone3)
                    .HasColumnName("Discuss_Phone3")
                    .HasMaxLength(32);

                entity.Property(e => e.DiscussPhoneViberEnabled).HasColumnName("Discuss_PhoneViberEnabled");

                entity.Property(e => e.DiscussPhoneWhatsAppEnabled).HasColumnName("Discuss_PhoneWhatsAppEnabled");

                entity.Property(e => e.DiscussRequestId)
                    .HasColumnName("Discuss_RequestID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DiscussResidence)
                    .HasColumnName("Discuss_Residence")
                    .HasMaxLength(32);

                entity.Property(e => e.DiscussSkype)
                    .HasColumnName("Discuss_Skype")
                    .HasMaxLength(32);

                entity.Property(e => e.DiscussStatus)
                    .HasColumnName("Discuss_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DiscussSubStatus).HasColumnName("Discuss_SubStatus");

                entity.Property(e => e.DiscussTag)
                    .HasColumnName("Discuss_Tag")
                    .HasMaxLength(32);

                entity.Property(e => e.DiscussUpdated)
                    .HasColumnName("Discuss_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiscussUpdatedById).HasColumnName("Discuss_UpdatedByID");
            });

            modelBuilder.Entity<Doc>(entity =>
            {
                entity.HasIndex(e => e.AddedById)
                    .HasName("IF3_Doc");

                entity.HasIndex(e => e.RequestId)
                    .HasName("IF1_Doc");

                entity.Property(e => e.DocId)
                    .HasColumnName("Doc_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddedById)
                    .HasColumnName("AddedBy_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AgreementId)
                    .HasColumnName("Agreement_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DocAdded)
                    .HasColumnName("Doc_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocDoc)
                    .HasColumnName("Doc_Doc")
                    .HasMaxLength(16);

                entity.Property(e => e.DocDocAgreed)
                    .HasColumnName("Doc_DocAgreed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocDocAgreedHttp)
                    .HasColumnName("Doc_DocAgreedHTTP")
                    .HasColumnType("ntext");

                entity.Property(e => e.DocDocAgreedIp)
                    .HasColumnName("Doc_DocAgreedIP")
                    .HasMaxLength(32);

                entity.Property(e => e.DocFileSize)
                    .HasColumnName("Doc_FileSize")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DocGuid)
                    .HasColumnName("Doc_GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DocHtml)
                    .HasColumnName("Doc_HTML")
                    .HasColumnType("ntext");

                entity.Property(e => e.DocNote)
                    .HasColumnName("Doc_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.DocPath)
                    .HasColumnName("Doc_Path")
                    .HasMaxLength(256);

                entity.Property(e => e.DocPathType).HasColumnName("Doc_PathType");

                entity.Property(e => e.DocRank).HasColumnName("Doc_Rank");

                entity.Property(e => e.DocSent)
                    .HasColumnName("Doc_Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocSubject)
                    .HasColumnName("Doc_Subject")
                    .HasMaxLength(512);

                entity.Property(e => e.DocTags)
                    .HasColumnName("Doc_Tags")
                    .HasMaxLength(64);

                entity.Property(e => e.DocText)
                    .HasColumnName("Doc_Text")
                    .HasColumnType("ntext");

                entity.Property(e => e.DocTitle)
                    .IsRequired()
                    .HasColumnName("Doc_Title")
                    .HasMaxLength(256);

                entity.Property(e => e.DocType)
                    .HasColumnName("Doc_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RequestId)
                    .HasColumnName("Request_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.Doc)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Doc__AddedBy_ID__37C5420D");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Doc)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK__Doc__Request_ID__36D11DD4");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.EventId)
                    .HasColumnName("Event_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EventAdded)
                    .HasColumnName("Event_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EventClientIp)
                    .HasColumnName("Event_ClientIP")
                    .HasMaxLength(128);

                entity.Property(e => e.EventDescription)
                    .HasColumnName("Event_Description")
                    .HasMaxLength(512);

                entity.Property(e => e.EventNumber).HasColumnName("Event_Number");

                entity.Property(e => e.EventSource)
                    .HasColumnName("Event_Source")
                    .HasMaxLength(256);

                entity.Property(e => e.EventStatus)
                    .HasColumnName("Event_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EventType)
                    .HasColumnName("Event_Type")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Excursion>(entity =>
            {
                entity.HasIndex(e => e.DestId)
                    .HasName("IF2_Excursion");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IF1_Excursion");

                entity.Property(e => e.ExcursionId)
                    .HasColumnName("Excursion_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DestId)
                    .HasColumnName("Dest_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExcursionAdded)
                    .HasColumnName("Excursion_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExcursionAddedById)
                    .HasColumnName("Excursion_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExcursionCurrency)
                    .IsRequired()
                    .HasColumnName("Excursion_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.ExcursionHtml)
                    .HasColumnName("Excursion_HTML")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExcursionHtmlml)
                    .HasColumnName("Excursion_HTMLML")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExcursionImg1)
                    .HasColumnName("Excursion_Img1")
                    .HasMaxLength(256);

                entity.Property(e => e.ExcursionKeywords)
                    .HasColumnName("Excursion_Keywords")
                    .HasMaxLength(1024);

                entity.Property(e => e.ExcursionKeywordsMl)
                    .HasColumnName("Excursion_KeywordsML")
                    .HasMaxLength(1024);

                entity.Property(e => e.ExcursionPrice)
                    .HasColumnName("Excursion_Price")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.ExcursionPriceChd)
                    .HasColumnName("Excursion_PriceCHD")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.ExcursionPublished)
                    .HasColumnName("Excursion_Published")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExcursionRank).HasColumnName("Excursion_Rank");

                entity.Property(e => e.ExcursionSeourl)
                    .HasColumnName("Excursion_SEOURL")
                    .HasMaxLength(256);

                entity.Property(e => e.ExcursionSeourlml)
                    .HasColumnName("Excursion_SEOURLML")
                    .HasMaxLength(256);

                entity.Property(e => e.ExcursionStatus)
                    .HasColumnName("Excursion_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ExcursionText)
                    .HasColumnName("Excursion_Text")
                    .HasMaxLength(1024);

                entity.Property(e => e.ExcursionTextInit)
                    .HasColumnName("Excursion_TextInit")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExcursionTextInitMl)
                    .HasColumnName("Excursion_TextInitML")
                    .HasColumnType("ntext");

                entity.Property(e => e.ExcursionTextMl)
                    .HasColumnName("Excursion_TextML")
                    .HasMaxLength(1024);

                entity.Property(e => e.ExcursionTitle)
                    .IsRequired()
                    .HasColumnName("Excursion_Title")
                    .HasMaxLength(512);

                entity.Property(e => e.ExcursionTitleMl)
                    .HasColumnName("Excursion_TitleML")
                    .HasMaxLength(512);

                entity.Property(e => e.ExcursionUpdated)
                    .HasColumnName("Excursion_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExcursionUpdatedById).HasColumnName("Excursion_UpdatedByID");

                entity.Property(e => e.ExcursionViewed).HasColumnName("Excursion_Viewed");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("Supplier_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Dest)
                    .WithMany(p => p.Excursion)
                    .HasForeignKey(d => d.DestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Excursion__Dest___39AD8A7F");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Excursion)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Excursion__Suppl__38B96646");
            });

            modelBuilder.Entity<Extra>(entity =>
            {
                entity.Property(e => e.ExtraId)
                    .HasColumnName("Extra_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ExtraAdded)
                    .HasColumnName("Extra_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExtraAddedById)
                    .HasColumnName("Extra_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExtraCurrency)
                    .IsRequired()
                    .HasColumnName("Extra_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.ExtraPrice)
                    .HasColumnName("Extra_Price")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.ExtraPriceChd)
                    .HasColumnName("Extra_PriceCHD")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.ExtraRank).HasColumnName("Extra_Rank");

                entity.Property(e => e.ExtraStatus).HasColumnName("Extra_Status");

                entity.Property(e => e.ExtraTitle)
                    .IsRequired()
                    .HasColumnName("Extra_Title")
                    .HasMaxLength(512);

                entity.Property(e => e.ExtraTitleMl)
                    .HasColumnName("Extra_TitleML")
                    .HasMaxLength(512);

                entity.Property(e => e.ExtraType).HasColumnName("Extra_Type");

                entity.Property(e => e.ExtraUpdated)
                    .HasColumnName("Extra_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExtraUpdatedById)
                    .HasColumnName("Extra_UpdatedByID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.HasIndex(e => e.AgencyId)
                    .HasName("IF3_Flight");

                entity.HasIndex(e => e.BookingId)
                    .HasName("IF4_Flight");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IF1_Flight");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IF2_Flight");

                entity.Property(e => e.FlightId)
                    .HasColumnName("Flight_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AgencyId)
                    .HasColumnName("Agency_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BookingId)
                    .HasColumnName("Booking_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FlightAdded)
                    .HasColumnName("Flight_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlightAdults)
                    .HasColumnName("Flight_Adults")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FlightAgencyCommision)
                    .HasColumnName("Flight_AgencyCommision")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.FlightAgencyPaidDate)
                    .HasColumnName("Flight_AgencyPaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightAgencyRefNo)
                    .HasColumnName("Flight_AgencyRefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.FlightArrAirport)
                    .IsRequired()
                    .HasColumnName("Flight_ArrAirport")
                    .HasMaxLength(32);

                entity.Property(e => e.FlightArrAirportCode)
                    .IsRequired()
                    .HasColumnName("Flight_ArrAirportCode")
                    .HasMaxLength(8);

                entity.Property(e => e.FlightArrDate)
                    .HasColumnName("Flight_ArrDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightArrTime)
                    .IsRequired()
                    .HasColumnName("Flight_ArrTime")
                    .HasMaxLength(16);

                entity.Property(e => e.FlightCancellationPolicy)
                    .HasColumnName("Flight_CancellationPolicy")
                    .HasColumnType("ntext");

                entity.Property(e => e.FlightChildAges)
                    .HasColumnName("Flight_ChildAges")
                    .HasMaxLength(32);

                entity.Property(e => e.FlightChildren).HasColumnName("Flight_Children");

                entity.Property(e => e.FlightCurrency)
                    .IsRequired()
                    .HasColumnName("Flight_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.FlightDepAirport)
                    .IsRequired()
                    .HasColumnName("Flight_DepAirport")
                    .HasMaxLength(32);

                entity.Property(e => e.FlightDepAirportCode)
                    .IsRequired()
                    .HasColumnName("Flight_DepAirportCode")
                    .HasMaxLength(8);

                entity.Property(e => e.FlightDepDate)
                    .HasColumnName("Flight_DepDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightDepTime)
                    .IsRequired()
                    .HasColumnName("Flight_DepTime")
                    .HasMaxLength(16);

                entity.Property(e => e.FlightImportantInfo)
                    .HasColumnName("Flight_ImportantInfo")
                    .HasColumnType("ntext");

                entity.Property(e => e.FlightInfants).HasColumnName("Flight_Infants");

                entity.Property(e => e.FlightNetCost)
                    .HasColumnName("Flight_NetCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.FlightNo)
                    .IsRequired()
                    .HasColumnName("Flight_No")
                    .HasMaxLength(16);

                entity.Property(e => e.FlightNote)
                    .HasColumnName("Flight_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.FlightOrigin)
                    .HasColumnName("Flight_Origin")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FlightPaidDate)
                    .HasColumnName("Flight_PaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightPwd)
                    .IsRequired()
                    .HasColumnName("Flight_Pwd")
                    .HasMaxLength(32);

                entity.Property(e => e.FlightRefNo)
                    .IsRequired()
                    .HasColumnName("Flight_RefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.FlightRetArrAirport)
                    .HasColumnName("Flight_Ret_ArrAirport")
                    .HasMaxLength(32);

                entity.Property(e => e.FlightRetArrAirportCode)
                    .HasColumnName("Flight_Ret_ArrAirportCode")
                    .HasMaxLength(8);

                entity.Property(e => e.FlightRetArrDate)
                    .HasColumnName("Flight_Ret_ArrDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightRetArrTime)
                    .HasColumnName("Flight_Ret_ArrTime")
                    .HasMaxLength(16);

                entity.Property(e => e.FlightRetDepAirport)
                    .HasColumnName("Flight_Ret_DepAirport")
                    .HasMaxLength(32);

                entity.Property(e => e.FlightRetDepAirportCode)
                    .HasColumnName("Flight_Ret_DepAirportCode")
                    .HasMaxLength(8);

                entity.Property(e => e.FlightRetDepDate)
                    .HasColumnName("Flight_Ret_DepDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightRetDepTime)
                    .HasColumnName("Flight_Ret_DepTime")
                    .HasMaxLength(16);

                entity.Property(e => e.FlightRetNo)
                    .HasColumnName("Flight_Ret_No")
                    .HasMaxLength(16);

                entity.Property(e => e.FlightSpecialRequest)
                    .HasColumnName("Flight_SpecialRequest")
                    .HasColumnType("ntext");

                entity.Property(e => e.FlightStatus)
                    .HasColumnName("Flight_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FlightSupplierPaidDate)
                    .HasColumnName("Flight_SupplierPaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightSupplierRefNo)
                    .HasColumnName("Flight_SupplierRefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.FlightTotalCost)
                    .HasColumnName("Flight_TotalCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.FlightTotalPaid)
                    .HasColumnName("Flight_TotalPaid")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.PersonId)
                    .HasColumnName("Person_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("Supplier_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.FlightAgency)
                    .HasForeignKey(d => d.AgencyId)
                    .HasConstraintName("FK__Flight__Agency_I__3B95D2F1");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.Flight)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK__Flight__Booking___3AA1AEB8");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Flight)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Flight__Person_I__3D7E1B63");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.FlightSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK__Flight__Supplier__3C89F72A");
            });

            modelBuilder.Entity<FlightCost>(entity =>
            {
                entity.HasIndex(e => e.AirlineId)
                    .HasName("IF5_FlightCost");

                entity.HasIndex(e => e.ConAirportId)
                    .HasName("IF4_FlightCost");

                entity.HasIndex(e => e.FromAirportId)
                    .HasName("IF1_FlightCost");

                entity.HasIndex(e => e.ToAirportId)
                    .HasName("IF2_FlightCost");

                entity.Property(e => e.FlightCostId)
                    .HasColumnName("FlightCost_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AirlineId)
                    .HasColumnName("Airline_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ConAirportId)
                    .HasColumnName("ConAirport_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FlightCostAdded)
                    .HasColumnName("FlightCost_Added")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightCostCurrency)
                    .IsRequired()
                    .HasColumnName("FlightCost_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.FlightCostFeatured)
                    .HasColumnName("FlightCost_Featured")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FlightCostOwpriceFrom)
                    .HasColumnName("FlightCost_OWPriceFrom")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.FlightCostOwpriceFromOld)
                    .HasColumnName("FlightCost_OWPriceFrom_old")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.FlightCostPublished)
                    .HasColumnName("FlightCost_Published")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightCostRtpriceFrom)
                    .HasColumnName("FlightCost_RTPriceFrom")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.FlightCostRtpriceFromOld)
                    .HasColumnName("FlightCost_RTPriceFrom_old")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.FlightCostStatus)
                    .HasColumnName("FlightCost_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FlightCostText)
                    .HasColumnName("FlightCost_Text")
                    .HasMaxLength(256);

                entity.Property(e => e.FlightCostTmp)
                    .HasColumnName("FlightCost_Tmp")
                    .HasMaxLength(256);

                entity.Property(e => e.FlightCostType)
                    .HasColumnName("FlightCost_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FromAirportId)
                    .HasColumnName("FromAirport_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ToAirportId)
                    .HasColumnName("ToAirport_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Airline)
                    .WithMany(p => p.FlightCost)
                    .HasForeignKey(d => d.AirlineId)
                    .HasConstraintName("FK__FlightCos__Airli__414EAC47");

                entity.HasOne(d => d.ConAirport)
                    .WithMany(p => p.FlightCostConAirport)
                    .HasForeignKey(d => d.ConAirportId)
                    .HasConstraintName("FK__FlightCos__ConAi__405A880E");

                entity.HasOne(d => d.FromAirport)
                    .WithMany(p => p.FlightCostFromAirport)
                    .HasForeignKey(d => d.FromAirportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FlightCos__FromA__3E723F9C");

                entity.HasOne(d => d.ToAirport)
                    .WithMany(p => p.FlightCostToAirport)
                    .HasForeignKey(d => d.ToAirportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FlightCos__ToAir__3F6663D5");
            });

            modelBuilder.Entity<FlightDay>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FlightDayAdded)
                    .HasColumnName("FlightDay_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlightDayCurrency)
                    .HasColumnName("FlightDay_Currency")
                    .HasMaxLength(3);

                entity.Property(e => e.FlightDayDate)
                    .HasColumnName("FlightDay_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightDayDay).HasColumnName("FlightDay_Day");

                entity.Property(e => e.FlightDayId)
                    .HasColumnName("FlightDay_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FlightDayPrice1011).HasColumnName("FlightDay_Price1011");

                entity.Property(e => e.FlightDayPrice14).HasColumnName("FlightDay_Price14");

                entity.Property(e => e.FlightDayPrice21).HasColumnName("FlightDay_Price21");

                entity.Property(e => e.FlightDayPrice28).HasColumnName("FlightDay_Price28");

                entity.Property(e => e.FlightDayPrice7).HasColumnName("FlightDay_Price7");

                entity.Property(e => e.FlightDayUpdated)
                    .HasColumnName("FlightDay_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightSchedId)
                    .HasColumnName("FlightSched_ID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<FlightSched>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FlightSchedAdded)
                    .HasColumnName("FlightSched_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlightSchedDay)
                    .HasColumnName("FlightSched_Day")
                    .HasMaxLength(32);

                entity.Property(e => e.FlightSchedId)
                    .HasColumnName("FlightSched_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FlightSchedNumber)
                    .HasColumnName("FlightSched_Number")
                    .HasMaxLength(32);

                entity.Property(e => e.FlightSchedPeriod)
                    .HasColumnName("FlightSched_Period")
                    .HasMaxLength(256);

                entity.Property(e => e.FlightSchedRoute)
                    .HasColumnName("FlightSched_Route")
                    .HasMaxLength(32);

                entity.Property(e => e.FlightSchedTag)
                    .HasColumnName("FlightSched_Tag")
                    .HasMaxLength(32);

                entity.Property(e => e.FlightSchedTime)
                    .HasColumnName("FlightSched_Time")
                    .HasMaxLength(32);

                entity.Property(e => e.FlightSchedUpdated)
                    .HasColumnName("FlightSched_Updated")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<GroupItem>(entity =>
            {
                entity.Property(e => e.GroupItemId)
                    .HasColumnName("GroupItem_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GroupItemAdded)
                    .HasColumnName("GroupItem_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupItemAddedById)
                    .HasColumnName("GroupItem_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GroupItemCommision1)
                    .HasColumnName("GroupItem_Commision1")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.GroupItemCommision2)
                    .HasColumnName("GroupItem_Commision2")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.GroupItemCommision3)
                    .HasColumnName("GroupItem_Commision3")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.GroupItemCommision4)
                    .HasColumnName("GroupItem_Commision4")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.GroupItemName)
                    .IsRequired()
                    .HasColumnName("GroupItem_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.GroupItemType).HasColumnName("GroupItem_Type");

                entity.Property(e => e.GroupItemUpdated)
                    .HasColumnName("GroupItem_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.GroupItemUpdatedById)
                    .HasColumnName("GroupItem_UpdatedByID")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<GroupMember>(entity =>
            {
                entity.HasIndex(e => e.CompanyId)
                    .HasName("IF1_GroupMember");

                entity.HasIndex(e => e.GroupItemId)
                    .HasName("IF3_GroupMember");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IF2_GroupMember");

                entity.Property(e => e.GroupMemberId)
                    .HasColumnName("GroupMember_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GroupItemId)
                    .HasColumnName("GroupItem_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GroupMemberAdded)
                    .HasColumnName("GroupMember_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupMemberAddedById)
                    .HasColumnName("GroupMember_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PersonId)
                    .HasColumnName("Person_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.GroupMember)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__GroupMemb__Compa__4242D080");

                entity.HasOne(d => d.GroupItem)
                    .WithMany(p => p.GroupMember)
                    .HasForeignKey(d => d.GroupItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GroupMemb__Group__442B18F2");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.GroupMember)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__GroupMemb__Perso__4336F4B9");
            });

            modelBuilder.Entity<Hbcsv>(entity =>
            {
                entity.ToTable("HBCSV");

                entity.Property(e => e.HbcsvId)
                    .HasColumnName("HBCSV_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HbcsvCount).HasColumnName("HBCSV_Count");

                entity.Property(e => e.HbcsvDestCode)
                    .IsRequired()
                    .HasColumnName("HBCSV_DestCode")
                    .HasMaxLength(3);

                entity.Property(e => e.HbcsvHotelCode)
                    .HasColumnName("HBCSV_HotelCode")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HbcsvZoneCode)
                    .HasColumnName("HBCSV_ZoneCode")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Hbdest>(entity =>
            {
                entity.ToTable("HBDest");

                entity.HasIndex(e => e.HbdestCountryCode)
                    .HasName("AK_HBDest_CountryCode");

                entity.HasIndex(e => e.HbdestDestCode)
                    .HasName("AK_HBDest_DestCode");

                entity.HasIndex(e => e.HbdestZoneCode)
                    .HasName("AK_HBDest_ZoneCode");

                entity.Property(e => e.HbdestId)
                    .HasColumnName("HBDest_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HbdestAdded)
                    .HasColumnName("HBDest_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HbdestCountry)
                    .IsRequired()
                    .HasColumnName("HBDest_Country")
                    .HasMaxLength(64);

                entity.Property(e => e.HbdestCountryCode)
                    .IsRequired()
                    .HasColumnName("HBDest_CountryCode")
                    .HasMaxLength(2);

                entity.Property(e => e.HbdestCountryMl)
                    .HasColumnName("HBDest_Country_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.HbdestDest)
                    .HasColumnName("HBDest_Dest")
                    .HasMaxLength(64);

                entity.Property(e => e.HbdestDestCode)
                    .HasColumnName("HBDest_DestCode")
                    .HasMaxLength(3);

                entity.Property(e => e.HbdestDestMl)
                    .HasColumnName("HBDest_Dest_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.HbdestLatitude)
                    .HasColumnName("HBDest_Latitude")
                    .HasMaxLength(32);

                entity.Property(e => e.HbdestLongitude)
                    .HasColumnName("HBDest_Longitude")
                    .HasMaxLength(32);

                entity.Property(e => e.HbdestUpdated)
                    .HasColumnName("HBDest_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.HbdestZone)
                    .HasColumnName("HBDest_Zone")
                    .HasMaxLength(64);

                entity.Property(e => e.HbdestZoneCode).HasColumnName("HBDest_ZoneCode");

                entity.Property(e => e.HbdestZoneMl)
                    .HasColumnName("HBDest_Zone_ML")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Hbhotel>(entity =>
            {
                entity.ToTable("HBHotel");

                entity.HasIndex(e => e.HbdestId)
                    .HasName("IF1_HBHotel");

                entity.HasIndex(e => e.HbhotelCode)
                    .HasName("AK_HBHotel_Code");

                entity.Property(e => e.HbhotelId)
                    .HasColumnName("HBHotel_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HbdestId)
                    .HasColumnName("HBDest_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HbhotelAdded)
                    .HasColumnName("HBHotel_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HbhotelAddress)
                    .HasColumnName("HBHotel_Address")
                    .HasMaxLength(512);

                entity.Property(e => e.HbhotelCat)
                    .IsRequired()
                    .HasColumnName("HBHotel_Cat")
                    .HasMaxLength(32);

                entity.Property(e => e.HbhotelCode)
                    .HasColumnName("HBHotel_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HbhotelDesc)
                    .HasColumnName("HBHotel_Desc")
                    .HasColumnType("ntext");

                entity.Property(e => e.HbhotelDescMl)
                    .HasColumnName("HBHotel_Desc_ML")
                    .HasColumnType("ntext");

                entity.Property(e => e.HbhotelEmail)
                    .HasColumnName("HBHotel_Email")
                    .HasMaxLength(128);

                entity.Property(e => e.HbhotelFax)
                    .HasColumnName("HBHotel_Fax")
                    .HasMaxLength(64);

                entity.Property(e => e.HbhotelFeatured).HasColumnName("HBHotel_Featured");

                entity.Property(e => e.HbhotelImg1)
                    .HasColumnName("HBHotel_Img1")
                    .HasMaxLength(256);

                entity.Property(e => e.HbhotelImg1Local)
                    .HasColumnName("HBHotel_Img1Local")
                    .HasMaxLength(256);

                entity.Property(e => e.HbhotelImg1Type)
                    .HasColumnName("HBHotel_Img1Type")
                    .HasMaxLength(8);

                entity.Property(e => e.HbhotelImg2)
                    .HasColumnName("HBHotel_Img2")
                    .HasMaxLength(256);

                entity.Property(e => e.HbhotelImg2Local)
                    .HasColumnName("HBHotel_Img2Local")
                    .HasMaxLength(256);

                entity.Property(e => e.HbhotelImg2Type)
                    .HasColumnName("HBHotel_Img2Type")
                    .HasMaxLength(8);

                entity.Property(e => e.HbhotelImg3)
                    .HasColumnName("HBHotel_Img3")
                    .HasMaxLength(256);

                entity.Property(e => e.HbhotelImg3Local)
                    .HasColumnName("HBHotel_Img3Local")
                    .HasMaxLength(256);

                entity.Property(e => e.HbhotelImg3Type)
                    .HasColumnName("HBHotel_Img3Type")
                    .HasMaxLength(8);

                entity.Property(e => e.HbhotelKeys).HasColumnName("HBHotel_Keys");

                entity.Property(e => e.HbhotelLatitude)
                    .HasColumnName("HBHotel_Latitude")
                    .HasMaxLength(64);

                entity.Property(e => e.HbhotelLongitude)
                    .HasColumnName("HBHotel_Longitude")
                    .HasMaxLength(64);

                entity.Property(e => e.HbhotelName)
                    .IsRequired()
                    .HasColumnName("HBHotel_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.HbhotelNameMl)
                    .HasColumnName("HBHotel_Name_ML")
                    .HasMaxLength(128);

                entity.Property(e => e.HbhotelPhone)
                    .HasColumnName("HBHotel_Phone")
                    .HasMaxLength(64);

                entity.Property(e => e.HbhotelPromt).HasColumnName("HBHotel_Promt");

                entity.Property(e => e.HbhotelStars).HasColumnName("HBHotel_Stars");

                entity.Property(e => e.HbhotelStarsName)
                    .HasColumnName("HBHotel_StarsName")
                    .HasMaxLength(64);

                entity.Property(e => e.HbhotelStarsPlus).HasColumnName("HBHotel_StarsPlus");

                entity.Property(e => e.HbhotelUpdated)
                    .HasColumnName("HBHotel_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.HbhotelUrl)
                    .HasColumnName("HBHotel_URL")
                    .HasMaxLength(256);

                entity.HasOne(d => d.Hbdest)
                    .WithMany(p => p.Hbhotel)
                    .HasForeignKey(d => d.HbdestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HBHotel__HBDest___451F3D2B");
            });

            modelBuilder.Entity<HbhotelDet>(entity =>
            {
                entity.ToTable("HBHotelDet");

                entity.HasIndex(e => e.HbhotelFacId)
                    .HasName("IF1_HBHotelDet");

                entity.HasIndex(e => e.HbhotelId)
                    .HasName("IF2_HBHotelDet");

                entity.Property(e => e.HbhotelDetId)
                    .HasColumnName("HBHotelDet_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HbhotelDetFee).HasColumnName("HBHotelDet_Fee");

                entity.Property(e => e.HbhotelDetNumber).HasColumnName("HBHotelDet_Number");

                entity.Property(e => e.HbhotelFacId)
                    .HasColumnName("HBHotelFac_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HbhotelId)
                    .HasColumnName("HBHotel_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.HbhotelFac)
                    .WithMany(p => p.HbhotelDet)
                    .HasForeignKey(d => d.HbhotelFacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HBHotelDe__HBHot__4707859D");

                entity.HasOne(d => d.Hbhotel)
                    .WithMany(p => p.HbhotelDet)
                    .HasForeignKey(d => d.HbhotelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HBHotelDe__HBHot__46136164");
            });

            modelBuilder.Entity<HbhotelFac>(entity =>
            {
                entity.ToTable("HBHotelFac");

                entity.Property(e => e.HbhotelFacId)
                    .HasColumnName("HBHotelFac_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HbhotelFacAdded)
                    .HasColumnName("HBHotelFac_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HbhotelFacName)
                    .IsRequired()
                    .HasColumnName("HBHotelFac_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.HbhotelFacNameMl)
                    .HasColumnName("HBHotelFac_Name_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.HbhotelFacType).HasColumnName("HBHotelFac_Type");
            });

            modelBuilder.Entity<Hoohotel>(entity =>
            {
                entity.ToTable("HOOHotel");

                entity.Property(e => e.HoohotelId)
                    .HasColumnName("HOOHotel_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HoohotelAdded)
                    .HasColumnName("HOOHotel_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HoohotelCategoryCode).HasColumnName("HOOHotel_CategoryCode");

                entity.Property(e => e.HoohotelCode)
                    .HasColumnName("HOOHotel_Code")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HoohotelDestCode)
                    .HasColumnName("HOOHotel_DestCode")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HoohotelName)
                    .IsRequired()
                    .HasColumnName("HOOHotel_Name")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<HotOffer>(entity =>
            {
                entity.Property(e => e.HotOfferId)
                    .HasColumnName("HotOffer_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HotOfferAdded)
                    .HasColumnName("HotOffer_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HotOfferHtml)
                    .IsRequired()
                    .HasColumnName("HotOffer_HTML")
                    .HasColumnType("ntext");

                entity.Property(e => e.HotOfferPublished)
                    .HasColumnName("HotOffer_Published")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HotOfferStatus)
                    .HasColumnName("HotOffer_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HotOfferText)
                    .IsRequired()
                    .HasColumnName("HotOffer_Text")
                    .HasColumnType("ntext");

                entity.Property(e => e.HotOfferTitle)
                    .IsRequired()
                    .HasColumnName("HotOffer_Title")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasIndex(e => e.DestId)
                    .HasName("IF2_Hotel");

                entity.HasIndex(e => e.HbhotelId)
                    .HasName("IF1_Hotel");

                entity.HasIndex(e => e.HoohotelId)
                    .HasName("IF5_Hotel");

                entity.HasIndex(e => e.OwnhotelId)
                    .HasName("IF3_Hotel");

                entity.HasIndex(e => e.TthotelId)
                    .HasName("IF4_Hotel");

                entity.Property(e => e.HotelId)
                    .HasColumnName("Hotel_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DestId)
                    .HasColumnName("Dest_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HbhotelId)
                    .HasColumnName("HBHotel_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Hbinfo).HasColumnName("HBInfo");

                entity.Property(e => e.HoohotelId)
                    .HasColumnName("HOOHotel_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HotelAdded)
                    .HasColumnName("Hotel_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HotelAddress)
                    .HasColumnName("Hotel_Address")
                    .HasMaxLength(256);

                entity.Property(e => e.HotelDesc)
                    .HasColumnName("Hotel_Desc")
                    .HasColumnType("ntext");

                entity.Property(e => e.HotelDesc1)
                    .HasColumnName("Hotel_Desc1")
                    .HasColumnType("ntext");

                entity.Property(e => e.HotelDesc1Ml)
                    .HasColumnName("Hotel_Desc1_ML")
                    .HasColumnType("ntext");

                entity.Property(e => e.HotelDescMl)
                    .HasColumnName("Hotel_Desc_ML")
                    .HasColumnType("ntext");

                entity.Property(e => e.HotelFeatured).HasColumnName("Hotel_Featured");

                entity.Property(e => e.HotelFix).HasColumnName("Hotel_Fix");

                entity.Property(e => e.HotelHtml)
                    .HasColumnName("Hotel_HTML")
                    .HasColumnType("ntext");

                entity.Property(e => e.HotelHtmlorig)
                    .HasColumnName("Hotel_HTMLOrig")
                    .HasColumnType("ntext");

                entity.Property(e => e.HotelHtmlorig2)
                    .HasColumnName("Hotel_HTMLOrig2")
                    .HasColumnType("ntext");

                entity.Property(e => e.HotelImg1)
                    .HasColumnName("Hotel_Img1")
                    .HasMaxLength(256);

                entity.Property(e => e.HotelImg1Local)
                    .HasColumnName("Hotel_Img1Local")
                    .HasMaxLength(256);

                entity.Property(e => e.HotelImgs)
                    .HasColumnName("Hotel_Imgs")
                    .HasColumnType("ntext");

                entity.Property(e => e.HotelImgs2)
                    .HasColumnName("Hotel_Imgs2")
                    .HasColumnType("ntext");

                entity.Property(e => e.HotelIncoming)
                    .HasColumnName("Hotel_Incoming")
                    .HasMaxLength(32);

                entity.Property(e => e.HotelIncoming2)
                    .HasColumnName("Hotel_Incoming2")
                    .HasMaxLength(32);

                entity.Property(e => e.HotelKeys).HasColumnName("Hotel_Keys");

                entity.Property(e => e.HotelLatitude)
                    .HasColumnName("Hotel_Latitude")
                    .HasMaxLength(64);

                entity.Property(e => e.HotelLongitude)
                    .HasColumnName("Hotel_Longitude")
                    .HasMaxLength(64);

                entity.Property(e => e.HotelName)
                    .IsRequired()
                    .HasColumnName("Hotel_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.HotelNameMl)
                    .HasColumnName("Hotel_Name_ML")
                    .HasMaxLength(128);

                entity.Property(e => e.HotelPriceCurrency)
                    .HasColumnName("Hotel_PriceCurrency")
                    .HasMaxLength(8);

                entity.Property(e => e.HotelPriceDetails)
                    .HasColumnName("Hotel_PriceDetails")
                    .HasMaxLength(32);

                entity.Property(e => e.HotelPriceFrom)
                    .HasColumnName("Hotel_PriceFrom")
                    .HasColumnType("money");

                entity.Property(e => e.HotelPromt).HasColumnName("Hotel_Promt");

                entity.Property(e => e.HotelRating)
                    .HasColumnName("Hotel_Rating")
                    .HasColumnType("numeric(14, 2)");

                entity.Property(e => e.HotelRatingQty).HasColumnName("Hotel_RatingQty");

                entity.Property(e => e.HotelStars).HasColumnName("Hotel_Stars");

                entity.Property(e => e.HotelStarsName)
                    .HasColumnName("Hotel_StarsName")
                    .HasMaxLength(64);

                entity.Property(e => e.HotelStarsPlus).HasColumnName("Hotel_StarsPlus");

                entity.Property(e => e.HotelType)
                    .HasColumnName("Hotel_Type")
                    .HasMaxLength(32);

                entity.Property(e => e.HotelTypeMl)
                    .HasColumnName("Hotel_Type_ML")
                    .HasMaxLength(32);

                entity.Property(e => e.HotelUpdated)
                    .HasColumnName("Hotel_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.HotelViewed).HasColumnName("Hotel_Viewed");

                entity.Property(e => e.OwnhotelId)
                    .HasColumnName("OWNHotel_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TthotelId)
                    .HasColumnName("TTHotel_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Dest)
                    .WithMany(p => p.Hotel)
                    .HasForeignKey(d => d.DestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Hotel__Dest_ID__4AD81681");

                entity.HasOne(d => d.Hbhotel)
                    .WithMany(p => p.Hotel)
                    .HasForeignKey(d => d.HbhotelId)
                    .HasConstraintName("FK__Hotel__HBHotel_I__4BCC3ABA");

                entity.HasOne(d => d.Hoohotel)
                    .WithMany(p => p.Hotel)
                    .HasForeignKey(d => d.HoohotelId)
                    .HasConstraintName("FK__Hotel__HOOHotel___48EFCE0F");

                entity.HasOne(d => d.Ownhotel)
                    .WithMany(p => p.Hotel)
                    .HasForeignKey(d => d.OwnhotelId)
                    .HasConstraintName("FK__Hotel__OWNHotel___47FBA9D6");

                entity.HasOne(d => d.Tthotel)
                    .WithMany(p => p.Hotel)
                    .HasForeignKey(d => d.TthotelId)
                    .HasConstraintName("FK__Hotel__TTHotel_I__49E3F248");
            });

            modelBuilder.Entity<HotelImage>(entity =>
            {
                entity.HasIndex(e => e.HotelId)
                    .HasName("IF1_HotelImage");

                entity.Property(e => e.HotelImageId)
                    .HasColumnName("HotelImage_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HotelId)
                    .HasColumnName("Hotel_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.HotelImageAdded)
                    .HasColumnName("HotelImage_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HotelImageEnabled).HasColumnName("HotelImage_Enabled");

                entity.Property(e => e.HotelImageTitle)
                    .HasColumnName("HotelImage_Title")
                    .HasMaxLength(256);

                entity.Property(e => e.HotelImageTitleMl)
                    .HasColumnName("HotelImage_Title_ML")
                    .HasMaxLength(256);

                entity.Property(e => e.HotelImageUrl)
                    .HasColumnName("HotelImage_URL")
                    .HasMaxLength(512);

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.HotelImage)
                    .HasForeignKey(d => d.HotelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HotelImag__Hotel__4CC05EF3");
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.HasIndex(e => e.AgencyId)
                    .HasName("IF3_Insurance");

                entity.HasIndex(e => e.BookingId)
                    .HasName("IF4_Insurance");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IF1_Insurance");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IF2_Insurance");

                entity.Property(e => e.InsuranceId)
                    .HasColumnName("Insurance_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AgencyId)
                    .HasColumnName("Agency_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BookingId)
                    .HasColumnName("Booking_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InsuranceAdded)
                    .HasColumnName("Insurance_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsuranceAdults)
                    .HasColumnName("Insurance_Adults")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.InsuranceAgencyCommision)
                    .HasColumnName("Insurance_AgencyCommision")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.InsuranceAgencyPaidDate)
                    .HasColumnName("Insurance_AgencyPaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsuranceAgencyRefNo)
                    .HasColumnName("Insurance_AgencyRefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.InsuranceCancellationPolicy)
                    .HasColumnName("Insurance_CancellationPolicy")
                    .HasColumnType("ntext");

                entity.Property(e => e.InsuranceChildAges)
                    .HasColumnName("Insurance_ChildAges")
                    .HasMaxLength(32);

                entity.Property(e => e.InsuranceChildren).HasColumnName("Insurance_Children");

                entity.Property(e => e.InsuranceCurrency)
                    .IsRequired()
                    .HasColumnName("Insurance_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.InsuranceFromDate)
                    .HasColumnName("Insurance_FromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsuranceImportantInfo)
                    .HasColumnName("Insurance_ImportantInfo")
                    .HasColumnType("ntext");

                entity.Property(e => e.InsuranceInfants).HasColumnName("Insurance_Infants");

                entity.Property(e => e.InsuranceNetCost)
                    .HasColumnName("Insurance_NetCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.InsuranceNote)
                    .HasColumnName("Insurance_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.InsuranceOrigin)
                    .HasColumnName("Insurance_Origin")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.InsurancePaidDate)
                    .HasColumnName("Insurance_PaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsurancePolicyAmount)
                    .HasColumnName("Insurance_PolicyAmount")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.InsurancePolicyCurrency)
                    .IsRequired()
                    .HasColumnName("Insurance_PolicyCurrency")
                    .HasMaxLength(8);

                entity.Property(e => e.InsurancePolicyType)
                    .IsRequired()
                    .HasColumnName("Insurance_PolicyType")
                    .HasMaxLength(32);

                entity.Property(e => e.InsurancePwd)
                    .IsRequired()
                    .HasColumnName("Insurance_Pwd")
                    .HasMaxLength(32);

                entity.Property(e => e.InsuranceRefNo)
                    .IsRequired()
                    .HasColumnName("Insurance_RefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.InsuranceSpecialRequest)
                    .HasColumnName("Insurance_SpecialRequest")
                    .HasColumnType("ntext");

                entity.Property(e => e.InsuranceStatus)
                    .HasColumnName("Insurance_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.InsuranceSupplierPaidDate)
                    .HasColumnName("Insurance_SupplierPaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsuranceSupplierRefNo)
                    .HasColumnName("Insurance_SupplierRefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.InsuranceToDate)
                    .HasColumnName("Insurance_ToDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsuranceTotalCost)
                    .HasColumnName("Insurance_TotalCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.InsuranceTotalPaid)
                    .HasColumnName("Insurance_TotalPaid")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.PersonId)
                    .HasColumnName("Person_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("Supplier_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.InsuranceAgency)
                    .HasForeignKey(d => d.AgencyId)
                    .HasConstraintName("FK__Insurance__Agenc__4EA8A765");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.Insurance)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK__Insurance__Booki__4DB4832C");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Insurance)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Insurance__Perso__5090EFD7");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.InsuranceSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK__Insurance__Suppl__4F9CCB9E");
            });

            modelBuilder.Entity<Ipaddress>(entity =>
            {
                entity.ToTable("IPAddress");

                entity.Property(e => e.IpaddressId)
                    .HasColumnName("IPAddress_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IpaddressAdded)
                    .HasColumnName("IPAddress_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpaddressEnabled).HasColumnName("IPAddress_Enabled");

                entity.Property(e => e.IpaddressIp)
                    .IsRequired()
                    .HasColumnName("IPAddress_IP")
                    .HasMaxLength(64);

                entity.Property(e => e.IpaddressNote)
                    .HasColumnName("IPAddress_Note")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Keyword>(entity =>
            {
                entity.Property(e => e.KeywordId)
                    .HasColumnName("Keyword_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KeywordTag)
                    .IsRequired()
                    .HasColumnName("Keyword_Tag")
                    .HasMaxLength(32);

                entity.Property(e => e.KeywordText)
                    .IsRequired()
                    .HasColumnName("Keyword_Text")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Link>(entity =>
            {
                entity.Property(e => e.LinkId)
                    .HasColumnName("Link_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LinkBacklinkUrl)
                    .IsRequired()
                    .HasColumnName("Link_BacklinkURL")
                    .HasMaxLength(512);

                entity.Property(e => e.LinkCategory).HasColumnName("Link_Category");

                entity.Property(e => e.LinkContactEmail)
                    .IsRequired()
                    .HasColumnName("Link_ContactEmail")
                    .HasMaxLength(256);

                entity.Property(e => e.LinkContactName)
                    .IsRequired()
                    .HasColumnName("Link_ContactName")
                    .HasMaxLength(128);

                entity.Property(e => e.LinkContactPhone)
                    .HasColumnName("Link_ContactPhone")
                    .HasMaxLength(32);

                entity.Property(e => e.LinkCreated)
                    .HasColumnName("Link_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LinkDescription)
                    .HasColumnName("Link_Description")
                    .HasMaxLength(512);

                entity.Property(e => e.LinkNote)
                    .HasColumnName("Link_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.LinkPageNo).HasColumnName("Link_PageNo");

                entity.Property(e => e.LinkStatus).HasColumnName("Link_Status");

                entity.Property(e => e.LinkTitle)
                    .IsRequired()
                    .HasColumnName("Link_Title")
                    .HasMaxLength(256);

                entity.Property(e => e.LinkUrl)
                    .IsRequired()
                    .HasColumnName("Link_URL")
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<Markup>(entity =>
            {
                entity.Property(e => e.MarkupId)
                    .HasColumnName("Markup_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MarkupPercent)
                    .HasColumnName("Markup_Percent")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.MarkupPercentMin)
                    .HasColumnName("Markup_PercentMin")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.MarkupProvider)
                    .IsRequired()
                    .HasColumnName("Markup_Provider")
                    .HasMaxLength(4);

                entity.Property(e => e.MarkupUpdated)
                    .HasColumnName("Markup_Updated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasIndex(e => e.MessageNumber)
                    .HasName("AK_Message_Number");

                entity.HasIndex(e => e.MessageSenderCompanyId)
                    .HasName("IF2_Message");

                entity.HasIndex(e => e.MessageSenderId)
                    .HasName("IF1_Message");

                entity.Property(e => e.MessageId)
                    .HasColumnName("Message_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MessageCreated)
                    .HasColumnName("Message_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MessageDeadline)
                    .HasColumnName("Message_Deadline")
                    .HasColumnType("datetime");

                entity.Property(e => e.MessageModified)
                    .HasColumnName("Message_Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.MessageNumber)
                    .IsRequired()
                    .HasColumnName("Message_Number")
                    .HasMaxLength(32);

                entity.Property(e => e.MessagePriority)
                    .HasColumnName("Message_Priority")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MessageSender)
                    .IsRequired()
                    .HasColumnName("Message_Sender")
                    .HasMaxLength(128);

                entity.Property(e => e.MessageSenderCompany)
                    .IsRequired()
                    .HasColumnName("Message_SenderCompany")
                    .HasMaxLength(64);

                entity.Property(e => e.MessageSenderCompanyId)
                    .HasColumnName("Message_SenderCompany_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MessageSenderId)
                    .HasColumnName("Message_Sender_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MessageStatus)
                    .HasColumnName("Message_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MessageSubject)
                    .IsRequired()
                    .HasColumnName("Message_Subject")
                    .HasMaxLength(128);

                entity.HasOne(d => d.MessageSenderCompanyNavigation)
                    .WithMany(p => p.Message)
                    .HasForeignKey(d => d.MessageSenderCompanyId)
                    .HasConstraintName("FK__Message__Message__51851410");

                entity.HasOne(d => d.MessageSenderNavigation)
                    .WithMany(p => p.Message)
                    .HasForeignKey(d => d.MessageSenderId)
                    .HasConstraintName("FK__Message__Message__52793849");
            });

            modelBuilder.Entity<MessageBody>(entity =>
            {
                entity.HasIndex(e => e.MessageBodyMessageId)
                    .HasName("IF1_MessageBody");

                entity.HasIndex(e => e.MessageBodySenderCompanyId)
                    .HasName("IF3_MessageBody");

                entity.HasIndex(e => e.MessageBodySenderId)
                    .HasName("IF2_MessageBody");

                entity.Property(e => e.MessageBodyId)
                    .HasColumnName("MessageBody_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MessageBodyAttachment1)
                    .HasColumnName("MessageBody_Attachment1")
                    .HasMaxLength(512);

                entity.Property(e => e.MessageBodyAttachment2)
                    .HasColumnName("MessageBody_Attachment2")
                    .HasMaxLength(512);

                entity.Property(e => e.MessageBodyAttachment3)
                    .HasColumnName("MessageBody_Attachment3")
                    .HasMaxLength(512);

                entity.Property(e => e.MessageBodyCreated)
                    .HasColumnName("MessageBody_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MessageBodyDeadline)
                    .HasColumnName("MessageBody_Deadline")
                    .HasColumnType("datetime");

                entity.Property(e => e.MessageBodyMessageId)
                    .HasColumnName("MessageBody_Message_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MessageBodyPriority)
                    .HasColumnName("MessageBody_Priority")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MessageBodySender)
                    .IsRequired()
                    .HasColumnName("MessageBody_Sender")
                    .HasMaxLength(128);

                entity.Property(e => e.MessageBodySenderCompany)
                    .IsRequired()
                    .HasColumnName("MessageBody_SenderCompany")
                    .HasMaxLength(64);

                entity.Property(e => e.MessageBodySenderCompanyId)
                    .HasColumnName("MessageBody_SenderCompany_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MessageBodySenderId)
                    .HasColumnName("MessageBody_Sender_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MessageBodyStatus)
                    .HasColumnName("MessageBody_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MessageBodyText)
                    .IsRequired()
                    .HasColumnName("MessageBody_Text")
                    .HasColumnType("ntext");

                entity.HasOne(d => d.MessageBodyMessage)
                    .WithMany(p => p.MessageBody)
                    .HasForeignKey(d => d.MessageBodyMessageId)
                    .HasConstraintName("FK__MessageBo__Messa__5555A4F4");

                entity.HasOne(d => d.MessageBodySenderCompanyNavigation)
                    .WithMany(p => p.MessageBody)
                    .HasForeignKey(d => d.MessageBodySenderCompanyId)
                    .HasConstraintName("FK__MessageBo__Messa__536D5C82");

                entity.HasOne(d => d.MessageBodySenderNavigation)
                    .WithMany(p => p.MessageBody)
                    .HasForeignKey(d => d.MessageBodySenderId)
                    .HasConstraintName("FK__MessageBo__Messa__546180BB");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.NewsId)
                    .HasColumnName("News_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NewsAdded)
                    .HasColumnName("News_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewsPublished)
                    .HasColumnName("News_Published")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewsStatus)
                    .HasColumnName("News_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NewsText)
                    .HasColumnName("News_Text")
                    .HasColumnType("ntext");

                entity.Property(e => e.NewsTitle)
                    .IsRequired()
                    .HasColumnName("News_Title")
                    .HasMaxLength(128);

                entity.Property(e => e.NewsUrl)
                    .IsRequired()
                    .HasColumnName("News_URL")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Newsletter>(entity =>
            {
                entity.HasIndex(e => e.NewsletterEmail)
                    .HasName("indNewsletter_Email");

                entity.HasIndex(e => e.NewsletterGroup)
                    .HasName("IFC1_Newsletter");

                entity.HasIndex(e => e.NewsletterSent)
                    .HasName("indNewsletter_Sent");

                entity.HasIndex(e => e.NewsletterStatus)
                    .HasName("indNewsletter_Status");

                entity.HasIndex(e => e.NewsletterTag)
                    .HasName("indNewsletter_Tag");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("Newsletter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NewsletterAdded)
                    .HasColumnName("Newsletter_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewsletterComments)
                    .HasColumnName("Newsletter_Comments")
                    .HasMaxLength(512);

                entity.Property(e => e.NewsletterEmail)
                    .IsRequired()
                    .HasColumnName("Newsletter_Email")
                    .HasMaxLength(128);

                entity.Property(e => e.NewsletterGroup)
                    .HasColumnName("Newsletter_Group")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NewsletterGuid)
                    .HasColumnName("Newsletter_GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NewsletterIpaddress)
                    .HasColumnName("Newsletter_IPAddress")
                    .HasMaxLength(32);

                entity.Property(e => e.NewsletterName)
                    .HasColumnName("Newsletter_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.NewsletterNotify)
                    .HasColumnName("Newsletter_Notify")
                    .HasColumnType("datetime");

                entity.Property(e => e.NewsletterPhone)
                    .HasColumnName("Newsletter_Phone")
                    .HasMaxLength(32);

                entity.Property(e => e.NewsletterPrice)
                    .HasColumnName("Newsletter_Price")
                    .HasColumnType("money");

                entity.Property(e => e.NewsletterSent)
                    .HasColumnName("Newsletter_Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.NewsletterSentQty).HasColumnName("Newsletter_SentQty");

                entity.Property(e => e.NewsletterSkype)
                    .HasColumnName("Newsletter_Skype")
                    .HasMaxLength(64);

                entity.Property(e => e.NewsletterStatus)
                    .HasColumnName("Newsletter_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NewsletterTag)
                    .HasColumnName("Newsletter_Tag")
                    .HasMaxLength(32);

                entity.Property(e => e.NewsletterType)
                    .HasColumnName("Newsletter_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NewsletterUnsubscribed)
                    .HasColumnName("Newsletter_Unsubscribed")
                    .HasColumnType("datetime");

                entity.Property(e => e.NewsletterViber)
                    .HasColumnName("Newsletter_Viber")
                    .HasMaxLength(64);

                entity.Property(e => e.NewsletterVk)
                    .HasColumnName("Newsletter_VK")
                    .HasMaxLength(256);

                entity.Property(e => e.NewsletterWhatsUp)
                    .HasColumnName("Newsletter_WhatsUp")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Newsletter2>(entity =>
            {
                entity.HasKey(e => e.NewsletterId)
                    .HasName("PK__Newslett__AA26DC27DA5BD062");

                entity.Property(e => e.NewsletterId)
                    .HasColumnName("Newsletter_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NewsletterAdded)
                    .HasColumnName("Newsletter_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewsletterComments)
                    .HasColumnName("Newsletter_Comments")
                    .HasColumnType("ntext");

                entity.Property(e => e.NewsletterEmail)
                    .IsRequired()
                    .HasColumnName("Newsletter_Email")
                    .HasMaxLength(128);

                entity.Property(e => e.NewsletterGroup)
                    .HasColumnName("Newsletter_Group")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NewsletterGuid)
                    .HasColumnName("Newsletter_GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NewsletterIpaddress)
                    .HasColumnName("Newsletter_IPAddress")
                    .HasMaxLength(32);

                entity.Property(e => e.NewsletterName)
                    .HasColumnName("Newsletter_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.NewsletterPhone)
                    .HasColumnName("Newsletter_Phone")
                    .HasMaxLength(32);

                entity.Property(e => e.NewsletterSent)
                    .HasColumnName("Newsletter_Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.NewsletterSentQty).HasColumnName("Newsletter_SentQty");

                entity.Property(e => e.NewsletterStatus)
                    .HasColumnName("Newsletter_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NewsletterTag)
                    .HasColumnName("Newsletter_Tag")
                    .HasMaxLength(32);

                entity.Property(e => e.NewsletterType)
                    .HasColumnName("Newsletter_Type")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ObjectLog>(entity =>
            {
                entity.Property(e => e.ObjectLogId)
                    .HasColumnName("ObjectLog_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddedById)
                    .HasColumnName("AddedBy_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AddedByName)
                    .IsRequired()
                    .HasColumnName("AddedBy_Name")
                    .HasMaxLength(128);

                entity.Property(e => e.ObjectId)
                    .HasColumnName("Object_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ObjectLogAdded)
                    .HasColumnName("ObjectLog_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjectLogAfter)
                    .HasColumnName("ObjectLog_After")
                    .HasColumnType("ntext");

                entity.Property(e => e.ObjectLogBefore)
                    .HasColumnName("ObjectLog_Before")
                    .HasColumnType("ntext");

                entity.Property(e => e.ObjectLogIpaddress)
                    .IsRequired()
                    .HasColumnName("ObjectLog_IPAddress")
                    .HasMaxLength(32);

                entity.Property(e => e.ObjectLogNote)
                    .HasColumnName("ObjectLog_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.ObjectLogOperation)
                    .IsRequired()
                    .HasColumnName("ObjectLog_Operation")
                    .HasMaxLength(32);

                entity.Property(e => e.ObjectLogTable)
                    .IsRequired()
                    .HasColumnName("ObjectLog_Table")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Ownhotel>(entity =>
            {
                entity.ToTable("OWNHotel");

                entity.Property(e => e.OwnhotelId)
                    .HasColumnName("OWNHotel_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OwnhotelAdded)
                    .HasColumnName("OWNHotel_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OwnhotelDesc)
                    .HasColumnName("OWNHotel_Desc")
                    .HasColumnType("ntext");

                entity.Property(e => e.OwnhotelDescMl)
                    .HasColumnName("OWNHotel_Desc_ML")
                    .HasColumnType("ntext");

                entity.Property(e => e.OwnhotelEmail)
                    .HasColumnName("OWNHotel_Email")
                    .HasMaxLength(64);

                entity.Property(e => e.OwnhotelFax)
                    .HasColumnName("OWNHotel_Fax")
                    .HasMaxLength(32);

                entity.Property(e => e.OwnhotelImg1)
                    .HasColumnName("OWNHotel_Img1")
                    .HasMaxLength(256);

                entity.Property(e => e.OwnhotelImg1Local)
                    .HasColumnName("OWNHotel_Img1Local")
                    .HasMaxLength(256);

                entity.Property(e => e.OwnhotelImg1Type)
                    .HasColumnName("OWNHotel_Img1Type")
                    .HasMaxLength(8);

                entity.Property(e => e.OwnhotelImg2)
                    .HasColumnName("OWNHotel_Img2")
                    .HasMaxLength(256);

                entity.Property(e => e.OwnhotelImg2Local)
                    .HasColumnName("OWNHotel_Img2Local")
                    .HasMaxLength(256);

                entity.Property(e => e.OwnhotelImg2Type)
                    .HasColumnName("OWNHotel_Img2Type")
                    .HasMaxLength(8);

                entity.Property(e => e.OwnhotelImg3)
                    .HasColumnName("OWNHotel_Img3")
                    .HasMaxLength(256);

                entity.Property(e => e.OwnhotelImg3Local)
                    .HasColumnName("OWNHotel_Img3Local")
                    .HasMaxLength(256);

                entity.Property(e => e.OwnhotelImg3Type)
                    .HasColumnName("OWNHotel_Img3Type")
                    .HasMaxLength(8);

                entity.Property(e => e.OwnhotelKeys).HasColumnName("OWNHotel_Keys");

                entity.Property(e => e.OwnhotelName)
                    .IsRequired()
                    .HasColumnName("OWNHotel_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.OwnhotelNameMl)
                    .HasColumnName("OWNHotel_Name_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.OwnhotelPhone)
                    .HasColumnName("OWNHotel_Phone")
                    .HasMaxLength(32);

                entity.Property(e => e.OwnhotelPromt).HasColumnName("OWNHotel_Promt");

                entity.Property(e => e.OwnhotelStars).HasColumnName("OWNHotel_Stars");

                entity.Property(e => e.OwnhotelStarsName)
                    .HasColumnName("OWNHotel_StarsName")
                    .HasMaxLength(64);

                entity.Property(e => e.OwnhotelStarsPlus).HasColumnName("OWNHotel_StarsPlus");

                entity.Property(e => e.OwnhotelUpdated)
                    .HasColumnName("OWNHotel_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.OwnhotelUrl)
                    .HasColumnName("OWNHotel_URL")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<OwnhotelDet>(entity =>
            {
                entity.ToTable("OWNHotelDet");

                entity.HasIndex(e => e.OwnhotelFacId)
                    .HasName("IF1_OWNHotelDet");

                entity.HasIndex(e => e.OwnhotelId)
                    .HasName("IF2_OWNHotelDet");

                entity.Property(e => e.OwnhotelDetId)
                    .HasColumnName("OWNHotelDet_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OwnhotelDetNumber).HasColumnName("OWNHotelDet_Number");

                entity.Property(e => e.OwnhotelFacId)
                    .HasColumnName("OWNHotelFac_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OwnhotelId)
                    .HasColumnName("OWNHotel_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.OwnhotelFac)
                    .WithMany(p => p.OwnhotelDet)
                    .HasForeignKey(d => d.OwnhotelFacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OWNHotelD__OWNHo__573DED66");

                entity.HasOne(d => d.Ownhotel)
                    .WithMany(p => p.OwnhotelDet)
                    .HasForeignKey(d => d.OwnhotelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OWNHotelD__OWNHo__5649C92D");
            });

            modelBuilder.Entity<OwnhotelFac>(entity =>
            {
                entity.ToTable("OWNHotelFac");

                entity.Property(e => e.OwnhotelFacId)
                    .HasColumnName("OWNHotelFac_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OwnhotelFacAdded)
                    .HasColumnName("OWNHotelFac_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OwnhotelFacName)
                    .IsRequired()
                    .HasColumnName("OWNHotelFac_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.OwnhotelFacNameMl)
                    .HasColumnName("OWNHotelFac_Name_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.OwnhotelFacType).HasColumnName("OWNHotelFac_Type");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.HasIndex(e => e.DestId)
                    .HasName("IF2_Package");

                entity.HasIndex(e => e.DestId1)
                    .HasName("IF3_Package");

                entity.HasIndex(e => e.DestId2)
                    .HasName("IF4_Package");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IF1_Package");

                entity.Property(e => e.PackageId)
                    .HasColumnName("Package_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AkkProdId)
                    .HasColumnName("AkkProd_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DestId)
                    .HasColumnName("Dest_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DestId1)
                    .HasColumnName("Dest_ID1")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DestId2)
                    .HasColumnName("Dest_ID2")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PackageAdded)
                    .HasColumnName("Package_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PackageAddedById)
                    .HasColumnName("Package_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PackageCurrency)
                    .IsRequired()
                    .HasColumnName("Package_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.PackageFeatured)
                    .HasColumnName("Package_Featured")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PackageFromDate)
                    .HasColumnName("Package_FromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PackageHtml)
                    .IsRequired()
                    .HasColumnName("Package_HTML")
                    .HasColumnType("ntext");

                entity.Property(e => e.PackageHtmlml)
                    .HasColumnName("Package_HTMLML")
                    .HasColumnType("ntext");

                entity.Property(e => e.PackageImg1)
                    .HasColumnName("Package_Img1")
                    .HasMaxLength(256);

                entity.Property(e => e.PackageKeywords)
                    .HasColumnName("Package_Keywords")
                    .HasMaxLength(512);

                entity.Property(e => e.PackageKeywordsMl)
                    .HasColumnName("Package_KeywordsML")
                    .HasMaxLength(1024);

                entity.Property(e => e.PackageKind).HasColumnName("Package_Kind");

                entity.Property(e => e.PackageNights).HasColumnName("Package_Nights");

                entity.Property(e => e.PackagePriceFrom)
                    .HasColumnName("Package_PriceFrom")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.PackagePriceFromChd)
                    .HasColumnName("Package_PriceFromCHD")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.PackagePublished)
                    .HasColumnName("Package_Published")
                    .HasColumnType("datetime");

                entity.Property(e => e.PackageRank).HasColumnName("Package_Rank");

                entity.Property(e => e.PackageRoute)
                    .HasColumnName("Package_Route")
                    .HasMaxLength(512);

                entity.Property(e => e.PackageRouteC)
                    .HasColumnName("Package_RouteC")
                    .HasMaxLength(512);

                entity.Property(e => e.PackageRouteCml)
                    .HasColumnName("Package_RouteCML")
                    .HasMaxLength(512);

                entity.Property(e => e.PackageRouteMl)
                    .HasColumnName("Package_RouteML")
                    .HasMaxLength(512);

                entity.Property(e => e.PackageSeourl)
                    .HasColumnName("Package_SEOURL")
                    .HasMaxLength(256);

                entity.Property(e => e.PackageSeourlml)
                    .HasColumnName("Package_SEOURLML")
                    .HasMaxLength(256);

                entity.Property(e => e.PackageStatus)
                    .HasColumnName("Package_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PackageSubtype)
                    .HasColumnName("Package_Subtype")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PackageSubtype1).HasColumnName("Package_Subtype1");

                entity.Property(e => e.PackageSubtype2).HasColumnName("Package_Subtype2");

                entity.Property(e => e.PackageSubtype3).HasColumnName("Package_Subtype3");

                entity.Property(e => e.PackageSubtype4).HasColumnName("Package_Subtype4");

                entity.Property(e => e.PackageSubtype5).HasColumnName("Package_Subtype5");

                entity.Property(e => e.PackageSubtype6).HasColumnName("Package_Subtype6");

                entity.Property(e => e.PackageSubtype7).HasColumnName("Package_Subtype7");

                entity.Property(e => e.PackageSubtype8).HasColumnName("Package_Subtype8");

                entity.Property(e => e.PackageSubtype9).HasColumnName("Package_Subtype9");

                entity.Property(e => e.PackageSupplierUrl)
                    .HasColumnName("Package_SupplierURL")
                    .HasMaxLength(256);

                entity.Property(e => e.PackageText)
                    .HasColumnName("Package_Text")
                    .HasMaxLength(1024);

                entity.Property(e => e.PackageTextInit)
                    .HasColumnName("Package_TextInit")
                    .HasColumnType("ntext");

                entity.Property(e => e.PackageTextInitMl)
                    .HasColumnName("Package_TextInitML")
                    .HasColumnType("ntext");

                entity.Property(e => e.PackageTextMl)
                    .HasColumnName("Package_TextML")
                    .HasMaxLength(1024);

                entity.Property(e => e.PackageTitle)
                    .IsRequired()
                    .HasColumnName("Package_Title")
                    .HasMaxLength(128);

                entity.Property(e => e.PackageTitleMl)
                    .HasColumnName("Package_TitleML")
                    .HasMaxLength(512);

                entity.Property(e => e.PackageTmp).HasColumnName("Package_tmp");

                entity.Property(e => e.PackageToDate)
                    .HasColumnName("Package_ToDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PackageType)
                    .HasColumnName("Package_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PackageTypeOld).HasColumnName("Package_Type_old");

                entity.Property(e => e.PackageUpdated)
                    .HasColumnName("Package_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.PackageUpdatedById)
                    .HasColumnName("Package_UpdatedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PackageViewed).HasColumnName("Package_Viewed");

                entity.Property(e => e.SamotyrUrl)
                    .HasColumnName("Samotyr_URL")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId)
                    .HasColumnName("Supplier_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Dest)
                    .WithMany(p => p.PackageDest)
                    .HasForeignKey(d => d.DestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Package__Dest_ID__5832119F");

                entity.HasOne(d => d.DestId1Navigation)
                    .WithMany(p => p.PackageDestId1Navigation)
                    .HasForeignKey(d => d.DestId1)
                    .HasConstraintName("FK__Package__Dest_ID__5B0E7E4A");

                entity.HasOne(d => d.DestId2Navigation)
                    .WithMany(p => p.PackageDestId2Navigation)
                    .HasForeignKey(d => d.DestId2)
                    .HasConstraintName("FK__Package__Dest_ID__5A1A5A11");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Package__Supplie__592635D8");
            });

            modelBuilder.Entity<PageAccess>(entity =>
            {
                entity.Property(e => e.PageAccessId)
                    .HasColumnName("PageAccess_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PageAccessLevel1).HasColumnName("PageAccess_Level1");

                entity.Property(e => e.PageAccessLevel2).HasColumnName("PageAccess_Level2");

                entity.Property(e => e.PageAccessLevel3).HasColumnName("PageAccess_Level3");

                entity.Property(e => e.PageAccessLevel4).HasColumnName("PageAccess_Level4");

                entity.Property(e => e.PageAccessLevel5).HasColumnName("PageAccess_Level5");

                entity.Property(e => e.PageAccessMenu1)
                    .HasColumnName("PageAccess_Menu1")
                    .HasMaxLength(32);

                entity.Property(e => e.PageAccessMenu2)
                    .HasColumnName("PageAccess_Menu2")
                    .HasMaxLength(32);

                entity.Property(e => e.PageAccessMenu3)
                    .HasColumnName("PageAccess_Menu3")
                    .HasMaxLength(32);

                entity.Property(e => e.PageAccessMenuRank).HasColumnName("PageAccess_MenuRank");

                entity.Property(e => e.PageAccessPage)
                    .HasColumnName("PageAccess_Page")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasIndex(e => e.CompanyId)
                    .HasName("IF1_Person");

                entity.Property(e => e.PersonId)
                    .HasColumnName("Person_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId)
                    .HasColumnName("Company_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PersonAccess).HasColumnName("Person_Access");

                entity.Property(e => e.PersonAccountLevel).HasColumnName("Person_AccountLevel");

                entity.Property(e => e.PersonAdded)
                    .HasColumnName("Person_Added")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonAddedById)
                    .HasColumnName("Person_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PersonArchived).HasColumnName("Person_Archived");

                entity.Property(e => e.PersonBirthday)
                    .HasColumnName("Person_Birthday")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonColorBg)
                    .HasColumnName("Person_ColorBg")
                    .HasMaxLength(8);

                entity.Property(e => e.PersonColorText)
                    .HasColumnName("Person_ColorText")
                    .HasMaxLength(8);

                entity.Property(e => e.PersonCreated)
                    .HasColumnName("Person_Created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PersonEmail)
                    .IsRequired()
                    .HasColumnName("Person_Email")
                    .HasMaxLength(64);

                entity.Property(e => e.PersonFirstName)
                    .IsRequired()
                    .HasColumnName("Person_FirstName")
                    .HasMaxLength(32);

                entity.Property(e => e.PersonLabel)
                    .HasColumnName("Person_Label")
                    .HasMaxLength(32);

                entity.Property(e => e.PersonLastActive)
                    .HasColumnName("Person_LastActive")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonLastIp)
                    .HasColumnName("Person_LastIP")
                    .HasMaxLength(64);

                entity.Property(e => e.PersonLastLogin)
                    .HasColumnName("Person_LastLogin")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonLastName)
                    .IsRequired()
                    .HasColumnName("Person_LastName")
                    .HasMaxLength(32);

                entity.Property(e => e.PersonLoginCount).HasColumnName("Person_LoginCount");

                entity.Property(e => e.PersonMiddleName)
                    .HasColumnName("Person_MiddleName")
                    .HasMaxLength(32);

                entity.Property(e => e.PersonMobile)
                    .HasColumnName("Person_Mobile")
                    .HasMaxLength(32);

                entity.Property(e => e.PersonNote)
                    .HasColumnName("Person_Note")
                    .HasMaxLength(1024);

                entity.Property(e => e.PersonPassword)
                    .IsRequired()
                    .HasColumnName("Person_Password")
                    .HasMaxLength(32);

                entity.Property(e => e.PersonPhone)
                    .IsRequired()
                    .HasColumnName("Person_Phone")
                    .HasMaxLength(32);

                entity.Property(e => e.PersonPrimary).HasColumnName("Person_Primary");

                entity.Property(e => e.PersonSys).HasColumnName("Person_Sys");

                entity.Property(e => e.PersonTitle)
                    .HasColumnName("Person_Title")
                    .HasMaxLength(32);

                entity.Property(e => e.PersonUpdated)
                    .HasColumnName("Person_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonUpdatedById)
                    .HasColumnName("Person_UpdatedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__Person__Company___5C02A283");
            });

            modelBuilder.Entity<PkgDate>(entity =>
            {
                entity.HasIndex(e => e.PackageId)
                    .HasName("IF1_PkgDate");

                entity.Property(e => e.PkgDateId)
                    .HasColumnName("PkgDate_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BusTripId)
                    .HasColumnName("BusTrip_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PackageId)
                    .HasColumnName("Package_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PkgDateAdded)
                    .HasColumnName("PkgDate_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PkgDateDate)
                    .HasColumnName("PkgDate_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PkgDateDateTo)
                    .HasColumnName("PkgDate_DateTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.PkgDatePriceFrom)
                    .HasColumnName("PkgDate_PriceFrom")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.PkgDatePriceFromChd)
                    .HasColumnName("PkgDate_PriceFromCHD")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.PkgDatePriceZero)
                    .HasColumnName("PkgDate_PriceZero")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PkgDateSpecial)
                    .HasColumnName("PkgDate_Special")
                    .HasMaxLength(32);

                entity.Property(e => e.PkgDateSpecialType).HasColumnName("PkgDate_SpecialType");

                entity.Property(e => e.PkgDateSpodateFrom)
                    .HasColumnName("PkgDate_SPODateFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.PkgDateSpodateTo)
                    .HasColumnName("PkgDate_SPODateTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.PkgDateUpdated)
                    .HasColumnName("PkgDate_Updated")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.BusTrip)
                    .WithMany(p => p.PkgDate)
                    .HasForeignKey(d => d.BusTripId)
                    .HasConstraintName("FK__PkgDate__BusTrip__5DEAEAF5");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.PkgDate)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PkgDate__Package__5CF6C6BC");
            });

            modelBuilder.Entity<PkgExtra>(entity =>
            {
                entity.HasIndex(e => e.ExcursionId)
                    .HasName("IF3_PkgExtra");

                entity.HasIndex(e => e.ExtraId)
                    .HasName("IF2_PkgExtra");

                entity.HasIndex(e => e.PackageId)
                    .HasName("IF1_PkgExtra");

                entity.Property(e => e.PkgExtraId)
                    .HasColumnName("PkgExtra_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ExcursionId)
                    .HasColumnName("Excursion_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ExtraId)
                    .HasColumnName("Extra_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PackageId)
                    .HasColumnName("Package_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PkgExtraAdded)
                    .HasColumnName("PkgExtra_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PkgExtraAddedById)
                    .HasColumnName("PkgExtra_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PkgExtraCurrency)
                    .IsRequired()
                    .HasColumnName("PkgExtra_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.PkgExtraPrice)
                    .HasColumnName("PkgExtra_Price")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.PkgExtraPriceChd)
                    .HasColumnName("PkgExtra_PriceCHD")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.PkgExtraRank).HasColumnName("PkgExtra_Rank");

                entity.Property(e => e.PkgExtraStatus).HasColumnName("PkgExtra_Status");

                entity.Property(e => e.PkgExtraTitle)
                    .HasColumnName("PkgExtra_Title")
                    .HasMaxLength(512);

                entity.Property(e => e.PkgExtraTitleMl)
                    .HasColumnName("PkgExtra_TitleML")
                    .HasMaxLength(512);

                entity.Property(e => e.PkgExtraType)
                    .HasColumnName("PkgExtra_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PkgExtraUpdated)
                    .HasColumnName("PkgExtra_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.PkgExtraUpdatedById)
                    .HasColumnName("PkgExtra_UpdatedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Excursion)
                    .WithMany(p => p.PkgExtra)
                    .HasForeignKey(d => d.ExcursionId)
                    .HasConstraintName("FK__PkgExtra__Excurs__6497E884");

                entity.HasOne(d => d.Extra)
                    .WithMany(p => p.PkgExtra)
                    .HasForeignKey(d => d.ExtraId)
                    .HasConstraintName("FK__PkgExtra__Extra___5FD33367");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.PkgExtra)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PkgExtra__Packag__5EDF0F2E");
            });

            modelBuilder.Entity<Referral>(entity =>
            {
                entity.Property(e => e.ReferralId)
                    .HasColumnName("Referral_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReferralAdded)
                    .HasColumnName("Referral_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReferralAllHttp)
                    .HasColumnName("Referral_ALL_HTTP")
                    .HasMaxLength(1024);

                entity.Property(e => e.ReferralClientIp)
                    .HasColumnName("Referral_ClientIP")
                    .HasMaxLength(64);

                entity.Property(e => e.ReferralQueryString)
                    .HasColumnName("Referral_QUERY_STRING")
                    .HasMaxLength(1024);

                entity.Property(e => e.ReferralReturnId)
                    .HasColumnName("Referral_ReturnID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReferralScriptName)
                    .HasColumnName("Referral_SCRIPT_NAME")
                    .HasMaxLength(256);

                entity.Property(e => e.ReferralServer)
                    .HasColumnName("Referral_Server")
                    .HasMaxLength(256);

                entity.Property(e => e.ReferralType).HasColumnName("Referral_Type");

                entity.Property(e => e.ReferralUrl)
                    .HasColumnName("Referral_URL")
                    .HasMaxLength(1024);
            });

            modelBuilder.Entity<ReqInfo>(entity =>
            {
                entity.HasIndex(e => e.AddedById)
                    .HasName("IF3_ReqInfo");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IF2_ReqInfo");

                entity.HasIndex(e => e.RequestId)
                    .HasName("IF1_ReqInfo");

                entity.HasIndex(e => e.SignedById)
                    .HasName("IF4_ReqInfo");

                entity.Property(e => e.ReqInfoId)
                    .HasColumnName("ReqInfo_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddedById)
                    .HasColumnName("AddedBy_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ManagerId)
                    .HasColumnName("Manager_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReqInfoAdded)
                    .HasColumnName("ReqInfo_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReqInfoAmount)
                    .HasColumnName("ReqInfo_Amount")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.ReqInfoAmountType).HasColumnName("ReqInfo_AmountType");

                entity.Property(e => e.ReqInfoCurrency)
                    .HasColumnName("ReqInfo_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.ReqInfoExcCurrency)
                    .HasColumnName("ReqInfo_ExcCurrency")
                    .HasMaxLength(8);

                entity.Property(e => e.ReqInfoExcRate)
                    .HasColumnName("ReqInfo_ExcRate")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.ReqInfoNotified)
                    .HasColumnName("ReqInfo_Notified")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqInfoNotifiedText)
                    .HasColumnName("ReqInfo_NotifiedText")
                    .HasMaxLength(256);

                entity.Property(e => e.ReqInfoNotify)
                    .HasColumnName("ReqInfo_Notify")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqInfoPriority)
                    .HasColumnName("ReqInfo_Priority")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.ReqInfoSigned)
                    .HasColumnName("ReqInfo_Signed")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqInfoSignedText)
                    .HasColumnName("ReqInfo_SignedText")
                    .HasMaxLength(256);

                entity.Property(e => e.ReqInfoSms)
                    .HasColumnName("ReqInfo_SMS")
                    .HasColumnType("ntext");

                entity.Property(e => e.ReqInfoStatusNew).HasColumnName("ReqInfo_StatusNew");

                entity.Property(e => e.ReqInfoStatusOld).HasColumnName("ReqInfo_StatusOld");

                entity.Property(e => e.ReqInfoText)
                    .HasColumnName("ReqInfo_Text")
                    .HasMaxLength(1024);

                entity.Property(e => e.RequestId)
                    .HasColumnName("Request_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SignedById)
                    .HasColumnName("SignedBy_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.ReqInfoAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReqInfo__AddedBy__668030F6");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.ReqInfoManager)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReqInfo__Manager__658C0CBD");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.ReqInfo)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReqInfo__Request__6774552F");
            });

            modelBuilder.Entity<ReqNotify>(entity =>
            {
                entity.Property(e => e.ReqNotifyId)
                    .HasColumnName("ReqNotify_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReqNotifyAdded)
                    .HasColumnName("ReqNotify_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReqNotifyEnabled)
                    .IsRequired()
                    .HasColumnName("ReqNotify_Enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReqNotifyInterval)
                    .IsRequired()
                    .HasColumnName("ReqNotify_Interval")
                    .HasMaxLength(8);

                entity.Property(e => e.ReqNotifyIntervalDate).HasColumnName("ReqNotify_IntervalDate");

                entity.Property(e => e.ReqNotifyNumber).HasColumnName("ReqNotify_Number");

                entity.Property(e => e.ReqNotifyPriority)
                    .HasColumnName("ReqNotify_Priority")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.ReqNotifyRank).HasColumnName("ReqNotify_Rank");

                entity.Property(e => e.ReqNotifyStatusNew).HasColumnName("ReqNotify_StatusNew");

                entity.Property(e => e.ReqNotifyStatusOld).HasColumnName("ReqNotify_StatusOld");

                entity.Property(e => e.ReqNotifyText)
                    .IsRequired()
                    .HasColumnName("ReqNotify_Text")
                    .HasMaxLength(512);

                entity.Property(e => e.ReqNotifyType).HasColumnName("ReqNotify_Type");
            });

            modelBuilder.Entity<ReqPassport>(entity =>
            {
                entity.HasIndex(e => e.AddedById)
                    .HasName("IF2_ReqPassport");

                entity.HasIndex(e => e.ChflightSeatBackId)
                    .HasName("IF4_ReqPassport");

                entity.HasIndex(e => e.ChflightSeatThereId)
                    .HasName("IF3_ReqPassport");

                entity.HasIndex(e => e.RequestId)
                    .HasName("IF1_ReqPassport");

                entity.Property(e => e.ReqPassportId)
                    .HasColumnName("ReqPassport_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddedById)
                    .HasColumnName("AddedBy_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ChflightSeatBackId)
                    .HasColumnName("CHFlightSeatBack_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ChflightSeatThereId)
                    .HasColumnName("CHFlightSeatThere_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqPassportAdded)
                    .HasColumnName("ReqPassport_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReqPassportContactPhone)
                    .HasColumnName("ReqPassport_ContactPhone")
                    .HasMaxLength(32);

                entity.Property(e => e.ReqPassportDateOfBirth)
                    .HasColumnName("ReqPassport_DateOfBirth")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqPassportDateOfExpiry)
                    .HasColumnName("ReqPassport_DateOfExpiry")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqPassportExt1)
                    .HasColumnName("ReqPassport_Ext1")
                    .HasMaxLength(256);

                entity.Property(e => e.ReqPassportFirstName)
                    .IsRequired()
                    .HasColumnName("ReqPassport_FirstName")
                    .HasMaxLength(32);

                entity.Property(e => e.ReqPassportIssuedBy)
                    .HasColumnName("ReqPassport_IssuedBy")
                    .HasMaxLength(32);

                entity.Property(e => e.ReqPassportLastName)
                    .IsRequired()
                    .HasColumnName("ReqPassport_LastName")
                    .HasMaxLength(32);

                entity.Property(e => e.ReqPassportLead).HasColumnName("ReqPassport_Lead");

                entity.Property(e => e.ReqPassportNote)
                    .HasColumnName("ReqPassport_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.ReqPassportNumber)
                    .HasColumnName("ReqPassport_Number")
                    .HasMaxLength(32);

                entity.Property(e => e.ReqPassportSeries)
                    .HasColumnName("ReqPassport_Series")
                    .HasMaxLength(16);

                entity.Property(e => e.ReqPassportTitle)
                    .HasColumnName("ReqPassport_Title")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestId)
                    .HasColumnName("Request_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.ReqPassport)
                    .HasForeignKey(d => d.AddedById)
                    .HasConstraintName("FK__ReqPasspo__Added__695C9DA1");

                entity.HasOne(d => d.ChflightSeatBack)
                    .WithMany(p => p.ReqPassportChflightSeatBack)
                    .HasForeignKey(d => d.ChflightSeatBackId)
                    .HasConstraintName("FK__ReqPasspo__CHFli__6B44E613");

                entity.HasOne(d => d.ChflightSeatThere)
                    .WithMany(p => p.ReqPassportChflightSeatThere)
                    .HasForeignKey(d => d.ChflightSeatThereId)
                    .HasConstraintName("FK__ReqPasspo__CHFli__6A50C1DA");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.ReqPassport)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReqPasspo__Reque__68687968");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasIndex(e => e.AddedById)
                    .HasName("IF3_Request");

                entity.HasIndex(e => e.AgencyId)
                    .HasName("IF4_Request");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IF1_Request");

                entity.HasIndex(e => e.ParentId)
                    .HasName("IF5_Request");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IF2_Request");

                entity.Property(e => e.RequestId)
                    .HasColumnName("Request_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddedById)
                    .HasColumnName("AddedBy_ID")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AgencyId)
                    .HasColumnName("Agency_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("Contact_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ContactInfoId)
                    .HasColumnName("ContactInfo_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ManagerId)
                    .HasColumnName("Manager_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ManagerId2)
                    .HasColumnName("Manager_ID2")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("Parent_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RequestAccAmount)
                    .HasColumnName("Request_AccAmount")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.RequestAccDate)
                    .HasColumnName("Request_AccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestAccNo)
                    .HasColumnName("Request_AccNo")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestAccServiceFee)
                    .HasColumnName("Request_AccServiceFee")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.RequestAdded)
                    .HasColumnName("Request_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestArchived).HasColumnName("Request_Archived");

                entity.Property(e => e.RequestBoardBasis)
                    .HasColumnName("Request_BoardBasis")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestBooking).HasColumnName("Request_Booking");

                entity.Property(e => e.RequestCalculation)
                    .HasColumnName("Request_Calculation")
                    .HasMaxLength(128);

                entity.Property(e => e.RequestCommission)
                    .HasColumnName("Request_Commission")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.RequestCommissionCurrency)
                    .HasColumnName("Request_CommissionCurrency")
                    .HasMaxLength(8);

                entity.Property(e => e.RequestCommissionManager1Amount)
                    .HasColumnName("Request_CommissionManager1Amount")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.RequestCommissionManager1Percent)
                    .HasColumnName("Request_CommissionManager1Percent")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.RequestCommissionManager2Amount)
                    .HasColumnName("Request_CommissionManager2Amount")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.RequestCommissionManager2Percent)
                    .HasColumnName("Request_CommissionManager2Percent")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.RequestCommissionPaid)
                    .HasColumnName("Request_CommissionPaid")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestCommissionSignedById)
                    .HasColumnName("Request_CommissionSignedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RequestContactAddress)
                    .HasColumnName("Request_ContactAddress")
                    .HasMaxLength(128);

                entity.Property(e => e.RequestContactCompany)
                    .HasColumnName("Request_ContactCompany")
                    .HasMaxLength(64);

                entity.Property(e => e.RequestContactCompanyEdrpou)
                    .HasColumnName("Request_ContactCompanyEDRPOU")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestContactEmail)
                    .HasColumnName("Request_ContactEmail")
                    .HasMaxLength(128);

                entity.Property(e => e.RequestContactEmail2)
                    .HasColumnName("Request_ContactEmail2")
                    .HasMaxLength(128);

                entity.Property(e => e.RequestContactFirstName)
                    .IsRequired()
                    .HasColumnName("Request_ContactFirstName")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RequestContactLastName)
                    .HasColumnName("Request_ContactLastName")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestContactMiddleName)
                    .HasColumnName("Request_ContactMiddleName")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestContactNameOld)
                    .HasColumnName("Request_ContactName_OLD")
                    .HasMaxLength(256);

                entity.Property(e => e.RequestContactPhone)
                    .IsRequired()
                    .HasColumnName("Request_ContactPhone")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestContactPhone2)
                    .HasColumnName("Request_ContactPhone2")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestContactPhone2Note)
                    .HasColumnName("Request_ContactPhone2Note")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestContactPhone3)
                    .HasColumnName("Request_ContactPhone3")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestContactPhone3Note)
                    .HasColumnName("Request_ContactPhone3Note")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestContactPhoneNote)
                    .HasColumnName("Request_ContactPhoneNote")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestCountry)
                    .IsRequired()
                    .HasColumnName("Request_Country")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RequestCurrency)
                    .HasColumnName("Request_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.RequestDate)
                    .HasColumnName("Request_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestDestination)
                    .IsRequired()
                    .HasColumnName("Request_Destination")
                    .HasMaxLength(64);

                entity.Property(e => e.RequestDestinationOld)
                    .HasColumnName("Request_Destination_OLD")
                    .HasMaxLength(128);

                entity.Property(e => e.RequestDiscount)
                    .HasColumnName("Request_Discount")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.RequestDocReceived)
                    .HasColumnName("Request_DocReceived")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestDocReceivedBy)
                    .HasColumnName("Request_DocReceivedBy")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestDocSent)
                    .HasColumnName("Request_DocSent")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestDocSentBy)
                    .HasColumnName("Request_DocSentBy")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestExchangeRate)
                    .HasColumnName("Request_ExchangeRate")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.RequestFlight)
                    .HasColumnName("Request_Flight")
                    .HasMaxLength(128);

                entity.Property(e => e.RequestFromCity)
                    .HasColumnName("Request_FromCity")
                    .HasMaxLength(64);

                entity.Property(e => e.RequestFromCountry)
                    .HasColumnName("Request_FromCountry")
                    .HasMaxLength(64);

                entity.Property(e => e.RequestFromDate)
                    .HasColumnName("Request_FromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestGuid)
                    .HasColumnName("Request_GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RequestHotel)
                    .HasColumnName("Request_Hotel")
                    .HasMaxLength(64);

                entity.Property(e => e.RequestInsurer)
                    .HasColumnName("Request_Insurer")
                    .HasMaxLength(128);

                entity.Property(e => e.RequestIpaddress)
                    .HasColumnName("Request_IPAddress")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestNetCost)
                    .HasColumnName("Request_NetCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.RequestNote)
                    .HasColumnName("Request_Note")
                    .HasMaxLength(512);

                entity.Property(e => e.RequestOnAccount).HasColumnName("Request_OnAccount");

                entity.Property(e => e.RequestOrigin).HasColumnName("Request_Origin");

                entity.Property(e => e.RequestPaid)
                    .HasColumnName("Request_Paid")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestPaidBank)
                    .HasColumnName("Request_PaidBank")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestPayTill)
                    .HasColumnName("Request_PayTill")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestPrepaid)
                    .HasColumnName("Request_Prepaid")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.RequestPrepaidPaid)
                    .HasColumnName("Request_PrepaidPaid")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestPrepaidPayTill)
                    .HasColumnName("Request_PrepaidPayTill")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestRefNo)
                    .HasColumnName("Request_RefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestRequestedFeedback)
                    .HasColumnName("Request_RequestedFeedback")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestRoomType)
                    .HasColumnName("Request_RoomType")
                    .HasMaxLength(64);

                entity.Property(e => e.RequestService)
                    .HasColumnName("Request_Service")
                    .HasMaxLength(512);

                entity.Property(e => e.RequestSpecialNote)
                    .HasColumnName("Request_SpecialNote")
                    .HasColumnType("ntext");

                entity.Property(e => e.RequestStatus)
                    .HasColumnName("Request_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RequestSupplierAccAmount)
                    .HasColumnName("Request_SupplierAccAmount")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.RequestSupplierAccDate)
                    .HasColumnName("Request_SupplierAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestSupplierAccNo)
                    .HasColumnName("Request_SupplierAccNo")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestSupplierCatalogPrice)
                    .HasColumnName("Request_SupplierCatalogPrice")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.RequestSupplierNettoCur)
                    .HasColumnName("Request_SupplierNettoCur")
                    .HasMaxLength(64);

                entity.Property(e => e.RequestSupplierPaid)
                    .HasColumnName("Request_SupplierPaid")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestSupplierPayTill)
                    .HasColumnName("Request_SupplierPayTill")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestSupplierRefNo)
                    .HasColumnName("Request_SupplierRefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.RequestToDate)
                    .HasColumnName("Request_ToDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestTotalCost)
                    .HasColumnName("Request_TotalCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.RequestTransfer)
                    .HasColumnName("Request_Transfer")
                    .HasMaxLength(64);

                entity.Property(e => e.RequestType).HasColumnName("Request_Type");

                entity.Property(e => e.RequestUpdated)
                    .HasColumnName("Request_Updated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestUpdatedById)
                    .HasColumnName("Request_UpdatedBy_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RequestVisa)
                    .HasColumnName("Request_Visa")
                    .HasMaxLength(64);

                entity.Property(e => e.SupplierId)
                    .HasColumnName("Supplier_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.AddedBy)
                    .WithMany(p => p.RequestAddedBy)
                    .HasForeignKey(d => d.AddedById)
                    .HasConstraintName("FK__Request__AddedBy__6C390A4C");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.RequestAgency)
                    .HasForeignKey(d => d.AgencyId)
                    .HasConstraintName("FK__Request__Agency___6F1576F7");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.RequestManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__Request__Manager__6E2152BE");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__Request__Parent___70099B30");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.RequestSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK__Request__Supplie__6D2D2E85");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasIndex(e => e.HotelId)
                    .HasName("IF2_Review");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IF1_Review");

                entity.Property(e => e.ReviewId)
                    .HasColumnName("Review_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HotelId)
                    .HasColumnName("Hotel_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PersonId)
                    .HasColumnName("Person_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReviewAdded)
                    .HasColumnName("Review_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReviewAddedById)
                    .HasColumnName("Review_AddedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReviewBeach).HasColumnName("Review_Beach");

                entity.Property(e => e.ReviewContentAvailable).HasColumnName("Review_ContentAvailable");

                entity.Property(e => e.ReviewCountry)
                    .IsRequired()
                    .HasColumnName("Review_Country")
                    .HasMaxLength(64);

                entity.Property(e => e.ReviewEaseUseWebsite).HasColumnName("Review_EaseUseWebsite");

                entity.Property(e => e.ReviewEmail)
                    .IsRequired()
                    .HasColumnName("Review_Email")
                    .HasMaxLength(128);

                entity.Property(e => e.ReviewEntertainment).HasColumnName("Review_Entertainment");

                entity.Property(e => e.ReviewFood).HasColumnName("Review_Food");

                entity.Property(e => e.ReviewFromDate)
                    .HasColumnName("Review_FromDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReviewHotelLocation).HasColumnName("Review_HotelLocation");

                entity.Property(e => e.ReviewHotelTerritory).HasColumnName("Review_HotelTerritory");

                entity.Property(e => e.ReviewHotelType).HasColumnName("Review_HotelType");

                entity.Property(e => e.ReviewIpaddress)
                    .HasColumnName("Review_IPAddress")
                    .HasMaxLength(32);

                entity.Property(e => e.ReviewName)
                    .HasColumnName("Review_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.ReviewOverallImpression).HasColumnName("Review_OverallImpression");

                entity.Property(e => e.ReviewPool)
                    .HasColumnName("Review_Pool")
                    .HasMaxLength(32);

                entity.Property(e => e.ReviewRating)
                    .HasColumnName("Review_Rating")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.ReviewReccomendToFriend)
                    .IsRequired()
                    .HasColumnName("Review_ReccomendToFriend")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReviewReceptionStaff).HasColumnName("Review_ReceptionStaff");

                entity.Property(e => e.ReviewRoomCleaning).HasColumnName("Review_RoomCleaning");

                entity.Property(e => e.ReviewRoomFacilities).HasColumnName("Review_RoomFacilities");

                entity.Property(e => e.ReviewSport).HasColumnName("Review_Sport");

                entity.Property(e => e.ReviewStatus)
                    .HasColumnName("Review_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReviewText)
                    .IsRequired()
                    .HasColumnName("Review_Text")
                    .HasColumnType("ntext");

                entity.Property(e => e.ReviewTextEn)
                    .HasColumnName("Review_Text_EN")
                    .HasColumnType("ntext");

                entity.Property(e => e.ReviewToDate)
                    .HasColumnName("Review_ToDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReviewTown)
                    .IsRequired()
                    .HasColumnName("Review_Town")
                    .HasMaxLength(64);

                entity.Property(e => e.ReviewUpdated)
                    .HasColumnName("Review_Updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReviewUpdatedById)
                    .HasColumnName("Review_UpdatedByID")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.HotelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Review__Hotel_ID__70FDBF69");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Review__Person_I__71F1E3A2");
            });

            modelBuilder.Entity<Seo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SEO");

                entity.Property(e => e.SeoAdded)
                    .HasColumnName("SEO_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SeoAirport)
                    .HasColumnName("SEO_Airport")
                    .HasMaxLength(64);

                entity.Property(e => e.SeoCity)
                    .HasColumnName("SEO_City")
                    .HasMaxLength(64);

                entity.Property(e => e.SeoComments)
                    .HasColumnName("SEO_Comments")
                    .HasColumnType("ntext");

                entity.Property(e => e.SeoEmail)
                    .IsRequired()
                    .HasColumnName("SEO_Email")
                    .HasMaxLength(128);

                entity.Property(e => e.SeoEmail2)
                    .HasColumnName("SEO_Email2")
                    .HasMaxLength(64);

                entity.Property(e => e.SeoGroup)
                    .HasColumnName("SEO_Group")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SeoGuid)
                    .HasColumnName("SEO_GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SeoIata)
                    .HasColumnName("SEO_IATA")
                    .HasMaxLength(64);

                entity.Property(e => e.SeoId)
                    .HasColumnName("SEO_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SeoIpaddress)
                    .HasColumnName("SEO_IPAddress")
                    .HasMaxLength(32);

                entity.Property(e => e.SeoName)
                    .HasColumnName("SEO_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.SeoPhone)
                    .HasColumnName("SEO_Phone")
                    .HasMaxLength(32);

                entity.Property(e => e.SeoSent)
                    .HasColumnName("SEO_Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.SeoSentQty).HasColumnName("SEO_SentQty");

                entity.Property(e => e.SeoStatus)
                    .HasColumnName("SEO_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SeoTag)
                    .HasColumnName("SEO_Tag")
                    .HasMaxLength(32);

                entity.Property(e => e.SeoType)
                    .HasColumnName("SEO_Type")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Seo2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SEO2");

                entity.Property(e => e.SeoAdded)
                    .HasColumnName("SEO_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SeoAirport)
                    .HasColumnName("SEO_Airport")
                    .HasMaxLength(64);

                entity.Property(e => e.SeoCity)
                    .HasColumnName("SEO_City")
                    .HasMaxLength(64);

                entity.Property(e => e.SeoComments)
                    .HasColumnName("SEO_Comments")
                    .HasColumnType("ntext");

                entity.Property(e => e.SeoCountry)
                    .HasColumnName("SEO_Country")
                    .HasMaxLength(64);

                entity.Property(e => e.SeoCountryCode)
                    .HasColumnName("SEO_CountryCode")
                    .HasMaxLength(2);

                entity.Property(e => e.SeoEmail)
                    .HasColumnName("SEO_Email")
                    .HasMaxLength(128);

                entity.Property(e => e.SeoEmail2)
                    .HasColumnName("SEO_Email2")
                    .HasMaxLength(64);

                entity.Property(e => e.SeoGroup)
                    .HasColumnName("SEO_Group")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SeoGuid)
                    .HasColumnName("SEO_GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SeoIata)
                    .HasColumnName("SEO_IATA")
                    .HasMaxLength(64);

                entity.Property(e => e.SeoId)
                    .HasColumnName("SEO_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SeoIpaddress)
                    .HasColumnName("SEO_IPAddress")
                    .HasMaxLength(32);

                entity.Property(e => e.SeoName)
                    .HasColumnName("SEO_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.SeoPhone)
                    .HasColumnName("SEO_Phone")
                    .HasMaxLength(32);

                entity.Property(e => e.SeoSent)
                    .HasColumnName("SEO_Sent")
                    .HasColumnType("datetime");

                entity.Property(e => e.SeoSentQty).HasColumnName("SEO_SentQty");

                entity.Property(e => e.SeoStatus)
                    .HasColumnName("SEO_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SeoTag)
                    .HasColumnName("SEO_Tag")
                    .HasMaxLength(32);

                entity.Property(e => e.SeoType)
                    .HasColumnName("SEO_Type")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.Property(e => e.SettingId)
                    .HasColumnName("Setting_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SettingDate)
                    .HasColumnName("Setting_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SettingForHtml).HasColumnName("Setting_ForHTML");

                entity.Property(e => e.SettingNumeric)
                    .HasColumnName("Setting_Numeric")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.SettingPath1)
                    .IsRequired()
                    .HasColumnName("Setting_Path1")
                    .HasMaxLength(64);

                entity.Property(e => e.SettingPath2)
                    .HasColumnName("Setting_Path2")
                    .HasMaxLength(64);

                entity.Property(e => e.SettingPath3)
                    .HasColumnName("Setting_Path3")
                    .HasMaxLength(64);

                entity.Property(e => e.SettingRequired).HasColumnName("Setting_Required");

                entity.Property(e => e.SettingString)
                    .HasColumnName("Setting_String")
                    .HasMaxLength(256);

                entity.Property(e => e.SettingText)
                    .HasColumnName("Setting_Text")
                    .HasColumnType("ntext");

                entity.Property(e => e.SettingType)
                    .HasColumnName("Setting_Type")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SettingValue>(entity =>
            {
                entity.HasIndex(e => e.SettingId)
                    .HasName("IF1_SettingValue");

                entity.Property(e => e.SettingValueId)
                    .HasColumnName("SettingValue_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SettingId)
                    .HasColumnName("Setting_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SettingValueCaption)
                    .IsRequired()
                    .HasColumnName("SettingValue_Caption")
                    .HasMaxLength(64);

                entity.Property(e => e.SettingValueDate)
                    .HasColumnName("SettingValue_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SettingValueNumeric)
                    .HasColumnName("SettingValue_Numeric")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.SettingValueRank)
                    .HasColumnName("SettingValue_Rank")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SettingValueString)
                    .HasColumnName("SettingValue_String")
                    .HasMaxLength(256);

                entity.Property(e => e.SettingValueText)
                    .HasColumnName("SettingValue_Text")
                    .HasColumnType("ntext");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.SettingValue)
                    .HasForeignKey(d => d.SettingId)
                    .HasConstraintName("FK__SettingVa__Setti__72E607DB");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasIndex(e => e.CountryId)
                    .HasName("IF1_State");

                entity.Property(e => e.StateId)
                    .HasColumnName("State_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StateAbrv)
                    .IsRequired()
                    .HasColumnName("State_Abrv")
                    .HasMaxLength(8);

                entity.Property(e => e.StateEnabled)
                    .IsRequired()
                    .HasColumnName("State_Enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasColumnName("State_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.StateNameMl)
                    .HasColumnName("State_Name_ML")
                    .HasMaxLength(64);

                entity.Property(e => e.StateRank).HasColumnName("State_Rank");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__State__Country_I__73DA2C14");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.HasIndex(e => e.HotelId)
                    .HasName("IF1_Testimonial");

                entity.Property(e => e.TestimonialId)
                    .HasColumnName("Testimonial_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HotelId)
                    .HasColumnName("Hotel_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TestimonialAdded)
                    .HasColumnName("Testimonial_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TestimonialCountry)
                    .IsRequired()
                    .HasColumnName("Testimonial_Country")
                    .HasMaxLength(64);

                entity.Property(e => e.TestimonialDestination)
                    .IsRequired()
                    .HasColumnName("Testimonial_Destination")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TestimonialEmail)
                    .HasColumnName("Testimonial_Email")
                    .HasMaxLength(128);

                entity.Property(e => e.TestimonialHotel)
                    .HasColumnName("Testimonial_Hotel")
                    .HasMaxLength(64);

                entity.Property(e => e.TestimonialIpaddress)
                    .HasColumnName("Testimonial_IPAddress")
                    .HasMaxLength(32);

                entity.Property(e => e.TestimonialManagerReply)
                    .HasColumnName("Testimonial_ManagerReply")
                    .HasColumnType("ntext");

                entity.Property(e => e.TestimonialName)
                    .IsRequired()
                    .HasColumnName("Testimonial_Name")
                    .HasMaxLength(64);

                entity.Property(e => e.TestimonialRating)
                    .HasColumnName("Testimonial_Rating")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.TestimonialStatus)
                    .HasColumnName("Testimonial_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TestimonialText)
                    .HasColumnName("Testimonial_Text")
                    .HasColumnType("ntext");

                entity.Property(e => e.TestimonialTitle)
                    .IsRequired()
                    .HasColumnName("Testimonial_Title")
                    .HasMaxLength(128);

                entity.Property(e => e.TestimonialTown)
                    .IsRequired()
                    .HasColumnName("Testimonial_Town")
                    .HasMaxLength(64);

                entity.Property(e => e.TestimonialType)
                    .HasColumnName("Testimonial_Type")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.Testimonial)
                    .HasForeignKey(d => d.HotelId)
                    .HasConstraintName("FK__Testimoni__Hotel__74CE504D");
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.HasIndex(e => e.AgencyId)
                    .HasName("IF3_Transfer");

                entity.HasIndex(e => e.BookingId)
                    .HasName("IF4_Transfer");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IF2_Transfer");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IF1_Transfer");

                entity.Property(e => e.TransferId)
                    .HasColumnName("Transfer_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AgencyId)
                    .HasColumnName("Agency_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BookingId)
                    .HasColumnName("Booking_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PersonId)
                    .HasColumnName("Person_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("Supplier_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TransferAdded)
                    .HasColumnName("Transfer_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TransferAdults)
                    .HasColumnName("Transfer_Adults")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TransferAgencyCommision)
                    .HasColumnName("Transfer_AgencyCommision")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.TransferAgencyPaidDate)
                    .HasColumnName("Transfer_AgencyPaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransferAgencyRefNo)
                    .HasColumnName("Transfer_AgencyRefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.TransferAirport)
                    .IsRequired()
                    .HasColumnName("Transfer_Airport")
                    .HasMaxLength(32);

                entity.Property(e => e.TransferAirportCode)
                    .IsRequired()
                    .HasColumnName("Transfer_AirportCode")
                    .HasMaxLength(8);

                entity.Property(e => e.TransferArrDate)
                    .HasColumnName("Transfer_ArrDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransferArrTime)
                    .HasColumnName("Transfer_ArrTime")
                    .HasMaxLength(16);

                entity.Property(e => e.TransferCancellationPolicy)
                    .HasColumnName("Transfer_CancellationPolicy")
                    .HasColumnType("ntext");

                entity.Property(e => e.TransferCarType)
                    .IsRequired()
                    .HasColumnName("Transfer_CarType")
                    .HasMaxLength(32);

                entity.Property(e => e.TransferChildAges)
                    .HasColumnName("Transfer_ChildAges")
                    .HasMaxLength(32);

                entity.Property(e => e.TransferChildren).HasColumnName("Transfer_Children");

                entity.Property(e => e.TransferCurrency)
                    .IsRequired()
                    .HasColumnName("Transfer_Currency")
                    .HasMaxLength(8);

                entity.Property(e => e.TransferDepDate)
                    .HasColumnName("Transfer_DepDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransferDepTime)
                    .HasColumnName("Transfer_DepTime")
                    .HasMaxLength(16);

                entity.Property(e => e.TransferHotel)
                    .IsRequired()
                    .HasColumnName("Transfer_Hotel")
                    .HasMaxLength(32);

                entity.Property(e => e.TransferHotelAddress)
                    .IsRequired()
                    .HasColumnName("Transfer_HotelAddress")
                    .HasMaxLength(32);

                entity.Property(e => e.TransferImportantInfo)
                    .HasColumnName("Transfer_ImportantInfo")
                    .HasColumnType("ntext");

                entity.Property(e => e.TransferInfants).HasColumnName("Transfer_Infants");

                entity.Property(e => e.TransferNetCost)
                    .HasColumnName("Transfer_NetCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.TransferNote)
                    .HasColumnName("Transfer_Note")
                    .HasColumnType("ntext");

                entity.Property(e => e.TransferOrigin)
                    .HasColumnName("Transfer_Origin")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TransferPaidDate)
                    .HasColumnName("Transfer_PaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransferPwd)
                    .IsRequired()
                    .HasColumnName("Transfer_Pwd")
                    .HasMaxLength(32);

                entity.Property(e => e.TransferRefNo)
                    .IsRequired()
                    .HasColumnName("Transfer_RefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.TransferRetArrDate)
                    .HasColumnName("Transfer_Ret_ArrDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransferRetArrTime)
                    .HasColumnName("Transfer_Ret_ArrTime")
                    .HasMaxLength(16);

                entity.Property(e => e.TransferRetDepDate)
                    .HasColumnName("Transfer_Ret_DepDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransferRetDepTime)
                    .HasColumnName("Transfer_Ret_DepTime")
                    .HasMaxLength(16);

                entity.Property(e => e.TransferSpecialRequest)
                    .HasColumnName("Transfer_SpecialRequest")
                    .HasColumnType("ntext");

                entity.Property(e => e.TransferStatus)
                    .HasColumnName("Transfer_Status")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TransferSupplierPaidDate)
                    .HasColumnName("Transfer_SupplierPaidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TransferSupplierRefNo)
                    .HasColumnName("Transfer_SupplierRefNo")
                    .HasMaxLength(32);

                entity.Property(e => e.TransferTotalCost)
                    .HasColumnName("Transfer_TotalCost")
                    .HasColumnType("numeric(14, 4)");

                entity.Property(e => e.TransferTotalPaid)
                    .HasColumnName("Transfer_TotalPaid")
                    .HasColumnType("numeric(14, 4)");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.TransferAgency)
                    .HasForeignKey(d => d.AgencyId)
                    .HasConstraintName("FK__Transfer__Agency__76B698BF");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.Transfer)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK__Transfer__Bookin__75C27486");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Transfer)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Transfer__Person__77AABCF8");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TransferSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK__Transfer__Suppli__789EE131");
            });

            modelBuilder.Entity<Translate>(entity =>
            {
                entity.Property(e => e.TranslateId)
                    .HasColumnName("Translate_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TranslateAdded)
                    .HasColumnName("Translate_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TranslateDe)
                    .HasColumnName("Translate_DE")
                    .HasMaxLength(256);

                entity.Property(e => e.TranslateEl)
                    .HasColumnName("Translate_EL")
                    .HasMaxLength(256);

                entity.Property(e => e.TranslateEn)
                    .IsRequired()
                    .HasColumnName("Translate_EN")
                    .HasMaxLength(256);

                entity.Property(e => e.TranslateEs)
                    .HasColumnName("Translate_ES")
                    .HasMaxLength(256);

                entity.Property(e => e.TranslateFr)
                    .HasColumnName("Translate_FR")
                    .HasMaxLength(256);

                entity.Property(e => e.TranslateGr)
                    .HasColumnName("Translate_GR")
                    .HasMaxLength(512);

                entity.Property(e => e.TranslateIt)
                    .HasColumnName("Translate_IT")
                    .HasMaxLength(256);

                entity.Property(e => e.TranslateRu)
                    .HasColumnName("Translate_RU")
                    .HasMaxLength(256);

                entity.Property(e => e.TranslateUk)
                    .HasColumnName("Translate_UK")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Ttcountry>(entity =>
            {
                entity.ToTable("TTCountry");

                entity.Property(e => e.TtcountryId)
                    .HasColumnName("TTCountry_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TtcountryAdded)
                    .HasColumnName("TTCountry_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TtcountryKey)
                    .HasColumnName("TTCountry_Key")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TtcountryName)
                    .IsRequired()
                    .HasColumnName("TTCountry_Name")
                    .HasMaxLength(128);

                entity.Property(e => e.TtcountryNameLat)
                    .IsRequired()
                    .HasColumnName("TTCountry_NameLat")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Tthotel>(entity =>
            {
                entity.ToTable("TTHotel");

                entity.Property(e => e.TthotelId)
                    .HasColumnName("TTHotel_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HotelId)
                    .HasColumnName("Hotel_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TthotelAdded)
                    .HasColumnName("TTHotel_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TthotelCityKey)
                    .HasColumnName("TTHotel_CityKey")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TthotelCountryKey)
                    .HasColumnName("TTHotel_CountryKey")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TthotelDesc)
                    .HasColumnName("TTHotel_Desc")
                    .HasColumnType("ntext");

                entity.Property(e => e.TthotelDesc1)
                    .HasColumnName("TTHotel_Desc1")
                    .HasColumnType("ntext");

                entity.Property(e => e.TthotelDescId)
                    .HasColumnName("TTHotel_Desc_ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TthotelImg1Local)
                    .HasColumnName("TTHotel_Img1Local")
                    .HasMaxLength(256);

                entity.Property(e => e.TthotelImg2Local)
                    .HasColumnName("TTHotel_Img2Local")
                    .HasMaxLength(256);

                entity.Property(e => e.TthotelImg3Local)
                    .HasColumnName("TTHotel_Img3Local")
                    .HasMaxLength(256);

                entity.Property(e => e.TthotelKey)
                    .HasColumnName("TTHotel_Key")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TthotelName)
                    .IsRequired()
                    .HasColumnName("TTHotel_Name")
                    .HasMaxLength(128);

                entity.Property(e => e.TthotelNameMl)
                    .HasColumnName("TTHotel_Name_ML")
                    .HasMaxLength(128);

                entity.Property(e => e.TthotelResortKey)
                    .HasColumnName("TTHotel_ResortKey")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TthotelStars).HasColumnName("TTHotel_Stars");

                entity.Property(e => e.TthotelStarsName)
                    .HasColumnName("TTHotel_StarsName")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Ttresort>(entity =>
            {
                entity.ToTable("TTResort");

                entity.Property(e => e.TtresortId)
                    .HasColumnName("TTResort_ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TtresortAdded)
                    .HasColumnName("TTResort_Added")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TtresortCountryKey)
                    .HasColumnName("TTResort_CountryKey")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TtresortKey)
                    .HasColumnName("TTResort_Key")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TtresortName)
                    .IsRequired()
                    .HasColumnName("TTResort_Name")
                    .HasMaxLength(128);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
