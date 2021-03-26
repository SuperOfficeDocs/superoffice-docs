---
uid: services80-contact-merge
title: Services80.ContactAgent.Merge SOAP
Generated: true
---

# Services80 Contact Merge SOAP

SOAP request and response examples **Remote/Services80/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IContactAgent.Merge">SuperOffice.Services80.IContactAgent.Merge</see> method.

## Merge

Merge two contacts. The destination contact will remain.

* **sourceContactId:** Source contact to merge from
* **destinationContactId:** Destination contact to merge into
* **mergeIdenticalPersons:** Persons with identical names will be merged
* **replaceEmptyFieldsOnDestination:** If true, empty fields on destination will be replaced by values from source.



[WSDL file for Services80/Contact](../Services80-Contact.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Merge Request

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
   <Contact:Merge>
    <Contact:SourceContactId xsi:type="xsd:int">0</Contact:SourceContactId>
    <Contact:DestinationContactId xsi:type="xsd:int">0</Contact:DestinationContactId>
    <Contact:MergeIdenticalPersons xsi:type="xsd:boolean">false</Contact:MergeIdenticalPersons>
    <Contact:ReplaceEmptyFieldsOnDestination xsi:type="xsd:boolean">false</Contact:ReplaceEmptyFieldsOnDestination>
   </Contact:Merge>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## Merge Response

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
  <Contact:MergeResponse>
  </Contact:MergeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

