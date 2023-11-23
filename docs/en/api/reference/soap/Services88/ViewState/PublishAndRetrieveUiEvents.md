---
title: Services88.ViewStateAgent.PublishAndRetrieveUiEvents SOAP
generated: true
uid: Services88-ViewState-PublishAndRetrieveUiEvents
---

# Services88 ViewState PublishAndRetrieveUiEvents

SOAP request and response examples **Remote/Services88/ViewState.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IViewStateAgent.PublishAndRetrieveUiEvents">SuperOffice.Services88.IViewStateAgent.PublishAndRetrieveUiEvents</see> method.

## PublishAndRetrieveUiEvents





[WSDL file for Services88/ViewState](../Services88-ViewState.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## PublishAndRetrieveUiEvents Request

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
   <ViewState:PublishAndRetrieveUiEvents>
    <ViewState:LatestKnownEventId xsi:type="xsd:int">0</ViewState:LatestKnownEventId>
    <ViewState:PublishEvents xsi:type="ViewState:ArrayOfUiEvent">
     <ViewState:UiEvent xsi:type="ViewState:UiEvent">
      <ViewState:EventId xsi:type="xsd:int">0</ViewState:EventId>
      <ViewState:EventName xsi:type="xsd:string"></ViewState:EventName>
      <ViewState:EntityType xsi:type="xsd:string"></ViewState:EntityType>
      <ViewState:EntityKey xsi:type="xsd:int">0</ViewState:EntityKey>
      <ViewState:AssociateId xsi:type="xsd:int">0</ViewState:AssociateId>
      <ViewState:AssociateName xsi:type="xsd:string"></ViewState:AssociateName>
      <ViewState:EventDateTime xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</ViewState:EventDateTime>
     </ViewState:UiEvent>
    </ViewState:PublishEvents>
    <ViewState:Metrics xsi:type="ViewState:ArrayOfMetricPair">
     <ViewState:MetricPair xsi:type="ViewState:MetricPair">
      <ViewState:Name xsi:type="xsd:string"></ViewState:Name>
      <ViewState:Value xsi:type="xsd:int">0</ViewState:Value>
     </ViewState:MetricPair>
    </ViewState:Metrics>
   </ViewState:PublishAndRetrieveUiEvents>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## PublishAndRetrieveUiEvents Response

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
  <ViewState:PublishAndRetrieveUiEventsResponse>
   <ViewState:Response xsi:type="ViewState:ArrayOfUiEvent">
    <ViewState:UiEvent xsi:type="ViewState:UiEvent">
     <ViewState:EventId xsi:type="xsd:int">0</ViewState:EventId>
     <ViewState:EventName xsi:type="xsd:string"></ViewState:EventName>
     <ViewState:EntityType xsi:type="xsd:string"></ViewState:EntityType>
     <ViewState:EntityKey xsi:type="xsd:int">0</ViewState:EntityKey>
     <ViewState:AssociateId xsi:type="xsd:int">0</ViewState:AssociateId>
     <ViewState:AssociateName xsi:type="xsd:string"></ViewState:AssociateName>
     <ViewState:EventDateTime xsi:type="xsd:dateTime">2023-11-10T12:38:03Z</ViewState:EventDateTime>
    </ViewState:UiEvent>
   </ViewState:Response>
  </ViewState:PublishAndRetrieveUiEventsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

