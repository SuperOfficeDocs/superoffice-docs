---
title: Services87.DatabaseTableAgent.ReadRow SOAP
generated: 1
uid: Services87-DatabaseTable-ReadRow
---

# Services87 DatabaseTable ReadRow

SOAP request and response examples **Remote/Services87/DatabaseTable.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IDatabaseTableAgent.ReadRow">SuperOffice.Services87.IDatabaseTableAgent.ReadRow</see> method.

## ReadRow

Read a row from a table
<para /><b>Online Restricted:</b> The DatabaseTable agent is not available in Online by default. Access must be requested specifically when app is registered.

* **tableName:** The name of the table to fetch; in the current release this must be an 'extratable'. Use the database name, on the form y\_aTable
* **id:** The id of the row to fetch

**Returns:** The row from the table


[WSDL file for Services87/DatabaseTable](../Services87-DatabaseTable.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ReadRow Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:DatabaseTable="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <DatabaseTable:ApplicationToken>1234567-1234-9876</DatabaseTable:ApplicationToken>
  <DatabaseTable:Credentials>
    <DatabaseTable:Ticket>7T:1234abcxyzExample==</DatabaseTable:Ticket>
  </DatabaseTable:Credentials>
 <SOAP-ENV:Body>
   <DatabaseTable:ReadRow>
    <DatabaseTable:TableName xsi:type="xsd:string"></DatabaseTable:TableName>
    <DatabaseTable:Id xsi:type="xsd:int">0</DatabaseTable:Id>
   </DatabaseTable:ReadRow>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ReadRow Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:DatabaseTable="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <DatabaseTable:ReadRowResponse>
   <DatabaseTable:Response xsi:type="DatabaseTable:TableRecord">
    <DatabaseTable:Values xsi:type="DatabaseTable:StringDictionary">
     <DatabaseTable:StringKeyValuePair>
      <DatabaseTable:Key xsi:type="xsd:string"></DatabaseTable:Key>
      <DatabaseTable:Value xsi:type="xsd:string"></DatabaseTable:Value>
     </DatabaseTable:StringKeyValuePair>
    </DatabaseTable:Values>
   </DatabaseTable:Response>
  </DatabaseTable:ReadRowResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

