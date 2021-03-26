---
uid: services88-foreignsystem-getdevicebyidentifier
title: Services88.ForeignSystemAgent.GetDeviceByIdentifier SOAP
Generated: true
---

# Services88 ForeignSystem GetDeviceByIdentifier SOAP

SOAP request and response examples **Remote/Services88/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IForeignSystemAgent.GetDeviceByIdentifier">SuperOffice.Services88.IForeignSystemAgent.GetDeviceByIdentifier</see> method.

## GetDeviceByIdentifier

Gets a ForeignDevice with deviceName and deviceIdentifier that belongs to the application with applicationName.

* **applicationName:** The name of the foreign application.
* **deviceName:** The name of the foreign device.
* **deviceIdentifier:** Optional unique id of device (Palm pilot device ID, version number, etc)

**Returns:** The ForeignDevice.


[WSDL file for Services88/ForeignSystem](../Services88-ForeignSystem.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDeviceByIdentifier Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <ForeignSystem:ApplicationToken>1234567-1234-9876</ForeignSystem:ApplicationToken>
  <ForeignSystem:Credentials>
    <ForeignSystem:Ticket>7T:1234abcxyzExample==</ForeignSystem:Ticket>
  </ForeignSystem:Credentials>
 <SOAP-ENV:Body>
   <ForeignSystem:GetDeviceByIdentifier>
    <ForeignSystem:ApplicationName xsi:type="xsd:string"></ForeignSystem:ApplicationName>
    <ForeignSystem:DeviceName xsi:type="xsd:string"></ForeignSystem:DeviceName>
    <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
   </ForeignSystem:GetDeviceByIdentifier>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDeviceByIdentifier Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <ForeignSystem:GetDeviceByIdentifierResponse>
   <ForeignSystem:Response xsi:type="ForeignSystem:ForeignDevice">
    <ForeignSystem:ForeignDeviceId xsi:type="xsd:int">0</ForeignSystem:ForeignDeviceId>
    <ForeignSystem:Name xsi:type="xsd:string"></ForeignSystem:Name>
    <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:36:59Z</ForeignSystem:CreatedDate>
    <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:36:59Z</ForeignSystem:UpdatedDate>
    <ForeignSystem:AssociateFullName xsi:type="xsd:string"></ForeignSystem:AssociateFullName>
    <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
    <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
    <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
    <ForeignSystem:ForeignAppId xsi:type="xsd:int">0</ForeignSystem:ForeignAppId>
   </ForeignSystem:Response>
  </ForeignSystem:GetDeviceByIdentifierResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

