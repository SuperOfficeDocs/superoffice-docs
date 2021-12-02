---
title: Services86.EMailAgent.SyncEmailAccount SOAP
generated: 1
uid: Services86-EMail-SyncEmailAccount
---

# Services86 EMail SyncEmailAccount

SOAP request and response examples **Remote/Services86/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IEMailAgent.SyncEmailAccount">SuperOffice.Services86.IEMailAgent.SyncEmailAccount</see> method.

## SyncEmailAccount

Sync the given account
<para /><b>Online Restricted:</b> The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.

* **syncUserAccount:** Account to sync

**Returns:** A void return


[WSDL file for Services86/EMail](../Services86-EMail.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SyncEmailAccount Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <EMail:ApplicationToken>1234567-1234-9876</EMail:ApplicationToken>
  <EMail:Credentials>
    <EMail:Ticket>7T:1234abcxyzExample==</EMail:Ticket>
  </EMail:Credentials>
 <SOAP-ENV:Body>
   <EMail:SyncEmailAccount>
    <EMail:SyncUserAccount xsi:type="EMail:SyncUserAccount">
     <EMail:AccountId xsi:type="xsd:int">0</EMail:AccountId>
     <EMail:AssociateName xsi:type="xsd:string"></EMail:AssociateName>
     <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
    </EMail:SyncUserAccount>
   </EMail:SyncEmailAccount>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SyncEmailAccount Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <EMail:SyncEmailAccountResponse>
  </EMail:SyncEmailAccountResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

