---
uid: services85-list-getwebpanellist
title: Services85.ListAgent.GetWebPanelList SOAP
Generated: true
---

# Services85 List GetWebPanelList SOAP

SOAP request and response examples **Remote/Services85/List.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IListAgent.GetWebPanelList">SuperOffice.Services85.IListAgent.GetWebPanelList</see> method.

## GetWebPanelList

Return a list of all web panels.


**Returns:** List of all web panels


[WSDL file for Services85/List](../Services85-List.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetWebPanelList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetWebPanelList>
   </List:GetWebPanelList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetWebPanelList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <List:GetWebPanelListResponse>
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
     <List:Icon xsi:type="xsd:short">0</List:Icon>
    </List:WebPanelEntity>
   </List:Response>
  </List:GetWebPanelListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

