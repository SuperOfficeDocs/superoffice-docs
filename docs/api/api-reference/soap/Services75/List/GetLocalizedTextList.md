---
uid: services75-list-getlocalizedtextlist
title: Services75.ListAgent.GetLocalizedTextList SOAP
Generated: true
---

# Services75 List GetLocalizedTextList SOAP

SOAP request and response examples **Remote/Services75/List.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IListAgent.GetLocalizedTextList">SuperOffice.Services75.IListAgent.GetLocalizedTextList</see> method.

## GetLocalizedTextList

Gets an array of LocalizedText objects.

* **localizedTextIds:** The identifiers of the LocalizedText object

**Returns:** Array of LocalizedText objects


[WSDL file for Services75/List](../Services75-List.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLocalizedTextList Request

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
   <List:GetLocalizedTextList>
    <List:LocalizedTextIds xsi:type="NetServerServices752:ArrayOfint">
     <NetServerServices752:int xsi:type="xsd:int">0</NetServerServices752:int>
    </List:LocalizedTextIds>
   </List:GetLocalizedTextList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetLocalizedTextList Response

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
  <List:GetLocalizedTextListResponse>
   <List:Response xsi:type="List:ArrayOfLocalizedText">
    <List:LocalizedText xsi:type="List:LocalizedText">
     <List:LanguageId xsi:type="xsd:int">0</List:LanguageId>
     <List:ResourceId xsi:type="xsd:int">0</List:ResourceId>
     <List:Text xsi:type="xsd:string"></List:Text>
     <List:Type xsi:type="List:LocalizedTextType">Unknown</List:Type>
     <List:LocalizedTextId xsi:type="xsd:int">0</List:LocalizedTextId>
     <List:IsBuiltIn xsi:type="xsd:boolean">false</List:IsBuiltIn>
    </List:LocalizedText>
   </List:Response>
  </List:GetLocalizedTextListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

