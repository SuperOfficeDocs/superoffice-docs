---
uid: services86-pocket-setpushnotificationtagsforuser
title: Services86.PocketAgent.SetPushNotificationTagsForUser SOAP
Generated: true
---

# Services86 Pocket SetPushNotificationTagsForUser SOAP

SOAP request and response examples **Remote/Services86/Pocket.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IPocketAgent.SetPushNotificationTagsForUser">SuperOffice.Services86.IPocketAgent.SetPushNotificationTagsForUser</see> method.

## SetPushNotificationTagsForUser

Specify what kind of notification events a user should receive push notifications for.  This will update all registerred devices for this user.

* **associateId:** The associate to set tags for
* **tags:** A comma separated list of events the associate should receive push events for



[WSDL file for Services86/Pocket](../Services86-Pocket.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetPushNotificationTagsForUser Request

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
   <Pocket:SetPushNotificationTagsForUser>
    <Pocket:AssociateId xsi:type="xsd:int">0</Pocket:AssociateId>
    <Pocket:Tags xsi:type="xsd:string"></Pocket:Tags>
   </Pocket:SetPushNotificationTagsForUser>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetPushNotificationTagsForUser Response

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
  <Pocket:SetPushNotificationTagsForUserResponse>
  </Pocket:SetPushNotificationTagsForUserResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

