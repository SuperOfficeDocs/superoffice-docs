---
uid: services83-foreignsystem-addforeignkey
title: Services83.ForeignSystemAgent.AddForeignKey SOAP
Generated: true
---

# Services83 ForeignSystem AddForeignKey SOAP

SOAP request and response examples **Remote/Services83/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IForeignSystemAgent.AddForeignKey">SuperOffice.Services83.IForeignSystemAgent.AddForeignKey</see> method.

## AddForeignKey

Add a new key belonging to the ForeignApp and ForeignDevice specified.

* **foreignKey:** Foreign key to save
* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **deviceIdentifier:** The device identifier. Optional if device identifier is not used.

**Returns:** The new or updated ForeignKey


[WSDL file for Services83/ForeignSystem](../Services83-ForeignSystem.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## AddForeignKey Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <ForeignSystem:ApplicationToken>1234567-1234-9876</ForeignSystem:ApplicationToken>
  <ForeignSystem:Credentials>
    <ForeignSystem:Ticket>7T:1234abcxyzExample==</ForeignSystem:Ticket>
  </ForeignSystem:Credentials>
 <SOAP-ENV:Body>
   <ForeignSystem:AddForeignKey>
    <ForeignSystem:ForeignKey xsi:type="ForeignSystem:ForeignKey">
     <ForeignSystem:Key xsi:type="xsd:string"></ForeignSystem:Key>
     <ForeignSystem:Value xsi:type="xsd:string"></ForeignSystem:Value>
     <ForeignSystem:RecordId xsi:type="xsd:int">0</ForeignSystem:RecordId>
     <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:07Z</ForeignSystem:CreatedDate>
     <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:07Z</ForeignSystem:UpdatedDate>
     <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
     <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
     <ForeignSystem:TableName xsi:type="xsd:string"></ForeignSystem:TableName>
    </ForeignSystem:ForeignKey>
    <ForeignSystem:ApplicationName xsi:type="xsd:string"></ForeignSystem:ApplicationName>
    <ForeignSystem:DeviceName xsi:type="xsd:string"></ForeignSystem:DeviceName>
    <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
   </ForeignSystem:AddForeignKey>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## AddForeignKey Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <ForeignSystem:AddForeignKeyResponse>
   <ForeignSystem:Response xsi:type="ForeignSystem:ForeignKey">
    <ForeignSystem:Key xsi:type="xsd:string"></ForeignSystem:Key>
    <ForeignSystem:Value xsi:type="xsd:string"></ForeignSystem:Value>
    <ForeignSystem:RecordId xsi:type="xsd:int">0</ForeignSystem:RecordId>
    <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:07Z</ForeignSystem:CreatedDate>
    <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:07Z</ForeignSystem:UpdatedDate>
    <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
    <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
    <ForeignSystem:TableName xsi:type="xsd:string"></ForeignSystem:TableName>
   </ForeignSystem:Response>
  </ForeignSystem:AddForeignKeyResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

