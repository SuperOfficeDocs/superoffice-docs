---
title: Services84.ContactAgent.SetDuplicateRulesStatus SOAP
generated: 1
uid: Services84-Contact-SetDuplicateRulesStatus
---

# Services84 Contact SetDuplicateRulesStatus

SOAP request and response examples **Remote/Services84/Contact.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IContactAgent.SetDuplicateRulesStatus">SuperOffice.Services84.IContactAgent.SetDuplicateRulesStatus</see> method.

## SetDuplicateRulesStatus

Set which duplicate rules should be active or not

* **rules:** Duplicate rules to update active status for



[WSDL file for Services84/Contact](../Services84-Contact.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetDuplicateRulesStatus Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Contact:ApplicationToken>1234567-1234-9876</Contact:ApplicationToken>
  <Contact:Credentials>
    <Contact:Ticket>7T:1234abcxyzExample==</Contact:Ticket>
  </Contact:Credentials>
 <SOAP-ENV:Body>
   <Contact:SetDuplicateRulesStatus>
    <Contact:Rules xsi:type="Contact:ArrayOfDuplicateRule">
     <Contact:DuplicateRule xsi:type="Contact:DuplicateRule">
      <Contact:Name xsi:type="xsd:string"></Contact:Name>
      <Contact:DisplayName xsi:type="xsd:string"></Contact:DisplayName>
      <Contact:DisplayTooltip xsi:type="xsd:string"></Contact:DisplayTooltip>
      <Contact:IsActive xsi:type="xsd:boolean">false</Contact:IsActive>
     </Contact:DuplicateRule>
    </Contact:Rules>
   </Contact:SetDuplicateRulesStatus>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetDuplicateRulesStatus Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Contact="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Contact:SetDuplicateRulesStatusResponse>
  </Contact:SetDuplicateRulesStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

