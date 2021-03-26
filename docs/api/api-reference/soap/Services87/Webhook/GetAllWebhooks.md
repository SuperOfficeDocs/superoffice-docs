---
uid: services87-webhook-getallwebhooks
title: Services87.WebhookAgent.GetAllWebhooks SOAP
Generated: true
---

# Services87 Webhook GetAllWebhooks SOAP

SOAP request and response examples **Remote/Services87/Webhook.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IWebhookAgent.GetAllWebhooks">SuperOffice.Services87.IWebhookAgent.GetAllWebhooks</see> method.

## GetAllWebhooks

Returns all webhooks, according to filter criteria
<para /><b>Online Restricted:</b> The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.

* **nameFilter:** Only return hooks with this name. Default NULL = no filter
* **eventFilter:** Only return hooks responding to this event name. Default NULL = no filter
* **statusFilter:** Only return hooks with this status. Default Unknown = no filter, returns all.

**Returns:** Array of all webhooks, filtered according to given criteria.


[WSDL file for Services87/Webhook](../Services87-Webhook.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllWebhooks Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Webhook="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Webhook:ApplicationToken>1234567-1234-9876</Webhook:ApplicationToken>
  <Webhook:Credentials>
    <Webhook:Ticket>7T:1234abcxyzExample==</Webhook:Ticket>
  </Webhook:Credentials>
 <SOAP-ENV:Body>
   <Webhook:GetAllWebhooks>
    <Webhook:NameFilter xsi:type="xsd:string"></Webhook:NameFilter>
    <Webhook:EventFilter xsi:type="xsd:string"></Webhook:EventFilter>
    <Webhook:StatusFilter xsi:type="Webhook:WebhookState">Unknown</Webhook:StatusFilter>
   </Webhook:GetAllWebhooks>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllWebhooks Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Webhook="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Webhook:GetAllWebhooksResponse>
   <Webhook:Response xsi:type="Webhook:ArrayOfWebhook">
    <Webhook:Webhook xsi:type="Webhook:Webhook">
     <Webhook:WebhookId xsi:type="xsd:int">0</Webhook:WebhookId>
     <Webhook:Name xsi:type="xsd:string"></Webhook:Name>
     <Webhook:Events xsi:type="NetServerServices872:ArrayOfstring">
      <NetServerServices872:string xsi:type="xsd:string"></NetServerServices872:string>
     </Webhook:Events>
     <Webhook:TargetUrl xsi:type="xsd:string"></Webhook:TargetUrl>
     <Webhook:Secret xsi:type="xsd:string"></Webhook:Secret>
     <Webhook:State xsi:type="Webhook:WebhookState">Unknown</Webhook:State>
     <Webhook:Type xsi:type="xsd:string"></Webhook:Type>
     <Webhook:Headers xsi:type="Webhook:StringDictionary">
      <Webhook:StringKeyValuePair>
       <Webhook:Key xsi:type="xsd:string"></Webhook:Key>
       <Webhook:Value xsi:type="xsd:string"></Webhook:Value>
      </Webhook:StringKeyValuePair>
     </Webhook:Headers>
     <Webhook:Properties xsi:type="Webhook:StringObjectDictionary">
      <Webhook:StringObjectKeyValuePair>
       <Webhook:Key xsi:type="xsd:string"></Webhook:Key>
       <Webhook:Value xsi:type="xsd:anyType"></Webhook:Value>
      </Webhook:StringObjectKeyValuePair>
     </Webhook:Properties>
     <Webhook:Registered xsi:type="xsd:dateTime">2021-03-25T21:36:49Z</Webhook:Registered>
     <Webhook:RegisteredAssociate xsi:type="Webhook:Associate">
      <Webhook:AssociateId xsi:type="xsd:int">0</Webhook:AssociateId>
      <Webhook:Name xsi:type="xsd:string"></Webhook:Name>
      <Webhook:PersonId xsi:type="xsd:int">0</Webhook:PersonId>
      <Webhook:Rank xsi:type="xsd:short">0</Webhook:Rank>
      <Webhook:Tooltip xsi:type="xsd:string"></Webhook:Tooltip>
      <Webhook:Type xsi:type="Webhook:UserType">Unknown</Webhook:Type>
      <Webhook:GroupIdx xsi:type="xsd:int">0</Webhook:GroupIdx>
      <Webhook:FullName xsi:type="xsd:string"></Webhook:FullName>
      <Webhook:FormalName xsi:type="xsd:string"></Webhook:FormalName>
      <Webhook:Deleted xsi:type="xsd:boolean">false</Webhook:Deleted>
      <Webhook:EjUserId xsi:type="xsd:int">0</Webhook:EjUserId>
      <Webhook:UserName xsi:type="xsd:string"></Webhook:UserName>
     </Webhook:RegisteredAssociate>
     <Webhook:Updated xsi:type="xsd:dateTime">2021-03-25T21:36:49Z</Webhook:Updated>
     <Webhook:UpdatedAssociate xsi:type="Webhook:Associate">
      <Webhook:AssociateId xsi:type="xsd:int">0</Webhook:AssociateId>
      <Webhook:Name xsi:type="xsd:string"></Webhook:Name>
      <Webhook:PersonId xsi:type="xsd:int">0</Webhook:PersonId>
      <Webhook:Rank xsi:type="xsd:short">0</Webhook:Rank>
      <Webhook:Tooltip xsi:type="xsd:string"></Webhook:Tooltip>
      <Webhook:Type xsi:type="Webhook:UserType">Unknown</Webhook:Type>
      <Webhook:GroupIdx xsi:type="xsd:int">0</Webhook:GroupIdx>
      <Webhook:FullName xsi:type="xsd:string"></Webhook:FullName>
      <Webhook:FormalName xsi:type="xsd:string"></Webhook:FormalName>
      <Webhook:Deleted xsi:type="xsd:boolean">false</Webhook:Deleted>
      <Webhook:EjUserId xsi:type="xsd:int">0</Webhook:EjUserId>
      <Webhook:UserName xsi:type="xsd:string"></Webhook:UserName>
     </Webhook:UpdatedAssociate>
    </Webhook:Webhook>
   </Webhook:Response>
  </Webhook:GetAllWebhooksResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

