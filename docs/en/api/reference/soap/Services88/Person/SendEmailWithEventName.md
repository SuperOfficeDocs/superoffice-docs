---
title: Services88.PersonAgent.SendEmailWithEventName SOAP
generated: true
uid: Services88-Person-SendEmailWithEventName
---

# Services88 Person SendEmailWithEventName

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.SendEmailWithEventName">SuperOffice.Services88.IPersonAgent.SendEmailWithEventName</see> method.

## SendEmailWithEventName





[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SendEmailWithEventName Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:SendEmailWithEventName>
    <Person:From xsi:type="xsd:string"></Person:From>
    <Person:To xsi:type="xsd:string"></Person:To>
    <Person:Subject xsi:type="xsd:string"></Person:Subject>
    <Person:PlainBody xsi:type="xsd:string"></Person:PlainBody>
    <Person:HtmlBody xsi:type="xsd:string"></Person:HtmlBody>
    <Person:AttachmentIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Person:AttachmentIds>
    <Person:EventName xsi:type="xsd:string"></Person:EventName>
   </Person:SendEmailWithEventName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SendEmailWithEventName Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Person:SendEmailWithEventNameResponse>
  </Person:SendEmailWithEventNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

