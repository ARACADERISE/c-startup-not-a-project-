package doWhile;

public class doWhile {
  public void doTheDo(int theNumberWeAreDoing) {
    do {
      System.out.println("Number " + theNumberWeAreDoing + " is not dead yet");
      if(theNumberWeAreDoing == 400) {
        System.out.println("The number " + theNumberWeAreDoing + " is dead");
      }
      theNumberWeAreDoing+=10;
    } while(theNumberWeAreDoing < 400);
  }
  
  public static void main(String[] args) {
    doTheDo numberWillBe = new doTheDo(250); 
  }
}
