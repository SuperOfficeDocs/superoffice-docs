---
uid: services81-configuration-savewindowpossize
title: Services81.ConfigurationAgent.SaveWindowPosSize SOAP
Generated: true
---

# Services81 Configuration SaveWindowPosSize SOAP

SOAP request and response examples **Remote/Services81/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IConfigurationAgent.SaveWindowPosSize">SuperOffice.Services81.IConfigurationAgent.SaveWindowPosSize</see> method.

## SaveWindowPosSize

Saves a window and dialog position and size setting.

* **windowPosSize:** The item that is saved

**Returns:** The saved item


[WSDL file for Services81/Configuration](../Services81-Configuration.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveWindowPosSize Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:SaveWindowPosSize>
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
   </Configuration:SaveWindowPosSize>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveWindowPosSize Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Configuration:SaveWindowPosSizeResponse>
   <Configuration:Response xsi:type="Configuration:WindowPosSize">
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
   </Configuration:Response>
  </Configuration:SaveWindowPosSizeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

