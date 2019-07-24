import pract.pract;
import abstractClasses.abstractClasses;

public class _another_one extends pract implements abstractClasses {
  public _another_one() {
    
    // NAME is assigned protected so I can assign it a value without having to say this or pass a argument
    NAME = "Aidan";
  }
  public static void main(String[] args) {
    _another_one name_is = new _another_one();
    name_is.returnName();
    
    // Now we use that abstracted class
    abstractClasses assign = new abstractClasses() {
      @Override public String aSubClass(String n) {
        this.name = n;
        System.out.println("Heyo " + this.name.toUpperCase());
        return "Done";
      };
      assign.aSubClass("Aidan");
    }
  }
}
