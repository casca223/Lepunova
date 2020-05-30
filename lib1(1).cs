using System;
public class lib1 {
   static public string remov (string str, string a) {
for (int i = 0; i < a.Length; i++) {
  string b = a[i].ToString();
      str = str.Replace(b, "");
}
     return str;
  }
}