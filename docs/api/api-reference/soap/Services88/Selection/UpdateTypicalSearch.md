---
uid: services88-selection-updatetypicalsearch
title: Services88.SelectionAgent.UpdateTypicalSearch SOAP
Generated: true
---

# Services88 Selection UpdateTypicalSearch SOAP

SOAP request and response examples **Remote/Services88/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ISelectionAgent.UpdateTypicalSearch">SuperOffice.Services88.ISelectionAgent.UpdateTypicalSearch</see> method.

## UpdateTypicalSearch

Update (import) TypicalSearch information in the database

* **searches:** TypicalSearch structures to import. If null, then the fileset is scanned for *TypicalSearch.json files and those are imported instead

**Returns:** Message that can be shown to the user, summarizing what has been done, if anything.


[WSDL file for Services88/Selection](../Services88-Selection.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## UpdateTypicalSearch Request

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
   <Selection:UpdateTypicalSearch>
    <Selection:Searches xsi:type="Selection:TypicalSearches">
     <Selection:Source xsi:type="xsd:string"></Selection:Source>
     <Selection:MasterVersion xsi:type="xsd:int">0</Selection:MasterVersion>
     <Selection:DeleteLeftovers xsi:type="xsd:boolean">false</Selection:DeleteLeftovers>
     <Selection:Searches xsi:type="Selection:ArrayOfTypicalSearch">
      <Selection:TypicalSearch xsi:type="Selection:TypicalSearch">
       <Selection:TypicalSearchId xsi:type="xsd:int">0</Selection:TypicalSearchId>
       <Selection:Title xsi:type="xsd:string"></Selection:Title>
       <Selection:Tooltip xsi:type="xsd:string"></Selection:Tooltip>
       <Selection:EntityName xsi:type="xsd:string"></Selection:EntityName>
       <Selection:IsEntityDefault xsi:type="xsd:short">0</Selection:IsEntityDefault>
       <Selection:IncludePerson xsi:type="xsd:short">0</Selection:IncludePerson>
       <Selection:Source xsi:type="xsd:string"></Selection:Source>
       <Selection:VersionNumber xsi:type="xsd:int">0</Selection:VersionNumber>
       <Selection:RestrictionGroups xsi:type="Selection:ArrayOfArchiveRestrictionGroup">
        <Selection:ArchiveRestrictionGroup xsi:type="Selection:ArchiveRestrictionGroup">
         <Selection:Name xsi:type="xsd:string"></Selection:Name>
         <Selection:Description xsi:type="xsd:string"></Selection:Description>
         <Selection:Rank xsi:type="xsd:short">0</Selection:Rank>
         <Selection:Restrictions xsi:type="Selection:ArrayOfArchiveRestrictionInfo">
          <Selection:ArchiveRestrictionInfo xsi:nil="true"></Selection:ArchiveRestrictionInfo>
         </Selection:Restrictions>
        </Selection:ArchiveRestrictionGroup>
       </Selection:RestrictionGroups>
      </Selection:TypicalSearch>
     </Selection:Searches>
    </Selection:Searches>
   </Selection:UpdateTypicalSearch>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## UpdateTypicalSearch Response

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
  <Selection:UpdateTypicalSearchResponse>
   <Selection:Response xsi:type="xsd:string"></Selection:Response>
  </Selection:UpdateTypicalSearchResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

