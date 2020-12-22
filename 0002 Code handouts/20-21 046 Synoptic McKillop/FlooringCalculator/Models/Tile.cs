using System;
using System.Collections.Generic;
using System.Text;

/*
 * Title:   Tile
 * Author:  Paul McKillop
 * Date:    November 2020
 * Purpose: Class to manage tile data
 */

namespace FlooringCalculator.Models
{
    public class Tile
    {
        // -- Data member fields
        private decimal tileWide;

        public decimal TileWide
        {
            get => tileWide;
            set => tileWide = value;
        }

        private decimal tileLong;

        public decimal TileLong
        {
            get => tileLong;
            set => tileLong = value;
        }


        // -- This is a derived property from existing properties
        private string tileName;

        public string TileName
        {
            get => tileName;
            set => tileName = tileWide + "x" + tileLong;
        }

        /// <summary>
        /// Returns the area of a Tile
        /// </summary>
        /// <param name="tile"></param>
        /// <returns>decimal of area of one Tile</returns>
        public static decimal TileArea(Tile tile)
        {
            return tile.tileLong * tile.tileWide;
        }
    }
}
