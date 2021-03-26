---
uid: services87-bulkupdate-removestoredfields
title: Services87.BulkUpdateAgent.RemoveStoredFields SOAP
Generated: true
---

# Services87 BulkUpdate RemoveStoredFields SOAP

SOAP request and response examples **Remote/Services87/BulkUpdate.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IBulkUpdateAgent.RemoveStoredFields">SuperOffice.Services87.IBulkUpdateAgent.RemoveStoredFields</see> method.

## RemoveStoredFields

Remove the stored settings of the bulk update for this table from this context

* **tableName:** The name of the table to remove stored settings from
* **context:** Where is the function called from that we will remove the settings from



[WSDL file for Services87/BulkUpdate](../Services87-BulkUpdate.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveStoredFields Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BulkUpdate="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <BulkUpdate:ApplicationToken>1234567-1234-9876</BulkUpdate:ApplicationToken>
  <BulkUpdate:Credentials>
    <BulkUpdate:Ticket>7T:1234abcxyzExample==</BulkUpdate:Ticket>
  </BulkUpdate:Credentials>
 <SOAP-ENV:Body>
   <BulkUpdate:RemoveStoredFields>
    <BulkUpdate:TableName xsi:type="xsd:string"></BulkUpdate:TableName>
    <BulkUpdate:Context xsi:type="xsd:string"></BulkUpdate:Context>
   </BulkUpdate:RemoveStoredFields>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveStoredFields Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:BulkUpdate="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <BulkUpdate:RemoveStoredFieldsResponse>
   <BulkUpdate:Response xsi:type="xsd:boolean">false</BulkUpdate:Response>
  </BulkUpdate:RemoveStoredFieldsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

