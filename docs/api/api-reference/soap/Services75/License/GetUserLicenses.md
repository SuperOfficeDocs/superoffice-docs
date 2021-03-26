---
uid: services75-license-getuserlicenses
title: Services75.LicenseAgent.GetUserLicenses SOAP
Generated: true
---

# Services75 License GetUserLicenses SOAP

SOAP request and response examples **Remote/Services75/License.svc**
Implemented by the <see cref="M:SuperOffice.Services75.ILicenseAgent.GetUserLicenses">SuperOffice.Services75.ILicenseAgent.GetUserLicenses</see> method.

## GetUserLicenses

Obtain information about associate module licenses

* **associateId:** Associate id to check for associate module licenses

**Returns:** Associate module licenses grouped by owners.


[WSDL file for Services75/License](../Services75-License.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUserLicenses Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <License:ApplicationToken>1234567-1234-9876</License:ApplicationToken>
  <License:Credentials>
    <License:Ticket>7T:1234abcxyzExample==</License:Ticket>
  </License:Credentials>
 <SOAP-ENV:Body>
   <License:GetUserLicenses>
    <License:AssociateId xsi:type="xsd:int">0</License:AssociateId>
   </License:GetUserLicenses>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUserLicenses Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <License:GetUserLicensesResponse>
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
       <License:Assigned xsi:type="xsd:boolean">false</License:Assigned>
       <License:ModuleLicenseId xsi:type="xsd:int">0</License:ModuleLicenseId>
       <License:Name xsi:type="xsd:string"></License:Name>
       <License:Description xsi:type="xsd:string"></License:Description>
       <License:PrerequisiteModuleName xsi:type="xsd:string"></License:PrerequisiteModuleName>
       <License:SortOrder xsi:type="xsd:int">0</License:SortOrder>
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
       <License:Assigned xsi:type="xsd:boolean">false</License:Assigned>
       <License:ModuleLicenseId xsi:type="xsd:int">0</License:ModuleLicenseId>
       <License:Name xsi:type="xsd:string"></License:Name>
       <License:Description xsi:type="xsd:string"></License:Description>
       <License:PrerequisiteModuleName xsi:type="xsd:string"></License:PrerequisiteModuleName>
       <License:SortOrder xsi:type="xsd:int">0</License:SortOrder>
      </License:ModuleLicenseLink>
     </License:UnrestrictedModuleLicenses>
    </License:LicenseOwner>
   </License:Response>
  </License:GetUserLicensesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

