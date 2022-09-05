---
title: Services84.AssociateAgent.GetNote SOAP
generated: 1
uid: Services84-Associate-GetNote
---

# Services84 Associate GetNote

SOAP request and response examples **Remote/Services84/Associate.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IAssociateAgent.GetNote">SuperOffice.Services84.IAssociateAgent.GetNote</see> method.

## GetNote

Returns an array of strings(notepad pages).

* **associateId:** The associate id

**Returns:** Returns an array of strings(notepad pages).


[WSDL file for Services84/Associate](../Services84-Associate.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNote Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Associate="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Associate:ApplicationToken>1234567-1234-9876</Associate:ApplicationToken>
  <Associate:Credentials>
    <Associate:Ticket>7T:1234abcxyzExample==</Associate:Ticket>
  </Associate:Credentials>
 <SOAP-ENV:Body>
   <Associate:GetNote>
    <Associate:AssociateId xsi:type="xsd:int">0</Associate:AssociateId>
   </Associate:GetNote>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNote Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Associate="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Associate:GetNoteResponse>
   <Associate:Response xsi:type="NetServerServices842:ArrayOfstring">
    <NetServerServices842:string xsi:type="xsd:string"></NetServerServices842:string>
   </Associate:Response>
  </Associate:GetNoteResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

