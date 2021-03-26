---
uid: services84-associate-logoffwindowsusers
title: Services84.AssociateAgent.LogOffWindowsUsers SOAP
Generated: true
---

# Services84 Associate LogOffWindowsUsers SOAP

SOAP request and response examples **Remote/Services84/Associate.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IAssociateAgent.LogOffWindowsUsers">SuperOffice.Services84.IAssociateAgent.LogOffWindowsUsers</see> method.

## LogOffWindowsUsers

Method that logs off associates that are logged on to the win client

* **associateIds:** The ids of the associates that shall be logged off

**Returns:** A void return


[WSDL file for Services84/Associate](../Services84-Associate.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## LogOffWindowsUsers Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Associate="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Associate:ApplicationToken>1234567-1234-9876</Associate:ApplicationToken>
  <Associate:Credentials>
    <Associate:Ticket>7T:1234abcxyzExample==</Associate:Ticket>
  </Associate:Credentials>
 <SOAP-ENV:Body>
   <Associate:LogOffWindowsUsers>
    <Associate:AssociateIds xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </Associate:AssociateIds>
   </Associate:LogOffWindowsUsers>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## LogOffWindowsUsers Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Associate="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Associate:LogOffWindowsUsersResponse>
  </Associate:LogOffWindowsUsersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

