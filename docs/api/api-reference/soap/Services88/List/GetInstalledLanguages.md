---
uid: services88-list-getinstalledlanguages
title: Services88.ListAgent.GetInstalledLanguages SOAP
Generated: true
---

# Services88 List GetInstalledLanguages SOAP

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.GetInstalledLanguages">SuperOffice.Services88.IListAgent.GetInstalledLanguages</see> method.

## GetInstalledLanguages

Returns the list of all languages installed in this database.


**Returns:** Array of installed languages


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetInstalledLanguages Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetInstalledLanguages>
   </List:GetInstalledLanguages>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetInstalledLanguages Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <List:GetInstalledLanguagesResponse>
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
  </List:GetInstalledLanguagesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

