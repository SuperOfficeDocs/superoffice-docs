---
uid: services86-configuration-clearconfigurationcache
title: Services86.ConfigurationAgent.ClearConfigurationCache SOAP
Generated: true
---

# Services86 Configuration ClearConfigurationCache SOAP

SOAP request and response examples **Remote/Services86/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IConfigurationAgent.ClearConfigurationCache">SuperOffice.Services86.IConfigurationAgent.ClearConfigurationCache</see> method.

## ClearConfigurationCache

Configuration XML's may be expensive to build and parse, and are therefore cached to the database. &lt;para/&gt;Cahcing is per application/instance/associate, and can be turned off through the config file. &lt;para/&gt;If caching is on, and the configuration is changed, it is necessary to clear the cached configurations from the database, through this call.&lt;para/&gt;Note that changes to the externalapplication table require cache invalidation. SoAdmin will do so automatically.

* **application:** The application name, for instance 'SixWeb'
* **instance:** The instance name for the application, like 'MainInstance'
* **forAllAssociates:** If false, only the current associate's configuration is cleared. If true, configurations are cleared for all associates.

**Returns:** There is no return value.


[WSDL file for Services86/Configuration](../Services86-Configuration.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ClearConfigurationCache Request

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
   <Configuration:ClearConfigurationCache>
    <Configuration:Application xsi:type="xsd:string"></Configuration:Application>
    <Configuration:Instance xsi:type="xsd:string"></Configuration:Instance>
    <Configuration:ForAllAssociates xsi:type="xsd:boolean">false</Configuration:ForAllAssociates>
   </Configuration:ClearConfigurationCache>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ClearConfigurationCache Response

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
  <Configuration:ClearConfigurationCacheResponse>
  </Configuration:ClearConfigurationCacheResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

