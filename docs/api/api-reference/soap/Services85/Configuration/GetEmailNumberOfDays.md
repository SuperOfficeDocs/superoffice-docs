---
uid: services85-configuration-getemailnumberofdays
title: Services85.ConfigurationAgent.GetEmailNumberOfDays SOAP
Generated: true
---

# Services85 Configuration GetEmailNumberOfDays SOAP

SOAP request and response examples **Remote/Services85/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IConfigurationAgent.GetEmailNumberOfDays">SuperOffice.Services85.IConfigurationAgent.GetEmailNumberOfDays</see> method.

## GetEmailNumberOfDays




**Returns:** Number of days in the past for which we are fetching email


[WSDL file for Services85/Configuration](../Services85-Configuration.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetEmailNumberOfDays Request

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
   <Configuration:GetEmailNumberOfDays>
   </Configuration:GetEmailNumberOfDays>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetEmailNumberOfDays Response

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
  <Configuration:GetEmailNumberOfDaysResponse>
   <Configuration:Response xsi:type="xsd:int">0</Configuration:Response>
  </Configuration:GetEmailNumberOfDaysResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

