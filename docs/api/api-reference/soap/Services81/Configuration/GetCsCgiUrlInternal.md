---
uid: services81-configuration-getcscgiurlinternal
title: Services81.ConfigurationAgent.GetCsCgiUrlInternal SOAP
Generated: true
---

# Services81 Configuration GetCsCgiUrlInternal SOAP

SOAP request and response examples **Remote/Services81/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IConfigurationAgent.GetCsCgiUrlInternal">SuperOffice.Services81.IConfigurationAgent.GetCsCgiUrlInternal</see> method.

## GetCsCgiUrlInternal

This method will get the host name for CS


**Returns:** Will get the host name for where CS is installed


[WSDL file for Services81/Configuration](../Services81-Configuration.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCsCgiUrlInternal Request

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
   <Configuration:GetCsCgiUrlInternal>
   </Configuration:GetCsCgiUrlInternal>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCsCgiUrlInternal Response

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
  <Configuration:GetCsCgiUrlInternalResponse>
   <Configuration:Response xsi:type="xsd:string"></Configuration:Response>
  </Configuration:GetCsCgiUrlInternalResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

