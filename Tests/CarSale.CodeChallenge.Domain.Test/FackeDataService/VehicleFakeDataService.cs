﻿using CarSale.CodeChallenge.Database.EntityModel;
using CarSale.CodeChallenge.Database.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarSale.CodeChallenge.Domain.Test.FackeDataService
{
    public class VehicleFakeDataService : IVehicleDataService
    {
        private readonly List<Vehicle> _request;
        public VehicleFakeDataService()
        {
            _request = new List<Vehicle>()
            {
            };

        }

      public  int AddVehicle(Vehicle vehicle)
        {
            _request.Add(vehicle);
            return vehicle.Id;
        }
    }
}
