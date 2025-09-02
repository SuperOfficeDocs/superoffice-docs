---
title: Services88.WorkflowAgent.ConnectEmailFlowContent SOAP
generated: true
uid: Services88-Workflow-ConnectEmailFlowContent
content_type: reference
---

# Services88 Workflow ConnectEmailFlowContent

SOAP request and response examples **Remote/Services88/Workflow.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IWorkflowAgent.ConnectEmailFlowContent">SuperOffice.Services88.IWorkflowAgent.ConnectEmailFlowContent</see> method.

## ConnectEmailFlowContent





[WSDL file for Services88/Workflow](../Services88-Workflow.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ConnectEmailFlowContent Request

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
   <Workflow:ConnectEmailFlowContent>
    <Workflow:EmailFlowId xsi:type="xsd:int">0</Workflow:EmailFlowId>
    <Workflow:MessageId xsi:type="xsd:int">0</Workflow:MessageId>
   </Workflow:ConnectEmailFlowContent>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ConnectEmailFlowContent Response

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
  <Workflow:ConnectEmailFlowContentResponse>
  </Workflow:ConnectEmailFlowContentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

