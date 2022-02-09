---
title: Services87.ListAgent.GetAllReasonStalled SOAP
generated: 1
uid: Services87-List-GetAllReasonStalled
---

# Services87 List GetAllReasonStalled

SOAP request and response examples **Remote/Services87/List.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IListAgent.GetAllReasonStalled">SuperOffice.Services87.IListAgent.GetAllReasonStalled</see> method.

## GetAllReasonStalled

Gets an array of all ReasonStalled objects.


**Returns:** Array of all ReasonStalled objects


[WSDL file for Services87/List](../Services87-List.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAllReasonStalled Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetAllReasonStalled>
   </List:GetAllReasonStalled>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAllReasonStalled Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <List:GetAllReasonStalledResponse>
   <List:Response xsi:type="List:ArrayOfReasonStalled">
    <List:ReasonStalled xsi:type="List:ReasonStalled">
     <List:Id xsi:type="xsd:int">0</List:Id>
     <List:Value xsi:type="xsd:string"></List:Value>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    </List:ReasonStalled>
   </List:Response>
  </List:GetAllReasonStalledResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

