---
uid: services87-viewstate-sethistorylengthprefvalue
title: Services87.ViewStateAgent.SetHistoryLengthPrefValue SOAP
Generated: true
---

# Services87 ViewState SetHistoryLengthPrefValue SOAP

SOAP request and response examples **Remote/Services87/ViewState.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IViewStateAgent.SetHistoryLengthPrefValue">SuperOffice.Services87.IViewStateAgent.SetHistoryLengthPrefValue</see> method.

## SetHistoryLengthPrefValue

Set the logged on user's preferred history list length.

* **length:** The new history list lenght



[WSDL file for Services87/ViewState](../Services87-ViewState.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetHistoryLengthPrefValue Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <ViewState:ApplicationToken>1234567-1234-9876</ViewState:ApplicationToken>
  <ViewState:Credentials>
    <ViewState:Ticket>7T:1234abcxyzExample==</ViewState:Ticket>
  </ViewState:Credentials>
 <SOAP-ENV:Body>
   <ViewState:SetHistoryLengthPrefValue>
    <ViewState:Length xsi:type="xsd:int">0</ViewState:Length>
   </ViewState:SetHistoryLengthPrefValue>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetHistoryLengthPrefValue Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <ViewState:SetHistoryLengthPrefValueResponse>
  </ViewState:SetHistoryLengthPrefValueResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

