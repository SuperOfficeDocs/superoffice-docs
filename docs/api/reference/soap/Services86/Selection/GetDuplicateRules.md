---
title: Services86.SelectionAgent.GetDuplicateRules SOAP
generated: 1
uid: Services86-Selection-GetDuplicateRules
---

# Services86 Selection GetDuplicateRules

SOAP request and response examples **Remote/Services86/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ISelectionAgent.GetDuplicateRules">SuperOffice.Services86.ISelectionAgent.GetDuplicateRules</see> method.

## GetDuplicateRules

Retrieve all available duplicate rules for selection


**Returns:** All available duplicate rules


[WSDL file for Services86/Selection](../Services86-Selection.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetDuplicateRules Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:GetDuplicateRules>
   </Selection:GetDuplicateRules>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetDuplicateRules Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Selection:GetDuplicateRulesResponse>
   <Selection:Response xsi:type="Selection:ArrayOfDuplicateRule">
    <Selection:DuplicateRule xsi:type="Selection:DuplicateRule">
     <Selection:Name xsi:type="xsd:string"></Selection:Name>
     <Selection:DisplayName xsi:type="xsd:string"></Selection:DisplayName>
     <Selection:DisplayTooltip xsi:type="xsd:string"></Selection:DisplayTooltip>
     <Selection:IsActive xsi:type="xsd:boolean">false</Selection:IsActive>
    </Selection:DuplicateRule>
   </Selection:Response>
  </Selection:GetDuplicateRulesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

