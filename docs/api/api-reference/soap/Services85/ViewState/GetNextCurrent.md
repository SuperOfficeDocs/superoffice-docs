---
uid: services85-viewstate-getnextcurrent
title: Services85.ViewStateAgent.GetNextCurrent SOAP
Generated: true
---

# Services85 ViewState GetNextCurrent SOAP

SOAP request and response examples **Remote/Services85/ViewState.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IViewStateAgent.GetNextCurrent">SuperOffice.Services85.IViewStateAgent.GetNextCurrent</see> method.

## GetNextCurrent

Returns the next current item. If no item exists a default value is returned. This is usually the first item in the table representing the history list.

* **historyName:** Name of the history list, e.g. contact, project
* **id:** Id of the history element, e.g. Contact id

**Returns:** The current value.


[WSDL file for Services85/ViewState](../Services85-ViewState.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetNextCurrent Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <ViewState:ApplicationToken>1234567-1234-9876</ViewState:ApplicationToken>
  <ViewState:Credentials>
    <ViewState:Ticket>7T:1234abcxyzExample==</ViewState:Ticket>
  </ViewState:Credentials>
 <SOAP-ENV:Body>
   <ViewState:GetNextCurrent>
    <ViewState:HistoryName xsi:type="xsd:string"></ViewState:HistoryName>
    <ViewState:Id xsi:type="xsd:int">0</ViewState:Id>
   </ViewState:GetNextCurrent>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetNextCurrent Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <ViewState:GetNextCurrentResponse>
   <ViewState:Response xsi:type="ViewState:History">
    <ViewState:Rank xsi:type="xsd:short">0</ViewState:Rank>
    <ViewState:Id xsi:type="xsd:int">0</ViewState:Id>
    <ViewState:HistoryName xsi:type="xsd:string"></ViewState:HistoryName>
    <ViewState:HistoryId xsi:type="xsd:int">0</ViewState:HistoryId>
    <ViewState:AssociateId xsi:type="xsd:int">0</ViewState:AssociateId>
    <ViewState:Name xsi:type="xsd:string"></ViewState:Name>
    <ViewState:ItemInfo xsi:type="xsd:string"></ViewState:ItemInfo>
   </ViewState:Response>
  </ViewState:GetNextCurrentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

