---
uid: services85-import-saveimport
title: Services85.ImportAgent.SaveImport SOAP
Generated: true
---

# Services85 Import SaveImport SOAP

SOAP request and response examples **Remote/Services85/Import.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IImportAgent.SaveImport">SuperOffice.Services85.IImportAgent.SaveImport</see> method.

## SaveImport

Do the actual import

* **importLines:** The rows that will be imported
* **columnDefinition:** An array of the columndefinitions, like firstname, lastname, ...
* **createSelection:** true if a selection of the imported entities shall be made
* **culture:** The current culture used in the import. Used to match language specific strings
* **context:** Optional context for the import.

**Returns:** First part: the id of the selection created after the import, 0 if no selection is created. Second part: The number of rows actually imported


[WSDL file for Services85/Import](../Services85-Import.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveImport Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Import="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Import:ApplicationToken>1234567-1234-9876</Import:ApplicationToken>
  <Import:Credentials>
    <Import:Ticket>7T:1234abcxyzExample==</Import:Ticket>
  </Import:Credentials>
 <SOAP-ENV:Body>
   <Import:SaveImport>
    <Import:ImportLines xsi:type="Import:ArrayOfImportLine">
     <Import:ImportLine xsi:type="Import:ImportLine">
      <Import:Values xsi:type="NetServerServices852:ArrayOfstring">
       <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
      </Import:Values>
      <Import:Selected xsi:type="xsd:boolean">false</Import:Selected>
      <Import:Operation xsi:type="Import:ImportAction">PersonAdded</Import:Operation>
      <Import:Type xsi:type="Import:ImportEntityType">Person</Import:Type>
      <Import:ExternalKey xsi:type="xsd:string"></Import:ExternalKey>
     </Import:ImportLine>
    </Import:ImportLines>
    <Import:ColumnDefinition xsi:type="NetServerServices852:ArrayOfstring">
     <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
    </Import:ColumnDefinition>
    <Import:CreateSelection xsi:type="xsd:boolean">false</Import:CreateSelection>
    <Import:Culture xsi:type="xsd:string"></Import:Culture>
    <Import:Context xsi:type="xsd:string"></Import:Context>
   </Import:SaveImport>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveImport Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Import="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Import:SaveImportResponse>
   <Import:Response xsi:type="NetServerServices852:ArrayOfint">
    <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
   </Import:Response>
  </Import:SaveImportResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

