---
uid: services83-email-hasnewmail
title: Services83.EMailAgent.HasNewMail SOAP
Generated: true
---

# Services83 EMail HasNewMail SOAP

SOAP request and response examples **Remote/Services83/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IEMailAgent.HasNewMail">SuperOffice.Services83.IEMailAgent.HasNewMail</see> method.

## HasNewMail

Fast check for new mail in the database

* **mailItemId:** The last known mailitemid
* **folderId:** The folderId for the folder to check for new mail

**Returns:** Has new mail if true


[WSDL file for Services83/EMail](../Services83-EMail.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## HasNewMail Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:HasNewMail>
    <EMail:MailItemId xsi:type="xsd:int">0</EMail:MailItemId>
    <EMail:FolderId xsi:type="xsd:int">0</EMail:FolderId>
   </EMail:HasNewMail>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## HasNewMail Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <EMail:HasNewMailResponse>
   <EMail:Response xsi:type="xsd:boolean">false</EMail:Response>
  </EMail:HasNewMailResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

