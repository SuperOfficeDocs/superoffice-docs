---
uid: services81-erpsync-getcrmactortype
title: Services81.ErpSyncAgent.GetCrmActorType SOAP
Generated: true
---

# Services81 ErpSync GetCrmActorType SOAP

SOAP request and response examples **Remote/Services81/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IErpSyncAgent.GetCrmActorType">SuperOffice.Services81.IErpSyncAgent.GetCrmActorType</see> method.

## GetCrmActorType

Retrieves the CrmActorType that are mapped to a specific ErpActorType for this connection

* **erpConnectionId:** The ERP connection ID
* **erpActorType:** The ERP actor type

**Returns:** The CrmActorType


[WSDL file for Services81/ErpSync](../Services81-ErpSync.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCrmActorType Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:GetCrmActorType>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
    <ErpSync:ErpActorType xsi:type="ErpSync:ErpActorType">Unknown</ErpSync:ErpActorType>
   </ErpSync:GetCrmActorType>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCrmActorType Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <ErpSync:GetCrmActorTypeResponse>
   <ErpSync:Response xsi:type="ErpSync:CrmActorType">Unknown</ErpSync:Response>
  </ErpSync:GetCrmActorTypeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

