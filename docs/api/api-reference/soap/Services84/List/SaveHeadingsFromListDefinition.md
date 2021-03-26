---
uid: services84-list-saveheadingsfromlistdefinition
title: Services84.ListAgent.SaveHeadingsFromListDefinition SOAP
Generated: true
---

# Services84 List SaveHeadingsFromListDefinition SOAP

SOAP request and response examples **Remote/Services84/List.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IListAgent.SaveHeadingsFromListDefinition">SuperOffice.Services84.IListAgent.SaveHeadingsFromListDefinition</see> method.

## SaveHeadingsFromListDefinition

Save headings for list resolved by the provided id.

* **id:** The id of the list to look up.
* **entities:** The headings to save

**Returns:** List of headings


[WSDL file for Services84/List](../Services84-List.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveHeadingsFromListDefinition Request

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
   <List:SaveHeadingsFromListDefinition>
    <List:Id xsi:type="xsd:int">0</List:Id>
    <List:Entities xsi:type="List:ArrayOfHeadingEntity">
     <List:HeadingEntity xsi:type="List:HeadingEntity">
      <List:HeadingId xsi:type="xsd:int">0</List:HeadingId>
      <List:Name xsi:type="xsd:string"></List:Name>
      <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
      <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
      <List:Rank xsi:type="xsd:short">0</List:Rank>
      <List:UdListDefinitionId xsi:type="xsd:int">0</List:UdListDefinitionId>
     </List:HeadingEntity>
    </List:Entities>
   </List:SaveHeadingsFromListDefinition>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveHeadingsFromListDefinition Response

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
  <List:SaveHeadingsFromListDefinitionResponse>
   <List:Response xsi:type="List:ArrayOfHeadingEntity">
    <List:HeadingEntity xsi:type="List:HeadingEntity">
     <List:HeadingId xsi:type="xsd:int">0</List:HeadingId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
     <List:UdListDefinitionId xsi:type="xsd:int">0</List:UdListDefinitionId>
    </List:HeadingEntity>
   </List:Response>
  </List:SaveHeadingsFromListDefinitionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

