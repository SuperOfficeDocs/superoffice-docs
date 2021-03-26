---
uid: services75-list-getlinklist
title: Services75.ListAgent.GetLinkList SOAP
Generated: true
---

# Services75 List GetLinkList SOAP

SOAP request and response examples **Remote/Services75/List.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IListAgent.GetLinkList">SuperOffice.Services75.IListAgent.GetLinkList</see> method.

## GetLinkList

Gets an array of Link objects.

* **linkIds:** The identifiers of the Link object

**Returns:** Array of Link objects


[WSDL file for Services75/List](../Services75-List.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLinkList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetLinkList>
    <List:LinkIds xsi:type="NetServerServices752:ArrayOfint">
     <NetServerServices752:int xsi:type="xsd:int">0</NetServerServices752:int>
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
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services75">
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

