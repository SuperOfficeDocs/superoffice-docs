---
title: Services85.SoPrincipalAgent.GetSystemInfo SOAP
generated: 1
uid: Services85-SoPrincipal-GetSystemInfo
---

# Services85 SoPrincipal GetSystemInfo

SOAP request and response examples **Remote/Services85/SoPrincipal.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ISoPrincipalAgent.GetSystemInfo">SuperOffice.Services85.ISoPrincipalAgent.GetSystemInfo</see> method.

## GetSystemInfo





[WSDL file for Services85/SoPrincipal](../Services85-SoPrincipal.md)

## GetSystemInfo Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices853="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:SoPrincipal="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <SoPrincipal:ApplicationToken>1234567-1234-9876</SoPrincipal:ApplicationToken>
 <SOAP-ENV:Body>
   <SoPrincipal:GetSystemInfo>
   </SoPrincipal:GetSystemInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSystemInfo Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices853="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:SoPrincipal="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <SoPrincipal:GetSystemInfoResponse>
   <SoPrincipal:SystemInfo xsi:type="SoPrincipal:SoSystemInfoCarrier">
    <SoPrincipal:License xsi:type="SoPrincipal:LicenseInfo">
     <SoPrincipal:CompanyName xsi:type="xsd:string"></SoPrincipal:CompanyName>
     <SoPrincipal:SerialNr xsi:type="xsd:string"></SoPrincipal:SerialNr>
     <SoPrincipal:OwnerName xsi:type="xsd:string"></SoPrincipal:OwnerName>
     <SoPrincipal:OwnerDescription xsi:type="xsd:string"></SoPrincipal:OwnerDescription>
     <SoPrincipal:NextCheckDate xsi:type="xsd:dateTime">2021-11-30T13:22:43Z</SoPrincipal:NextCheckDate>
     <SoPrincipal:MaintenanceDate xsi:type="xsd:dateTime">2021-11-30T13:22:43Z</SoPrincipal:MaintenanceDate>
     <SoPrincipal:AdminWarningDate xsi:type="xsd:dateTime">2021-11-30T13:22:43Z</SoPrincipal:AdminWarningDate>
     <SoPrincipal:ExpiryDate xsi:type="xsd:dateTime">2021-11-30T13:22:43Z</SoPrincipal:ExpiryDate>
     <SoPrincipal:GraceDate xsi:type="xsd:dateTime">2021-11-30T13:22:43Z</SoPrincipal:GraceDate>
     <SoPrincipal:ExtraFlags xsi:type="xsd:int">0</SoPrincipal:ExtraFlags>
     <SoPrincipal:LicenseUrl xsi:type="xsd:string"></SoPrincipal:LicenseUrl>
     <SoPrincipal:LicenseVersion xsi:type="xsd:string"></SoPrincipal:LicenseVersion>
     <SoPrincipal:DeploymentType xsi:type="xsd:int">0</SoPrincipal:DeploymentType>
     <SoPrincipal:ProductType xsi:type="xsd:string"></SoPrincipal:ProductType>
     <SoPrincipal:ProductDescription xsi:type="xsd:string"></SoPrincipal:ProductDescription>
     <SoPrincipal:ModuleLicenses xsi:type="SoPrincipal:ArrayOfModuleLicense">
      <SoPrincipal:ModuleLicense xsi:type="SoPrincipal:ModuleLicense">
       <SoPrincipal:OwnerName xsi:type="xsd:string"></SoPrincipal:OwnerName>
       <SoPrincipal:ModuleName xsi:type="xsd:string"></SoPrincipal:ModuleName>
       <SoPrincipal:ModuleDescription xsi:type="xsd:string"></SoPrincipal:ModuleDescription>
       <SoPrincipal:ModuleTooltip xsi:type="xsd:string"></SoPrincipal:ModuleTooltip>
       <SoPrincipal:ModuleVersion xsi:type="xsd:string"></SoPrincipal:ModuleVersion>
       <SoPrincipal:LicenseType xsi:type="SoPrincipal:LicenseType">Unknown</SoPrincipal:LicenseType>
       <SoPrincipal:Unrestricted xsi:type="xsd:boolean">false</SoPrincipal:Unrestricted>
       <SoPrincipal:AllowedUserType xsi:type="SoPrincipal:UserType">Unknown</SoPrincipal:AllowedUserType>
       <SoPrincipal:NumberOfLicenses xsi:type="xsd:int">0</SoPrincipal:NumberOfLicenses>
       <SoPrincipal:ExtraFlags xsi:type="xsd:int">0</SoPrincipal:ExtraFlags>
       <SoPrincipal:ExtraInfo xsi:type="xsd:string"></SoPrincipal:ExtraInfo>
       <SoPrincipal:SortOrder xsi:type="xsd:int">0</SoPrincipal:SortOrder>
       <SoPrincipal:IsHidden xsi:type="xsd:boolean">false</SoPrincipal:IsHidden>
       <SoPrincipal:PrerequisiteModuleName xsi:type="xsd:string"></SoPrincipal:PrerequisiteModuleName>
       <SoPrincipal:Signature xsi:type="xsd:string"></SoPrincipal:Signature>
      </SoPrincipal:ModuleLicense>
     </SoPrincipal:ModuleLicenses>
     <SoPrincipal:PublicKey xsi:type="SoPrincipal:SignedPublicKey">
      <SoPrincipal:OwnerName xsi:type="xsd:string"></SoPrincipal:OwnerName>
      <SoPrincipal:SignDate xsi:type="xsd:dateTime">2021-11-30T13:22:43Z</SoPrincipal:SignDate>
      <SoPrincipal:ExpiryDate xsi:type="xsd:dateTime">2021-11-30T13:22:43Z</SoPrincipal:ExpiryDate>
      <SoPrincipal:Key xsi:type="NetServerServices852:DSAParameters">
       <NetServerServices852:Counter xsi:type="xsd:int">0</NetServerServices852:Counter>
       <NetServerServices852:G xsi:type="xsd:base64Binary"></NetServerServices852:G>
       <NetServerServices852:J xsi:type="xsd:base64Binary"></NetServerServices852:J>
       <NetServerServices852:P xsi:type="xsd:base64Binary"></NetServerServices852:P>
       <NetServerServices852:Q xsi:type="xsd:base64Binary"></NetServerServices852:Q>
       <NetServerServices852:Seed xsi:type="xsd:base64Binary"></NetServerServices852:Seed>
       <NetServerServices852:Y xsi:type="xsd:base64Binary"></NetServerServices852:Y>
      </SoPrincipal:Key>
      <SoPrincipal:Signature xsi:type="xsd:string"></SoPrincipal:Signature>
     </SoPrincipal:PublicKey>
     <SoPrincipal:Signature xsi:type="xsd:string"></SoPrincipal:Signature>
    </SoPrincipal:License>
    <SoPrincipal:WarningEnglish xsi:type="xsd:string"></SoPrincipal:WarningEnglish>
    <SoPrincipal:WarningResource xsi:type="xsd:string"></SoPrincipal:WarningResource>
    <SoPrincipal:BranchName xsi:type="xsd:string"></SoPrincipal:BranchName>
    <SoPrincipal:BuildLabel xsi:type="xsd:string"></SoPrincipal:BuildLabel>
    <SoPrincipal:AssemblyVersion xsi:type="xsd:string"></SoPrincipal:AssemblyVersion>
    <SoPrincipal:AccumulatedNextCheckDate xsi:type="xsd:dateTime">2021-11-30T13:22:43Z</SoPrincipal:AccumulatedNextCheckDate>
    <SoPrincipal:FileVersion xsi:type="xsd:string"></SoPrincipal:FileVersion>
    <SoPrincipal:Description xsi:type="xsd:string"></SoPrincipal:Description>
    <SoPrincipal:DaysUntilNetServerExpiry xsi:type="xsd:int">0</SoPrincipal:DaysUntilNetServerExpiry>
    <SoPrincipal:BuildType xsi:type="SoPrincipal:NetServerBuildType">Feature</SoPrincipal:BuildType>
    <SoPrincipal:DatabaseVersion xsi:type="xsd:int">0</SoPrincipal:DatabaseVersion>
    <SoPrincipal:IsUnicode xsi:type="xsd:boolean">false</SoPrincipal:IsUnicode>
    <SoPrincipal:CompanyName xsi:type="xsd:string"></SoPrincipal:CompanyName>
    <SoPrincipal:CompanyId xsi:type="xsd:int">0</SoPrincipal:CompanyId>
    <SoPrincipal:DatabaseType xsi:type="xsd:string"></SoPrincipal:DatabaseType>
    <SoPrincipal:DatabaseMinor xsi:type="xsd:string"></SoPrincipal:DatabaseMinor>
    <SoPrincipal:DatabaseName xsi:type="xsd:string"></SoPrincipal:DatabaseName>
    <SoPrincipal:IsOnTravel xsi:type="xsd:boolean">false</SoPrincipal:IsOnTravel>
    <SoPrincipal:IsSatellite xsi:type="xsd:boolean">false</SoPrincipal:IsSatellite>
   </SoPrincipal:SystemInfo>
  </SoPrincipal:GetSystemInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

