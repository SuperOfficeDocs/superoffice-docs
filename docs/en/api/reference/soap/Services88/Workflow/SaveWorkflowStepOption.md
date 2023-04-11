---
title: Services88.WorkflowAgent.SaveWorkflowStepOption SOAP
generated: 1
uid: Services88-Workflow-SaveWorkflowStepOption
---

# Services88 Workflow SaveWorkflowStepOption

SOAP request and response examples **Remote/Services88/Workflow.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IWorkflowAgent.SaveWorkflowStepOption">SuperOffice.Services88.IWorkflowAgent.SaveWorkflowStepOption</see> method.

## SaveWorkflowStepOption





[WSDL file for Services88/Workflow](../Services88-Workflow.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveWorkflowStepOption Request

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
   <Workflow:SaveWorkflowStepOption>
    <Workflow:WorkflowStepOption xsi:type="Workflow:WorkflowStepOption">
     <Workflow:WorkflowStepOptionId xsi:type="xsd:int">0</Workflow:WorkflowStepOptionId>
     <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
     <Workflow:WorkflowId xsi:type="xsd:int">0</Workflow:WorkflowId>
     <Workflow:Key xsi:type="xsd:string"></Workflow:Key>
     <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
     <Workflow:Rank xsi:type="xsd:int">0</Workflow:Rank>
     <Workflow:Steps xsi:type="Workflow:ArrayOfWorkflowStepBase">
      <Workflow:WorkflowStepBase xsi:type="Workflow:WorkflowStepBase">
       <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
       <Workflow:WorkflowId xsi:type="xsd:int">0</Workflow:WorkflowId>
       <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
       <Workflow:Rank xsi:type="xsd:int">0</Workflow:Rank>
      </Workflow:WorkflowStepBase>
     </Workflow:Steps>
    </Workflow:WorkflowStepOption>
   </Workflow:SaveWorkflowStepOption>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveWorkflowStepOption Response

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
  <Workflow:SaveWorkflowStepOptionResponse>
   <Workflow:Response xsi:type="Workflow:WorkflowStepOption">
    <Workflow:WorkflowStepOptionId xsi:type="xsd:int">0</Workflow:WorkflowStepOptionId>
    <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
    <Workflow:WorkflowId xsi:type="xsd:int">0</Workflow:WorkflowId>
    <Workflow:Key xsi:type="xsd:string"></Workflow:Key>
    <Workflow:Name xsi:type="xsd:string"></Workflow:Name>
    <Workflow:Rank xsi:type="xsd:int">0</Workflow:Rank>
    <Workflow:Steps xsi:type="Workflow:ArrayOfWorkflowStepBase">
     <Workflow:WorkflowStepBase xsi:type="Workflow:WorkflowStepBase">
      <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
      <Workflow:WorkflowId xsi:type="xsd:int">0</Workflow:WorkflowId>
      <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
      <Workflow:Rank xsi:type="xsd:int">0</Workflow:Rank>
     </Workflow:WorkflowStepBase>
    </Workflow:Steps>
   </Workflow:Response>
  </Workflow:SaveWorkflowStepOptionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

