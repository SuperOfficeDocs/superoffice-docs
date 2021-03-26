---
uid: services80-associate-getnote
title: Services80.AssociateAgent.GetNote SOAP
Generated: true
---

# Services80 Associate GetNote SOAP

SOAP request and response examples **Remote/Services80/Associate.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IAssociateAgent.GetNote">SuperOffice.Services80.IAssociateAgent.GetNote</see> method.

## GetNote

Returns an array of strings(notepad pages).

* **associateId:** The associate id

**Returns:** Returns an array of strings(notepad pages).


[WSDL file for Services80/Associate](../Services80-Associate.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNote Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Associate="http://www.superoffice.net/ws/crm/NetServer/Services80">
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
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Associate="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <Associate:GetNoteResponse>
   <Associate:Response xsi:type="NetServerServices802:ArrayOfstring">
    <NetServerServices802:string xsi:type="xsd:string"></NetServerServices802:string>
   </Associate:Response>
  </Associate:GetNoteResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

