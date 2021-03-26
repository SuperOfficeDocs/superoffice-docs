---
uid: services85-configuration-getcrmurl
title: Services85.ConfigurationAgent.GetCRMUrl SOAP
Generated: true
---

# Services85 Configuration GetCRMUrl SOAP

SOAP request and response examples **Remote/Services85/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IConfigurationAgent.GetCRMUrl">SuperOffice.Services85.IConfigurationAgent.GetCRMUrl</see> method.

## GetCRMUrl





[WSDL file for Services85/Configuration](../Services85-Configuration.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCRMUrl Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:GetCRMUrl>
    <Configuration:SoProtocol xsi:type="xsd:string"></Configuration:SoProtocol>
    <Configuration:Currents xsi:type="xsd:string"></Configuration:Currents>
    <Configuration:Frameless xsi:type="xsd:boolean">false</Configuration:Frameless>
   </Configuration:GetCRMUrl>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCRMUrl Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Configuration:GetCRMUrlResponse>
   <Configuration:Response xsi:type="xsd:string"></Configuration:Response>
  </Configuration:GetCRMUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

