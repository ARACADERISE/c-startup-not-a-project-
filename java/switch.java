package switch;

public class switch {
  public void doTheS(int aNum) {
    while(aNum < 10) {
      switch(aNum){
        case 5:
          System.out.println("It's " + aNum);
          while(aNum < 50) {
            System.out.println(aNum);
            aNum+=2;
          }
          break;
        case 10:
          System.out.println("It's " + aNum);
          while(aNum < 100) {
            System.out.println(aNum);
            aNum+=4;
          }
          break;
        default:
          System.out.println("It's " + aNum);
          while(aNum < 150) {
            System.out.println(aNum);
            aNum+=8;
          }
          break;
      }
    }
  }
  public static void main(String[] args) {
    doTheS doNum = new doTheS(50); 
  }
}
