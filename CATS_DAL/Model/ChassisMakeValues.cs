namespace CATS_DAL.Model
{
    public class ChassisMakeValues
    {
        public enum MyEnum
        {
            Daf = 1,
            Erf = 2,
            Foden = 3, 
            Ford = 4,
            Fso = 5, 
            Hino = 6, 
            Isuzu = 7, 
            Iveco = 8, 
            Ldv = 9,
            Man = 10,
            MercedesBenz = 11,
            Mitsubishi = 12,
            Renault = 13, 
            Scania = 14, 
            SeddonAtkinson = 15, 
            Volvo = 16,
            Dennis = 17,
            Daewoo = 18       
        }
        public virtual byte ChassisMakeId { get; set; }
        public string ChassisMake { get; set; }
    }
}
