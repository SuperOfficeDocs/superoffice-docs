---
uid: services84-foreignsystem-getforeigndevice
title: Services84.ForeignSystemAgent.GetForeignDevice SOAP
Generated: true
---

# Services84 ForeignSystem GetForeignDevice SOAP

SOAP request and response examples **Remote/Services84/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IForeignSystemAgent.GetForeignDevice">SuperOffice.Services84.IForeignSystemAgent.GetForeignDevice</see> method.

## GetForeignDevice

Gets a ForeignDevice object.

* **foreignDeviceId:** The identifier of the ForeignDevice object

**Returns:** ForeignDevice


[WSDL file for Services84/ForeignSystem](../Services84-ForeignSystem.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetForeignDevice Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <ForeignSystem:ApplicationToken>1234567-1234-9876</ForeignSystem:ApplicationToken>
  <ForeignSystem:Credentials>
    <ForeignSystem:Ticket>7T:1234abcxyzExample==</ForeignSystem:Ticket>
  </ForeignSystem:Credentials>
 <SOAP-ENV:Body>
   <ForeignSystem:GetForeignDevice>
    <ForeignSystem:ForeignDeviceId xsi:type="xsd:int">0</ForeignSystem:ForeignDeviceId>
   </ForeignSystem:GetForeignDevice>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetForeignDevice Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ForeignSystem="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <ForeignSystem:GetForeignDeviceResponse>
   <ForeignSystem:Response xsi:type="ForeignSystem:ForeignDevice">
    <ForeignSystem:ForeignDeviceId xsi:type="xsd:int">0</ForeignSystem:ForeignDeviceId>
    <ForeignSystem:Name xsi:type="xsd:string"></ForeignSystem:Name>
    <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:27Z</ForeignSystem:CreatedDate>
    <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:35:27Z</ForeignSystem:UpdatedDate>
    <ForeignSystem:AssociateFullName xsi:type="xsd:string"></ForeignSystem:AssociateFullName>
    <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
    <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
    <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
    <ForeignSystem:ForeignAppId xsi:type="xsd:int">0</ForeignSystem:ForeignAppId>
   </ForeignSystem:Response>
  </ForeignSystem:GetForeignDeviceResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

