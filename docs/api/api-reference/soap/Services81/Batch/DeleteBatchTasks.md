---
uid: services81-batch-deletebatchtasks
title: Services81.BatchAgent.DeleteBatchTasks SOAP
Generated: true
---

# Services81 Batch DeleteBatchTasks SOAP

SOAP request and response examples **Remote/Services81/Batch.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IBatchAgent.DeleteBatchTasks">SuperOffice.Services81.IBatchAgent.DeleteBatchTasks</see> method.

## DeleteBatchTasks

Delete batch tasks from the database.

* **batchTaskIds:** Array of batchTask ids to delete.



[WSDL file for Services81/Batch](../Services81-Batch.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteBatchTasks Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Batch="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Batch:ApplicationToken>1234567-1234-9876</Batch:ApplicationToken>
  <Batch:Credentials>
    <Batch:Ticket>7T:1234abcxyzExample==</Batch:Ticket>
  </Batch:Credentials>
 <SOAP-ENV:Body>
   <Batch:DeleteBatchTasks>
    <Batch:BatchTaskIds xsi:type="NetServerServices812:ArrayOfint">
     <NetServerServices812:int xsi:type="xsd:int">0</NetServerServices812:int>
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
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Batch="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Batch:DeleteBatchTasksResponse>
  </Batch:DeleteBatchTasksResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

