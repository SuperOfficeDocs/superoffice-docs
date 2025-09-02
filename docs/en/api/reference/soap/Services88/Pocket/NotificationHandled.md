---
title: Services88.PocketAgent.NotificationHandled SOAP
generated: true
uid: Services88-Pocket-NotificationHandled
content_type: reference
---

# Services88 Pocket NotificationHandled

SOAP request and response examples **Remote/Services88/Pocket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPocketAgent.NotificationHandled">SuperOffice.Services88.IPocketAgent.NotificationHandled</see> method.

## NotificationHandled





[WSDL file for Services88/Pocket](../Services88-Pocket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## NotificationHandled Request

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
   <Pocket:NotificationHandled>
    <Pocket:NotificationEventType xsi:type="Pocket:NotificationEventType">Unknown</Pocket:NotificationEventType>
    <Pocket:Id xsi:type="xsd:int">0</Pocket:Id>
   </Pocket:NotificationHandled>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## NotificationHandled Response

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
  <Pocket:NotificationHandledResponse>
  </Pocket:NotificationHandledResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

