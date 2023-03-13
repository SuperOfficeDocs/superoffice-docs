---
title: Services88.WorkflowAgent.SaveWorkflowStep SOAP
generated: 1
uid: Services88-Workflow-SaveWorkflowStep
---

# Services88 Workflow SaveWorkflowStep

SOAP request and response examples **Remote/Services88/Workflow.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IWorkflowAgent.SaveWorkflowStep">SuperOffice.Services88.IWorkflowAgent.SaveWorkflowStep</see> method.

## SaveWorkflowStep





[WSDL file for Services88/Workflow](../Services88-Workflow.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveWorkflowStep Request

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
   <Workflow:SaveWorkflowStep>
    <Workflow:WorkflowStep xsi:type="Workflow:WorkflowStep">
     <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
     <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
     <Workflow:SubSteps xsi:type="Workflow:ArrayOfWorkflowStep">
      <Workflow:WorkflowStep xsi:type="Workflow:WorkflowStep">
       <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
       <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
       <Workflow:SubSteps xsi:type="Workflow:ArrayOfWorkflowStep">
        <Workflow:WorkflowStep xsi:type="Workflow:WorkflowStep">
         <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
         <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
         <Workflow:SubSteps xsi:type="Workflow:ArrayOfWorkflowStep">
          <Workflow:WorkflowStep xsi:nil="true"></Workflow:WorkflowStep>
         </Workflow:SubSteps>
        </Workflow:WorkflowStep>
       </Workflow:SubSteps>
      </Workflow:WorkflowStep>
     </Workflow:SubSteps>
    </Workflow:WorkflowStep>
   </Workflow:SaveWorkflowStep>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveWorkflowStep Response

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
  <Workflow:SaveWorkflowStepResponse>
   <Workflow:Response xsi:type="Workflow:WorkflowStep">
    <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
    <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
    <Workflow:SubSteps xsi:type="Workflow:ArrayOfWorkflowStep">
     <Workflow:WorkflowStep xsi:type="Workflow:WorkflowStep">
      <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
      <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
      <Workflow:SubSteps xsi:type="Workflow:ArrayOfWorkflowStep">
       <Workflow:WorkflowStep xsi:type="Workflow:WorkflowStep">
        <Workflow:WorkflowStepId xsi:type="xsd:int">0</Workflow:WorkflowStepId>
        <Workflow:StepType xsi:type="Workflow:WorkflowStepType">None</Workflow:StepType>
        <Workflow:SubSteps xsi:type="Workflow:ArrayOfWorkflowStep">
         <Workflow:WorkflowStep xsi:type="Workflow:WorkflowStep">
          <Workflow:WorkflowStepId xsi:nil="true"></Workflow:WorkflowStepId>
          <Workflow:StepType xsi:nil="true"></Workflow:StepType>
          <Workflow:SubSteps xsi:nil="true"></Workflow:SubSteps>
         </Workflow:WorkflowStep>
        </Workflow:SubSteps>
       </Workflow:WorkflowStep>
      </Workflow:SubSteps>
     </Workflow:WorkflowStep>
    </Workflow:SubSteps>
   </Workflow:Response>
  </Workflow:SaveWorkflowStepResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

