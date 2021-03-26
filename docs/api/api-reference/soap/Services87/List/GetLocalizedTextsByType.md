---
uid: services87-list-getlocalizedtextsbytype
title: Services87.ListAgent.GetLocalizedTextsByType SOAP
Generated: true
---

# Services87 List GetLocalizedTextsByType SOAP

SOAP request and response examples **Remote/Services87/List.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IListAgent.GetLocalizedTextsByType">SuperOffice.Services87.IListAgent.GetLocalizedTextsByType</see> method.

## GetLocalizedTextsByType

Gets localized text by their type

* **textTypes:** Array of LocalizedTextTypes. If null all texts are returned.

**Returns:** Array of LocalizedText objects


[WSDL file for Services87/List](../Services87-List.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLocalizedTextsByType Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetLocalizedTextsByType>
    <List:TextTypes xsi:type="List:ArrayOfLocalizedTextType">
     <List:LocalizedTextType xsi:type="List:LocalizedTextType">Unknown</List:LocalizedTextType>
    </List:TextTypes>
   </List:GetLocalizedTextsByType>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetLocalizedTextsByType Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <List:GetLocalizedTextsByTypeResponse>
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
  </List:GetLocalizedTextsByTypeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

