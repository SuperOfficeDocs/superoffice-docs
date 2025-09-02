---
title: Services88.ListAgent.GetTaskMenu SOAP
generated: true
uid: Services88-List-GetTaskMenu
content_type: reference
---

# Services88 List GetTaskMenu

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.GetTaskMenu">SuperOffice.Services88.IListAgent.GetTaskMenu</see> method.

## GetTaskMenu





[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTaskMenu Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetTaskMenu>
    <List:TaskMenuId xsi:type="xsd:int">0</List:TaskMenuId>
   </List:GetTaskMenu>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTaskMenu Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <List:GetTaskMenuResponse>
   <List:Response xsi:type="List:TaskMenu">
    <List:TaskMenuId xsi:type="xsd:int">0</List:TaskMenuId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:TableName xsi:type="xsd:string"></List:TableName>
    <List:Area xsi:type="xsd:string"></List:Area>
    <List:UrlOrSoprotocol xsi:type="xsd:string"></List:UrlOrSoprotocol>
    <List:TaskType xsi:type="List:TaskListItemType">None</List:TaskType>
    <List:CrmScriptId xsi:type="xsd:int">0</List:CrmScriptId>
    <List:ShowInClient xsi:type="List:ShowTaskItemInClient">Web</List:ShowInClient>
    <List:ArchiveBehaviour xsi:type="List:ArchiveBehaviour">InArchives</List:ArchiveBehaviour>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
    <List:Encoding xsi:type="List:UrlEncoding">Unknown</List:Encoding>
    <List:ProgId xsi:type="xsd:string"></List:ProgId>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
   </List:Response>
  </List:GetTaskMenuResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

