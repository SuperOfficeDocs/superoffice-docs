---
uid: services87-selection-getselectionshadowmembersarchiverows
title: Services87.SelectionAgent.GetSelectionShadowMembersArchiveRows SOAP
Generated: true
---

# Services87 Selection GetSelectionShadowMembersArchiveRows SOAP

SOAP request and response examples **Remote/Services87/Selection.svc**
Implemented by the <see cref="M:SuperOffice.Services87.ISelectionAgent.GetSelectionShadowMembersArchiveRows">SuperOffice.Services87.ISelectionAgent.GetSelectionShadowMembersArchiveRows</see> method.

## GetSelectionShadowMembersArchiveRows

Get the list of members in this selection's shadow (i.e. the list of contacts + persons referenced in the main selection).

* **selectionId:** The selectionId we want selection members for.
* **select:** (optional) Comma separated Column names to include in result. List of columns varies depending on the selection's TargetTable. e.g. 'name', 'firstname,name', 'startTime,firstname,name'

**Returns:** Array of archive rows, where each item represents one row of data (row level data + the requested columns). NULL if selection does not exist.


[WSDL file for Services87/Selection](../Services87-Selection.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSelectionShadowMembersArchiveRows Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Selection:ApplicationToken>1234567-1234-9876</Selection:ApplicationToken>
  <Selection:Credentials>
    <Selection:Ticket>7T:1234abcxyzExample==</Selection:Ticket>
  </Selection:Credentials>
 <SOAP-ENV:Body>
   <Selection:GetSelectionShadowMembersArchiveRows>
    <Selection:SelectionId xsi:type="xsd:int">0</Selection:SelectionId>
    <Selection:Select xsi:type="xsd:string"></Selection:Select>
   </Selection:GetSelectionShadowMembersArchiveRows>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSelectionShadowMembersArchiveRows Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Selection="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Selection:GetSelectionShadowMembersArchiveRowsResponse>
   <Selection:Response xsi:type="Selection:ArrayOfArchiveListItem">
    <Selection:ArchiveListItem xsi:type="Selection:ArchiveListItem">
     <Selection:EntityName xsi:type="xsd:string"></Selection:EntityName>
     <Selection:PrimaryKey xsi:type="xsd:int">0</Selection:PrimaryKey>
     <Selection:ColumnData xsi:type="Selection:ColumnDataDictionary">
      <Selection:ColumnDataKeyValuePair>
       <Selection:Key xsi:type="xsd:string"></Selection:Key>
       <Selection:Value xsi:type="Selection:ArchiveColumnData">
        <Selection:DisplayValue xsi:type="xsd:string"></Selection:DisplayValue>
        <Selection:TooltipHint xsi:type="xsd:string"></Selection:TooltipHint>
        <Selection:LinkHint xsi:type="xsd:string"></Selection:LinkHint>
       </Selection:Value>
      </Selection:ColumnDataKeyValuePair>
     </Selection:ColumnData>
     <Selection:LinkHint xsi:type="xsd:string"></Selection:LinkHint>
     <Selection:StyleHint xsi:type="xsd:string"></Selection:StyleHint>
    </Selection:ArchiveListItem>
   </Selection:Response>
  </Selection:GetSelectionShadowMembersArchiveRowsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

