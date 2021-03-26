---
uid: services80-list-getbusinesslist
title: Services80.ListAgent.GetBusinessList SOAP
Generated: true
---

# Services80 List GetBusinessList SOAP

SOAP request and response examples **Remote/Services80/List.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IListAgent.GetBusinessList">SuperOffice.Services80.IListAgent.GetBusinessList</see> method.

## GetBusinessList

Gets an array of Business objects.

* **businessIds:** The identifiers of the Business object

**Returns:** Array of Business objects


[WSDL file for Services80/List](../Services80-List.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetBusinessList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetBusinessList>
    <List:BusinessIds xsi:type="NetServerServices802:ArrayOfint">
     <NetServerServices802:int xsi:type="xsd:int">0</NetServerServices802:int>
    </List:BusinessIds>
   </List:GetBusinessList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetBusinessList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <List:GetBusinessListResponse>
   <List:Response xsi:type="List:ArrayOfBusiness">
    <List:Business xsi:type="List:Business">
     <List:Id xsi:type="xsd:int">0</List:Id>
     <List:Value xsi:type="xsd:string"></List:Value>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    </List:Business>
   </List:Response>
  </List:GetBusinessListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

