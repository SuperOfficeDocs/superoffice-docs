string RefreshAcessToken()
{
  try
  {
    string refresh_token = Session["RefreshToken"] as string;
    OAuthHelper.GetRefreshToken(Server, Session, refresh_token);
    return null;
  }
  catch (Exception ex)
  {
    return ex.Message; 
  }
}