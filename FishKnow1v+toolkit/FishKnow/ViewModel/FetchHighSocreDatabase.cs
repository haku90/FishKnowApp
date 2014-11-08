using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishKnow.Model;
namespace FishKnow.ViewModel
{
    class HigScoreIn
    {
        public static int cnt = 0;
        public int id { get; set; }
        public string name { get; set; }
        public string score { get; set; }
        public DateTime date { get; set; }

    }
    class FetchHighSocreDatabase
    {
        
        public IList<HighScore> GetAllhs()
        {
            IList<HighScore> list = null;
            using (HighScoreDataContext context = new HighScoreDataContext(HighScoreDataContext.DBConnectionString))
            {
                IQueryable<HighScore> query = from c in context.HighScores select c;
                list = query.ToList();
            }
            return list;
        }
        public List<HigScoreIn> geths()
        {
            IList<HighScore> hs = this.GetAllhs();
            List<HigScoreIn> allhs=new List<HigScoreIn>();
            foreach (HighScore m in hs)
	        {
		        HigScoreIn n= new HigScoreIn();
                n.id = m.ID;
                n.name=m.NameFish;
                n.score = m.Score;
                n.date=m.Date;
                allhs.Add(n);
	        }
            return allhs;
        }
    }
}
