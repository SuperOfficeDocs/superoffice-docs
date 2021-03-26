---
uid: services83-list-getlinklist
title: Services83.ListAgent.GetLinkList SOAP
Generated: true
---

# Services83 List GetLinkList SOAP

SOAP request and response examples **Remote/Services83/List.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IListAgent.GetLinkList">SuperOffice.Services83.IListAgent.GetLinkList</see> method.

## GetLinkList

Gets an array of Link objects.

* **linkIds:** The identifiers of the Link object

**Returns:** Array of Link objects


[WSDL file for Services83/List](../Services83-List.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLinkList Request

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
   <List:GetLinkList>
    <List:LinkIds xsi:type="NetServerServices832:ArrayOfint">
     <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
    </List:LinkIds>
   </List:GetLinkList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetLinkList Response

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
  <List:GetLinkListResponse>
   <List:Response xsi:type="List:ArrayOfLink">
    <List:Link xsi:type="List:Link">
     <List:EntityName xsi:type="xsd:string"></List:EntityName>
     <List:Id xsi:type="xsd:int">0</List:Id>
     <List:Description xsi:type="xsd:string"></List:Description>
     <List:ExtraInfo xsi:type="xsd:string"></List:ExtraInfo>
     <List:LinkId xsi:type="xsd:int">0</List:LinkId>
    </List:Link>
   </List:Response>
  </List:GetLinkListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

