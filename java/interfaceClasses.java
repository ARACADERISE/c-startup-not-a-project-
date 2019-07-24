package interfaceClasses;

public class interfaceClasses {
  interface name() {
    public String getName(String r);
    public void sayName();
  }
  
  public static void main(String[] args) {
    // Now we will use it!
    interfaceClasses n = new interfaceClasses() {
      @Override public void sayName(String re) {
        System.out.println("Hello " + re);
      }
      @Override public void getName(String r) {
        return r.toUpperCase();
        sayName(r);
      };
      //This will, and should(if I am wrong tell me) print "Aidan". I do not have a IDE so I am going off of plain skill
      n.getName("Aidan");
    }
  }
}
