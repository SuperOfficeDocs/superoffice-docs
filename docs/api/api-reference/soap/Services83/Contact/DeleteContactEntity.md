---
uid: services83-contact-deletecontactentity
title: Services83.ContactAgent.DeleteContactEntity SOAP
Generated: true
---

# Services83 Contact DeleteContactEntity SOAP

SOAP request and response examples **Remote/Services83/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IContactAgent.DeleteContactEntity">SuperOffice.Services83.IContactAgent.DeleteContactEntity</see> method.

## DeleteContactEntity

Deletes the ContactEntity

* **contactEntityId:** The identity of the ContactEntity



[WSDL file for Services83/Contact](../Services83-Contact.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteContactEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:DeleteContactEntity>
    <Contact:ContactEntityId xsi:type="xsd:int">0</Contact:ContactEntityId>
   </Contact:DeleteContactEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteContactEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Contact:DeleteContactEntityResponse>
  </Contact:DeleteContactEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

