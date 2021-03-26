---
uid: services75-list-getlink
title: Services75.ListAgent.GetLink SOAP
Generated: true
---

# Services75 List GetLink SOAP

SOAP request and response examples **Remote/Services75/List.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IListAgent.GetLink">SuperOffice.Services75.IListAgent.GetLink</see> method.

## GetLink

Gets a Link object.

* **linkId:** The identifier of the Link object

**Returns:** Link


[WSDL file for Services75/List](../Services75-List.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLink Request

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
   <List:GetLink>
    <List:LinkId xsi:type="xsd:int">0</List:LinkId>
   </List:GetLink>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetLink Response

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
  <List:GetLinkResponse>
   <List:Response xsi:type="List:Link">
    <List:EntityName xsi:type="xsd:string"></List:EntityName>
    <List:Id xsi:type="xsd:int">0</List:Id>
    <List:Description xsi:type="xsd:string"></List:Description>
    <List:ExtraInfo xsi:type="xsd:string"></List:ExtraInfo>
    <List:LinkId xsi:type="xsd:int">0</List:LinkId>
   </List:Response>
  </List:GetLinkResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

