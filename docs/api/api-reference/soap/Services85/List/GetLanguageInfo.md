---
uid: services85-list-getlanguageinfo
title: Services85.ListAgent.GetLanguageInfo SOAP
Generated: true
---

# Services85 List GetLanguageInfo SOAP

SOAP request and response examples **Remote/Services85/List.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IListAgent.GetLanguageInfo">SuperOffice.Services85.IListAgent.GetLanguageInfo</see> method.

## GetLanguageInfo

Gets a LanguageInfo object.

* **languageInfoId:** The identifier of the LanguageInfo object

**Returns:** LanguageInfo


[WSDL file for Services85/List](../Services85-List.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLanguageInfo Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetLanguageInfo>
    <List:LanguageInfoId xsi:type="xsd:int">0</List:LanguageInfoId>
   </List:GetLanguageInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetLanguageInfo Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <List:GetLanguageInfoResponse>
   <List:Response xsi:type="List:LanguageInfo">
    <List:LanguageInfoId xsi:type="xsd:int">0</List:LanguageInfoId>
    <List:LCID xsi:type="xsd:int">0</List:LCID>
    <List:EnglishName xsi:type="xsd:string"></List:EnglishName>
    <List:NativeName xsi:type="xsd:string"></List:NativeName>
    <List:ThreeLetterISOLanguageName xsi:type="xsd:string"></List:ThreeLetterISOLanguageName>
    <List:TwoLetterISOLanguageName xsi:type="xsd:string"></List:TwoLetterISOLanguageName>
    <List:IsBuiltIn xsi:type="xsd:boolean">false</List:IsBuiltIn>
   </List:Response>
  </List:GetLanguageInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

