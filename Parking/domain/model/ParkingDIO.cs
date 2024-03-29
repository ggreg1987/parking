
namespace Parking.domain.model
{
    public class ParkingDIO
    {
        private double _price;
        private double _pricePerHour;

        private string? _plateCar;

        public ParkingDIO() { }

        public ParkingDIO(double price, string plateCar)
        {
            this._price = price;
            this._plateCar = plateCar;

        }

        public ParkingDIO(double price,double pricePerHour, string plateCar)
        {
            this._price = price;
            this._plateCar = plateCar;
            this._pricePerHour = pricePerHour;

        }

        public void SetPrice(double price)
        {
            this._price = price;
        }

        public double GetPrice()
        {
            return this._price;
        }

        public void SetPricePerHour(double pricePerHour)
        {
            this._pricePerHour = pricePerHour;
        }

        public double GetPricePerHour()
        {
            return this._pricePerHour;
        }

        public void SetPlateCar(string placeCar)
        {
            this._plateCar = placeCar.ToUpper();
        }

        public string? GetPlateCar()
        {
            return this._plateCar;
        }

        public override string ToString()
        {
            
            return $"Plate Car: {_plateCar} \nFixed Price: {_price}\n";

        }

    }
}