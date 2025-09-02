---
title: Services88.WorkflowAgent.GetWorkflowStep SOAP
generated: true
uid: Services88-Workflow-GetWorkflowStep
content_type: reference
---

# Services88 Workflow GetWorkflowStep

SOAP request and response examples **Remote/Services88/Workflow.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IWorkflowAgent.GetWorkflowStep">SuperOffice.Services88.IWorkflowAgent.GetWorkflowStep</see> method.

## GetWorkflowStep





[WSDL file for Services88/Workflow](../Services88-Workflow.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetWorkflowStep Request

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
   <Workflow:GetWorkflowStep>
    <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
   </Workflow:GetWorkflowStep>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetWorkflowStep Response

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
  <Workflow:GetWorkflowStepResponse>
   <Workflow:Response xsi:type="Workflow:WorkflowStepBase">
    <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
    <Workflow:WorkflowId xsi:type="xsd:int">0</Workflow:WorkflowId>
    <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
    <Workflow:Rank xsi:type="xsd:int">0</Workflow:Rank>
   </Workflow:Response>
  </Workflow:GetWorkflowStepResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

