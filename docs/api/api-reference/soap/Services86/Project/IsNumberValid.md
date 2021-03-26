---
uid: services86-project-isnumbervalid
title: Services86.ProjectAgent.IsNumberValid SOAP
Generated: true
---

# Services86 Project IsNumberValid SOAP

SOAP request and response examples **Remote/Services86/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IProjectAgent.IsNumberValid">SuperOffice.Services86.IProjectAgent.IsNumberValid</see> method.

## IsNumberValid

Checks if the number is unique or required.  The setting is configured from admin under system options.

* **contactId:** The Project id
* **number:** The number to check for uniqueness and validity

**Returns:** True if the number is valid


[WSDL file for Services86/Project](../Services86-Project.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## IsNumberValid Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services86">
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
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Project:IsNumberValidResponse>
   <Project:Response xsi:type="xsd:boolean">false</Project:Response>
  </Project:IsNumberValidResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

