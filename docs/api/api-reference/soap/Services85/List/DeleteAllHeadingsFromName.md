---
uid: services85-list-deleteallheadingsfromname
title: Services85.ListAgent.DeleteAllHeadingsFromName SOAP
Generated: true
---

# Services85 List DeleteAllHeadingsFromName SOAP

SOAP request and response examples **Remote/Services85/List.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IListAgent.DeleteAllHeadingsFromName">SuperOffice.Services85.IListAgent.DeleteAllHeadingsFromName</see> method.

## DeleteAllHeadingsFromName

Delete all headings for list resolved by the provided name.

* **name:** The name of the list to look up.

**Returns:** This method has no return value


[WSDL file for Services85/List](../Services85-List.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteAllHeadingsFromName Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:DeleteAllHeadingsFromName>
    <List:Name xsi:type="xsd:string"></List:Name>
   </List:DeleteAllHeadingsFromName>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteAllHeadingsFromName Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <List:DeleteAllHeadingsFromNameResponse>
  </List:DeleteAllHeadingsFromNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

