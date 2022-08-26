---
title: Services88.LicenseAgent.GetModuleLicenseFromDB SOAP
generated: 1
uid: Services88-License-GetModuleLicenseFromDB
---

# Services88 License GetModuleLicenseFromDB

SOAP request and response examples **Remote/Services88/License.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ILicenseAgent.GetModuleLicenseFromDB">SuperOffice.Services88.ILicenseAgent.GetModuleLicenseFromDB</see> method.

## GetModuleLicenseFromDB

Get license information for one particular license module.

* **ownerName:** Name of the module owner.
* **moduleName:** Name of the license module.

**Returns:** Module License details, as it is stored in the database. NULL if not found.


[WSDL file for Services88/License](../Services88-License.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetModuleLicenseFromDB Request

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
   <License:GetModuleLicenseFromDB>
    <License:OwnerName xsi:type="xsd:string"></License:OwnerName>
    <License:ModuleName xsi:type="xsd:string"></License:ModuleName>
   </License:GetModuleLicenseFromDB>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetModuleLicenseFromDB Response

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
  <License:GetModuleLicenseFromDBResponse>
   <License:Response xsi:type="License:ModuleLicense">
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
   </License:Response>
  </License:GetModuleLicenseFromDBResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

