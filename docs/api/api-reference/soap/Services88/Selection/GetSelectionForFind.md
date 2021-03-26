---
uid: services88-selection-getselectionforfind
title: Services88.SelectionAgent.GetSelectionForFind SOAP
Generated: true
---

# Services88 Selection GetSelectionForFind SOAP

SOAP request and response examples **Remote/Services88/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISelectionAgent.GetSelectionForFind">SuperOffice.Services88.ISelectionAgent.GetSelectionForFind</see> method.

## GetSelectionForFind

Obtain a selection for the given entity, for the current user, of type WorkingSetForFind. Optionally populate criteria from the TypicalSearches system

* **entityName:** The name of the entity to make a selection for; examples 'sale', 'project', 'y\_equipment'
* **typicalSearchId:** If 0, keep existing criteria; if -1, reset to entity default; &gt; 0 get criteria from given TypicalSearch

**Returns:** Target selection id and provider name


[WSDL file for Services88/Selection](../Services88-Selection.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSelectionForFind Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:GetSelectionForFind>
    <Selection:EntityName xsi:type="xsd:string"></Selection:EntityName>
    <Selection:TypicalSearchId xsi:type="xsd:int">0</Selection:TypicalSearchId>
   </Selection:GetSelectionForFind>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSelectionForFind Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Selection:GetSelectionForFindResponse>
   <Selection:Response xsi:type="Selection:SelectionForFind">
    <Selection:ProviderName xsi:type="xsd:string"></Selection:ProviderName>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:CanSaveAsSelection xsi:type="xsd:boolean">false</Selection:CanSaveAsSelection>
    <Selection:MainHeading xsi:type="xsd:string"></Selection:MainHeading>
    <Selection:FilterScreenHeading xsi:type="xsd:string"></Selection:FilterScreenHeading>
    <Selection:SelectionEntityHeading xsi:type="xsd:string"></Selection:SelectionEntityHeading>
   </Selection:Response>
  </Selection:GetSelectionForFindResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

