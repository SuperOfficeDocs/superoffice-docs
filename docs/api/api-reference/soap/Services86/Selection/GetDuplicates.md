---
uid: services86-selection-getduplicates
title: Services86.SelectionAgent.GetDuplicates SOAP
Generated: true
---

# Services86 Selection GetDuplicates SOAP

SOAP request and response examples **Remote/Services86/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ISelectionAgent.GetDuplicates">SuperOffice.Services86.ISelectionAgent.GetDuplicates</see> method.

## GetDuplicates

Get duplicates(exact or similar in the database) based on the name

* **name:** Name used for lookup

**Returns:** Any records matching the specified name


[WSDL file for Services86/Selection](../Services86-Selection.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDuplicates Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:GetDuplicates>
    <Selection:Name xsi:type="xsd:string"></Selection:Name>
   </Selection:GetDuplicates>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDuplicates Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Selection:GetDuplicatesResponse>
   <Selection:Response xsi:type="Selection:ArrayOfDuplicateEntry">
    <Selection:DuplicateEntry xsi:type="Selection:DuplicateEntry">
     <Selection:RuleName xsi:type="xsd:string"></Selection:RuleName>
     <Selection:SoPrimaryKey xsi:type="xsd:int">0</Selection:SoPrimaryKey>
     <Selection:EntryName xsi:type="xsd:string"></Selection:EntryName>
     <Selection:EntryIdentifier xsi:type="xsd:string"></Selection:EntryIdentifier>
     <Selection:RuleDisplayName xsi:type="xsd:string"></Selection:RuleDisplayName>
    </Selection:DuplicateEntry>
   </Selection:Response>
  </Selection:GetDuplicatesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

