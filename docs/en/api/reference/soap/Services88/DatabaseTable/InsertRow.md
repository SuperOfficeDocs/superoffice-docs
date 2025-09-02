---
title: Services88.DatabaseTableAgent.InsertRow SOAP
generated: true
uid: Services88-DatabaseTable-InsertRow
content_type: reference
---

# Services88 DatabaseTable InsertRow

SOAP request and response examples **Remote/Services88/DatabaseTable.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IDatabaseTableAgent.InsertRow">SuperOffice.Services88.IDatabaseTableAgent.InsertRow</see> method.

## InsertRow





[WSDL file for Services88/DatabaseTable](../Services88-DatabaseTable.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## InsertRow Request

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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:DatabaseTable="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <DatabaseTable:InsertRowResponse>
   <DatabaseTable:Response xsi:type="xsd:int">0</DatabaseTable:Response>
  </DatabaseTable:InsertRowResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

