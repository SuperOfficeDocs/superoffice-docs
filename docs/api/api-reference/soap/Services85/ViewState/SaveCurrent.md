---
uid: services85-viewstate-savecurrent
title: Services85.ViewStateAgent.SaveCurrent SOAP
Generated: true
---

# Services85 ViewState SaveCurrent SOAP

SOAP request and response examples **Remote/Services85/ViewState.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IViewStateAgent.SaveCurrent">SuperOffice.Services85.IViewStateAgent.SaveCurrent</see> method.

## SaveCurrent

Saving the current history item. This history item is saved with Rank = 1, and all the remaining elements rank values are shifted one down. The list is maintained with the max lenght of the History list length preference.

* **current:** The new current history element.

**Returns:** The current (most recent) history item


[WSDL file for Services85/ViewState](../Services85-ViewState.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveCurrent Request

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
   <ViewState:SaveCurrent>
    <ViewState:Current xsi:type="ViewState:History">
     <ViewState:Rank xsi:type="xsd:short">0</ViewState:Rank>
     <ViewState:Id xsi:type="xsd:int">0</ViewState:Id>
     <ViewState:HistoryName xsi:type="xsd:string"></ViewState:HistoryName>
     <ViewState:HistoryId xsi:type="xsd:int">0</ViewState:HistoryId>
     <ViewState:AssociateId xsi:type="xsd:int">0</ViewState:AssociateId>
     <ViewState:Name xsi:type="xsd:string"></ViewState:Name>
     <ViewState:ItemInfo xsi:type="xsd:string"></ViewState:ItemInfo>
    </ViewState:Current>
   </ViewState:SaveCurrent>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveCurrent Response

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
  <ViewState:SaveCurrentResponse>
   <ViewState:Response xsi:type="ViewState:History">
    <ViewState:Rank xsi:type="xsd:short">0</ViewState:Rank>
    <ViewState:Id xsi:type="xsd:int">0</ViewState:Id>
    <ViewState:HistoryName xsi:type="xsd:string"></ViewState:HistoryName>
    <ViewState:HistoryId xsi:type="xsd:int">0</ViewState:HistoryId>
    <ViewState:AssociateId xsi:type="xsd:int">0</ViewState:AssociateId>
    <ViewState:Name xsi:type="xsd:string"></ViewState:Name>
    <ViewState:ItemInfo xsi:type="xsd:string"></ViewState:ItemInfo>
   </ViewState:Response>
  </ViewState:SaveCurrentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

