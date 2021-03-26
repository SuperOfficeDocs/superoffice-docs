---
uid: services88-databasetable-upsert
title: Services88.DatabaseTableAgent.Upsert SOAP
Generated: true
---

# Services88 DatabaseTable Upsert SOAP

SOAP request and response examples **Remote/Services88/DatabaseTable.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDatabaseTableAgent.Upsert">SuperOffice.Services88.IDatabaseTableAgent.Upsert</see> method.

## Upsert

Insert or update rows
<para /><b>Online Restricted:</b> The DatabaseTable agent is not available in Online by default. Access must be requested specifically when app is registered.

* **tableName:** The name of the table where rows should be inserted or updated
* **columns:** List of column names, in the same order as in the data
* **keys:** List of columns that are to be used as keys, to match any existing rows
* **deleteUnmatched:** If true, then any rows that have NOT been matched or inserted, will be deleted. The end result is that the table will look like the incoming data
* **data:** Outer array = row, inner = column in specified order; use CultureDataFormatter to format values

**Returns:** Summary of results


[WSDL file for Services88/DatabaseTable](../Services88-DatabaseTable.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Upsert Request

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
   <DatabaseTable:Upsert>
    <DatabaseTable:TableName xsi:type="xsd:string"></DatabaseTable:TableName>
    <DatabaseTable:Columns xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </DatabaseTable:Columns>
    <DatabaseTable:Keys xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </DatabaseTable:Keys>
    <DatabaseTable:DeleteUnmatched xsi:type="xsd:boolean">false</DatabaseTable:DeleteUnmatched>
    <DatabaseTable:Data xsi:type="NetServerServices882:ArrayOfArrayOfstring">
     <NetServerServices882:ArrayOfstring xsi:type="NetServerServices882:ArrayOfstring">
      <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
     </NetServerServices882:ArrayOfstring>
    </DatabaseTable:Data>
   </DatabaseTable:Upsert>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## Upsert Response

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
  <DatabaseTable:UpsertResponse>
   <DatabaseTable:Response xsi:type="DatabaseTable:MassOperationResult">
    <DatabaseTable:Success xsi:type="xsd:boolean">false</DatabaseTable:Success>
    <DatabaseTable:Message xsi:type="xsd:string"></DatabaseTable:Message>
    <DatabaseTable:Inserts xsi:type="xsd:int">0</DatabaseTable:Inserts>
    <DatabaseTable:Updates xsi:type="xsd:int">0</DatabaseTable:Updates>
    <DatabaseTable:Deletes xsi:type="xsd:int">0</DatabaseTable:Deletes>
   </DatabaseTable:Response>
  </DatabaseTable:UpsertResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

