---
title: Services88.QuoteAgent.GetConfigurationFields SOAP
generated: true
uid: Services88-Quote-GetConfigurationFields
content_type: reference
---

# Services88 Quote GetConfigurationFields

SOAP request and response examples **Remote/Services88/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IQuoteAgent.GetConfigurationFields">SuperOffice.Services88.IQuoteAgent.GetConfigurationFields</see> method.

## GetConfigurationFields





[WSDL file for Services88/Quote](../Services88-Quote.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetConfigurationFields Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetConfigurationFields>
    <Quote:ConnectionId xsi:type="xsd:int">0</Quote:ConnectionId>
    <Quote:ConnectorName xsi:type="xsd:string"></Quote:ConnectorName>
   </Quote:GetConfigurationFields>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetConfigurationFields Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Quote:GetConfigurationFieldsResponse>
   <Quote:Response xsi:type="Quote:FieldMetadataDictionary">
    <Quote:FieldMetadataDictionaryKeyValuePair>
     <Quote:Key xsi:type="xsd:string"></Quote:Key>
     <Quote:Value xsi:type="Quote:FieldMetadata">
      <Quote:FieldKey xsi:type="xsd:string"></Quote:FieldKey>
      <Quote:Rank xsi:type="xsd:int">0</Quote:Rank>
      <Quote:DisplayName xsi:type="xsd:string"></Quote:DisplayName>
      <Quote:DisplayDescription xsi:type="xsd:string"></Quote:DisplayDescription>
      <Quote:FieldType xsi:type="Quote:FieldMetadataType">Checkbox</Quote:FieldType>
      <Quote:ListName xsi:type="xsd:string"></Quote:ListName>
      <Quote:DefaultValue xsi:type="xsd:string"></Quote:DefaultValue>
      <Quote:MaxLength xsi:type="xsd:int">0</Quote:MaxLength>
      <Quote:Access xsi:type="Quote:FieldAccess">Normal</Quote:Access>
      <Quote:ShowInSearch xsi:type="xsd:boolean">false</Quote:ShowInSearch>
     </Quote:Value>
    </Quote:FieldMetadataDictionaryKeyValuePair>
   </Quote:Response>
  </Quote:GetConfigurationFieldsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

