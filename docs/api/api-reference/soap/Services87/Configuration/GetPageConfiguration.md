---
uid: services87-configuration-getpageconfiguration
title: Services87.ConfigurationAgent.GetPageConfiguration SOAP
Generated: true
---

# Services87 Configuration GetPageConfiguration SOAP

SOAP request and response examples **Remote/Services87/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IConfigurationAgent.GetPageConfiguration">SuperOffice.Services87.IConfigurationAgent.GetPageConfiguration</see> method.

## GetPageConfiguration

Get the configuration for one whole web page, including all its panels etc.  totally asynchronous items like menus are not included, but all references are resolved and all special processing is applied.

* **application:** The application name, for instance 'SixWeb
* **instance:** The instance name for the application, like 'MainInstance'
* **page:** Page name, must correspond to one of the pages in the Application Configuration

**Returns:** XML containing the configuration for the given page, from the page down to the control level.


[WSDL file for Services87/Configuration](../Services87-Configuration.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPageConfiguration Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:GetPageConfiguration>
    <Configuration:Application xsi:type="xsd:string"></Configuration:Application>
    <Configuration:Instance xsi:type="xsd:string"></Configuration:Instance>
    <Configuration:Page xsi:type="xsd:string"></Configuration:Page>
   </Configuration:GetPageConfiguration>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPageConfiguration Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Configuration:GetPageConfigurationResponse>
   <Configuration:Response xsi:type="xsd:string"></Configuration:Response>
  </Configuration:GetPageConfigurationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

