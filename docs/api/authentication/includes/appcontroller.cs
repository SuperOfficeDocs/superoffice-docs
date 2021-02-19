public class AppController : Controller
{
  RestClient _client = new RestClient();

  // GET: App - must be logged in to access this
  public ActionResult Index()
  {
    // Are we logged in?
    if (Session["LoggedIn"] == null)
      return RedirectToAction("Index", "Home");

    // Do we need to refresh access token?
    string error = null;
    DateTime expiryDate = (DateTime)Session["Expires"];
    if (expiryDate < DateTime.Now)
      error = RefreshAcessToken();

    string accessToken = Session["LoggedIn"] as string;
    string baseUrl = Session["NetServerUrl"] as string; // https://xxx.yyy/api

    var model = GetDataFromSuperOffice(baseUrl, accessToken);
    model.TimeLeft = expiryDate - DateTime.Now;
    model.Error = error;

    return View(model);
  }
}