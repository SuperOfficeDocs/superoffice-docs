---
uid: services86-list-getheadingsfromlistdefinition
title: Services86.ListAgent.GetHeadingsFromListDefinition SOAP
Generated: true
---

# Services86 List GetHeadingsFromListDefinition SOAP

SOAP request and response examples **Remote/Services86/List.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IListAgent.GetHeadingsFromListDefinition">SuperOffice.Services86.IListAgent.GetHeadingsFromListDefinition</see> method.

## GetHeadingsFromListDefinition

Gets headings for list resolved by the provided id.

* **id:** The id of the list to look up.

**Returns:** List of headings


[WSDL file for Services86/List](../Services86-List.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetHeadingsFromListDefinition Request

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
   <List:GetHeadingsFromListDefinition>
    <List:Id xsi:type="xsd:int">0</List:Id>
   </List:GetHeadingsFromListDefinition>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetHeadingsFromListDefinition Response

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
  <List:GetHeadingsFromListDefinitionResponse>
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
  </List:GetHeadingsFromListDefinitionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

