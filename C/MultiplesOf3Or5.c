int solution(int number) {
	int retVal=0;
  
  for(int i=0; i<number;i++){
     if(i%3==0 && i%5==0){
       retVal+=i;
     }
     else if(i%3==0||i%5==0){
     retVal+=i;
     }
  }
    return retVal;
}