---
title: Services86.NumberAllocationAgent.GetNumberEachTemplate SOAP
generated: 1
uid: Services86-NumberAllocation-GetNumberEachTemplate
---

# Services86 NumberAllocation GetNumberEachTemplate

SOAP request and response examples **Remote/Services86/NumberAllocation.svc**
Implemented by the <see cref="M:SuperOffice.Services86.INumberAllocationAgent.GetNumberEachTemplate">SuperOffice.Services86.INumberAllocationAgent.GetNumberEachTemplate</see> method.

## GetNumberEachTemplate

Returns true or false if Automatically create new counters for new document templates


**Returns:** Is NumberEachTemplate?


[WSDL file for Services86/NumberAllocation](../Services86-NumberAllocation.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNumberEachTemplate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:NumberAllocation="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <NumberAllocation:ApplicationToken>1234567-1234-9876</NumberAllocation:ApplicationToken>
  <NumberAllocation:Credentials>
    <NumberAllocation:Ticket>7T:1234abcxyzExample==</NumberAllocation:Ticket>
  </NumberAllocation:Credentials>
 <SOAP-ENV:Body>
   <NumberAllocation:GetNumberEachTemplate>
   </NumberAllocation:GetNumberEachTemplate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNumberEachTemplate Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:NumberAllocation="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <NumberAllocation:GetNumberEachTemplateResponse>
   <NumberAllocation:Response xsi:type="xsd:boolean">false</NumberAllocation:Response>
  </NumberAllocation:GetNumberEachTemplateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

