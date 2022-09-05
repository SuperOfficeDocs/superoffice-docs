---
title: Services84.ConfigurationAgent.GetApplicationConfiguration SOAP
generated: 1
uid: Services84-Configuration-GetApplicationConfiguration
---

# Services84 Configuration GetApplicationConfiguration

SOAP request and response examples **Remote/Services84/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IConfigurationAgent.GetApplicationConfiguration">SuperOffice.Services84.IConfigurationAgent.GetApplicationConfiguration</see> method.

## GetApplicationConfiguration

Return the application configuration. This is a list of pages, with information about the name, main panel and preference mappings of each page.

* **application:** The application name, for instance 'SixWeb'
* **instance:** The instance name for the application, like 'MainInstance'

**Returns:** XML structure containing the application configuration


[WSDL file for Services84/Configuration](../Services84-Configuration.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetApplicationConfiguration Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:GetApplicationConfiguration>
    <Configuration:Application xsi:type="xsd:string"></Configuration:Application>
    <Configuration:Instance xsi:type="xsd:string"></Configuration:Instance>
   </Configuration:GetApplicationConfiguration>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetApplicationConfiguration Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Configuration:GetApplicationConfigurationResponse>
   <Configuration:Response xsi:type="xsd:string"></Configuration:Response>
  </Configuration:GetApplicationConfigurationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

