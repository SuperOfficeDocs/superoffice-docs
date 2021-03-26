---
uid: services82-list-getlocalizedtexts
title: Services82.ListAgent.GetLocalizedTexts SOAP
Generated: true
---

# Services82 List GetLocalizedTexts SOAP

SOAP request and response examples **Remote/Services82/List.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IListAgent.GetLocalizedTexts">SuperOffice.Services82.IListAgent.GetLocalizedTexts</see> method.

## GetLocalizedTexts

Gets all localized texts in the CRM database.


**Returns:** Array of LocalizedText objects


[WSDL file for Services82/List](../Services82-List.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLocalizedTexts Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetLocalizedTexts>
   </List:GetLocalizedTexts>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetLocalizedTexts Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <List:GetLocalizedTextsResponse>
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
  </List:GetLocalizedTextsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

