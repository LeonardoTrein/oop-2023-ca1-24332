using System;
namespace ca1_oop_24332.sln
{
    public class ParkingGarage
    {
        public ParkingGarage()
        {


        private double minimumFee = 2.0;
        private double additionalFeeG1 = 0.5;
        private double additionalFeeG2 = 0.6;
        private double additionalFeeG3 = 0.75;
        private double maxCharge = 10.00;
        private double totalHours = 0;


        private double garage1Total = 0;
        private double garage2Total = 0;
        private double garage3Total = 0;

        private double allgarage = 0;


        public ParkingGarage(double totalHours)
        {
            totalHours = totalHours;
        }

        public double calculateCharges()
        {

            if (totalHours <= 3)
            {
                allgarage = minimumFee;

            }
            else if (totalHours > 3 && totalHours < 19)
            {
                allgarage = minimumFee + ((totalHours - 3) * (additionalFeeG1 + additionalFeeG2 + additionalFeeG3);

            }
            else
            {

                allgarage = maxCharge;
            }

            return allgarage;
        }

    }


