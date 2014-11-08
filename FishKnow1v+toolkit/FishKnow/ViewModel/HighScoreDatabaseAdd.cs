using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishKnow.Model;
using FishKnow.ViewModel;
namespace FishKnow.ViewModel
{
    class HighScoreDatabaseAdd
    {
        
        public void Addhs(string name,string score)
        {
            using (HighScoreDataContext context = new HighScoreDataContext(HighScoreDataContext.DBConnectionString))
            {
                HighScore hs = new HighScore();
                hs.NameFish = name;
                hs.Score = score;
                hs.ID = HigScoreIn.cnt++;
                hs.Date = DateTime.Now;
                context.HighScores.InsertOnSubmit(hs);
                context.SubmitChanges();
            }
        }
    }
}
