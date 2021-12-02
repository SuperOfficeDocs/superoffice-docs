---
title: Services88.UserAgent.ResolveUserFromInfo SOAP
generated: 1
uid: Services88-User-ResolveUserFromInfo
---

# Services88 User ResolveUserFromInfo

SOAP request and response examples **Remote/Services88/User.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IUserAgent.ResolveUserFromInfo">SuperOffice.Services88.IUserAgent.ResolveUserFromInfo</see> method.

## ResolveUserFromInfo

Get a user from the provided information. If the user or associated person does not exist, it will be created on demand.
<para /><b>Online Restricted:</b> The User agent is not available in Online by default. User management is not allowed for partner apps.

* **contactId:** The contact Id of the contact which the person belongs to. Cannot be 0.
* **personName:** The full name of the person to be resolved. Optional.
* **phoneNumbers:** Phone numbers registered on the person. Optional.
* **emails:** Email-addresses registered on the person. Optional.
* **userType:** The type of user to look up or create.
* **credential:** The credentials to be used for the user. Required.

**Returns:** The results of the resolve-operation.


[WSDL file for Services88/User](../Services88-User.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ResolveUserFromInfo Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <User:ApplicationToken>1234567-1234-9876</User:ApplicationToken>
  <User:Credentials>
    <User:Ticket>7T:1234abcxyzExample==</User:Ticket>
  </User:Credentials>
 <SOAP-ENV:Body>
   <User:ResolveUserFromInfo>
    <User:ContactId xsi:type="xsd:int">0</User:ContactId>
    <User:PersonName xsi:type="xsd:string"></User:PersonName>
    <User:PhoneNumbers xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </User:PhoneNumbers>
    <User:Emails xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </User:Emails>
    <User:UserType xsi:type="User:UserType">Unknown</User:UserType>
    <User:Credential xsi:type="User:Credential">
     <User:Type xsi:type="User:CredentialType">
      <User:DisplayType xsi:type="xsd:string"></User:DisplayType>
      <User:Type xsi:type="xsd:string"></User:Type>
      <User:Description xsi:type="xsd:string"></User:Description>
      <User:ValueControl xsi:type="User:CredentialControlType">Static</User:ValueControl>
      <User:CanCreatePerson xsi:type="xsd:boolean">false</User:CanCreatePerson>
      <User:IsUserNameSupported xsi:type="xsd:boolean">false</User:IsUserNameSupported>
     </User:Type>
     <User:Value xsi:type="xsd:string"></User:Value>
     <User:DisplayValue xsi:type="xsd:string"></User:DisplayValue>
    </User:Credential>
   </User:ResolveUserFromInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ResolveUserFromInfo Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:User="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <User:ResolveUserFromInfoResponse>
   <User:Response xsi:type="User:ResolvedUser">
    <User:User xsi:type="User:User">
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
         <User:IsHidden xsi:type="xsd:boolean">false</User:IsHidden>
         <User:Assigned xsi:type="xsd:boolean">false</User:Assigned>
         <User:ModuleLicenseId xsi:type="xsd:int">0</User:ModuleLicenseId>
         <User:Name xsi:type="xsd:string"></User:Name>
         <User:Description xsi:type="xsd:string"></User:Description>
         <User:PrerequisiteModuleName xsi:type="xsd:string"></User:PrerequisiteModuleName>
         <User:SortOrder xsi:type="xsd:int">0</User:SortOrder>
         <User:ExtraFlags xsi:type="xsd:int">0</User:ExtraFlags>
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
         <User:IsHidden xsi:type="xsd:boolean">false</User:IsHidden>
         <User:Assigned xsi:type="xsd:boolean">false</User:Assigned>
         <User:ModuleLicenseId xsi:type="xsd:int">0</User:ModuleLicenseId>
         <User:Name xsi:type="xsd:string"></User:Name>
         <User:Description xsi:type="xsd:string"></User:Description>
         <User:PrerequisiteModuleName xsi:type="xsd:string"></User:PrerequisiteModuleName>
         <User:SortOrder xsi:type="xsd:int">0</User:SortOrder>
         <User:ExtraFlags xsi:type="xsd:int">0</User:ExtraFlags>
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
      <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
     </User:UserGroup>
     <User:OtherGroups xsi:type="User:ArrayOfUserGroup">
      <User:UserGroup xsi:type="User:UserGroup">
       <User:Value xsi:type="xsd:string"></User:Value>
       <User:Tooltip xsi:type="xsd:string"></User:Tooltip>
       <User:Id xsi:type="xsd:int">0</User:Id>
       <User:Rank xsi:type="xsd:short">0</User:Rank>
       <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
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
      <User:TicketPriorityId xsi:type="xsd:int">0</User:TicketPriorityId>
      <User:SupportLanguageId xsi:type="xsd:int">0</User:SupportLanguageId>
      <User:SupportAssociateId xsi:type="xsd:int">0</User:SupportAssociateId>
      <User:CategoryName xsi:type="xsd:string"></User:CategoryName>
     </User:Person>
     <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
     <User:Lastlogin xsi:type="xsd:dateTime">2021-11-30T13:23:54Z</User:Lastlogin>
     <User:Lastlogout xsi:type="xsd:dateTime">2021-11-30T13:23:54Z</User:Lastlogout>
     <User:EjUserId xsi:type="xsd:int">0</User:EjUserId>
     <User:RequestSignature xsi:type="xsd:string"></User:RequestSignature>
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
        <User:IsUserNameSupported xsi:type="xsd:boolean">false</User:IsUserNameSupported>
       </User:Type>
       <User:Value xsi:type="xsd:string"></User:Value>
       <User:DisplayValue xsi:type="xsd:string"></User:DisplayValue>
      </User:Credential>
     </User:Credentials>
     <User:UserName xsi:type="xsd:string"></User:UserName>
     <User:TicketCategories xsi:type="User:ArrayOfMDOListItem">
      <User:MDOListItem xsi:type="User:MDOListItem">
       <User:Id xsi:type="xsd:int">0</User:Id>
       <User:Name xsi:type="xsd:string"></User:Name>
       <User:ToolTip xsi:type="xsd:string"></User:ToolTip>
       <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
       <User:Rank xsi:type="xsd:int">0</User:Rank>
       <User:Type xsi:type="xsd:string"></User:Type>
       <User:ChildItems xsi:type="User:ArrayOfMDOListItem">
        <User:MDOListItem xsi:type="User:MDOListItem">
         <User:Id xsi:type="xsd:int">0</User:Id>
         <User:Name xsi:type="xsd:string"></User:Name>
         <User:ToolTip xsi:type="xsd:string"></User:ToolTip>
         <User:Deleted xsi:type="xsd:boolean">false</User:Deleted>
         <User:Rank xsi:type="xsd:int">0</User:Rank>
         <User:Type xsi:type="xsd:string"></User:Type>
         <User:ChildItems xsi:type="User:ArrayOfMDOListItem">
          <User:MDOListItem xsi:nil="true"></User:MDOListItem>
         </User:ChildItems>
         <User:IconHint xsi:type="xsd:string"></User:IconHint>
         <User:ColorBlock xsi:type="xsd:int">0</User:ColorBlock>
         <User:ExtraInfo xsi:type="xsd:string"></User:ExtraInfo>
         <User:StyleHint xsi:type="xsd:string"></User:StyleHint>
         <User:FullName xsi:type="xsd:string"></User:FullName>
        </User:MDOListItem>
       </User:ChildItems>
       <User:IconHint xsi:type="xsd:string"></User:IconHint>
       <User:ColorBlock xsi:type="xsd:int">0</User:ColorBlock>
       <User:ExtraInfo xsi:type="xsd:string"></User:ExtraInfo>
       <User:StyleHint xsi:type="xsd:string"></User:StyleHint>
       <User:FullName xsi:type="xsd:string"></User:FullName>
      </User:MDOListItem>
     </User:TicketCategories>
     <User:NickName xsi:type="xsd:string"></User:NickName>
     <User:WaitingForApproval xsi:type="xsd:boolean">false</User:WaitingForApproval>
     <User:ExtraFields xsi:type="User:StringDictionary">
      <User:StringKeyValuePair>
       <User:Key xsi:type="xsd:string"></User:Key>
       <User:Value xsi:type="xsd:string"></User:Value>
      </User:StringKeyValuePair>
     </User:ExtraFields>
     <User:CustomFields xsi:type="User:StringDictionary">
      <User:StringKeyValuePair>
       <User:Key xsi:type="xsd:string"></User:Key>
       <User:Value xsi:type="xsd:string"></User:Value>
      </User:StringKeyValuePair>
     </User:CustomFields>
     <User:PostSaveCommands xsi:type="User:ArrayOfCustomCommand">
      <User:CustomCommand xsi:type="User:CustomCommand">
       <User:Name xsi:type="xsd:string"></User:Name>
       <User:DisplayName xsi:type="xsd:string"></User:DisplayName>
       <User:Description xsi:type="xsd:string"></User:Description>
       <User:ToolTip xsi:type="xsd:string"></User:ToolTip>
       <User:Actions xsi:type="User:CommandAction">Implicit</User:Actions>
       <User:ActionData xsi:type="xsd:string"></User:ActionData>
      </User:CustomCommand>
     </User:PostSaveCommands>
    </User:User>
    <User:PersonCreated xsi:type="xsd:boolean">false</User:PersonCreated>
   </User:Response>
  </User:ResolveUserFromInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

