---
title: Services88.SelectionAgent.CreateNewEntry SOAP
generated: 1
uid: Services88-Selection-CreateNewEntry
---

# Services88 Selection CreateNewEntry

SOAP request and response examples **Remote/Services88/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISelectionAgent.CreateNewEntry">SuperOffice.Services88.ISelectionAgent.CreateNewEntry</see> method.

## CreateNewEntry

Creates a new selection based on external duplicate

* **duplicate:** The duplicate to create a new entry based upon

**Returns:** The database identity of the newly created entry


[WSDL file for Services88/Selection](../Services88-Selection.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateNewEntry Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:CreateNewEntry>
    <Selection:Duplicate xsi:type="Selection:DuplicateEntry">
     <Selection:RuleName xsi:type="xsd:string"></Selection:RuleName>
     <Selection:SoPrimaryKey xsi:type="xsd:int">0</Selection:SoPrimaryKey>
     <Selection:EntryName xsi:type="xsd:string"></Selection:EntryName>
     <Selection:EntryIdentifier xsi:type="xsd:string"></Selection:EntryIdentifier>
     <Selection:RuleDisplayName xsi:type="xsd:string"></Selection:RuleDisplayName>
    </Selection:Duplicate>
   </Selection:CreateNewEntry>

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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Selection:CreateNewEntryResponse>
   <Selection:Response xsi:type="xsd:int">0</Selection:Response>
  </Selection:CreateNewEntryResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

