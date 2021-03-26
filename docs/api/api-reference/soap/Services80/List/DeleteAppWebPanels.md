---
uid: services80-list-deleteappwebpanels
title: Services80.ListAgent.DeleteAppWebPanels SOAP
Generated: true
---

# Services80 List DeleteAppWebPanels SOAP

SOAP request and response examples **Remote/Services80/List.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IListAgent.DeleteAppWebPanels">SuperOffice.Services80.IListAgent.DeleteAppWebPanels</see> method.

## DeleteAppWebPanels

Permanentely delete all web panels owned by your app; works in Online only, for registered Apps that send a valid ApplicationToken; otherwise nothing happens


**Returns:** This method has no return value


[WSDL file for Services80/List](../Services80-List.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteAppWebPanels Request

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
   <List:DeleteAppWebPanels>
   </List:DeleteAppWebPanels>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteAppWebPanels Response

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
  <List:DeleteAppWebPanelsResponse>
  </List:DeleteAppWebPanelsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

