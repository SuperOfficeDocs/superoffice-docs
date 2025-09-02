---
title: Services88.LicenseAgent.GetCentralLicense SOAP
generated: true
uid: Services88-License-GetCentralLicense
content_type: reference
---

# Services88 License GetCentralLicense

SOAP request and response examples **Remote/Services88/License.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ILicenseAgent.GetCentralLicense">SuperOffice.Services88.ILicenseAgent.GetCentralLicense</see> method.

## GetCentralLicense





[WSDL file for Services88/License](../Services88-License.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCentralLicense Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices883="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <License:ApplicationToken>1234567-1234-9876</License:ApplicationToken>
  <License:Credentials>
    <License:Ticket>7T:1234abcxyzExample==</License:Ticket>
  </License:Credentials>
 <SOAP-ENV:Body>
   <License:GetCentralLicense>
   </License:GetCentralLicense>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCentralLicense Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices883="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <License:GetCentralLicenseResponse>
   <License:Response xsi:type="License:ArrayOfLicenseOwner">
    <License:LicenseOwner xsi:type="License:LicenseOwner">
     <License:Name xsi:type="xsd:string"></License:Name>
     <License:Description xsi:type="xsd:string"></License:Description>
     <License:RestrictedModuleLicenses xsi:type="License:ArrayOfModuleLicenseLink">
      <License:ModuleLicenseLink xsi:type="License:ModuleLicenseLink">
       <License:Unrestricted xsi:type="xsd:boolean">false</License:Unrestricted>
       <License:Total xsi:type="xsd:int">0</License:Total>
       <License:Tooltip xsi:type="xsd:string"></License:Tooltip>
       <License:CanAssign xsi:type="xsd:boolean">false</License:CanAssign>
       <License:Free xsi:type="xsd:int">0</License:Free>
       <License:InUse xsi:type="xsd:int">0</License:InUse>
       <License:IsHidden xsi:type="xsd:boolean">false</License:IsHidden>
       <License:Assigned xsi:type="xsd:boolean">false</License:Assigned>
       <License:ModuleLicenseId xsi:type="xsd:int">0</License:ModuleLicenseId>
       <License:Name xsi:type="xsd:string"></License:Name>
       <License:Description xsi:type="xsd:string"></License:Description>
       <License:PrerequisiteModuleName xsi:type="xsd:string"></License:PrerequisiteModuleName>
       <License:SortOrder xsi:type="xsd:int">0</License:SortOrder>
       <License:ExtraFlags xsi:type="xsd:int">0</License:ExtraFlags>
      </License:ModuleLicenseLink>
     </License:RestrictedModuleLicenses>
     <License:UnrestrictedModuleLicenses xsi:type="License:ArrayOfModuleLicenseLink">
      <License:ModuleLicenseLink xsi:type="License:ModuleLicenseLink">
       <License:Unrestricted xsi:type="xsd:boolean">false</License:Unrestricted>
       <License:Total xsi:type="xsd:int">0</License:Total>
       <License:Tooltip xsi:type="xsd:string"></License:Tooltip>
       <License:CanAssign xsi:type="xsd:boolean">false</License:CanAssign>
       <License:Free xsi:type="xsd:int">0</License:Free>
       <License:InUse xsi:type="xsd:int">0</License:InUse>
       <License:IsHidden xsi:type="xsd:boolean">false</License:IsHidden>
       <License:Assigned xsi:type="xsd:boolean">false</License:Assigned>
       <License:ModuleLicenseId xsi:type="xsd:int">0</License:ModuleLicenseId>
       <License:Name xsi:type="xsd:string"></License:Name>
       <License:Description xsi:type="xsd:string"></License:Description>
       <License:PrerequisiteModuleName xsi:type="xsd:string"></License:PrerequisiteModuleName>
       <License:SortOrder xsi:type="xsd:int">0</License:SortOrder>
       <License:ExtraFlags xsi:type="xsd:int">0</License:ExtraFlags>
      </License:ModuleLicenseLink>
     </License:UnrestrictedModuleLicenses>
    </License:LicenseOwner>
   </License:Response>
  </License:GetCentralLicenseResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

