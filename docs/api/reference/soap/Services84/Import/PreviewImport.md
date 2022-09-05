---
title: Services84.ImportAgent.PreviewImport SOAP
generated: 1
uid: Services84-Import-PreviewImport
---

# Services84 Import PreviewImport

SOAP request and response examples **Remote/Services84/Import.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IImportAgent.PreviewImport">SuperOffice.Services84.IImportAgent.PreviewImport</see> method.

## PreviewImport

Preview the import

* **importLines:** The rows that will be manipulated and according to Import rules
* **columnDefinition:** An array of the columndefinitions, like firstname, lastname, ...
* **culture:** The current culture used in the import. Used to match language specific strings
* **context:** Optional context for the import.

**Returns:** An array of the the rows that can be imported, manipulated according to Import rules given


[WSDL file for Services84/Import](../Services84-Import.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## PreviewImport Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Import="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Import:ApplicationToken>1234567-1234-9876</Import:ApplicationToken>
  <Import:Credentials>
    <Import:Ticket>7T:1234abcxyzExample==</Import:Ticket>
  </Import:Credentials>
 <SOAP-ENV:Body>
   <Import:PreviewImport>
    <Import:ImportLines xsi:type="Import:ArrayOfImportLine">
     <Import:ImportLine xsi:type="Import:ImportLine">
      <Import:Values xsi:type="NetServerServices842:ArrayOfstring">
       <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
      </Import:Values>
      <Import:Selected xsi:type="xsd:boolean">false</Import:Selected>
      <Import:Operation xsi:type="Import:ImportAction">PersonAdded</Import:Operation>
      <Import:Type xsi:type="Import:ImportEntityType">Person</Import:Type>
      <Import:ExternalKey xsi:type="xsd:string"></Import:ExternalKey>
     </Import:ImportLine>
    </Import:ImportLines>
    <Import:ColumnDefinition xsi:type="NetServerServices842:ArrayOfstring">
     <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
    </Import:ColumnDefinition>
    <Import:Culture xsi:type="xsd:string"></Import:Culture>
    <Import:Context xsi:type="xsd:string"></Import:Context>
   </Import:PreviewImport>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## PreviewImport Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Import="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Import:PreviewImportResponse>
   <Import:Response xsi:type="Import:ArrayOfImportLine">
    <Import:ImportLine xsi:type="Import:ImportLine">
     <Import:Values xsi:type="NetServerServices842:ArrayOfstring">
      <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
     </Import:Values>
     <Import:Selected xsi:type="xsd:boolean">false</Import:Selected>
     <Import:Operation xsi:type="Import:ImportAction">PersonAdded</Import:Operation>
     <Import:Type xsi:type="Import:ImportEntityType">Person</Import:Type>
     <Import:ExternalKey xsi:type="xsd:string"></Import:ExternalKey>
    </Import:ImportLine>
   </Import:Response>
  </Import:PreviewImportResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

