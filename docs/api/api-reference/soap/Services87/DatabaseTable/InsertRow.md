---
title: Services87.DatabaseTableAgent.InsertRow SOAP
generated: 1
uid: Services87-DatabaseTable-InsertRow
---

# Services87 DatabaseTable InsertRow

SOAP request and response examples **Remote/Services87/DatabaseTable.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IDatabaseTableAgent.InsertRow">SuperOffice.Services87.IDatabaseTableAgent.InsertRow</see> method.

## InsertRow

Insert a row into a table
<para /><b>Online Restricted:</b> The DatabaseTable agent is not available in Online by default. Access must be requested specifically when app is registered.

* **tableName:** The name of the table to insert into; in the current release this must be an 'extratable'. Use the database name, on the form y\_aTable
* **values:** A StringDictionary with the values to insert. You do not need to specify all the values in the table. The omitted ones will get default values

**Returns:** The id of the newly inserted row


[WSDL file for Services87/DatabaseTable](../Services87-DatabaseTable.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## InsertRow Request

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
   <DatabaseTable:InsertRow>
    <DatabaseTable:TableName xsi:type="xsd:string"></DatabaseTable:TableName>
    <DatabaseTable:Values xsi:type="DatabaseTable:StringDictionary">
     <DatabaseTable:StringKeyValuePair>
      <DatabaseTable:Key xsi:type="xsd:string"></DatabaseTable:Key>
      <DatabaseTable:Value xsi:type="xsd:string"></DatabaseTable:Value>
     </DatabaseTable:StringKeyValuePair>
    </DatabaseTable:Values>
   </DatabaseTable:InsertRow>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## InsertRow Response

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
  <DatabaseTable:InsertRowResponse>
   <DatabaseTable:Response xsi:type="xsd:int">0</DatabaseTable:Response>
  </DatabaseTable:InsertRowResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

