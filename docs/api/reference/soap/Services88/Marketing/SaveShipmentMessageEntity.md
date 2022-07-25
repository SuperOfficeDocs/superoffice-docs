---
title: Services88.MarketingAgent.SaveShipmentMessageEntity SOAP
generated: 1
uid: Services88-Marketing-SaveShipmentMessageEntity
---

# Services88 Marketing SaveShipmentMessageEntity

SOAP request and response examples **Remote/Services88/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IMarketingAgent.SaveShipmentMessageEntity">SuperOffice.Services88.IMarketingAgent.SaveShipmentMessageEntity</see> method.

## SaveShipmentMessageEntity

Updates the existing ShipmentMessageEntity or creates a new ShipmentMessageEntity if the id parameter is 0.

* **shipmentMessageEntity:** The ShipmentMessageEntity that is saved.

**Returns:** New or updated ShipmentMessageEntity

[WSDL file for Services88/Marketing](../Services88-Marketing.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveShipmentMessageEntity Request

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
   <Marketing:SaveShipmentMessageEntity>
    <Marketing:ShipmentMessageEntity xsi:type="Marketing:ShipmentMessageEntity">
     <Marketing:ShipmentMessageId xsi:type="xsd:int">0</Marketing:ShipmentMessageId>
     <Marketing:PlainMessage xsi:type="xsd:string"></Marketing:PlainMessage>
     <Marketing:HtmlMessage xsi:type="xsd:string"></Marketing:HtmlMessage>
     <Marketing:SmsMessage xsi:type="xsd:string"></Marketing:SmsMessage>
     <Marketing:Description xsi:type="xsd:string"></Marketing:Description>
     <Marketing:Subject xsi:type="xsd:string"></Marketing:Subject>
     <Marketing:FolderId xsi:type="xsd:int">0</Marketing:FolderId>
     <Marketing:HeaderField xsi:type="xsd:string"></Marketing:HeaderField>
     <Marketing:Design xsi:type="xsd:string"></Marketing:Design>
     <Marketing:Designtype xsi:type="Marketing:DesignType">Unknown</Marketing:Designtype>
     <Marketing:Flags xsi:type="Marketing:ShipmentMessageType">Html</Marketing:Flags>
     <Marketing:RegisterViews xsi:type="xsd:boolean">false</Marketing:RegisterViews>
     <Marketing:InlineImages xsi:type="xsd:boolean">false</Marketing:InlineImages>
     <Marketing:LongDescription xsi:type="xsd:string"></Marketing:LongDescription>
     <Marketing:AccessKey xsi:type="xsd:string"></Marketing:AccessKey>
     <Marketing:DocumentMessage xsi:type="xsd:int">0</Marketing:DocumentMessage>
     <Marketing:Registered xsi:type="xsd:dateTime">2021-11-30T13:23:45Z</Marketing:Registered>
     <Marketing:RegisteredAssociateId xsi:type="xsd:int">0</Marketing:RegisteredAssociateId>
     <Marketing:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:45Z</Marketing:Updated>
     <Marketing:UpdatedAssociateId xsi:type="xsd:int">0</Marketing:UpdatedAssociateId>
     <Marketing:UpdatedCount xsi:type="xsd:short">0</Marketing:UpdatedCount>
    </Marketing:ShipmentMessageEntity>
   </Marketing:SaveShipmentMessageEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## SaveShipmentMessageEntity Response

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
  <Marketing:SaveShipmentMessageEntityResponse>
   <Marketing:Response xsi:type="Marketing:ShipmentMessageEntity">
    <Marketing:ShipmentMessageId xsi:type="xsd:int">0</Marketing:ShipmentMessageId>
    <Marketing:PlainMessage xsi:type="xsd:string"></Marketing:PlainMessage>
    <Marketing:HtmlMessage xsi:type="xsd:string"></Marketing:HtmlMessage>
    <Marketing:SmsMessage xsi:type="xsd:string"></Marketing:SmsMessage>
    <Marketing:Description xsi:type="xsd:string"></Marketing:Description>
    <Marketing:Subject xsi:type="xsd:string"></Marketing:Subject>
    <Marketing:FolderId xsi:type="xsd:int">0</Marketing:FolderId>
    <Marketing:HeaderField xsi:type="xsd:string"></Marketing:HeaderField>
    <Marketing:Design xsi:type="xsd:string"></Marketing:Design>
    <Marketing:Designtype xsi:type="Marketing:DesignType">Unknown</Marketing:Designtype>
    <Marketing:Flags xsi:type="Marketing:ShipmentMessageType">Html</Marketing:Flags>
    <Marketing:RegisterViews xsi:type="xsd:boolean">false</Marketing:RegisterViews>
    <Marketing:InlineImages xsi:type="xsd:boolean">false</Marketing:InlineImages>
    <Marketing:LongDescription xsi:type="xsd:string"></Marketing:LongDescription>
    <Marketing:AccessKey xsi:type="xsd:string"></Marketing:AccessKey>
    <Marketing:DocumentMessage xsi:type="xsd:int">0</Marketing:DocumentMessage>
    <Marketing:Registered xsi:type="xsd:dateTime">2021-11-30T13:23:45Z</Marketing:Registered>
    <Marketing:RegisteredAssociateId xsi:type="xsd:int">0</Marketing:RegisteredAssociateId>
    <Marketing:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:45Z</Marketing:Updated>
    <Marketing:UpdatedAssociateId xsi:type="xsd:int">0</Marketing:UpdatedAssociateId>
    <Marketing:UpdatedCount xsi:type="xsd:short">0</Marketing:UpdatedCount>
   </Marketing:Response>
  </Marketing:SaveShipmentMessageEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
