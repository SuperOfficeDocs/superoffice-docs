---
uid: services81-contact-isnumbervalid
title: Services81.ContactAgent.IsNumberValid SOAP
Generated: true
---

# Services81 Contact IsNumberValid SOAP

SOAP request and response examples **Remote/Services81/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IContactAgent.IsNumberValid">SuperOffice.Services81.IContactAgent.IsNumberValid</see> method.

## IsNumberValid

Checks if the number is unique or required.  The setting is configured from admin under system options.

* **contactId:** 
* **number:** 



[WSDL file for Services81/Contact](../Services81-Contact.md)

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
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:IsNumberValid>
    <Contact:ContactId xsi:type="xsd:int">0</Contact:ContactId>
    <Contact:Number xsi:type="xsd:string"></Contact:Number>
   </Contact:IsNumberValid>

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
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Contact:IsNumberValidResponse>
   <Contact:Response xsi:type="xsd:boolean">false</Contact:Response>
  </Contact:IsNumberValidResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

