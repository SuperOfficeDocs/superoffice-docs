---
uid: services84-quote-saveconnection
title: Services84.QuoteAgent.SaveConnection SOAP
Generated: true
---

# Services84 Quote SaveConnection SOAP

SOAP request and response examples **Remote/Services84/Quote.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IQuoteAgent.SaveConnection">SuperOffice.Services84.IQuoteAgent.SaveConnection</see> method.

## SaveConnection

Saves a connection to the database.

* **connection:** The connection to save.

**Returns:** The resulting connection.


[WSDL file for Services84/Quote](../Services84-Quote.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveConnection Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Quote:ApplicationToken>1234567-1234-9876</Quote:ApplicationToken>
  <Quote:Credentials>
    <Quote:Ticket>7T:1234abcxyzExample==</Quote:Ticket>
  </Quote:Credentials>
 <SOAP-ENV:Body>
   <Quote:SaveConnection>
    <Quote:Connection xsi:type="Quote:QuoteConnection">
     <Quote:QuoteConnectionId xsi:type="xsd:int">0</Quote:QuoteConnectionId>
     <Quote:ERPName xsi:type="xsd:string"></Quote:ERPName>
     <Quote:DisplayName xsi:type="xsd:string"></Quote:DisplayName>
     <Quote:DisplayDescription xsi:type="xsd:string"></Quote:DisplayDescription>
     <Quote:Rank xsi:type="xsd:int">0</Quote:Rank>
     <Quote:ConnectorName xsi:type="xsd:string"></Quote:ConnectorName>
     <Quote:ErpConnectionId xsi:type="xsd:int">0</Quote:ErpConnectionId>
     <Quote:ExtraData xsi:type="xsd:string"></Quote:ExtraData>
     <Quote:IsAvailable xsi:type="xsd:boolean">false</Quote:IsAvailable>
     <Quote:InitializeResponse xsi:type="Quote:PluginResponse">
      <Quote:IsOk xsi:type="xsd:boolean">false</Quote:IsOk>
      <Quote:UserExplanation xsi:type="xsd:string"></Quote:UserExplanation>
      <Quote:TechExplanation xsi:type="xsd:string"></Quote:TechExplanation>
      <Quote:ErrorCode xsi:type="xsd:string"></Quote:ErrorCode>
      <Quote:Changes xsi:type="Quote:ChangedData">
       <Quote:AddedRecords xsi:type="Quote:ArrayOfChangedDataItem">
        <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
         <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
         <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
        </Quote:ChangedDataItem>
       </Quote:AddedRecords>
       <Quote:UpdatedRecords xsi:type="Quote:ArrayOfChangedDataItem">
        <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
         <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
         <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
        </Quote:ChangedDataItem>
       </Quote:UpdatedRecords>
       <Quote:DeletedRecords xsi:type="Quote:ArrayOfChangedDataItem">
        <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
         <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
         <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
        </Quote:ChangedDataItem>
       </Quote:DeletedRecords>
      </Quote:Changes>
     </Quote:InitializeResponse>
     <Quote:PriceLists xsi:type="Quote:ArrayOfPriceList">
      <Quote:PriceList xsi:type="Quote:PriceList">
       <Quote:PriceListId xsi:type="xsd:int">0</Quote:PriceListId>
       <Quote:ERPPriceListKey xsi:type="xsd:string"></Quote:ERPPriceListKey>
       <Quote:QuoteConnectionId xsi:type="xsd:int">0</Quote:QuoteConnectionId>
       <Quote:Name xsi:type="xsd:string"></Quote:Name>
       <Quote:Description xsi:type="xsd:string"></Quote:Description>
       <Quote:Currency xsi:type="xsd:string"></Quote:Currency>
       <Quote:CurrencyName xsi:type="xsd:string"></Quote:CurrencyName>
       <Quote:ValidFrom xsi:type="xsd:dateTime">2021-03-25T21:35:34Z</Quote:ValidFrom>
       <Quote:ValidTo xsi:type="xsd:dateTime">2021-03-25T21:35:34Z</Quote:ValidTo>
       <Quote:IsActive xsi:type="xsd:boolean">false</Quote:IsActive>
      </Quote:PriceList>
     </Quote:PriceLists>
     <Quote:AllAccess xsi:type="xsd:boolean">false</Quote:AllAccess>
     <Quote:Deleted xsi:type="xsd:boolean">false</Quote:Deleted>
     <Quote:UserGroupAccessIds xsi:type="NetServerServices842:ArrayOfint">
      <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
     </Quote:UserGroupAccessIds>
     <Quote:AssociateAccessIds xsi:type="NetServerServices842:ArrayOfint">
      <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
     </Quote:AssociateAccessIds>
    </Quote:Connection>
   </Quote:SaveConnection>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveConnection Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Quote="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Quote:SaveConnectionResponse>
   <Quote:Response xsi:type="Quote:QuoteConnection">
    <Quote:QuoteConnectionId xsi:type="xsd:int">0</Quote:QuoteConnectionId>
    <Quote:ERPName xsi:type="xsd:string"></Quote:ERPName>
    <Quote:DisplayName xsi:type="xsd:string"></Quote:DisplayName>
    <Quote:DisplayDescription xsi:type="xsd:string"></Quote:DisplayDescription>
    <Quote:Rank xsi:type="xsd:int">0</Quote:Rank>
    <Quote:ConnectorName xsi:type="xsd:string"></Quote:ConnectorName>
    <Quote:ErpConnectionId xsi:type="xsd:int">0</Quote:ErpConnectionId>
    <Quote:ExtraData xsi:type="xsd:string"></Quote:ExtraData>
    <Quote:IsAvailable xsi:type="xsd:boolean">false</Quote:IsAvailable>
    <Quote:InitializeResponse xsi:type="Quote:PluginResponse">
     <Quote:IsOk xsi:type="xsd:boolean">false</Quote:IsOk>
     <Quote:UserExplanation xsi:type="xsd:string"></Quote:UserExplanation>
     <Quote:TechExplanation xsi:type="xsd:string"></Quote:TechExplanation>
     <Quote:ErrorCode xsi:type="xsd:string"></Quote:ErrorCode>
     <Quote:Changes xsi:type="Quote:ChangedData">
      <Quote:AddedRecords xsi:type="Quote:ArrayOfChangedDataItem">
       <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
        <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
        <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
       </Quote:ChangedDataItem>
      </Quote:AddedRecords>
      <Quote:UpdatedRecords xsi:type="Quote:ArrayOfChangedDataItem">
       <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
        <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
        <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
       </Quote:ChangedDataItem>
      </Quote:UpdatedRecords>
      <Quote:DeletedRecords xsi:type="Quote:ArrayOfChangedDataItem">
       <Quote:ChangedDataItem xsi:type="Quote:ChangedDataItem">
        <Quote:Tablename xsi:type="xsd:string"></Quote:Tablename>
        <Quote:RecordId xsi:type="xsd:int">0</Quote:RecordId>
       </Quote:ChangedDataItem>
      </Quote:DeletedRecords>
     </Quote:Changes>
    </Quote:InitializeResponse>
    <Quote:PriceLists xsi:type="Quote:ArrayOfPriceList">
     <Quote:PriceList xsi:type="Quote:PriceList">
      <Quote:PriceListId xsi:type="xsd:int">0</Quote:PriceListId>
      <Quote:ERPPriceListKey xsi:type="xsd:string"></Quote:ERPPriceListKey>
      <Quote:QuoteConnectionId xsi:type="xsd:int">0</Quote:QuoteConnectionId>
      <Quote:Name xsi:type="xsd:string"></Quote:Name>
      <Quote:Description xsi:type="xsd:string"></Quote:Description>
      <Quote:Currency xsi:type="xsd:string"></Quote:Currency>
      <Quote:CurrencyName xsi:type="xsd:string"></Quote:CurrencyName>
      <Quote:ValidFrom xsi:type="xsd:dateTime">2021-03-25T21:35:34Z</Quote:ValidFrom>
      <Quote:ValidTo xsi:type="xsd:dateTime">2021-03-25T21:35:34Z</Quote:ValidTo>
      <Quote:IsActive xsi:type="xsd:boolean">false</Quote:IsActive>
     </Quote:PriceList>
    </Quote:PriceLists>
    <Quote:AllAccess xsi:type="xsd:boolean">false</Quote:AllAccess>
    <Quote:Deleted xsi:type="xsd:boolean">false</Quote:Deleted>
    <Quote:UserGroupAccessIds xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </Quote:UserGroupAccessIds>
    <Quote:AssociateAccessIds xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </Quote:AssociateAccessIds>
   </Quote:Response>
  </Quote:SaveConnectionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

