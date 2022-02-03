```php
if($_GET['systemUser'] == 1) {
   //use system user to create a contactEntity

   //exchange system user token for a JWT/SAML token – contains system user ticket
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