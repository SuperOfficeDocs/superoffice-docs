---
uid: services81-list-getlanguageinfolist
title: Services81.ListAgent.GetLanguageInfoList SOAP
Generated: true
---

# Services81 List GetLanguageInfoList SOAP

SOAP request and response examples **Remote/Services81/List.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IListAgent.GetLanguageInfoList">SuperOffice.Services81.IListAgent.GetLanguageInfoList</see> method.

## GetLanguageInfoList

Gets an array of LanguageInfo objects.

* **languageInfoIds:** The identifiers of the LanguageInfo object

**Returns:** Array of LanguageInfo objects


[WSDL file for Services81/List](../Services81-List.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLanguageInfoList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetLanguageInfoList>
    <List:LanguageInfoIds xsi:type="NetServerServices812:ArrayOfint">
     <NetServerServices812:int xsi:type="xsd:int">0</NetServerServices812:int>
    </List:LanguageInfoIds>
   </List:GetLanguageInfoList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetLanguageInfoList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <List:GetLanguageInfoListResponse>
   <List:Response xsi:type="List:ArrayOfLanguageInfo">
    <List:LanguageInfo xsi:type="List:LanguageInfo">
     <List:LanguageInfoId xsi:type="xsd:int">0</List:LanguageInfoId>
     <List:LCID xsi:type="xsd:int">0</List:LCID>
     <List:EnglishName xsi:type="xsd:string"></List:EnglishName>
     <List:NativeName xsi:type="xsd:string"></List:NativeName>
     <List:ThreeLetterISOLanguageName xsi:type="xsd:string"></List:ThreeLetterISOLanguageName>
     <List:TwoLetterISOLanguageName xsi:type="xsd:string"></List:TwoLetterISOLanguageName>
     <List:IsBuiltIn xsi:type="xsd:boolean">false</List:IsBuiltIn>
    </List:LanguageInfo>
   </List:Response>
  </List:GetLanguageInfoListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

