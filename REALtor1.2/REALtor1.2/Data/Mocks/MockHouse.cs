using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REALtor1._2.Data.Interfaces;
using REALtor1._2.Data.Models;

namespace REALtor1._2.Data.Mocks
{
    public class MockHouse : IAllHouses
    {
        private readonly IAllPerson _housesSeller = new MockPerson();
        public IEnumerable<House> Houses
        {
            get
            {
                return new List<House>
                {
                    new House
                    {
                        id = 1,
                        Address = "ул. Счастливая д.3 кв.22",
                        Area = "Индустриальный",
                        Available = true,
                        Condition = new House.Conditions { hotWater = true, coldWater = true, electricity = true, gas = true },
                        CountOfRooms = 3,
                        Despription = "Прекрасная трехкомнатная квартира на 2 этаже ЖК Улыбка, рядом детский сад, школа, гипермаркет Пятерочка, 10 минут до остановок общественного транспорта",
                        Img="/img/house1.jpg",
                        Name = "ЖК Улыбка",
                        Price = 3000000,
                        Square = 61.2,
                        StatusOfHome = "Новостройка",
                        Seller=_housesSeller.AllPeople.First()
                    },
                    new House
                    {
                        id = 2,
                        Address = "ул. Пушкина д.12 кв.24",
                        Area = "Октябрьский",
                        Available = true,
                        Condition = new House.Conditions { hotWater = true, coldWater = true, electricity = true, gas = true },
                        CountOfRooms = 1,
                        Despription = "Уютная однокомнатная квартира, в шаговой доступности остановкки общественного транспорта, гипермаркет Магнит, санаторий Ласточка",
                        Img="/img/house2.jpg",
                        Name = "Квартира на ул.Пушкина",
                        Price = 1200000,
                        Square = 32,
                        StatusOfHome = "Многоэтажный дом советстких времен",
                        Seller=_housesSeller.AllPeople.ElementAt(1)
                    },
                    new House
                    {
                        id = 3,
                        Address = "ул. Карла Маркса д.45",
                        Area = "Первомайский",
                        Available = true,
                        Condition = new House.Conditions { hotWater = true, coldWater = true, electricity = true, gas = false },
                        CountOfRooms = 6,
                        Despription = "Двухэтажный, рядом детский сад, автобусная остановка. Просторный, недавно был ремонт",
                        Img="/img/house3.jpg",
                        Name = "Частный двухэтажный дом на ул. Карла Маркса",
                        Price = 5500000,
                        Square = 97.6,
                        StatusOfHome = "Частный дом",
                        Seller=_housesSeller.AllPeople.ElementAt(5)
                    },
                    new House
                    {
                        id = 4,
                        Address = "ул. Петровская д.10 кв.42",
                        Area = "Индустриальный",
                        Available = false,
                        Condition = new House.Conditions { hotWater = true, coldWater = true, electricity = true, gas = true },
                        CountOfRooms = 4,
                        Despription = "Квартира на 5 этаже для большой семьи, рядом детский сад, школа, университет, больница, библиотека, 20 минут пешком от остановок общественного транспорта",
                        Img="/img/house4.jpg",
                        Name = "ЖК Петр",
                        Price = 4100000,
                        Square = 72.2,
                        StatusOfHome = "Новостройка",
                        Seller=_housesSeller.AllPeople.ElementAt(5)
                    },
                    new House
                    {
                        id = 5,
                        Address = "ул. Лесная р.2 №23",
                        Area = "Первомайский",
                        Available = true,
                        Condition = new House.Conditions { hotWater = false, coldWater = false, electricity = true, gas = false },
                        CountOfRooms = 1,
                        Despription = "Отапливаемый, въезд/выезд без наклона, уверенно вмещает легковой автомобиль средних габаритов",
                        Img="/img/house5.jpg",
                        Name = "Гараж на ул.Лесная",
                        Price = 160000,
                        Square = 22,
                        StatusOfHome = "Гаражное помещение",
                        Seller=_housesSeller.AllPeople.ElementAt(1)
                    },
                    new House
                    {
                        id = 6,
                        Address = "ул. Заводская д.9",
                        Area = "Октябрьский",
                        Available = true,
                        Condition = new House.Conditions { hotWater = true, coldWater = true, electricity = true, gas = false },
                        CountOfRooms = 4,
                        Despription = "Старый деревянный дом, обшит сайдингом, 2 минут до остановок общественного транспорта, больница, санаторий, подойдет для людей с ограниченным бюджетом, газ отсутствует",
                        Img="/img/house6.jpg",
                        Name = "Дом на ул. Заводская",
                        Price = 400000,
                        Square = 55.1,
                        StatusOfHome = "Старый ветхий дом",
                        Seller=_housesSeller.AllPeople.ElementAt(5)
                    },
                };
            }
        }
        public IEnumerable<House> GetAvailableHouses { get; set; }

        public House getObjectHouse(int id)
        {
            throw new NotImplementedException();
        }
    }
}
