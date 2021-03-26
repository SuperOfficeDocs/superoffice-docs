---
uid: services82-foreignsystem-getdevicekeysondeviceidentifiertable
title: Services82.ForeignSystemAgent.GetDeviceKeysOnDeviceIdentifierTable SOAP
Generated: true
---

# Services82 ForeignSystem GetDeviceKeysOnDeviceIdentifierTable SOAP

SOAP request and response examples **Remote/Services82/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IForeignSystemAgent.GetDeviceKeysOnDeviceIdentifierTable">SuperOffice.Services82.IForeignSystemAgent.GetDeviceKeysOnDeviceIdentifierTable</see> method.

## GetDeviceKeysOnDeviceIdentifierTable

Returns all ForeignKeys that belong to a device with a given deviceIdentifier and table name.

* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **deviceIdentifier:** Identifier for a unique grouping of keys within a device.
* **tableName:** Table name, transformed to and from numeric table id by the service layer.<p />Use an empty string to indicate that your key is not bound to any specific table.

**Returns:** Array of all ForeignKeys in the ForeignDevice that belong to the DeviceIdentifier.


[WSDL file for Services82/ForeignSystem](../Services82-ForeignSystem.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDeviceKeysOnDeviceIdentifierTable Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <ForeignSystem:ApplicationToken>1234567-1234-9876</ForeignSystem:ApplicationToken>
  <ForeignSystem:Credentials>
    <ForeignSystem:Ticket>7T:1234abcxyzExample==</ForeignSystem:Ticket>
  </ForeignSystem:Credentials>
 <SOAP-ENV:Body>
   <ForeignSystem:GetDeviceKeysOnDeviceIdentifierTable>
    <ForeignSystem:ApplicationName xsi:type="xsd:string"></ForeignSystem:ApplicationName>
    <ForeignSystem:DeviceName xsi:type="xsd:string"></ForeignSystem:DeviceName>
    <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
    <ForeignSystem:TableName xsi:type="xsd:string"></ForeignSystem:TableName>
   </ForeignSystem:GetDeviceKeysOnDeviceIdentifierTable>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDeviceKeysOnDeviceIdentifierTable Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <ForeignSystem:GetDeviceKeysOnDeviceIdentifierTableResponse>
   <ForeignSystem:Response xsi:type="ForeignSystem:ArrayOfForeignKey">
    <ForeignSystem:ForeignKey xsi:type="ForeignSystem:ForeignKey">
     <ForeignSystem:Key xsi:type="xsd:string"></ForeignSystem:Key>
     <ForeignSystem:Value xsi:type="xsd:string"></ForeignSystem:Value>
     <ForeignSystem:RecordId xsi:type="xsd:int">0</ForeignSystem:RecordId>
     <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:34:47Z</ForeignSystem:CreatedDate>
     <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:34:47Z</ForeignSystem:UpdatedDate>
     <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
     <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
     <ForeignSystem:TableName xsi:type="xsd:string"></ForeignSystem:TableName>
    </ForeignSystem:ForeignKey>
   </ForeignSystem:Response>
  </ForeignSystem:GetDeviceKeysOnDeviceIdentifierTableResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

