using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using REALtor.Data.Models;

namespace REALtor.Data
{
    public class DbObjects
    {
        public static void Initial(DbContent content)
        {
            if (!content.House.Any())
            {
                content.AddRange(
                    new House
                    {
                        Name = "ЖК Капитал",
                        CountOfRooms = 4,
                        Area = "Октябрьский район",
                        Price = 1000000,
                        Address = "ул. Карла Маркса д.52, кв.33",
                        Available = true,
                        Square = 96.2,
                        Img ="/img/house3.jpeg",
                        Seller = new Person{id=1,Fio = { Name="James"} }

                    },
                    new House
                    {
                        Name = "ЖК Морской",
                        CountOfRooms = 4,
                        Area = "Октябрьский район",
                        Price = 123000,
                        Address = "ул. Крылова д.5, кв.2",
                        Available = true,
                        Square = 104.2,
                        Img ="/img/house4.jpeg",
                        Seller = new Person{ id = 2, Fio = { Name = "James2" } }
                    },
                    new House
                    {
                        Name = "Дом на ул. Цветочная",
                        CountOfRooms = 3,
                        Area = "Октябрьский район",
                        Price = 1005000,
                        Address = "ул. Цветочная, д.12",
                        Available = true,
                        Square = 36.5,
                        Img="/img/house1.jpg",
                        Seller = new Person{ id = 3, Fio = { Name = "James3" } }
                    }
                    ) ;
            }
            content.SaveChanges();
        }
    }
}
