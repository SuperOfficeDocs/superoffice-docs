---
uid: services75-project-createnewentry
title: Services75.ProjectAgent.CreateNewEntry SOAP
Generated: true
---

# Services75 Project CreateNewEntry SOAP

SOAP request and response examples **Remote/Services75/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IProjectAgent.CreateNewEntry">SuperOffice.Services75.IProjectAgent.CreateNewEntry</see> method.

## CreateNewEntry

Creates a new project based on external duplicate

* **duplicate:** The duplicate to create a new entry based upon

**Returns:** The database identity of the newly created entry


[WSDL file for Services75/Project](../Services75-Project.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateNewEntry Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:CreateNewEntry>
    <Project:Duplicate xsi:type="Project:DuplicateEntry">
     <Project:RuleName xsi:type="xsd:string"></Project:RuleName>
     <Project:SoPrimaryKey xsi:type="xsd:int">0</Project:SoPrimaryKey>
     <Project:EntryName xsi:type="xsd:string"></Project:EntryName>
     <Project:EntryIdentifier xsi:type="xsd:string"></Project:EntryIdentifier>
     <Project:RuleDisplayName xsi:type="xsd:string"></Project:RuleDisplayName>
    </Project:Duplicate>
   </Project:CreateNewEntry>

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
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Project:CreateNewEntryResponse>
   <Project:Response xsi:type="xsd:int">0</Project:Response>
  </Project:CreateNewEntryResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

