using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProvinceCities.Models;

namespace ProvinceCities.Data;

public static class SeedData {
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }
    public static List<Province> GetProvinces() {
        List<Province> provinces = new List<Province>() {
            new Province() {    // 1
                ProvinceCode="BC",
                ProvinceName="British Columbia",
            },
            new Province() {    //2
                ProvinceCode="AB",
                ProvinceName="Alberta",
            },
            new Province() {    // 3
                ProvinceCode="SA",
                ProvinceName="Saskatchewan",
            },
            new Province() {    // 4
                ProvinceCode="MB",
                ProvinceName="Manitoba",
            },
            new Province() {    // 5
                ProvinceCode="ON",
                ProvinceName="Ontario",
            },
            new Province() {    // 6
                ProvinceCode="QC",
                ProvinceName="Quebec",
            },

        };

        return provinces;
    }

    public static List<City> GetCities() {
        List<City> cities = new List<City>() {
            new City {
                CityId = 1,
                CityName = "Vancouver",
                Population = 660000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 2,
                CityName = "Burnaby",
                Population = 250000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 3,
                CityName = "Surrey",
                Population = 570000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 4,
                CityName = "Victoria",
                Population = 92000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 5,
                CityName = "Calgary",
                Population = 1300000,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 6,
                CityName = "Edmonton",
                Population = 970000,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 7,
                CityName = "Red Deer",
                Population = 100000,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 8,
                CityName = "Toronto",
                Population = 3000000,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 9,
                CityName = "Ottawa",
                Population = 880000,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 10,
                CityName = "Windsor",
                Population = 220000,
                ProvinceCode = "ON"
            },
            new City {
                CityId = 11,
                CityName = "Quebec City",
                Population = 520000,
                ProvinceCode = "QC"
            },
            new City {
                CityId = 12,
                CityName = "Montreal",
                Population = 1800000,
                ProvinceCode = "QC"
            },
            new City {
                CityId = 13,
                CityName = "Gatineau",
                Population = 290000,
                ProvinceCode = "QC"
            },
        };

        return cities;
    }
}
