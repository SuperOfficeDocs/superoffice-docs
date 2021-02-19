SuperIdToken ValidateToken(HttpServerUtilityBase server, string token)
{
  var path = server.MapPath("~/App_Data/") +"SOD_SuperOfficeFederatedLogin.crt";

  var tokenHandler = new SuperIdTokenHandler();
  tokenHandler.JwtIssuerSigningCertificate = new X509Certificate2(path);
  tokenHandler.CertificateValidator = X509CertificateValidator.ChainTrust;

  // override issuer name with environment name
  tokenHandler.ValidIssuer = "https://sod.superoffice.com";

  return tokenHandler.ValidateToken(token, TokenType.Jwt);
}