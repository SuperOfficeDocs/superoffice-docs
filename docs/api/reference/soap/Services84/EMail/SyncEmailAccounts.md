---
title: Services84.EMailAgent.SyncEmailAccounts SOAP
generated: 1
uid: Services84-EMail-SyncEmailAccounts
---

# Services84 EMail SyncEmailAccounts

SOAP request and response examples **Remote/Services84/EMail.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IEMailAgent.SyncEmailAccounts">SuperOffice.Services84.IEMailAgent.SyncEmailAccounts</see> method.

## SyncEmailAccounts

Start syncing of the given accounts

* **syncUserAccounts:** Accounts to sync

**Returns:** A void return


[WSDL file for Services84/EMail](../Services84-EMail.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SyncEmailAccounts Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services84">
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
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:EMail="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <EMail:SyncEmailAccountsResponse>
  </EMail:SyncEmailAccountsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

