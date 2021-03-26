---
uid: services80-list-getappwebpanels
title: Services80.ListAgent.GetAppWebPanels SOAP
Generated: true
---

# Services80 List GetAppWebPanels SOAP

SOAP request and response examples **Remote/Services80/List.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IListAgent.GetAppWebPanels">SuperOffice.Services80.IListAgent.GetAppWebPanels</see> method.

## GetAppWebPanels

Get all web panels owned by your app; works in Online only, for registered Apps that send a valid ApplicationToken


**Returns:** List of all web panels owned by the current App


[WSDL file for Services80/List](../Services80-List.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetAppWebPanels Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetAppWebPanels>
   </List:GetAppWebPanels>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetAppWebPanels Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <List:GetAppWebPanelsResponse>
   <List:Response xsi:type="List:ArrayOfWebPanelEntity">
    <List:WebPanelEntity xsi:type="List:WebPanelEntity">
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
    </List:WebPanelEntity>
   </List:Response>
  </List:GetAppWebPanelsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

