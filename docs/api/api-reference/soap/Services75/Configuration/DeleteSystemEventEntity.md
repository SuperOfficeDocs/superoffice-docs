---
uid: services75-configuration-deletesystemevententity
title: Services75.ConfigurationAgent.DeleteSystemEventEntity SOAP
Generated: true
---

# Services75 Configuration DeleteSystemEventEntity SOAP

SOAP request and response examples **Remote/Services75/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IConfigurationAgent.DeleteSystemEventEntity">SuperOffice.Services75.IConfigurationAgent.DeleteSystemEventEntity</see> method.

## DeleteSystemEventEntity

Deletes the SystemEventEntity

* **systemEventEntityId:** The identity of the SystemEventEntity



[WSDL file for Services75/Configuration](../Services75-Configuration.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteSystemEventEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:DeleteSystemEventEntity>
    <Configuration:SystemEventEntityId xsi:type="xsd:int">0</Configuration:SystemEventEntityId>
   </Configuration:DeleteSystemEventEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteSystemEventEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Configuration:DeleteSystemEventEntityResponse>
  </Configuration:DeleteSystemEventEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

