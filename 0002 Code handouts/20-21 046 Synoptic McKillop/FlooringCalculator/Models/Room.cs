

/*
 * Title:   Room
 * Author:  Paul McKillop
 * Date:    November 2020
 * Purpose: Class to manage room dimension data
 */

namespace FlooringCalculator.Models
{
    public class Room
    {
        public decimal RoomWide { get; set; }


        

        public decimal RoomLong { get; set; }

        private decimal cutout1Wide;

        public decimal Cutout1Wide
        {
            get => cutout1Wide;
            set => cutout1Wide = value;
        }
        /*
         *  private scope: encapsulated property.
         *  Used as a demonstration of technique. We don't really
         *  need an encapsulated property as we aren't doing anything with it
         *  that needs to be protected from outside access
         */
        private decimal cutout1Long;

        public decimal Cutout1Long
        {
            get => cutout1Long;
            set => cutout1Long = value;
        }

        private decimal cutout2Wide;

        public decimal Cutout2Wide
        {
            get => cutout2Wide;
            set => cutout2Wide = value;
        }

        private decimal cutout2Long;

        public decimal Cutout2Long
        {
            get => cutout2Long;
            set => cutout2Long = value;
        }


    }
}
