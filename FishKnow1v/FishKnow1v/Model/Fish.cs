using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FishKnow1v.Model;
using FishKnow1v.ViewModel;
using FishKnow1v.View;
namespace FishKnow1v.Model
{
   public class Fish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Morpho { get; set; }
        public string Origin { get; set; }
        public string Feeding { get; set; }
        public Uri Image { get; set; }
    }
}
