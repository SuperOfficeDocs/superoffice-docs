---
uid: services83-email-syncemailaccounts
title: Services83.EMailAgent.SyncEmailAccounts SOAP
Generated: true
---

# Services83 EMail SyncEmailAccounts SOAP

SOAP request and response examples **Remote/Services83/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IEMailAgent.SyncEmailAccounts">SuperOffice.Services83.IEMailAgent.SyncEmailAccounts</see> method.

## SyncEmailAccounts

Start syncing of the given accounts

* **syncUserAccounts:** Accounts to sync

**Returns:** A void return


[WSDL file for Services83/EMail](../Services83-EMail.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SyncEmailAccounts Request

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
   <EMail:SyncEmailAccounts>
    <EMail:SyncUserAccounts xsi:type="EMail:ArrayOfSyncUserAccount">
     <EMail:SyncUserAccount xsi:type="EMail:SyncUserAccount">
      <EMail:AccountId xsi:type="xsd:int">0</EMail:AccountId>
      <EMail:AssociateName xsi:type="xsd:string"></EMail:AssociateName>
      <EMail:AssociateId xsi:type="xsd:int">0</EMail:AssociateId>
     </EMail:SyncUserAccount>
    </EMail:SyncUserAccounts>
   </EMail:SyncEmailAccounts>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SyncEmailAccounts Response

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
  <EMail:SyncEmailAccountsResponse>
  </EMail:SyncEmailAccountsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

