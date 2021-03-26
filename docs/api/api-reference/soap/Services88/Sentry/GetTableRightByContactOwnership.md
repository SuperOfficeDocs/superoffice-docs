---
uid: services88-sentry-gettablerightbycontactownership
title: Services88.SentryAgent.GetTableRightByContactOwnership SOAP
Generated: true
---

# Services88 Sentry GetTableRightByContactOwnership SOAP

SOAP request and response examples **Remote/Services88/Sentry.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISentryAgent.GetTableRightByContactOwnership">SuperOffice.Services88.ISentryAgent.GetTableRightByContactOwnership</see> method.

## GetTableRightByContactOwnership

Return the TableRight from the relationship between the current user and the given user and group.

* **tableName:** Name of the table to get the TableRights from.
* **contactId:** The owner contact.

**Returns:** The TableRight


[WSDL file for Services88/Sentry](../Services88-Sentry.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTableRightByContactOwnership Request

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
   <Sentry:GetTableRightByContactOwnership>
    <Sentry:TableName xsi:type="xsd:string"></Sentry:TableName>
    <Sentry:ContactId xsi:type="xsd:int">0</Sentry:ContactId>
   </Sentry:GetTableRightByContactOwnership>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTableRightByContactOwnership Response

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
  <Sentry:GetTableRightByContactOwnershipResponse>
   <Sentry:Response xsi:type="Sentry:TableRight">
    <Sentry:Mask xsi:type="Sentry:ETableRight">Select</Sentry:Mask>
    <Sentry:Reason xsi:type="xsd:string"></Sentry:Reason>
   </Sentry:Response>
  </Sentry:GetTableRightByContactOwnershipResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

