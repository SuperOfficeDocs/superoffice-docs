---
uid: services84-license-getlicenseforallownersfromdb
title: Services84.LicenseAgent.GetLicenseForAllOwnersFromDB SOAP
Generated: true
---

# Services84 License GetLicenseForAllOwnersFromDB SOAP

SOAP request and response examples **Remote/Services84/License.svc**
Implemented by the <see cref="M:SuperOffice.Services84.ILicenseAgent.GetLicenseForAllOwnersFromDB">SuperOffice.Services84.ILicenseAgent.GetLicenseForAllOwnersFromDB</see> method.

## GetLicenseForAllOwnersFromDB

Get all licenses, with usage, from all module owners as they are stored in the database




[WSDL file for Services84/License](../Services84-License.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetLicenseForAllOwnersFromDB Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices843="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <License:ApplicationToken>1234567-1234-9876</License:ApplicationToken>
  <License:Credentials>
    <License:Ticket>7T:1234abcxyzExample==</License:Ticket>
  </License:Credentials>
 <SOAP-ENV:Body>
   <License:GetLicenseForAllOwnersFromDB>
   </License:GetLicenseForAllOwnersFromDB>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetLicenseForAllOwnersFromDB Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices843="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <License:GetLicenseForAllOwnersFromDBResponse>
   <License:Response xsi:type="License:ArrayOfExtendedLicenseInfo">
    <License:ExtendedLicenseInfo xsi:type="License:ExtendedLicenseInfo">
     <License:Reason xsi:type="xsd:string"></License:Reason>
     <License:CanBeActivated xsi:type="xsd:boolean">false</License:CanBeActivated>
     <License:New xsi:type="License:LicenseInfo">
      <License:CompanyName xsi:type="xsd:string"></License:CompanyName>
      <License:SerialNr xsi:type="xsd:string"></License:SerialNr>
      <License:OwnerName xsi:type="xsd:string"></License:OwnerName>
      <License:OwnerDescription xsi:type="xsd:string"></License:OwnerDescription>
      <License:NextCheckDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:NextCheckDate>
      <License:MaintenanceDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:MaintenanceDate>
      <License:AdminWarningDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:AdminWarningDate>
      <License:ExpiryDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:ExpiryDate>
      <License:GraceDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:GraceDate>
      <License:ExtraFlags xsi:type="xsd:int">0</License:ExtraFlags>
      <License:LicenseUrl xsi:type="xsd:string"></License:LicenseUrl>
      <License:LicenseVersion xsi:type="xsd:string"></License:LicenseVersion>
      <License:DeploymentType xsi:type="xsd:int">0</License:DeploymentType>
      <License:ProductType xsi:type="xsd:string"></License:ProductType>
      <License:ProductDescription xsi:type="xsd:string"></License:ProductDescription>
      <License:ModuleLicenses xsi:type="License:ArrayOfModuleLicense">
       <License:ModuleLicense xsi:type="License:ModuleLicense">
        <License:OwnerName xsi:type="xsd:string"></License:OwnerName>
        <License:ModuleName xsi:type="xsd:string"></License:ModuleName>
        <License:ModuleDescription xsi:type="xsd:string"></License:ModuleDescription>
        <License:ModuleTooltip xsi:type="xsd:string"></License:ModuleTooltip>
        <License:ModuleVersion xsi:type="xsd:string"></License:ModuleVersion>
        <License:LicenseType xsi:type="License:LicenseType">Unknown</License:LicenseType>
        <License:Unrestricted xsi:type="xsd:boolean">false</License:Unrestricted>
        <License:AllowedUserType xsi:type="License:UserType">Unknown</License:AllowedUserType>
        <License:NumberOfLicenses xsi:type="xsd:int">0</License:NumberOfLicenses>
        <License:ExtraFlags xsi:type="xsd:int">0</License:ExtraFlags>
        <License:ExtraInfo xsi:type="xsd:string"></License:ExtraInfo>
        <License:SortOrder xsi:type="xsd:int">0</License:SortOrder>
        <License:IsHidden xsi:type="xsd:boolean">false</License:IsHidden>
        <License:PrerequisiteModuleName xsi:type="xsd:string"></License:PrerequisiteModuleName>
        <License:Signature xsi:type="xsd:string"></License:Signature>
       </License:ModuleLicense>
      </License:ModuleLicenses>
      <License:PublicKey xsi:type="License:SignedPublicKey">
       <License:OwnerName xsi:type="xsd:string"></License:OwnerName>
       <License:SignDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:SignDate>
       <License:ExpiryDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:ExpiryDate>
       <License:Key xsi:type="NetServerServices842:DSAParameters">
        <NetServerServices842:Counter xsi:type="xsd:int">0</NetServerServices842:Counter>
        <NetServerServices842:G xsi:type="xsd:base64Binary"></NetServerServices842:G>
        <NetServerServices842:J xsi:type="xsd:base64Binary"></NetServerServices842:J>
        <NetServerServices842:P xsi:type="xsd:base64Binary"></NetServerServices842:P>
        <NetServerServices842:Q xsi:type="xsd:base64Binary"></NetServerServices842:Q>
        <NetServerServices842:Seed xsi:type="xsd:base64Binary"></NetServerServices842:Seed>
        <NetServerServices842:Y xsi:type="xsd:base64Binary"></NetServerServices842:Y>
       </License:Key>
       <License:Signature xsi:type="xsd:string"></License:Signature>
      </License:PublicKey>
      <License:Signature xsi:type="xsd:string"></License:Signature>
     </License:New>
     <License:Current xsi:type="License:LicenseInfo">
      <License:CompanyName xsi:type="xsd:string"></License:CompanyName>
      <License:SerialNr xsi:type="xsd:string"></License:SerialNr>
      <License:OwnerName xsi:type="xsd:string"></License:OwnerName>
      <License:OwnerDescription xsi:type="xsd:string"></License:OwnerDescription>
      <License:NextCheckDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:NextCheckDate>
      <License:MaintenanceDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:MaintenanceDate>
      <License:AdminWarningDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:AdminWarningDate>
      <License:ExpiryDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:ExpiryDate>
      <License:GraceDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:GraceDate>
      <License:ExtraFlags xsi:type="xsd:int">0</License:ExtraFlags>
      <License:LicenseUrl xsi:type="xsd:string"></License:LicenseUrl>
      <License:LicenseVersion xsi:type="xsd:string"></License:LicenseVersion>
      <License:DeploymentType xsi:type="xsd:int">0</License:DeploymentType>
      <License:ProductType xsi:type="xsd:string"></License:ProductType>
      <License:ProductDescription xsi:type="xsd:string"></License:ProductDescription>
      <License:ModuleLicenses xsi:type="License:ArrayOfModuleLicense">
       <License:ModuleLicense xsi:type="License:ModuleLicense">
        <License:OwnerName xsi:type="xsd:string"></License:OwnerName>
        <License:ModuleName xsi:type="xsd:string"></License:ModuleName>
        <License:ModuleDescription xsi:type="xsd:string"></License:ModuleDescription>
        <License:ModuleTooltip xsi:type="xsd:string"></License:ModuleTooltip>
        <License:ModuleVersion xsi:type="xsd:string"></License:ModuleVersion>
        <License:LicenseType xsi:type="License:LicenseType">Unknown</License:LicenseType>
        <License:Unrestricted xsi:type="xsd:boolean">false</License:Unrestricted>
        <License:AllowedUserType xsi:type="License:UserType">Unknown</License:AllowedUserType>
        <License:NumberOfLicenses xsi:type="xsd:int">0</License:NumberOfLicenses>
        <License:ExtraFlags xsi:type="xsd:int">0</License:ExtraFlags>
        <License:ExtraInfo xsi:type="xsd:string"></License:ExtraInfo>
        <License:SortOrder xsi:type="xsd:int">0</License:SortOrder>
        <License:IsHidden xsi:type="xsd:boolean">false</License:IsHidden>
        <License:PrerequisiteModuleName xsi:type="xsd:string"></License:PrerequisiteModuleName>
        <License:Signature xsi:type="xsd:string"></License:Signature>
       </License:ModuleLicense>
      </License:ModuleLicenses>
      <License:PublicKey xsi:type="License:SignedPublicKey">
       <License:OwnerName xsi:type="xsd:string"></License:OwnerName>
       <License:SignDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:SignDate>
       <License:ExpiryDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:ExpiryDate>
       <License:Key xsi:type="NetServerServices842:DSAParameters">
        <NetServerServices842:Counter xsi:type="xsd:int">0</NetServerServices842:Counter>
        <NetServerServices842:G xsi:type="xsd:base64Binary"></NetServerServices842:G>
        <NetServerServices842:J xsi:type="xsd:base64Binary"></NetServerServices842:J>
        <NetServerServices842:P xsi:type="xsd:base64Binary"></NetServerServices842:P>
        <NetServerServices842:Q xsi:type="xsd:base64Binary"></NetServerServices842:Q>
        <NetServerServices842:Seed xsi:type="xsd:base64Binary"></NetServerServices842:Seed>
        <NetServerServices842:Y xsi:type="xsd:base64Binary"></NetServerServices842:Y>
       </License:Key>
       <License:Signature xsi:type="xsd:string"></License:Signature>
      </License:PublicKey>
      <License:Signature xsi:type="xsd:string"></License:Signature>
     </License:Current>
     <License:ExtendedModuleLicenses xsi:type="License:ArrayOfExtendedModuleLicense">
      <License:ExtendedModuleLicense xsi:type="License:ExtendedModuleLicense">
       <License:New xsi:type="License:ModuleLicense">
        <License:OwnerName xsi:type="xsd:string"></License:OwnerName>
        <License:ModuleName xsi:type="xsd:string"></License:ModuleName>
        <License:ModuleDescription xsi:type="xsd:string"></License:ModuleDescription>
        <License:ModuleTooltip xsi:type="xsd:string"></License:ModuleTooltip>
        <License:ModuleVersion xsi:type="xsd:string"></License:ModuleVersion>
        <License:LicenseType xsi:type="License:LicenseType">Unknown</License:LicenseType>
        <License:Unrestricted xsi:type="xsd:boolean">false</License:Unrestricted>
        <License:AllowedUserType xsi:type="License:UserType">Unknown</License:AllowedUserType>
        <License:NumberOfLicenses xsi:type="xsd:int">0</License:NumberOfLicenses>
        <License:ExtraFlags xsi:type="xsd:int">0</License:ExtraFlags>
        <License:ExtraInfo xsi:type="xsd:string"></License:ExtraInfo>
        <License:SortOrder xsi:type="xsd:int">0</License:SortOrder>
        <License:IsHidden xsi:type="xsd:boolean">false</License:IsHidden>
        <License:PrerequisiteModuleName xsi:type="xsd:string"></License:PrerequisiteModuleName>
        <License:Signature xsi:type="xsd:string"></License:Signature>
       </License:New>
       <License:Current xsi:type="License:ModuleLicense">
        <License:OwnerName xsi:type="xsd:string"></License:OwnerName>
        <License:ModuleName xsi:type="xsd:string"></License:ModuleName>
        <License:ModuleDescription xsi:type="xsd:string"></License:ModuleDescription>
        <License:ModuleTooltip xsi:type="xsd:string"></License:ModuleTooltip>
        <License:ModuleVersion xsi:type="xsd:string"></License:ModuleVersion>
        <License:LicenseType xsi:type="License:LicenseType">Unknown</License:LicenseType>
        <License:Unrestricted xsi:type="xsd:boolean">false</License:Unrestricted>
        <License:AllowedUserType xsi:type="License:UserType">Unknown</License:AllowedUserType>
        <License:NumberOfLicenses xsi:type="xsd:int">0</License:NumberOfLicenses>
        <License:ExtraFlags xsi:type="xsd:int">0</License:ExtraFlags>
        <License:ExtraInfo xsi:type="xsd:string"></License:ExtraInfo>
        <License:SortOrder xsi:type="xsd:int">0</License:SortOrder>
        <License:IsHidden xsi:type="xsd:boolean">false</License:IsHidden>
        <License:PrerequisiteModuleName xsi:type="xsd:string"></License:PrerequisiteModuleName>
        <License:Signature xsi:type="xsd:string"></License:Signature>
       </License:Current>
       <License:NumberOfLicensesInUse xsi:type="xsd:int">0</License:NumberOfLicensesInUse>
       <License:NumberOfLicensesFree xsi:type="xsd:int">0</License:NumberOfLicensesFree>
       <License:NumberOfLicensesAdded xsi:type="xsd:int">0</License:NumberOfLicensesAdded>
       <License:NumberOfLicensesNewTotal xsi:type="xsd:int">0</License:NumberOfLicensesNewTotal>
       <License:NumberOfLicensesNewFree xsi:type="xsd:int">0</License:NumberOfLicensesNewFree>
       <License:NumberOfLicensesTotal xsi:type="xsd:int">0</License:NumberOfLicensesTotal>
      </License:ExtendedModuleLicense>
     </License:ExtendedModuleLicenses>
     <License:AccumulatedNextCheckDate xsi:type="xsd:dateTime">2021-03-25T21:35:28Z</License:AccumulatedNextCheckDate>
    </License:ExtendedLicenseInfo>
   </License:Response>
  </License:GetLicenseForAllOwnersFromDBResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

