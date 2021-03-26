---
uid: services75-numberallocation-setnumbereachtemplate
title: Services75.NumberAllocationAgent.SetNumberEachTemplate SOAP
Generated: true
---

# Services75 NumberAllocation SetNumberEachTemplate SOAP

SOAP request and response examples **Remote/Services75/NumberAllocation.svc**
Implemented by the <see cref="M:SuperOffice.Services75.INumberAllocationAgent.SetNumberEachTemplate">SuperOffice.Services75.INumberAllocationAgent.SetNumberEachTemplate</see> method.

## SetNumberEachTemplate

Saves true or false if Automatically create new counters for new document templates

* **setValue:** true or false if Automatically create new counters for new document templates

**Returns:** void


[WSDL file for Services75/NumberAllocation](../Services75-NumberAllocation.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetNumberEachTemplate Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:NumberAllocation="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <NumberAllocation:ApplicationToken>1234567-1234-9876</NumberAllocation:ApplicationToken>
  <NumberAllocation:Credentials>
    <NumberAllocation:Ticket>7T:1234abcxyzExample==</NumberAllocation:Ticket>
  </NumberAllocation:Credentials>
 <SOAP-ENV:Body>
   <NumberAllocation:SetNumberEachTemplate>
    <NumberAllocation:SetValue xsi:type="xsd:boolean">false</NumberAllocation:SetValue>
   </NumberAllocation:SetNumberEachTemplate>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetNumberEachTemplate Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:NumberAllocation="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <NumberAllocation:SetNumberEachTemplateResponse>
  </NumberAllocation:SetNumberEachTemplateResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

