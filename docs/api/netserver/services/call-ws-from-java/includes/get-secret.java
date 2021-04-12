import java.io.UnsupportedEncodingException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.Date;
import java.util.GregorianCalendar;

import JavaApplication1.*;

import sun.misc.BASE64Encoder;

//Returns the Secrete base on the getBase64Code() method
public static String getSecret(String authenticationType, String username, String password) throws UnsupportedEncodingException, NoSuchAlgorithmException
{
  //Variable declaration and assignment
  String input = "";
  input += authenticationType;
  input += username;
  input += password;
  input += getDays();
  
  //Retrieves and returns the Secret
  return getBase64Code(input);
}

//Returns the date difference
private static long getDays()
{
  //Variable declaration and assignment
  Date date = new GregorianCalendar(2000, GregorianCalendar.JANUARY, 1).getTime();
  Date now = new Date();

  //Gets the date difference
  long span = now.getTime()-date.getTime();
  long days = span/1000/60/60/24;

  //Returns the date difference
  return days;
}

//Generates the Base64Code based on the BASE64Encoder class
private static String getBase64Code(String input) throws UnsupportedEncodingException, NoSuchAlgorithmException
{
  String base64 = "";

  byte[] txt = input.getBytes("UTF8");
  byte[] text = new byte[txt.length+3];

  text[0] = (byte)239;
  text[1] = (byte)187;
  text[2] = (byte)191;
  for(int i=0; i<txt.length; i++)
    text[i+3] = txt[i];

  MessageDigest md = MessageDigest.getInstance("MD5");
  md.update(text);
  byte digest[] = md.digest();
  BASE64Encoder encoder = new BASE64Encoder();
  base64 = encoder.encode(digest);

  return base64;
}