---
title: Services88.TargetsAgent.CreateDefaultTargetAssignmentForCompanyWithYearAndDimension SOAP
generated: true
uid: Services88-Targets-CreateDefaultTargetAssignmentForCompanyWithYearAndDimension
content_type: reference
---

# Services88 Targets CreateDefaultTargetAssignmentForCompanyWithYearAndDimension

SOAP request and response examples **Remote/Services88/Targets.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ITargetsAgent.CreateDefaultTargetAssignmentForCompanyWithYearAndDimension">SuperOffice.Services88.ITargetsAgent.CreateDefaultTargetAssignmentForCompanyWithYearAndDimension</see> method.

## CreateDefaultTargetAssignmentForCompanyWithYearAndDimension





[WSDL file for Services88/Targets](../Services88-Targets.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultTargetAssignmentForCompanyWithYearAndDimension Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Targets="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Targets:ApplicationToken>1234567-1234-9876</Targets:ApplicationToken>
  <Targets:Credentials>
    <Targets:Ticket>7T:1234abcxyzExample==</Targets:Ticket>
  </Targets:Credentials>
 <SOAP-ENV:Body>
   <Targets:CreateDefaultTargetAssignmentForCompanyWithYearAndDimension>
    <Targets:Year xsi:type="xsd:int">0</Targets:Year>
    <Targets:TargetDimensionId xsi:type="xsd:int">0</Targets:TargetDimensionId>
   </Targets:CreateDefaultTargetAssignmentForCompanyWithYearAndDimension>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultTargetAssignmentForCompanyWithYearAndDimension Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Targets="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Targets:CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionResponse>
   <Targets:Response xsi:type="Targets:ArrayOfTargetAssignment">
    <Targets:TargetAssignment xsi:type="Targets:TargetAssignment">
     <Targets:TargetAssignmentInfoId xsi:type="xsd:int">0</Targets:TargetAssignmentInfoId>
     <Targets:Values xsi:type="NetServerServices882:ArrayOfdouble">
      <NetServerServices882:double xsi:type="xsd:double">0.0</NetServerServices882:double>
     </Targets:Values>
     <Targets:Locked xsi:type="xsd:boolean">false</Targets:Locked>
     <Targets:TargetAssociate xsi:type="Targets:Associate">
      <Targets:AssociateId xsi:type="xsd:int">0</Targets:AssociateId>
      <Targets:Name xsi:type="xsd:string"></Targets:Name>
      <Targets:PersonId xsi:type="xsd:int">0</Targets:PersonId>
      <Targets:Rank xsi:type="xsd:short">0</Targets:Rank>
      <Targets:Tooltip xsi:type="xsd:string"></Targets:Tooltip>
      <Targets:Type xsi:type="Targets:UserType">Unknown</Targets:Type>
      <Targets:GroupIdx xsi:type="xsd:int">0</Targets:GroupIdx>
      <Targets:FullName xsi:type="xsd:string"></Targets:FullName>
      <Targets:FormalName xsi:type="xsd:string"></Targets:FormalName>
      <Targets:Deleted xsi:type="xsd:boolean">false</Targets:Deleted>
      <Targets:EjUserId xsi:type="xsd:int">0</Targets:EjUserId>
      <Targets:UserName xsi:type="xsd:string"></Targets:UserName>
      <Targets:ExtraFields xsi:type="Targets:StringDictionary">
       <Targets:StringKeyValuePair>
        <Targets:Key xsi:type="xsd:string"></Targets:Key>
        <Targets:Value xsi:type="xsd:string"></Targets:Value>
       </Targets:StringKeyValuePair>
      </Targets:ExtraFields>
      <Targets:CustomFields xsi:type="Targets:StringDictionary">
       <Targets:StringKeyValuePair>
        <Targets:Key xsi:type="xsd:string"></Targets:Key>
        <Targets:Value xsi:type="xsd:string"></Targets:Value>
       </Targets:StringKeyValuePair>
      </Targets:CustomFields>
     </Targets:TargetAssociate>
     <Targets:TargetContact xsi:type="Targets:Contact">
      <Targets:ContactId xsi:type="xsd:int">0</Targets:ContactId>
      <Targets:Name xsi:type="xsd:string"></Targets:Name>
      <Targets:OrgNr xsi:type="xsd:string"></Targets:OrgNr>
      <Targets:Department xsi:type="xsd:string"></Targets:Department>
      <Targets:URL xsi:type="xsd:string"></Targets:URL>
      <Targets:City xsi:type="xsd:string"></Targets:City>
      <Targets:DirectPhone xsi:type="xsd:string"></Targets:DirectPhone>
      <Targets:AssociateId xsi:type="xsd:int">0</Targets:AssociateId>
      <Targets:CountryId xsi:type="xsd:int">0</Targets:CountryId>
      <Targets:EmailAddress xsi:type="xsd:string"></Targets:EmailAddress>
      <Targets:Kananame xsi:type="xsd:string"></Targets:Kananame>
      <Targets:EmailAddressName xsi:type="xsd:string"></Targets:EmailAddressName>
      <Targets:URLName xsi:type="xsd:string"></Targets:URLName>
      <Targets:AssociateFullName xsi:type="xsd:string"></Targets:AssociateFullName>
      <Targets:BusinessName xsi:type="xsd:string"></Targets:BusinessName>
      <Targets:CategoryName xsi:type="xsd:string"></Targets:CategoryName>
      <Targets:CountryName xsi:type="xsd:string"></Targets:CountryName>
      <Targets:Address xsi:type="Targets:Address">
       <Targets:Wgs84Latitude xsi:type="xsd:double">0.0</Targets:Wgs84Latitude>
       <Targets:Wgs84Longitude xsi:type="xsd:double">0.0</Targets:Wgs84Longitude>
       <Targets:LocalizedAddress xsi:type="Targets:ArrayOfArrayOfLocalizedField">
        <Targets:ArrayOfLocalizedField xsi:type="Targets:ArrayOfLocalizedField">
         <Targets:LocalizedField xsi:type="Targets:LocalizedField">
          <Targets:Name xsi:type="xsd:string"></Targets:Name>
          <Targets:Value xsi:type="xsd:string"></Targets:Value>
          <Targets:Tooltip xsi:type="xsd:string"></Targets:Tooltip>
          <Targets:Label xsi:type="xsd:string"></Targets:Label>
          <Targets:ValueLength xsi:nil="true"></Targets:ValueLength>
          <Targets:AddressType xsi:type="xsd:string"></Targets:AddressType>
         </Targets:LocalizedField>
        </Targets:ArrayOfLocalizedField>
       </Targets:LocalizedAddress>
       <Targets:Street xsi:type="Targets:StructuredAddress">
        <Targets:AtypeIdx xsi:type="Targets:AddressType">Unknown</Targets:AtypeIdx>
        <Targets:Address1 xsi:type="xsd:string"></Targets:Address1>
        <Targets:Address2 xsi:type="xsd:string"></Targets:Address2>
        <Targets:Address3 xsi:type="xsd:string"></Targets:Address3>
        <Targets:City xsi:type="xsd:string"></Targets:City>
        <Targets:County xsi:type="xsd:string"></Targets:County>
        <Targets:State xsi:type="xsd:string"></Targets:State>
        <Targets:Zipcode xsi:type="xsd:string"></Targets:Zipcode>
        <Targets:Formatted xsi:type="xsd:string"></Targets:Formatted>
       </Targets:Street>
       <Targets:Postal xsi:type="Targets:StructuredAddress">
        <Targets:AtypeIdx xsi:type="Targets:AddressType">Unknown</Targets:AtypeIdx>
        <Targets:Address1 xsi:type="xsd:string"></Targets:Address1>
        <Targets:Address2 xsi:type="xsd:string"></Targets:Address2>
        <Targets:Address3 xsi:type="xsd:string"></Targets:Address3>
        <Targets:City xsi:type="xsd:string"></Targets:City>
        <Targets:County xsi:type="xsd:string"></Targets:County>
        <Targets:State xsi:type="xsd:string"></Targets:State>
        <Targets:Zipcode xsi:type="xsd:string"></Targets:Zipcode>
        <Targets:Formatted xsi:type="xsd:string"></Targets:Formatted>
       </Targets:Postal>
       <Targets:Formatted xsi:type="xsd:string"></Targets:Formatted>
      </Targets:Address>
      <Targets:FormattedAddress xsi:type="xsd:string"></Targets:FormattedAddress>
      <Targets:FullName xsi:type="xsd:string"></Targets:FullName>
      <Targets:IsOwnerContact xsi:type="xsd:boolean">false</Targets:IsOwnerContact>
      <Targets:ActiveErpLinks xsi:type="xsd:int">0</Targets:ActiveErpLinks>
      <Targets:Number1 xsi:type="xsd:string"></Targets:Number1>
      <Targets:Number2 xsi:type="xsd:string"></Targets:Number2>
     </Targets:TargetContact>
     <Targets:TargetUserGroup xsi:type="Targets:UserGroup">
      <Targets:Value xsi:type="xsd:string"></Targets:Value>
      <Targets:Tooltip xsi:type="xsd:string"></Targets:Tooltip>
      <Targets:Id xsi:type="xsd:int">0</Targets:Id>
      <Targets:Rank xsi:type="xsd:short">0</Targets:Rank>
      <Targets:Deleted xsi:type="xsd:boolean">false</Targets:Deleted>
     </Targets:TargetUserGroup>
     <Targets:Currency xsi:type="Targets:Currency">
      <Targets:Id xsi:type="xsd:int">0</Targets:Id>
      <Targets:Value xsi:type="xsd:string"></Targets:Value>
      <Targets:Tooltip xsi:type="xsd:string"></Targets:Tooltip>
     </Targets:Currency>
     <Targets:DimensionListItem xsi:type="xsd:int">0</Targets:DimensionListItem>
     <Targets:DimensionListItemDisplayName xsi:type="xsd:string"></Targets:DimensionListItemDisplayName>
    </Targets:TargetAssignment>
   </Targets:Response>
  </Targets:CreateDefaultTargetAssignmentForCompanyWithYearAndDimensionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

