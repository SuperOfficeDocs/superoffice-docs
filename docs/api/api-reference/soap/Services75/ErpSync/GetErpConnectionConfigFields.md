---
uid: services75-erpsync-geterpconnectionconfigfields
title: Services75.ErpSyncAgent.GetErpConnectionConfigFields SOAP
Generated: true
---

# Services75 ErpSync GetErpConnectionConfigFields SOAP

SOAP request and response examples **Remote/Services75/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IErpSyncAgent.GetErpConnectionConfigFields">SuperOffice.Services75.IErpSyncAgent.GetErpConnectionConfigFields</see> method.

## GetErpConnectionConfigFields

Returns the config fields for the connection.

* **erpConnectionId:** Primary key of the erp connection

**Returns:** Config Fields


[WSDL file for Services75/ErpSync](../Services75-ErpSync.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetErpConnectionConfigFields Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:GetErpConnectionConfigFields>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
   </ErpSync:GetErpConnectionConfigFields>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetErpConnectionConfigFields Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <ErpSync:GetErpConnectionConfigFieldsResponse>
   <ErpSync:Response xsi:type="ErpSync:StringDictionary">
    <ErpSync:StringKeyValuePair>
     <ErpSync:Key xsi:type="xsd:string"></ErpSync:Key>
     <ErpSync:Value xsi:type="xsd:string"></ErpSync:Value>
    </ErpSync:StringKeyValuePair>
   </ErpSync:Response>
  </ErpSync:GetErpConnectionConfigFieldsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

