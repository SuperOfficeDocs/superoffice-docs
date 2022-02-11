public ActionResult Index(string state, string code)
{
  // Callback 1 in authorization flow
  if (state != null && code != null)
  {
    try
    {
      var storedState = Session["state"] as string;
      if (storedState != state)
        throw new Exception("OAuth State mismatch.");
      OAuthHelper.GetAuthorizationCode(Server, Session, code);
      return RedirectToAction("Index", "App");
    }
    catch( Exception ex)
    {
      object model = ex.Message;
      return View(model);
    }
  }
  // Something is wrong, start over
  object error = "Unknown callback request. Missing state and/or code.";
  return View( error );
}