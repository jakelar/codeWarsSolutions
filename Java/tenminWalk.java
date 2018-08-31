
//Class To check if a walk takes 10 minutes
public class TenMinWalk {
  public static boolean isValid(char[] walk) {
	//north
    int n=0;
	//south
    int s=0;
    //east
	int e=0;
    //west
	int w=0;
	//for each char in walk increment each directional value
      for (char ch: walk){
        if (ch=='n'){n++;}
        if (ch=='s'){s++;}
        if (ch=='e'){e++;}
        if (ch=='w'){w++;}
      }
	  /*ince each walk takes 1 minute total walks must equal 10 and the difference of north/south and east/west must equal 
	   *to ensure you have arrived back at your origin. 
	   */
      if((n+s+e+w)==10 && (n-s)==0 && (w-e)==0) {
        return true;
      }          
  return false;
  }
}