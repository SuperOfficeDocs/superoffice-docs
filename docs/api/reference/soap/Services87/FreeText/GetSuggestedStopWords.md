---
title: Services87.FreeTextAgent.GetSuggestedStopWords SOAP
generated: 1
uid: Services87-FreeText-GetSuggestedStopWords
---

# Services87 FreeText GetSuggestedStopWords

SOAP request and response examples **Remote/Services87/FreeText.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IFreeTextAgent.GetSuggestedStopWords">SuperOffice.Services87.IFreeTextAgent.GetSuggestedStopWords</see> method.

## GetSuggestedStopWords

Returns the top used words in the freetext index table, sorted as most used first

* **countWords:** The count of words that will be returned

**Returns:** The most used words


[WSDL file for Services87/FreeText](../Services87-FreeText.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSuggestedStopWords Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <FreeText:ApplicationToken>1234567-1234-9876</FreeText:ApplicationToken>
  <FreeText:Credentials>
    <FreeText:Ticket>7T:1234abcxyzExample==</FreeText:Ticket>
  </FreeText:Credentials>
 <SOAP-ENV:Body>
   <FreeText:GetSuggestedStopWords>
    <FreeText:CountWords xsi:type="xsd:int">0</FreeText:CountWords>
   </FreeText:GetSuggestedStopWords>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSuggestedStopWords Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <FreeText:GetSuggestedStopWordsResponse>
   <FreeText:Response xsi:type="FreeText:ArrayOfMDOListItem">
    <FreeText:MDOListItem xsi:type="FreeText:MDOListItem">
     <FreeText:Id xsi:type="xsd:int">0</FreeText:Id>
     <FreeText:Name xsi:type="xsd:string"></FreeText:Name>
     <FreeText:ToolTip xsi:type="xsd:string"></FreeText:ToolTip>
     <FreeText:Deleted xsi:type="xsd:boolean">false</FreeText:Deleted>
     <FreeText:Rank xsi:type="xsd:int">0</FreeText:Rank>
     <FreeText:Type xsi:type="xsd:string"></FreeText:Type>
     <FreeText:ChildItems xsi:type="FreeText:ArrayOfMDOListItem">
      <FreeText:MDOListItem xsi:type="FreeText:MDOListItem">
       <FreeText:Id xsi:type="xsd:int">0</FreeText:Id>
       <FreeText:Name xsi:type="xsd:string"></FreeText:Name>
       <FreeText:ToolTip xsi:type="xsd:string"></FreeText:ToolTip>
       <FreeText:Deleted xsi:type="xsd:boolean">false</FreeText:Deleted>
       <FreeText:Rank xsi:type="xsd:int">0</FreeText:Rank>
       <FreeText:Type xsi:type="xsd:string"></FreeText:Type>
       <FreeText:ChildItems xsi:type="FreeText:ArrayOfMDOListItem">
        <FreeText:MDOListItem xsi:type="FreeText:MDOListItem">
         <FreeText:Id xsi:type="xsd:int">0</FreeText:Id>
         <FreeText:Name xsi:type="xsd:string"></FreeText:Name>
         <FreeText:ToolTip xsi:type="xsd:string"></FreeText:ToolTip>
         <FreeText:Deleted xsi:type="xsd:boolean">false</FreeText:Deleted>
         <FreeText:Rank xsi:type="xsd:int">0</FreeText:Rank>
         <FreeText:Type xsi:type="xsd:string"></FreeText:Type>
         <FreeText:ChildItems xsi:type="FreeText:ArrayOfMDOListItem">
          <FreeText:MDOListItem xsi:nil="true"></FreeText:MDOListItem>
         </FreeText:ChildItems>
         <FreeText:IconHint xsi:type="xsd:string"></FreeText:IconHint>
         <FreeText:ColorBlock xsi:type="xsd:int">0</FreeText:ColorBlock>
         <FreeText:ExtraInfo xsi:type="xsd:string"></FreeText:ExtraInfo>
         <FreeText:StyleHint xsi:type="xsd:string"></FreeText:StyleHint>
         <FreeText:FullName xsi:type="xsd:string"></FreeText:FullName>
        </FreeText:MDOListItem>
       </FreeText:ChildItems>
       <FreeText:IconHint xsi:type="xsd:string"></FreeText:IconHint>
       <FreeText:ColorBlock xsi:type="xsd:int">0</FreeText:ColorBlock>
       <FreeText:ExtraInfo xsi:type="xsd:string"></FreeText:ExtraInfo>
       <FreeText:StyleHint xsi:type="xsd:string"></FreeText:StyleHint>
       <FreeText:FullName xsi:type="xsd:string"></FreeText:FullName>
      </FreeText:MDOListItem>
     </FreeText:ChildItems>
     <FreeText:IconHint xsi:type="xsd:string"></FreeText:IconHint>
     <FreeText:ColorBlock xsi:type="xsd:int">0</FreeText:ColorBlock>
     <FreeText:ExtraInfo xsi:type="xsd:string"></FreeText:ExtraInfo>
     <FreeText:StyleHint xsi:type="xsd:string"></FreeText:StyleHint>
     <FreeText:FullName xsi:type="xsd:string"></FreeText:FullName>
    </FreeText:MDOListItem>
   </FreeText:Response>
  </FreeText:GetSuggestedStopWordsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

