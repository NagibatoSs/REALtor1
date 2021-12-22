using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REALtor1._2.Data.Interfaces;
using REALtor1._2.Data.Models;

namespace REALtor1._2.Data.Mocks
{
    public class MockPerson : IAllPerson
    {
        public IEnumerable<Person> AllPeople
        {
            get
            {
                return new List<Person>
                {
                    new Person {id=1,Fio = new Person.FIO {Name="Петр",Surname="Шарапов",FatherName="Игоревич"},Email="sharapovP@mail.ru",NumberOfPhone="88005553535", Status="владелец"},
                    new Person {id=2,Fio = new Person.FIO {Name="Михаил",Surname="Григорьев",FatherName="Алексеевич"},Email="mihaDestroyer@mail.ru",NumberOfPhone="79139432323", Status="владелец"},
                    new Person {id=3,Fio = new Person.FIO {Name="Инга",Surname="Мирная",FatherName="Геннадьевна"},Email="inga@mail.ru",NumberOfPhone="89459342221", Status="покупатель"},
                    new Person {id=4,Fio = new Person.FIO {Name="Константин",Surname="Орлов",FatherName="Дмитриевич"},Email="orlov2012@mail.ru",NumberOfPhone="73452347712", Status="покупатель"},
                    new Person {id=5,Fio = new Person.FIO {Name="Алмаз",Surname="Ветров",FatherName="Тимурович"},Email="dimonDd@mail.ru",NumberOfPhone="89090657455", Status="покупатель"},
                    new Person {id=6,Fio = new Person.FIO {Name="Роза",Surname="Русских",FatherName="Викторовна"},Email="rozaMimoza@mail.ru",NumberOfPhone="84442341121", Status="владелец"}
                };
            }
        }

        public void createPerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
