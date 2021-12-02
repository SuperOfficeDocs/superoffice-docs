---
title: Services88.ViewStateAgent.GetCurrent SOAP
generated: 1
uid: Services88-ViewState-GetCurrent
---

# Services88 ViewState GetCurrent

SOAP request and response examples **Remote/Services88/ViewState.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IViewStateAgent.GetCurrent">SuperOffice.Services88.IViewStateAgent.GetCurrent</see> method.

## GetCurrent

Get the current (most recent) value of the history list. This is the item with rank = 1. If no item exists a default value is returned. This is usually the first item in the table representing the history list.

* **historyName:** Name of the history list, e.g. contact, project

**Returns:** The current (most recent) history item


[WSDL file for Services88/ViewState](../Services88-ViewState.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCurrent Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <ViewState:ApplicationToken>1234567-1234-9876</ViewState:ApplicationToken>
  <ViewState:Credentials>
    <ViewState:Ticket>7T:1234abcxyzExample==</ViewState:Ticket>
  </ViewState:Credentials>
 <SOAP-ENV:Body>
   <ViewState:GetCurrent>
    <ViewState:HistoryName xsi:type="xsd:string"></ViewState:HistoryName>
   </ViewState:GetCurrent>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCurrent Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <ViewState:GetCurrentResponse>
   <ViewState:Response xsi:type="ViewState:History">
    <ViewState:Rank xsi:type="xsd:short">0</ViewState:Rank>
    <ViewState:Id xsi:type="xsd:int">0</ViewState:Id>
    <ViewState:HistoryName xsi:type="xsd:string"></ViewState:HistoryName>
    <ViewState:HistoryId xsi:type="xsd:int">0</ViewState:HistoryId>
    <ViewState:AssociateId xsi:type="xsd:int">0</ViewState:AssociateId>
    <ViewState:Name xsi:type="xsd:string"></ViewState:Name>
    <ViewState:ItemInfo xsi:type="xsd:string"></ViewState:ItemInfo>
   </ViewState:Response>
  </ViewState:GetCurrentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

