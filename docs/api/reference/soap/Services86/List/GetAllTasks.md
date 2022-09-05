---
title: Services86.ListAgent.GetAllTasks SOAP
generated: 1
uid: Services86-List-GetAllTasks
---

# Services86 List GetAllTasks

SOAP request and response examples **Remote/Services86/List.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IListAgent.GetAllTasks">SuperOffice.Services86.IListAgent.GetAllTasks</see> method.

## GetAllTasks

Returns all appointment tasks

* **includeDeleted:** Include deleted items in result?

**Returns:** An array of all available tasks


[WSDL file for Services86/List](../Services86-List.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllTasks Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetAllTasks>
    <List:IncludeDeleted xsi:type="xsd:boolean">false</List:IncludeDeleted>
   </List:GetAllTasks>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllTasks Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <List:GetAllTasksResponse>
   <List:Response xsi:type="List:ArrayOfTaskListItem">
    <List:TaskListItem xsi:type="List:TaskListItem">
     <List:TaskListItemId xsi:type="xsd:int">0</List:TaskListItemId>
     <List:Value xsi:type="xsd:string"></List:Value>
     <List:Direction xsi:type="List:TaskDirection">Unknown</List:Direction>
     <List:Type xsi:type="List:TaskType">Unknown</List:Type>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
     <List:IntentId xsi:type="xsd:int">0</List:IntentId>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
     <List:IsDefaultAlldayEvent xsi:type="xsd:boolean">false</List:IsDefaultAlldayEvent>
     <List:IsDefaultFree xsi:type="xsd:boolean">false</List:IsDefaultFree>
     <List:IsDefaultPublished xsi:type="xsd:boolean">false</List:IsDefaultPublished>
     <List:ColorIndex xsi:type="List:ColorIndex">LightBlue</List:ColorIndex>
    </List:TaskListItem>
   </List:Response>
  </List:GetAllTasksResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

