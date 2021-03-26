---
uid: services83-foreignsystem-getkeybyvalueandidentifier
title: Services83.ForeignSystemAgent.GetKeyByValueAndIdentifier SOAP
Generated: true
---

# Services83 ForeignSystem GetKeyByValueAndIdentifier SOAP

SOAP request and response examples **Remote/Services83/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IForeignSystemAgent.GetKeyByValueAndIdentifier">SuperOffice.Services83.IForeignSystemAgent.GetKeyByValueAndIdentifier</see> method.

## GetKeyByValueAndIdentifier

Get a foreignkey based on its name and value, that belongs to the specified deviceId, device, and application.

* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **deviceIdentifier:** The device identifier. Optional if device identifier is not used.
* **keyName:** The name of the foreign key.
* **keyValue:** Foreignkey value
* **tableName:** Table name, transformed to and from numeric table id by the service layer.<p />Use an empty string to indicate that your key is not bound to any specific table.

**Returns:** The ForeignKey.


[WSDL file for Services83/ForeignSystem](../Services83-ForeignSystem.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetKeyByValueAndIdentifier Request

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
   <ForeignSystem:GetKeyByValueAndIdentifier>
    <ForeignSystem:ApplicationName xsi:type="xsd:string"></ForeignSystem:ApplicationName>
    <ForeignSystem:DeviceName xsi:type="xsd:string"></ForeignSystem:DeviceName>
    <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
    <ForeignSystem:KeyName xsi:type="xsd:string"></ForeignSystem:KeyName>
    <ForeignSystem:KeyValue xsi:type="xsd:string"></ForeignSystem:KeyValue>
    <ForeignSystem:TableName xsi:type="xsd:string"></ForeignSystem:TableName>
   </ForeignSystem:GetKeyByValueAndIdentifier>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetKeyByValueAndIdentifier Response

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
  <ForeignSystem:GetKeyByValueAndIdentifierResponse>
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
  </ForeignSystem:GetKeyByValueAndIdentifierResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

