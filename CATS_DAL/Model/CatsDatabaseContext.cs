using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CATS_DAL.Model
{
    public class CatsDatabaseContext:DbContext
    {
        //public CatsDatabaseContext() :base (@"Password=1p2U3n4K2010;Persist Security Info=True;User ID=sa;Initial Catalog=CATS_2012;Data Source=LUKE_LAPTOP\SQLEXPRESS"){}
            //base("name=CatsConnectionString") { }

        public CatsDatabaseContext() : base("CATS")
        {
            
        }

        public IDbSet<Operator> Operators { get; set; }
        public IDbSet<Vehicle> Vehicles { get; set; }
        public IDbSet<RecordStatusValues> RecordStatusValuese { get; set; }
        public IDbSet<SiteTypeValues> SiteTypeValues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<CatsDatabaseContext>(null);

            //base.OnModelCreating(modelBuilder);
            
//            modelBuilder.Entity<Operator>()
//                        .HasKey(p => p.OperatorId)
//                        .Property(p => p.OperatorId)
//                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
