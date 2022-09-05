---
title: Services86.ConfigurationAgent.GetAnyConfiguration SOAP
generated: 1
uid: Services86-Configuration-GetAnyConfiguration
---

# Services86 Configuration GetAnyConfiguration

SOAP request and response examples **Remote/Services86/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IConfigurationAgent.GetAnyConfiguration">SuperOffice.Services86.IConfigurationAgent.GetAnyConfiguration</see> method.

## GetAnyConfiguration

Get one defined configuration fragment, with full reference resolution and parsing applied. This is essentially the same service as the GetPageConfiguration, except that this service is not locked to objects of type Page.

* **application:** The application name, for instance Six.Web
* **instance:** The instance name, for instance Main
* **item:** The configuration item name (first component of file name)
* **type:** The configuration item type (second component of file name)

**Returns:** Fully resolved and parsed configuration XML, as string.


[WSDL file for Services86/Configuration](../Services86-Configuration.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAnyConfiguration Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:GetAnyConfiguration>
    <Configuration:Application xsi:type="xsd:string"></Configuration:Application>
    <Configuration:Instance xsi:type="xsd:string"></Configuration:Instance>
    <Configuration:Item xsi:type="xsd:string"></Configuration:Item>
    <Configuration:Type xsi:type="xsd:string"></Configuration:Type>
   </Configuration:GetAnyConfiguration>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAnyConfiguration Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Configuration:GetAnyConfigurationResponse>
   <Configuration:Response xsi:type="xsd:string"></Configuration:Response>
  </Configuration:GetAnyConfigurationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

