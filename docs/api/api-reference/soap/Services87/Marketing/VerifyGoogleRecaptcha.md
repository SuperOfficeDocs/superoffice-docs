---
uid: services87-marketing-verifygooglerecaptcha
title: Services87.MarketingAgent.VerifyGoogleRecaptcha SOAP
Generated: true
---

# Services87 Marketing VerifyGoogleRecaptcha SOAP

SOAP request and response examples **Remote/Services87/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IMarketingAgent.VerifyGoogleRecaptcha">SuperOffice.Services87.IMarketingAgent.VerifyGoogleRecaptcha</see> method.

## VerifyGoogleRecaptcha

This method will try to verify a Google recaptcha token. The token is gained from the recaptcha frontend component

* **token:** The token to be verified
* **optionalSecretKey:** Use an optional secret key instead of the system wide

**Returns:** Returns true if the recaptcha token verified successfully


[WSDL file for Services87/Marketing](../Services87-Marketing.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## VerifyGoogleRecaptcha Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Marketing:ApplicationToken>1234567-1234-9876</Marketing:ApplicationToken>
  <Marketing:Credentials>
    <Marketing:Ticket>7T:1234abcxyzExample==</Marketing:Ticket>
  </Marketing:Credentials>
 <SOAP-ENV:Body>
   <Marketing:VerifyGoogleRecaptcha>
    <Marketing:Token xsi:type="xsd:string"></Marketing:Token>
    <Marketing:OptionalSecretKey xsi:type="xsd:string"></Marketing:OptionalSecretKey>
   </Marketing:VerifyGoogleRecaptcha>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## VerifyGoogleRecaptcha Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Marketing:VerifyGoogleRecaptchaResponse>
   <Marketing:Response xsi:type="xsd:boolean">false</Marketing:Response>
  </Marketing:VerifyGoogleRecaptchaResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

