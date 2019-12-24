﻿namespace CarSale.CodeChallenge.Database.EntityModel
{
    public class Vehicle : VehicleBase
    {
        public int NoOfWeels { get; set; }
        public int NoOfDoors { get; set; }
        public string Engine { get; set; }
        public string BodyType { get; set; }

    }
}
