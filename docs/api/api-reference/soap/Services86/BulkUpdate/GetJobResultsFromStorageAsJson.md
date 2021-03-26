---
uid: services86-bulkupdate-getjobresultsfromstorageasjson
title: Services86.BulkUpdateAgent.GetJobResultsFromStorageAsJson SOAP
Generated: true
---

# Services86 BulkUpdate GetJobResultsFromStorageAsJson SOAP

SOAP request and response examples **Remote/Services86/BulkUpdate.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IBulkUpdateAgent.GetJobResultsFromStorageAsJson">SuperOffice.Services86.IBulkUpdateAgent.GetJobResultsFromStorageAsJson</see> method.

## GetJobResultsFromStorageAsJson

Get result of the batchupdate job


**Returns:** Result of job as json


[WSDL file for Services86/BulkUpdate](../Services86-BulkUpdate.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetJobResultsFromStorageAsJson Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BulkUpdate="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <BulkUpdate:ApplicationToken>1234567-1234-9876</BulkUpdate:ApplicationToken>
  <BulkUpdate:Credentials>
    <BulkUpdate:Ticket>7T:1234abcxyzExample==</BulkUpdate:Ticket>
  </BulkUpdate:Credentials>
 <SOAP-ENV:Body>
   <BulkUpdate:GetJobResultsFromStorageAsJson>
   </BulkUpdate:GetJobResultsFromStorageAsJson>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetJobResultsFromStorageAsJson Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BulkUpdate="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <BulkUpdate:GetJobResultsFromStorageAsJsonResponse>
   <BulkUpdate:Response xsi:type="NetServerServices862:ArrayOfstring">
    <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
   </BulkUpdate:Response>
  </BulkUpdate:GetJobResultsFromStorageAsJsonResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

