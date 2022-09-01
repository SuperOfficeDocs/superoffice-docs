---
title: Services86.DatabaseTableAgent.DeleteRow SOAP
generated: 1
uid: Services86-DatabaseTable-DeleteRow
---

# Services86 DatabaseTable DeleteRow

SOAP request and response examples **Remote/Services86/DatabaseTable.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IDatabaseTableAgent.DeleteRow">SuperOffice.Services86.IDatabaseTableAgent.DeleteRow</see> method.

## DeleteRow

Delete a row from a table
<para /><b>Online Restricted:</b> The DatabaseTable agent is not available in Online by default. Access must be requested specifically when app is registered.

* **tableName:** The name of the table to delete from; in the current release this must be an 'extratable'. Use the database name, on the form y\_aTable
* **id:** The id of the row to delete



[WSDL file for Services86/DatabaseTable](../Services86-DatabaseTable.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteRow Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:DatabaseTable="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <DatabaseTable:ApplicationToken>1234567-1234-9876</DatabaseTable:ApplicationToken>
  <DatabaseTable:Credentials>
    <DatabaseTable:Ticket>7T:1234abcxyzExample==</DatabaseTable:Ticket>
  </DatabaseTable:Credentials>
 <SOAP-ENV:Body>
   <DatabaseTable:DeleteRow>
    <DatabaseTable:TableName xsi:type="xsd:string"></DatabaseTable:TableName>
    <DatabaseTable:Id xsi:type="xsd:int">0</DatabaseTable:Id>
   </DatabaseTable:DeleteRow>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteRow Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:DatabaseTable="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <DatabaseTable:DeleteRowResponse>
  </DatabaseTable:DeleteRowResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

