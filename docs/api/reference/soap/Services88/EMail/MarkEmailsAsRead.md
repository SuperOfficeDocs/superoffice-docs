---
title: Services88.EMailAgent.MarkEmailsAsRead SOAP
generated: 1
uid: Services88-EMail-MarkEmailsAsRead
---

# Services88 EMail MarkEmailsAsRead

SOAP request and response examples **Remote/Services88/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IEMailAgent.MarkEmailsAsRead">SuperOffice.Services88.IEMailAgent.MarkEmailsAsRead</see> method.

## MarkEmailsAsRead

Mark one or more e-mails as (un)read
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **ids:** The e-mails to handle
* **read:** If true mails are marked as read. If false mails are marked as unread.



[WSDL file for Services88/EMail](../Services88-EMail.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## MarkEmailsAsRead Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:MarkEmailsAsRead>
    <EMail:Ids xsi:type="NetServerServices882:ArrayOfint">
     <NetServerServices882:int xsi:type="xsd:int">0</NetServerServices882:int>
    </EMail:Ids>
    <EMail:Read xsi:type="xsd:boolean">false</EMail:Read>
   </EMail:MarkEmailsAsRead>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## MarkEmailsAsRead Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <EMail:MarkEmailsAsReadResponse>
  </EMail:MarkEmailsAsReadResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

