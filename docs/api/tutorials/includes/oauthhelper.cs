public class OAuthHelper
{
  void GetAuthorizationCode(HttpServer server, HttpSession session, string code)
  {
    GetSuperIdTokens(server, session, code, null, "authorization_code");
  }

  void GetSuperIdTokens(HttpServer server, HttpSession session, string code, string refreshToken, string grant_type)
  {
    // Make new request from SuperID to get refresh token

    string appId = ConfigurationManager.AppSettings["SoAppId"];
    string appToken = ConfigurationManager.AppSettings["SoAppToken"];
    string appUrl = ConfigurationManager.AppSettings["SoAppUrl"];
    string url = ConfigurationManager.AppSettings["SoFederationGateway"];

    // Make the request from the server, since the secret appToken is used
    var client = new RestClient(url);
    var request = new RestRequest("common/oauth/tokens", Method.POST);
    request.AddParameter("client_id", appId);
    request.AddParameter("client_secret", appToken);
    if( code != null ) request.AddParameter("code", code);
    if( refreshToken!= null ) request.AddParameter("refresh_token", refreshToken);
    request.AddParameter("redirect_uri", appUrl);
    request.AddParameter("grant_type", grant_type);

    var response = client.Execute<TokensResponse>(request);
    if (response.IsSuccessful)
    {
      var tokens = response.Data;
      StoreTokensInSession(server, session, tokens).access_token, tokens.token_type, tokens.expires_in, tokens.refresh_token, tokens.id_token);
    }
  }
}