---
title: Scenarios
uid: minimal_php_app_scenarios
description: Scenarios
author: SuperOffice Product and Engineering
keywords:
content_type: tutorial
deployment: online
platform: web
---

# Scenarios

These scenarios walk you through the [nuSoapSample][1] code and what happens when you run the sample.

These sequence diagrams were built using an online resource `www.websequencediagrams.com`. The text used to generate these diagrams is located at the end of this document.

## Create a new company as the current application user

The following diagram describes how the first link works, how to create a company using the signed-in user account.

![x][img1]

There are several helper classes to make things easier and are described in subsequent sections of this document.

## Create a new company as a system user

The following diagram describes how create a company using the [system user token][2]. The key thing to understand here is that the system user token is not a usable credential. It is used in exchange for a system user ticket. The system user ticket is the usable credential for passing into web service methods.

![x][img2]

As stated before, there are several helper classes to make things easier. An important one is the `SystemUserHelper` class. It's used to look up the current user context, get the stored system user token, sign the token, call the tenant service and it returns a server signed token containing claims.

The web application must then validated the new server token, then extract the system user ticket.

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

The application must validate the new JWT token using the public SuperOffice certificates. Once validated as an authentic token, the application uses another helper class, **ClaimNames**, to convert the token into an SoContext class – containing properties such as name, company, ticket, and NetServerUrl.

With the new **SoContext** available, containing the ticket credentials for a system user, the application proceeds to call the **ContactEnitityHelper** to create a new company.

```php
if($_GET['systemUser'] == 1) {
   //use system user to create a contactEntity

   //exchange system user token for a JWT/SAML token contains system user ticket
   $returnedToken = SystemUserHelper::GetSystemUserToken(ENABLE_SAML ? "Saml":"Jwt");

   //validate the returned token using SuperOffice public certificates
   if(ENABLE_SAML) {
      require_once('./lib/SoSAML.php');
      $data = SoSAML::decode($returnedToken, PUBLIC_CERTIFICATE);
   } else {
      require_once "./lib/SoJWT.php";
      $data = SoJWT::decode($returnedToken, PUBLIC_CERTIFICATE);
   }

   //extract the claims in the token and cast then to a SoContext class
   if($data != null){
      $context = ClaimNames::ConvertToSoContext($data);
   } else {
      $url = UrlHelper::getBaseUrl().'welcome.php';
      header("Location: $url");
   }

   //using the system user ticket to create a new company
   $contact = ContactEntityHelper::CreateContactEntity($context->NetServerUrl, $context->Ticket, APPTOKEN);

   //view the company details on the contactEntity.php page.
   $id = $contact['ContactId'];
   header("Location: contactEntity.php?contactEntityId=$id");
}
```

## More advanced scenario

This sequence represents a common scenario where a service exists that communicates with a tenant on a revolving interval.

1. User navigates to the partner application.
2. User is not authenticated for access to SuperOffice functionality and is therefore redirected.
3. User is redirected to SuperID with client ID for authentication.
4. User is successfully authenticated and redirected to the partner applications redirect URL.
5. Partner application receives SuperID request and JWT token. Validated using certificates.
6. Partner application processes or configures user and stored system user token in the database.
7. Partner service polls database for new tenant user tokens.
8. Partner service signs user token with its private key and sends it to SuperID for exchange of system user ticket.
9. Partner service validates system user token using certificates.
10. Partner service calls tenant web services using a system user ticket.

![x][img3]

<!-- Referenced links -->
[1]: overview.md
[2]: ../../authentication/online/auth-application/index.md

<!-- Referenced images -->
[img1]: media/image005.png
[img2]: media/image007.png
[img3]: media/image009.png
