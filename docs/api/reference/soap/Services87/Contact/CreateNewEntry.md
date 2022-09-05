---
title: Services87.ContactAgent.CreateNewEntry SOAP
generated: 1
uid: Services87-Contact-CreateNewEntry
---

# Services87 Contact CreateNewEntry

SOAP request and response examples **Remote/Services87/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IContactAgent.CreateNewEntry">SuperOffice.Services87.IContactAgent.CreateNewEntry</see> method.

## CreateNewEntry

Creates a new contact based on external duplicate

* **duplicate:** The duplicate to create a new entry based upon

**Returns:** The database identity of the newly created entry


[WSDL file for Services87/Contact](../Services87-Contact.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateNewEntry Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:CreateNewEntry>
    <Contact:Duplicate xsi:type="Contact:DuplicateEntry">
     <Contact:RuleName xsi:type="xsd:string"></Contact:RuleName>
     <Contact:SoPrimaryKey xsi:type="xsd:int">0</Contact:SoPrimaryKey>
     <Contact:EntryName xsi:type="xsd:string"></Contact:EntryName>
     <Contact:EntryIdentifier xsi:type="xsd:string"></Contact:EntryIdentifier>
     <Contact:RuleDisplayName xsi:type="xsd:string"></Contact:RuleDisplayName>
    </Contact:Duplicate>
   </Contact:CreateNewEntry>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateNewEntry Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Contact:CreateNewEntryResponse>
   <Contact:Response xsi:type="xsd:int">0</Contact:Response>
  </Contact:CreateNewEntryResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

