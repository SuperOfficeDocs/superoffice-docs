void StoreTokensInSession(HttpServer server, HttpSession session, TokensResponse tokens)
{
  // Validate JWT token
  var superIdToken = ValidateToken(server, tokens.id_token);
  if (superIdToken == null)
      throw new Exception("Invalid JWT token: " + tokens.id_token );

  // Store tokens
  session["LoggedIn"] = tokens.access_token;
  session["RefreshToken"] = tokens.refresh_token;
  session["Expires"] = DateTime.Now.AddSeconds(tokens.expires_in);
  session["Token"] = superIdToken;
  session["NetServerUrl"] = superIdToken.NetserverUrl;
}