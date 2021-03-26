---
uid: services86-contact-getnamedepartmentduplicates
title: Services86.ContactAgent.GetNameDepartmentDuplicates SOAP
Generated: true
---

# Services86 Contact GetNameDepartmentDuplicates SOAP

SOAP request and response examples **Remote/Services86/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IContactAgent.GetNameDepartmentDuplicates">SuperOffice.Services86.IContactAgent.GetNameDepartmentDuplicates</see> method.

## GetNameDepartmentDuplicates

Get duplicates based on the contact name and department

* **name:** Name used for lookup
* **department:** Department used for lookup (if any)

**Returns:** Any records matching the specified name and department


[WSDL file for Services86/Contact](../Services86-Contact.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNameDepartmentDuplicates Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:GetNameDepartmentDuplicates>
    <Contact:Name xsi:type="xsd:string"></Contact:Name>
    <Contact:Department xsi:type="xsd:string"></Contact:Department>
   </Contact:GetNameDepartmentDuplicates>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNameDepartmentDuplicates Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Contact:GetNameDepartmentDuplicatesResponse>
   <Contact:Response xsi:type="Contact:ArrayOfDuplicateEntry">
    <Contact:DuplicateEntry xsi:type="Contact:DuplicateEntry">
     <Contact:RuleName xsi:type="xsd:string"></Contact:RuleName>
     <Contact:SoPrimaryKey xsi:type="xsd:int">0</Contact:SoPrimaryKey>
     <Contact:EntryName xsi:type="xsd:string"></Contact:EntryName>
     <Contact:EntryIdentifier xsi:type="xsd:string"></Contact:EntryIdentifier>
     <Contact:RuleDisplayName xsi:type="xsd:string"></Contact:RuleDisplayName>
    </Contact:DuplicateEntry>
   </Contact:Response>
  </Contact:GetNameDepartmentDuplicatesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

