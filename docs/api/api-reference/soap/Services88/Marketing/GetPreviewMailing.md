---
title: Services88.MarketingAgent.GetPreviewMailing SOAP
generated: 1
uid: Services88-Marketing-GetPreviewMailing
---

# Services88 Marketing GetPreviewMailing

SOAP request and response examples **Remote/Services88/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IMarketingAgent.GetPreviewMailing">SuperOffice.Services88.IMarketingAgent.GetPreviewMailing</see> method.

## GetPreviewMailing

Get a shipment message from its shipment address id

* **shipmentAddrId:** Shipment address id

**Returns:** PreviewMailing


[WSDL file for Services88/Marketing](../Services88-Marketing.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPreviewMailing Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Marketing:ApplicationToken>1234567-1234-9876</Marketing:ApplicationToken>
  <Marketing:Credentials>
    <Marketing:Ticket>7T:1234abcxyzExample==</Marketing:Ticket>
  </Marketing:Credentials>
 <SOAP-ENV:Body>
   <Marketing:GetPreviewMailing>
    <Marketing:ShipmentAddrId xsi:type="xsd:int">0</Marketing:ShipmentAddrId>
   </Marketing:GetPreviewMailing>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPreviewMailing Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Marketing="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Marketing:GetPreviewMailingResponse>
   <Marketing:Response xsi:type="Marketing:PreviewMailing">
    <Marketing:SendingTime xsi:type="xsd:dateTime">2021-11-30T13:23:45Z</Marketing:SendingTime>
    <Marketing:Status xsi:type="Marketing:ShipmentAddrStatus">Unknown</Marketing:Status>
    <Marketing:ShipmentId xsi:type="xsd:int">0</Marketing:ShipmentId>
    <Marketing:ShipmentDescription xsi:type="xsd:string"></Marketing:ShipmentDescription>
    <Marketing:FromAddress xsi:type="xsd:string"></Marketing:FromAddress>
    <Marketing:ContactId xsi:type="xsd:int">0</Marketing:ContactId>
    <Marketing:ContactName xsi:type="xsd:string"></Marketing:ContactName>
    <Marketing:PersonId xsi:type="xsd:int">0</Marketing:PersonId>
    <Marketing:PersonFullName xsi:type="xsd:string"></Marketing:PersonFullName>
    <Marketing:ShipmentType xsi:type="xsd:string"></Marketing:ShipmentType>
    <Marketing:MessageId xsi:type="xsd:int">0</Marketing:MessageId>
    <Marketing:MessageSubject xsi:type="xsd:string"></Marketing:MessageSubject>
    <Marketing:DocumentMessageId xsi:type="xsd:int">0</Marketing:DocumentMessageId>
    <Marketing:Opened xsi:type="xsd:dateTime">2021-11-30T13:23:45Z</Marketing:Opened>
    <Marketing:LinkClicks xsi:type="xsd:int">0</Marketing:LinkClicks>
   </Marketing:Response>
  </Marketing:GetPreviewMailingResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

