namespace Dealership.Src.Entities
{
    public class Vehicle
    {

        //declaring the variables

        public string Brand;
        public string Model;
        public int Year;
        public string Color;
        public double Price;
        public int Kms;

        //creating a contructor, which will force to receive the informations below when the Veiculo Class be instantiated.
        public Vehicle(string Brand, string Model, int Year, string Color, double Price)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Year = Year;
            this.Color = Color;
            this.Price = Price;
            this.Kms = 0;
        }

        //Adding a tax if price be equal or bigger than 40000.00
        //The "virtual" word is to enable the overriding on the child class 
        public virtual double Tax(){
            if(this.Price >= 40000.00)
            {
                return (this.Price * 0.1);
            }
            else
            {
                return 00.00;
            }
        }


        //overriding ToString() method in order to show the variables below instead the namespace.classname

        public override string ToString()
        {
            return ($"\n Car Brand: {this.Brand}\n Model: {this.Model}\n Year: {this.Year}\n Color: {this.Color}\n Kms: {this.Kms}\n Price in cash: {this.Price}\n Installment Tax: {Tax()}\n Final Price: {this.Price + Tax()}\n");
        }
    }
}