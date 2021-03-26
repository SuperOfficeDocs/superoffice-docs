---
uid: services80-viewstate-savecurrents
title: Services80.ViewStateAgent.SaveCurrents SOAP
Generated: true
---

# Services80 ViewState SaveCurrents SOAP

SOAP request and response examples **Remote/Services80/ViewState.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IViewStateAgent.SaveCurrents">SuperOffice.Services80.IViewStateAgent.SaveCurrents</see> method.

## SaveCurrents

Saves the history elements as the current value for their respective lists. If more than one item is submitted for the same list, they are added sequently, meaning that the last one is the most current.

* **currents:** Array of new history items to save.

**Returns:** Array of the saved History items


[WSDL file for Services80/ViewState](../Services80-ViewState.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveCurrents Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <ViewState:ApplicationToken>1234567-1234-9876</ViewState:ApplicationToken>
  <ViewState:Credentials>
    <ViewState:Ticket>7T:1234abcxyzExample==</ViewState:Ticket>
  </ViewState:Credentials>
 <SOAP-ENV:Body>
   <ViewState:SaveCurrents>
    <ViewState:Currents xsi:type="ViewState:ArrayOfHistory">
     <ViewState:History xsi:type="ViewState:History">
      <ViewState:Rank xsi:type="xsd:short">0</ViewState:Rank>
      <ViewState:Id xsi:type="xsd:int">0</ViewState:Id>
      <ViewState:HistoryName xsi:type="xsd:string"></ViewState:HistoryName>
      <ViewState:HistoryId xsi:type="xsd:int">0</ViewState:HistoryId>
      <ViewState:AssociateId xsi:type="xsd:int">0</ViewState:AssociateId>
      <ViewState:Name xsi:type="xsd:string"></ViewState:Name>
      <ViewState:ItemInfo xsi:type="xsd:string"></ViewState:ItemInfo>
     </ViewState:History>
    </ViewState:Currents>
   </ViewState:SaveCurrents>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveCurrents Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <ViewState:SaveCurrentsResponse>
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
  </ViewState:SaveCurrentsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

