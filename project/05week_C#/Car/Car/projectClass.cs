using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{

    internal class Car
    {
        public int Id { get; }
        public string CarNum { get; }
        public string Type { get; set; }
        public bool Static { get; set; }
        public double Price { get; set; }

        public Car(int Id, string CarNum, string Type, bool Static, double Price)
        {
            this.Id = Id;
            this.CarNum = CarNum;
            this.Type = Type;
            this.Static = Static;
            this.Price = Price;

        }
    }


    internal class User
    {
        public int Id { get; }
        public string Name { get; set; }
        public string IdCard { get; }
        public string RegTime { get; }
        public string Gender { get; set; }
        public string phoneNo { get; set; }
        public string Motto { get; set; }
        public User(int Id, string Name, string IdCard, string RegTime, string Gender, string phoneNo, string Motto)
        {
            this.Id = Id;
            this.Name = Name;
            this.IdCard = IdCard;
            this.RegTime = RegTime;
            this.Gender = Gender;
            this.phoneNo = phoneNo;
            this.Motto = Motto;


        }
    }


            internal class RRCar
            {
                public int Id { get; set; }
                public int CarId { get; set; }
                public int UserId { get; set; }
                public string RentTime { get; set; }
                public string ReturnTime { get; set; }
                public double PayMoney { get; set; }
                public RRCar(int Id, int CarId, int UserId, string RentTime, string ReturnTime, string phoneNo, double PayMoney)
                {
                    this.Id = Id;
                    this.CarId = CarId;
                    this.UserId = UserId;
                    this.RentTime = RentTime;
                    this.ReturnTime = ReturnTime;
                    this.PayMoney = PayMoney;


                }


            }
       
    
}












    

