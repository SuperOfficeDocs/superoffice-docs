---
uid: services88-databasetable-insert
title: Services88.DatabaseTableAgent.Insert SOAP
Generated: true
---

# Services88 DatabaseTable Insert SOAP

SOAP request and response examples **Remote/Services88/DatabaseTable.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDatabaseTableAgent.Insert">SuperOffice.Services88.IDatabaseTableAgent.Insert</see> method.

## Insert

Mass-insert rows, with or without primary keys specified
<para /><b>Online Restricted:</b> The DatabaseTable agent is not available in Online by default. Access must be requested specifically when app is registered.

* **tableName:** The name of the table where rows should be inserted
* **columns:** List of column names, in the same order as in the data
* **data:** Outer array = row, inner = column in specified order; use CultureDataFormatter to format values

**Returns:** Summary of results


[WSDL file for Services88/DatabaseTable](../Services88-DatabaseTable.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Insert Request

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
   <DatabaseTable:Insert>
    <DatabaseTable:TableName xsi:type="xsd:string"></DatabaseTable:TableName>
    <DatabaseTable:Columns xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </DatabaseTable:Columns>
    <DatabaseTable:Data xsi:type="NetServerServices882:ArrayOfArrayOfstring">
     <NetServerServices882:ArrayOfstring xsi:type="NetServerServices882:ArrayOfstring">
      <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
     </NetServerServices882:ArrayOfstring>
    </DatabaseTable:Data>
   </DatabaseTable:Insert>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## Insert Response

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
  <DatabaseTable:InsertResponse>
   <DatabaseTable:Response xsi:type="DatabaseTable:MassOperationResult">
    <DatabaseTable:Success xsi:type="xsd:boolean">false</DatabaseTable:Success>
    <DatabaseTable:Message xsi:type="xsd:string"></DatabaseTable:Message>
    <DatabaseTable:Inserts xsi:type="xsd:int">0</DatabaseTable:Inserts>
    <DatabaseTable:Updates xsi:type="xsd:int">0</DatabaseTable:Updates>
    <DatabaseTable:Deletes xsi:type="xsd:int">0</DatabaseTable:Deletes>
   </DatabaseTable:Response>
  </DatabaseTable:InsertResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

