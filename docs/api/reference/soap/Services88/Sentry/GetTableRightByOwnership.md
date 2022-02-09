---
title: Services88.SentryAgent.GetTableRightByOwnership SOAP
generated: 1
uid: Services88-Sentry-GetTableRightByOwnership
---

# Services88 Sentry GetTableRightByOwnership

SOAP request and response examples **Remote/Services88/Sentry.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISentryAgent.GetTableRightByOwnership">SuperOffice.Services88.ISentryAgent.GetTableRightByOwnership</see> method.

## GetTableRightByOwnership

Return the TableRight from the relationship between the current user and the given user and group.

* **tableName:** Name of the table to get the TableRights from.
* **contactGroupId:** The user-group that the associate id is part of.
* **contactAssociateId:** The associate id of the owner of the record

**Returns:** The TableRight


[WSDL file for Services88/Sentry](../Services88-Sentry.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTableRightByOwnership Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sentry="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Sentry:ApplicationToken>1234567-1234-9876</Sentry:ApplicationToken>
  <Sentry:Credentials>
    <Sentry:Ticket>7T:1234abcxyzExample==</Sentry:Ticket>
  </Sentry:Credentials>
 <SOAP-ENV:Body>
   <Sentry:GetTableRightByOwnership>
    <Sentry:TableName xsi:type="xsd:string"></Sentry:TableName>
    <Sentry:ContactGroupId xsi:type="xsd:int">0</Sentry:ContactGroupId>
    <Sentry:ContactAssociateId xsi:type="xsd:int">0</Sentry:ContactAssociateId>
   </Sentry:GetTableRightByOwnership>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTableRightByOwnership Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Sentry="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Sentry:GetTableRightByOwnershipResponse>
   <Sentry:Response xsi:type="Sentry:TableRight">
    <Sentry:Mask xsi:type="Sentry:ETableRight">Select</Sentry:Mask>
    <Sentry:Reason xsi:type="xsd:string"></Sentry:Reason>
   </Sentry:Response>
  </Sentry:GetTableRightByOwnershipResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

