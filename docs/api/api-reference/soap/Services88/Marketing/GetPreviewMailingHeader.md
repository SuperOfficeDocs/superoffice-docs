---
title: Services88.MarketingAgent.GetPreviewMailingHeader SOAP
generated: 1
uid: Services88-Marketing-GetPreviewMailingHeader
---

# Services88 Marketing GetPreviewMailingHeader

SOAP request and response examples **Remote/Services88/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IMarketingAgent.GetPreviewMailingHeader">SuperOffice.Services88.IMarketingAgent.GetPreviewMailingHeader</see> method.

## GetPreviewMailingHeader

Get a shipment from its shipment id

* **shipmentId:** Shipment id

**Returns:** PreviewMailingHeader


[WSDL file for Services88/Marketing](../Services88-Marketing.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPreviewMailingHeader Request

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
   <Marketing:GetPreviewMailingHeader>
    <Marketing:ShipmentId xsi:type="xsd:int">0</Marketing:ShipmentId>
   </Marketing:GetPreviewMailingHeader>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPreviewMailingHeader Response

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
  <Marketing:GetPreviewMailingHeaderResponse>
   <Marketing:Response xsi:type="Marketing:PreviewMailingHeader">
    <Marketing:StartDate xsi:type="xsd:dateTime">2021-11-30T13:23:45Z</Marketing:StartDate>
    <Marketing:Status xsi:type="Marketing:ShipmentStatus">None</Marketing:Status>
    <Marketing:ShipmentId xsi:type="xsd:int">0</Marketing:ShipmentId>
    <Marketing:ShipmentDescription xsi:type="xsd:string"></Marketing:ShipmentDescription>
    <Marketing:FromAddress xsi:type="xsd:string"></Marketing:FromAddress>
    <Marketing:PersonId xsi:type="xsd:int">0</Marketing:PersonId>
    <Marketing:PersonFullName xsi:type="xsd:string"></Marketing:PersonFullName>
    <Marketing:ShipmentType xsi:type="xsd:string"></Marketing:ShipmentType>
    <Marketing:MessageId xsi:type="xsd:int">0</Marketing:MessageId>
    <Marketing:MessageSubject xsi:type="xsd:string"></Marketing:MessageSubject>
    <Marketing:DocumentMessageId xsi:type="xsd:int">0</Marketing:DocumentMessageId>
    <Marketing:NumSent xsi:type="xsd:int">0</Marketing:NumSent>
    <Marketing:NumOpened xsi:type="xsd:int">0</Marketing:NumOpened>
    <Marketing:NumBounced xsi:type="xsd:int">0</Marketing:NumBounced>
    <Marketing:NumClicks xsi:type="xsd:int">0</Marketing:NumClicks>
   </Marketing:Response>
  </Marketing:GetPreviewMailingHeaderResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

