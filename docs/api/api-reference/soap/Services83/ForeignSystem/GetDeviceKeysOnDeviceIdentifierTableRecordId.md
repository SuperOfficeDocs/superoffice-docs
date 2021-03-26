---
uid: services83-foreignsystem-getdevicekeysondeviceidentifiertablerecordid
title: Services83.ForeignSystemAgent.GetDeviceKeysOnDeviceIdentifierTableRecordId SOAP
Generated: true
---

# Services83 ForeignSystem GetDeviceKeysOnDeviceIdentifierTableRecordId SOAP

SOAP request and response examples **Remote/Services83/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IForeignSystemAgent.GetDeviceKeysOnDeviceIdentifierTableRecordId">SuperOffice.Services83.IForeignSystemAgent.GetDeviceKeysOnDeviceIdentifierTableRecordId</see> method.

## GetDeviceKeysOnDeviceIdentifierTableRecordId

Returns all ForeignKeys that belong to a device with a given deviceIdentifier and table name, as well as record id.

* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **deviceIdentifier:** Identifier for a unique grouping of keys within a device.
* **tableName:** Table name, transformed to and from numeric table id by the service layer.<p />Use an empty string to indicate that your key is not bound to any specific table.
* **recordId:** Id of record that this key refers to. If the table name was blank, then this parameter must be 0. It can also be 0 to mean that the foreign key record was not bound to any particular record of the target table.

**Returns:** Array of all ForeignKeys in the ForeignDevice that match the criteria


[WSDL file for Services83/ForeignSystem](../Services83-ForeignSystem.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDeviceKeysOnDeviceIdentifierTableRecordId Request

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
   <ForeignSystem:GetDeviceKeysOnDeviceIdentifierTableRecordId>
    <ForeignSystem:ApplicationName xsi:type="xsd:string"></ForeignSystem:ApplicationName>
    <ForeignSystem:DeviceName xsi:type="xsd:string"></ForeignSystem:DeviceName>
    <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
    <ForeignSystem:TableName xsi:type="xsd:string"></ForeignSystem:TableName>
    <ForeignSystem:RecordId xsi:type="xsd:int">0</ForeignSystem:RecordId>
   </ForeignSystem:GetDeviceKeysOnDeviceIdentifierTableRecordId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDeviceKeysOnDeviceIdentifierTableRecordId Response

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
  <ForeignSystem:GetDeviceKeysOnDeviceIdentifierTableRecordIdResponse>
   <ForeignSystem:Response xsi:type="ForeignSystem:ArrayOfForeignKey">
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
   </ForeignSystem:Response>
  </ForeignSystem:GetDeviceKeysOnDeviceIdentifierTableRecordIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

