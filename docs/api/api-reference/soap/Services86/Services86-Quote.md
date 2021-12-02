---
generated: 1
uid: wsdl-Services86-Quote
title: Services86.QuoteAgent WSDL
---

# Services86.QuoteAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfQuoteService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services86" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="UpdateQuoteVersionPrices">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ApplicationToken" nillable="true" type="xs:string" />
      <xs:complexType name="SoCredentials">
        <xs:sequence>
          <xs:element minOccurs="0" name="Ticket" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoCredentials" nillable="true" type="tns:SoCredentials" />
      <xs:element name="Credentials" nillable="true" type="tns:SoCredentials" />
      <xs:complexType name="SoTimeZone">
        <xs:sequence>
          <xs:element minOccurs="0" name="SoTimeZoneId" type="xs:int" />
          <xs:element minOccurs="0" name="SoTimeZoneLocationCode" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoTimeZone" nillable="true" type="tns:SoTimeZone" />
      <xs:element name="TimeZone" nillable="true" type="tns:SoTimeZone" />
      <xs:element name="UpdateQuoteVersionPricesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteVersionValidated" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="QuoteVersionValidated">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="IsOk" type="xs:boolean" />
              <xs:element minOccurs="0" name="UserExplanation" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TechExplanation" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ErrorCode" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ChangedSale" nillable="true" type="tns:Sale" />
              <xs:element minOccurs="0" name="ChangedQuote" nillable="true" type="tns:Quote" />
              <xs:element minOccurs="0" name="ChangedQuoteVersion" nillable="true" type="tns:QuoteVersion" />
              <xs:element minOccurs="0" name="ChangedQuoteAlternatives" nillable="true" type="tns:ArrayOfQuoteAlternativeRecalculated" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuoteVersionValidated" nillable="true" type="tns:QuoteVersionValidated" />
      <xs:complexType name="Carrier">
        <xs:sequence>
          <xs:element minOccurs="0" name="TableRight" nillable="true" type="tns:TableRight" />
          <xs:element minOccurs="0" name="FieldProperties" nillable="true" type="tns:FieldPropertyDictionary" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="Carrier" nillable="true" type="tns:Carrier" />
      <xs:complexType name="TableRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="tns:ETableRight" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="TableRight" nillable="true" type="tns:TableRight" />
      <xs:simpleType name="ETableRight">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Select" />
              <xs:enumeration value="Update" />
              <xs:enumeration value="Insert" />
              <xs:enumeration value="Delete" />
              <xs:enumeration value="Filtering" />
              <xs:enumeration value="RestrictedUpdate" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="ETableRight" nillable="true" type="tns:ETableRight" />
      <xs:complexType name="FieldPropertyDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="FieldPropertyDictionaryKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="tns:FieldProperty" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldPropertyDictionary" nillable="true" type="tns:FieldPropertyDictionary" />
      <xs:complexType name="FieldProperty">
        <xs:sequence>
          <xs:element minOccurs="0" name="FieldRight" nillable="true" type="tns:FieldRight" />
          <xs:element minOccurs="0" name="FieldType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FieldLength" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldProperty" nillable="true" type="tns:FieldProperty" />
      <xs:complexType name="FieldRight">
        <xs:sequence>
          <xs:element minOccurs="0" name="Mask" type="tns:EFieldRight" />
          <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldRight" nillable="true" type="tns:FieldRight" />
      <xs:simpleType name="EFieldRight">
        <xs:list>
          <xs:simpleType>
            <xs:restriction base="xs:string">
              <xs:enumeration value="Read" />
              <xs:enumeration value="Write" />
              <xs:enumeration value="Unused1" />
              <xs:enumeration value="Unused2" />
              <xs:enumeration value="Unused3" />
              <xs:enumeration value="Unused4" />
              <xs:enumeration value="UIHintMandatory" />
              <xs:enumeration value="UIHintReadOnly" />
              <xs:enumeration value="UndefinedValue256" />
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="EFieldRight" nillable="true" type="tns:EFieldRight" />
      <xs:complexType name="Sale">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ContactName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SaleDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="Probability" type="xs:short" />
              <xs:element minOccurs="0" name="Title" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Amount" type="xs:double" />
              <xs:element minOccurs="0" name="Currency" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProjectName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="AssociateFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Status" type="tns:SaleStatus" />
              <xs:element minOccurs="0" name="WeightedAmount" type="xs:double" />
              <xs:element minOccurs="0" name="ProjectId" type="xs:int" />
              <xs:element minOccurs="0" name="EarningPercent" type="xs:double" />
              <xs:element minOccurs="0" name="Earning" type="xs:double" />
              <xs:element minOccurs="0" name="ContactId" type="xs:int" />
              <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="PersonId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleTypeId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleTypeName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PersonFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Completed" type="tns:ActivityStatus" />
              <xs:element minOccurs="0" name="ActiveErpLinks" type="xs:int" />
              <xs:element minOccurs="0" name="NextDueDate" type="xs:dateTime" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Sale" nillable="true" type="tns:Sale" />
      <xs:simpleType name="SaleStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Open" />
          <xs:enumeration value="Sold" />
          <xs:enumeration value="Lost" />
          <xs:enumeration value="Stalled" />
          <xs:enumeration value="SaintAll">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1000</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="SaleStatus" nillable="true" type="tns:SaleStatus" />
      <xs:simpleType name="ActivityStatus">
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="NotStarted" />
          <xs:enumeration value="Started" />
          <xs:enumeration value="Completed" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ActivityStatus" nillable="true" type="tns:ActivityStatus" />
      <xs:complexType name="Quote">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="QuoteId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
              <xs:element minOccurs="0" name="ERPQuoteKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ERPOrderKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ActiveQuoteVersionId" type="xs:int" />
              <xs:element minOccurs="0" name="AcceptedQuoteAlternativeId" type="xs:int" />
              <xs:element minOccurs="0" name="UseValuesFromQuote" type="xs:short" />
              <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
              <xs:element minOccurs="0" name="PoNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OrderComment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PreferredEmailCulture" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ActiveQuoteVersion" nillable="true" type="tns:QuoteVersion" />
              <xs:element minOccurs="0" name="FavoriteQuoteAlternative" nillable="true" type="tns:QuoteAlternative" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Quote" nillable="true" type="tns:Quote" />
      <xs:complexType name="QuoteVersion">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
              <xs:element minOccurs="0" name="ERPQuoteVersionKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="QuoteId" type="xs:int" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Number" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="State" type="tns:QuoteVersionState" />
              <xs:element minOccurs="0" name="ArchivedState" type="tns:QuoteVersionState" />
              <xs:element minOccurs="0" name="Status" type="tns:QuoteStatus" />
              <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="LikelyQuoteAlternativeId" type="xs:int" />
              <xs:element minOccurs="0" name="SentDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="FollowupId" type="xs:int" />
              <xs:element minOccurs="0" name="ExpirationDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="DeliveryCountryId" type="xs:int" />
              <xs:element minOccurs="0" name="HasOwnDeliveryAddress" type="xs:boolean" />
              <xs:element minOccurs="0" name="InvoiceCountryId" type="xs:int" />
              <xs:element minOccurs="0" name="HasOwnInvoiceAddress" type="xs:boolean" />
              <xs:element minOccurs="0" name="ERPPaymentTermsKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ERPPaymentTypeKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ERPDeliveryTermsKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ERPDeliveryTypeKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="ApprovedBy" type="xs:int" />
              <xs:element minOccurs="0" name="ApprovedText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ApprovedRegisteredBy" type="xs:int" />
              <xs:element minOccurs="0" name="ApprovedRegisteredDate" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ExtraField1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField2" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField3" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField4" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField5" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="LastRecalculated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Updated" type="xs:dateTime" />
              <xs:element minOccurs="0" name="UpdatedAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="Registered" type="xs:dateTime" />
              <xs:element minOccurs="0" name="RegisteredAssociateId" type="xs:int" />
              <xs:element minOccurs="0" name="QuoteAlternatives" nillable="true" type="tns:ArrayOfQuoteAlternative" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuoteVersion" nillable="true" type="tns:QuoteVersion" />
      <xs:simpleType name="QuoteVersionState">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Unknown" />
          <xs:enumeration value="Draft" />
          <xs:enumeration value="DraftNotCalculated" />
          <xs:enumeration value="DraftNeedsApproval" />
          <xs:enumeration value="DraftApproved" />
          <xs:enumeration value="DraftNotApproved" />
          <xs:enumeration value="Sent" />
          <xs:enumeration value="Archived" />
          <xs:enumeration value="Lost" />
          <xs:enumeration value="Sold" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="QuoteVersionState" nillable="true" type="tns:QuoteVersionState" />
      <xs:simpleType name="QuoteStatus">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Ok" />
          <xs:enumeration value="OkWithInfo" />
          <xs:enumeration value="Warning" />
          <xs:enumeration value="Error" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="QuoteStatus" nillable="true" type="tns:QuoteStatus" />
      <xs:complexType name="ArrayOfQuoteAlternative">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="QuoteAlternative" nillable="true" type="tns:QuoteAlternative" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfQuoteAlternative" nillable="true" type="tns:ArrayOfQuoteAlternative" />
      <xs:complexType name="QuoteAlternative">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="QuoteAlternativeId" type="xs:int" />
              <xs:element minOccurs="0" name="ERPQuoteAlternativeKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Status" type="tns:QuoteStatus" />
              <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ERPDiscountPercent" type="xs:double" />
              <xs:element minOccurs="0" name="ERPDiscountAmount" type="xs:double" />
              <xs:element minOccurs="0" name="DiscountPercent" type="xs:double" />
              <xs:element minOccurs="0" name="DiscountAmount" type="xs:double" />
              <xs:element minOccurs="0" name="UserValueOverride" type="tns:ValueOverride" />
              <xs:element minOccurs="0" name="VATInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="VAT" type="xs:double" />
              <xs:element minOccurs="0" name="EarningPercent" type="xs:double" />
              <xs:element minOccurs="0" name="EarningAmount" type="xs:double" />
              <xs:element minOccurs="0" name="SubTotal" type="xs:double" />
              <xs:element minOccurs="0" name="TotalPrice" type="xs:double" />
              <xs:element minOccurs="0" name="ExtraField1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField2" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField3" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField4" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField5" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuoteAlternative" nillable="true" type="tns:QuoteAlternative" />
      <xs:simpleType name="ValueOverride">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Total" />
          <xs:enumeration value="DiscountPercent" />
          <xs:enumeration value="DiscountAmount" />
          <xs:enumeration value="EarningPercent" />
          <xs:enumeration value="EarningAmount" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ValueOverride" nillable="true" type="tns:ValueOverride" />
      <xs:complexType name="ArrayOfQuoteAlternativeRecalculated">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="QuoteAlternativeRecalculated" nillable="true" type="tns:QuoteAlternativeRecalculated" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfQuoteAlternativeRecalculated" nillable="true" type="tns:ArrayOfQuoteAlternativeRecalculated" />
      <xs:complexType name="QuoteAlternativeRecalculated">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="QuoteLinesHasChanged" type="xs:boolean" />
              <xs:element minOccurs="0" name="ChangedQuoteAlternative" nillable="true" type="tns:QuoteAlternative" />
              <xs:element minOccurs="0" name="Changes" nillable="true" type="tns:ChangedData" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuoteAlternativeRecalculated" nillable="true" type="tns:QuoteAlternativeRecalculated" />
      <xs:complexType name="ChangedData">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="AddedRecords" nillable="true" type="tns:ArrayOfChangedDataItem" />
              <xs:element minOccurs="0" name="UpdatedRecords" nillable="true" type="tns:ArrayOfChangedDataItem" />
              <xs:element minOccurs="0" name="DeletedRecords" nillable="true" type="tns:ArrayOfChangedDataItem" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ChangedData" nillable="true" type="tns:ChangedData" />
      <xs:complexType name="ArrayOfChangedDataItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ChangedDataItem" nillable="true" type="tns:ChangedDataItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfChangedDataItem" nillable="true" type="tns:ArrayOfChangedDataItem" />
      <xs:complexType name="ChangedDataItem">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Tablename" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="RecordId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ChangedDataItem" nillable="true" type="tns:ChangedDataItem" />
      <xs:complexType name="SoExceptionInfo">
        <xs:sequence>
          <xs:element minOccurs="0" name="Message" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="StackTrace" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="FriendlyText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="ExceptionType" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="Source" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="InnerException" nillable="true" type="tns:SoExceptionInfo" />
          <xs:element minOccurs="0" name="Parameters" nillable="true" type="tns:SoExceptionInfoParameters" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfo" nillable="true" type="tns:SoExceptionInfo" />
      <xs:complexType name="SoExceptionInfoParameters">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="SoExceptionInfoParametersKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="xs:string" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExceptionInfoParameters" nillable="true" type="tns:SoExceptionInfoParameters" />
      <xs:element name="ExceptionInfo" nillable="true" type="tns:SoExceptionInfo" />
      <xs:complexType name="SoExtraInfo">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ExtraInfoNameValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="xs:string" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="SoExtraInfo" nillable="true" type="tns:SoExtraInfo" />
      <xs:element name="ExtraInfo" nillable="true" type="tns:SoExtraInfo" />
      <xs:element name="Succeeded" type="xs:boolean" />
      <xs:element name="SaveQuoteVersionNumber">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
            <xs:element minOccurs="0" name="Number" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteVersionNumberResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteVersionWorkflowImageState">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteVersionWorkflowImageStateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteVersionButtonState" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="QuoteVersionButtonState">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Action" type="tns:QuoteVersionButtonAction" />
              <xs:element minOccurs="0" name="ImageHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TooltipText" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Enabled" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuoteVersionButtonState" nillable="true" type="tns:QuoteVersionButtonState" />
      <xs:simpleType name="QuoteVersionButtonAction">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="ValidateVersion" />
          <xs:enumeration value="Edit" />
          <xs:enumeration value="Send" />
          <xs:enumeration value="Approve" />
          <xs:enumeration value="Reject" />
          <xs:enumeration value="ValidateVersionAndSendIfPossible">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">7</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="ValidateVersionAndPlaceOrderIfPossible">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">8</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="CloneVersion">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">9</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="SendConfirmation">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">10</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="GetOrderState">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">11</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
          <xs:enumeration value="UpdatePrices">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">12</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="QuoteVersionButtonAction" nillable="true" type="tns:QuoteVersionButtonAction" />
      <xs:element name="GetQuoteVersionWorkflowButtonStates">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
            <xs:element minOccurs="0" name="QuoteAlternativeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteVersionWorkflowButtonStatesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteVersionWorkflowState" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="QuoteVersionWorkflowState">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ActionButtons" nillable="true" type="tns:ArrayOfQuoteVersionButtonState" />
              <xs:element minOccurs="0" name="StateImage" nillable="true" type="tns:QuoteVersionButtonState" />
              <xs:element minOccurs="0" name="UpdatePricesButton" nillable="true" type="tns:QuoteVersionButtonState" />
              <xs:element minOccurs="0" name="Status" nillable="true" type="tns:QuoteVersionStatusInformation" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuoteVersionWorkflowState" nillable="true" type="tns:QuoteVersionWorkflowState" />
      <xs:complexType name="ArrayOfQuoteVersionButtonState">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="QuoteVersionButtonState" nillable="true" type="tns:QuoteVersionButtonState" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfQuoteVersionButtonState" nillable="true" type="tns:ArrayOfQuoteVersionButtonState" />
      <xs:complexType name="QuoteVersionStatusInformation">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Status" type="tns:QuoteStatus" />
              <xs:element minOccurs="0" name="IconHint" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayMessage" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayTooltip" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuoteVersionStatusInformation" nillable="true" type="tns:QuoteVersionStatusInformation" />
      <xs:element name="GetQuoteVersionWorkflowStatusInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteVersionWorkflowStatusInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteVersionStatusInformation" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateOrUpdateQuoteVersionAttachments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateOrUpdateQuoteVersionAttachmentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfQuoteVersionAttachment" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfQuoteVersionAttachment">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="QuoteVersionAttachment" nillable="true" type="tns:QuoteVersionAttachment" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfQuoteVersionAttachment" nillable="true" type="tns:ArrayOfQuoteVersionAttachment" />
      <xs:complexType name="QuoteVersionAttachment">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
              <xs:element minOccurs="0" name="Included" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuoteVersionAttachment" nillable="true" type="tns:QuoteVersionAttachment" />
      <xs:element name="IncludeQuoteVersionAttachment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
            <xs:element minOccurs="0" name="Include" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="IncludeQuoteVersionAttachmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleSaleTypeQuoteAttachmentDefaultIncluded">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleTypeQuoteAttachmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleSaleTypeQuoteAttachmentDefaultIncludedResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddSaleTypeQuoteAttachment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleTypeId" type="xs:int" />
            <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="AddSaleTypeQuoteAttachmentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteSaleTypeQuoteAttachment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleTypeQuoteAttachmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteSaleTypeQuoteAttachmentResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleQuoteVersionAttachmentIncluded">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionAttachmentId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleQuoteVersionAttachmentIncludedResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultPriceList">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultPriceListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PriceList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PriceList">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="PriceListId" type="xs:int" />
              <xs:element minOccurs="0" name="ERPPriceListKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Currency" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CurrencyName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ValidFrom" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ValidTo" type="xs:dateTime" />
              <xs:element minOccurs="0" name="IsActive" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PriceList" nillable="true" type="tns:PriceList" />
      <xs:element name="SavePriceList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PriceList" nillable="true" type="tns:PriceList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SavePriceListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PriceList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeletePriceList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PriceListId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeletePriceListResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultProduct">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultProductResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Product" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Product">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ProductId" type="xs:int" />
              <xs:element minOccurs="0" name="ERPProductKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ERPPriceListKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Code" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PriceUnit" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="QuantityUnit" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsSubscription" type="xs:boolean" />
              <xs:element minOccurs="0" name="SubscriptionUnit" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DefaultSubscriptionQuantity" type="xs:double" />
              <xs:element minOccurs="0" name="ItemNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Url" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProductCategoryKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProductFamilyKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProductTypeKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="VAT" type="xs:double" />
              <xs:element minOccurs="0" name="VATInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="UnitCost" type="xs:double" />
              <xs:element minOccurs="0" name="UnitMinimumPrice" type="xs:double" />
              <xs:element minOccurs="0" name="UnitListPrice" type="xs:double" />
              <xs:element minOccurs="0" name="InAssortment" type="xs:boolean" />
              <xs:element minOccurs="0" name="Supplier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SupplierCode" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rights" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rule" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="tns:ArrayOfProductExtraDataField" />
              <xs:element minOccurs="0" name="RawExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField2" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField3" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField4" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField5" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="InStock" type="xs:double" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Product" nillable="true" type="tns:Product" />
      <xs:complexType name="ArrayOfProductExtraDataField">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ProductExtraDataField" nillable="true" type="tns:ProductExtraDataField" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfProductExtraDataField" nillable="true" type="tns:ArrayOfProductExtraDataField" />
      <xs:complexType name="ProductExtraDataField">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Value" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Type" type="tns:ExtraDataFieldType" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ProductExtraDataField" nillable="true" type="tns:ProductExtraDataField" />
      <xs:simpleType name="ExtraDataFieldType">
        <xs:restriction base="xs:string">
          <xs:enumeration value="String" />
          <xs:enumeration value="Url" />
          <xs:enumeration value="Image" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="ExtraDataFieldType" nillable="true" type="tns:ExtraDataFieldType" />
      <xs:element name="SaveProduct">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Product" nillable="true" type="tns:Product" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveProductResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Product" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteProduct">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProductId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteProductResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultQuoteAlternative">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateDefaultQuoteAlternativeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteAlternative" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteAlternative">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteAlternative" nillable="true" type="tns:QuoteAlternative" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteAlternativeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteAlternative" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigurationFields">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ConnectorName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConfigurationFieldsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:FieldMetadataDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="FieldMetadataDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="FieldMetadataDictionaryKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="tns:FieldMetadata" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="FieldMetadataDictionary" nillable="true" type="tns:FieldMetadataDictionary" />
      <xs:complexType name="FieldMetadata">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="FieldKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="FieldType" type="tns:FieldMetadataType" />
              <xs:element minOccurs="0" name="ListName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DefaultValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MaxLength" type="xs:int" />
              <xs:element minOccurs="0" name="Access" type="tns:FieldAccess" />
              <xs:element minOccurs="0" name="ShowInSearch" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="FieldMetadata" nillable="true" type="tns:FieldMetadata" />
      <xs:simpleType name="FieldMetadataType">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Checkbox" />
          <xs:enumeration value="Text" />
          <xs:enumeration value="Password" />
          <xs:enumeration value="Integer" />
          <xs:enumeration value="Double" />
          <xs:enumeration value="List" />
          <xs:enumeration value="Date" />
          <xs:enumeration value="Label">
            <xs:annotation>
              <xs:appinfo>
                <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">99</EnumerationValue>
              </xs:appinfo>
            </xs:annotation>
          </xs:enumeration>
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="FieldMetadataType" nillable="true" type="tns:FieldMetadataType" />
      <xs:simpleType name="FieldAccess">
        <xs:annotation>
          <xs:appinfo>
            <ActualType Name="short" Namespace="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/2003/10/Serialization/" />
          </xs:appinfo>
        </xs:annotation>
        <xs:restriction base="xs:string">
          <xs:enumeration value="Normal" />
          <xs:enumeration value="Mandatory" />
          <xs:enumeration value="ReadOnly" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="FieldAccess" nillable="true" type="tns:FieldAccess" />
      <xs:element name="TestConnection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectorName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ConnectionData" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="StringDictionary">
        <xs:annotation>
          <xs:appinfo>
            <IsDictionary xmlns="http://schemas.microsoft.com/2003/10/Serialization/">true</IsDictionary>
          </xs:appinfo>
        </xs:annotation>
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="StringKeyValuePair">
            <xs:complexType>
              <xs:sequence>
                <xs:element name="Key" nillable="true" type="xs:string" />
                <xs:element name="Value" nillable="true" type="xs:string" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:complexType>
      <xs:element name="StringDictionary" nillable="true" type="tns:StringDictionary" />
      <xs:element name="TestConnectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PluginResponse" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PluginResponse">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="IsOk" type="xs:boolean" />
              <xs:element minOccurs="0" name="UserExplanation" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TechExplanation" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ErrorCode" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Changes" nillable="true" type="tns:ChangedData" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PluginResponse" nillable="true" type="tns:PluginResponse" />
      <xs:element name="GetPriceList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="PriceListId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetPriceListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PriceList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopySuperOfficePriceList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="OriginalPriceListId" type="xs:int" />
            <xs:element minOccurs="0" name="NewName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ValidFrom" type="xs:dateTime" />
            <xs:element minOccurs="0" name="ValidTo" type="xs:dateTime" />
            <xs:element minOccurs="0" name="NewCurrencyId" type="xs:int" />
            <xs:element minOccurs="0" name="ConvertCurrency" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopySuperOfficePriceListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PriceList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ERPProductKey" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Rank" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductImageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindProduct">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteAlternativeId" type="xs:int" />
            <xs:element minOccurs="0" name="UserInput" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PriceListKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="FindProductResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfProduct" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfProduct">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="Product" nillable="true" type="tns:Product" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfProduct" nillable="true" type="tns:ArrayOfProduct" />
      <xs:element name="GetProduct">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ERPProductKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Product" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductFromDbId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProductId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetProductFromDbIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Product" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveProduct">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProductId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RemoveProductResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleProductInAssortment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ProductId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ToggleProductInAssortmentResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuote">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Quote" nillable="true" type="tns:Quote" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Quote" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuote">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Quote" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteFromSaleId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteFromSaleIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Quote" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateAndSaveQuote">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="ConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="FirstAlternativeName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateAndSaveQuoteResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="QuoteEntity">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="QuoteId" type="xs:int" />
              <xs:element minOccurs="0" name="SaleId" type="xs:int" />
              <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
              <xs:element minOccurs="0" name="ERPQuoteKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ERPOrderKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ActiveQuoteVersionId" type="xs:int" />
              <xs:element minOccurs="0" name="AcceptedQuoteAlternativeId" type="xs:int" />
              <xs:element minOccurs="0" name="UseValuesFromQuote" type="xs:short" />
              <xs:element minOccurs="0" name="DocumentId" type="xs:int" />
              <xs:element minOccurs="0" name="PoNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="OrderComment" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PreferredEmailCulture" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="QuoteVersions" nillable="true" type="tns:ArrayOfQuoteVersion" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuoteEntity" nillable="true" type="tns:QuoteEntity" />
      <xs:complexType name="ArrayOfQuoteVersion">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="QuoteVersion" nillable="true" type="tns:QuoteVersion" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfQuoteVersion" nillable="true" type="tns:ArrayOfQuoteVersion" />
      <xs:element name="GetQuoteEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteEntityFromSaleId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteEntityFromSaleIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteEntity" nillable="true" type="tns:QuoteEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateAndSaveQuoteFromSale">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="CopyFromSaleId" type="xs:int" />
            <xs:element minOccurs="0" name="CopyToSaleId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateAndSaveQuoteFromSaleResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteEntity" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="PlaceOrder">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteAlternativeId" type="xs:int" />
            <xs:element minOccurs="0" name="MarkSaleAsSold" type="xs:boolean" />
            <xs:element minOccurs="0" name="PoNumber" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="OrderComment" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Culture" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="PlaceOrderResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PluginUrlResponse" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="PluginUrlResponse">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="IsOk" type="xs:boolean" />
              <xs:element minOccurs="0" name="UserExplanation" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="TechExplanation" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ErrorCode" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Changes" nillable="true" type="tns:ChangedData" />
              <xs:element minOccurs="0" name="Url" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="PluginUrlResponse" nillable="true" type="tns:PluginUrlResponse" />
      <xs:element name="GetOrderState">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetOrderStateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PluginUrlResponse" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteQuote">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteQuoteResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteAlternative">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteAlternativeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteAlternativeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteAlternative" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RecalculateQuoteAlternative">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteAlternative" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RecalculateQuoteAlternativeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteAlternativeRecalculated" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteAlternatives">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteAlternativesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfQuoteAlternative" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveQuoteLine">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteLineId" type="xs:int" />
            <xs:element minOccurs="0" name="Direction" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="MoveQuoteLineResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateQuoteAlternative">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
            <xs:element minOccurs="0" name="QuoteAlternativeName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="QuoteAlternativeDescription" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateQuoteAlternativeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteAlternative" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyQuoteAlternative">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
            <xs:element minOccurs="0" name="QuoteAlternativeId" type="xs:int" />
            <xs:element minOccurs="0" name="QuoteAlternativeName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CopyQuoteAlternativeResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteAlternative" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteQuoteAlternative">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteAlternativeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteQuoteAlternativeResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="HasConnections">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="HasConnectionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PluginResponse" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllInstalledQuoteConnections">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllInstalledQuoteConnectionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfQuoteConnection" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfQuoteConnection">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="QuoteConnection" nillable="true" type="tns:QuoteConnection" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfQuoteConnection" nillable="true" type="tns:ArrayOfQuoteConnection" />
      <xs:complexType name="QuoteConnection">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
              <xs:element minOccurs="0" name="ERPName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayDescription" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="ConnectorName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ErpConnectionId" type="xs:int" />
              <xs:element minOccurs="0" name="ExtraData" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsAvailable" type="xs:boolean" />
              <xs:element minOccurs="0" name="InitializeResponse" nillable="true" type="tns:PluginResponse" />
              <xs:element minOccurs="0" name="PriceLists" nillable="true" type="tns:ArrayOfPriceList" />
              <xs:element minOccurs="0" name="AllAccess" type="xs:boolean" />
              <xs:element minOccurs="0" name="Deleted" type="xs:boolean" />
              <xs:element minOccurs="0" name="UserGroupAccessIds" nillable="true" type="q1:ArrayOfint" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="AssociateAccessIds" nillable="true" type="q2:ArrayOfint" xmlns:q2="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuoteConnection" nillable="true" type="tns:QuoteConnection" />
      <xs:complexType name="ArrayOfPriceList">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="PriceList" nillable="true" type="tns:PriceList" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPriceList" nillable="true" type="tns:ArrayOfPriceList" />
      <xs:element name="GetAllAvailableQuoteConnections">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllAvailableQuoteConnectionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfQuoteConnection" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllAvailableQuoteConnectionsWithPriceLists">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllAvailableQuoteConnectionsWithPriceListsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfQuoteConnection" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateConnectionFromConnectorName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ConnectorName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateConnectionFromConnectorNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteConnection" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteConnection" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveConnection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Connection" nillable="true" type="tns:QuoteConnection" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveConnectionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteConnection" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteConnection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteConnectionResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RestoreConnection">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RestoreConnectionResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectionsForAssociate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="AssociateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectionsForAssociateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfQuoteConnection" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetActivePriceLists">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Currency" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetActivePriceListsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPriceList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetActivePriceListsByCurrencyId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="CurrencyId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetActivePriceListsByCurrencyIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPriceList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllPriceLists">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="Currency" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllPriceListsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPriceList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllPriceListsByCurrencyId">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="CurrencyId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllPriceListsByCurrencyIdResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPriceList" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectorCapabilityNames">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectorCapabilityNamesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q3:ArrayOfstring" xmlns:q3="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectorCapabilities">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectorCapabilitiesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="q4:ArrayOfstring" xmlns:q4="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CanConnectorProvideCapability">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="CapabilityName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CanConnectorProvideCapabilityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:boolean" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectionStartupErrors">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectionStartupErrorsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfPluginResponse" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfPluginResponse">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="PluginResponse" nillable="true" type="tns:PluginResponse" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfPluginResponse" nillable="true" type="tns:ArrayOfPluginResponse" />
      <xs:element name="GetConnectionStartupResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectionStartupResponseResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PluginResponse" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectionConfigFields">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetConnectionConfigFieldsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveConnectionConfigFields">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteConnectionId" type="xs:int" />
            <xs:element minOccurs="0" name="ConnectionConfigFields" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveConnectionConfigFieldsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:StringDictionary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateQuoteLine">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteAlternativeId" type="xs:int" />
            <xs:element minOccurs="0" name="ERPProductKey" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateQuoteLineResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteLine" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="QuoteLine">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="QuoteLineId" type="xs:int" />
              <xs:element minOccurs="0" name="ERPQuoteLineKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="QuoteAlternativeId" type="xs:int" />
              <xs:element minOccurs="0" name="ERPProductKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Status" type="tns:QuoteStatus" />
              <xs:element minOccurs="0" name="Reason" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Quantity" type="xs:double" />
              <xs:element minOccurs="0" name="DeliveredQuantity" type="xs:double" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="Name" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Description" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Code" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="QuantityUnit" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="PriceUnit" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ItemNumber" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Url" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProductCategoryKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProductFamilyKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ProductTypeKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Supplier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SupplierCode" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Thumbnail" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="VATInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="VAT" type="xs:double" />
              <xs:element minOccurs="0" name="UnitCost" type="xs:double" />
              <xs:element minOccurs="0" name="UnitMinimumPrice" type="xs:double" />
              <xs:element minOccurs="0" name="UnitListPrice" type="xs:double" />
              <xs:element minOccurs="0" name="ExtraInfo" nillable="true" type="tns:ArrayOfProductExtraDataField" />
              <xs:element minOccurs="0" name="RawExtraInfo" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="IsSubscription" type="xs:boolean" />
              <xs:element minOccurs="0" name="SubscriptionUnit" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="SubscriptionQuantity" type="xs:double" />
              <xs:element minOccurs="0" name="SubscriptionStart" type="xs:dateTime" />
              <xs:element minOccurs="0" name="ERPDiscountPercent" type="xs:double" />
              <xs:element minOccurs="0" name="ERPDiscountAmount" type="xs:double" />
              <xs:element minOccurs="0" name="DiscountPercent" type="xs:double" />
              <xs:element minOccurs="0" name="DiscountAmount" type="xs:double" />
              <xs:element minOccurs="0" name="UserValueOverride" type="tns:ValueOverride" />
              <xs:element minOccurs="0" name="EarningPercent" type="xs:double" />
              <xs:element minOccurs="0" name="EarningAmount" type="xs:double" />
              <xs:element minOccurs="0" name="SubTotal" type="xs:double" />
              <xs:element minOccurs="0" name="TotalPrice" type="xs:double" />
              <xs:element minOccurs="0" name="Rights" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Rule" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField1" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField2" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField3" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField4" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ExtraField5" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuoteLine" nillable="true" type="tns:QuoteLine" />
      <xs:element name="CreateQuoteLineFromProduct">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteAlternativeId" type="xs:int" />
            <xs:element minOccurs="0" name="Product" nillable="true" type="tns:Product" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateQuoteLineFromProductResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteLine" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteLine">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteLine" nillable="true" type="tns:QuoteLine" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteLineResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteLine" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteLine">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteLineId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteLineResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteLine" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteLines">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteAlternativeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteLinesResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfQuoteLine" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfQuoteLine">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="QuoteLine" nillable="true" type="tns:QuoteLine" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfQuoteLine" nillable="true" type="tns:ArrayOfQuoteLine" />
      <xs:element name="DeleteQuoteLine">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteLineId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DeleteQuoteLineResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="RecalculateQuoteLine">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteLine" nillable="true" type="tns:QuoteLine" />
            <xs:element minOccurs="0" name="ChangedFields" nillable="true" type="q5:ArrayOfstring" xmlns:q5="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RecalculateQuoteLineResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteLine" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteLineImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteLineId" type="xs:int" />
            <xs:element minOccurs="0" name="Rank" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteLineImageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:base64Binary" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteLineImage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteLineId" type="xs:int" />
            <xs:element minOccurs="0" name="Image" nillable="true" type="xs:base64Binary" />
            <xs:element minOccurs="0" name="Rank" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteLineImageResponse">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetExtraInfo">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteLineExtraData" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetExtraInfoResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfProductExtraDataField" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteLineConfiguration">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteLineConfigurationId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteLineConfigurationResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteLineConfiguration" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="QuoteLineConfiguration">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="QuoteLineConfigurationId" type="xs:int" />
              <xs:element minOccurs="0" name="FieldName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Label" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Tooltip" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Editable" type="xs:boolean" />
              <xs:element minOccurs="0" name="InUse" type="xs:boolean" />
              <xs:element minOccurs="0" name="Mandatory" type="xs:boolean" />
              <xs:element minOccurs="0" name="Rank" type="xs:int" />
              <xs:element minOccurs="0" name="RestrictEdit" type="xs:boolean" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuoteLineConfiguration" nillable="true" type="tns:QuoteLineConfiguration" />
      <xs:element name="GetQuoteLineConfigurationFromFieldName">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="FieldName" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteLineConfigurationFromFieldNameResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteLineConfiguration" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllQuoteLineConfigurations">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetAllQuoteLineConfigurationsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfQuoteLineConfiguration" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfQuoteLineConfiguration">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="QuoteLineConfiguration" nillable="true" type="tns:QuoteLineConfiguration" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfQuoteLineConfiguration" nillable="true" type="tns:ArrayOfQuoteLineConfiguration" />
      <xs:element name="GetInUseQuoteLineConfigurations">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetInUseQuoteLineConfigurationsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfQuoteLineConfiguration" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteLineConfiguration">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteLineConfiguration" nillable="true" type="tns:QuoteLineConfiguration" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteLineConfigurationResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteLineConfiguration" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteLineConfigurations">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteLineConfigurations" nillable="true" type="tns:ArrayOfQuoteLineConfiguration" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteLineConfigurationsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfQuoteLineConfiguration" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteList">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteListType" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteListResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfQuoteListItem" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfQuoteListItem">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="QuoteListItem" nillable="true" type="tns:QuoteListItem" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfQuoteListItem" nillable="true" type="tns:ArrayOfQuoteListItem" />
      <xs:complexType name="QuoteListItem">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ERPQuoteListItemKey" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="DisplayDescription" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuoteListItem" nillable="true" type="tns:QuoteListItem" />
      <xs:element name="ValidateQuoteVersion">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
            <xs:element minOccurs="0" name="Action" type="tns:QuoteVersionButtonAction" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ValidateQuoteVersionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteVersionValidated" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateAndSaveQuoteVersion">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="CreateAndSaveQuoteVersionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteVersion" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteVersion">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteVersionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteVersion" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteVersions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteVersionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ArrayOfQuoteVersion" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SendQuoteVersion">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
            <xs:element minOccurs="0" name="ExpiryDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="FollowupDate" type="xs:dateTime" />
            <xs:element minOccurs="0" name="FollowupText" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Culture" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SendQuoteVersionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:PluginUrlResponse" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteVersion">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersion" nillable="true" type="tns:QuoteVersion" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SaveQuoteVersionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteVersion" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ApproveQuoteVersion">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
            <xs:element minOccurs="0" name="ApprovedByText" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="ApprovedByAssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="ApprovalText" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ApproveQuoteVersionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ApproveRejectResponse" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ApproveRejectResponse">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="PluginResponse" nillable="true" type="tns:PluginResponse" />
              <xs:element minOccurs="0" name="CreatedAppointmentId" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="ApproveRejectResponse" nillable="true" type="tns:ApproveRejectResponse" />
      <xs:element name="RejectQuoteVersion">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
            <xs:element minOccurs="0" name="RejectedByText" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="RejectedByAssociateId" type="xs:int" />
            <xs:element minOccurs="0" name="RejectionText" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RejectQuoteVersionResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ApproveRejectResponse" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GenerateQuoteDocuments">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
            <xs:element minOccurs="0" name="EmailBodyTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="AttachMainDocument" type="xs:boolean" />
            <xs:element minOccurs="0" name="QuotedProductsTemplateId" type="xs:int" />
            <xs:element minOccurs="0" name="IncludeAttachments" type="xs:boolean" />
            <xs:element minOccurs="0" name="RawMailSubject" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GenerateQuoteDocumentsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuotePublishDocuments" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="QuotePublishDocuments">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="QuoteDocumentId" type="xs:int" />
              <xs:element minOccurs="0" name="QuotedProductsId" type="xs:int" />
              <xs:element minOccurs="0" name="QuoteAttachmentIds" nillable="true" type="q6:ArrayOfint" xmlns:q6="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
              <xs:element minOccurs="0" name="MailBody" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="MailSubject" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ToEmail" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ToFullName" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="ErrorMessage" nillable="true" type="xs:string" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="QuotePublishDocuments" nillable="true" type="tns:QuotePublishDocuments" />
      <xs:element name="GetOrderConfirmation">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
            <xs:element minOccurs="0" name="ConfirmationTemplateId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetOrderConfirmationResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteVersionWorkflowState">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="QuoteVersionId" type="xs:int" />
            <xs:element minOccurs="0" name="QuoteAlternativeId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetQuoteVersionWorkflowStateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:QuoteVersionWorkflowState" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
    </xs:schema>
    <xs:schema attributeFormDefault="qualified" elementFormDefault="qualified" targetNamespace="http://schemas.microsoft.com/2003/10/Serialization/" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:tns="http://schemas.microsoft.com/2003/10/Serialization/">
      <xs:element name="anyType" nillable="true" type="xs:anyType" />
      <xs:element name="anyURI" nillable="true" type="xs:anyURI" />
      <xs:element name="base64Binary" nillable="true" type="xs:base64Binary" />
      <xs:element name="boolean" nillable="true" type="xs:boolean" />
      <xs:element name="byte" nillable="true" type="xs:byte" />
      <xs:element name="dateTime" nillable="true" type="xs:dateTime" />
      <xs:element name="decimal" nillable="true" type="xs:decimal" />
      <xs:element name="double" nillable="true" type="xs:double" />
      <xs:element name="float" nillable="true" type="xs:float" />
      <xs:element name="int" nillable="true" type="xs:int" />
      <xs:element name="long" nillable="true" type="xs:long" />
      <xs:element name="QName" nillable="true" type="xs:QName" />
      <xs:element name="short" nillable="true" type="xs:short" />
      <xs:element name="string" nillable="true" type="xs:string" />
      <xs:element name="unsignedByte" nillable="true" type="xs:unsignedByte" />
      <xs:element name="unsignedInt" nillable="true" type="xs:unsignedInt" />
      <xs:element name="unsignedLong" nillable="true" type="xs:unsignedLong" />
      <xs:element name="unsignedShort" nillable="true" type="xs:unsignedShort" />
      <xs:element name="char" nillable="true" type="tns:char" />
      <xs:simpleType name="char">
        <xs:restriction base="xs:int" />
      </xs:simpleType>
      <xs:element name="duration" nillable="true" type="tns:duration" />
      <xs:simpleType name="duration">
        <xs:restriction base="xs:duration">
          <xs:pattern value="\-?P(\d*D)?(T(\d*H)?(\d*M)?(\d*(\.\d*)?S)?)?" />
          <xs:minInclusive value="-P10675199DT2H48M5.4775808S" />
          <xs:maxInclusive value="P10675199DT2H48M5.4775807S" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="guid" nillable="true" type="tns:guid" />
      <xs:simpleType name="guid">
        <xs:restriction base="xs:string">
          <xs:pattern value="[\da-fA-F]{8}-[\da-fA-F]{4}-[\da-fA-F]{4}-[\da-fA-F]{4}-[\da-fA-F]{12}" />
        </xs:restriction>
      </xs:simpleType>
      <xs:attribute name="FactoryType" type="xs:QName" />
      <xs:attribute name="Id" type="xs:ID" />
      <xs:attribute name="Ref" type="xs:IDREF" />
    </xs:schema>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:tns="http://schemas.microsoft.com/2003/10/Serialization/Arrays">
      <xs:complexType name="ArrayOfint">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="int" type="xs:int" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfint" nillable="true" type="tns:ArrayOfint" />
      <xs:complexType name="ArrayOfstring">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="string" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfstring" nillable="true" type="tns:ArrayOfstring" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="UpdateQuoteVersionPricesRequest">
    <wsdl:part name="parameters" element="tns:UpdateQuoteVersionPrices" />
  </wsdl:message>
  <wsdl:message name="UpdateQuoteVersionPricesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="UpdateQuoteVersionPricesResponse">
    <wsdl:part name="parameters" element="tns:UpdateQuoteVersionPricesResponse" />
  </wsdl:message>
  <wsdl:message name="UpdateQuoteVersionPricesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteVersionNumberRequest">
    <wsdl:part name="parameters" element="tns:SaveQuoteVersionNumber" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteVersionNumberRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteVersionNumberResponse">
    <wsdl:part name="parameters" element="tns:SaveQuoteVersionNumberResponse" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteVersionNumberResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowImageStateRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteVersionWorkflowImageState" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowImageStateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowImageStateResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteVersionWorkflowImageStateResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowImageStateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowButtonStatesRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteVersionWorkflowButtonStates" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowButtonStatesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowButtonStatesResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteVersionWorkflowButtonStatesResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowButtonStatesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowStatusInfoRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteVersionWorkflowStatusInfo" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowStatusInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowStatusInfoResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteVersionWorkflowStatusInfoResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowStatusInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateOrUpdateQuoteVersionAttachmentsRequest">
    <wsdl:part name="parameters" element="tns:CreateOrUpdateQuoteVersionAttachments" />
  </wsdl:message>
  <wsdl:message name="CreateOrUpdateQuoteVersionAttachmentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateOrUpdateQuoteVersionAttachmentsResponse">
    <wsdl:part name="parameters" element="tns:CreateOrUpdateQuoteVersionAttachmentsResponse" />
  </wsdl:message>
  <wsdl:message name="CreateOrUpdateQuoteVersionAttachmentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IncludeQuoteVersionAttachmentRequest">
    <wsdl:part name="parameters" element="tns:IncludeQuoteVersionAttachment" />
  </wsdl:message>
  <wsdl:message name="IncludeQuoteVersionAttachmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="IncludeQuoteVersionAttachmentResponse">
    <wsdl:part name="parameters" element="tns:IncludeQuoteVersionAttachmentResponse" />
  </wsdl:message>
  <wsdl:message name="IncludeQuoteVersionAttachmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleSaleTypeQuoteAttachmentDefaultIncludedRequest">
    <wsdl:part name="parameters" element="tns:ToggleSaleTypeQuoteAttachmentDefaultIncluded" />
  </wsdl:message>
  <wsdl:message name="ToggleSaleTypeQuoteAttachmentDefaultIncludedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleSaleTypeQuoteAttachmentDefaultIncludedResponse">
    <wsdl:part name="parameters" element="tns:ToggleSaleTypeQuoteAttachmentDefaultIncludedResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleSaleTypeQuoteAttachmentDefaultIncludedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddSaleTypeQuoteAttachmentRequest">
    <wsdl:part name="parameters" element="tns:AddSaleTypeQuoteAttachment" />
  </wsdl:message>
  <wsdl:message name="AddSaleTypeQuoteAttachmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="AddSaleTypeQuoteAttachmentResponse">
    <wsdl:part name="parameters" element="tns:AddSaleTypeQuoteAttachmentResponse" />
  </wsdl:message>
  <wsdl:message name="AddSaleTypeQuoteAttachmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteSaleTypeQuoteAttachmentRequest">
    <wsdl:part name="parameters" element="tns:DeleteSaleTypeQuoteAttachment" />
  </wsdl:message>
  <wsdl:message name="DeleteSaleTypeQuoteAttachmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteSaleTypeQuoteAttachmentResponse">
    <wsdl:part name="parameters" element="tns:DeleteSaleTypeQuoteAttachmentResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteSaleTypeQuoteAttachmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleQuoteVersionAttachmentIncludedRequest">
    <wsdl:part name="parameters" element="tns:ToggleQuoteVersionAttachmentIncluded" />
  </wsdl:message>
  <wsdl:message name="ToggleQuoteVersionAttachmentIncludedRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleQuoteVersionAttachmentIncludedResponse">
    <wsdl:part name="parameters" element="tns:ToggleQuoteVersionAttachmentIncludedResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleQuoteVersionAttachmentIncludedResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPriceListRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultPriceList" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPriceListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPriceListResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultPriceListResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultPriceListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SavePriceListRequest">
    <wsdl:part name="parameters" element="tns:SavePriceList" />
  </wsdl:message>
  <wsdl:message name="SavePriceListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SavePriceListResponse">
    <wsdl:part name="parameters" element="tns:SavePriceListResponse" />
  </wsdl:message>
  <wsdl:message name="SavePriceListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeletePriceListRequest">
    <wsdl:part name="parameters" element="tns:DeletePriceList" />
  </wsdl:message>
  <wsdl:message name="DeletePriceListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeletePriceListResponse">
    <wsdl:part name="parameters" element="tns:DeletePriceListResponse" />
  </wsdl:message>
  <wsdl:message name="DeletePriceListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProductRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultProduct" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProductRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProductResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultProductResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultProductResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveProductRequest">
    <wsdl:part name="parameters" element="tns:SaveProduct" />
  </wsdl:message>
  <wsdl:message name="SaveProductRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveProductResponse">
    <wsdl:part name="parameters" element="tns:SaveProductResponse" />
  </wsdl:message>
  <wsdl:message name="SaveProductResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteProductRequest">
    <wsdl:part name="parameters" element="tns:DeleteProduct" />
  </wsdl:message>
  <wsdl:message name="DeleteProductRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteProductResponse">
    <wsdl:part name="parameters" element="tns:DeleteProductResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteProductResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultQuoteAlternativeRequest">
    <wsdl:part name="parameters" element="tns:CreateDefaultQuoteAlternative" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultQuoteAlternativeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultQuoteAlternativeResponse">
    <wsdl:part name="parameters" element="tns:CreateDefaultQuoteAlternativeResponse" />
  </wsdl:message>
  <wsdl:message name="CreateDefaultQuoteAlternativeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteAlternativeRequest">
    <wsdl:part name="parameters" element="tns:SaveQuoteAlternative" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteAlternativeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteAlternativeResponse">
    <wsdl:part name="parameters" element="tns:SaveQuoteAlternativeResponse" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteAlternativeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigurationFieldsRequest">
    <wsdl:part name="parameters" element="tns:GetConfigurationFields" />
  </wsdl:message>
  <wsdl:message name="GetConfigurationFieldsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConfigurationFieldsResponse">
    <wsdl:part name="parameters" element="tns:GetConfigurationFieldsResponse" />
  </wsdl:message>
  <wsdl:message name="GetConfigurationFieldsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TestConnectionRequest">
    <wsdl:part name="parameters" element="tns:TestConnection" />
  </wsdl:message>
  <wsdl:message name="TestConnectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TestConnectionResponse">
    <wsdl:part name="parameters" element="tns:TestConnectionResponse" />
  </wsdl:message>
  <wsdl:message name="TestConnectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPriceListRequest">
    <wsdl:part name="parameters" element="tns:GetPriceList" />
  </wsdl:message>
  <wsdl:message name="GetPriceListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetPriceListResponse">
    <wsdl:part name="parameters" element="tns:GetPriceListResponse" />
  </wsdl:message>
  <wsdl:message name="GetPriceListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopySuperOfficePriceListRequest">
    <wsdl:part name="parameters" element="tns:CopySuperOfficePriceList" />
  </wsdl:message>
  <wsdl:message name="CopySuperOfficePriceListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopySuperOfficePriceListResponse">
    <wsdl:part name="parameters" element="tns:CopySuperOfficePriceListResponse" />
  </wsdl:message>
  <wsdl:message name="CopySuperOfficePriceListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductImageRequest">
    <wsdl:part name="parameters" element="tns:GetProductImage" />
  </wsdl:message>
  <wsdl:message name="GetProductImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductImageResponse">
    <wsdl:part name="parameters" element="tns:GetProductImageResponse" />
  </wsdl:message>
  <wsdl:message name="GetProductImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindProductRequest">
    <wsdl:part name="parameters" element="tns:FindProduct" />
  </wsdl:message>
  <wsdl:message name="FindProductRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="FindProductResponse">
    <wsdl:part name="parameters" element="tns:FindProductResponse" />
  </wsdl:message>
  <wsdl:message name="FindProductResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductRequest">
    <wsdl:part name="parameters" element="tns:GetProduct" />
  </wsdl:message>
  <wsdl:message name="GetProductRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductResponse">
    <wsdl:part name="parameters" element="tns:GetProductResponse" />
  </wsdl:message>
  <wsdl:message name="GetProductResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductFromDbIdRequest">
    <wsdl:part name="parameters" element="tns:GetProductFromDbId" />
  </wsdl:message>
  <wsdl:message name="GetProductFromDbIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetProductFromDbIdResponse">
    <wsdl:part name="parameters" element="tns:GetProductFromDbIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetProductFromDbIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveProductRequest">
    <wsdl:part name="parameters" element="tns:RemoveProduct" />
  </wsdl:message>
  <wsdl:message name="RemoveProductRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RemoveProductResponse">
    <wsdl:part name="parameters" element="tns:RemoveProductResponse" />
  </wsdl:message>
  <wsdl:message name="RemoveProductResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleProductInAssortmentRequest">
    <wsdl:part name="parameters" element="tns:ToggleProductInAssortment" />
  </wsdl:message>
  <wsdl:message name="ToggleProductInAssortmentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ToggleProductInAssortmentResponse">
    <wsdl:part name="parameters" element="tns:ToggleProductInAssortmentResponse" />
  </wsdl:message>
  <wsdl:message name="ToggleProductInAssortmentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteRequest">
    <wsdl:part name="parameters" element="tns:SaveQuote" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteResponse">
    <wsdl:part name="parameters" element="tns:SaveQuoteResponse" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteRequest">
    <wsdl:part name="parameters" element="tns:GetQuote" />
  </wsdl:message>
  <wsdl:message name="GetQuoteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteFromSaleIdRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteFromSaleId" />
  </wsdl:message>
  <wsdl:message name="GetQuoteFromSaleIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteFromSaleIdResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteFromSaleIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteFromSaleIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateAndSaveQuoteRequest">
    <wsdl:part name="parameters" element="tns:CreateAndSaveQuote" />
  </wsdl:message>
  <wsdl:message name="CreateAndSaveQuoteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateAndSaveQuoteResponse">
    <wsdl:part name="parameters" element="tns:CreateAndSaveQuoteResponse" />
  </wsdl:message>
  <wsdl:message name="CreateAndSaveQuoteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteEntityRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteEntity" />
  </wsdl:message>
  <wsdl:message name="GetQuoteEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteEntityResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteEntityResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteEntityFromSaleIdRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteEntityFromSaleId" />
  </wsdl:message>
  <wsdl:message name="GetQuoteEntityFromSaleIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteEntityFromSaleIdResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteEntityFromSaleIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteEntityFromSaleIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteEntityRequest">
    <wsdl:part name="parameters" element="tns:SaveQuoteEntity" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteEntityResponse">
    <wsdl:part name="parameters" element="tns:SaveQuoteEntityResponse" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateAndSaveQuoteFromSaleRequest">
    <wsdl:part name="parameters" element="tns:CreateAndSaveQuoteFromSale" />
  </wsdl:message>
  <wsdl:message name="CreateAndSaveQuoteFromSaleRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateAndSaveQuoteFromSaleResponse">
    <wsdl:part name="parameters" element="tns:CreateAndSaveQuoteFromSaleResponse" />
  </wsdl:message>
  <wsdl:message name="CreateAndSaveQuoteFromSaleResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PlaceOrderRequest">
    <wsdl:part name="parameters" element="tns:PlaceOrder" />
  </wsdl:message>
  <wsdl:message name="PlaceOrderRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="PlaceOrderResponse">
    <wsdl:part name="parameters" element="tns:PlaceOrderResponse" />
  </wsdl:message>
  <wsdl:message name="PlaceOrderResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOrderStateRequest">
    <wsdl:part name="parameters" element="tns:GetOrderState" />
  </wsdl:message>
  <wsdl:message name="GetOrderStateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOrderStateResponse">
    <wsdl:part name="parameters" element="tns:GetOrderStateResponse" />
  </wsdl:message>
  <wsdl:message name="GetOrderStateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteQuoteRequest">
    <wsdl:part name="parameters" element="tns:DeleteQuote" />
  </wsdl:message>
  <wsdl:message name="DeleteQuoteRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteQuoteResponse">
    <wsdl:part name="parameters" element="tns:DeleteQuoteResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteQuoteResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteAlternativeRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteAlternative" />
  </wsdl:message>
  <wsdl:message name="GetQuoteAlternativeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteAlternativeResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteAlternativeResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteAlternativeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RecalculateQuoteAlternativeRequest">
    <wsdl:part name="parameters" element="tns:RecalculateQuoteAlternative" />
  </wsdl:message>
  <wsdl:message name="RecalculateQuoteAlternativeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RecalculateQuoteAlternativeResponse">
    <wsdl:part name="parameters" element="tns:RecalculateQuoteAlternativeResponse" />
  </wsdl:message>
  <wsdl:message name="RecalculateQuoteAlternativeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteAlternativesRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteAlternatives" />
  </wsdl:message>
  <wsdl:message name="GetQuoteAlternativesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteAlternativesResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteAlternativesResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteAlternativesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveQuoteLineRequest">
    <wsdl:part name="parameters" element="tns:MoveQuoteLine" />
  </wsdl:message>
  <wsdl:message name="MoveQuoteLineRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="MoveQuoteLineResponse">
    <wsdl:part name="parameters" element="tns:MoveQuoteLineResponse" />
  </wsdl:message>
  <wsdl:message name="MoveQuoteLineResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateQuoteAlternativeRequest">
    <wsdl:part name="parameters" element="tns:CreateQuoteAlternative" />
  </wsdl:message>
  <wsdl:message name="CreateQuoteAlternativeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateQuoteAlternativeResponse">
    <wsdl:part name="parameters" element="tns:CreateQuoteAlternativeResponse" />
  </wsdl:message>
  <wsdl:message name="CreateQuoteAlternativeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyQuoteAlternativeRequest">
    <wsdl:part name="parameters" element="tns:CopyQuoteAlternative" />
  </wsdl:message>
  <wsdl:message name="CopyQuoteAlternativeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CopyQuoteAlternativeResponse">
    <wsdl:part name="parameters" element="tns:CopyQuoteAlternativeResponse" />
  </wsdl:message>
  <wsdl:message name="CopyQuoteAlternativeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteQuoteAlternativeRequest">
    <wsdl:part name="parameters" element="tns:DeleteQuoteAlternative" />
  </wsdl:message>
  <wsdl:message name="DeleteQuoteAlternativeRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteQuoteAlternativeResponse">
    <wsdl:part name="parameters" element="tns:DeleteQuoteAlternativeResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteQuoteAlternativeResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasConnectionsRequest">
    <wsdl:part name="parameters" element="tns:HasConnections" />
  </wsdl:message>
  <wsdl:message name="HasConnectionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="HasConnectionsResponse">
    <wsdl:part name="parameters" element="tns:HasConnectionsResponse" />
  </wsdl:message>
  <wsdl:message name="HasConnectionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllInstalledQuoteConnectionsRequest">
    <wsdl:part name="parameters" element="tns:GetAllInstalledQuoteConnections" />
  </wsdl:message>
  <wsdl:message name="GetAllInstalledQuoteConnectionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllInstalledQuoteConnectionsResponse">
    <wsdl:part name="parameters" element="tns:GetAllInstalledQuoteConnectionsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllInstalledQuoteConnectionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllAvailableQuoteConnectionsRequest">
    <wsdl:part name="parameters" element="tns:GetAllAvailableQuoteConnections" />
  </wsdl:message>
  <wsdl:message name="GetAllAvailableQuoteConnectionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllAvailableQuoteConnectionsResponse">
    <wsdl:part name="parameters" element="tns:GetAllAvailableQuoteConnectionsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllAvailableQuoteConnectionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllAvailableQuoteConnectionsWithPriceListsRequest">
    <wsdl:part name="parameters" element="tns:GetAllAvailableQuoteConnectionsWithPriceLists" />
  </wsdl:message>
  <wsdl:message name="GetAllAvailableQuoteConnectionsWithPriceListsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllAvailableQuoteConnectionsWithPriceListsResponse">
    <wsdl:part name="parameters" element="tns:GetAllAvailableQuoteConnectionsWithPriceListsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllAvailableQuoteConnectionsWithPriceListsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateConnectionFromConnectorNameRequest">
    <wsdl:part name="parameters" element="tns:CreateConnectionFromConnectorName" />
  </wsdl:message>
  <wsdl:message name="CreateConnectionFromConnectorNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateConnectionFromConnectorNameResponse">
    <wsdl:part name="parameters" element="tns:CreateConnectionFromConnectorNameResponse" />
  </wsdl:message>
  <wsdl:message name="CreateConnectionFromConnectorNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionRequest">
    <wsdl:part name="parameters" element="tns:GetConnection" />
  </wsdl:message>
  <wsdl:message name="GetConnectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionResponse">
    <wsdl:part name="parameters" element="tns:GetConnectionResponse" />
  </wsdl:message>
  <wsdl:message name="GetConnectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionRequest">
    <wsdl:part name="parameters" element="tns:SaveConnection" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionResponse">
    <wsdl:part name="parameters" element="tns:SaveConnectionResponse" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteConnectionRequest">
    <wsdl:part name="parameters" element="tns:DeleteConnection" />
  </wsdl:message>
  <wsdl:message name="DeleteConnectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteConnectionResponse">
    <wsdl:part name="parameters" element="tns:DeleteConnectionResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteConnectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RestoreConnectionRequest">
    <wsdl:part name="parameters" element="tns:RestoreConnection" />
  </wsdl:message>
  <wsdl:message name="RestoreConnectionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RestoreConnectionResponse">
    <wsdl:part name="parameters" element="tns:RestoreConnectionResponse" />
  </wsdl:message>
  <wsdl:message name="RestoreConnectionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionsForAssociateRequest">
    <wsdl:part name="parameters" element="tns:GetConnectionsForAssociate" />
  </wsdl:message>
  <wsdl:message name="GetConnectionsForAssociateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionsForAssociateResponse">
    <wsdl:part name="parameters" element="tns:GetConnectionsForAssociateResponse" />
  </wsdl:message>
  <wsdl:message name="GetConnectionsForAssociateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetActivePriceListsRequest">
    <wsdl:part name="parameters" element="tns:GetActivePriceLists" />
  </wsdl:message>
  <wsdl:message name="GetActivePriceListsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetActivePriceListsResponse">
    <wsdl:part name="parameters" element="tns:GetActivePriceListsResponse" />
  </wsdl:message>
  <wsdl:message name="GetActivePriceListsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetActivePriceListsByCurrencyIdRequest">
    <wsdl:part name="parameters" element="tns:GetActivePriceListsByCurrencyId" />
  </wsdl:message>
  <wsdl:message name="GetActivePriceListsByCurrencyIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetActivePriceListsByCurrencyIdResponse">
    <wsdl:part name="parameters" element="tns:GetActivePriceListsByCurrencyIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetActivePriceListsByCurrencyIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllPriceListsRequest">
    <wsdl:part name="parameters" element="tns:GetAllPriceLists" />
  </wsdl:message>
  <wsdl:message name="GetAllPriceListsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllPriceListsResponse">
    <wsdl:part name="parameters" element="tns:GetAllPriceListsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllPriceListsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllPriceListsByCurrencyIdRequest">
    <wsdl:part name="parameters" element="tns:GetAllPriceListsByCurrencyId" />
  </wsdl:message>
  <wsdl:message name="GetAllPriceListsByCurrencyIdRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllPriceListsByCurrencyIdResponse">
    <wsdl:part name="parameters" element="tns:GetAllPriceListsByCurrencyIdResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllPriceListsByCurrencyIdResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectorCapabilityNamesRequest">
    <wsdl:part name="parameters" element="tns:GetConnectorCapabilityNames" />
  </wsdl:message>
  <wsdl:message name="GetConnectorCapabilityNamesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectorCapabilityNamesResponse">
    <wsdl:part name="parameters" element="tns:GetConnectorCapabilityNamesResponse" />
  </wsdl:message>
  <wsdl:message name="GetConnectorCapabilityNamesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectorCapabilitiesRequest">
    <wsdl:part name="parameters" element="tns:GetConnectorCapabilities" />
  </wsdl:message>
  <wsdl:message name="GetConnectorCapabilitiesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectorCapabilitiesResponse">
    <wsdl:part name="parameters" element="tns:GetConnectorCapabilitiesResponse" />
  </wsdl:message>
  <wsdl:message name="GetConnectorCapabilitiesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CanConnectorProvideCapabilityRequest">
    <wsdl:part name="parameters" element="tns:CanConnectorProvideCapability" />
  </wsdl:message>
  <wsdl:message name="CanConnectorProvideCapabilityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CanConnectorProvideCapabilityResponse">
    <wsdl:part name="parameters" element="tns:CanConnectorProvideCapabilityResponse" />
  </wsdl:message>
  <wsdl:message name="CanConnectorProvideCapabilityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionStartupErrorsRequest">
    <wsdl:part name="parameters" element="tns:GetConnectionStartupErrors" />
  </wsdl:message>
  <wsdl:message name="GetConnectionStartupErrorsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionStartupErrorsResponse">
    <wsdl:part name="parameters" element="tns:GetConnectionStartupErrorsResponse" />
  </wsdl:message>
  <wsdl:message name="GetConnectionStartupErrorsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionStartupResponseRequest">
    <wsdl:part name="parameters" element="tns:GetConnectionStartupResponse" />
  </wsdl:message>
  <wsdl:message name="GetConnectionStartupResponseRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionStartupResponseResponse">
    <wsdl:part name="parameters" element="tns:GetConnectionStartupResponseResponse" />
  </wsdl:message>
  <wsdl:message name="GetConnectionStartupResponseResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionConfigFieldsRequest">
    <wsdl:part name="parameters" element="tns:GetConnectionConfigFields" />
  </wsdl:message>
  <wsdl:message name="GetConnectionConfigFieldsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetConnectionConfigFieldsResponse">
    <wsdl:part name="parameters" element="tns:GetConnectionConfigFieldsResponse" />
  </wsdl:message>
  <wsdl:message name="GetConnectionConfigFieldsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionConfigFieldsRequest">
    <wsdl:part name="parameters" element="tns:SaveConnectionConfigFields" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionConfigFieldsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionConfigFieldsResponse">
    <wsdl:part name="parameters" element="tns:SaveConnectionConfigFieldsResponse" />
  </wsdl:message>
  <wsdl:message name="SaveConnectionConfigFieldsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateQuoteLineRequest">
    <wsdl:part name="parameters" element="tns:CreateQuoteLine" />
  </wsdl:message>
  <wsdl:message name="CreateQuoteLineRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateQuoteLineResponse">
    <wsdl:part name="parameters" element="tns:CreateQuoteLineResponse" />
  </wsdl:message>
  <wsdl:message name="CreateQuoteLineResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateQuoteLineFromProductRequest">
    <wsdl:part name="parameters" element="tns:CreateQuoteLineFromProduct" />
  </wsdl:message>
  <wsdl:message name="CreateQuoteLineFromProductRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateQuoteLineFromProductResponse">
    <wsdl:part name="parameters" element="tns:CreateQuoteLineFromProductResponse" />
  </wsdl:message>
  <wsdl:message name="CreateQuoteLineFromProductResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineRequest">
    <wsdl:part name="parameters" element="tns:SaveQuoteLine" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineResponse">
    <wsdl:part name="parameters" element="tns:SaveQuoteLineResponse" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteLine" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteLineResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLinesRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteLines" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLinesRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLinesResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteLinesResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLinesResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteQuoteLineRequest">
    <wsdl:part name="parameters" element="tns:DeleteQuoteLine" />
  </wsdl:message>
  <wsdl:message name="DeleteQuoteLineRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DeleteQuoteLineResponse">
    <wsdl:part name="parameters" element="tns:DeleteQuoteLineResponse" />
  </wsdl:message>
  <wsdl:message name="DeleteQuoteLineResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RecalculateQuoteLineRequest">
    <wsdl:part name="parameters" element="tns:RecalculateQuoteLine" />
  </wsdl:message>
  <wsdl:message name="RecalculateQuoteLineRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RecalculateQuoteLineResponse">
    <wsdl:part name="parameters" element="tns:RecalculateQuoteLineResponse" />
  </wsdl:message>
  <wsdl:message name="RecalculateQuoteLineResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineImageRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteLineImage" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineImageResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteLineImageResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineImageRequest">
    <wsdl:part name="parameters" element="tns:SaveQuoteLineImage" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineImageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineImageResponse">
    <wsdl:part name="parameters" element="tns:SaveQuoteLineImageResponse" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineImageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetExtraInfoRequest">
    <wsdl:part name="parameters" element="tns:GetExtraInfo" />
  </wsdl:message>
  <wsdl:message name="GetExtraInfoRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetExtraInfoResponse">
    <wsdl:part name="parameters" element="tns:GetExtraInfoResponse" />
  </wsdl:message>
  <wsdl:message name="GetExtraInfoResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineConfigurationRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteLineConfiguration" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineConfigurationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineConfigurationResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteLineConfigurationResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineConfigurationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineConfigurationFromFieldNameRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteLineConfigurationFromFieldName" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineConfigurationFromFieldNameRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineConfigurationFromFieldNameResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteLineConfigurationFromFieldNameResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteLineConfigurationFromFieldNameResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllQuoteLineConfigurationsRequest">
    <wsdl:part name="parameters" element="tns:GetAllQuoteLineConfigurations" />
  </wsdl:message>
  <wsdl:message name="GetAllQuoteLineConfigurationsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetAllQuoteLineConfigurationsResponse">
    <wsdl:part name="parameters" element="tns:GetAllQuoteLineConfigurationsResponse" />
  </wsdl:message>
  <wsdl:message name="GetAllQuoteLineConfigurationsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetInUseQuoteLineConfigurationsRequest">
    <wsdl:part name="parameters" element="tns:GetInUseQuoteLineConfigurations" />
  </wsdl:message>
  <wsdl:message name="GetInUseQuoteLineConfigurationsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetInUseQuoteLineConfigurationsResponse">
    <wsdl:part name="parameters" element="tns:GetInUseQuoteLineConfigurationsResponse" />
  </wsdl:message>
  <wsdl:message name="GetInUseQuoteLineConfigurationsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineConfigurationRequest">
    <wsdl:part name="parameters" element="tns:SaveQuoteLineConfiguration" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineConfigurationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineConfigurationResponse">
    <wsdl:part name="parameters" element="tns:SaveQuoteLineConfigurationResponse" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineConfigurationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineConfigurationsRequest">
    <wsdl:part name="parameters" element="tns:SaveQuoteLineConfigurations" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineConfigurationsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineConfigurationsResponse">
    <wsdl:part name="parameters" element="tns:SaveQuoteLineConfigurationsResponse" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteLineConfigurationsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteListRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteList" />
  </wsdl:message>
  <wsdl:message name="GetQuoteListRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteListResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteListResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteListResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateQuoteVersionRequest">
    <wsdl:part name="parameters" element="tns:ValidateQuoteVersion" />
  </wsdl:message>
  <wsdl:message name="ValidateQuoteVersionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ValidateQuoteVersionResponse">
    <wsdl:part name="parameters" element="tns:ValidateQuoteVersionResponse" />
  </wsdl:message>
  <wsdl:message name="ValidateQuoteVersionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateAndSaveQuoteVersionRequest">
    <wsdl:part name="parameters" element="tns:CreateAndSaveQuoteVersion" />
  </wsdl:message>
  <wsdl:message name="CreateAndSaveQuoteVersionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="CreateAndSaveQuoteVersionResponse">
    <wsdl:part name="parameters" element="tns:CreateAndSaveQuoteVersionResponse" />
  </wsdl:message>
  <wsdl:message name="CreateAndSaveQuoteVersionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteVersion" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteVersionResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionsRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteVersions" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionsResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteVersionsResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendQuoteVersionRequest">
    <wsdl:part name="parameters" element="tns:SendQuoteVersion" />
  </wsdl:message>
  <wsdl:message name="SendQuoteVersionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SendQuoteVersionResponse">
    <wsdl:part name="parameters" element="tns:SendQuoteVersionResponse" />
  </wsdl:message>
  <wsdl:message name="SendQuoteVersionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteVersionRequest">
    <wsdl:part name="parameters" element="tns:SaveQuoteVersion" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteVersionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteVersionResponse">
    <wsdl:part name="parameters" element="tns:SaveQuoteVersionResponse" />
  </wsdl:message>
  <wsdl:message name="SaveQuoteVersionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ApproveQuoteVersionRequest">
    <wsdl:part name="parameters" element="tns:ApproveQuoteVersion" />
  </wsdl:message>
  <wsdl:message name="ApproveQuoteVersionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ApproveQuoteVersionResponse">
    <wsdl:part name="parameters" element="tns:ApproveQuoteVersionResponse" />
  </wsdl:message>
  <wsdl:message name="ApproveQuoteVersionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RejectQuoteVersionRequest">
    <wsdl:part name="parameters" element="tns:RejectQuoteVersion" />
  </wsdl:message>
  <wsdl:message name="RejectQuoteVersionRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RejectQuoteVersionResponse">
    <wsdl:part name="parameters" element="tns:RejectQuoteVersionResponse" />
  </wsdl:message>
  <wsdl:message name="RejectQuoteVersionResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateQuoteDocumentsRequest">
    <wsdl:part name="parameters" element="tns:GenerateQuoteDocuments" />
  </wsdl:message>
  <wsdl:message name="GenerateQuoteDocumentsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GenerateQuoteDocumentsResponse">
    <wsdl:part name="parameters" element="tns:GenerateQuoteDocumentsResponse" />
  </wsdl:message>
  <wsdl:message name="GenerateQuoteDocumentsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOrderConfirmationRequest">
    <wsdl:part name="parameters" element="tns:GetOrderConfirmation" />
  </wsdl:message>
  <wsdl:message name="GetOrderConfirmationRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetOrderConfirmationResponse">
    <wsdl:part name="parameters" element="tns:GetOrderConfirmationResponse" />
  </wsdl:message>
  <wsdl:message name="GetOrderConfirmationResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowStateRequest">
    <wsdl:part name="parameters" element="tns:GetQuoteVersionWorkflowState" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowStateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowStateResponse">
    <wsdl:part name="parameters" element="tns:GetQuoteVersionWorkflowStateResponse" />
  </wsdl:message>
  <wsdl:message name="GetQuoteVersionWorkflowStateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="Quote">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for Quote</summary>
    </wsdl:documentation>
    <wsdl:operation name="UpdateQuoteVersionPrices">
      <wsdl:documentation>
        <summary>Update price on the all the quotelines for each alternative in the current quote version</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/UpdateQuoteVersionPrices" name="UpdateQuoteVersionPricesRequest" message="tns:UpdateQuoteVersionPricesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/UpdateQuoteVersionPricesResponse" name="UpdateQuoteVersionPricesResponse" message="tns:UpdateQuoteVersionPricesResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteVersionNumber">
      <wsdl:documentation>
        <summary>Save the quote version number if it is valid</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteVersionNumber" name="SaveQuoteVersionNumberRequest" message="tns:SaveQuoteVersionNumberRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteVersionNumberResponse" name="SaveQuoteVersionNumberResponse" message="tns:SaveQuoteVersionNumberResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteVersionWorkflowImageState">
      <wsdl:documentation>
        <summary>Get state icon and name for the Quote version dialog header.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersionWorkflowImageState" name="GetQuoteVersionWorkflowImageStateRequest" message="tns:GetQuoteVersionWorkflowImageStateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersionWorkflowImageStateResponse" name="GetQuoteVersionWorkflowImageStateResponse" message="tns:GetQuoteVersionWorkflowImageStateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteVersionWorkflowButtonStates">
      <wsdl:documentation>
        <summary>Get all button states for the Quote version dialog.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersionWorkflowButtonStates" name="GetQuoteVersionWorkflowButtonStatesRequest" message="tns:GetQuoteVersionWorkflowButtonStatesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersionWorkflowButtonStatesResponse" name="GetQuoteVersionWorkflowButtonStatesResponse" message="tns:GetQuoteVersionWorkflowButtonStatesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteVersionWorkflowStatusInfo">
      <wsdl:documentation>
        <summary>Get status info for the Quote version dialog header. Collects most important warnings/errors from across all quotelines/alternatives in this quote version.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersionWorkflowStatusInfo" name="GetQuoteVersionWorkflowStatusInfoRequest" message="tns:GetQuoteVersionWorkflowStatusInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersionWorkflowStatusInfoResponse" name="GetQuoteVersionWorkflowStatusInfoResponse" message="tns:GetQuoteVersionWorkflowStatusInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateOrUpdateQuoteVersionAttachments">
      <wsdl:documentation>
        <summary>Look at the Quote version, related sale and sale type, and ensure that the correct QuoteVersionAttachment records exist. This method may create or delete records</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateOrUpdateQuoteVersionAttachments" name="CreateOrUpdateQuoteVersionAttachmentsRequest" message="tns:CreateOrUpdateQuoteVersionAttachmentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateOrUpdateQuoteVersionAttachmentsResponse" name="CreateOrUpdateQuoteVersionAttachmentsResponse" message="tns:CreateOrUpdateQuoteVersionAttachmentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="IncludeQuoteVersionAttachment">
      <wsdl:documentation>
        <summary>Toggle the 'included' state of a quote version attachment; will throw exceptions if called on locked versions</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/IncludeQuoteVersionAttachment" name="IncludeQuoteVersionAttachmentRequest" message="tns:IncludeQuoteVersionAttachmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/IncludeQuoteVersionAttachmentResponse" name="IncludeQuoteVersionAttachmentResponse" message="tns:IncludeQuoteVersionAttachmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleSaleTypeQuoteAttachmentDefaultIncluded">
      <wsdl:documentation>
        <summary>Toggle the 'default included' state of a sale type quote attachment</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ToggleSaleTypeQuoteAttachmentDefaultIncluded" name="ToggleSaleTypeQuoteAttachmentDefaultIncludedRequest" message="tns:ToggleSaleTypeQuoteAttachmentDefaultIncludedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ToggleSaleTypeQuoteAttachmentDefaultIncludedResponse" name="ToggleSaleTypeQuoteAttachmentDefaultIncludedResponse" message="tns:ToggleSaleTypeQuoteAttachmentDefaultIncludedResponse" />
    </wsdl:operation>
    <wsdl:operation name="AddSaleTypeQuoteAttachment">
      <wsdl:documentation>
        <summary>Adds a new quote attachment document to a sale type</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/AddSaleTypeQuoteAttachment" name="AddSaleTypeQuoteAttachmentRequest" message="tns:AddSaleTypeQuoteAttachmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/AddSaleTypeQuoteAttachmentResponse" name="AddSaleTypeQuoteAttachmentResponse" message="tns:AddSaleTypeQuoteAttachmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteSaleTypeQuoteAttachment">
      <wsdl:documentation>
        <summary>Deletes the sale type quote attachment with the given id</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteSaleTypeQuoteAttachment" name="DeleteSaleTypeQuoteAttachmentRequest" message="tns:DeleteSaleTypeQuoteAttachmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteSaleTypeQuoteAttachmentResponse" name="DeleteSaleTypeQuoteAttachmentResponse" message="tns:DeleteSaleTypeQuoteAttachmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleQuoteVersionAttachmentIncluded">
      <wsdl:documentation>
        <summary>Toggle the 'included' state of a quote version attachment</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ToggleQuoteVersionAttachmentIncluded" name="ToggleQuoteVersionAttachmentIncludedRequest" message="tns:ToggleQuoteVersionAttachmentIncludedRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ToggleQuoteVersionAttachmentIncludedResponse" name="ToggleQuoteVersionAttachmentIncludedResponse" message="tns:ToggleQuoteVersionAttachmentIncludedResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultPriceList">
      <wsdl:documentation>
        <summary>Loading default values into a new PriceList.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateDefaultPriceList" name="CreateDefaultPriceListRequest" message="tns:CreateDefaultPriceListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateDefaultPriceListResponse" name="CreateDefaultPriceListResponse" message="tns:CreateDefaultPriceListResponse" />
    </wsdl:operation>
    <wsdl:operation name="SavePriceList">
      <wsdl:documentation>
        <summary>Updates the existing PriceList or creates a new PriceList if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SavePriceList" name="SavePriceListRequest" message="tns:SavePriceListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SavePriceListResponse" name="SavePriceListResponse" message="tns:SavePriceListResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeletePriceList">
      <wsdl:documentation>
        <summary>Deletes the PriceList</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeletePriceList" name="DeletePriceListRequest" message="tns:DeletePriceListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeletePriceListResponse" name="DeletePriceListResponse" message="tns:DeletePriceListResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultProduct">
      <wsdl:documentation>
        <summary>Loading default values into a new Product.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateDefaultProduct" name="CreateDefaultProductRequest" message="tns:CreateDefaultProductRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateDefaultProductResponse" name="CreateDefaultProductResponse" message="tns:CreateDefaultProductResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveProduct">
      <wsdl:documentation>
        <summary>Updates the existing Product or creates a new Product if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveProduct" name="SaveProductRequest" message="tns:SaveProductRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveProductResponse" name="SaveProductResponse" message="tns:SaveProductResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteProduct">
      <wsdl:documentation>
        <summary>Deletes the Product</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteProduct" name="DeleteProductRequest" message="tns:DeleteProductRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteProductResponse" name="DeleteProductResponse" message="tns:DeleteProductResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultQuoteAlternative">
      <wsdl:documentation>
        <summary>Loading default values into a new QuoteAlternative.  NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateDefaultQuoteAlternative" name="CreateDefaultQuoteAlternativeRequest" message="tns:CreateDefaultQuoteAlternativeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateDefaultQuoteAlternativeResponse" name="CreateDefaultQuoteAlternativeResponse" message="tns:CreateDefaultQuoteAlternativeResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteAlternative">
      <wsdl:documentation>
        <summary>Updates the existing QuoteAlternative or creates a new QuoteAlternative if the id parameter is empty.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteAlternative" name="SaveQuoteAlternativeRequest" message="tns:SaveQuoteAlternativeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteAlternativeResponse" name="SaveQuoteAlternativeResponse" message="tns:SaveQuoteAlternativeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConfigurationFields">
      <wsdl:documentation>
        <summary>Used by ADMIN. Asks for metadata needed to populate admin dialog that takes in the information needed to create a connection to an ERP system. The values entered in the dialog are stored in SuperOffice db and used when InitializeConnector is called by the client.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConfigurationFields" name="GetConfigurationFieldsRequest" message="tns:GetConfigurationFieldsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConfigurationFieldsResponse" name="GetConfigurationFieldsResponse" message="tns:GetConfigurationFieldsResponse" />
    </wsdl:operation>
    <wsdl:operation name="TestConnection">
      <wsdl:documentation>
        <summary>Used by the Admin clients. Testing if the connection data is sufficient to get a connection with the ERP system. The Connector should try to do some operations to check if the connection has sufficient rights to run. The connection has not been created yet. TestConnection is called without InitializeConnector being called first.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/TestConnection" name="TestConnectionRequest" message="tns:TestConnectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/TestConnectionResponse" name="TestConnectionResponse" message="tns:TestConnectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetPriceList">
      <wsdl:documentation>
        <summary>Gets a PriceList object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetPriceList" name="GetPriceListRequest" message="tns:GetPriceListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetPriceListResponse" name="GetPriceListResponse" message="tns:GetPriceListResponse" />
    </wsdl:operation>
    <wsdl:operation name="CopySuperOfficePriceList">
      <wsdl:documentation>
        <summary>Create a copy of a PriceList in the SuperOffice database</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CopySuperOfficePriceList" name="CopySuperOfficePriceListRequest" message="tns:CopySuperOfficePriceListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CopySuperOfficePriceListResponse" name="CopySuperOfficePriceListResponse" message="tns:CopySuperOfficePriceListResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProductImage">
      <wsdl:documentation>
        <summary>Gets an image connected to a product, from the ProductProvider</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetProductImage" name="GetProductImageRequest" message="tns:GetProductImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetProductImageResponse" name="GetProductImageResponse" message="tns:GetProductImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="FindProduct">
      <wsdl:documentation>
        <summary>Gets a product, from the ProductProvider</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/FindProduct" name="FindProductRequest" message="tns:FindProductRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/FindProductResponse" name="FindProductResponse" message="tns:FindProductResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProduct">
      <wsdl:documentation>
        <summary>Get a product with the given key</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetProduct" name="GetProductRequest" message="tns:GetProductRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetProductResponse" name="GetProductResponse" message="tns:GetProductResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetProductFromDbId">
      <wsdl:documentation>
        <summary>Get a product with the given database id</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetProductFromDbId" name="GetProductFromDbIdRequest" message="tns:GetProductFromDbIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetProductFromDbIdResponse" name="GetProductFromDbIdResponse" message="tns:GetProductFromDbIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="RemoveProduct">
      <wsdl:documentation>
        <summary>Removes a product from the database</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RemoveProduct" name="RemoveProductRequest" message="tns:RemoveProductRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RemoveProductResponse" name="RemoveProductResponse" message="tns:RemoveProductResponse" />
    </wsdl:operation>
    <wsdl:operation name="ToggleProductInAssortment">
      <wsdl:documentation>
        <summary>Toggles if the prdouct is in assortment or not</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ToggleProductInAssortment" name="ToggleProductInAssortmentRequest" message="tns:ToggleProductInAssortmentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ToggleProductInAssortmentResponse" name="ToggleProductInAssortmentResponse" message="tns:ToggleProductInAssortmentResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveQuote">
      <wsdl:documentation>
        <summary>Saves a Quote</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuote" name="SaveQuoteRequest" message="tns:SaveQuoteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteResponse" name="SaveQuoteResponse" message="tns:SaveQuoteResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuote">
      <wsdl:documentation>
        <summary>Get a Quote</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuote" name="GetQuoteRequest" message="tns:GetQuoteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteResponse" name="GetQuoteResponse" message="tns:GetQuoteResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteFromSaleId">
      <wsdl:documentation>
        <summary>Get a Quote for a sale</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteFromSaleId" name="GetQuoteFromSaleIdRequest" message="tns:GetQuoteFromSaleIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteFromSaleIdResponse" name="GetQuoteFromSaleIdResponse" message="tns:GetQuoteFromSaleIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateAndSaveQuote">
      <wsdl:documentation>
        <summary>Creates a new quote on a sale.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateAndSaveQuote" name="CreateAndSaveQuoteRequest" message="tns:CreateAndSaveQuoteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateAndSaveQuoteResponse" name="CreateAndSaveQuoteResponse" message="tns:CreateAndSaveQuoteResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteEntity">
      <wsdl:documentation>
        <summary>Get a Quote</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteEntity" name="GetQuoteEntityRequest" message="tns:GetQuoteEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteEntityResponse" name="GetQuoteEntityResponse" message="tns:GetQuoteEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteEntityFromSaleId">
      <wsdl:documentation>
        <summary>Get a Quote for a sale</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteEntityFromSaleId" name="GetQuoteEntityFromSaleIdRequest" message="tns:GetQuoteEntityFromSaleIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteEntityFromSaleIdResponse" name="GetQuoteEntityFromSaleIdResponse" message="tns:GetQuoteEntityFromSaleIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteEntity">
      <wsdl:documentation>
        <summary>Saves a QuoteEntity. Versions and alternatives will not be saved by this call.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteEntity" name="SaveQuoteEntityRequest" message="tns:SaveQuoteEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteEntityResponse" name="SaveQuoteEntityResponse" message="tns:SaveQuoteEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateAndSaveQuoteFromSale">
      <wsdl:documentation>
        <summary>Creates a copy the active version with connected alternatives and quotelines from another sale.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateAndSaveQuoteFromSale" name="CreateAndSaveQuoteFromSaleRequest" message="tns:CreateAndSaveQuoteFromSaleRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateAndSaveQuoteFromSaleResponse" name="CreateAndSaveQuoteFromSaleResponse" message="tns:CreateAndSaveQuoteFromSaleResponse" />
    </wsdl:operation>
    <wsdl:operation name="PlaceOrder">
      <wsdl:documentation>
        <summary>Place an order in the ERP system.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/PlaceOrder" name="PlaceOrderRequest" message="tns:PlaceOrderRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/PlaceOrderResponse" name="PlaceOrderResponse" message="tns:PlaceOrderResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetOrderState">
      <wsdl:documentation>
        <summary>If there is a problem with a quoteline, the error description shall be placed in the status and reason fields of the quoteline, if there is a problem with the alternative, the error description shall be placed in the status and reason fields of the alternative. A summary of all the problems (if any) should be placed in the response object. Requires that the Create-Order capability is true.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetOrderState" name="GetOrderStateRequest" message="tns:GetOrderStateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetOrderStateResponse" name="GetOrderStateResponse" message="tns:GetOrderStateResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteQuote">
      <wsdl:documentation>
        <summary>Delete a Quote</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteQuote" name="DeleteQuoteRequest" message="tns:DeleteQuoteRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteQuoteResponse" name="DeleteQuoteResponse" message="tns:DeleteQuoteResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteAlternative">
      <wsdl:documentation>
        <summary>Gets a QuoteAlternative object..</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteAlternative" name="GetQuoteAlternativeRequest" message="tns:GetQuoteAlternativeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteAlternativeResponse" name="GetQuoteAlternativeResponse" message="tns:GetQuoteAlternativeResponse" />
    </wsdl:operation>
    <wsdl:operation name="RecalculateQuoteAlternative">
      <wsdl:documentation>
        <summary>When the user changes one or more values in a quoteline or a quoteAlternative, the connector gets to change the QuoteLines and the alternative, for instance calculate VAT. RecalculateQuoteAlternative shall be called when the user changes any of the following fields: Quantity, DiscountAmount, DiscountPercent, listprice (if allowed). RecalculateQuoteAlternative will calculate the TotalPrice and the VAT (if possible) for the lines and the alternative.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RecalculateQuoteAlternative" name="RecalculateQuoteAlternativeRequest" message="tns:RecalculateQuoteAlternativeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RecalculateQuoteAlternativeResponse" name="RecalculateQuoteAlternativeResponse" message="tns:RecalculateQuoteAlternativeResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteAlternatives">
      <wsdl:documentation>
        <summary>Get all quote alternatives for a quote version</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteAlternatives" name="GetQuoteAlternativesRequest" message="tns:GetQuoteAlternativesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteAlternativesResponse" name="GetQuoteAlternativesResponse" message="tns:GetQuoteAlternativesResponse" />
    </wsdl:operation>
    <wsdl:operation name="MoveQuoteLine">
      <wsdl:documentation>
        <summary>Move quote line rank up/down</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/MoveQuoteLine" name="MoveQuoteLineRequest" message="tns:MoveQuoteLineRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/MoveQuoteLineResponse" name="MoveQuoteLineResponse" message="tns:MoveQuoteLineResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateQuoteAlternative">
      <wsdl:documentation>
        <summary>Create a new quote alternative on a version.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateQuoteAlternative" name="CreateQuoteAlternativeRequest" message="tns:CreateQuoteAlternativeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateQuoteAlternativeResponse" name="CreateQuoteAlternativeResponse" message="tns:CreateQuoteAlternativeResponse" />
    </wsdl:operation>
    <wsdl:operation name="CopyQuoteAlternative">
      <wsdl:documentation>
        <summary>Copy a quote alternative from the same sale and adds it to a version.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CopyQuoteAlternative" name="CopyQuoteAlternativeRequest" message="tns:CopyQuoteAlternativeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CopyQuoteAlternativeResponse" name="CopyQuoteAlternativeResponse" message="tns:CopyQuoteAlternativeResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteQuoteAlternative">
      <wsdl:documentation>
        <summary>Delete a quote alternative</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteQuoteAlternative" name="DeleteQuoteAlternativeRequest" message="tns:DeleteQuoteAlternativeRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteQuoteAlternativeResponse" name="DeleteQuoteAlternativeResponse" message="tns:DeleteQuoteAlternativeResponse" />
    </wsdl:operation>
    <wsdl:operation name="HasConnections">
      <wsdl:documentation>
        <summary>Whether or not the system has any connections available for this user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/HasConnections" name="HasConnectionsRequest" message="tns:HasConnectionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/HasConnectionsResponse" name="HasConnectionsResponse" message="tns:HasConnectionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllInstalledQuoteConnections">
      <wsdl:documentation>
        <summary>Get all installed connections. Some installed connections may not be available to the user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllInstalledQuoteConnections" name="GetAllInstalledQuoteConnectionsRequest" message="tns:GetAllInstalledQuoteConnectionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllInstalledQuoteConnectionsResponse" name="GetAllInstalledQuoteConnectionsResponse" message="tns:GetAllInstalledQuoteConnectionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllAvailableQuoteConnections">
      <wsdl:documentation>
        <summary>Get all available connections. Some installed connections may not be available to the user. Use GetAllAvailableQuoteConnectionsWithPriceLists if you need the pricelists on the connections as well.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllAvailableQuoteConnections" name="GetAllAvailableQuoteConnectionsRequest" message="tns:GetAllAvailableQuoteConnectionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllAvailableQuoteConnectionsResponse" name="GetAllAvailableQuoteConnectionsResponse" message="tns:GetAllAvailableQuoteConnectionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllAvailableQuoteConnectionsWithPriceLists">
      <wsdl:documentation>
        <summary>Get all available connections. Some installed connections may not be available to the user. Includes pricelists for the connection. This is a heavy call</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllAvailableQuoteConnectionsWithPriceLists" name="GetAllAvailableQuoteConnectionsWithPriceListsRequest" message="tns:GetAllAvailableQuoteConnectionsWithPriceListsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllAvailableQuoteConnectionsWithPriceListsResponse" name="GetAllAvailableQuoteConnectionsWithPriceListsResponse" message="tns:GetAllAvailableQuoteConnectionsWithPriceListsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateConnectionFromConnectorName">
      <wsdl:documentation>
        <summary>Create a new connection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateConnectionFromConnectorName" name="CreateConnectionFromConnectorNameRequest" message="tns:CreateConnectionFromConnectorNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateConnectionFromConnectorNameResponse" name="CreateConnectionFromConnectorNameResponse" message="tns:CreateConnectionFromConnectorNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConnection">
      <wsdl:documentation>
        <summary>Returns the specified connection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnection" name="GetConnectionRequest" message="tns:GetConnectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectionResponse" name="GetConnectionResponse" message="tns:GetConnectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveConnection">
      <wsdl:documentation>
        <summary>Saves a connection to the database.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveConnection" name="SaveConnectionRequest" message="tns:SaveConnectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveConnectionResponse" name="SaveConnectionResponse" message="tns:SaveConnectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteConnection">
      <wsdl:documentation>
        <summary>Marks a connection as deleted.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteConnection" name="DeleteConnectionRequest" message="tns:DeleteConnectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteConnectionResponse" name="DeleteConnectionResponse" message="tns:DeleteConnectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="RestoreConnection">
      <wsdl:documentation>
        <summary>Restores a connection marked as deleted.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RestoreConnection" name="RestoreConnectionRequest" message="tns:RestoreConnectionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RestoreConnectionResponse" name="RestoreConnectionResponse" message="tns:RestoreConnectionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConnectionsForAssociate">
      <wsdl:documentation>
        <summary>Returns all connections available for the specified user.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectionsForAssociate" name="GetConnectionsForAssociateRequest" message="tns:GetConnectionsForAssociateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectionsForAssociateResponse" name="GetConnectionsForAssociateResponse" message="tns:GetConnectionsForAssociateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetActivePriceLists">
      <wsdl:documentation>
        <summary>Gets the available active PriceLists in a specific currency. Will return empty array if there is no PriceList with the stated currency available.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetActivePriceLists" name="GetActivePriceListsRequest" message="tns:GetActivePriceListsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetActivePriceListsResponse" name="GetActivePriceListsResponse" message="tns:GetActivePriceListsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetActivePriceListsByCurrencyId">
      <wsdl:documentation>
        <summary>Gets the available active PriceLists in a specific currency. Will return empty array if there is no PriceList with the stated currency available.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetActivePriceListsByCurrencyId" name="GetActivePriceListsByCurrencyIdRequest" message="tns:GetActivePriceListsByCurrencyIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetActivePriceListsByCurrencyIdResponse" name="GetActivePriceListsByCurrencyIdResponse" message="tns:GetActivePriceListsByCurrencyIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllPriceLists">
      <wsdl:documentation>
        <summary>Gets the all PriceLists in all currencies, including those inactive. Will return empty array if there is no PriceList available.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllPriceLists" name="GetAllPriceListsRequest" message="tns:GetAllPriceListsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllPriceListsResponse" name="GetAllPriceListsResponse" message="tns:GetAllPriceListsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllPriceListsByCurrencyId">
      <wsdl:documentation>
        <summary>Gets the all PriceLists in all currencies, including those inactive. Will return empty array if there is no PriceList available.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllPriceListsByCurrencyId" name="GetAllPriceListsByCurrencyIdRequest" message="tns:GetAllPriceListsByCurrencyIdRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllPriceListsByCurrencyIdResponse" name="GetAllPriceListsByCurrencyIdResponse" message="tns:GetAllPriceListsByCurrencyIdResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConnectorCapabilityNames">
      <wsdl:documentation>
        <summary>Gets a list of all possible connector capabilities</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectorCapabilityNames" name="GetConnectorCapabilityNamesRequest" message="tns:GetConnectorCapabilityNamesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectorCapabilityNamesResponse" name="GetConnectorCapabilityNamesResponse" message="tns:GetConnectorCapabilityNamesResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConnectorCapabilities">
      <wsdl:documentation>
        <summary>Gets a list of connector capabilities</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectorCapabilities" name="GetConnectorCapabilitiesRequest" message="tns:GetConnectorCapabilitiesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectorCapabilitiesResponse" name="GetConnectorCapabilitiesResponse" message="tns:GetConnectorCapabilitiesResponse" />
    </wsdl:operation>
    <wsdl:operation name="CanConnectorProvideCapability">
      <wsdl:documentation>
        <summary>Can the connector provide the capability</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CanConnectorProvideCapability" name="CanConnectorProvideCapabilityRequest" message="tns:CanConnectorProvideCapabilityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CanConnectorProvideCapabilityResponse" name="CanConnectorProvideCapabilityResponse" message="tns:CanConnectorProvideCapabilityResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConnectionStartupErrors">
      <wsdl:documentation>
        <summary>Returns an array of PluginResponseInfos for all failed connection initializations.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectionStartupErrors" name="GetConnectionStartupErrorsRequest" message="tns:GetConnectionStartupErrorsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectionStartupErrorsResponse" name="GetConnectionStartupErrorsResponse" message="tns:GetConnectionStartupErrorsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConnectionStartupResponse">
      <wsdl:documentation>
        <summary>Returns the PluginResponseInfo for the connection initialization. Does not initialize the connection, just returns what happened when initialize was called.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectionStartupResponse" name="GetConnectionStartupResponseRequest" message="tns:GetConnectionStartupResponseRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectionStartupResponseResponse" name="GetConnectionStartupResponseResponse" message="tns:GetConnectionStartupResponseResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetConnectionConfigFields">
      <wsdl:documentation>
        <summary>Returns the config fields for the connection.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectionConfigFields" name="GetConnectionConfigFieldsRequest" message="tns:GetConnectionConfigFieldsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectionConfigFieldsResponse" name="GetConnectionConfigFieldsResponse" message="tns:GetConnectionConfigFieldsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveConnectionConfigFields">
      <wsdl:documentation>
        <summary>Saves the connection config fields</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveConnectionConfigFields" name="SaveConnectionConfigFieldsRequest" message="tns:SaveConnectionConfigFieldsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveConnectionConfigFieldsResponse" name="SaveConnectionConfigFieldsResponse" message="tns:SaveConnectionConfigFieldsResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateQuoteLine">
      <wsdl:documentation>
        <summary>Create a quoteline based on a product key.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateQuoteLine" name="CreateQuoteLineRequest" message="tns:CreateQuoteLineRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateQuoteLineResponse" name="CreateQuoteLineResponse" message="tns:CreateQuoteLineResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateQuoteLineFromProduct">
      <wsdl:documentation>
        <summary>Create a quoteline based on a product.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateQuoteLineFromProduct" name="CreateQuoteLineFromProductRequest" message="tns:CreateQuoteLineFromProductRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateQuoteLineFromProductResponse" name="CreateQuoteLineFromProductResponse" message="tns:CreateQuoteLineFromProductResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteLine">
      <wsdl:documentation>
        <summary>Saves the QuoteLine in the SuperOffice database</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteLine" name="SaveQuoteLineRequest" message="tns:SaveQuoteLineRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteLineResponse" name="SaveQuoteLineResponse" message="tns:SaveQuoteLineResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteLine">
      <wsdl:documentation>
        <summary>Get QuoteLine from database</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLine" name="GetQuoteLineRequest" message="tns:GetQuoteLineRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLineResponse" name="GetQuoteLineResponse" message="tns:GetQuoteLineResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteLines">
      <wsdl:documentation>
        <summary>Get all QuoteLines from an alternative</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLines" name="GetQuoteLinesRequest" message="tns:GetQuoteLinesRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLinesResponse" name="GetQuoteLinesResponse" message="tns:GetQuoteLinesResponse" />
    </wsdl:operation>
    <wsdl:operation name="DeleteQuoteLine">
      <wsdl:documentation>
        <summary>Deletes the QuoteLine in the SuperOffice database</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteQuoteLine" name="DeleteQuoteLineRequest" message="tns:DeleteQuoteLineRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteQuoteLineResponse" name="DeleteQuoteLineResponse" message="tns:DeleteQuoteLineResponse" />
    </wsdl:operation>
    <wsdl:operation name="RecalculateQuoteLine">
      <wsdl:documentation>
        <summary>When the user changes one or more values in a quoteline, the connector gets to change the QuoteLine, for instance calculate VAT. Shall be called when the user changes any of the following fields: Quantity, DiscountAmount, DiscountPercent, ListPrice (if allowed). Will calculate the TotalPrice and the VAT (if possible) for the line.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RecalculateQuoteLine" name="RecalculateQuoteLineRequest" message="tns:RecalculateQuoteLineRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RecalculateQuoteLineResponse" name="RecalculateQuoteLineResponse" message="tns:RecalculateQuoteLineResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteLineImage">
      <wsdl:documentation>
        <summary>Gets an image connected to a quoteline, either from the ERPProvider or from the SuperOffice database</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLineImage" name="GetQuoteLineImageRequest" message="tns:GetQuoteLineImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLineImageResponse" name="GetQuoteLineImageResponse" message="tns:GetQuoteLineImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteLineImage">
      <wsdl:documentation>
        <summary>Saves the image connected to a quoteline in the SuperOffice database</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteLineImage" name="SaveQuoteLineImageRequest" message="tns:SaveQuoteLineImageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteLineImageResponse" name="SaveQuoteLineImageResponse" message="tns:SaveQuoteLineImageResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetExtraInfo">
      <wsdl:documentation>
        <summary>Converts an xml string into an object representation.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetExtraInfo" name="GetExtraInfoRequest" message="tns:GetExtraInfoRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetExtraInfoResponse" name="GetExtraInfoResponse" message="tns:GetExtraInfoResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteLineConfiguration">
      <wsdl:documentation>
        <summary>Returns the configuration field with the given id</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLineConfiguration" name="GetQuoteLineConfigurationRequest" message="tns:GetQuoteLineConfigurationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLineConfigurationResponse" name="GetQuoteLineConfigurationResponse" message="tns:GetQuoteLineConfigurationResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteLineConfigurationFromFieldName">
      <wsdl:documentation>
        <summary>Returns the configuration field with the given field name</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLineConfigurationFromFieldName" name="GetQuoteLineConfigurationFromFieldNameRequest" message="tns:GetQuoteLineConfigurationFromFieldNameRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLineConfigurationFromFieldNameResponse" name="GetQuoteLineConfigurationFromFieldNameResponse" message="tns:GetQuoteLineConfigurationFromFieldNameResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetAllQuoteLineConfigurations">
      <wsdl:documentation>
        <summary>Returns all the configuration fields</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllQuoteLineConfigurations" name="GetAllQuoteLineConfigurationsRequest" message="tns:GetAllQuoteLineConfigurationsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllQuoteLineConfigurationsResponse" name="GetAllQuoteLineConfigurationsResponse" message="tns:GetAllQuoteLineConfigurationsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetInUseQuoteLineConfigurations">
      <wsdl:documentation>
        <summary>Returns the configuration fields that should be visible in the GUI.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetInUseQuoteLineConfigurations" name="GetInUseQuoteLineConfigurationsRequest" message="tns:GetInUseQuoteLineConfigurationsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetInUseQuoteLineConfigurationsResponse" name="GetInUseQuoteLineConfigurationsResponse" message="tns:GetInUseQuoteLineConfigurationsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteLineConfiguration">
      <wsdl:documentation>
        <summary>Save a QuoteLineConfiguration object. It is not possible to add a new configuration.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteLineConfiguration" name="SaveQuoteLineConfigurationRequest" message="tns:SaveQuoteLineConfigurationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteLineConfigurationResponse" name="SaveQuoteLineConfigurationResponse" message="tns:SaveQuoteLineConfigurationResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteLineConfigurations">
      <wsdl:documentation>
        <summary>Save a collection of QuoteLineConfigurations. It is not possible to add a new configurations.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteLineConfigurations" name="SaveQuoteLineConfigurationsRequest" message="tns:SaveQuoteLineConfigurationsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteLineConfigurationsResponse" name="SaveQuoteLineConfigurationsResponse" message="tns:SaveQuoteLineConfigurationsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteList">
      <wsdl:documentation>
        <summary>Gets a named list from the connector Return array of QuoteListItems. Return NULL if the given list is not supported.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteList" name="GetQuoteListRequest" message="tns:GetQuoteListRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteListResponse" name="GetQuoteListResponse" message="tns:GetQuoteListResponse" />
    </wsdl:operation>
    <wsdl:operation name="ValidateQuoteVersion">
      <wsdl:documentation>
        <summary>When the user changes one or more values in a quoteline or a quoteAlternative, the connector gets to change the QuoteLines and the alternative, for instance calculate VAT. ValidateQuoteVersion shall be called when the user presses the validate button, presses the send button or closes the quote dialog. RecalculateQuoteAlternative should typically validate all alternatives, set values in extrafields, and set the state in the version.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ValidateQuoteVersion" name="ValidateQuoteVersionRequest" message="tns:ValidateQuoteVersionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ValidateQuoteVersionResponse" name="ValidateQuoteVersionResponse" message="tns:ValidateQuoteVersionResponse" />
    </wsdl:operation>
    <wsdl:operation name="CreateAndSaveQuoteVersion">
      <wsdl:documentation>
        <summary>Created a new QuoteVersion based on another QuoteVersion on the same Quote.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateAndSaveQuoteVersion" name="CreateAndSaveQuoteVersionRequest" message="tns:CreateAndSaveQuoteVersionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateAndSaveQuoteVersionResponse" name="CreateAndSaveQuoteVersionResponse" message="tns:CreateAndSaveQuoteVersionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteVersion">
      <wsdl:documentation>
        <summary>Get a QuoteVersion</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersion" name="GetQuoteVersionRequest" message="tns:GetQuoteVersionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersionResponse" name="GetQuoteVersionResponse" message="tns:GetQuoteVersionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteVersions">
      <wsdl:documentation>
        <summary>Get all quote versions for a sale</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersions" name="GetQuoteVersionsRequest" message="tns:GetQuoteVersionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersionsResponse" name="GetQuoteVersionsResponse" message="tns:GetQuoteVersionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="SendQuoteVersion">
      <wsdl:documentation>
        <summary>Send the quote to the user's customer. More parameters to be added later...</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SendQuoteVersion" name="SendQuoteVersionRequest" message="tns:SendQuoteVersionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SendQuoteVersionResponse" name="SendQuoteVersionResponse" message="tns:SendQuoteVersionResponse" />
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteVersion">
      <wsdl:documentation>
        <summary>Saves a quote version</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteVersion" name="SaveQuoteVersionRequest" message="tns:SaveQuoteVersionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteVersionResponse" name="SaveQuoteVersionResponse" message="tns:SaveQuoteVersionResponse" />
    </wsdl:operation>
    <wsdl:operation name="ApproveQuoteVersion">
      <wsdl:documentation>
        <summary>Approves a quote version</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ApproveQuoteVersion" name="ApproveQuoteVersionRequest" message="tns:ApproveQuoteVersionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ApproveQuoteVersionResponse" name="ApproveQuoteVersionResponse" message="tns:ApproveQuoteVersionResponse" />
    </wsdl:operation>
    <wsdl:operation name="RejectQuoteVersion">
      <wsdl:documentation>
        <summary>Rejects a quote version</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RejectQuoteVersion" name="RejectQuoteVersionRequest" message="tns:RejectQuoteVersionRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RejectQuoteVersionResponse" name="RejectQuoteVersionResponse" message="tns:RejectQuoteVersionResponse" />
    </wsdl:operation>
    <wsdl:operation name="GenerateQuoteDocuments">
      <wsdl:documentation>
        <summary>Generate all the documents required to send the Quote as an email to the prospect - or an Order Confirmation; it just depends on the template id's for the lines doc and mail body. Quote version status is not changed by this method.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GenerateQuoteDocuments" name="GenerateQuoteDocumentsRequest" message="tns:GenerateQuoteDocumentsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GenerateQuoteDocumentsResponse" name="GenerateQuoteDocumentsResponse" message="tns:GenerateQuoteDocumentsResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetOrderConfirmation">
      <wsdl:documentation>
        <summary>Get a base64-encoded data stream that is just the order confirmation document, for the given quote version; no permanent document is created or stored anywhere; the result is a PDF</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetOrderConfirmation" name="GetOrderConfirmationRequest" message="tns:GetOrderConfirmationRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetOrderConfirmationResponse" name="GetOrderConfirmationResponse" message="tns:GetOrderConfirmationResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetQuoteVersionWorkflowState">
      <wsdl:documentation>
        <summary>Get all button states for the Quote version dialog. Packages ImageState, Button states and status info into one call. Collects most important warnings/errors from across all quotelines/alternatives in this quote version.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersionWorkflowState" name="GetQuoteVersionWorkflowStateRequest" message="tns:GetQuoteVersionWorkflowStateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersionWorkflowStateResponse" name="GetQuoteVersionWorkflowStateResponse" message="tns:GetQuoteVersionWorkflowStateResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_Quote" type="tns:Quote">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="UpdateQuoteVersionPrices">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/UpdateQuoteVersionPrices" style="document" />
      <wsdl:input name="UpdateQuoteVersionPricesRequest">
        <soap:header message="tns:UpdateQuoteVersionPricesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:UpdateQuoteVersionPricesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:UpdateQuoteVersionPricesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="UpdateQuoteVersionPricesResponse">
        <soap:header message="tns:UpdateQuoteVersionPricesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:UpdateQuoteVersionPricesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:UpdateQuoteVersionPricesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:UpdateQuoteVersionPricesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteVersionNumber">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteVersionNumber" style="document" />
      <wsdl:input name="SaveQuoteVersionNumberRequest">
        <soap:header message="tns:SaveQuoteVersionNumberRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveQuoteVersionNumberRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveQuoteVersionNumberRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveQuoteVersionNumberResponse">
        <soap:header message="tns:SaveQuoteVersionNumberResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveQuoteVersionNumberResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveQuoteVersionNumberResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveQuoteVersionNumberResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteVersionWorkflowImageState">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersionWorkflowImageState" style="document" />
      <wsdl:input name="GetQuoteVersionWorkflowImageStateRequest">
        <soap:header message="tns:GetQuoteVersionWorkflowImageStateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowImageStateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowImageStateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteVersionWorkflowImageStateResponse">
        <soap:header message="tns:GetQuoteVersionWorkflowImageStateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowImageStateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowImageStateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowImageStateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteVersionWorkflowButtonStates">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersionWorkflowButtonStates" style="document" />
      <wsdl:input name="GetQuoteVersionWorkflowButtonStatesRequest">
        <soap:header message="tns:GetQuoteVersionWorkflowButtonStatesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowButtonStatesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowButtonStatesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteVersionWorkflowButtonStatesResponse">
        <soap:header message="tns:GetQuoteVersionWorkflowButtonStatesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowButtonStatesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowButtonStatesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowButtonStatesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteVersionWorkflowStatusInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersionWorkflowStatusInfo" style="document" />
      <wsdl:input name="GetQuoteVersionWorkflowStatusInfoRequest">
        <soap:header message="tns:GetQuoteVersionWorkflowStatusInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowStatusInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowStatusInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteVersionWorkflowStatusInfoResponse">
        <soap:header message="tns:GetQuoteVersionWorkflowStatusInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowStatusInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowStatusInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowStatusInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateOrUpdateQuoteVersionAttachments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateOrUpdateQuoteVersionAttachments" style="document" />
      <wsdl:input name="CreateOrUpdateQuoteVersionAttachmentsRequest">
        <soap:header message="tns:CreateOrUpdateQuoteVersionAttachmentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateOrUpdateQuoteVersionAttachmentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateOrUpdateQuoteVersionAttachmentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateOrUpdateQuoteVersionAttachmentsResponse">
        <soap:header message="tns:CreateOrUpdateQuoteVersionAttachmentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateOrUpdateQuoteVersionAttachmentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateOrUpdateQuoteVersionAttachmentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateOrUpdateQuoteVersionAttachmentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="IncludeQuoteVersionAttachment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/IncludeQuoteVersionAttachment" style="document" />
      <wsdl:input name="IncludeQuoteVersionAttachmentRequest">
        <soap:header message="tns:IncludeQuoteVersionAttachmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:IncludeQuoteVersionAttachmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:IncludeQuoteVersionAttachmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="IncludeQuoteVersionAttachmentResponse">
        <soap:header message="tns:IncludeQuoteVersionAttachmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:IncludeQuoteVersionAttachmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:IncludeQuoteVersionAttachmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:IncludeQuoteVersionAttachmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleSaleTypeQuoteAttachmentDefaultIncluded">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ToggleSaleTypeQuoteAttachmentDefaultIncluded" style="document" />
      <wsdl:input name="ToggleSaleTypeQuoteAttachmentDefaultIncludedRequest">
        <soap:header message="tns:ToggleSaleTypeQuoteAttachmentDefaultIncludedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleSaleTypeQuoteAttachmentDefaultIncludedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleSaleTypeQuoteAttachmentDefaultIncludedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleSaleTypeQuoteAttachmentDefaultIncludedResponse">
        <soap:header message="tns:ToggleSaleTypeQuoteAttachmentDefaultIncludedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleSaleTypeQuoteAttachmentDefaultIncludedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleSaleTypeQuoteAttachmentDefaultIncludedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleSaleTypeQuoteAttachmentDefaultIncludedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="AddSaleTypeQuoteAttachment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/AddSaleTypeQuoteAttachment" style="document" />
      <wsdl:input name="AddSaleTypeQuoteAttachmentRequest">
        <soap:header message="tns:AddSaleTypeQuoteAttachmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:AddSaleTypeQuoteAttachmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:AddSaleTypeQuoteAttachmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="AddSaleTypeQuoteAttachmentResponse">
        <soap:header message="tns:AddSaleTypeQuoteAttachmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:AddSaleTypeQuoteAttachmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:AddSaleTypeQuoteAttachmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:AddSaleTypeQuoteAttachmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteSaleTypeQuoteAttachment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteSaleTypeQuoteAttachment" style="document" />
      <wsdl:input name="DeleteSaleTypeQuoteAttachmentRequest">
        <soap:header message="tns:DeleteSaleTypeQuoteAttachmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteSaleTypeQuoteAttachmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteSaleTypeQuoteAttachmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteSaleTypeQuoteAttachmentResponse">
        <soap:header message="tns:DeleteSaleTypeQuoteAttachmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteSaleTypeQuoteAttachmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteSaleTypeQuoteAttachmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteSaleTypeQuoteAttachmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleQuoteVersionAttachmentIncluded">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ToggleQuoteVersionAttachmentIncluded" style="document" />
      <wsdl:input name="ToggleQuoteVersionAttachmentIncludedRequest">
        <soap:header message="tns:ToggleQuoteVersionAttachmentIncludedRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleQuoteVersionAttachmentIncludedRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleQuoteVersionAttachmentIncludedRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleQuoteVersionAttachmentIncludedResponse">
        <soap:header message="tns:ToggleQuoteVersionAttachmentIncludedResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleQuoteVersionAttachmentIncludedResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleQuoteVersionAttachmentIncludedResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleQuoteVersionAttachmentIncludedResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultPriceList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateDefaultPriceList" style="document" />
      <wsdl:input name="CreateDefaultPriceListRequest">
        <soap:header message="tns:CreateDefaultPriceListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultPriceListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultPriceListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultPriceListResponse">
        <soap:header message="tns:CreateDefaultPriceListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultPriceListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultPriceListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultPriceListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SavePriceList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SavePriceList" style="document" />
      <wsdl:input name="SavePriceListRequest">
        <soap:header message="tns:SavePriceListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SavePriceListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SavePriceListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SavePriceListResponse">
        <soap:header message="tns:SavePriceListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SavePriceListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SavePriceListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SavePriceListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeletePriceList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeletePriceList" style="document" />
      <wsdl:input name="DeletePriceListRequest">
        <soap:header message="tns:DeletePriceListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeletePriceListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeletePriceListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeletePriceListResponse">
        <soap:header message="tns:DeletePriceListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeletePriceListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeletePriceListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeletePriceListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultProduct">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateDefaultProduct" style="document" />
      <wsdl:input name="CreateDefaultProductRequest">
        <soap:header message="tns:CreateDefaultProductRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultProductRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultProductRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultProductResponse">
        <soap:header message="tns:CreateDefaultProductResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultProductResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultProductResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultProductResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveProduct">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveProduct" style="document" />
      <wsdl:input name="SaveProductRequest">
        <soap:header message="tns:SaveProductRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveProductRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveProductRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveProductResponse">
        <soap:header message="tns:SaveProductResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveProductResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveProductResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveProductResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteProduct">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteProduct" style="document" />
      <wsdl:input name="DeleteProductRequest">
        <soap:header message="tns:DeleteProductRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteProductRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteProductRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteProductResponse">
        <soap:header message="tns:DeleteProductResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteProductResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteProductResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteProductResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateDefaultQuoteAlternative">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateDefaultQuoteAlternative" style="document" />
      <wsdl:input name="CreateDefaultQuoteAlternativeRequest">
        <soap:header message="tns:CreateDefaultQuoteAlternativeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateDefaultQuoteAlternativeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateDefaultQuoteAlternativeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateDefaultQuoteAlternativeResponse">
        <soap:header message="tns:CreateDefaultQuoteAlternativeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateDefaultQuoteAlternativeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateDefaultQuoteAlternativeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateDefaultQuoteAlternativeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteAlternative">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteAlternative" style="document" />
      <wsdl:input name="SaveQuoteAlternativeRequest">
        <soap:header message="tns:SaveQuoteAlternativeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveQuoteAlternativeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveQuoteAlternativeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveQuoteAlternativeResponse">
        <soap:header message="tns:SaveQuoteAlternativeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveQuoteAlternativeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveQuoteAlternativeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveQuoteAlternativeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConfigurationFields">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConfigurationFields" style="document" />
      <wsdl:input name="GetConfigurationFieldsRequest">
        <soap:header message="tns:GetConfigurationFieldsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConfigurationFieldsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConfigurationFieldsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConfigurationFieldsResponse">
        <soap:header message="tns:GetConfigurationFieldsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConfigurationFieldsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConfigurationFieldsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConfigurationFieldsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TestConnection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/TestConnection" style="document" />
      <wsdl:input name="TestConnectionRequest">
        <soap:header message="tns:TestConnectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TestConnectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TestConnectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TestConnectionResponse">
        <soap:header message="tns:TestConnectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TestConnectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TestConnectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TestConnectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetPriceList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetPriceList" style="document" />
      <wsdl:input name="GetPriceListRequest">
        <soap:header message="tns:GetPriceListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetPriceListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetPriceListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetPriceListResponse">
        <soap:header message="tns:GetPriceListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetPriceListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetPriceListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetPriceListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CopySuperOfficePriceList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CopySuperOfficePriceList" style="document" />
      <wsdl:input name="CopySuperOfficePriceListRequest">
        <soap:header message="tns:CopySuperOfficePriceListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CopySuperOfficePriceListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CopySuperOfficePriceListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CopySuperOfficePriceListResponse">
        <soap:header message="tns:CopySuperOfficePriceListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CopySuperOfficePriceListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CopySuperOfficePriceListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CopySuperOfficePriceListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProductImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetProductImage" style="document" />
      <wsdl:input name="GetProductImageRequest">
        <soap:header message="tns:GetProductImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProductImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProductImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProductImageResponse">
        <soap:header message="tns:GetProductImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProductImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProductImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProductImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="FindProduct">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/FindProduct" style="document" />
      <wsdl:input name="FindProductRequest">
        <soap:header message="tns:FindProductRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:FindProductRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:FindProductRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="FindProductResponse">
        <soap:header message="tns:FindProductResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:FindProductResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:FindProductResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:FindProductResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProduct">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetProduct" style="document" />
      <wsdl:input name="GetProductRequest">
        <soap:header message="tns:GetProductRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProductRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProductRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProductResponse">
        <soap:header message="tns:GetProductResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProductResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProductResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProductResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetProductFromDbId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetProductFromDbId" style="document" />
      <wsdl:input name="GetProductFromDbIdRequest">
        <soap:header message="tns:GetProductFromDbIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetProductFromDbIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetProductFromDbIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetProductFromDbIdResponse">
        <soap:header message="tns:GetProductFromDbIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetProductFromDbIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetProductFromDbIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetProductFromDbIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RemoveProduct">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RemoveProduct" style="document" />
      <wsdl:input name="RemoveProductRequest">
        <soap:header message="tns:RemoveProductRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RemoveProductRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RemoveProductRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RemoveProductResponse">
        <soap:header message="tns:RemoveProductResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RemoveProductResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RemoveProductResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RemoveProductResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ToggleProductInAssortment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ToggleProductInAssortment" style="document" />
      <wsdl:input name="ToggleProductInAssortmentRequest">
        <soap:header message="tns:ToggleProductInAssortmentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ToggleProductInAssortmentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ToggleProductInAssortmentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ToggleProductInAssortmentResponse">
        <soap:header message="tns:ToggleProductInAssortmentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ToggleProductInAssortmentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ToggleProductInAssortmentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ToggleProductInAssortmentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveQuote">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuote" style="document" />
      <wsdl:input name="SaveQuoteRequest">
        <soap:header message="tns:SaveQuoteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveQuoteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveQuoteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveQuoteResponse">
        <soap:header message="tns:SaveQuoteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveQuoteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveQuoteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveQuoteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuote">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuote" style="document" />
      <wsdl:input name="GetQuoteRequest">
        <soap:header message="tns:GetQuoteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteResponse">
        <soap:header message="tns:GetQuoteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteFromSaleId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteFromSaleId" style="document" />
      <wsdl:input name="GetQuoteFromSaleIdRequest">
        <soap:header message="tns:GetQuoteFromSaleIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteFromSaleIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteFromSaleIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteFromSaleIdResponse">
        <soap:header message="tns:GetQuoteFromSaleIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteFromSaleIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteFromSaleIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteFromSaleIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateAndSaveQuote">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateAndSaveQuote" style="document" />
      <wsdl:input name="CreateAndSaveQuoteRequest">
        <soap:header message="tns:CreateAndSaveQuoteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateAndSaveQuoteResponse">
        <soap:header message="tns:CreateAndSaveQuoteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteEntity" style="document" />
      <wsdl:input name="GetQuoteEntityRequest">
        <soap:header message="tns:GetQuoteEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteEntityResponse">
        <soap:header message="tns:GetQuoteEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteEntityFromSaleId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteEntityFromSaleId" style="document" />
      <wsdl:input name="GetQuoteEntityFromSaleIdRequest">
        <soap:header message="tns:GetQuoteEntityFromSaleIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteEntityFromSaleIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteEntityFromSaleIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteEntityFromSaleIdResponse">
        <soap:header message="tns:GetQuoteEntityFromSaleIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteEntityFromSaleIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteEntityFromSaleIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteEntityFromSaleIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteEntity" style="document" />
      <wsdl:input name="SaveQuoteEntityRequest">
        <soap:header message="tns:SaveQuoteEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveQuoteEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveQuoteEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveQuoteEntityResponse">
        <soap:header message="tns:SaveQuoteEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveQuoteEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveQuoteEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveQuoteEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateAndSaveQuoteFromSale">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateAndSaveQuoteFromSale" style="document" />
      <wsdl:input name="CreateAndSaveQuoteFromSaleRequest">
        <soap:header message="tns:CreateAndSaveQuoteFromSaleRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteFromSaleRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteFromSaleRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateAndSaveQuoteFromSaleResponse">
        <soap:header message="tns:CreateAndSaveQuoteFromSaleResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteFromSaleResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteFromSaleResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteFromSaleResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="PlaceOrder">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/PlaceOrder" style="document" />
      <wsdl:input name="PlaceOrderRequest">
        <soap:header message="tns:PlaceOrderRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:PlaceOrderRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:PlaceOrderRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="PlaceOrderResponse">
        <soap:header message="tns:PlaceOrderResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:PlaceOrderResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:PlaceOrderResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:PlaceOrderResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetOrderState">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetOrderState" style="document" />
      <wsdl:input name="GetOrderStateRequest">
        <soap:header message="tns:GetOrderStateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetOrderStateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetOrderStateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetOrderStateResponse">
        <soap:header message="tns:GetOrderStateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetOrderStateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetOrderStateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetOrderStateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteQuote">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteQuote" style="document" />
      <wsdl:input name="DeleteQuoteRequest">
        <soap:header message="tns:DeleteQuoteRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteQuoteRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteQuoteRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteQuoteResponse">
        <soap:header message="tns:DeleteQuoteResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteQuoteResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteQuoteResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteQuoteResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteAlternative">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteAlternative" style="document" />
      <wsdl:input name="GetQuoteAlternativeRequest">
        <soap:header message="tns:GetQuoteAlternativeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteAlternativeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteAlternativeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteAlternativeResponse">
        <soap:header message="tns:GetQuoteAlternativeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteAlternativeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteAlternativeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteAlternativeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RecalculateQuoteAlternative">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RecalculateQuoteAlternative" style="document" />
      <wsdl:input name="RecalculateQuoteAlternativeRequest">
        <soap:header message="tns:RecalculateQuoteAlternativeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RecalculateQuoteAlternativeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RecalculateQuoteAlternativeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RecalculateQuoteAlternativeResponse">
        <soap:header message="tns:RecalculateQuoteAlternativeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RecalculateQuoteAlternativeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RecalculateQuoteAlternativeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RecalculateQuoteAlternativeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteAlternatives">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteAlternatives" style="document" />
      <wsdl:input name="GetQuoteAlternativesRequest">
        <soap:header message="tns:GetQuoteAlternativesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteAlternativesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteAlternativesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteAlternativesResponse">
        <soap:header message="tns:GetQuoteAlternativesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteAlternativesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteAlternativesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteAlternativesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="MoveQuoteLine">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/MoveQuoteLine" style="document" />
      <wsdl:input name="MoveQuoteLineRequest">
        <soap:header message="tns:MoveQuoteLineRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:MoveQuoteLineRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:MoveQuoteLineRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="MoveQuoteLineResponse">
        <soap:header message="tns:MoveQuoteLineResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:MoveQuoteLineResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:MoveQuoteLineResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:MoveQuoteLineResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateQuoteAlternative">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateQuoteAlternative" style="document" />
      <wsdl:input name="CreateQuoteAlternativeRequest">
        <soap:header message="tns:CreateQuoteAlternativeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateQuoteAlternativeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateQuoteAlternativeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateQuoteAlternativeResponse">
        <soap:header message="tns:CreateQuoteAlternativeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateQuoteAlternativeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateQuoteAlternativeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateQuoteAlternativeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CopyQuoteAlternative">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CopyQuoteAlternative" style="document" />
      <wsdl:input name="CopyQuoteAlternativeRequest">
        <soap:header message="tns:CopyQuoteAlternativeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CopyQuoteAlternativeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CopyQuoteAlternativeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CopyQuoteAlternativeResponse">
        <soap:header message="tns:CopyQuoteAlternativeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CopyQuoteAlternativeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CopyQuoteAlternativeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CopyQuoteAlternativeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteQuoteAlternative">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteQuoteAlternative" style="document" />
      <wsdl:input name="DeleteQuoteAlternativeRequest">
        <soap:header message="tns:DeleteQuoteAlternativeRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteQuoteAlternativeRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteQuoteAlternativeRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteQuoteAlternativeResponse">
        <soap:header message="tns:DeleteQuoteAlternativeResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteQuoteAlternativeResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteQuoteAlternativeResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteQuoteAlternativeResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="HasConnections">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/HasConnections" style="document" />
      <wsdl:input name="HasConnectionsRequest">
        <soap:header message="tns:HasConnectionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:HasConnectionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:HasConnectionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="HasConnectionsResponse">
        <soap:header message="tns:HasConnectionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:HasConnectionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:HasConnectionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:HasConnectionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllInstalledQuoteConnections">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllInstalledQuoteConnections" style="document" />
      <wsdl:input name="GetAllInstalledQuoteConnectionsRequest">
        <soap:header message="tns:GetAllInstalledQuoteConnectionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllInstalledQuoteConnectionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllInstalledQuoteConnectionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllInstalledQuoteConnectionsResponse">
        <soap:header message="tns:GetAllInstalledQuoteConnectionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllInstalledQuoteConnectionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllInstalledQuoteConnectionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllInstalledQuoteConnectionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllAvailableQuoteConnections">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllAvailableQuoteConnections" style="document" />
      <wsdl:input name="GetAllAvailableQuoteConnectionsRequest">
        <soap:header message="tns:GetAllAvailableQuoteConnectionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllAvailableQuoteConnectionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllAvailableQuoteConnectionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllAvailableQuoteConnectionsResponse">
        <soap:header message="tns:GetAllAvailableQuoteConnectionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllAvailableQuoteConnectionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllAvailableQuoteConnectionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllAvailableQuoteConnectionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllAvailableQuoteConnectionsWithPriceLists">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllAvailableQuoteConnectionsWithPriceLists" style="document" />
      <wsdl:input name="GetAllAvailableQuoteConnectionsWithPriceListsRequest">
        <soap:header message="tns:GetAllAvailableQuoteConnectionsWithPriceListsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllAvailableQuoteConnectionsWithPriceListsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllAvailableQuoteConnectionsWithPriceListsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllAvailableQuoteConnectionsWithPriceListsResponse">
        <soap:header message="tns:GetAllAvailableQuoteConnectionsWithPriceListsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllAvailableQuoteConnectionsWithPriceListsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllAvailableQuoteConnectionsWithPriceListsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllAvailableQuoteConnectionsWithPriceListsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateConnectionFromConnectorName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateConnectionFromConnectorName" style="document" />
      <wsdl:input name="CreateConnectionFromConnectorNameRequest">
        <soap:header message="tns:CreateConnectionFromConnectorNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateConnectionFromConnectorNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateConnectionFromConnectorNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateConnectionFromConnectorNameResponse">
        <soap:header message="tns:CreateConnectionFromConnectorNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateConnectionFromConnectorNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateConnectionFromConnectorNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateConnectionFromConnectorNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConnection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnection" style="document" />
      <wsdl:input name="GetConnectionRequest">
        <soap:header message="tns:GetConnectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConnectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConnectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConnectionResponse">
        <soap:header message="tns:GetConnectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConnectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConnectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConnectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveConnection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveConnection" style="document" />
      <wsdl:input name="SaveConnectionRequest">
        <soap:header message="tns:SaveConnectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveConnectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveConnectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveConnectionResponse">
        <soap:header message="tns:SaveConnectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveConnectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveConnectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveConnectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteConnection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteConnection" style="document" />
      <wsdl:input name="DeleteConnectionRequest">
        <soap:header message="tns:DeleteConnectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteConnectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteConnectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteConnectionResponse">
        <soap:header message="tns:DeleteConnectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteConnectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteConnectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteConnectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RestoreConnection">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RestoreConnection" style="document" />
      <wsdl:input name="RestoreConnectionRequest">
        <soap:header message="tns:RestoreConnectionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RestoreConnectionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RestoreConnectionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RestoreConnectionResponse">
        <soap:header message="tns:RestoreConnectionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RestoreConnectionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RestoreConnectionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RestoreConnectionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConnectionsForAssociate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectionsForAssociate" style="document" />
      <wsdl:input name="GetConnectionsForAssociateRequest">
        <soap:header message="tns:GetConnectionsForAssociateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConnectionsForAssociateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConnectionsForAssociateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConnectionsForAssociateResponse">
        <soap:header message="tns:GetConnectionsForAssociateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConnectionsForAssociateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConnectionsForAssociateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConnectionsForAssociateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetActivePriceLists">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetActivePriceLists" style="document" />
      <wsdl:input name="GetActivePriceListsRequest">
        <soap:header message="tns:GetActivePriceListsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetActivePriceListsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetActivePriceListsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetActivePriceListsResponse">
        <soap:header message="tns:GetActivePriceListsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetActivePriceListsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetActivePriceListsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetActivePriceListsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetActivePriceListsByCurrencyId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetActivePriceListsByCurrencyId" style="document" />
      <wsdl:input name="GetActivePriceListsByCurrencyIdRequest">
        <soap:header message="tns:GetActivePriceListsByCurrencyIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetActivePriceListsByCurrencyIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetActivePriceListsByCurrencyIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetActivePriceListsByCurrencyIdResponse">
        <soap:header message="tns:GetActivePriceListsByCurrencyIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetActivePriceListsByCurrencyIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetActivePriceListsByCurrencyIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetActivePriceListsByCurrencyIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllPriceLists">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllPriceLists" style="document" />
      <wsdl:input name="GetAllPriceListsRequest">
        <soap:header message="tns:GetAllPriceListsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllPriceListsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllPriceListsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllPriceListsResponse">
        <soap:header message="tns:GetAllPriceListsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllPriceListsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllPriceListsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllPriceListsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllPriceListsByCurrencyId">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllPriceListsByCurrencyId" style="document" />
      <wsdl:input name="GetAllPriceListsByCurrencyIdRequest">
        <soap:header message="tns:GetAllPriceListsByCurrencyIdRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllPriceListsByCurrencyIdRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllPriceListsByCurrencyIdRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllPriceListsByCurrencyIdResponse">
        <soap:header message="tns:GetAllPriceListsByCurrencyIdResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllPriceListsByCurrencyIdResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllPriceListsByCurrencyIdResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllPriceListsByCurrencyIdResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConnectorCapabilityNames">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectorCapabilityNames" style="document" />
      <wsdl:input name="GetConnectorCapabilityNamesRequest">
        <soap:header message="tns:GetConnectorCapabilityNamesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConnectorCapabilityNamesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConnectorCapabilityNamesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConnectorCapabilityNamesResponse">
        <soap:header message="tns:GetConnectorCapabilityNamesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConnectorCapabilityNamesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConnectorCapabilityNamesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConnectorCapabilityNamesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConnectorCapabilities">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectorCapabilities" style="document" />
      <wsdl:input name="GetConnectorCapabilitiesRequest">
        <soap:header message="tns:GetConnectorCapabilitiesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConnectorCapabilitiesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConnectorCapabilitiesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConnectorCapabilitiesResponse">
        <soap:header message="tns:GetConnectorCapabilitiesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConnectorCapabilitiesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConnectorCapabilitiesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConnectorCapabilitiesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CanConnectorProvideCapability">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CanConnectorProvideCapability" style="document" />
      <wsdl:input name="CanConnectorProvideCapabilityRequest">
        <soap:header message="tns:CanConnectorProvideCapabilityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CanConnectorProvideCapabilityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CanConnectorProvideCapabilityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CanConnectorProvideCapabilityResponse">
        <soap:header message="tns:CanConnectorProvideCapabilityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CanConnectorProvideCapabilityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CanConnectorProvideCapabilityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CanConnectorProvideCapabilityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConnectionStartupErrors">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectionStartupErrors" style="document" />
      <wsdl:input name="GetConnectionStartupErrorsRequest">
        <soap:header message="tns:GetConnectionStartupErrorsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConnectionStartupErrorsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConnectionStartupErrorsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConnectionStartupErrorsResponse">
        <soap:header message="tns:GetConnectionStartupErrorsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConnectionStartupErrorsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConnectionStartupErrorsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConnectionStartupErrorsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConnectionStartupResponse">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectionStartupResponse" style="document" />
      <wsdl:input name="GetConnectionStartupResponseRequest">
        <soap:header message="tns:GetConnectionStartupResponseRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConnectionStartupResponseRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConnectionStartupResponseRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConnectionStartupResponseResponse">
        <soap:header message="tns:GetConnectionStartupResponseResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConnectionStartupResponseResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConnectionStartupResponseResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConnectionStartupResponseResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetConnectionConfigFields">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetConnectionConfigFields" style="document" />
      <wsdl:input name="GetConnectionConfigFieldsRequest">
        <soap:header message="tns:GetConnectionConfigFieldsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetConnectionConfigFieldsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetConnectionConfigFieldsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetConnectionConfigFieldsResponse">
        <soap:header message="tns:GetConnectionConfigFieldsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetConnectionConfigFieldsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetConnectionConfigFieldsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetConnectionConfigFieldsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveConnectionConfigFields">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveConnectionConfigFields" style="document" />
      <wsdl:input name="SaveConnectionConfigFieldsRequest">
        <soap:header message="tns:SaveConnectionConfigFieldsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveConnectionConfigFieldsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveConnectionConfigFieldsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveConnectionConfigFieldsResponse">
        <soap:header message="tns:SaveConnectionConfigFieldsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveConnectionConfigFieldsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveConnectionConfigFieldsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveConnectionConfigFieldsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateQuoteLine">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateQuoteLine" style="document" />
      <wsdl:input name="CreateQuoteLineRequest">
        <soap:header message="tns:CreateQuoteLineRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateQuoteLineRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateQuoteLineRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateQuoteLineResponse">
        <soap:header message="tns:CreateQuoteLineResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateQuoteLineResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateQuoteLineResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateQuoteLineResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateQuoteLineFromProduct">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateQuoteLineFromProduct" style="document" />
      <wsdl:input name="CreateQuoteLineFromProductRequest">
        <soap:header message="tns:CreateQuoteLineFromProductRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateQuoteLineFromProductRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateQuoteLineFromProductRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateQuoteLineFromProductResponse">
        <soap:header message="tns:CreateQuoteLineFromProductResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateQuoteLineFromProductResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateQuoteLineFromProductResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateQuoteLineFromProductResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteLine">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteLine" style="document" />
      <wsdl:input name="SaveQuoteLineRequest">
        <soap:header message="tns:SaveQuoteLineRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveQuoteLineRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveQuoteLineRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveQuoteLineResponse">
        <soap:header message="tns:SaveQuoteLineResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveQuoteLineResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveQuoteLineResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveQuoteLineResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteLine">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLine" style="document" />
      <wsdl:input name="GetQuoteLineRequest">
        <soap:header message="tns:GetQuoteLineRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteLineRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteLineRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteLineResponse">
        <soap:header message="tns:GetQuoteLineResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteLineResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteLineResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteLineResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteLines">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLines" style="document" />
      <wsdl:input name="GetQuoteLinesRequest">
        <soap:header message="tns:GetQuoteLinesRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteLinesRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteLinesRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteLinesResponse">
        <soap:header message="tns:GetQuoteLinesResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteLinesResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteLinesResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteLinesResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DeleteQuoteLine">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/DeleteQuoteLine" style="document" />
      <wsdl:input name="DeleteQuoteLineRequest">
        <soap:header message="tns:DeleteQuoteLineRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DeleteQuoteLineRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DeleteQuoteLineRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DeleteQuoteLineResponse">
        <soap:header message="tns:DeleteQuoteLineResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DeleteQuoteLineResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DeleteQuoteLineResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DeleteQuoteLineResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RecalculateQuoteLine">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RecalculateQuoteLine" style="document" />
      <wsdl:input name="RecalculateQuoteLineRequest">
        <soap:header message="tns:RecalculateQuoteLineRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RecalculateQuoteLineRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RecalculateQuoteLineRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RecalculateQuoteLineResponse">
        <soap:header message="tns:RecalculateQuoteLineResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RecalculateQuoteLineResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RecalculateQuoteLineResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RecalculateQuoteLineResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteLineImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLineImage" style="document" />
      <wsdl:input name="GetQuoteLineImageRequest">
        <soap:header message="tns:GetQuoteLineImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteLineImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteLineImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteLineImageResponse">
        <soap:header message="tns:GetQuoteLineImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteLineImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteLineImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteLineImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteLineImage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteLineImage" style="document" />
      <wsdl:input name="SaveQuoteLineImageRequest">
        <soap:header message="tns:SaveQuoteLineImageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveQuoteLineImageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveQuoteLineImageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveQuoteLineImageResponse">
        <soap:header message="tns:SaveQuoteLineImageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveQuoteLineImageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveQuoteLineImageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveQuoteLineImageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetExtraInfo">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetExtraInfo" style="document" />
      <wsdl:input name="GetExtraInfoRequest">
        <soap:header message="tns:GetExtraInfoRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetExtraInfoRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetExtraInfoRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetExtraInfoResponse">
        <soap:header message="tns:GetExtraInfoResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetExtraInfoResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetExtraInfoResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetExtraInfoResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteLineConfiguration">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLineConfiguration" style="document" />
      <wsdl:input name="GetQuoteLineConfigurationRequest">
        <soap:header message="tns:GetQuoteLineConfigurationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteLineConfigurationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteLineConfigurationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteLineConfigurationResponse">
        <soap:header message="tns:GetQuoteLineConfigurationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteLineConfigurationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteLineConfigurationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteLineConfigurationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteLineConfigurationFromFieldName">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteLineConfigurationFromFieldName" style="document" />
      <wsdl:input name="GetQuoteLineConfigurationFromFieldNameRequest">
        <soap:header message="tns:GetQuoteLineConfigurationFromFieldNameRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteLineConfigurationFromFieldNameRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteLineConfigurationFromFieldNameRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteLineConfigurationFromFieldNameResponse">
        <soap:header message="tns:GetQuoteLineConfigurationFromFieldNameResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteLineConfigurationFromFieldNameResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteLineConfigurationFromFieldNameResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteLineConfigurationFromFieldNameResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetAllQuoteLineConfigurations">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetAllQuoteLineConfigurations" style="document" />
      <wsdl:input name="GetAllQuoteLineConfigurationsRequest">
        <soap:header message="tns:GetAllQuoteLineConfigurationsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetAllQuoteLineConfigurationsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetAllQuoteLineConfigurationsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetAllQuoteLineConfigurationsResponse">
        <soap:header message="tns:GetAllQuoteLineConfigurationsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetAllQuoteLineConfigurationsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetAllQuoteLineConfigurationsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetAllQuoteLineConfigurationsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetInUseQuoteLineConfigurations">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetInUseQuoteLineConfigurations" style="document" />
      <wsdl:input name="GetInUseQuoteLineConfigurationsRequest">
        <soap:header message="tns:GetInUseQuoteLineConfigurationsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetInUseQuoteLineConfigurationsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetInUseQuoteLineConfigurationsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetInUseQuoteLineConfigurationsResponse">
        <soap:header message="tns:GetInUseQuoteLineConfigurationsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetInUseQuoteLineConfigurationsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetInUseQuoteLineConfigurationsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetInUseQuoteLineConfigurationsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteLineConfiguration">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteLineConfiguration" style="document" />
      <wsdl:input name="SaveQuoteLineConfigurationRequest">
        <soap:header message="tns:SaveQuoteLineConfigurationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveQuoteLineConfigurationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveQuoteLineConfigurationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveQuoteLineConfigurationResponse">
        <soap:header message="tns:SaveQuoteLineConfigurationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveQuoteLineConfigurationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveQuoteLineConfigurationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveQuoteLineConfigurationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteLineConfigurations">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteLineConfigurations" style="document" />
      <wsdl:input name="SaveQuoteLineConfigurationsRequest">
        <soap:header message="tns:SaveQuoteLineConfigurationsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveQuoteLineConfigurationsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveQuoteLineConfigurationsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveQuoteLineConfigurationsResponse">
        <soap:header message="tns:SaveQuoteLineConfigurationsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveQuoteLineConfigurationsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveQuoteLineConfigurationsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveQuoteLineConfigurationsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteList">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteList" style="document" />
      <wsdl:input name="GetQuoteListRequest">
        <soap:header message="tns:GetQuoteListRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteListRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteListRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteListResponse">
        <soap:header message="tns:GetQuoteListResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteListResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteListResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteListResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ValidateQuoteVersion">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ValidateQuoteVersion" style="document" />
      <wsdl:input name="ValidateQuoteVersionRequest">
        <soap:header message="tns:ValidateQuoteVersionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ValidateQuoteVersionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ValidateQuoteVersionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ValidateQuoteVersionResponse">
        <soap:header message="tns:ValidateQuoteVersionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ValidateQuoteVersionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ValidateQuoteVersionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ValidateQuoteVersionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="CreateAndSaveQuoteVersion">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/CreateAndSaveQuoteVersion" style="document" />
      <wsdl:input name="CreateAndSaveQuoteVersionRequest">
        <soap:header message="tns:CreateAndSaveQuoteVersionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteVersionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteVersionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="CreateAndSaveQuoteVersionResponse">
        <soap:header message="tns:CreateAndSaveQuoteVersionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteVersionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteVersionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:CreateAndSaveQuoteVersionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteVersion">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersion" style="document" />
      <wsdl:input name="GetQuoteVersionRequest">
        <soap:header message="tns:GetQuoteVersionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteVersionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteVersionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteVersionResponse">
        <soap:header message="tns:GetQuoteVersionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteVersionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteVersionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteVersionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteVersions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersions" style="document" />
      <wsdl:input name="GetQuoteVersionsRequest">
        <soap:header message="tns:GetQuoteVersionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteVersionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteVersionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteVersionsResponse">
        <soap:header message="tns:GetQuoteVersionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteVersionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteVersionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteVersionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SendQuoteVersion">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SendQuoteVersion" style="document" />
      <wsdl:input name="SendQuoteVersionRequest">
        <soap:header message="tns:SendQuoteVersionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SendQuoteVersionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SendQuoteVersionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SendQuoteVersionResponse">
        <soap:header message="tns:SendQuoteVersionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SendQuoteVersionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SendQuoteVersionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SendQuoteVersionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SaveQuoteVersion">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/SaveQuoteVersion" style="document" />
      <wsdl:input name="SaveQuoteVersionRequest">
        <soap:header message="tns:SaveQuoteVersionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SaveQuoteVersionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SaveQuoteVersionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SaveQuoteVersionResponse">
        <soap:header message="tns:SaveQuoteVersionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SaveQuoteVersionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SaveQuoteVersionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SaveQuoteVersionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ApproveQuoteVersion">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/ApproveQuoteVersion" style="document" />
      <wsdl:input name="ApproveQuoteVersionRequest">
        <soap:header message="tns:ApproveQuoteVersionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ApproveQuoteVersionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ApproveQuoteVersionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ApproveQuoteVersionResponse">
        <soap:header message="tns:ApproveQuoteVersionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ApproveQuoteVersionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ApproveQuoteVersionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ApproveQuoteVersionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RejectQuoteVersion">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/RejectQuoteVersion" style="document" />
      <wsdl:input name="RejectQuoteVersionRequest">
        <soap:header message="tns:RejectQuoteVersionRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RejectQuoteVersionRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RejectQuoteVersionRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RejectQuoteVersionResponse">
        <soap:header message="tns:RejectQuoteVersionResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RejectQuoteVersionResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RejectQuoteVersionResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RejectQuoteVersionResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GenerateQuoteDocuments">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GenerateQuoteDocuments" style="document" />
      <wsdl:input name="GenerateQuoteDocumentsRequest">
        <soap:header message="tns:GenerateQuoteDocumentsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GenerateQuoteDocumentsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GenerateQuoteDocumentsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GenerateQuoteDocumentsResponse">
        <soap:header message="tns:GenerateQuoteDocumentsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GenerateQuoteDocumentsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GenerateQuoteDocumentsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GenerateQuoteDocumentsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetOrderConfirmation">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetOrderConfirmation" style="document" />
      <wsdl:input name="GetOrderConfirmationRequest">
        <soap:header message="tns:GetOrderConfirmationRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetOrderConfirmationRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetOrderConfirmationRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetOrderConfirmationResponse">
        <soap:header message="tns:GetOrderConfirmationResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetOrderConfirmationResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetOrderConfirmationResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetOrderConfirmationResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetQuoteVersionWorkflowState">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services86/Quote/GetQuoteVersionWorkflowState" style="document" />
      <wsdl:input name="GetQuoteVersionWorkflowStateRequest">
        <soap:header message="tns:GetQuoteVersionWorkflowStateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowStateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowStateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetQuoteVersionWorkflowStateResponse">
        <soap:header message="tns:GetQuoteVersionWorkflowStateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowStateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowStateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetQuoteVersionWorkflowStateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfQuoteService">
    <wsdl:port name="BasicHttpBinding_Quote" binding="tns:BasicHttpBinding_Quote">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services86/Quote.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

