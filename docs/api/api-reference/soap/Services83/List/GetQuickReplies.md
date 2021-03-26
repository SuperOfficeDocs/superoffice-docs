---
uid: services83-list-getquickreplies
title: Services83.ListAgent.GetQuickReplies SOAP
Generated: true
---

# Services83 List GetQuickReplies SOAP

SOAP request and response examples **Remote/Services83/List.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IListAgent.GetQuickReplies">SuperOffice.Services83.IListAgent.GetQuickReplies</see> method.

## GetQuickReplies

Method to return all quick replies for a given associate


**Returns:** Array of quick replies


[WSDL file for Services83/List](../Services83-List.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetQuickReplies Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetQuickReplies>
   </List:GetQuickReplies>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetQuickReplies Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <List:GetQuickRepliesResponse>
   <List:Response xsi:type="List:ArrayOfQuickReply">
    <List:QuickReply xsi:type="List:QuickReply">
     <List:QuickReplyId xsi:type="xsd:int">0</List:QuickReplyId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:HtmlBody xsi:type="xsd:string"></List:HtmlBody>
    </List:QuickReply>
   </List:Response>
  </List:GetQuickRepliesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

