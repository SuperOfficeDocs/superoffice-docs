---
uid: services82-configuration-savewindowpossizes
title: Services82.ConfigurationAgent.SaveWindowPosSizes SOAP
Generated: true
---

# Services82 Configuration SaveWindowPosSizes SOAP

SOAP request and response examples **Remote/Services82/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IConfigurationAgent.SaveWindowPosSizes">SuperOffice.Services82.IConfigurationAgent.SaveWindowPosSizes</see> method.

## SaveWindowPosSizes

Saves a set of window and dialog position and size settings.

* **windowPosSizes:** The items that are saved

**Returns:** The saved items


[WSDL file for Services82/Configuration](../Services82-Configuration.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveWindowPosSizes Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:SaveWindowPosSizes>
    <Configuration:WindowPosSizes xsi:type="Configuration:ArrayOfWindowPosSize">
     <Configuration:WindowPosSize xsi:type="Configuration:WindowPosSize">
      <Configuration:OwnerWindow xsi:type="xsd:string"></Configuration:OwnerWindow>
      <Configuration:PersonId xsi:type="xsd:int">0</Configuration:PersonId>
      <Configuration:AssociateId xsi:type="xsd:int">0</Configuration:AssociateId>
      <Configuration:ExtraId xsi:type="xsd:int">0</Configuration:ExtraId>
      <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
      <Configuration:Height xsi:type="xsd:int">0</Configuration:Height>
      <Configuration:LeftX xsi:type="xsd:int">0</Configuration:LeftX>
      <Configuration:State xsi:type="Configuration:ShowWindowState">Normal</Configuration:State>
      <Configuration:UpperY xsi:type="xsd:int">0</Configuration:UpperY>
      <Configuration:Width xsi:type="xsd:int">0</Configuration:Width>
      <Configuration:WindowPosSizeId xsi:type="xsd:int">0</Configuration:WindowPosSizeId>
     </Configuration:WindowPosSize>
    </Configuration:WindowPosSizes>
   </Configuration:SaveWindowPosSizes>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveWindowPosSizes Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <Configuration:SaveWindowPosSizesResponse>
   <Configuration:Response xsi:type="Configuration:ArrayOfWindowPosSize">
    <Configuration:WindowPosSize xsi:type="Configuration:WindowPosSize">
     <Configuration:OwnerWindow xsi:type="xsd:string"></Configuration:OwnerWindow>
     <Configuration:PersonId xsi:type="xsd:int">0</Configuration:PersonId>
     <Configuration:AssociateId xsi:type="xsd:int">0</Configuration:AssociateId>
     <Configuration:ExtraId xsi:type="xsd:int">0</Configuration:ExtraId>
     <Configuration:ExtraInfo xsi:type="xsd:string"></Configuration:ExtraInfo>
     <Configuration:Height xsi:type="xsd:int">0</Configuration:Height>
     <Configuration:LeftX xsi:type="xsd:int">0</Configuration:LeftX>
     <Configuration:State xsi:type="Configuration:ShowWindowState">Normal</Configuration:State>
     <Configuration:UpperY xsi:type="xsd:int">0</Configuration:UpperY>
     <Configuration:Width xsi:type="xsd:int">0</Configuration:Width>
     <Configuration:WindowPosSizeId xsi:type="xsd:int">0</Configuration:WindowPosSizeId>
    </Configuration:WindowPosSize>
   </Configuration:Response>
  </Configuration:SaveWindowPosSizesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

