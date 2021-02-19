// see if we have logged in
if (Session["LoggedIn"] == null)
{
  // Not logged in - go to login page
  string appId = ConfigurationManager.AppSettings["SoAppId"];
  string appUrl = ConfigurationManager.AppSettings["SoAppUrl"];
  string url = ConfigurationManager.AppSettings["SoFederationGateway"];
  string state = Guid.NewGuid().ToString();

  Session["state"] = state;

  var query = System.Web.HttpUtility.ParseQueryString(string.Empty);
  query.Add("client_id", appId);
  query.Add("redirect_url", appUrl);
  query.Add("scope", "openid");
  query.Add("state", state);
  query.Add("response_type", "code"); // authorization flow
  query.Add("response_mode", "form_data"); // instead of #fragment

  url += "/common/oauth/authorize?" + query.ToString();
  return Redirect(url);
}
else
  // Is logged in - go to App instead.
  return RedirectToAction("Index", "App");