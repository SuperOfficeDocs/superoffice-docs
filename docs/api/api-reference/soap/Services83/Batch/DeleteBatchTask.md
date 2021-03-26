---
uid: services83-batch-deletebatchtask
title: Services83.BatchAgent.DeleteBatchTask SOAP
Generated: true
---

# Services83 Batch DeleteBatchTask SOAP

SOAP request and response examples **Remote/Services83/Batch.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IBatchAgent.DeleteBatchTask">SuperOffice.Services83.IBatchAgent.DeleteBatchTask</see> method.

## DeleteBatchTask

Delete a batch task from the database.

* **batchTaskId:** The batchTask ids to delete.



[WSDL file for Services83/Batch](../Services83-Batch.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteBatchTask Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Batch="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Batch:ApplicationToken>1234567-1234-9876</Batch:ApplicationToken>
  <Batch:Credentials>
    <Batch:Ticket>7T:1234abcxyzExample==</Batch:Ticket>
  </Batch:Credentials>
 <SOAP-ENV:Body>
   <Batch:DeleteBatchTask>
    <Batch:BatchTaskId xsi:type="xsd:int">0</Batch:BatchTaskId>
   </Batch:DeleteBatchTask>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteBatchTask Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Batch="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Batch:DeleteBatchTaskResponse>
  </Batch:DeleteBatchTaskResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

