---
title: Services84.ListAgent.GetDocumentTemplateTask SOAP
generated: 1
uid: Services84-List-GetDocumentTemplateTask
---

# Services84 List GetDocumentTemplateTask

SOAP request and response examples **Remote/Services84/List.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IListAgent.GetDocumentTemplateTask">SuperOffice.Services84.IListAgent.GetDocumentTemplateTask</see> method.

## GetDocumentTemplateTask

Returns a Document Template list item as a TaskListItem. The appointment's task is a Document template item when the appointment is a document.

* **documentTemplateId:** Id of the document template, i.e. the Appointment.TaskIdx

**Returns:** Document Template item as TaskListItem.


[WSDL file for Services84/List](../Services84-List.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDocumentTemplateTask Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetDocumentTemplateTask>
    <List:DocumentTemplateId xsi:type="xsd:int">0</List:DocumentTemplateId>
   </List:GetDocumentTemplateTask>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDocumentTemplateTask Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <List:GetDocumentTemplateTaskResponse>
   <List:Response xsi:type="List:Task">
    <List:Id xsi:type="xsd:int">0</List:Id>
    <List:Value xsi:type="xsd:string"></List:Value>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
   </List:Response>
  </List:GetDocumentTemplateTaskResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

