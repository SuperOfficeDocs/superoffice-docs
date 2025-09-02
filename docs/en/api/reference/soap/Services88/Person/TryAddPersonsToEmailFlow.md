---
title: Services88.PersonAgent.TryAddPersonsToEmailFlow SOAP
generated: true
uid: Services88-Person-TryAddPersonsToEmailFlow
content_type: reference
---

# Services88 Person TryAddPersonsToEmailFlow

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.TryAddPersonsToEmailFlow">SuperOffice.Services88.IPersonAgent.TryAddPersonsToEmailFlow</see> method.

## TryAddPersonsToEmailFlow





[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## TryAddPersonsToEmailFlow Request

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
   <Person:TryAddPersonsToEmailFlow>
    <Person:EmailFlowId xsi:type="xsd:int">0</Person:EmailFlowId>
    <Person:PersonIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Person:PersonIds>
   </Person:TryAddPersonsToEmailFlow>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## TryAddPersonsToEmailFlow Response

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
  <Person:TryAddPersonsToEmailFlowResponse>
   <Person:Response xsi:type="NetServerServices882:ArrayOfboolean">
    <NetServerServices882:boolean xsi:type="xsd:boolean">false</NetServerServices882:boolean>
   </Person:Response>
  </Person:TryAddPersonsToEmailFlowResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

