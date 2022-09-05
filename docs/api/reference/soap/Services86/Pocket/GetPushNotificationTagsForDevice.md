---
title: Services86.PocketAgent.GetPushNotificationTagsForDevice SOAP
generated: 1
uid: Services86-Pocket-GetPushNotificationTagsForDevice
---

# Services86 Pocket GetPushNotificationTagsForDevice

SOAP request and response examples **Remote/Services86/Pocket.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IPocketAgent.GetPushNotificationTagsForDevice">SuperOffice.Services86.IPocketAgent.GetPushNotificationTagsForDevice</see> method.

## GetPushNotificationTagsForDevice

Retrieve current tag value for a device

* **deviceIdentifier:** The unique identifier of this device

**Returns:** A comma separated list of events this device should receive push events for


[WSDL file for Services86/Pocket](../Services86-Pocket.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPushNotificationTagsForDevice Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Pocket:ApplicationToken>1234567-1234-9876</Pocket:ApplicationToken>
  <Pocket:Credentials>
    <Pocket:Ticket>7T:1234abcxyzExample==</Pocket:Ticket>
  </Pocket:Credentials>
 <SOAP-ENV:Body>
   <Pocket:GetPushNotificationTagsForDevice>
    <Pocket:DeviceIdentifier xsi:type="xsd:string"></Pocket:DeviceIdentifier>
   </Pocket:GetPushNotificationTagsForDevice>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPushNotificationTagsForDevice Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Pocket:GetPushNotificationTagsForDeviceResponse>
   <Pocket:Response xsi:type="xsd:string"></Pocket:Response>
  </Pocket:GetPushNotificationTagsForDeviceResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

