---
title: Services88.BLOBAgent.CleanupBatchTask SOAP
generated: 1
uid: Services88-BLOB-CleanupBatchTask
---

# Services88 BLOB CleanupBatchTask

SOAP request and response examples **Remote/Services88/BLOB.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IBLOBAgent.CleanupBatchTask">SuperOffice.Services88.IBLOBAgent.CleanupBatchTask</see> method.

## CleanupBatchTask

Removes the binary objects linked to the batch task, the links themselves and the batch task.

* **batchTaskId:** The ID of the batchtask that created the output data



[WSDL file for Services88/BLOB](../Services88-BLOB.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CleanupBatchTask Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <BLOB:ApplicationToken>1234567-1234-9876</BLOB:ApplicationToken>
  <BLOB:Credentials>
    <BLOB:Ticket>7T:1234abcxyzExample==</BLOB:Ticket>
  </BLOB:Credentials>
 <SOAP-ENV:Body>
   <BLOB:CleanupBatchTask>
    <BLOB:BatchTaskId xsi:type="xsd:int">0</BLOB:BatchTaskId>
   </BLOB:CleanupBatchTask>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CleanupBatchTask Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BLOB="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <BLOB:CleanupBatchTaskResponse>
  </BLOB:CleanupBatchTaskResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

