---
uid: services86-project-merge
title: Services86.ProjectAgent.Merge SOAP
Generated: true
---

# Services86 Project Merge SOAP

SOAP request and response examples **Remote/Services86/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IProjectAgent.Merge">SuperOffice.Services86.IProjectAgent.Merge</see> method.

## Merge

Merge two projects into one, removing the source project in the process

* **sourceProjectId:** Id of source project for merge. This project is removed after the merge is completed.
* **destinationProjectId:** Id of destination project to merge to. This project is updated with info from the source.
* **replaceEmptyFieldsOnDestination:** Fill in empty fields on destination from source?



[WSDL file for Services86/Project](../Services86-Project.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Merge Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:Merge>
    <Project:SourceProjectId xsi:type="xsd:int">0</Project:SourceProjectId>
    <Project:DestinationProjectId xsi:type="xsd:int">0</Project:DestinationProjectId>
    <Project:ReplaceEmptyFieldsOnDestination xsi:type="xsd:boolean">false</Project:ReplaceEmptyFieldsOnDestination>
   </Project:Merge>

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
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Project:MergeResponse>
  </Project:MergeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

