---
uid: services87-pocket-registerdeviceforpushnotification
title: Services87.PocketAgent.RegisterDeviceForPushNotification SOAP
Generated: true
---

# Services87 Pocket RegisterDeviceForPushNotification SOAP

SOAP request and response examples **Remote/Services87/Pocket.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IPocketAgent.RegisterDeviceForPushNotification">SuperOffice.Services87.IPocketAgent.RegisterDeviceForPushNotification</see> method.

## RegisterDeviceForPushNotification

Register a device that should receive push notifications when notable events occour

* **deviceInfo:** Properties for the device to register



[WSDL file for Services87/Pocket](../Services87-Pocket.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RegisterDeviceForPushNotification Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Pocket:ApplicationToken>1234567-1234-9876</Pocket:ApplicationToken>
  <Pocket:Credentials>
    <Pocket:Ticket>7T:1234abcxyzExample==</Pocket:Ticket>
  </Pocket:Credentials>
 <SOAP-ENV:Body>
   <Pocket:RegisterDeviceForPushNotification>
    <Pocket:DeviceInfo xsi:type="Pocket:PocketDeviceInfo">
     <Pocket:DeviceName xsi:type="xsd:string"></Pocket:DeviceName>
     <Pocket:DeviceIdentifier xsi:type="xsd:string"></Pocket:DeviceIdentifier>
     <Pocket:PocketVersion xsi:type="xsd:string"></Pocket:PocketVersion>
     <Pocket:Language xsi:type="xsd:string"></Pocket:Language>
     <Pocket:PNSHandle xsi:type="xsd:string"></Pocket:PNSHandle>
     <Pocket:Platform xsi:type="Pocket:NotificationPlatform">Apple</Pocket:Platform>
     <Pocket:OSVersion xsi:type="xsd:string"></Pocket:OSVersion>
    </Pocket:DeviceInfo>
   </Pocket:RegisterDeviceForPushNotification>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RegisterDeviceForPushNotification Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Pocket:RegisterDeviceForPushNotificationResponse>
  </Pocket:RegisterDeviceForPushNotificationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

