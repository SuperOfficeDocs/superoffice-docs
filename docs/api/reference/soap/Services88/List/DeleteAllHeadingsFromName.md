---
title: Services88.ListAgent.DeleteAllHeadingsFromName SOAP
generated: 1
uid: Services88-List-DeleteAllHeadingsFromName
---

# Services88 List DeleteAllHeadingsFromName

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.DeleteAllHeadingsFromName">SuperOffice.Services88.IListAgent.DeleteAllHeadingsFromName</see> method.

## DeleteAllHeadingsFromName

Delete all headings for list resolved by the provided name.

* **name:** The name of the list to look up.

**Returns:** This method has no return value


[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteAllHeadingsFromName Request

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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <List:DeleteAllHeadingsFromNameResponse>
  </List:DeleteAllHeadingsFromNameResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

