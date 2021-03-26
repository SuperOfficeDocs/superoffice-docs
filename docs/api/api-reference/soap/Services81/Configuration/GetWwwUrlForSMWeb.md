---
uid: services81-configuration-getwwwurlforsmweb
title: Services81.ConfigurationAgent.GetWwwUrlForSMWeb SOAP
Generated: true
---

# Services81 Configuration GetWwwUrlForSMWeb SOAP

SOAP request and response examples **Remote/Services81/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IConfigurationAgent.GetWwwUrlForSMWeb">SuperOffice.Services81.IConfigurationAgent.GetWwwUrlForSMWeb</see> method.

## GetWwwUrlForSMWeb

Returns the URL used for the logo by the SM.web client. Uses urldispatch.aspx


**Returns:** Link to urldispatch.aspx tagged with [SOSITEURL]


[WSDL file for Services81/Configuration](../Services81-Configuration.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetWwwUrlForSMWeb Request

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
   <Configuration:GetWwwUrlForSMWeb>
   </Configuration:GetWwwUrlForSMWeb>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetWwwUrlForSMWeb Response

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
  <Configuration:GetWwwUrlForSMWebResponse>
   <Configuration:Response xsi:type="xsd:string"></Configuration:Response>
  </Configuration:GetWwwUrlForSMWebResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

