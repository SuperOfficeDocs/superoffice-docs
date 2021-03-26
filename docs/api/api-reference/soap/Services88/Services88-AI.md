---
Generated: 1
TOCExclude: 1
title: Services88.AIAgent WSDL
---

# Services88.AIAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfAIService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:element name="DetectLanguage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
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
      <xs:element name="DetectLanguageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
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
      <xs:element name="DetectSentiment">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DetectSentimentResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:Sentiment" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="Sentiment">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="Score" type="xs:int" />
              <xs:element minOccurs="0" name="Confidence" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="Sentiment" nillable="true" type="tns:Sentiment" />
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
      <xs:element name="Translate">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="TargetLanguage" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TranslateResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GuessCategory">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Subject" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GuessCategoryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TrainCategorizer">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="TrainCategorizerResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
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
  </wsdl:types>
  <wsdl:message name="DetectLanguageRequest">
    <wsdl:part name="parameters" element="tns:DetectLanguage" />
  </wsdl:message>
  <wsdl:message name="DetectLanguageRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DetectLanguageResponse">
    <wsdl:part name="parameters" element="tns:DetectLanguageResponse" />
  </wsdl:message>
  <wsdl:message name="DetectLanguageResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DetectSentimentRequest">
    <wsdl:part name="parameters" element="tns:DetectSentiment" />
  </wsdl:message>
  <wsdl:message name="DetectSentimentRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="DetectSentimentResponse">
    <wsdl:part name="parameters" element="tns:DetectSentimentResponse" />
  </wsdl:message>
  <wsdl:message name="DetectSentimentResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TranslateRequest">
    <wsdl:part name="parameters" element="tns:Translate" />
  </wsdl:message>
  <wsdl:message name="TranslateRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TranslateResponse">
    <wsdl:part name="parameters" element="tns:TranslateResponse" />
  </wsdl:message>
  <wsdl:message name="TranslateResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GuessCategoryRequest">
    <wsdl:part name="parameters" element="tns:GuessCategory" />
  </wsdl:message>
  <wsdl:message name="GuessCategoryRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GuessCategoryResponse">
    <wsdl:part name="parameters" element="tns:GuessCategoryResponse" />
  </wsdl:message>
  <wsdl:message name="GuessCategoryResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TrainCategorizerRequest">
    <wsdl:part name="parameters" element="tns:TrainCategorizer" />
  </wsdl:message>
  <wsdl:message name="TrainCategorizerRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TrainCategorizerResponse">
    <wsdl:part name="parameters" element="tns:TrainCategorizerResponse" />
  </wsdl:message>
  <wsdl:message name="TrainCategorizerResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="AI">
    <wsdl:documentation>
      <summary>Declaration of Wcf web services for AI</summary>
    </wsdl:documentation>
    <wsdl:operation name="DetectLanguage">
      <wsdl:documentation>
        <summary>Given a (reasonably short) text, detect the language it is written in</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectLanguage" name="DetectLanguageRequest" message="tns:DetectLanguageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectLanguageResponse" name="DetectLanguageResponse" message="tns:DetectLanguageResponse" />
    </wsdl:operation>
    <wsdl:operation name="DetectSentiment">
      <wsdl:documentation>
        <summary>Detect the sentiment of a (reasonably short) text. Sentiment analysis may cause a translation to be made, since sentiment analysis only supports a limited set of languages</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectSentiment" name="DetectSentimentRequest" message="tns:DetectSentimentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectSentimentResponse" name="DetectSentimentResponse" message="tns:DetectSentimentResponse" />
    </wsdl:operation>
    <wsdl:operation name="Translate">
      <wsdl:documentation>
        <summary>Translate a text from one language to another. Language of the text is automatically detected.</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/Translate" name="TranslateRequest" message="tns:TranslateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TranslateResponse" name="TranslateResponse" message="tns:TranslateResponse" />
    </wsdl:operation>
    <wsdl:operation name="GuessCategory">
      <wsdl:documentation>
        <summary>Given a ticket's subject and message body, guess the ticket category it should be placed in</summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GuessCategory" name="GuessCategoryRequest" message="tns:GuessCategoryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GuessCategoryResponse" name="GuessCategoryResponse" message="tns:GuessCategoryResponse" />
    </wsdl:operation>
    <wsdl:operation name="TrainCategorizer">
      <wsdl:documentation>
        <summary>Train categorizer with a </summary>
      </wsdl:documentation>
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TrainCategorizer" name="TrainCategorizerRequest" message="tns:TrainCategorizerRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TrainCategorizerResponse" name="TrainCategorizerResponse" message="tns:TrainCategorizerResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_AI" type="tns:AI">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="DetectLanguage">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectLanguage" style="document" />
      <wsdl:input name="DetectLanguageRequest">
        <soap:header message="tns:DetectLanguageRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DetectLanguageRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DetectLanguageRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DetectLanguageResponse">
        <soap:header message="tns:DetectLanguageResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DetectLanguageResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DetectLanguageResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DetectLanguageResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="DetectSentiment">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectSentiment" style="document" />
      <wsdl:input name="DetectSentimentRequest">
        <soap:header message="tns:DetectSentimentRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:DetectSentimentRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:DetectSentimentRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="DetectSentimentResponse">
        <soap:header message="tns:DetectSentimentResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:DetectSentimentResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:DetectSentimentResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:DetectSentimentResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="Translate">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/Translate" style="document" />
      <wsdl:input name="TranslateRequest">
        <soap:header message="tns:TranslateRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TranslateRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TranslateRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TranslateResponse">
        <soap:header message="tns:TranslateResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TranslateResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TranslateResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TranslateResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GuessCategory">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GuessCategory" style="document" />
      <wsdl:input name="GuessCategoryRequest">
        <soap:header message="tns:GuessCategoryRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GuessCategoryRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GuessCategoryRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GuessCategoryResponse">
        <soap:header message="tns:GuessCategoryResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GuessCategoryResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GuessCategoryResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GuessCategoryResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="TrainCategorizer">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TrainCategorizer" style="document" />
      <wsdl:input name="TrainCategorizerRequest">
        <soap:header message="tns:TrainCategorizerRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TrainCategorizerRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TrainCategorizerRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TrainCategorizerResponse">
        <soap:header message="tns:TrainCategorizerResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TrainCategorizerResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TrainCategorizerResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TrainCategorizerResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
  </wsdl:binding>
  <wsdl:service name="WcfAIService">
    <wsdl:port name="BasicHttpBinding_AI" binding="tns:BasicHttpBinding_AI">
      <soap:address location="https://sod.superoffice.com/Cust12345/Remote/Services88/AI.svc" />
    </wsdl:port>
  </wsdl:service>
</wsdl:definitions>
```

