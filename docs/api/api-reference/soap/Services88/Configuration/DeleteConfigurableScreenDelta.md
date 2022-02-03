---
title: Services88.ConfigurationAgent.DeleteConfigurableScreenDelta SOAP
generated: 1
uid: Services88-Configuration-DeleteConfigurableScreenDelta
---

# Services88 Configuration DeleteConfigurableScreenDelta

SOAP request and response examples **Remote/Services88/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IConfigurationAgent.DeleteConfigurableScreenDelta">SuperOffice.Services88.IConfigurationAgent.DeleteConfigurableScreenDelta</see> method.

## DeleteConfigurableScreenDelta

Deletes the ConfigurableScreenDelta

* **configurableScreenDeltaId:** The identity of the ConfigurableScreenDelta



[WSDL file for Services88/Configuration](../Services88-Configuration.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteConfigurableScreenDelta Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:DeleteConfigurableScreenDelta>
    <Configuration:ConfigurableScreenDeltaId xsi:type="xsd:int">0</Configuration:ConfigurableScreenDeltaId>
   </Configuration:DeleteConfigurableScreenDelta>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteConfigurableScreenDelta Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Configuration:DeleteConfigurableScreenDeltaResponse>
  </Configuration:DeleteConfigurableScreenDeltaResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

