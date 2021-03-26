---
uid: services85-selection-setduplicaterulesstatus
title: Services85.SelectionAgent.SetDuplicateRulesStatus SOAP
Generated: true
---

# Services85 Selection SetDuplicateRulesStatus SOAP

SOAP request and response examples **Remote/Services85/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ISelectionAgent.SetDuplicateRulesStatus">SuperOffice.Services85.ISelectionAgent.SetDuplicateRulesStatus</see> method.

## SetDuplicateRulesStatus

Set which duplicate rules should be active or not

* **rules:** Duplicate rules to update active status for



[WSDL file for Services85/Selection](../Services85-Selection.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetDuplicateRulesStatus Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:SetDuplicateRulesStatus>
    <Selection:Rules xsi:type="Selection:ArrayOfDuplicateRule">
     <Selection:DuplicateRule xsi:type="Selection:DuplicateRule">
      <Selection:Name xsi:type="xsd:string"></Selection:Name>
      <Selection:DisplayName xsi:type="xsd:string"></Selection:DisplayName>
      <Selection:DisplayTooltip xsi:type="xsd:string"></Selection:DisplayTooltip>
      <Selection:IsActive xsi:type="xsd:boolean">false</Selection:IsActive>
     </Selection:DuplicateRule>
    </Selection:Rules>
   </Selection:SetDuplicateRulesStatus>

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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Selection:SetDuplicateRulesStatusResponse>
  </Selection:SetDuplicateRulesStatusResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

