---
uid: services80-configuration-gethelpdispatcherurl
title: Services80.ConfigurationAgent.GetHelpDispatcherUrl SOAP
Generated: true
---

# Services80 Configuration GetHelpDispatcherUrl SOAP

SOAP request and response examples **Remote/Services80/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IConfigurationAgent.GetHelpDispatcherUrl">SuperOffice.Services80.IConfigurationAgent.GetHelpDispatcherUrl</see> method.

## GetHelpDispatcherUrl

Will get the GetHelpDispatcherUrl used by the help system


**Returns:** URL to be used by the help system


[WSDL file for Services80/Configuration](../Services80-Configuration.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetHelpDispatcherUrl Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:GetHelpDispatcherUrl>
   </Configuration:GetHelpDispatcherUrl>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetHelpDispatcherUrl Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Configuration:GetHelpDispatcherUrlResponse>
   <Configuration:Response xsi:type="xsd:string"></Configuration:Response>
  </Configuration:GetHelpDispatcherUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

