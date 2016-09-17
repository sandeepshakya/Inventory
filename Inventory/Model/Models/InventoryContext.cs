using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Model.Models.Mapping;

namespace Model.Models
{
    public partial class InventoryContext : DbContext
    {
        static InventoryContext()
        {
            Database.SetInitializer<InventoryContext>(null);
        }

        public InventoryContext()
            : base("Name=InventoryContext")
        {
            // These Lines are used to handled performance of EF State and materialization.
            this.Configuration.AutoDetectChangesEnabled = false; //Changes are not tracked in DB
            this.Configuration.ProxyCreationEnabled = false; //No un neccessary names as prefix for e.g. _________XCXCDFDFE then class name 
            this.Configuration.LazyLoadingEnabled = false; // Only required database tables.
        }

        public DbSet<AttributeValue> AttributeValues { get; set; }
        public DbSet<AutoCustomID> AutoCustomIDs { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyGroup> CompanyGroups { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductLocation> ProductLocations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductUnit> ProductUnits { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchasePayment> PurchasePayments { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesPayment> SalesPayments { get; set; }
        public DbSet<SalesQuotation> SalesQuotations { get; set; }
        public DbSet<SalesReceipt> SalesReceipts { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SysAdmin> SysAdmins { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AttributeValueMap());
            modelBuilder.Configurations.Add(new AutoCustomIDMap());
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new CompanyGroupMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new GroupUserMap());
            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new ProductAttributeMap());
            modelBuilder.Configurations.Add(new ProductCategoryMap());
            modelBuilder.Configurations.Add(new ProductLocationMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductUnitMap());
            modelBuilder.Configurations.Add(new PurchaseOrderMap());
            modelBuilder.Configurations.Add(new PurchasePaymentMap());
            modelBuilder.Configurations.Add(new SalesOrderMap());
            modelBuilder.Configurations.Add(new SalesPaymentMap());
            modelBuilder.Configurations.Add(new SalesQuotationMap());
            modelBuilder.Configurations.Add(new SalesReceiptMap());
            modelBuilder.Configurations.Add(new SubCategoryMap());
            modelBuilder.Configurations.Add(new SysAdminMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new VendorMap());
        }
    }
}
