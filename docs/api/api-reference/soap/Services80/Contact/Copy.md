---
uid: services80-contact-copy
title: Services80.ContactAgent.Copy SOAP
Generated: true
---

# Services80 Contact Copy SOAP

SOAP request and response examples **Remote/Services80/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IContactAgent.Copy">SuperOffice.Services80.IContactAgent.Copy</see> method.

## Copy

Copy a contact. Activities and related data will be ignored

* **sourceContactId:** The id of the contact to copy
* **destinationContactName:** The name of the destination contact
* **destinationContactDepartment:** The department of the destination contact
* **copyPersons:** If true, persons will be copied from source contact

**Returns:** Id of copied contact


[WSDL file for Services80/Contact](../Services80-Contact.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Copy Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:Copy>
    <Contact:SourceContactId xsi:type="xsd:int">0</Contact:SourceContactId>
    <Contact:DestinationContactName xsi:type="xsd:string"></Contact:DestinationContactName>
    <Contact:DestinationContactDepartment xsi:type="xsd:string"></Contact:DestinationContactDepartment>
    <Contact:CopyPersons xsi:type="xsd:boolean">false</Contact:CopyPersons>
   </Contact:Copy>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## Copy Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Contact:CopyResponse>
   <Contact:Response xsi:type="xsd:int">0</Contact:Response>
  </Contact:CopyResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

