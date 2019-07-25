package enuM;

public class enuM {
  enum NAME {
    NAME_TYPE,
    NAME_DATA
  }
  
  public void getName extends NAME {
    public getName() {
      enuM en = new enuM.NAME_TYPE;
      
      switch(en) {
        case NAME_TYPE:
          System.out.println("String");
          break;
        case NAME_DATA:
          System.out.println("ARACADERISE");
      }
    }
  }
  
  public static void main(String[] args) {
    getName name = new getName(); 
  }
}
