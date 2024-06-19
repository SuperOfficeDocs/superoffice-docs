---
title: Services87.ListAgent.SaveDocumentTemplateStream SOAP
generated: 1
uid: Services87-List-SaveDocumentTemplateStream
---

# Services87 List SaveDocumentTemplateStream

SOAP request and response examples **Remote/Services87/List.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IListAgent.SaveDocumentTemplateStream">SuperOffice.Services87.IListAgent.SaveDocumentTemplateStream</see> method.

## SaveDocumentTemplateStream

[WSDL file for Services87/List](../Services87-List.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveDocumentTemplateStream Request

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
   <List:SaveDocumentTemplateStream>
    <List:DocumentTemplateId xsi:type="xsd:int">0</List:DocumentTemplateId>
    <List:Content xsi:type="xsd:base64Binary"></List:Content>
    <List:LanguageCode xsi:type="xsd:string"></List:LanguageCode>
    <List:PluginId xsi:type="xsd:int">0</List:PluginId>
   </List:SaveDocumentTemplateStream>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

## SaveDocumentTemplateStream Response

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
  <List:SaveDocumentTemplateStreamResponse>
   <List:Response xsi:type="List:TemplateInfo">
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Description xsi:type="xsd:string"></List:Description>
    <List:ExternalReference xsi:type="xsd:string"></List:ExternalReference>
    <List:PluginId xsi:type="xsd:int">0</List:PluginId>
   </List:Response>
  </List:SaveDocumentTemplateStreamResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```
