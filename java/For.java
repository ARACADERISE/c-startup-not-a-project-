package For;

public class For {
  public void doTheF(int a) {
    //One way of writing a for loop
    for(int b = 0; b < a; b ++) {
      System.out.println(b);
    }
    //Here is another way
    for(;a < 100;a+=2) {
      System.out.println(a);
    }
    //The third way
    for(;a<100;) {
      System.out.println(a);
      a+=4
    }
  }
  
  public static void main(String[] args) {
    doTheF num = new doTheF(10);
  }
}
