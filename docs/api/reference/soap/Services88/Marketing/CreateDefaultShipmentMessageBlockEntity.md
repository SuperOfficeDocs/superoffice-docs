---
title: Services88.MarketingAgent.CreateDefaultShipmentMessageBlockEntity SOAP
generated: 1
uid: Services88-Marketing-CreateDefaultShipmentMessageBlockEntity
---

# Services88 Marketing CreateDefaultShipmentMessageBlockEntity

SOAP request and response examples **Remote/Services88/Marketing.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IMarketingAgent.CreateDefaultShipmentMessageBlockEntity">SuperOffice.Services88.IMarketingAgent.CreateDefaultShipmentMessageBlockEntity</see> method.

## CreateDefaultShipmentMessageBlockEntity

Loading default values into a new ShipmentMessageBlockEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance

**Returns:** New ShipmentMessageBlockEntity with default values

[WSDL file for Services88/Marketing](../Services88-Marketing.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultShipmentMessageBlockEntity Request

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
   <Marketing:CreateDefaultShipmentMessageBlockEntity>
   </Marketing:CreateDefaultShipmentMessageBlockEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## CreateDefaultShipmentMessageBlockEntity Response

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
  <Marketing:CreateDefaultShipmentMessageBlockEntityResponse>
   <Marketing:Response xsi:type="Marketing:ShipmentMessageBlockEntity">
    <Marketing:ShipmentMessageBlockId xsi:type="xsd:int">0</Marketing:ShipmentMessageBlockId>
    <Marketing:AssociateId xsi:type="xsd:int">0</Marketing:AssociateId>
    <Marketing:Block xsi:type="xsd:string"></Marketing:Block>
    <Marketing:Registered xsi:type="xsd:dateTime">2021-11-30T13:23:45Z</Marketing:Registered>
    <Marketing:RegisteredAssociateId xsi:type="xsd:int">0</Marketing:RegisteredAssociateId>
    <Marketing:Updated xsi:type="xsd:dateTime">2021-11-30T13:23:45Z</Marketing:Updated>
    <Marketing:UpdatedAssociateId xsi:type="xsd:int">0</Marketing:UpdatedAssociateId>
    <Marketing:UpdatedCount xsi:type="xsd:short">0</Marketing:UpdatedCount>
   </Marketing:Response>
  </Marketing:CreateDefaultShipmentMessageBlockEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
