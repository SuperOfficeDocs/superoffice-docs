---
uid: services88-databasetable-deleterow
title: Services88.DatabaseTableAgent.DeleteRow SOAP
Generated: true
---

# Services88 DatabaseTable DeleteRow SOAP

SOAP request and response examples **Remote/Services88/DatabaseTable.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDatabaseTableAgent.DeleteRow">SuperOffice.Services88.IDatabaseTableAgent.DeleteRow</see> method.

## DeleteRow

Delete a row from a table
<para /><b>Online Restricted:</b> The DatabaseTable agent is not available in Online by default. Access must be requested specifically when app is registered.

* **tableName:** The name of the table to delete from; in the current release this must be an 'extratable'. Use the database name, on the form y\_aTable
* **id:** The id of the row to delete



[WSDL file for Services88/DatabaseTable](../Services88-DatabaseTable.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteRow Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:DatabaseTable="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:DatabaseTable="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <DatabaseTable:DeleteRowResponse>
  </DatabaseTable:DeleteRowResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

