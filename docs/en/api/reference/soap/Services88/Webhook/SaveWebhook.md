---
title: Services88.WebhookAgent.SaveWebhook SOAP
generated: true
uid: Services88-Webhook-SaveWebhook
content_type: reference
---

# Services88 Webhook SaveWebhook

SOAP request and response examples **Remote/Services88/Webhook.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IWebhookAgent.SaveWebhook">SuperOffice.Services88.IWebhookAgent.SaveWebhook</see> method.

## SaveWebhook





[WSDL file for Services88/Webhook](../Services88-Webhook.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveWebhook Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Webhook="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Webhook:ApplicationToken>1234567-1234-9876</Webhook:ApplicationToken>
  <Webhook:Credentials>
    <Webhook:Ticket>7T:1234abcxyzExample==</Webhook:Ticket>
  </Webhook:Credentials>
 <SOAP-ENV:Body>
   <Webhook:SaveWebhook>
    <Webhook:Webhook xsi:type="Webhook:Webhook">
     <Webhook:WebhookId xsi:type="xsd:int">0</Webhook:WebhookId>
     <Webhook:Name xsi:type="xsd:string"></Webhook:Name>
     <Webhook:Events xsi:type="NetServerServices882:ArrayOfstring">
      <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
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
     <Webhook:Registered xsi:type="xsd:dateTime">2026-07-02T01:24:15Z</Webhook:Registered>
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
      <Webhook:ExtraFields xsi:type="Webhook:StringDictionary">
       <Webhook:StringKeyValuePair>
        <Webhook:Key xsi:type="xsd:string"></Webhook:Key>
        <Webhook:Value xsi:type="xsd:string"></Webhook:Value>
       </Webhook:StringKeyValuePair>
      </Webhook:ExtraFields>
      <Webhook:CustomFields xsi:type="Webhook:StringDictionary">
       <Webhook:StringKeyValuePair>
        <Webhook:Key xsi:type="xsd:string"></Webhook:Key>
        <Webhook:Value xsi:type="xsd:string"></Webhook:Value>
       </Webhook:StringKeyValuePair>
      </Webhook:CustomFields>
     </Webhook:RegisteredAssociate>
     <Webhook:Updated xsi:type="xsd:dateTime">2026-07-02T01:24:15Z</Webhook:Updated>
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
      <Webhook:ExtraFields xsi:type="Webhook:StringDictionary">
       <Webhook:StringKeyValuePair>
        <Webhook:Key xsi:type="xsd:string"></Webhook:Key>
        <Webhook:Value xsi:type="xsd:string"></Webhook:Value>
       </Webhook:StringKeyValuePair>
      </Webhook:ExtraFields>
      <Webhook:CustomFields xsi:type="Webhook:StringDictionary">
       <Webhook:StringKeyValuePair>
        <Webhook:Key xsi:type="xsd:string"></Webhook:Key>
        <Webhook:Value xsi:type="xsd:string"></Webhook:Value>
       </Webhook:StringKeyValuePair>
      </Webhook:CustomFields>
     </Webhook:UpdatedAssociate>
     <Webhook:ErrorsEmail xsi:type="xsd:string"></Webhook:ErrorsEmail>
     <Webhook:ErrorEmails xsi:type="NetServerServices882:ArrayOfstring">
      <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
     </Webhook:ErrorEmails>
     <Webhook:ErrorAssociates xsi:type="Webhook:ArrayOfMDOListItem">
      <Webhook:MDOListItem xsi:type="Webhook:MDOListItem">
       <Webhook:Id xsi:type="xsd:int">0</Webhook:Id>
       <Webhook:Name xsi:type="xsd:string"></Webhook:Name>
       <Webhook:ToolTip xsi:type="xsd:string"></Webhook:ToolTip>
       <Webhook:Deleted xsi:type="xsd:boolean">false</Webhook:Deleted>
       <Webhook:Rank xsi:type="xsd:int">0</Webhook:Rank>
       <Webhook:Type xsi:type="xsd:string"></Webhook:Type>
       <Webhook:ChildItems xsi:type="Webhook:ArrayOfMDOListItem">
        <Webhook:MDOListItem xsi:type="Webhook:MDOListItem">
         <Webhook:Id xsi:type="xsd:int">0</Webhook:Id>
         <Webhook:Name xsi:type="xsd:string"></Webhook:Name>
         <Webhook:ToolTip xsi:type="xsd:string"></Webhook:ToolTip>
         <Webhook:Deleted xsi:type="xsd:boolean">false</Webhook:Deleted>
         <Webhook:Rank xsi:type="xsd:int">0</Webhook:Rank>
         <Webhook:Type xsi:type="xsd:string"></Webhook:Type>
         <Webhook:ChildItems xsi:type="Webhook:ArrayOfMDOListItem">
          <Webhook:MDOListItem xsi:nil="true"></Webhook:MDOListItem>
         </Webhook:ChildItems>
         <Webhook:IconHint xsi:type="xsd:string"></Webhook:IconHint>
         <Webhook:ColorBlock xsi:type="xsd:int">0</Webhook:ColorBlock>
         <Webhook:ExtraInfo xsi:type="xsd:string"></Webhook:ExtraInfo>
         <Webhook:StyleHint xsi:type="xsd:string"></Webhook:StyleHint>
         <Webhook:FullName xsi:type="xsd:string"></Webhook:FullName>
        </Webhook:MDOListItem>
       </Webhook:ChildItems>
       <Webhook:IconHint xsi:type="xsd:string"></Webhook:IconHint>
       <Webhook:ColorBlock xsi:type="xsd:int">0</Webhook:ColorBlock>
       <Webhook:ExtraInfo xsi:type="xsd:string"></Webhook:ExtraInfo>
       <Webhook:StyleHint xsi:type="xsd:string"></Webhook:StyleHint>
       <Webhook:FullName xsi:type="xsd:string"></Webhook:FullName>
      </Webhook:MDOListItem>
     </Webhook:ErrorAssociates>
     <Webhook:Description xsi:type="xsd:string"></Webhook:Description>
     <Webhook:NotifyVia xsi:type="Webhook:WebhookNotifyVia">Email</Webhook:NotifyVia>
     <Webhook:NotifyWhen xsi:type="Webhook:WebhookNotifyWhen">FirstFailure</Webhook:NotifyWhen>
     <Webhook:TotalCalls xsi:type="xsd:int">0</Webhook:TotalCalls>
     <Webhook:TotalErrors xsi:type="xsd:int">0</Webhook:TotalErrors>
     <Webhook:ConsecutiveErrors xsi:type="xsd:int">0</Webhook:ConsecutiveErrors>
     <Webhook:LastError xsi:type="xsd:string"></Webhook:LastError>
    </Webhook:Webhook>
   </Webhook:SaveWebhook>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveWebhook Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Webhook="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Webhook:SaveWebhookResponse>
   <Webhook:Response xsi:type="Webhook:Webhook">
    <Webhook:WebhookId xsi:type="xsd:int">0</Webhook:WebhookId>
    <Webhook:Name xsi:type="xsd:string"></Webhook:Name>
    <Webhook:Events xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
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
    <Webhook:Registered xsi:type="xsd:dateTime">2026-07-02T01:24:15Z</Webhook:Registered>
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
     <Webhook:ExtraFields xsi:type="Webhook:StringDictionary">
      <Webhook:StringKeyValuePair>
       <Webhook:Key xsi:type="xsd:string"></Webhook:Key>
       <Webhook:Value xsi:type="xsd:string"></Webhook:Value>
      </Webhook:StringKeyValuePair>
     </Webhook:ExtraFields>
     <Webhook:CustomFields xsi:type="Webhook:StringDictionary">
      <Webhook:StringKeyValuePair>
       <Webhook:Key xsi:type="xsd:string"></Webhook:Key>
       <Webhook:Value xsi:type="xsd:string"></Webhook:Value>
      </Webhook:StringKeyValuePair>
     </Webhook:CustomFields>
    </Webhook:RegisteredAssociate>
    <Webhook:Updated xsi:type="xsd:dateTime">2026-07-02T01:24:15Z</Webhook:Updated>
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
     <Webhook:ExtraFields xsi:type="Webhook:StringDictionary">
      <Webhook:StringKeyValuePair>
       <Webhook:Key xsi:type="xsd:string"></Webhook:Key>
       <Webhook:Value xsi:type="xsd:string"></Webhook:Value>
      </Webhook:StringKeyValuePair>
     </Webhook:ExtraFields>
     <Webhook:CustomFields xsi:type="Webhook:StringDictionary">
      <Webhook:StringKeyValuePair>
       <Webhook:Key xsi:type="xsd:string"></Webhook:Key>
       <Webhook:Value xsi:type="xsd:string"></Webhook:Value>
      </Webhook:StringKeyValuePair>
     </Webhook:CustomFields>
    </Webhook:UpdatedAssociate>
    <Webhook:ErrorsEmail xsi:type="xsd:string"></Webhook:ErrorsEmail>
    <Webhook:ErrorEmails xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Webhook:ErrorEmails>
    <Webhook:ErrorAssociates xsi:type="Webhook:ArrayOfMDOListItem">
     <Webhook:MDOListItem xsi:type="Webhook:MDOListItem">
      <Webhook:Id xsi:type="xsd:int">0</Webhook:Id>
      <Webhook:Name xsi:type="xsd:string"></Webhook:Name>
      <Webhook:ToolTip xsi:type="xsd:string"></Webhook:ToolTip>
      <Webhook:Deleted xsi:type="xsd:boolean">false</Webhook:Deleted>
      <Webhook:Rank xsi:type="xsd:int">0</Webhook:Rank>
      <Webhook:Type xsi:type="xsd:string"></Webhook:Type>
      <Webhook:ChildItems xsi:type="Webhook:ArrayOfMDOListItem">
       <Webhook:MDOListItem xsi:type="Webhook:MDOListItem">
        <Webhook:Id xsi:type="xsd:int">0</Webhook:Id>
        <Webhook:Name xsi:type="xsd:string"></Webhook:Name>
        <Webhook:ToolTip xsi:type="xsd:string"></Webhook:ToolTip>
        <Webhook:Deleted xsi:type="xsd:boolean">false</Webhook:Deleted>
        <Webhook:Rank xsi:type="xsd:int">0</Webhook:Rank>
        <Webhook:Type xsi:type="xsd:string"></Webhook:Type>
        <Webhook:ChildItems xsi:type="Webhook:ArrayOfMDOListItem">
         <Webhook:MDOListItem xsi:type="Webhook:MDOListItem">
          <Webhook:Id xsi:nil="true"></Webhook:Id>
          <Webhook:Name xsi:type="xsd:string"></Webhook:Name>
          <Webhook:ToolTip xsi:type="xsd:string"></Webhook:ToolTip>
          <Webhook:Deleted xsi:nil="true"></Webhook:Deleted>
          <Webhook:Rank xsi:nil="true"></Webhook:Rank>
          <Webhook:Type xsi:type="xsd:string"></Webhook:Type>
          <Webhook:ChildItems xsi:nil="true"></Webhook:ChildItems>
          <Webhook:IconHint xsi:type="xsd:string"></Webhook:IconHint>
          <Webhook:ColorBlock xsi:nil="true"></Webhook:ColorBlock>
          <Webhook:ExtraInfo xsi:type="xsd:string"></Webhook:ExtraInfo>
          <Webhook:StyleHint xsi:type="xsd:string"></Webhook:StyleHint>
          <Webhook:FullName xsi:type="xsd:string"></Webhook:FullName>
         </Webhook:MDOListItem>
        </Webhook:ChildItems>
        <Webhook:IconHint xsi:type="xsd:string"></Webhook:IconHint>
        <Webhook:ColorBlock xsi:type="xsd:int">0</Webhook:ColorBlock>
        <Webhook:ExtraInfo xsi:type="xsd:string"></Webhook:ExtraInfo>
        <Webhook:StyleHint xsi:type="xsd:string"></Webhook:StyleHint>
        <Webhook:FullName xsi:type="xsd:string"></Webhook:FullName>
       </Webhook:MDOListItem>
      </Webhook:ChildItems>
      <Webhook:IconHint xsi:type="xsd:string"></Webhook:IconHint>
      <Webhook:ColorBlock xsi:type="xsd:int">0</Webhook:ColorBlock>
      <Webhook:ExtraInfo xsi:type="xsd:string"></Webhook:ExtraInfo>
      <Webhook:StyleHint xsi:type="xsd:string"></Webhook:StyleHint>
      <Webhook:FullName xsi:type="xsd:string"></Webhook:FullName>
     </Webhook:MDOListItem>
    </Webhook:ErrorAssociates>
    <Webhook:Description xsi:type="xsd:string"></Webhook:Description>
    <Webhook:NotifyVia xsi:type="Webhook:WebhookNotifyVia">Email</Webhook:NotifyVia>
    <Webhook:NotifyWhen xsi:type="Webhook:WebhookNotifyWhen">FirstFailure</Webhook:NotifyWhen>
    <Webhook:TotalCalls xsi:type="xsd:int">0</Webhook:TotalCalls>
    <Webhook:TotalErrors xsi:type="xsd:int">0</Webhook:TotalErrors>
    <Webhook:ConsecutiveErrors xsi:type="xsd:int">0</Webhook:ConsecutiveErrors>
    <Webhook:LastError xsi:type="xsd:string"></Webhook:LastError>
   </Webhook:Response>
  </Webhook:SaveWebhookResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

