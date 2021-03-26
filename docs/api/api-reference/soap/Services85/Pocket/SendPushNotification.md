---
uid: services85-pocket-sendpushnotification
title: Services85.PocketAgent.SendPushNotification SOAP
Generated: true
---

# Services85 Pocket SendPushNotification SOAP

SOAP request and response examples **Remote/Services85/Pocket.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IPocketAgent.SendPushNotification">SuperOffice.Services85.IPocketAgent.SendPushNotification</see> method.

## SendPushNotification

Send a push notification to one or more associates

* **associateIds:** The associates to send the push notification message to
* **message:** The message to send



[WSDL file for Services85/Pocket](../Services85-Pocket.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SendPushNotification Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Pocket:ApplicationToken>1234567-1234-9876</Pocket:ApplicationToken>
  <Pocket:Credentials>
    <Pocket:Ticket>7T:1234abcxyzExample==</Pocket:Ticket>
  </Pocket:Credentials>
 <SOAP-ENV:Body>
   <Pocket:SendPushNotification>
    <Pocket:AssociateIds xsi:type="NetServerServices852:ArrayOfint">
     <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
    </Pocket:AssociateIds>
    <Pocket:Message xsi:type="Pocket:PocketNotificationMessage">
     <Pocket:Title xsi:type="xsd:string"></Pocket:Title>
     <Pocket:Message xsi:type="xsd:string"></Pocket:Message>
     <Pocket:Url xsi:type="xsd:string"></Pocket:Url>
     <Pocket:Silent xsi:type="xsd:boolean">false</Pocket:Silent>
     <Pocket:Type xsi:type="Pocket:NotificationMessageType">Message</Pocket:Type>
     <Pocket:TimeToLive xsi:type="xsd:int">0</Pocket:TimeToLive>
     <Pocket:RecordId xsi:type="xsd:int">0</Pocket:RecordId>
     <Pocket:Date xsi:type="xsd:dateTime">2021-03-25T21:35:53Z</Pocket:Date>
     <Pocket:Duration xsi:type="NetServerServices851:duration"></Pocket:Duration>
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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Pocket:SendPushNotificationResponse>
  </Pocket:SendPushNotificationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

