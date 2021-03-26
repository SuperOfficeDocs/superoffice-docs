---
uid: services87-pocket-sendpushnotification
title: Services87.PocketAgent.SendPushNotification SOAP
Generated: true
---

# Services87 Pocket SendPushNotification SOAP

SOAP request and response examples **Remote/Services87/Pocket.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IPocketAgent.SendPushNotification">SuperOffice.Services87.IPocketAgent.SendPushNotification</see> method.

## SendPushNotification

Send a push notification to one or more associates

* **associateIds:** The associates to send the push notification message to
* **message:** The message to send



[WSDL file for Services87/Pocket](../Services87-Pocket.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SendPushNotification Request

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
   <Pocket:SendPushNotification>
    <Pocket:AssociateIds xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
    </Pocket:AssociateIds>
    <Pocket:Message xsi:type="Pocket:PocketNotificationMessage">
     <Pocket:Title xsi:type="xsd:string"></Pocket:Title>
     <Pocket:Message xsi:type="xsd:string"></Pocket:Message>
     <Pocket:Url xsi:type="xsd:string"></Pocket:Url>
     <Pocket:Silent xsi:type="xsd:boolean">false</Pocket:Silent>
     <Pocket:Type xsi:type="Pocket:NotificationMessageType">Message</Pocket:Type>
     <Pocket:TimeToLive xsi:type="xsd:int">0</Pocket:TimeToLive>
     <Pocket:RecordId xsi:type="xsd:int">0</Pocket:RecordId>
     <Pocket:Date xsi:type="xsd:dateTime">2021-03-25T21:36:40Z</Pocket:Date>
     <Pocket:Duration xsi:type="NetServerServices871:duration"></Pocket:Duration>
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
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Pocket:SendPushNotificationResponse>
  </Pocket:SendPushNotificationResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

