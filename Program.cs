using System;

namespace Lab5_2_CarLot
{
    enum CarMake
    {
        Ford,
        Chevrolet,
        Chrysler,
        Honda,
        Toyota
    }

    class Car
    {
        protected CarMake Make;
        protected string Model;
        protected int Year;
        protected decimal Price;

        // Public Constructor
        public Car(CarMake _Make, string _Model, int _Year, decimal _Price)
        {
            Make = _Make;
            Model = _Model;
            Year = _Year;
            Price = _Price;
        }
    }

    class NewCar : Car
    {
        public bool ExtendedWarranty;
        public NewCar(CarMake _Make, string _Model, int _Year, decimal _Price, bool _ExtendedWarranty) : base(_Make, _Model, _Year, _Price,)
        {

            ExtendedWarranty = _ExtendedWarranty;
        }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}, Extended Warranty: {ExtendedWarranty}";
        }
    }

    class UsedCar : Car
    {
        public int NumberOfOwners;
        public int Mileage;

        public UsedCar(CarMake _Make, string _Model, int _Year, decimal _Price, int _NumberOfOwners, int _Mileage) : base(_Make, _Model, _Year, _Price)
        {
            NumberOfOwners = _NumberOfOwners;
            Mileage = _Mileage;
        }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}, Number of Owners: {NumberOfOwners}, Mileage: {Mileage}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
