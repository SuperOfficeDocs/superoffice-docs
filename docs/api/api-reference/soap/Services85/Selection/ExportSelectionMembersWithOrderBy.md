---
uid: services85-selection-exportselectionmemberswithorderby
title: Services85.SelectionAgent.ExportSelectionMembersWithOrderBy SOAP
Generated: true
---

# Services85 Selection ExportSelectionMembersWithOrderBy SOAP

SOAP request and response examples **Remote/Services85/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ISelectionAgent.ExportSelectionMembersWithOrderBy">SuperOffice.Services85.ISelectionAgent.ExportSelectionMembersWithOrderBy</see> method.

## ExportSelectionMembersWithOrderBy





[WSDL file for Services85/Selection](../Services85-Selection.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ExportSelectionMembersWithOrderBy Request

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
   <Selection:ExportSelectionMembersWithOrderBy>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:TemplateName xsi:type="xsd:string"></Selection:TemplateName>
    <Selection:UseContacts xsi:type="xsd:boolean">false</Selection:UseContacts>
    <Selection:OrderBy xsi:type="xsd:string"></Selection:OrderBy>
   </Selection:ExportSelectionMembersWithOrderBy>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ExportSelectionMembersWithOrderBy Response

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
  <Selection:ExportSelectionMembersWithOrderByResponse>
   <Selection:Response xsi:type="xsd:base64Binary"></Selection:Response>
  </Selection:ExportSelectionMembersWithOrderByResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

