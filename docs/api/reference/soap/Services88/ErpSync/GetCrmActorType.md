---
title: Services88.ErpSyncAgent.GetCrmActorType SOAP
generated: 1
uid: Services88-ErpSync-GetCrmActorType
---

# Services88 ErpSync GetCrmActorType

SOAP request and response examples **Remote/Services88/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IErpSyncAgent.GetCrmActorType">SuperOffice.Services88.IErpSyncAgent.GetCrmActorType</see> method.

## GetCrmActorType

Retrieves the CrmActorType that are mapped to a specific ErpActorType for this connection
<para /><b>Online Restricted:</b> The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.

* **erpConnectionId:** The ERP connection ID
* **erpActorType:** The ERP actor type

**Returns:** The CrmActorType


[WSDL file for Services88/ErpSync](../Services88-ErpSync.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCrmActorType Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <ErpSync:GetCrmActorTypeResponse>
   <ErpSync:Response xsi:type="ErpSync:CrmActorType">Unknown</ErpSync:Response>
  </ErpSync:GetCrmActorTypeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

