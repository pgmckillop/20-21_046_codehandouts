using System;
using System.Collections.Generic;
using System.Text;

/*
 * Title:   DataSummary
 * Author:  Paul McKillop
 * Date:    November 2020
 * Purpose: Hold data transferred to summary page
 */

namespace FlooringCalculator.Models
{
    public class DataSummary
    {
        public string WholeRoomArea { get; set; }
        public string Cutout1Area { get; set; }
        public string Cutout2Area { get; set; }
        public string TileSizeUsed { get; set; }
        public string TilesNeededForRoom { get; set; }
        public string LeftoverTileArea { get; set; }
        public string PerimeterLength { get; set; }

        /// <summary>
        /// Create a formatted string of all required data
        /// </summary>
        /// <returns>string</returns>
        public string SummaryForDisplay()
        {
            var sb = new StringBuilder();


            sb.Append("Whole Room Area: ").Append(WholeRoomArea).Append(" sq m").AppendLine();
            sb.Append("Cutout 1 Area: ").Append(Cutout1Area).Append(" sq m").AppendLine();
            sb.Append("Cutout 2 Area: ").Append(Cutout2Area).Append(" sq m").AppendLine();
            sb.AppendLine();
            sb.Append("Tile size calculated: ").Append(TileSizeUsed).AppendLine();
            sb.Append("Tiles needed for Room: ").Append(TilesNeededForRoom).AppendLine();
            sb.Append("Area of tile left over: ").Append(LeftoverTileArea).Append(" sq m").AppendLine();
            sb.AppendLine();
            sb.Append("Edging strip needed: ").Append(PerimeterLength).Append(" m").AppendLine();
            
            return sb.ToString();

        }
    }
}
