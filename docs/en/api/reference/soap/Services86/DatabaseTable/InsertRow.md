---
title: Services86.DatabaseTableAgent.InsertRow SOAP
generated: 1
uid: Services86-DatabaseTable-InsertRow
---

# Services86 DatabaseTable InsertRow

SOAP request and response examples **Remote/Services86/DatabaseTable.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IDatabaseTableAgent.InsertRow">SuperOffice.Services86.IDatabaseTableAgent.InsertRow</see> method.

## InsertRow





[WSDL file for Services86/DatabaseTable](../Services86-DatabaseTable.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## InsertRow Request

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
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:DatabaseTable="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <DatabaseTable:InsertRowResponse>
   <DatabaseTable:Response xsi:type="xsd:int">0</DatabaseTable:Response>
  </DatabaseTable:InsertRowResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

