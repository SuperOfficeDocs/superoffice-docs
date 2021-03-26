---
uid: services75-viewstate-gethistoriesbynames
title: Services75.ViewStateAgent.GetHistoriesByNames SOAP
Generated: true
---

# Services75 ViewState GetHistoriesByNames SOAP

SOAP request and response examples **Remote/Services75/ViewState.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IViewStateAgent.GetHistoriesByNames">SuperOffice.Services75.IViewStateAgent.GetHistoriesByNames</see> method.

## GetHistoriesByNames

Returns the named history lists that belong to the currently logged in user

* **historyNames:** String array of list names

**Returns:** Array of History items


[WSDL file for Services75/ViewState](../Services75-ViewState.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetHistoriesByNames Request

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
   <ViewState:GetHistoriesByNames>
    <ViewState:HistoryNames xsi:type="NetServerServices752:ArrayOfstring">
     <NetServerServices752:string xsi:type="xsd:string"></NetServerServices752:string>
    </ViewState:HistoryNames>
   </ViewState:GetHistoriesByNames>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetHistoriesByNames Response

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
  <ViewState:GetHistoriesByNamesResponse>
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
  </ViewState:GetHistoriesByNamesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

