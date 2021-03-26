---
uid: services81-user-createdefaultuserfromusertype
title: Services81.UserAgent.CreateDefaultUserFromUserType SOAP
Generated: true
---

# Services81 User CreateDefaultUserFromUserType SOAP

SOAP request and response examples **Remote/Services81/User.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IUserAgent.CreateDefaultUserFromUserType">SuperOffice.Services81.IUserAgent.CreateDefaultUserFromUserType</see> method.

## CreateDefaultUserFromUserType

Create default User providing the user type.  Only System and Anonymous users can be created without an exsisting person.  Use CreateDefaultUserFromUserTypeAndPersonId to create internal (i.e. Employee) or external users.

* **userType:** Type of associate for the user.  This can only be System or Anonymous. Use CreateDefaultUserFromUserTypeAndPersonId to create internal (i.e. Employee) or external users.

**Returns:** New user object with defalt values set.


[WSDL file for Services81/User](../Services81-User.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultUserFromUserType Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:CreateDefaultUserFromUserType>
    <User:UserType xsi:type="User:UserType">Unknown</User:UserType>
   </User:CreateDefaultUserFromUserType>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultUserFromUserType Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <User:CreateDefaultUserFromUserTypeResponse>
   <User:Response xsi:type="User:User">
    <User:AssociateId xsi:type="xsd:int">0</User:AssociateId>
    <User:Name xsi:type="xsd:string"></User:Name>
    <User:Rank xsi:type="xsd:short">0</User:Rank>
    <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
    <User:LicenseOwners xsi:type="User:ArrayOfLicenseOwner">
     <User:LicenseOwner xsi:type="User:LicenseOwner">
      <User:Name xsi:type="xsd:string"></User:Name>
      <User:Description xsi:type="xsd:string"></User:Description>
      <User:RestrictedModuleLicenses xsi:type="User:ArrayOfModuleLicenseLink">
       <User:ModuleLicenseLink xsi:type="User:ModuleLicenseLink">
        <User:Unrestricted xsi:type="xsd:boolean">false</User:Unrestricted>
        <User:Total xsi:type="xsd:int">0</User:Total>
        <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
        <User:CanAssign xsi:type="xsd:boolean">false</User:CanAssign>
        <User:Free xsi:type="xsd:int">0</User:Free>
        <User:InUse xsi:type="xsd:int">0</User:InUse>
        <User:Assigned xsi:type="xsd:boolean">false</User:Assigned>
        <User:ModuleLicenseId xsi:type="xsd:int">0</User:ModuleLicenseId>
        <User:Name xsi:type="xsd:string"></User:Name>
        <User:Description xsi:type="xsd:string"></User:Description>
        <User:PrerequisiteModuleName xsi:type="xsd:string"></User:PrerequisiteModuleName>
        <User:SortOrder xsi:type="xsd:int">0</User:SortOrder>
       </User:ModuleLicenseLink>
      </User:RestrictedModuleLicenses>
      <User:UnrestrictedModuleLicenses xsi:type="User:ArrayOfModuleLicenseLink">
       <User:ModuleLicenseLink xsi:type="User:ModuleLicenseLink">
        <User:Unrestricted xsi:type="xsd:boolean">false</User:Unrestricted>
        <User:Total xsi:type="xsd:int">0</User:Total>
        <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
        <User:CanAssign xsi:type="xsd:boolean">false</User:CanAssign>
        <User:Free xsi:type="xsd:int">0</User:Free>
        <User:InUse xsi:type="xsd:int">0</User:InUse>
        <User:Assigned xsi:type="xsd:boolean">false</User:Assigned>
        <User:ModuleLicenseId xsi:type="xsd:int">0</User:ModuleLicenseId>
        <User:Name xsi:type="xsd:string"></User:Name>
        <User:Description xsi:type="xsd:string"></User:Description>
        <User:PrerequisiteModuleName xsi:type="xsd:string"></User:PrerequisiteModuleName>
        <User:SortOrder xsi:type="xsd:int">0</User:SortOrder>
       </User:ModuleLicenseLink>
      </User:UnrestrictedModuleLicenses>
     </User:LicenseOwner>
    </User:LicenseOwners>
    <User:Role xsi:type="User:Role">
     <User:Id xsi:type="xsd:int">0</User:Id>
     <User:Value xsi:type="xsd:string"></User:Value>
     <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
    </User:Role>
    <User:UserGroup xsi:type="User:UserGroup">
     <User:Value xsi:type="xsd:string"></User:Value>
     <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
     <User:Id xsi:type="xsd:int">0</User:Id>
     <User:Rank xsi:type="xsd:short">0</User:Rank>
     <User:Deleted xsi:type="xsd:short">0</User:Deleted>
    </User:UserGroup>
    <User:OtherGroups xsi:type="User:ArrayOfUserGroup">
     <User:UserGroup xsi:type="User:UserGroup">
      <User:Value xsi:type="xsd:string"></User:Value>
      <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
      <User:Id xsi:type="xsd:int">0</User:Id>
      <User:Rank xsi:type="xsd:short">0</User:Rank>
      <User:Deleted xsi:type="xsd:short">0</User:Deleted>
     </User:UserGroup>
    </User:OtherGroups>
    <User:Person xsi:type="User:Person">
     <User:Position xsi:type="xsd:string"></User:Position>
     <User:PersonId xsi:type="xsd:int">0</User:PersonId>
     <User:Mrmrs xsi:type="xsd:string"></User:Mrmrs>
     <User:Firstname xsi:type="xsd:string"></User:Firstname>
     <User:Lastname xsi:type="xsd:string"></User:Lastname>
     <User:MiddleName xsi:type="xsd:string"></User:MiddleName>
     <User:Title xsi:type="xsd:string"></User:Title>
     <User:Description xsi:type="xsd:string"></User:Description>
     <User:Email xsi:type="xsd:string"></User:Email>
     <User:FullName xsi:type="xsd:string"></User:FullName>
     <User:DirectPhone xsi:type="xsd:string"></User:DirectPhone>
     <User:FormalName xsi:type="xsd:string"></User:FormalName>
     <User:CountryId xsi:type="xsd:int">0</User:CountryId>
     <User:ContactId xsi:type="xsd:int">0</User:ContactId>
     <User:ContactName xsi:type="xsd:string"></User:ContactName>
     <User:Retired xsi:type="xsd:short">0</User:Retired>
     <User:Rank xsi:type="xsd:short">0</User:Rank>
     <User:ActiveInterests xsi:type="xsd:short">0</User:ActiveInterests>
     <User:ContactDepartment xsi:type="xsd:string"></User:ContactDepartment>
     <User:ContactCountryId xsi:type="xsd:int">0</User:ContactCountryId>
     <User:ContactOrgNr xsi:type="xsd:string"></User:ContactOrgNr>
     <User:FaxPhone xsi:type="xsd:string"></User:FaxPhone>
     <User:MobilePhone xsi:type="xsd:string"></User:MobilePhone>
     <User:ContactPhone xsi:type="xsd:string"></User:ContactPhone>
     <User:AssociateName xsi:type="xsd:string"></User:AssociateName>
     <User:AssociateId xsi:type="xsd:int">0</User:AssociateId>
     <User:UsePersonAddress xsi:type="xsd:boolean">false</User:UsePersonAddress>
     <User:ContactFax xsi:type="xsd:string"></User:ContactFax>
     <User:Kanafname xsi:type="xsd:string"></User:Kanafname>
     <User:Kanalname xsi:type="xsd:string"></User:Kanalname>
     <User:Post1 xsi:type="xsd:string"></User:Post1>
     <User:Post2 xsi:type="xsd:string"></User:Post2>
     <User:Post3 xsi:type="xsd:string"></User:Post3>
     <User:EmailName xsi:type="xsd:string"></User:EmailName>
     <User:ContactFullName xsi:type="xsd:string"></User:ContactFullName>
     <User:ActiveErpLinks xsi:type="xsd:int">0</User:ActiveErpLinks>
    </User:Person>
    <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
    <User:Lastlogin xsi:type="xsd:dateTime">2021-03-25T21:34:39Z</User:Lastlogin>
    <User:Lastlogout xsi:type="xsd:dateTime">2021-03-25T21:34:39Z</User:Lastlogout>
    <User:EjUserId xsi:type="xsd:int">0</User:EjUserId>
    <User:Type xsi:type="User:UserType">Unknown</User:Type>
    <User:IsPersonRetired xsi:type="xsd:boolean">false</User:IsPersonRetired>
    <User:IsOnTravel xsi:type="xsd:boolean">false</User:IsOnTravel>
    <User:Credentials xsi:type="User:ArrayOfCredential">
     <User:Credential xsi:type="User:Credential">
      <User:Type xsi:type="User:CredentialType">
       <User:DisplayType xsi:type="xsd:string"></User:DisplayType>
       <User:Type xsi:type="xsd:string"></User:Type>
       <User:Description xsi:type="xsd:string"></User:Description>
       <User:ValueControl xsi:type="User:CredentialControlType">Static</User:ValueControl>
       <User:CanCreatePerson xsi:type="xsd:boolean">false</User:CanCreatePerson>
      </User:Type>
      <User:Value xsi:type="xsd:string"></User:Value>
      <User:DisplayValue xsi:type="xsd:string"></User:DisplayValue>
     </User:Credential>
    </User:Credentials>
   </User:Response>
  </User:CreateDefaultUserFromUserTypeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

