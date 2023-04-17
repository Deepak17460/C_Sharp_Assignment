
//In Encapsulation, We can make our class WriteOnly and ReadOnly

class Price{
     int price=10;
    // public void SetPrice(int p){
    //     this.price=p;
    // }
    // public void GetPrice(){
    //     Console.WriteLine("The price is:"+price);
    // }
    public int PriceS{
        set{
            price=value;
        }
        get{
            return price;
        }
    }
}

class program{
     public static void Main(string[] args){
         //Creating the object
         Price P=new Price();
       //  P.price=20;
         // P.SetPrice(20);
         // P.GetPrice();
         //P.PriceS=20;
         Console.WriteLine("The price is:"+(P.PriceS));
     }
}
