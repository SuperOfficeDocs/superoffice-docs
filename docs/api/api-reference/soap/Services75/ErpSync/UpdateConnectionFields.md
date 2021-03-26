---
uid: services75-erpsync-updateconnectionfields
title: Services75.ErpSyncAgent.UpdateConnectionFields SOAP
Generated: true
---

# Services75 ErpSync UpdateConnectionFields SOAP

SOAP request and response examples **Remote/Services75/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IErpSyncAgent.UpdateConnectionFields">SuperOffice.Services75.IErpSyncAgent.UpdateConnectionFields</see> method.

## UpdateConnectionFields

Gets all supported actor types, and all fields for each actor type, and save this state to the CRM database

* **erpConnectionId:** The ERP connection ID

**Returns:** Success or fail


[WSDL file for Services75/ErpSync](../Services75-ErpSync.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateConnectionFields Request

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
   <ErpSync:UpdateConnectionFields>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
   </ErpSync:UpdateConnectionFields>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UpdateConnectionFields Response

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
  <ErpSync:UpdateConnectionFieldsResponse>
   <ErpSync:Response xsi:type="xsd:boolean">false</ErpSync:Response>
  </ErpSync:UpdateConnectionFieldsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

