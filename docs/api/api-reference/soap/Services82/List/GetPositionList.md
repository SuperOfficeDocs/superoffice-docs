---
uid: services82-list-getpositionlist
title: Services82.ListAgent.GetPositionList SOAP
Generated: true
---

# Services82 List GetPositionList SOAP

SOAP request and response examples **Remote/Services82/List.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IListAgent.GetPositionList">SuperOffice.Services82.IListAgent.GetPositionList</see> method.

## GetPositionList

Gets an array of Position objects.

* **positionIds:** The identifiers of the Position object

**Returns:** Array of Position objects


[WSDL file for Services82/List](../Services82-List.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPositionList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetPositionList>
    <List:PositionIds xsi:type="NetServerServices822:ArrayOfint">
     <NetServerServices822:int xsi:type="xsd:int">0</NetServerServices822:int>
    </List:PositionIds>
   </List:GetPositionList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPositionList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <List:GetPositionListResponse>
   <List:Response xsi:type="List:ArrayOfPosition">
    <List:Position xsi:type="List:Position">
     <List:Id xsi:type="xsd:int">0</List:Id>
     <List:Value xsi:type="xsd:string"></List:Value>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    </List:Position>
   </List:Response>
  </List:GetPositionListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

