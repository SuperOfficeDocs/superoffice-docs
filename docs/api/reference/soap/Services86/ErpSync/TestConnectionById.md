---
title: Services86.ErpSyncAgent.TestConnectionById SOAP
generated: 1
uid: Services86-ErpSync-TestConnectionById
---

# Services86 ErpSync TestConnectionById

SOAP request and response examples **Remote/Services86/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IErpSyncAgent.TestConnectionById">SuperOffice.Services86.IErpSyncAgent.TestConnectionById</see> method.

## TestConnectionById

Tests to see if we can establish a connection with the given config fields
<para /><b>Online Restricted:</b> The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.

* **erpConnectionId:** The id of the connection

**Returns:** Returns true if success


[WSDL file for Services86/ErpSync](../Services86-ErpSync.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## TestConnectionById Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:TestConnectionById>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
   </ErpSync:TestConnectionById>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## TestConnectionById Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <ErpSync:TestConnectionByIdResponse>
   <ErpSync:Response xsi:type="xsd:boolean">false</ErpSync:Response>
  </ErpSync:TestConnectionByIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

