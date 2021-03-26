---
uid: services85-contact-undelete
title: Services85.ContactAgent.Undelete SOAP
Generated: true
---

# Services85 Contact Undelete SOAP

SOAP request and response examples **Remote/Services85/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IContactAgent.Undelete">SuperOffice.Services85.IContactAgent.Undelete</see> method.

## Undelete

This entity supports Soft Delete. Call this method to Undelete a previously soft-deleted record

* **id:** The primary key of the entity to undelete

**Returns:** This method has no return value


[WSDL file for Services85/Contact](../Services85-Contact.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Undelete Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:Undelete>
    <Contact:Id xsi:type="xsd:int">0</Contact:Id>
   </Contact:Undelete>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## Undelete Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Contact:UndeleteResponse>
  </Contact:UndeleteResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

