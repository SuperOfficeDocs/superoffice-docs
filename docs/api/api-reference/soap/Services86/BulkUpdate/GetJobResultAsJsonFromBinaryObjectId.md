---
uid: services86-bulkupdate-getjobresultasjsonfrombinaryobjectid
title: Services86.BulkUpdateAgent.GetJobResultAsJsonFromBinaryObjectId SOAP
Generated: true
---

# Services86 BulkUpdate GetJobResultAsJsonFromBinaryObjectId SOAP

SOAP request and response examples **Remote/Services86/BulkUpdate.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IBulkUpdateAgent.GetJobResultAsJsonFromBinaryObjectId">SuperOffice.Services86.IBulkUpdateAgent.GetJobResultAsJsonFromBinaryObjectId</see> method.

## GetJobResultAsJsonFromBinaryObjectId

Get result of the batchupdate job

* **tableName:** The name of the table that was updated to show the log from
* **binaryObjectId:** Which binaryobject id has stored the job result

**Returns:** Result of job as json


[WSDL file for Services86/BulkUpdate](../Services86-BulkUpdate.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetJobResultAsJsonFromBinaryObjectId Request

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
   <BulkUpdate:GetJobResultAsJsonFromBinaryObjectId>
    <BulkUpdate:TableName xsi:type="xsd:string"></BulkUpdate:TableName>
    <BulkUpdate:BinaryObjectId xsi:type="xsd:int">0</BulkUpdate:BinaryObjectId>
   </BulkUpdate:GetJobResultAsJsonFromBinaryObjectId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetJobResultAsJsonFromBinaryObjectId Response

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
  <BulkUpdate:GetJobResultAsJsonFromBinaryObjectIdResponse>
   <BulkUpdate:Response xsi:type="xsd:string"></BulkUpdate:Response>
  </BulkUpdate:GetJobResultAsJsonFromBinaryObjectIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

