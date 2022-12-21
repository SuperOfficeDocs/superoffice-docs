public static string CalculateCredentialsSecret(SoAuthenticationType authenticationType, int days, params string[] arguments)
{
  string secret = null;
  MemoryStream ms = new MemoryStream();
  StreamWriter sw = new StreamWriter(ms, System.Text.Encoding.UTF8);

  //The Authentication type enum as string, e.g. "CRM5"
  sw.Write(authenticationType.ToString());
  foreach (string argument in arguments)
    sw.Write(argument);
  sw.Write(days.ToString());

  //Clears all buffers for the current writer
  sw.Flush();
  int length = (int)ms.Position;
  sw.Close();
  MD5 md5 = MD5.Create();
  byte[] hash = md5.ComputeHash(ms.GetBuffer(), 0, length);
  secret = Convert.ToBase64String(hash);

  //Closes the stream for reading and writing
  ms.Close();
  return secret;
}

public static int GetDays()
{
  return (int)((TimeSpan)(DateTime.UtcNow - new DateTime(2000, 1, 1))).TotalDays;
}