using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FishKnow.Model;
using FishKnow.ViewModel;
using FishKnow.View;
namespace FishKnow.Model
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
