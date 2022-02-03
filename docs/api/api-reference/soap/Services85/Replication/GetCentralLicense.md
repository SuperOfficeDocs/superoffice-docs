---
title: Services85.ReplicationAgent.GetCentralLicense SOAP
generated: 1
uid: Services85-Replication-GetCentralLicense
---

# Services85 Replication GetCentralLicense

SOAP request and response examples **Remote/Services85/Replication.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IReplicationAgent.GetCentralLicense">SuperOffice.Services85.IReplicationAgent.GetCentralLicense</see> method.

## GetCentralLicense






[WSDL file for Services85/Replication](../Services85-Replication.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCentralLicense Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Replication="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Replication:ApplicationToken>1234567-1234-9876</Replication:ApplicationToken>
  <Replication:Credentials>
    <Replication:Ticket>7T:1234abcxyzExample==</Replication:Ticket>
  </Replication:Credentials>
 <SOAP-ENV:Body>
   <Replication:GetCentralLicense>
   </Replication:GetCentralLicense>

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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Replication="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Replication:GetCentralLicenseResponse>
   <Replication:Response xsi:type="Replication:ArrayOfLicenseOwner">
    <Replication:LicenseOwner xsi:type="Replication:LicenseOwner">
     <Replication:Name xsi:type="xsd:string"></Replication:Name>
     <Replication:Description xsi:type="xsd:string"></Replication:Description>
     <Replication:RestrictedModuleLicenses xsi:type="Replication:ArrayOfModuleLicenseLink">
      <Replication:ModuleLicenseLink xsi:type="Replication:ModuleLicenseLink">
       <Replication:Unrestricted xsi:type="xsd:boolean">false</Replication:Unrestricted>
       <Replication:Total xsi:type="xsd:int">0</Replication:Total>
       <Replication:Tooltip xsi:type="xsd:string"></Replication:Tooltip>
       <Replication:CanAssign xsi:type="xsd:boolean">false</Replication:CanAssign>
       <Replication:Free xsi:type="xsd:int">0</Replication:Free>
       <Replication:InUse xsi:type="xsd:int">0</Replication:InUse>
       <Replication:Assigned xsi:type="xsd:boolean">false</Replication:Assigned>
       <Replication:ModuleLicenseId xsi:type="xsd:int">0</Replication:ModuleLicenseId>
       <Replication:Name xsi:type="xsd:string"></Replication:Name>
       <Replication:Description xsi:type="xsd:string"></Replication:Description>
       <Replication:PrerequisiteModuleName xsi:type="xsd:string"></Replication:PrerequisiteModuleName>
       <Replication:SortOrder xsi:type="xsd:int">0</Replication:SortOrder>
      </Replication:ModuleLicenseLink>
     </Replication:RestrictedModuleLicenses>
     <Replication:UnrestrictedModuleLicenses xsi:type="Replication:ArrayOfModuleLicenseLink">
      <Replication:ModuleLicenseLink xsi:type="Replication:ModuleLicenseLink">
       <Replication:Unrestricted xsi:type="xsd:boolean">false</Replication:Unrestricted>
       <Replication:Total xsi:type="xsd:int">0</Replication:Total>
       <Replication:Tooltip xsi:type="xsd:string"></Replication:Tooltip>
       <Replication:CanAssign xsi:type="xsd:boolean">false</Replication:CanAssign>
       <Replication:Free xsi:type="xsd:int">0</Replication:Free>
       <Replication:InUse xsi:type="xsd:int">0</Replication:InUse>
       <Replication:Assigned xsi:type="xsd:boolean">false</Replication:Assigned>
       <Replication:ModuleLicenseId xsi:type="xsd:int">0</Replication:ModuleLicenseId>
       <Replication:Name xsi:type="xsd:string"></Replication:Name>
       <Replication:Description xsi:type="xsd:string"></Replication:Description>
       <Replication:PrerequisiteModuleName xsi:type="xsd:string"></Replication:PrerequisiteModuleName>
       <Replication:SortOrder xsi:type="xsd:int">0</Replication:SortOrder>
      </Replication:ModuleLicenseLink>
     </Replication:UnrestrictedModuleLicenses>
    </Replication:LicenseOwner>
   </Replication:Response>
  </Replication:GetCentralLicenseResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

