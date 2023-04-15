
class deepak{
    //Properties
    internal string name;
    internal  char level;
    internal int age;
    internal void DeepakDetails(){
        Console.WriteLine("My name is:"+name);
        Console.WriteLine("My level is:"+level);
        Console.WriteLine("My age is:"+age);
    }
    // public static void Main(string[] args){
    //     //Creating the Object
    //     deepak Mydeepak=new deepak();
    //     Mydeepak.name="Deepak";
    //     Mydeepak.level='A';
    //     Mydeepak.age=20;
    //     Mydeepak.DeepakDetails();
    // }
}
class Deepak : deepak{
      int familymembers;
       public void details(){
           Console.WriteLine("Total Family Members are:"+familymembers);
       }
     public static void Main(string[] args){
        //Creating the Object
         Deepak MyFamily=new Deepak();
       // deepak Mydeepak=new deepak();
         MyFamily.name="Deepak";
         MyFamily.level='A';
         MyFamily.age=20;
         MyFamily.familymembers=12;
         MyFamily.DeepakDetails();
         MyFamily.details();
     }
         
}
