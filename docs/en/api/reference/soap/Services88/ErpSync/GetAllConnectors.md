---
title: Services88.ErpSyncAgent.GetAllConnectors SOAP
generated: true
uid: Services88-ErpSync-GetAllConnectors
content_type: reference
---

# Services88 ErpSync GetAllConnectors

SOAP request and response examples **Remote/Services88/ErpSync.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IErpSyncAgent.GetAllConnectors">SuperOffice.Services88.IErpSyncAgent.GetAllConnectors</see> method.

## GetAllConnectors





[WSDL file for Services88/ErpSync](../Services88-ErpSync.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllConnectors Request

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
   <ErpSync:GetAllConnectors>
   </ErpSync:GetAllConnectors>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllConnectors Response

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
  <ErpSync:GetAllConnectorsResponse>
   <ErpSync:Response xsi:type="ErpSync:ArrayOfListItem">
    <ErpSync:ListItem xsi:type="ErpSync:ListItem">
     <ErpSync:Id xsi:type="xsd:int">0</ErpSync:Id>
     <ErpSync:Name xsi:type="xsd:string"></ErpSync:Name>
     <ErpSync:ToolTip xsi:type="xsd:string"></ErpSync:ToolTip>
    </ErpSync:ListItem>
   </ErpSync:Response>
  </ErpSync:GetAllConnectorsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

