---
uid: services86-list-getextappentity
title: Services86.ListAgent.GetExtAppEntity SOAP
Generated: true
---

# Services86 List GetExtAppEntity SOAP

SOAP request and response examples **Remote/Services86/List.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IListAgent.GetExtAppEntity">SuperOffice.Services86.IListAgent.GetExtAppEntity</see> method.

## GetExtAppEntity

Gets a ExtAppEntity object.

* **extAppEntityId:** The identifier of the ExtAppEntity object

**Returns:** ExtAppEntity


[WSDL file for Services86/List](../Services86-List.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetExtAppEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetExtAppEntity>
    <List:ExtAppEntityId xsi:type="xsd:int">0</List:ExtAppEntityId>
   </List:GetExtAppEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetExtAppEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <List:GetExtAppEntityResponse>
   <List:Response xsi:type="List:ExtAppEntity">
    <List:ExtAppId xsi:type="xsd:int">0</List:ExtAppId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    <List:Rank xsi:type="xsd:int">0</List:Rank>
    <List:Filename xsi:type="xsd:string"></List:Filename>
    <List:Parameters xsi:type="xsd:string"></List:Parameters>
    <List:Workdir xsi:type="xsd:string"></List:Workdir>
    <List:ShowState xsi:type="List:ShowState">Maximized</List:ShowState>
    <List:VisibleIn xsi:type="List:Navigation">Invisible</List:VisibleIn>
    <List:OnCentral xsi:type="xsd:boolean">false</List:OnCentral>
    <List:OnSatellite xsi:type="xsd:boolean">false</List:OnSatellite>
    <List:OnTravel xsi:type="xsd:boolean">false</List:OnTravel>
    <List:OnSalesMarketingPocket xsi:type="xsd:boolean">false</List:OnSalesMarketingPocket>
    <List:ShowInMenuBar xsi:type="xsd:boolean">false</List:ShowInMenuBar>
    <List:ShowInToolBar xsi:type="xsd:boolean">false</List:ShowInToolBar>
    <List:ShowInAddressBar xsi:type="xsd:boolean">false</List:ShowInAddressBar>
    <List:ShowInStatusBar xsi:type="xsd:boolean">false</List:ShowInStatusBar>
    <List:Icon xsi:type="xsd:short">0</List:Icon>
    <List:WaitToFinish xsi:type="xsd:boolean">false</List:WaitToFinish>
    <List:ExecuteOnEvent xsi:type="List:ExecuteOnEvent">Never</List:ExecuteOnEvent>
    <List:Path xsi:type="xsd:string"></List:Path>
   </List:Response>
  </List:GetExtAppEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

