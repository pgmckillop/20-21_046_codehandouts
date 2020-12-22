using System;
using System.Collections.Generic;
using System.Text;

/*
 * Title:   RoomAreas
 * Author:  Paul McKillop
 * Date:    November 2020
 * Purpose: Method only class to carry out core calculations
 */

namespace FlooringCalculator.Models
{
    public class RoomAreas
    {
        // -- Data members for the class
        
        private decimal areaCutoutOne;

        public decimal AreaCutoutOne
        {
            get => areaCutoutOne;
            set => areaCutoutOne = value;
        }


        private decimal areaCutoutTwo;

        public decimal AreaCutoutTwo
        {
            get => areaCutoutTwo;
            set => areaCutoutTwo = value;
        }

        // -- methods

        /// <summary>
        /// Calculates room perimeter
        /// </summary>
        /// <param name="room"></param>
        /// <returns>decimal of value</returns>
        public static decimal RoomPerimeter(Room room)
        {
            return (room.RoomWide * 2 + room.RoomLong * 2) - (room.Cutout1Wide + room.Cutout1Long + room.Cutout2Wide + room.Cutout2Long);
        }

        public static decimal AreaCutout1(Room room)
        {
            return room.Cutout1Wide * room.Cutout1Long;
        }

        public static decimal AreaCutout2(Room room)
        {
            return room.Cutout2Wide * room.Cutout2Long;
        }


        protected void Cutout1Area(Room room)
        {
            areaCutoutOne = room.Cutout1Wide * room.Cutout1Long;
        }

        /// <summary>
        /// Area Cutout 2 - Encapsulated method
        /// </summary>
        /// <param name="room"></param>
        /// <returns>decimal area two</returns>
        protected void Cutout2Area(Room room)
        {
            areaCutoutTwo = room.Cutout2Wide * room.Cutout2Long;
        }

        public static decimal WholeAreaCutouts(Room room)
        {

            var areaOne = room.Cutout1Wide * room.Cutout1Long;
            var areaTwo = room.Cutout2Wide * room.Cutout2Long;

            return areaOne + areaTwo;
        }

        /// <summary>
        /// Whole room not removing cutout areas
        /// </summary>
        /// <param name="room"></param>
        /// <returns>decimal of area</returns>
        public static decimal WholeRoomArea(Room room)
        {
            return room.RoomWide * room.RoomLong;
        }

    }
}
