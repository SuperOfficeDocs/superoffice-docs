---
title: Services84.PocketAgent.GetRegisteredDevices SOAP
generated: 1
uid: Services84-Pocket-GetRegisteredDevices
---

# Services84 Pocket GetRegisteredDevices

SOAP request and response examples **Remote/Services84/Pocket.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IPocketAgent.GetRegisteredDevices">SuperOffice.Services84.IPocketAgent.GetRegisteredDevices</see> method.

## GetRegisteredDevices

Retrieve all registered devices for an associate

* **associateId:** The user to get devices for



[WSDL file for Services84/Pocket](../Services84-Pocket.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetRegisteredDevices Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Pocket:ApplicationToken>1234567-1234-9876</Pocket:ApplicationToken>
  <Pocket:Credentials>
    <Pocket:Ticket>7T:1234abcxyzExample==</Pocket:Ticket>
  </Pocket:Credentials>
 <SOAP-ENV:Body>
   <Pocket:GetRegisteredDevices>
    <Pocket:AssociateId xsi:type="xsd:int">0</Pocket:AssociateId>
   </Pocket:GetRegisteredDevices>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetRegisteredDevices Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Pocket:GetRegisteredDevicesResponse>
   <Pocket:Response xsi:type="Pocket:ArrayOfPocketDeviceInfo">
    <Pocket:PocketDeviceInfo xsi:type="Pocket:PocketDeviceInfo">
     <Pocket:DeviceName xsi:type="xsd:string"></Pocket:DeviceName>
     <Pocket:DeviceIdentifier xsi:type="xsd:string"></Pocket:DeviceIdentifier>
     <Pocket:PocketVersion xsi:type="xsd:string"></Pocket:PocketVersion>
     <Pocket:Language xsi:type="xsd:string"></Pocket:Language>
     <Pocket:PNSHandle xsi:type="xsd:string"></Pocket:PNSHandle>
     <Pocket:Platform xsi:type="Pocket:NotificationPlatform">Apple</Pocket:Platform>
     <Pocket:OSVersion xsi:type="xsd:string"></Pocket:OSVersion>
    </Pocket:PocketDeviceInfo>
   </Pocket:Response>
  </Pocket:GetRegisteredDevicesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

