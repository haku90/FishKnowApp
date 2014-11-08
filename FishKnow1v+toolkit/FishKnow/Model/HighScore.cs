using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using Microsoft.Phone.Data.Linq.Mapping;
using System.Data.Linq;
namespace FishKnow.Model
{
    public class HighScoreDataContext:DataContext
    {
        public static string DBConnectionString = @"isostore:/Database.sdf";
        public HighScoreDataContext(string connString) : base(connString) { }
        public Table<HighScore> HighScores
        {
            get
            {
                return this.GetTable<HighScore>();
            }
        }
    }

   [Table]
  public  class HighScore
    {
       [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity")]
       public int ID { get; set; }
      
       [Column] public String NameFish { get; set; }
       [Column]public string Score { get; set; }
       [Column]public DateTime Date { get; set; }

      

    }
}
