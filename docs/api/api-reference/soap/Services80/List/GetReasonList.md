---
uid: services80-list-getreasonlist
title: Services80.ListAgent.GetReasonList SOAP
Generated: true
---

# Services80 List GetReasonList SOAP

SOAP request and response examples **Remote/Services80/List.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IListAgent.GetReasonList">SuperOffice.Services80.IListAgent.GetReasonList</see> method.

## GetReasonList

Gets an array of Reason objects.

* **reasonIds:** The identifiers of the Reason object

**Returns:** Array of Reason objects


[WSDL file for Services80/List](../Services80-List.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetReasonList Request

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
   <List:GetReasonList>
    <List:ReasonIds xsi:type="NetServerServices802:ArrayOfint">
     <NetServerServices802:int xsi:type="xsd:int">0</NetServerServices802:int>
    </List:ReasonIds>
   </List:GetReasonList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetReasonList Response

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
  <List:GetReasonListResponse>
   <List:Response xsi:type="List:ArrayOfReason">
    <List:Reason xsi:type="List:Reason">
     <List:Id xsi:type="xsd:int">0</List:Id>
     <List:Value xsi:type="xsd:string"></List:Value>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    </List:Reason>
   </List:Response>
  </List:GetReasonListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

