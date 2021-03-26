---
uid: services86-erpsync-testconnectorurl
title: Services86.ErpSyncAgent.TestConnectorUrl SOAP
Generated: true
---

# Services86 ErpSync TestConnectorUrl SOAP

SOAP request and response examples **Remote/Services86/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IErpSyncAgent.TestConnectorUrl">SuperOffice.Services86.IErpSyncAgent.TestConnectorUrl</see> method.

## TestConnectorUrl

Test if connector urls anwers
<para /><b>Online Restricted:</b> The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.

* **url:** The url to test connection on

**Returns:** Enum response says ok or what is wrong


[WSDL file for Services86/ErpSync](../Services86-ErpSync.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## TestConnectorUrl Request

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
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ErpSync="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <ErpSync:TestConnectorUrlResponse>
   <ErpSync:Response xsi:type="ErpSync:ErpSyncResponseCode">NoError</ErpSync:Response>
  </ErpSync:TestConnectorUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

