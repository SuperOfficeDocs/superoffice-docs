---
title: Services86.BatchAgent.StopBatchJob SOAP
generated: 1
uid: Services86-Batch-StopBatchJob
---

# Services86 Batch StopBatchJob

SOAP request and response examples **Remote/Services86/Batch.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IBatchAgent.StopBatchJob">SuperOffice.Services86.IBatchAgent.StopBatchJob</see> method.

## StopBatchJob

Stop a batch job based on Id.

* **id:** Id of the batch job to stop.

**Returns:** Returns true if the job was stopped successfully.


[WSDL file for Services86/Batch](../Services86-Batch.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## StopBatchJob Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Batch="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Batch:ApplicationToken>1234567-1234-9876</Batch:ApplicationToken>
  <Batch:Credentials>
    <Batch:Ticket>7T:1234abcxyzExample==</Batch:Ticket>
  </Batch:Credentials>
 <SOAP-ENV:Body>
   <Batch:StopBatchJob>
    <Batch:Id xsi:type="xsd:int">0</Batch:Id>
   </Batch:StopBatchJob>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## StopBatchJob Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Batch="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Batch:StopBatchJobResponse>
   <Batch:Response xsi:type="xsd:boolean">false</Batch:Response>
  </Batch:StopBatchJobResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

