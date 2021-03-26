---
uid: services81-list-getpriorities
title: Services81.ListAgent.GetPriorities SOAP
Generated: true
---

# Services81 List GetPriorities SOAP

SOAP request and response examples **Remote/Services81/List.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IListAgent.GetPriorities">SuperOffice.Services81.IListAgent.GetPriorities</see> method.

## GetPriorities

Returns all priorities an appointment could have.


**Returns:** An array of all available priorities


[WSDL file for Services81/List](../Services81-List.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPriorities Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetPriorities>
   </List:GetPriorities>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPriorities Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <List:GetPrioritiesResponse>
   <List:Response xsi:type="List:ArrayOfPriority">
    <List:Priority xsi:type="List:Priority">
     <List:Id xsi:type="xsd:int">0</List:Id>
     <List:Value xsi:type="xsd:string"></List:Value>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    </List:Priority>
   </List:Response>
  </List:GetPrioritiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

