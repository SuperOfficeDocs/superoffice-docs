---
uid: services85-webhook-testwebhook
title: Services85.WebhookAgent.TestWebhook SOAP
Generated: true
---

# Services85 Webhook TestWebhook SOAP

SOAP request and response examples **Remote/Services85/Webhook.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IWebhookAgent.TestWebhook">SuperOffice.Services85.IWebhookAgent.TestWebhook</see> method.

## TestWebhook

Pings a webhook with a 'test' event, returns SUCCESS(true) or FAILURE(false) + the response from the webhook target.

* **webhook:** Webhook definition to ping. Must contain a valid TargetUrl.

**Returns:** Result of calling webhook. Sucess=true/false + Error message


[WSDL file for Services85/Webhook](../Services85-Webhook.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## TestWebhook Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Webhook="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Webhook:ApplicationToken>1234567-1234-9876</Webhook:ApplicationToken>
  <Webhook:Credentials>
    <Webhook:Ticket>7T:1234abcxyzExample==</Webhook:Ticket>
  </Webhook:Credentials>
 <SOAP-ENV:Body>
   <Webhook:TestWebhook>
    <Webhook:Webhook xsi:type="Webhook:Webhook">
     <Webhook:WebhookId xsi:type="xsd:int">0</Webhook:WebhookId>
     <Webhook:Name xsi:type="xsd:string"></Webhook:Name>
     <Webhook:Events xsi:type="NetServerServices852:ArrayOfstring">
      <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
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
     <Webhook:Registered xsi:type="xsd:dateTime">2021-03-25T21:36:01Z</Webhook:Registered>
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
     </Webhook:RegisteredAssociate>
     <Webhook:Updated xsi:type="xsd:dateTime">2021-03-25T21:36:01Z</Webhook:Updated>
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
     </Webhook:UpdatedAssociate>
    </Webhook:Webhook>
   </Webhook:TestWebhook>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## TestWebhook Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Webhook="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Webhook:TestWebhookResponse>
   <Webhook:Response xsi:type="Webhook:WebhookResult">
    <Webhook:Success xsi:type="xsd:boolean">false</Webhook:Success>
    <Webhook:Message xsi:type="xsd:string"></Webhook:Message>
   </Webhook:Response>
  </Webhook:TestWebhookResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

