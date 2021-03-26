---
uid: services88-customerservice-executeeventhandlers
title: Services88.CustomerServiceAgent.ExecuteEventHandlers SOAP
Generated: true
---

# Services88 CustomerService ExecuteEventHandlers SOAP

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.ExecuteEventHandlers">SuperOffice.Services88.ICustomerServiceAgent.ExecuteEventHandlers</see> method.

## ExecuteEventHandlers

This method will execute event handlers in CRMScript for a given event.

* **eventData:** The EventData instance sent to the event handler

**Returns:** The EventData instance after event handler execution


[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ExecuteEventHandlers Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <CustomerService:ApplicationToken>1234567-1234-9876</CustomerService:ApplicationToken>
  <CustomerService:Credentials>
    <CustomerService:Ticket>7T:1234abcxyzExample==</CustomerService:Ticket>
  </CustomerService:Credentials>
 <SOAP-ENV:Body>
   <CustomerService:ExecuteEventHandlers>
    <CustomerService:EventData xsi:type="CustomerService:EventData">
     <CustomerService:Type xsi:type="CustomerService:EventHandlerType">Unknown</CustomerService:Type>
     <CustomerService:InputValues xsi:type="CustomerService:StringDictionary">
      <CustomerService:StringKeyValuePair>
       <CustomerService:Key xsi:type="xsd:string"></CustomerService:Key>
       <CustomerService:Value xsi:type="xsd:string"></CustomerService:Value>
      </CustomerService:StringKeyValuePair>
     </CustomerService:InputValues>
     <CustomerService:BlockExecution xsi:type="xsd:boolean">false</CustomerService:BlockExecution>
     <CustomerService:NavigateTo xsi:type="xsd:string"></CustomerService:NavigateTo>
     <CustomerService:Message xsi:type="xsd:string"></CustomerService:Message>
     <CustomerService:OutputValues xsi:type="CustomerService:StringDictionary">
      <CustomerService:StringKeyValuePair>
       <CustomerService:Key xsi:type="xsd:string"></CustomerService:Key>
       <CustomerService:Value xsi:type="xsd:string"></CustomerService:Value>
      </CustomerService:StringKeyValuePair>
     </CustomerService:OutputValues>
     <CustomerService:StateValues xsi:type="CustomerService:StringDictionary">
      <CustomerService:StringKeyValuePair>
       <CustomerService:Key xsi:type="xsd:string"></CustomerService:Key>
       <CustomerService:Value xsi:type="xsd:string"></CustomerService:Value>
      </CustomerService:StringKeyValuePair>
     </CustomerService:StateValues>
     <CustomerService:Exception xsi:type="xsd:string"></CustomerService:Exception>
    </CustomerService:EventData>
   </CustomerService:ExecuteEventHandlers>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ExecuteEventHandlers Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <CustomerService:ExecuteEventHandlersResponse>
   <CustomerService:Response xsi:type="CustomerService:EventData">
    <CustomerService:Type xsi:type="CustomerService:EventHandlerType">Unknown</CustomerService:Type>
    <CustomerService:InputValues xsi:type="CustomerService:StringDictionary">
     <CustomerService:StringKeyValuePair>
      <CustomerService:Key xsi:type="xsd:string"></CustomerService:Key>
      <CustomerService:Value xsi:type="xsd:string"></CustomerService:Value>
     </CustomerService:StringKeyValuePair>
    </CustomerService:InputValues>
    <CustomerService:BlockExecution xsi:type="xsd:boolean">false</CustomerService:BlockExecution>
    <CustomerService:NavigateTo xsi:type="xsd:string"></CustomerService:NavigateTo>
    <CustomerService:Message xsi:type="xsd:string"></CustomerService:Message>
    <CustomerService:OutputValues xsi:type="CustomerService:StringDictionary">
     <CustomerService:StringKeyValuePair>
      <CustomerService:Key xsi:type="xsd:string"></CustomerService:Key>
      <CustomerService:Value xsi:type="xsd:string"></CustomerService:Value>
     </CustomerService:StringKeyValuePair>
    </CustomerService:OutputValues>
    <CustomerService:StateValues xsi:type="CustomerService:StringDictionary">
     <CustomerService:StringKeyValuePair>
      <CustomerService:Key xsi:type="xsd:string"></CustomerService:Key>
      <CustomerService:Value xsi:type="xsd:string"></CustomerService:Value>
     </CustomerService:StringKeyValuePair>
    </CustomerService:StateValues>
    <CustomerService:Exception xsi:type="xsd:string"></CustomerService:Exception>
   </CustomerService:Response>
  </CustomerService:ExecuteEventHandlersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

