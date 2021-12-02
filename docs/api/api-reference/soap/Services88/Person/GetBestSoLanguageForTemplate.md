---
title: Services88.PersonAgent.GetBestSoLanguageForTemplate SOAP
generated: 1
uid: Services88-Person-GetBestSoLanguageForTemplate
---

# Services88 Person GetBestSoLanguageForTemplate

SOAP request and response examples **Remote/Services88/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPersonAgent.GetBestSoLanguageForTemplate">SuperOffice.Services88.IPersonAgent.GetBestSoLanguageForTemplate</see> method.

## GetBestSoLanguageForTemplate

Get the best language for this person on this template

* **personId:** The id of the person
* **templateId:** The id of the template to find languages on

**Returns:** The solang code for best language, empty string if no best language found


[WSDL file for Services88/Person](../Services88-Person.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetBestSoLanguageForTemplate Request

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
   <Person:GetBestSoLanguageForTemplate>
    <Person:PersonId xsi:type="xsd:int">0</Person:PersonId>
    <Person:TemplateId xsi:type="xsd:int">0</Person:TemplateId>
   </Person:GetBestSoLanguageForTemplate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetBestSoLanguageForTemplate Response

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
  <Person:GetBestSoLanguageForTemplateResponse>
   <Person:Response xsi:type="xsd:string"></Person:Response>
  </Person:GetBestSoLanguageForTemplateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

