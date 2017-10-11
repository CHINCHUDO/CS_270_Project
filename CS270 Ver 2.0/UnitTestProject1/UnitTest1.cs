using Xunit;
using System;

namespace UnitTestProject1
{
    public class CustomerTest
    {
        [Fact]
        public void TestSearchCustomer()
        {

        }

        [Fact]
        public void TestAddCustomer()
        {

        }

        [Fact]
        public void TestEditCustomer()
        {

        }

        [Fact]
        public void TestDeleteCustomer()
        {

        }
    }

    public class CargoPlaneTest
    {

        [Fact]
        public void TestAddCargoPlane()
        {

        }

        [Fact]
        public void TestEditCargoPlane()
        {

        }

        [Fact]
        public void TestDeleteCargoPlane()
        {

        }

        [Fact]
        public void TestSearchCargoPlane()
        {
            // List of flights
            List<Flight> flights = new List<Flight>();
            var flightNumber = "Delta 0007";

            flights.Add(new Flight(flightNumber));
            flights.Add(new Flight("Delta 0008"));


            FlightSearch flightSearch = new FlightSearch(flights);
            Flight flight = flightSearch.byFlightNumber(flightNumber);


            Xunit.Assert.Equal(flight.flightNumber, flightNumber);
        }

        [Fact]
        public void TestScheduleCargoPlane()
        {

        }
    }
}
