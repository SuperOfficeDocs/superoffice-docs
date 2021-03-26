---
uid: services86-webhook-getwebhook
title: Services86.WebhookAgent.GetWebhook SOAP
Generated: true
---

# Services86 Webhook GetWebhook SOAP

SOAP request and response examples **Remote/Services86/Webhook.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IWebhookAgent.GetWebhook">SuperOffice.Services86.IWebhookAgent.GetWebhook</see> method.

## GetWebhook

Gets a Webhook object.
<para /><b>Online Restricted:</b> The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.

* **webhookId:** The identifier of the Webhook object

**Returns:** Webhook


[WSDL file for Services86/Webhook](../Services86-Webhook.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetWebhook Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Webhook="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Webhook:ApplicationToken>1234567-1234-9876</Webhook:ApplicationToken>
  <Webhook:Credentials>
    <Webhook:Ticket>7T:1234abcxyzExample==</Webhook:Ticket>
  </Webhook:Credentials>
 <SOAP-ENV:Body>
   <Webhook:GetWebhook>
    <Webhook:WebhookId xsi:type="xsd:int">0</Webhook:WebhookId>
   </Webhook:GetWebhook>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetWebhook Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Webhook="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Webhook:GetWebhookResponse>
   <Webhook:Response xsi:type="Webhook:Webhook">
    <Webhook:WebhookId xsi:type="xsd:int">0</Webhook:WebhookId>
    <Webhook:Name xsi:type="xsd:string"></Webhook:Name>
    <Webhook:Events xsi:type="NetServerServices862:ArrayOfstring">
     <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
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
    <Webhook:Registered xsi:type="xsd:dateTime">2021-03-25T21:36:25Z</Webhook:Registered>
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
    <Webhook:Updated xsi:type="xsd:dateTime">2021-03-25T21:36:25Z</Webhook:Updated>
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
   </Webhook:Response>
  </Webhook:GetWebhookResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

