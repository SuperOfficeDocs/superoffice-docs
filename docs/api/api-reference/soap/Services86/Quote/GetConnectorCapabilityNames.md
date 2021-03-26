---
uid: services86-quote-getconnectorcapabilitynames
title: Services86.QuoteAgent.GetConnectorCapabilityNames SOAP
Generated: true
---

# Services86 Quote GetConnectorCapabilityNames SOAP

SOAP request and response examples **Remote/Services86/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IQuoteAgent.GetConnectorCapabilityNames">SuperOffice.Services86.IQuoteAgent.GetConnectorCapabilityNames</see> method.

## GetConnectorCapabilityNames

Gets a list of all possible connector capabilities

* **quoteConnectionId:** Primary key of the connection

**Returns:** Capabilities names


[WSDL file for Services86/Quote](../Services86-Quote.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetConnectorCapabilityNames Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:GetConnectorCapabilityNames>
    <Quote:QuoteConnectionId xsi:type="xsd:int">0</Quote:QuoteConnectionId>
   </Quote:GetConnectorCapabilityNames>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetConnectorCapabilityNames Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Quote:GetConnectorCapabilityNamesResponse>
   <Quote:Response xsi:type="NetServerServices862:ArrayOfstring">
    <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
   </Quote:Response>
  </Quote:GetConnectorCapabilityNamesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

