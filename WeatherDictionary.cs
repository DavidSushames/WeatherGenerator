using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Generation
{
    public static class WeatherDictionary
    {
        public static readonly Dictionary<string, string> weatherDict = new Dictionary<string, string>
        {
            {"Triple1", "DISASTERY 1 BLIZZARD"},
            {"Triple2", "DISASTERY 2 RAZOR HAIL"},
            {"Triple3", "DISASTERY 3 ELECTRIC STORM"},
            {"Triple4", "DISASTERY 4 BLINDING FOG"},
            {"Triple5", "DISASTERY 5 HURRICANE"},
            {"Triple6", "DISASTERY 6 SHARKNADO"},

            {"LoLoLoDo", "Cold Dry Still Danger"},
            {"LoLoLo", "Cold Dry Still"},
            {"LoLoMiDo", "Cold Dry Calm Danger"},
            {"LoLoMi", "Cold Dry Calm"},
            {"LoLoHiDo", "Cold Dry Wind Danger"},
            {"LoLoHi", "Cold Dry Wind"},

            {"LoMiLoDo", "Cold Damp Still Danger"},
            {"LoMiLo", "Cold Damp Still"},
            {"LoMiMiDo", "Cold Damp Calm Danger"},
            {"LoMiMi", "Cold Damp Calm"},
            {"LoMiHiDo", "Cold Damp Wind Danger"},
            {"LoMiHi", "Cold Damp Wind"},

            {"LoHiLoDo", "Cold Wet Still Danger"},
            {"LoHiLo", "Cold Wet Still"},
            {"LoHiMiDo", "Cold Wet Calm Danger"},
            {"LoHiMi", "Cold Wet Calm"},
            {"LoHiHiDo", "Cold Wet Wind Danger"},
            {"LoHiHi", "Cold Wet Wind"},

            {"MiLoLoDo", "Tepid Dry Still Danger"},
            {"MiLoLo", "Tepid Dry Still"},
            {"MiLoMiDo", "Tepid Dry Calm Danger"},
            {"MiLoMi", "Tepid Dry Calm"},
            {"MiLoHiDo", "Tepid Dry Wind Danger"},
            {"MiLoHi", "Tepid Dry Wind"},

            {"MiMiLoDo", "Tepid Damp Still Danger"},
            {"MiMiLo", "Tepid Damp Still"},
            {"MiMiMiDo", "Tepid Damp Still Danger"},
            {"MiMiMi", "Tepid Damp Still"},
            {"MiMiHiDo", "Tepid Damp Wind Danger"},
            {"MiMiHi", "Tepid Damp Wind"},

            {"MiHiLoDo", "Tepid Wet Still Danger"},
            {"MiHiLo", "Tepid Wet Still"},
            {"MiHiMiDo", "Tepid Wet Calm Danger"},
            {"MiHiMi", "Tepid Wet Calm"},
            {"MiHiHiDo", "Tepid Wet Wind Danger"},
            {"MiHiHi", "Tepid Wet Wind"},

            {"HiLoLoDo", "Hot Dry Still Danger"},
            {"HiLoLo", "Hot Dry Still"},
            {"HiLoMiDo", "Hot Dry Calm Danger"},
            {"HiLoMi", "Hot Dry Calm"},
            {"HiLoHiDo", "Hot Dry Wind Danger"},
            {"HiLoHi", "Hot Dry Wind"},

            {"HiMiLoDo", "Hot Damp Still Danger"},
            {"HiMiLo", "Hot Damp Still"},
            {"HiMiMiDo", "Hot Damp Calm Danger"},
            {"HiMiMi", "Hot Damp Calm"},
            {"HiMiHiDo", "Hot Damp Wind Danger"},
            {"HiMiHi", "Hot Damp Wind"},

            {"HiHiLoDo", "Hot Wet Still Danger"},
            {"HiHiLo", "Hot Wet Still"},
            {"HiHiMiDo", "Hot Wet Calm Danger"},
            {"HiHiMi", "Hot Wet Calm"},
            {"HiHiHiDo", "Hot Wet Wind Danger"},
            {"HiHiHi", "Hot Wet Wind"}
        };
    }
}