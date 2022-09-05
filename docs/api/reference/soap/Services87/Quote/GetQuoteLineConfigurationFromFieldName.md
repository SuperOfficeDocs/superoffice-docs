---
title: Services87.QuoteAgent.GetQuoteLineConfigurationFromFieldName SOAP
generated: 1
uid: Services87-Quote-GetQuoteLineConfigurationFromFieldName
---

# Services87 Quote GetQuoteLineConfigurationFromFieldName

SOAP request and response examples **Remote/Services87/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IQuoteAgent.GetQuoteLineConfigurationFromFieldName">SuperOffice.Services87.IQuoteAgent.GetQuoteLineConfigurationFromFieldName</see> method.

## GetQuoteLineConfigurationFromFieldName

Returns the configuration field with the given field name

* **fieldName:** Field name of the QuoteLineConfiguration to get.

**Returns:** QuoteLineConfiguration


[WSDL file for Services87/Quote](../Services87-Quote.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetQuoteLineConfigurationFromFieldName Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetQuoteLineConfigurationFromFieldName>
    <Quote:FieldName xsi:type="xsd:string"></Quote:FieldName>
   </Quote:GetQuoteLineConfigurationFromFieldName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetQuoteLineConfigurationFromFieldName Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Quote:GetQuoteLineConfigurationFromFieldNameResponse>
   <Quote:Response xsi:type="Quote:QuoteLineConfiguration">
    <Quote:QuoteLineConfigurationId xsi:type="xsd:int">0</Quote:QuoteLineConfigurationId>
    <Quote:FieldName xsi:type="xsd:string"></Quote:FieldName>
    <Quote:Label xsi:type="xsd:string"></Quote:Label>
    <Quote:Tooltip xsi:type="xsd:string"></Quote:Tooltip>
    <Quote:Editable xsi:type="xsd:boolean">false</Quote:Editable>
    <Quote:InUse xsi:type="xsd:boolean">false</Quote:InUse>
    <Quote:Mandatory xsi:type="xsd:boolean">false</Quote:Mandatory>
    <Quote:Rank xsi:type="xsd:int">0</Quote:Rank>
    <Quote:RestrictEdit xsi:type="xsd:boolean">false</Quote:RestrictEdit>
   </Quote:Response>
  </Quote:GetQuoteLineConfigurationFromFieldNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

