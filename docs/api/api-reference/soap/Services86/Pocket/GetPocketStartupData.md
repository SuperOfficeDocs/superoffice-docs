---
title: Services86.PocketAgent.GetPocketStartupData SOAP
generated: 1
uid: Services86-Pocket-GetPocketStartupData
---

# Services86 Pocket GetPocketStartupData

SOAP request and response examples **Remote/Services86/Pocket.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IPocketAgent.GetPocketStartupData">SuperOffice.Services86.IPocketAgent.GetPocketStartupData</see> method.

## GetPocketStartupData



* **tables:** Tables to check for license
* **currentClientTime:** Current time on the client, used for overdue sale lookup having correct timezone relative to client

**Returns:** Startup data for pocket


[WSDL file for Services86/Pocket](../Services86-Pocket.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPocketStartupData Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Pocket:ApplicationToken>1234567-1234-9876</Pocket:ApplicationToken>
  <Pocket:Credentials>
    <Pocket:Ticket>7T:1234abcxyzExample==</Pocket:Ticket>
  </Pocket:Credentials>
 <SOAP-ENV:Body>
   <Pocket:GetPocketStartupData>
    <Pocket:Tables xsi:type="NetServerServices862:ArrayOfstring">
     <NetServerServices862:string xsi:type="xsd:string"></NetServerServices862:string>
    </Pocket:Tables>
    <Pocket:CurrentClientTime xsi:type="xsd:dateTime">2021-11-30T13:23:00Z</Pocket:CurrentClientTime>
   </Pocket:GetPocketStartupData>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPocketStartupData Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Pocket="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Pocket:GetPocketStartupDataResponse>
   <Pocket:Response xsi:type="Pocket:PocketStartupData">
    <Pocket:TableRights xsi:type="Pocket:ArrayOfETableRight">
     <Pocket:ETableRight xsi:type="Pocket:ETableRight">Select</Pocket:ETableRight>
    </Pocket:TableRights>
    <Pocket:PhoneLocaleTimeZoneData xsi:type="Pocket:TimeZoneData">
     <Pocket:TZLocationID xsi:type="xsd:int">0</Pocket:TZLocationID>
     <Pocket:Name xsi:type="xsd:string"></Pocket:Name>
     <Pocket:TZLocationCode xsi:type="xsd:string"></Pocket:TZLocationCode>
     <Pocket:TZLocationCities xsi:type="xsd:string"></Pocket:TZLocationCities>
     <Pocket:IsoNumber xsi:type="xsd:int">0</Pocket:IsoNumber>
     <Pocket:TimeZoneSTDRules xsi:type="Pocket:TimeZoneRuleDictionary">
      <Pocket:TimeZoneRuleKeyValuePair>
       <Pocket:Key xsi:type="xsd:dateTime"></Pocket:Key>
       <Pocket:Value xsi:type="Pocket:TimeZoneRule">
        <Pocket:TZOffset xsi:type="xsd:int">0</Pocket:TZOffset>
        <Pocket:StartRulePattern xsi:type="xsd:string"></Pocket:StartRulePattern>
        <Pocket:EndRulePattern xsi:type="xsd:string"></Pocket:EndRulePattern>
        <Pocket:StartDay xsi:type="xsd:int">0</Pocket:StartDay>
        <Pocket:StartMonth xsi:type="xsd:int">0</Pocket:StartMonth>
        <Pocket:EndDay xsi:type="xsd:int">0</Pocket:EndDay>
        <Pocket:EndMonth xsi:type="xsd:int">0</Pocket:EndMonth>
       </Pocket:Value>
      </Pocket:TimeZoneRuleKeyValuePair>
     </Pocket:TimeZoneSTDRules>
     <Pocket:TimeZoneDSTRules xsi:type="Pocket:TimeZoneRuleDictionary">
      <Pocket:TimeZoneRuleKeyValuePair>
       <Pocket:Key xsi:type="xsd:dateTime"></Pocket:Key>
       <Pocket:Value xsi:type="Pocket:TimeZoneRule">
        <Pocket:TZOffset xsi:type="xsd:int">0</Pocket:TZOffset>
        <Pocket:StartRulePattern xsi:type="xsd:string"></Pocket:StartRulePattern>
        <Pocket:EndRulePattern xsi:type="xsd:string"></Pocket:EndRulePattern>
        <Pocket:StartDay xsi:type="xsd:int">0</Pocket:StartDay>
        <Pocket:StartMonth xsi:type="xsd:int">0</Pocket:StartMonth>
        <Pocket:EndDay xsi:type="xsd:int">0</Pocket:EndDay>
        <Pocket:EndMonth xsi:type="xsd:int">0</Pocket:EndMonth>
       </Pocket:Value>
      </Pocket:TimeZoneRuleKeyValuePair>
     </Pocket:TimeZoneDSTRules>
    </Pocket:PhoneLocaleTimeZoneData>
    <Pocket:BaseLocaleTimeZoneData xsi:type="Pocket:TimeZoneData">
     <Pocket:TZLocationID xsi:type="xsd:int">0</Pocket:TZLocationID>
     <Pocket:Name xsi:type="xsd:string"></Pocket:Name>
     <Pocket:TZLocationCode xsi:type="xsd:string"></Pocket:TZLocationCode>
     <Pocket:TZLocationCities xsi:type="xsd:string"></Pocket:TZLocationCities>
     <Pocket:IsoNumber xsi:type="xsd:int">0</Pocket:IsoNumber>
     <Pocket:TimeZoneSTDRules xsi:type="Pocket:TimeZoneRuleDictionary">
      <Pocket:TimeZoneRuleKeyValuePair>
       <Pocket:Key xsi:type="xsd:dateTime"></Pocket:Key>
       <Pocket:Value xsi:type="Pocket:TimeZoneRule">
        <Pocket:TZOffset xsi:type="xsd:int">0</Pocket:TZOffset>
        <Pocket:StartRulePattern xsi:type="xsd:string"></Pocket:StartRulePattern>
        <Pocket:EndRulePattern xsi:type="xsd:string"></Pocket:EndRulePattern>
        <Pocket:StartDay xsi:type="xsd:int">0</Pocket:StartDay>
        <Pocket:StartMonth xsi:type="xsd:int">0</Pocket:StartMonth>
        <Pocket:EndDay xsi:type="xsd:int">0</Pocket:EndDay>
        <Pocket:EndMonth xsi:type="xsd:int">0</Pocket:EndMonth>
       </Pocket:Value>
      </Pocket:TimeZoneRuleKeyValuePair>
     </Pocket:TimeZoneSTDRules>
     <Pocket:TimeZoneDSTRules xsi:type="Pocket:TimeZoneRuleDictionary">
      <Pocket:TimeZoneRuleKeyValuePair>
       <Pocket:Key xsi:type="xsd:dateTime"></Pocket:Key>
       <Pocket:Value xsi:type="Pocket:TimeZoneRule">
        <Pocket:TZOffset xsi:type="xsd:int">0</Pocket:TZOffset>
        <Pocket:StartRulePattern xsi:type="xsd:string"></Pocket:StartRulePattern>
        <Pocket:EndRulePattern xsi:type="xsd:string"></Pocket:EndRulePattern>
        <Pocket:StartDay xsi:type="xsd:int">0</Pocket:StartDay>
        <Pocket:StartMonth xsi:type="xsd:int">0</Pocket:StartMonth>
        <Pocket:EndDay xsi:type="xsd:int">0</Pocket:EndDay>
        <Pocket:EndMonth xsi:type="xsd:int">0</Pocket:EndMonth>
       </Pocket:Value>
      </Pocket:TimeZoneRuleKeyValuePair>
     </Pocket:TimeZoneDSTRules>
    </Pocket:BaseLocaleTimeZoneData>
    <Pocket:OverdueSalesCount xsi:type="xsd:int">0</Pocket:OverdueSalesCount>
    <Pocket:NotificationsCount xsi:type="xsd:int">0</Pocket:NotificationsCount>
    <Pocket:SystemWebPanels xsi:type="Pocket:ArrayOfWebPanelEntity">
     <Pocket:WebPanelEntity xsi:type="Pocket:WebPanelEntity">
      <Pocket:WebPanelId xsi:type="xsd:int">0</Pocket:WebPanelId>
      <Pocket:Name xsi:type="xsd:string"></Pocket:Name>
      <Pocket:Tooltip xsi:type="xsd:string"></Pocket:Tooltip>
      <Pocket:Deleted xsi:type="xsd:boolean">false</Pocket:Deleted>
      <Pocket:Rank xsi:type="xsd:int">0</Pocket:Rank>
      <Pocket:UrlEncoding xsi:type="Pocket:UrlEncoding">Unknown</Pocket:UrlEncoding>
      <Pocket:VisibleIn xsi:type="Pocket:Navigation">Invisible</Pocket:VisibleIn>
      <Pocket:OnCentral xsi:type="xsd:boolean">false</Pocket:OnCentral>
      <Pocket:OnSatellite xsi:type="xsd:boolean">false</Pocket:OnSatellite>
      <Pocket:OnTravel xsi:type="xsd:boolean">false</Pocket:OnTravel>
      <Pocket:OnSalesMarketingWeb xsi:type="xsd:boolean">false</Pocket:OnSalesMarketingWeb>
      <Pocket:OnSalesMarketingPocket xsi:type="xsd:boolean">false</Pocket:OnSalesMarketingPocket>
      <Pocket:ShowInMenuBar xsi:type="xsd:boolean">false</Pocket:ShowInMenuBar>
      <Pocket:ShowInToolBar xsi:type="xsd:boolean">false</Pocket:ShowInToolBar>
      <Pocket:ShowInAddressBar xsi:type="xsd:boolean">false</Pocket:ShowInAddressBar>
      <Pocket:ShowInStatusBar xsi:type="xsd:boolean">false</Pocket:ShowInStatusBar>
      <Pocket:WindowName xsi:type="xsd:string"></Pocket:WindowName>
      <Pocket:Url xsi:type="xsd:string"></Pocket:Url>
      <Pocket:ProgId xsi:type="xsd:string"></Pocket:ProgId>
      <Pocket:Icon xsi:type="xsd:short">0</Pocket:Icon>
     </Pocket:WebPanelEntity>
    </Pocket:SystemWebPanels>
    <Pocket:PocketPreferences xsi:type="Pocket:ArrayOfPreference">
     <Pocket:Preference xsi:type="Pocket:Preference">
      <Pocket:Level xsi:type="Pocket:PreferenceLevel">Undefined</Pocket:Level>
      <Pocket:RawValue xsi:type="xsd:string"></Pocket:RawValue>
      <Pocket:Specification xsi:type="Pocket:PreferenceSpec">
       <Pocket:Section xsi:type="xsd:string"></Pocket:Section>
       <Pocket:Key xsi:type="xsd:string"></Pocket:Key>
      </Pocket:Specification>
      <Pocket:DisplayValue xsi:type="xsd:string"></Pocket:DisplayValue>
      <Pocket:DisplayTooltip xsi:type="xsd:string"></Pocket:DisplayTooltip>
      <Pocket:DisplayType xsi:type="Pocket:PrefDescValueType">Unknown</Pocket:DisplayType>
      <Pocket:TabOrder xsi:type="Pocket:TabOrder">
       <Pocket:TabOrderId xsi:type="xsd:int">0</Pocket:TabOrderId>
       <Pocket:TabName xsi:type="xsd:string"></Pocket:TabName>
       <Pocket:Order xsi:type="xsd:string"></Pocket:Order>
       <Pocket:AssociateId xsi:type="xsd:int">0</Pocket:AssociateId>
      </Pocket:TabOrder>
      <Pocket:TargetId xsi:type="xsd:int">0</Pocket:TargetId>
      <Pocket:PrefDescId xsi:type="xsd:int">0</Pocket:PrefDescId>
      <Pocket:TableName xsi:type="xsd:string"></Pocket:TableName>
      <Pocket:UserPreferenceId xsi:type="xsd:int">0</Pocket:UserPreferenceId>
     </Pocket:Preference>
    </Pocket:PocketPreferences>
    <Pocket:IsPushNotificationEnabled xsi:type="xsd:boolean">false</Pocket:IsPushNotificationEnabled>
    <Pocket:CustomData xsi:type="xsd:string"></Pocket:CustomData>
   </Pocket:Response>
  </Pocket:GetPocketStartupDataResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

