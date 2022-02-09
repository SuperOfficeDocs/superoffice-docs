---
title: Services88.ListAgent.SaveHeadingFromName SOAP
generated: 1
uid: Services88-List-SaveHeadingFromName
---

# Services88 List SaveHeadingFromName

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.SaveHeadingFromName">SuperOffice.Services88.IListAgent.SaveHeadingFromName</see> method.

## SaveHeadingFromName

Save new heading for list resolved by the provided name.

* **name:** The name of the list to look up.
* **entity:** The new heading to save

**Returns:** The saved entity.


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveHeadingFromName Request

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
   <List:SaveHeadingFromName>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Entity xsi:type="List:HeadingEntity">
     <List:HeadingId xsi:type="xsd:int">0</List:HeadingId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
     <List:UdListDefinitionId xsi:type="xsd:int">0</List:UdListDefinitionId>
    </List:Entity>
   </List:SaveHeadingFromName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveHeadingFromName Response

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
  <List:SaveHeadingFromNameResponse>
   <List:Response xsi:type="List:HeadingEntity">
    <List:HeadingId xsi:type="xsd:int">0</List:HeadingId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
    <List:UdListDefinitionId xsi:type="xsd:int">0</List:UdListDefinitionId>
   </List:Response>
  </List:SaveHeadingFromNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

