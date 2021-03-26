---
uid: services88-pocket-sendpushnotification
title: Services88.PocketAgent.SendPushNotification SOAP
Generated: true
---

# Services88 Pocket SendPushNotification SOAP

SOAP request and response examples **Remote/Services88/Pocket.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPocketAgent.SendPushNotification">SuperOffice.Services88.IPocketAgent.SendPushNotification</see> method.

## SendPushNotification

Send a push notification to one or more associates

* **associateIds:** The associates to send the push notification message to
* **message:** The message to send



[WSDL file for Services88/Pocket](../Services88-Pocket.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SendPushNotification Request

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
   <Pocket:SendPushNotification>
    <Pocket:AssociateIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Pocket:AssociateIds>
    <Pocket:Message xsi:type="Pocket:PocketNotificationMessage">
     <Pocket:Title xsi:type="xsd:string"></Pocket:Title>
     <Pocket:Message xsi:type="xsd:string"></Pocket:Message>
     <Pocket:Url xsi:type="xsd:string"></Pocket:Url>
     <Pocket:Silent xsi:type="xsd:boolean">false</Pocket:Silent>
     <Pocket:Type xsi:type="Pocket:NotificationMessageType">Message</Pocket:Type>
     <Pocket:TimeToLive xsi:type="xsd:int">0</Pocket:TimeToLive>
     <Pocket:RecordId xsi:type="xsd:int">0</Pocket:RecordId>
     <Pocket:Date xsi:type="xsd:dateTime">2021-03-25T21:37:06Z</Pocket:Date>
     <Pocket:Duration xsi:type="NetServerServices881:duration"></Pocket:Duration>
     <Pocket:ExtraValues xsi:type="Pocket:StringDictionary">
      <Pocket:StringKeyValuePair>
       <Pocket:Key xsi:type="xsd:string"></Pocket:Key>
       <Pocket:Value xsi:type="xsd:string"></Pocket:Value>
      </Pocket:StringKeyValuePair>
     </Pocket:ExtraValues>
    </Pocket:Message>
   </Pocket:SendPushNotification>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SendPushNotification Response

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
  <Pocket:SendPushNotificationResponse>
  </Pocket:SendPushNotificationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

