using System;
public class lib1 {
   static public string rev(string a) {
     string b = "";
            for (int i = a.Length-1; i >= 0; i--) 
            {
              b += a[i] ;
            }    
            return b;
  }
}