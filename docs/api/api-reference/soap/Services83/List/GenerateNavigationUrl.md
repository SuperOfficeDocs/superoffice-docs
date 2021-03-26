---
uid: services83-list-generatenavigationurl
title: Services83.ListAgent.GenerateNavigationUrl SOAP
Generated: true
---

# Services83 List GenerateNavigationUrl SOAP

SOAP request and response examples **Remote/Services83/List.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IListAgent.GenerateNavigationUrl">SuperOffice.Services83.IListAgent.GenerateNavigationUrl</see> method.

## GenerateNavigationUrl

This methods generates the navigation URL to be used to navigate to the panel

* **visibleIn:** The visble in/navigation to generate for
* **windowName:** The name of the web panel window

**Returns:** The navigation url


[WSDL file for Services83/List](../Services83-List.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GenerateNavigationUrl Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GenerateNavigationUrl>
    <List:VisibleIn xsi:type="List:Navigation">Invisible</List:VisibleIn>
    <List:WindowName xsi:type="xsd:string"></List:WindowName>
   </List:GenerateNavigationUrl>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GenerateNavigationUrl Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <List:GenerateNavigationUrlResponse>
   <List:Response xsi:type="xsd:string"></List:Response>
  </List:GenerateNavigationUrlResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

