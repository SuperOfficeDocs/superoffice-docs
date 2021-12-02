---
title: Services85.ForeignSystemAgent.GetApplicationDevices SOAP
generated: 1
uid: Services85-ForeignSystem-GetApplicationDevices
---

# Services85 ForeignSystem GetApplicationDevices

SOAP request and response examples **Remote/Services85/ForeignSystem.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IForeignSystemAgent.GetApplicationDevices">SuperOffice.Services85.IForeignSystemAgent.GetApplicationDevices</see> method.

## GetApplicationDevices

Gets all devices that belong to a foreign application.

* **applicationName:** The foreign application name

**Returns:** Array of ForeignDevices


[WSDL file for Services85/ForeignSystem](../Services85-ForeignSystem.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetApplicationDevices Request

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
   <ForeignSystem:GetApplicationDevices>
    <ForeignSystem:ApplicationName xsi:type="xsd:string"></ForeignSystem:ApplicationName>
   </ForeignSystem:GetApplicationDevices>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetApplicationDevices Response

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
  <ForeignSystem:GetApplicationDevicesResponse>
   <ForeignSystem:Response xsi:type="ForeignSystem:ArrayOfForeignDevice">
    <ForeignSystem:ForeignDevice xsi:type="ForeignSystem:ForeignDevice">
     <ForeignSystem:ForeignDeviceId xsi:type="xsd:int">0</ForeignSystem:ForeignDeviceId>
     <ForeignSystem:Name xsi:type="xsd:string"></ForeignSystem:Name>
     <ForeignSystem:CreatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:32Z</ForeignSystem:CreatedDate>
     <ForeignSystem:UpdatedDate xsi:type="xsd:dateTime">2021-11-30T13:22:32Z</ForeignSystem:UpdatedDate>
     <ForeignSystem:AssociateFullName xsi:type="xsd:string"></ForeignSystem:AssociateFullName>
     <ForeignSystem:CreatedBy xsi:type="xsd:string"></ForeignSystem:CreatedBy>
     <ForeignSystem:UpdatedBy xsi:type="xsd:string"></ForeignSystem:UpdatedBy>
     <ForeignSystem:DeviceIdentifier xsi:type="xsd:string"></ForeignSystem:DeviceIdentifier>
     <ForeignSystem:ForeignAppId xsi:type="xsd:int">0</ForeignSystem:ForeignAppId>
    </ForeignSystem:ForeignDevice>
   </ForeignSystem:Response>
  </ForeignSystem:GetApplicationDevicesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

