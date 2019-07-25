package tryCatch;

public class tryCatch {
  public static void main(String[] args) {
    try {
      String[] n = new String[2];
      System.out.println(n[5]);
  } catch(Exception e) {
      System.out.println("Error");
    }
  }
}
