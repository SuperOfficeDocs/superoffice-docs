```php
class SystemUserHelper
{
   /*
   * Sign system token from callback and authenticate it with the SuperID service
   *
   * return system user token from SuperID service
   */
   public static function GetSystemUserToken($returnTokenType) {
      $context = SessionHelper::getSoContext();

      //get private key and its path is configured in setting.php
      $privateKey = openssl_pkey_get_private(file_get_contents(PRIVATE_KEY), KEYPASSWORD);

      //SuperOffice signed format
      $signThis = ($context->SystemToken).".".date("YmdHi");

      //sign the system token using private key of the application
      openssl_sign($signThis, $signature, $privateKey, OPENSSL_ALGO_SHA256);

      //instantiate the agent to the SuperID endpoint path, NOT the tenant.
      $agent = new SystemUserAgent(LOGIN_PATH, APPTOKEN, $context->ContextIdentifier);

      //return a new JWT or SAML token containing the system user ticket
      return $agent->AuthenticateSystemUser($signThis.".".base64_encode($signature), $returnTokenType);
   }
}
```