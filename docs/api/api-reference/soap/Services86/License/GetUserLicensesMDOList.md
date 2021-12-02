---
title: Services86.LicenseAgent.GetUserLicensesMDOList SOAP
generated: 1
uid: Services86-License-GetUserLicensesMDOList
---

# Services86 License GetUserLicensesMDOList

SOAP request and response examples **Remote/Services86/License.svc**
Implemented by the <see cref="M:SuperOffice.Services86.ILicenseAgent.GetUserLicensesMDOList">SuperOffice.Services86.ILicenseAgent.GetUserLicensesMDOList</see> method.

## GetUserLicensesMDOList

Get all licenses in a MDOListItem structure.


**Returns:** Hierarchical structure of user licenses.


[WSDL file for Services86/License](../Services86-License.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetUserLicensesMDOList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices863="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services86">
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
 xmlns:NetServerServices862="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices863="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services86">
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
     <License:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:55Z</License:LastChanged>
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
       <License:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:55Z</License:LastChanged>
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
         <License:LastChanged xsi:type="xsd:dateTime">2021-11-30T13:22:55Z</License:LastChanged>
         <License:ChildItems xsi:type="License:ArrayOfSelectableMDOListItem">
          <License:SelectableMDOListItem xsi:nil="true"></License:SelectableMDOListItem>
         </License:ChildItems>
         <License:ExtraInfo xsi:type="xsd:string"></License:ExtraInfo>
         <License:StyleHint xsi:type="xsd:string"></License:StyleHint>
         <License:Hidden xsi:type="xsd:boolean">false</License:Hidden>
         <License:FullName xsi:type="xsd:string"></License:FullName>
        </License:SelectableMDOListItem>
       </License:ChildItems>
       <License:ExtraInfo xsi:type="xsd:string"></License:ExtraInfo>
       <License:StyleHint xsi:type="xsd:string"></License:StyleHint>
       <License:Hidden xsi:type="xsd:boolean">false</License:Hidden>
       <License:FullName xsi:type="xsd:string"></License:FullName>
      </License:SelectableMDOListItem>
     </License:ChildItems>
     <License:ExtraInfo xsi:type="xsd:string"></License:ExtraInfo>
     <License:StyleHint xsi:type="xsd:string"></License:StyleHint>
     <License:Hidden xsi:type="xsd:boolean">false</License:Hidden>
     <License:FullName xsi:type="xsd:string"></License:FullName>
    </License:SelectableMDOListItem>
   </License:Response>
  </License:GetUserLicensesMDOListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

