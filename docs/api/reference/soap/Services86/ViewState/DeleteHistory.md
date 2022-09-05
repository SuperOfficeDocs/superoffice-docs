---
title: Services86.ViewStateAgent.DeleteHistory SOAP
generated: 1
uid: Services86-ViewState-DeleteHistory
---

# Services86 ViewState DeleteHistory

SOAP request and response examples **Remote/Services86/ViewState.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IViewStateAgent.DeleteHistory">SuperOffice.Services86.IViewStateAgent.DeleteHistory</see> method.

## DeleteHistory

Deletes the history element

* **historyName:** Name of the history list, e.g. contact, project
* **id:** Id of the history element, e.g. Contact id



[WSDL file for Services86/ViewState](../Services86-ViewState.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteHistory Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <ViewState:ApplicationToken>1234567-1234-9876</ViewState:ApplicationToken>
  <ViewState:Credentials>
    <ViewState:Ticket>7T:1234abcxyzExample==</ViewState:Ticket>
  </ViewState:Credentials>
 <SOAP-ENV:Body>
   <ViewState:DeleteHistory>
    <ViewState:HistoryName xsi:type="xsd:string"></ViewState:HistoryName>
    <ViewState:Id xsi:type="xsd:int">0</ViewState:Id>
   </ViewState:DeleteHistory>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteHistory Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:ViewState="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <ViewState:DeleteHistoryResponse>
  </ViewState:DeleteHistoryResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

