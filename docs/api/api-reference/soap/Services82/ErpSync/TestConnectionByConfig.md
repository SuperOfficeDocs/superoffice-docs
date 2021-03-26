---
uid: services82-erpsync-testconnectionbyconfig
title: Services82.ErpSyncAgent.TestConnectionByConfig SOAP
Generated: true
---

# Services82 ErpSync TestConnectionByConfig SOAP

SOAP request and response examples **Remote/Services82/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IErpSyncAgent.TestConnectionByConfig">SuperOffice.Services82.IErpSyncAgent.TestConnectionByConfig</see> method.

## TestConnectionByConfig

Tests to see if the given connection has a valid connection to its connector

* **erpConnectionId:** The id of the connector we try to connect to
* **configFields:** The config fields used to test connection

**Returns:** Returns true if success


[WSDL file for Services82/ErpSync](../Services82-ErpSync.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## TestConnectionByConfig Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:TestConnectionByConfig>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
    <ErpSync:ConfigFields xsi:type="ErpSync:StringDictionary">
     <ErpSync:StringKeyValuePair>
      <ErpSync:Key xsi:type="xsd:string"></ErpSync:Key>
      <ErpSync:Value xsi:type="xsd:string"></ErpSync:Value>
     </ErpSync:StringKeyValuePair>
    </ErpSync:ConfigFields>
   </ErpSync:TestConnectionByConfig>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## TestConnectionByConfig Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <ErpSync:TestConnectionByConfigResponse>
   <ErpSync:Response xsi:type="xsd:boolean">false</ErpSync:Response>
  </ErpSync:TestConnectionByConfigResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

