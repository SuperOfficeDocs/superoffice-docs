---
uid: services82-erpsync-toggleerpconnectionactive
title: Services82.ErpSyncAgent.ToggleErpConnectionActive SOAP
Generated: true
---

# Services82 ErpSync ToggleErpConnectionActive SOAP

SOAP request and response examples **Remote/Services82/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IErpSyncAgent.ToggleErpConnectionActive">SuperOffice.Services82.IErpSyncAgent.ToggleErpConnectionActive</see> method.

## ToggleErpConnectionActive

Toggles the Active state of the connection

* **erpConnectionId:** Primary key of the erp connection

**Returns:** Contains the reason for why the toggle failed. Empty if operation was successful


[WSDL file for Services82/ErpSync](../Services82-ErpSync.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ToggleErpConnectionActive Request

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
   <ErpSync:ToggleErpConnectionActive>
    <ErpSync:ErpConnectionId xsi:type="xsd:int">0</ErpSync:ErpConnectionId>
   </ErpSync:ToggleErpConnectionActive>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ToggleErpConnectionActive Response

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
  <ErpSync:ToggleErpConnectionActiveResponse>
   <ErpSync:Response xsi:type="NetServerServices822:ArrayOfstring">
    <NetServerServices822:string xsi:type="xsd:string"></NetServerServices822:string>
   </ErpSync:Response>
  </ErpSync:ToggleErpConnectionActiveResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

