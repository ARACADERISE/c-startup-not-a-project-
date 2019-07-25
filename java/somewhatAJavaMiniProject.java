package somewhatAJavaMiniProject;

public class somewhatAJavaMiniProject {
  
  private static String name_type;
  private static String return_type;
  private static final int data_bytes_allowed = 365;
  
  public void get_name_type(String type_) {
    if(type_ > this.data_bytes_allowed) {
      System.out.println("Error: Bytes Overload")
    } else {
      this.name_type = type_;
    }
  }
  
  abstract class thisWillBeOverriden {
    public int returnAmountOfBytes();
  }
  
  enum typeOf {
    STRING,
    INT,
    CHAR,
    FLOAT,
    DOUBLE
  }
  
  public void getType(String type) {
    switch(type) {
      case "STRING":
        typeOf.STRING;
        this.return_type = "STRING";
        break;
      case "INT":
        typeOf.INT;
        this.return_type = "INT";
        break;
      case "CHAR":
        typeOf.CHAR;
        this.return_type = "CHAR";
        break;
      case "DOUBLE":
        typeOf.DOUBLE;
        this.return_type = "DOUBLE";
        break;
      default:
        System.out.println("No type");
        this.return_type = null;
        break;
    }
  }
  
  public static void main(String[] args) {
    somewhatAJavaMiniProject overRideThis = new somewhatAJavaMiniProject();
    overRideThis.thisWillBeOverriden() {
      @Override
      public int returnAmountOfBytes() {
        return this.data_bytes_allowed;
      }
    };
    overRideThis.returnAmountOfBytes();
    overRideThis.get_name_type();
    overRideThis.getType("STRING");
  } 
}
