---
uid: services88-batch-deletebatchtasks
title: Services88.BatchAgent.DeleteBatchTasks SOAP
Generated: true
---

# Services88 Batch DeleteBatchTasks SOAP

SOAP request and response examples **Remote/Services88/Batch.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IBatchAgent.DeleteBatchTasks">SuperOffice.Services88.IBatchAgent.DeleteBatchTasks</see> method.

## DeleteBatchTasks

Delete batch tasks from the database.

* **batchTaskIds:** Array of batchTask ids to delete.



[WSDL file for Services88/Batch](../Services88-Batch.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteBatchTasks Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Batch="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Batch:ApplicationToken>1234567-1234-9876</Batch:ApplicationToken>
  <Batch:Credentials>
    <Batch:Ticket>7T:1234abcxyzExample==</Batch:Ticket>
  </Batch:Credentials>
 <SOAP-ENV:Body>
   <Batch:DeleteBatchTasks>
    <Batch:BatchTaskIds xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </Batch:BatchTaskIds>
   </Batch:DeleteBatchTasks>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteBatchTasks Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Batch="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Batch:DeleteBatchTasksResponse>
  </Batch:DeleteBatchTasksResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

