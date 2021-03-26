---
uid: services85-erpsync-testconnectorurl
title: Services85.ErpSyncAgent.TestConnectorUrl SOAP
Generated: true
---

# Services85 ErpSync TestConnectorUrl SOAP

SOAP request and response examples **Remote/Services85/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IErpSyncAgent.TestConnectorUrl">SuperOffice.Services85.IErpSyncAgent.TestConnectorUrl</see> method.

## TestConnectorUrl

Test if connector urls anwers

* **url:** The url to test connection on

**Returns:** Enum response says ok or what is wrong


[WSDL file for Services85/ErpSync](../Services85-ErpSync.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## TestConnectorUrl Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <ErpSync:ApplicationToken>1234567-1234-9876</ErpSync:ApplicationToken>
  <ErpSync:Credentials>
    <ErpSync:Ticket>7T:1234abcxyzExample==</ErpSync:Ticket>
  </ErpSync:Credentials>
 <SOAP-ENV:Body>
   <ErpSync:TestConnectorUrl>
    <ErpSync:Url xsi:type="xsd:string"></ErpSync:Url>
   </ErpSync:TestConnectorUrl>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## TestConnectorUrl Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <ErpSync:TestConnectorUrlResponse>
   <ErpSync:Response xsi:type="ErpSync:ErpSyncResponseCode">NoError</ErpSync:Response>
  </ErpSync:TestConnectorUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

