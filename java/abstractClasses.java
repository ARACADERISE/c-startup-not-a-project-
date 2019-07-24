package abstractClasses;
/*
* An abstract class is a class that just assigns
* a subclass
*/

// Example of a Abstract
abstract class abstractClasses {
  // You can have assignments
  public static String name;
  
  // Sub-classes
  public void aSubClass() {
    System.out.println("Hello " + this.name);
  }
}
