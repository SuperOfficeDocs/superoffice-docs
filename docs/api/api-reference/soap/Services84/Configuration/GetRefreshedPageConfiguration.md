---
uid: services84-configuration-getrefreshedpageconfiguration
title: Services84.ConfigurationAgent.GetRefreshedPageConfiguration SOAP
Generated: true
---

# Services84 Configuration GetRefreshedPageConfiguration SOAP

SOAP request and response examples **Remote/Services84/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IConfigurationAgent.GetRefreshedPageConfiguration">SuperOffice.Services84.IConfigurationAgent.GetRefreshedPageConfiguration</see> method.

## GetRefreshedPageConfiguration

Get the configuration for one whole web page, including all its panels etc.  totally asynchronous items like menus are not included, but all references are resolved and all special processing is applied. Does not use cache for fetching, but updates the cache with refreshed configuration.

* **application:** The application name, for instance 'SixWeb
* **instance:** The instance name for the application, like 'MainInstance'
* **page:** Page name, must correspond to one of the pages in the Application Configuration

**Returns:** XML containing the configuration for the given page, from the page down to the control level.


[WSDL file for Services84/Configuration](../Services84-Configuration.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetRefreshedPageConfiguration Request

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
   <Configuration:GetRefreshedPageConfiguration>
    <Configuration:Application xsi:type="xsd:string"></Configuration:Application>
    <Configuration:Instance xsi:type="xsd:string"></Configuration:Instance>
    <Configuration:Page xsi:type="xsd:string"></Configuration:Page>
   </Configuration:GetRefreshedPageConfiguration>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetRefreshedPageConfiguration Response

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
  <Configuration:GetRefreshedPageConfigurationResponse>
   <Configuration:Response xsi:type="xsd:string"></Configuration:Response>
  </Configuration:GetRefreshedPageConfigurationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

