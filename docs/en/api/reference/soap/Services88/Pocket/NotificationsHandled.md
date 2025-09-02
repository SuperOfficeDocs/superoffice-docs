---
title: Services88.PocketAgent.NotificationsHandled SOAP
generated: true
uid: Services88-Pocket-NotificationsHandled
content_type: reference
---

# Services88 Pocket NotificationsHandled

SOAP request and response examples **Remote/Services88/Pocket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPocketAgent.NotificationsHandled">SuperOffice.Services88.IPocketAgent.NotificationsHandled</see> method.

## NotificationsHandled





[WSDL file for Services88/Pocket](../Services88-Pocket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## NotificationsHandled Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Pocket:ApplicationToken>1234567-1234-9876</Pocket:ApplicationToken>
  <Pocket:Credentials>
    <Pocket:Ticket>7T:1234abcxyzExample==</Pocket:Ticket>
  </Pocket:Credentials>
 <SOAP-ENV:Body>
   <Pocket:NotificationsHandled>
    <Pocket:NotificationEvents xsi:type="Pocket:ArrayOfNotificationEvent">
     <Pocket:NotificationEvent xsi:type="Pocket:NotificationEvent">
      <Pocket:Type xsi:type="Pocket:NotificationEventType">Unknown</Pocket:Type>
      <Pocket:Id xsi:type="xsd:int">0</Pocket:Id>
     </Pocket:NotificationEvent>
    </Pocket:NotificationEvents>
   </Pocket:NotificationsHandled>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## NotificationsHandled Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Pocket:NotificationsHandledResponse>
  </Pocket:NotificationsHandledResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

