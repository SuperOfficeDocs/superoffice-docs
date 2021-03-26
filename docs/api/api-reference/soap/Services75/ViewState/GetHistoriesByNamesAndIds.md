---
uid: services75-viewstate-gethistoriesbynamesandids
title: Services75.ViewStateAgent.GetHistoriesByNamesAndIds SOAP
Generated: true
---

# Services75 ViewState GetHistoriesByNamesAndIds SOAP

SOAP request and response examples **Remote/Services75/ViewState.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IViewStateAgent.GetHistoriesByNamesAndIds">SuperOffice.Services75.IViewStateAgent.GetHistoriesByNamesAndIds</see> method.

## GetHistoriesByNamesAndIds

Returns history data for the named entities and the given ids - which may not directly correspond to the current history records in the database.<para />Use this method if you know exactly which items you need, regardless of whether they are in the current history or not.<para />The history in the database is not changed or even looked at by this method.

* **requests:** Array of request objects that define what entities we are requesting history information for

**Returns:** On history item for each history name/id pair specified, in exactly the same order as specified.<para />If a specified item cannot be found in the database, its Id will be 0 and its name will be blank in the return array.


[WSDL file for Services75/ViewState](../Services75-ViewState.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetHistoriesByNamesAndIds Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <ViewState:ApplicationToken>1234567-1234-9876</ViewState:ApplicationToken>
  <ViewState:Credentials>
    <ViewState:Ticket>7T:1234abcxyzExample==</ViewState:Ticket>
  </ViewState:Credentials>
 <SOAP-ENV:Body>
   <ViewState:GetHistoriesByNamesAndIds>
    <ViewState:Requests xsi:type="ViewState:ArrayOfHistoryRequest">
     <ViewState:HistoryRequest xsi:type="ViewState:HistoryRequest">
      <ViewState:EntityName xsi:type="xsd:string"></ViewState:EntityName>
      <ViewState:EntityOrParentId xsi:type="xsd:int">0</ViewState:EntityOrParentId>
      <ViewState:RequestForNewRecord xsi:type="xsd:boolean">false</ViewState:RequestForNewRecord>
     </ViewState:HistoryRequest>
    </ViewState:Requests>
   </ViewState:GetHistoriesByNamesAndIds>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetHistoriesByNamesAndIds Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <ViewState:GetHistoriesByNamesAndIdsResponse>
   <ViewState:Response xsi:type="ViewState:ArrayOfHistory">
    <ViewState:History xsi:type="ViewState:History">
     <ViewState:Rank xsi:type="xsd:short">0</ViewState:Rank>
     <ViewState:Id xsi:type="xsd:int">0</ViewState:Id>
     <ViewState:HistoryName xsi:type="xsd:string"></ViewState:HistoryName>
     <ViewState:HistoryId xsi:type="xsd:int">0</ViewState:HistoryId>
     <ViewState:AssociateId xsi:type="xsd:int">0</ViewState:AssociateId>
     <ViewState:Name xsi:type="xsd:string"></ViewState:Name>
     <ViewState:ItemInfo xsi:type="xsd:string"></ViewState:ItemInfo>
    </ViewState:History>
   </ViewState:Response>
  </ViewState:GetHistoriesByNamesAndIdsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

