---
title: Services87.ForeignSystemAgent.SaveDeviceByIdentifier SOAP
generated: 1
uid: Services87-ForeignSystem-SaveDeviceByIdentifier
---

# Services87 ForeignSystem SaveDeviceByIdentifier

SOAP request and response examples **Remote/Services87/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IForeignSystemAgent.SaveDeviceByIdentifier">SuperOffice.Services87.IForeignSystemAgent.SaveDeviceByIdentifier</see> method.

## SaveDeviceByIdentifier

Updates a ForeignDevice with deviceName that belongs to the application with applicationName.

* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **deviceIdentifier:** Unique id of device (Palm pilot device ID, version number, etc)
* **foreignDevice:** Foreign device to save. Can be null if adding new device.

**Returns:** The ForeignDevice.


[WSDL file for Services87/ForeignSystem](../Services87-ForeignSystem.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveDeviceByIdentifier Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <ForeignSystem:ApplicationToken>1234567-1234-9876</ForeignSystem:ApplicationToken>
  <ForeignSystem:Credentials>
    <ForeignSystem:Ticket>7T:1234abcxyzExample==</ForeignSystem:Ticket>
  </ForeignSystem:Credentials>
 <SOAP-ENV:Body>
   <ForeignSystem:SaveDeviceByIdentifier>
    <ForeignSystem:ApplicationName xsi:type="xsd:string"></ForeignSystem:ApplicationName>
    <ForeignSystem:DeviceName xsi:type="xsd:string"></ForeignSystem:DeviceName>
    <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
    <ForeignSystem:ForeignDevice xsi:type="ForeignSystem:ForeignDevice">
     <ForeignSystem:ForeignDeviceId xsi:type="xsd:int">0</ForeignSystem:ForeignDeviceId>
     <ForeignSystem:Name xsi:type="xsd:string"></ForeignSystem:Name>
     <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2022-08-26T08:57:09Z</ForeignSystem:CreatedDate>
     <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2022-08-26T08:57:09Z</ForeignSystem:UpdatedDate>
     <ForeignSystem:AssociateFullName xsi:type="xsd:string"></ForeignSystem:AssociateFullName>
     <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
     <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
     <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
     <ForeignSystem:ForeignAppId xsi:type="xsd:int">0</ForeignSystem:ForeignAppId>
    </ForeignSystem:ForeignDevice>
   </ForeignSystem:SaveDeviceByIdentifier>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveDeviceByIdentifier Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <ForeignSystem:SaveDeviceByIdentifierResponse>
   <ForeignSystem:Response xsi:type="ForeignSystem:ForeignDevice">
    <ForeignSystem:ForeignDeviceId xsi:type="xsd:int">0</ForeignSystem:ForeignDeviceId>
    <ForeignSystem:Name xsi:type="xsd:string"></ForeignSystem:Name>
    <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2022-08-26T08:57:09Z</ForeignSystem:CreatedDate>
    <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2022-08-26T08:57:09Z</ForeignSystem:UpdatedDate>
    <ForeignSystem:AssociateFullName xsi:type="xsd:string"></ForeignSystem:AssociateFullName>
    <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
    <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
    <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
    <ForeignSystem:ForeignAppId xsi:type="xsd:int">0</ForeignSystem:ForeignAppId>
   </ForeignSystem:Response>
  </ForeignSystem:SaveDeviceByIdentifierResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

