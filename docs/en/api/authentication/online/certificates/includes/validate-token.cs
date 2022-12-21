public SuperIdToken ValidateToken(string token)
{
  var tokenHandler = new SuperIdTokenHandler();
  tokenHandler.JwtIssuerSigningCertificate = new X509Certificate2(
    HttpContext.Current.Server.MapPath("~/App_Data/") + "SuperOfficeFederatedLogin.crt"
  );
  // Change subdomain for correct environment (sod, stage, online).
  tokenHandler.ValidIssuer = "https://sod.superoffice.com";
  tokenHandler.CertificateValidator = X509CertificateValidator.None;
  return tokenHandler.ValidateToken(token, TokenType.Jwt);
}