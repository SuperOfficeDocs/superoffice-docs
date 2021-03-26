---
uid: services81-list-getwebpanelbyprogid
title: Services81.ListAgent.GetWebPanelByProgId SOAP
Generated: true
---

# Services81 List GetWebPanelByProgId SOAP

SOAP request and response examples **Remote/Services81/List.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IListAgent.GetWebPanelByProgId">SuperOffice.Services81.IListAgent.GetWebPanelByProgId</see> method.

## GetWebPanelByProgId

Get a web panel using the ProgId key that was specified when it was created

* **progId:** String key that can be used to uniquely retrieve the panel, set in the WebPanelEntity when saving

**Returns:** The Web panel information


[WSDL file for Services81/List](../Services81-List.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetWebPanelByProgId Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetWebPanelByProgId>
    <List:ProgId xsi:type="xsd:string"></List:ProgId>
   </List:GetWebPanelByProgId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetWebPanelByProgId Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <List:GetWebPanelByProgIdResponse>
   <List:Response xsi:type="List:WebPanelEntity">
    <List:WebPanelId xsi:type="xsd:int">0</List:WebPanelId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    <List:Rank xsi:type="xsd:int">0</List:Rank>
    <List:UrlEncoding xsi:type="List:UrlEncoding">Unknown</List:UrlEncoding>
    <List:VisibleIn xsi:type="List:Navigation">Invisible</List:VisibleIn>
    <List:OnCentral xsi:type="xsd:boolean">false</List:OnCentral>
    <List:OnSatellite xsi:type="xsd:boolean">false</List:OnSatellite>
    <List:OnTravel xsi:type="xsd:boolean">false</List:OnTravel>
    <List:OnSalesMarketingWeb xsi:type="xsd:boolean">false</List:OnSalesMarketingWeb>
    <List:OnSalesMarketingPocket xsi:type="xsd:boolean">false</List:OnSalesMarketingPocket>
    <List:ShowInMenuBar xsi:type="xsd:boolean">false</List:ShowInMenuBar>
    <List:ShowInToolBar xsi:type="xsd:boolean">false</List:ShowInToolBar>
    <List:ShowInAddressBar xsi:type="xsd:boolean">false</List:ShowInAddressBar>
    <List:ShowInStatusBar xsi:type="xsd:boolean">false</List:ShowInStatusBar>
    <List:WindowName xsi:type="xsd:string"></List:WindowName>
    <List:Url xsi:type="xsd:string"></List:Url>
    <List:ProgId xsi:type="xsd:string"></List:ProgId>
    <List:Icon xsi:type="xsd:short">0</List:Icon>
   </List:Response>
  </List:GetWebPanelByProgIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

