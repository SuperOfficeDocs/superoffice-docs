---
uid: services75-foreignsystem-getdevicekeysondeviceidentifier
title: Services75.ForeignSystemAgent.GetDeviceKeysOnDeviceIdentifier SOAP
Generated: true
---

# Services75 ForeignSystem GetDeviceKeysOnDeviceIdentifier SOAP

SOAP request and response examples **Remote/Services75/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IForeignSystemAgent.GetDeviceKeysOnDeviceIdentifier">SuperOffice.Services75.IForeignSystemAgent.GetDeviceKeysOnDeviceIdentifier</see> method.

## GetDeviceKeysOnDeviceIdentifier

Returns all ForeignKeys that belong to a device with a given deviceIdentifier.

* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **deviceIdentifier:** Identifier for a unique grouping of keys within a device.

**Returns:** Array of all ForeignKeys in the ForeignDevice that belong to the DeviceIdentifier.


[WSDL file for Services75/ForeignSystem](../Services75-ForeignSystem.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDeviceKeysOnDeviceIdentifier Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <ForeignSystem:ApplicationToken>1234567-1234-9876</ForeignSystem:ApplicationToken>
  <ForeignSystem:Credentials>
    <ForeignSystem:Ticket>7T:1234abcxyzExample==</ForeignSystem:Ticket>
  </ForeignSystem:Credentials>
 <SOAP-ENV:Body>
   <ForeignSystem:GetDeviceKeysOnDeviceIdentifier>
    <ForeignSystem:ApplicationName xsi:type="xsd:string"></ForeignSystem:ApplicationName>
    <ForeignSystem:DeviceName xsi:type="xsd:string"></ForeignSystem:DeviceName>
    <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
   </ForeignSystem:GetDeviceKeysOnDeviceIdentifier>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDeviceKeysOnDeviceIdentifier Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <ForeignSystem:GetDeviceKeysOnDeviceIdentifierResponse>
   <ForeignSystem:Response xsi:type="ForeignSystem:ArrayOfForeignKey">
    <ForeignSystem:ForeignKey xsi:type="ForeignSystem:ForeignKey">
     <ForeignSystem:Key xsi:type="xsd:string"></ForeignSystem:Key>
     <ForeignSystem:Value xsi:type="xsd:string"></ForeignSystem:Value>
     <ForeignSystem:RecordId xsi:type="xsd:int">0</ForeignSystem:RecordId>
     <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:32:24Z</ForeignSystem:CreatedDate>
     <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:32:24Z</ForeignSystem:UpdatedDate>
     <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
     <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
     <ForeignSystem:TableName xsi:type="xsd:string"></ForeignSystem:TableName>
    </ForeignSystem:ForeignKey>
   </ForeignSystem:Response>
  </ForeignSystem:GetDeviceKeysOnDeviceIdentifierResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

