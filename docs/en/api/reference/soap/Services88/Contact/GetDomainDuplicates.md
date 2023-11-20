---
title: Services88.ContactAgent.GetDomainDuplicates SOAP
generated: true
uid: Services88-Contact-GetDomainDuplicates
---

# Services88 Contact GetDomainDuplicates

SOAP request and response examples **Remote/Services88/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IContactAgent.GetDomainDuplicates">SuperOffice.Services88.IContactAgent.GetDomainDuplicates</see> method.

## GetDomainDuplicates





[WSDL file for Services88/Contact](../Services88-Contact.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDomainDuplicates Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:GetDomainDuplicates>
    <Contact:Domain xsi:type="xsd:string"></Contact:Domain>
   </Contact:GetDomainDuplicates>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDomainDuplicates Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Contact:GetDomainDuplicatesResponse>
   <Contact:Response xsi:type="Contact:ArrayOfDuplicateEntry">
    <Contact:DuplicateEntry xsi:type="Contact:DuplicateEntry">
     <Contact:RuleName xsi:type="xsd:string"></Contact:RuleName>
     <Contact:SoPrimaryKey xsi:type="xsd:int">0</Contact:SoPrimaryKey>
     <Contact:EntryName xsi:type="xsd:string"></Contact:EntryName>
     <Contact:EntryIdentifier xsi:type="xsd:string"></Contact:EntryIdentifier>
     <Contact:RuleDisplayName xsi:type="xsd:string"></Contact:RuleDisplayName>
    </Contact:DuplicateEntry>
   </Contact:Response>
  </Contact:GetDomainDuplicatesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

