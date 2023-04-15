
class factorial{
      // void factorial(){
      //     Console.Write("It is Default Constructor");
      // }
     internal int fact(int num){
         // Base case
         if(num==0||num==1) return 1;
         return num*fact(num-1);
     }
    // public static void Main(){
    //     // Creating the object
    //     factorial Math=new factorial();
    //     //int num=int.Parse(Console.ReadLine())
    //     int num=Convert.ToInt32(Console.ReadLine());
    //     Console.Write("Factorial of {0} is: {1}",num,(Math.fact(num)));
    // }   
}
class Math :factorial{
       int price;
       Math(int p){
           //price=p;
           Console.WriteLine("the price is:"+price);
           //Console.WriteLine("It is Default Constructor");
       }
      public static void Main(){
          //Creating the Object
          Math Fact=new Math(4);
          int num=int.Parse(Console.ReadLine());
          Console.Write("Factorial of {0} is: {1}",num,(Fact.fact(num)));
      }
}
