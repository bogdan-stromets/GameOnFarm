using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOnFarm
{
    struct AllForms
    {
        public static ChooseDifficult choose { get; set; }
        public static StartScreen start { get; set; }
        public static Stats stats { get; set; }
        public static Answers answ { get; set; }
        public static Game game { get; set; }
        public static Rules rules { get; set; }
    }
}
