---
uid: services87-list-deleteallheadingsfromlistdefinition
title: Services87.ListAgent.DeleteAllHeadingsFromListDefinition SOAP
Generated: true
---

# Services87 List DeleteAllHeadingsFromListDefinition SOAP

SOAP request and response examples **Remote/Services87/List.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IListAgent.DeleteAllHeadingsFromListDefinition">SuperOffice.Services87.IListAgent.DeleteAllHeadingsFromListDefinition</see> method.

## DeleteAllHeadingsFromListDefinition

Delete all headings for list resolved by the provided id.

* **id:** The id of the list to look up.

**Returns:** This method has no return value


[WSDL file for Services87/List](../Services87-List.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteAllHeadingsFromListDefinition Request

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
   <List:DeleteAllHeadingsFromListDefinition>
    <List:Id xsi:type="xsd:int">0</List:Id>
   </List:DeleteAllHeadingsFromListDefinition>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteAllHeadingsFromListDefinition Response

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
  <List:DeleteAllHeadingsFromListDefinitionResponse>
  </List:DeleteAllHeadingsFromListDefinitionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

