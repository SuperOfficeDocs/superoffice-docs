---
uid: services83-configuration-getwindowpossize
title: Services83.ConfigurationAgent.GetWindowPosSize SOAP
Generated: true
---

# Services83 Configuration GetWindowPosSize SOAP

SOAP request and response examples **Remote/Services83/Configuration.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IConfigurationAgent.GetWindowPosSize">SuperOffice.Services83.IConfigurationAgent.GetWindowPosSize</see> method.

## GetWindowPosSize

Gets a WindowPosSize object.

* **windowPosSizeId:** The identifier of the WindowPosSize object

**Returns:** WindowPosSize


[WSDL file for Services83/Configuration](../Services83-Configuration.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetWindowPosSize Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Configuration:ApplicationToken>1234567-1234-9876</Configuration:ApplicationToken>
  <Configuration:Credentials>
    <Configuration:Ticket>7T:1234abcxyzExample==</Configuration:Ticket>
  </Configuration:Credentials>
 <SOAP-ENV:Body>
   <Configuration:GetWindowPosSize>
    <Configuration:WindowPosSizeId xsi:type="xsd:int">0</Configuration:WindowPosSizeId>
   </Configuration:GetWindowPosSize>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetWindowPosSize Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Configuration="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Configuration:GetWindowPosSizeResponse>
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
  </Configuration:GetWindowPosSizeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

