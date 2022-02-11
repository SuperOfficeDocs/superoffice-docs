```javascript
{
"issuer": "https://sod.superoffice.com",
"authorization_endpoint": "https://sod.superoffice.com/login/common/oauth/authorize",
"token_endpoint": "https://sod.superoffice.com/login/common/oauth/tokens",
"jwks_uri": "https://sod.superoffice.com/login/.well-known/jwks",
"scopes_supported": [
  "openid"
],
"response_modes_supported": [
  "form_post",
  "fragment",
  "query"
],
"response_types_supported": [
  "code",
  "id_token",
  "code id_token",
  "token id_token",
  "token"
],
"subject_types_supported": [
  "public"
],
"id_token_signing_alg_values_supported": [
  "RS256"
],
"token_endpoint_auth_methods_supported": [
  "client_secret_post",
  "client_secret_basic"
],
"grant_types_supported": [
  "implicit",
  "authorization_code",
  "refresh_token"
],
}
```