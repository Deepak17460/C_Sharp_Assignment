//Dynamic Polymorphism
//Runtime Polymorphism

//Method Overridding
class Deepak{
    //Method
    public void deepak(){
        Console.WriteLine("Deepak is Studying");
    }
}
class Deepu : Deepak{
     public void deepak(){
        Console.WriteLine("Deepak is  not Studying");
    }
    // Main Method
    public static void Main(string[] args){
        //Creating the Object
        Deepu Mydeepak=new Deepu();
        Mydeepak.deepak();
    }
}
