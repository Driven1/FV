using System;

namespace Foodvaultwpf
{	
    public class recipe
        {
            public string NAME { get; set; }
            public int CALORIES { get; set; }
            public int TTC { get; set; } // time to cook
            public int COST { get; set; }
            public string PREP { get; set; }
            public string INGS { get; set; }

        }
}
