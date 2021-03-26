---
uid: services81-configuration-getcsauthurl
title: Services81.ConfigurationAgent.GetCSAuthUrl SOAP
Generated: true
---

# Services81 Configuration GetCSAuthUrl SOAP

SOAP request and response examples **Remote/Services81/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IConfigurationAgent.GetCSAuthUrl">SuperOffice.Services81.IConfigurationAgent.GetCSAuthUrl</see> method.

## GetCSAuthUrl

Will generate an url to the emarketing module

* **language:** By setting this parameter, you can change the CS language for the current user.
* **programName:** In this parameter you must specify which CS program you want to create an URL for. Valid examples are "ticket", "rms", "spm" etc.
* **action:** Here you can optionally specify the action for the current program. This will enable you to go to a specific screen.
* **extraParameters:** If an action is specified, you can specify extra parameters here. This can be used to set specific behaviour for the chosen screen/action. If an empty action is supplied, this parameter will be ignored.

**Returns:** Returns a valid CS URL composed of the give parameters.


[WSDL file for Services81/Configuration](../Services81-Configuration.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCSAuthUrl Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:GetCSAuthUrl>
    <Configuration:Language xsi:type="xsd:string"></Configuration:Language>
    <Configuration:ProgramName xsi:type="xsd:string"></Configuration:ProgramName>
    <Configuration:Action xsi:type="xsd:string"></Configuration:Action>
    <Configuration:ExtraParameters xsi:type="xsd:string"></Configuration:ExtraParameters>
   </Configuration:GetCSAuthUrl>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCSAuthUrl Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Configuration:GetCSAuthUrlResponse>
   <Configuration:Response xsi:type="xsd:string"></Configuration:Response>
  </Configuration:GetCSAuthUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

