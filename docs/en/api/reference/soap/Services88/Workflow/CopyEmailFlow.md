---
title: Services88.WorkflowAgent.CopyEmailFlow SOAP
generated: true
uid: Services88-Workflow-CopyEmailFlow
content_type: reference
---

# Services88 Workflow CopyEmailFlow

SOAP request and response examples **Remote/Services88/Workflow.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IWorkflowAgent.CopyEmailFlow">SuperOffice.Services88.IWorkflowAgent.CopyEmailFlow</see> method.

## CopyEmailFlow





[WSDL file for Services88/Workflow](../Services88-Workflow.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CopyEmailFlow Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Workflow="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Workflow:ApplicationToken>1234567-1234-9876</Workflow:ApplicationToken>
  <Workflow:Credentials>
    <Workflow:Ticket>7T:1234abcxyzExample==</Workflow:Ticket>
  </Workflow:Credentials>
 <SOAP-ENV:Body>
   <Workflow:CopyEmailFlow>
    <Workflow:EmailFlowId xsi:type="xsd:int">0</Workflow:EmailFlowId>
    <Workflow:NewName xsi:type="xsd:string"></Workflow:NewName>
   </Workflow:CopyEmailFlow>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CopyEmailFlow Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Workflow="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Workflow:CopyEmailFlowResponse>
   <Workflow:Response xsi:type="xsd:int">0</Workflow:Response>
  </Workflow:CopyEmailFlowResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

