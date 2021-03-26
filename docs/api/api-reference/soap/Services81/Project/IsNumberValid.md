---
uid: services81-project-isnumbervalid
title: Services81.ProjectAgent.IsNumberValid SOAP
Generated: true
---

# Services81 Project IsNumberValid SOAP

SOAP request and response examples **Remote/Services81/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IProjectAgent.IsNumberValid">SuperOffice.Services81.IProjectAgent.IsNumberValid</see> method.

## IsNumberValid

Checks if the number is unique or required.  The setting is configured from admin under system options.

* **contactId:** 
* **number:** 



[WSDL file for Services81/Project](../Services81-Project.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## IsNumberValid Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:IsNumberValid>
    <Project:ContactId xsi:type="xsd:int">0</Project:ContactId>
    <Project:Number xsi:type="xsd:string"></Project:Number>
   </Project:IsNumberValid>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## IsNumberValid Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Project:IsNumberValidResponse>
   <Project:Response xsi:type="xsd:boolean">false</Project:Response>
  </Project:IsNumberValidResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

