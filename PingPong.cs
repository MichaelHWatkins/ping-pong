using System;

namespace ChristopherWalkin {

  public class Player
  {
    public void pingPong(int userInput){
      for(int I = 1; I <= userInput; I++){
        Console.WriteLine(checkInput(I));
      }
    }
    public string checkInput(int numericalInput){
      if(numericalInput % 15 == 0){
        return "Ping Pong";
      }

      if(numericalInput % 5 == 0){
        return "Pong";
      }

      if(numericalInput % 3 == 0){
        return "Ping";
      }
      else{
        return numericalInput.ToString();
      }
    }
  }
}