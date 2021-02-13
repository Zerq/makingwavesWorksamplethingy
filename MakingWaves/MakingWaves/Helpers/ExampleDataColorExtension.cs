using MakingWaves.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakingWaves.Helpers
{
    public static class ExampleDataColorExtension
    {
        public static string ContrastColor(this ExampleData model) {

            var red = int.Parse(model.Color.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
            var Green = int.Parse(model.Color.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
            var blue = int.Parse(model.Color.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);

            //https://en.wikipedia.org/wiki/Rec._709
            var luma = (0.2126 * red) + (0.7152 * Green) + (0.0722 * blue);

            if (luma >= 165)
            {
                return "#000000";
            }
            else
            {
                return "#ffffff";
            }
        }

    }
}
