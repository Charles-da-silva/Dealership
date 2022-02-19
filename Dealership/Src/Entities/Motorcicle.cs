namespace Dealership.Src.Entities
{
    ////Child class from the Vehicle parent class

    public class Motorcicle : Vehicle
    {
        public int EngineCapacity { get; set; }

        public Motorcicle(string Brand, string Model, int Year, string Color, double Price, int EngineCapacity) : base(Brand, Model, Year, Color, Price)
        {
            this.EngineCapacity = EngineCapacity;
        }

        //overrinding the Tax method from parent class
        public override double Tax(){
            if(this.Price >= 25000.00)
            {
                return (this.Price * 0.1);
            }
            else
            {
                return 00.00;
            }
        }


        public override string ToString()
        {
            return ($"\n Motorcicle Brand: {this.Brand}\n Model: {this.Model}\n Year: {this.Year}\n Color: {this.Color}\n Engine Capacity: {this.EngineCapacity}\n Kms: {this.Kms}\n Price in cash: {this.Price}\n Installment Tax: {Tax()}\n Final Price: {this.Price + Tax()}\n");
        }
    }
}