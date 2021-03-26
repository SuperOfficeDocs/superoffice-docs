---
uid: services83-quote-saveconnectionconfigfields
title: Services83.QuoteAgent.SaveConnectionConfigFields SOAP
Generated: true
---

# Services83 Quote SaveConnectionConfigFields SOAP

SOAP request and response examples **Remote/Services83/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IQuoteAgent.SaveConnectionConfigFields">SuperOffice.Services83.IQuoteAgent.SaveConnectionConfigFields</see> method.

## SaveConnectionConfigFields

Saves the connection config fields

* **quoteConnectionId:** Primary key of the connection
* **connectionConfigFields:** ConnectionConfigFields to save.

**Returns:** Config Fields


[WSDL file for Services83/Quote](../Services83-Quote.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveConnectionConfigFields Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:SaveConnectionConfigFields>
    <Quote:QuoteConnectionId xsi:type="xsd:int">0</Quote:QuoteConnectionId>
    <Quote:ConnectionConfigFields xsi:type="Quote:StringDictionary">
     <Quote:StringKeyValuePair>
      <Quote:Key xsi:type="xsd:string"></Quote:Key>
      <Quote:Value xsi:type="xsd:string"></Quote:Value>
     </Quote:StringKeyValuePair>
    </Quote:ConnectionConfigFields>
   </Quote:SaveConnectionConfigFields>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveConnectionConfigFields Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Quote:SaveConnectionConfigFieldsResponse>
   <Quote:Response xsi:type="Quote:StringDictionary">
    <Quote:StringKeyValuePair>
     <Quote:Key xsi:type="xsd:string"></Quote:Key>
     <Quote:Value xsi:type="xsd:string"></Quote:Value>
    </Quote:StringKeyValuePair>
   </Quote:Response>
  </Quote:SaveConnectionConfigFieldsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

