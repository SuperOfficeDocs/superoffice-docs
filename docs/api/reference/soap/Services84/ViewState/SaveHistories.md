---
title: Services84.ViewStateAgent.SaveHistories SOAP
generated: 1
uid: Services84-ViewState-SaveHistories
---

# Services84 ViewState SaveHistories

SOAP request and response examples **Remote/Services84/ViewState.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IViewStateAgent.SaveHistories">SuperOffice.Services84.IViewStateAgent.SaveHistories</see> method.

## SaveHistories

Replaces the existing history-list for the currently logged in user. All elements must belong to the same history list. If not they are ignored.

* **historyName:** 
* **history:** Array of new history items to save.

**Returns:** Array of the saved History items


[WSDL file for Services84/ViewState](../Services84-ViewState.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveHistories Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <ViewState:ApplicationToken>1234567-1234-9876</ViewState:ApplicationToken>
  <ViewState:Credentials>
    <ViewState:Ticket>7T:1234abcxyzExample==</ViewState:Ticket>
  </ViewState:Credentials>
 <SOAP-ENV:Body>
   <ViewState:SaveHistories>
    <ViewState:HistoryName xsi:type="xsd:string"></ViewState:HistoryName>
    <ViewState:History xsi:type="ViewState:ArrayOfHistory">
     <ViewState:History xsi:type="ViewState:History">
      <ViewState:Rank xsi:type="xsd:short">0</ViewState:Rank>
      <ViewState:Id xsi:type="xsd:int">0</ViewState:Id>
      <ViewState:HistoryName xsi:type="xsd:string"></ViewState:HistoryName>
      <ViewState:HistoryId xsi:type="xsd:int">0</ViewState:HistoryId>
      <ViewState:AssociateId xsi:type="xsd:int">0</ViewState:AssociateId>
      <ViewState:Name xsi:type="xsd:string"></ViewState:Name>
      <ViewState:ItemInfo xsi:type="xsd:string"></ViewState:ItemInfo>
     </ViewState:History>
    </ViewState:History>
   </ViewState:SaveHistories>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveHistories Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <ViewState:SaveHistoriesResponse>
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
  </ViewState:SaveHistoriesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

