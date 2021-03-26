---
uid: services81-license-getuserlicensesmdolist
title: Services81.LicenseAgent.GetUserLicensesMDOList SOAP
Generated: true
---

# Services81 License GetUserLicensesMDOList SOAP

SOAP request and response examples **Remote/Services81/License.svc**
Implemented by the <see cref="M:SuperOffice.Services81.ILicenseAgent.GetUserLicensesMDOList">SuperOffice.Services81.ILicenseAgent.GetUserLicensesMDOList</see> method.

## GetUserLicensesMDOList

Get all licenses in a MDOListItem structure.


**Returns:** Hierarchical structure of user licenses.


[WSDL file for Services81/License](../Services81-License.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUserLicensesMDOList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <License:ApplicationToken>1234567-1234-9876</License:ApplicationToken>
  <License:Credentials>
    <License:Ticket>7T:1234abcxyzExample==</License:Ticket>
  </License:Credentials>
 <SOAP-ENV:Body>
   <License:GetUserLicensesMDOList>
   </License:GetUserLicensesMDOList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetUserLicensesMDOList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <License:GetUserLicensesMDOListResponse>
   <License:Response xsi:type="License:ArrayOfSelectableMDOListItem">
    <License:SelectableMDOListItem xsi:type="License:SelectableMDOListItem">
     <License:Id xsi:type="xsd:int">0</License:Id>
     <License:Name xsi:type="xsd:string"></License:Name>
     <License:ToolTip xsi:type="xsd:string"></License:ToolTip>
     <License:Deleted xsi:type="xsd:boolean">false</License:Deleted>
     <License:Rank xsi:type="xsd:int">0</License:Rank>
     <License:Type xsi:type="xsd:string"></License:Type>
     <License:ColorBlock xsi:type="xsd:int">0</License:ColorBlock>
     <License:IconHint xsi:type="xsd:string"></License:IconHint>
     <License:Selected xsi:type="xsd:boolean">false</License:Selected>
     <License:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:34:30Z</License:LastChanged>
     <License:ChildItems xsi:type="License:ArrayOfSelectableMDOListItem">
      <License:SelectableMDOListItem xsi:type="License:SelectableMDOListItem">
       <License:Id xsi:type="xsd:int">0</License:Id>
       <License:Name xsi:type="xsd:string"></License:Name>
       <License:ToolTip xsi:type="xsd:string"></License:ToolTip>
       <License:Deleted xsi:type="xsd:boolean">false</License:Deleted>
       <License:Rank xsi:type="xsd:int">0</License:Rank>
       <License:Type xsi:type="xsd:string"></License:Type>
       <License:ColorBlock xsi:type="xsd:int">0</License:ColorBlock>
       <License:IconHint xsi:type="xsd:string"></License:IconHint>
       <License:Selected xsi:type="xsd:boolean">false</License:Selected>
       <License:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:34:30Z</License:LastChanged>
       <License:ChildItems xsi:type="License:ArrayOfSelectableMDOListItem">
        <License:SelectableMDOListItem xsi:type="License:SelectableMDOListItem">
         <License:Id xsi:type="xsd:int">0</License:Id>
         <License:Name xsi:type="xsd:string"></License:Name>
         <License:ToolTip xsi:type="xsd:string"></License:ToolTip>
         <License:Deleted xsi:type="xsd:boolean">false</License:Deleted>
         <License:Rank xsi:type="xsd:int">0</License:Rank>
         <License:Type xsi:type="xsd:string"></License:Type>
         <License:ColorBlock xsi:type="xsd:int">0</License:ColorBlock>
         <License:IconHint xsi:type="xsd:string"></License:IconHint>
         <License:Selected xsi:type="xsd:boolean">false</License:Selected>
         <License:LastChanged xsi:type="xsd:dateTime">2021-03-25T21:34:30Z</License:LastChanged>
         <License:ChildItems xsi:type="License:ArrayOfSelectableMDOListItem">
          <License:SelectableMDOListItem xsi:nil="true"></License:SelectableMDOListItem>
         </License:ChildItems>
         <License:ExtraInfo xsi:type="xsd:string"></License:ExtraInfo>
         <License:StyleHint xsi:type="xsd:string"></License:StyleHint>
         <License:Hidden xsi:type="xsd:boolean">false</License:Hidden>
        </License:SelectableMDOListItem>
       </License:ChildItems>
       <License:ExtraInfo xsi:type="xsd:string"></License:ExtraInfo>
       <License:StyleHint xsi:type="xsd:string"></License:StyleHint>
       <License:Hidden xsi:type="xsd:boolean">false</License:Hidden>
      </License:SelectableMDOListItem>
     </License:ChildItems>
     <License:ExtraInfo xsi:type="xsd:string"></License:ExtraInfo>
     <License:StyleHint xsi:type="xsd:string"></License:StyleHint>
     <License:Hidden xsi:type="xsd:boolean">false</License:Hidden>
    </License:SelectableMDOListItem>
   </License:Response>
  </License:GetUserLicensesMDOListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

