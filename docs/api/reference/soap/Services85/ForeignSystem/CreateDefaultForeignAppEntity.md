---
title: Services85.ForeignSystemAgent.CreateDefaultForeignAppEntity SOAP
generated: 1
uid: Services85-ForeignSystem-CreateDefaultForeignAppEntity
---

# Services85 ForeignSystem CreateDefaultForeignAppEntity

SOAP request and response examples **Remote/Services85/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IForeignSystemAgent.CreateDefaultForeignAppEntity">SuperOffice.Services85.IForeignSystemAgent.CreateDefaultForeignAppEntity</see> method.

## CreateDefaultForeignAppEntity

Loading default values into a new ForeignAppEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance

**Returns:** New ForeignAppEntity with default values

[WSDL file for Services85/ForeignSystem](../Services85-ForeignSystem.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultForeignAppEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <ForeignSystem:ApplicationToken>1234567-1234-9876</ForeignSystem:ApplicationToken>
  <ForeignSystem:Credentials>
    <ForeignSystem:Ticket>7T:1234abcxyzExample==</ForeignSystem:Ticket>
  </ForeignSystem:Credentials>
 <SOAP-ENV:Body>
   <ForeignSystem:CreateDefaultForeignAppEntity>
   </ForeignSystem:CreateDefaultForeignAppEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## CreateDefaultForeignAppEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <ForeignSystem:CreateDefaultForeignAppEntityResponse>
   <ForeignSystem:Response xsi:type="ForeignSystem:ForeignAppEntity">
    <ForeignSystem:ForeignAppId xsi:type="xsd:int">0</ForeignSystem:ForeignAppId>
    <ForeignSystem:Name xsi:type="xsd:string"></ForeignSystem:Name>
    <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2022-08-26T08:52:58Z</ForeignSystem:CreatedDate>
    <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2022-08-26T08:52:58Z</ForeignSystem:UpdatedDate>
    <ForeignSystem:CreatedBy xsi:type="ForeignSystem:Associate">
     <ForeignSystem:AssociateId xsi:type="xsd:int">0</ForeignSystem:AssociateId>
     <ForeignSystem:Name xsi:type="xsd:string"></ForeignSystem:Name>
     <ForeignSystem:PersonId xsi:type="xsd:int">0</ForeignSystem:PersonId>
     <ForeignSystem:Rank xsi:type="xsd:short">0</ForeignSystem:Rank>
     <ForeignSystem:Tooltip xsi:type="xsd:string"></ForeignSystem:Tooltip>
     <ForeignSystem:Type xsi:type="ForeignSystem:UserType">Unknown</ForeignSystem:Type>
     <ForeignSystem:GroupIdx xsi:type="xsd:int">0</ForeignSystem:GroupIdx>
     <ForeignSystem:FullName xsi:type="xsd:string"></ForeignSystem:FullName>
     <ForeignSystem:FormalName xsi:type="xsd:string"></ForeignSystem:FormalName>
     <ForeignSystem:Deleted xsi:type="xsd:boolean">false</ForeignSystem:Deleted>
     <ForeignSystem:EjUserId xsi:type="xsd:int">0</ForeignSystem:EjUserId>
    </ForeignSystem:CreatedBy>
    <ForeignSystem:UpdatedBy xsi:type="ForeignSystem:Associate">
     <ForeignSystem:AssociateId xsi:type="xsd:int">0</ForeignSystem:AssociateId>
     <ForeignSystem:Name xsi:type="xsd:string"></ForeignSystem:Name>
     <ForeignSystem:PersonId xsi:type="xsd:int">0</ForeignSystem:PersonId>
     <ForeignSystem:Rank xsi:type="xsd:short">0</ForeignSystem:Rank>
     <ForeignSystem:Tooltip xsi:type="xsd:string"></ForeignSystem:Tooltip>
     <ForeignSystem:Type xsi:type="ForeignSystem:UserType">Unknown</ForeignSystem:Type>
     <ForeignSystem:GroupIdx xsi:type="xsd:int">0</ForeignSystem:GroupIdx>
     <ForeignSystem:FullName xsi:type="xsd:string"></ForeignSystem:FullName>
     <ForeignSystem:FormalName xsi:type="xsd:string"></ForeignSystem:FormalName>
     <ForeignSystem:Deleted xsi:type="xsd:boolean">false</ForeignSystem:Deleted>
     <ForeignSystem:EjUserId xsi:type="xsd:int">0</ForeignSystem:EjUserId>
    </ForeignSystem:UpdatedBy>
    <ForeignSystem:Devices xsi:type="ForeignSystem:ArrayOfForeignDevice">
     <ForeignSystem:ForeignDevice xsi:type="ForeignSystem:ForeignDevice">
      <ForeignSystem:ForeignDeviceId xsi:type="xsd:int">0</ForeignSystem:ForeignDeviceId>
      <ForeignSystem:Name xsi:type="xsd:string"></ForeignSystem:Name>
      <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2022-08-26T08:52:58Z</ForeignSystem:CreatedDate>
      <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2022-08-26T08:52:58Z</ForeignSystem:UpdatedDate>
      <ForeignSystem:AssociateFullName xsi:type="xsd:string"></ForeignSystem:AssociateFullName>
      <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
      <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
      <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
      <ForeignSystem:ForeignAppId xsi:type="xsd:int">0</ForeignSystem:ForeignAppId>
     </ForeignSystem:ForeignDevice>
    </ForeignSystem:Devices>
   </ForeignSystem:Response>
  </ForeignSystem:CreateDefaultForeignAppEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
