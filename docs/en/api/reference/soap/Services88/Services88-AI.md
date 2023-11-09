---
generated: true
uid: wsdl-Services88-AI
title: Services88.AIAgent WSDL
---

# Services88.AIAgent WSDL

```xml
<?xml version="1.0" encoding="utf-8"?>
<wsdl:definitions name="WcfAIService" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsdl="http://schemas.xmlsoap.org/wsdl/" xmlns:wsam="http://www.w3.org/2007/05/addressing/metadata" xmlns:wsx="http://schemas.xmlsoap.org/ws/2004/09/mex" xmlns:wsap="http://schemas.xmlsoap.org/ws/2004/08/addressing/policy" xmlns:msc="http://schemas.microsoft.com/ws/2005/12/wsdl/contract" xmlns:wsp="http://schemas.xmlsoap.org/ws/2004/09/policy" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/" xmlns:wsu="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd" xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/" xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/" xmlns:tns="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:wsa10="http://www.w3.org/2005/08/addressing" xmlns:wsaw="http://www.w3.org/2006/05/addressing/wsdl" xmlns:wsa="http://schemas.xmlsoap.org/ws/2004/08/addressing">
  <wsdl:types>
    <xs:schema elementFormDefault="qualified" targetNamespace="http://www.superoffice.net/ws/crm/NetServer/Services88" xmlns:xs="http://www.w3.org/2001/XMLSchema">
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/" />
      <xs:import namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
      <xs:element name="SummarizeText">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PercentSmaller" type="xs:int" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
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
      <xs:element name="SummarizeTextResponse">
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
      <xs:element name="ExpandText">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PercentBigger" type="xs:int" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="ExpandTextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="RephraseText">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="Style" type="tns:AiTextStyle" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:simpleType name="AiTextStyle">
        <xs:restriction base="xs:string">
          <xs:enumeration value="None" />
          <xs:enumeration value="Rephrase" />
          <xs:enumeration value="Correct" />
          <xs:enumeration value="Casual" />
          <xs:enumeration value="Formal" />
        </xs:restriction>
      </xs:simpleType>
      <xs:element name="AiTextStyle" nillable="true" type="tns:AiTextStyle" />
      <xs:element name="RephraseTextResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTrainingStatus">
        <xs:complexType>
          <xs:sequence />
        </xs:complexType>
      </xs:element>
      <xs:element name="GetTrainingStatusResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:CategorizationStatusResponse" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="CategorizationStatusResponse">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ContextIdentifier" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="Status" nillable="true" type="xs:string" />
              <xs:element minOccurs="0" name="CurrentModel" nillable="true" type="tns:CategorizationModelDetails" />
              <xs:element minOccurs="0" name="PreviousModel" nillable="true" type="tns:CategorizationModelDetails" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CategorizationStatusResponse" nillable="true" type="tns:CategorizationStatusResponse" />
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
              <xs:enumeration value="Unused1" />
              <xs:enumeration value="Uninitialized" />
              <xs:enumeration value="R">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">1</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
              <xs:enumeration value="F">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">16</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
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
              <xs:enumeration value="Nullable">
                <xs:annotation>
                  <xs:appinfo>
                    <EnumerationValue xmlns="http://schemas.microsoft.com/2003/10/Serialization/">32</EnumerationValue>
                  </xs:appinfo>
                </xs:annotation>
              </xs:enumeration>
            </xs:restriction>
          </xs:simpleType>
        </xs:list>
      </xs:simpleType>
      <xs:element name="EFieldRight" nillable="true" type="tns:EFieldRight" />
      <xs:complexType name="CategorizationModelDetails">
        <xs:complexContent mixed="false">
          <xs:extension base="tns:Carrier">
            <xs:sequence>
              <xs:element minOccurs="0" name="ModelBuiltDateTime" type="xs:dateTime" />
              <xs:element minOccurs="0" name="Accuracy" type="xs:double" />
              <xs:element minOccurs="0" name="TicketCountForTraining" type="xs:int" />
            </xs:sequence>
          </xs:extension>
        </xs:complexContent>
      </xs:complexType>
      <xs:element name="CategorizationModelDetails" nillable="true" type="tns:CategorizationModelDetails" />
      <xs:element name="GuessCategory">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GuessCategoryResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TrainCategoryGuesser">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SelectionId" type="xs:int" />
            <xs:element minOccurs="0" name="MaxItems" type="xs:int" />
            <xs:element minOccurs="0" name="MaxTextLength" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TrainCategoryGuesserResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatbotResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="UserPrompt" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="DisplayValue" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="PreviousTurns" nillable="true" type="tns:ArrayOfChatbotTurn" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:complexType name="ArrayOfChatbotTurn">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="ChatbotTurn" nillable="true" type="tns:ChatbotTurn" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfChatbotTurn" nillable="true" type="tns:ArrayOfChatbotTurn" />
      <xs:complexType name="ChatbotTurn">
        <xs:sequence>
          <xs:element minOccurs="0" name="Timestamp" type="xs:dateTime" />
          <xs:element minOccurs="0" name="UserPrompt" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="UserDisplayText" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="BotResponse" nillable="true" type="xs:string" />
          <xs:element minOccurs="0" name="BotActions" nillable="true" type="tns:StringDictionary" />
          <xs:element minOccurs="0" name="Attachments" nillable="true" type="q1:ArrayOfstring" xmlns:q1="http://schemas.microsoft.com/2003/10/Serialization/Arrays" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ChatbotTurn" nillable="true" type="tns:ChatbotTurn" />
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
      <xs:element name="GetChatbotResponseResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ChatbotTurn" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatbotPromptSuggestions">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="SoProtocol" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="CurrentContactId" type="xs:int" />
            <xs:element minOccurs="0" name="CurrentPersonId" type="xs:int" />
            <xs:element minOccurs="0" name="CurrentProjectId" type="xs:int" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetChatbotPromptSuggestionsResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ChatbotTurn" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DetectLanguage">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Text" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="DetectLanguageResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
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
      <xs:element name="TranslateEntity">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="EntityName" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="EntityId" type="xs:int" />
            <xs:element minOccurs="0" name="TargetLanguage" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="TranslateEntityResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SummarizeTicket">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
            <xs:element minOccurs="0" name="NumSentences" type="xs:int" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SummarizeTicketResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummarizeTicketPrompt">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="TicketId" type="xs:int" />
            <xs:element minOccurs="0" name="NumSentences" type="xs:int" />
            <xs:element minOccurs="0" name="Summary" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummarizeTicketPromptResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ChatbotTurn" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SummarizeContact">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="NumSentences" type="xs:int" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SummarizeContactResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummarizeContactPrompt">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="ContactId" type="xs:int" />
            <xs:element minOccurs="0" name="NumSentences" type="xs:int" />
            <xs:element minOccurs="0" name="Summary" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummarizeContactPromptResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ChatbotTurn" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SummarizeSale">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="NumSentences" type="xs:int" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="SummarizeSaleResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummarizeSalePrompt">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="SaleId" type="xs:int" />
            <xs:element minOccurs="0" name="NumSentences" type="xs:int" />
            <xs:element minOccurs="0" name="Summary" nillable="true" type="xs:string" />
            <xs:element minOccurs="0" name="IsoLangCode" nillable="true" type="xs:string" />
          </xs:sequence>
        </xs:complexType>
      </xs:element>
      <xs:element name="GetSummarizeSalePromptResponse">
        <xs:complexType>
          <xs:sequence>
            <xs:element minOccurs="0" name="Response" nillable="true" type="tns:ChatbotTurn" />
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
      <xs:complexType name="ArrayOfstring">
        <xs:sequence>
          <xs:element minOccurs="0" maxOccurs="unbounded" name="string" nillable="true" type="xs:string" />
        </xs:sequence>
      </xs:complexType>
      <xs:element name="ArrayOfstring" nillable="true" type="tns:ArrayOfstring" />
    </xs:schema>
  </wsdl:types>
  <wsdl:message name="SummarizeTextRequest">
    <wsdl:part name="parameters" element="tns:SummarizeText" />
  </wsdl:message>
  <wsdl:message name="SummarizeTextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SummarizeTextResponse">
    <wsdl:part name="parameters" element="tns:SummarizeTextResponse" />
  </wsdl:message>
  <wsdl:message name="SummarizeTextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExpandTextRequest">
    <wsdl:part name="parameters" element="tns:ExpandText" />
  </wsdl:message>
  <wsdl:message name="ExpandTextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="ExpandTextResponse">
    <wsdl:part name="parameters" element="tns:ExpandTextResponse" />
  </wsdl:message>
  <wsdl:message name="ExpandTextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RephraseTextRequest">
    <wsdl:part name="parameters" element="tns:RephraseText" />
  </wsdl:message>
  <wsdl:message name="RephraseTextRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="RephraseTextResponse">
    <wsdl:part name="parameters" element="tns:RephraseTextResponse" />
  </wsdl:message>
  <wsdl:message name="RephraseTextResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTrainingStatusRequest">
    <wsdl:part name="parameters" element="tns:GetTrainingStatus" />
  </wsdl:message>
  <wsdl:message name="GetTrainingStatusRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetTrainingStatusResponse">
    <wsdl:part name="parameters" element="tns:GetTrainingStatusResponse" />
  </wsdl:message>
  <wsdl:message name="GetTrainingStatusResponse_Headers">
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
  <wsdl:message name="TrainCategoryGuesserRequest">
    <wsdl:part name="parameters" element="tns:TrainCategoryGuesser" />
  </wsdl:message>
  <wsdl:message name="TrainCategoryGuesserRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TrainCategoryGuesserResponse">
    <wsdl:part name="parameters" element="tns:TrainCategoryGuesserResponse" />
  </wsdl:message>
  <wsdl:message name="TrainCategoryGuesserResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatbotResponseRequest">
    <wsdl:part name="parameters" element="tns:GetChatbotResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatbotResponseRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatbotResponseResponse">
    <wsdl:part name="parameters" element="tns:GetChatbotResponseResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatbotResponseResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatbotPromptSuggestionsRequest">
    <wsdl:part name="parameters" element="tns:GetChatbotPromptSuggestions" />
  </wsdl:message>
  <wsdl:message name="GetChatbotPromptSuggestionsRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetChatbotPromptSuggestionsResponse">
    <wsdl:part name="parameters" element="tns:GetChatbotPromptSuggestionsResponse" />
  </wsdl:message>
  <wsdl:message name="GetChatbotPromptSuggestionsResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
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
  <wsdl:message name="TranslateEntityRequest">
    <wsdl:part name="parameters" element="tns:TranslateEntity" />
  </wsdl:message>
  <wsdl:message name="TranslateEntityRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="TranslateEntityResponse">
    <wsdl:part name="parameters" element="tns:TranslateEntityResponse" />
  </wsdl:message>
  <wsdl:message name="TranslateEntityResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SummarizeTicketRequest">
    <wsdl:part name="parameters" element="tns:SummarizeTicket" />
  </wsdl:message>
  <wsdl:message name="SummarizeTicketRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SummarizeTicketResponse">
    <wsdl:part name="parameters" element="tns:SummarizeTicketResponse" />
  </wsdl:message>
  <wsdl:message name="SummarizeTicketResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeTicketPromptRequest">
    <wsdl:part name="parameters" element="tns:GetSummarizeTicketPrompt" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeTicketPromptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeTicketPromptResponse">
    <wsdl:part name="parameters" element="tns:GetSummarizeTicketPromptResponse" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeTicketPromptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SummarizeContactRequest">
    <wsdl:part name="parameters" element="tns:SummarizeContact" />
  </wsdl:message>
  <wsdl:message name="SummarizeContactRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SummarizeContactResponse">
    <wsdl:part name="parameters" element="tns:SummarizeContactResponse" />
  </wsdl:message>
  <wsdl:message name="SummarizeContactResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeContactPromptRequest">
    <wsdl:part name="parameters" element="tns:GetSummarizeContactPrompt" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeContactPromptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeContactPromptResponse">
    <wsdl:part name="parameters" element="tns:GetSummarizeContactPromptResponse" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeContactPromptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SummarizeSaleRequest">
    <wsdl:part name="parameters" element="tns:SummarizeSale" />
  </wsdl:message>
  <wsdl:message name="SummarizeSaleRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="SummarizeSaleResponse">
    <wsdl:part name="parameters" element="tns:SummarizeSaleResponse" />
  </wsdl:message>
  <wsdl:message name="SummarizeSaleResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeSalePromptRequest">
    <wsdl:part name="parameters" element="tns:GetSummarizeSalePrompt" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeSalePromptRequest_Headers">
    <wsdl:part name="ApplicationToken" element="tns:ApplicationToken" />
    <wsdl:part name="Credentials" element="tns:Credentials" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeSalePromptResponse">
    <wsdl:part name="parameters" element="tns:GetSummarizeSalePromptResponse" />
  </wsdl:message>
  <wsdl:message name="GetSummarizeSalePromptResponse_Headers">
    <wsdl:part name="ExceptionInfo" element="tns:ExceptionInfo" />
    <wsdl:part name="ExtraInfo" element="tns:ExtraInfo" />
    <wsdl:part name="Succeeded" element="tns:Succeeded" />
    <wsdl:part name="TimeZone" element="tns:TimeZone" />
  </wsdl:message>
  <wsdl:portType name="AI">
    <wsdl:operation name="SummarizeText">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeText" name="SummarizeTextRequest" message="tns:SummarizeTextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeTextResponse" name="SummarizeTextResponse" message="tns:SummarizeTextResponse" />
    </wsdl:operation>
    <wsdl:operation name="ExpandText">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/ExpandText" name="ExpandTextRequest" message="tns:ExpandTextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/ExpandTextResponse" name="ExpandTextResponse" message="tns:ExpandTextResponse" />
    </wsdl:operation>
    <wsdl:operation name="RephraseText">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/RephraseText" name="RephraseTextRequest" message="tns:RephraseTextRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/RephraseTextResponse" name="RephraseTextResponse" message="tns:RephraseTextResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetTrainingStatus">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetTrainingStatus" name="GetTrainingStatusRequest" message="tns:GetTrainingStatusRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetTrainingStatusResponse" name="GetTrainingStatusResponse" message="tns:GetTrainingStatusResponse" />
    </wsdl:operation>
    <wsdl:operation name="GuessCategory">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GuessCategory" name="GuessCategoryRequest" message="tns:GuessCategoryRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GuessCategoryResponse" name="GuessCategoryResponse" message="tns:GuessCategoryResponse" />
    </wsdl:operation>
    <wsdl:operation name="TrainCategoryGuesser">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TrainCategoryGuesser" name="TrainCategoryGuesserRequest" message="tns:TrainCategoryGuesserRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TrainCategoryGuesserResponse" name="TrainCategoryGuesserResponse" message="tns:TrainCategoryGuesserResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetChatbotResponse">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotResponse" name="GetChatbotResponseRequest" message="tns:GetChatbotResponseRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotResponseResponse" name="GetChatbotResponseResponse" message="tns:GetChatbotResponseResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetChatbotPromptSuggestions">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotPromptSuggestions" name="GetChatbotPromptSuggestionsRequest" message="tns:GetChatbotPromptSuggestionsRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotPromptSuggestionsResponse" name="GetChatbotPromptSuggestionsResponse" message="tns:GetChatbotPromptSuggestionsResponse" />
    </wsdl:operation>
    <wsdl:operation name="DetectLanguage">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectLanguage" name="DetectLanguageRequest" message="tns:DetectLanguageRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectLanguageResponse" name="DetectLanguageResponse" message="tns:DetectLanguageResponse" />
    </wsdl:operation>
    <wsdl:operation name="DetectSentiment">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectSentiment" name="DetectSentimentRequest" message="tns:DetectSentimentRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/DetectSentimentResponse" name="DetectSentimentResponse" message="tns:DetectSentimentResponse" />
    </wsdl:operation>
    <wsdl:operation name="Translate">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/Translate" name="TranslateRequest" message="tns:TranslateRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TranslateResponse" name="TranslateResponse" message="tns:TranslateResponse" />
    </wsdl:operation>
    <wsdl:operation name="TranslateEntity">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TranslateEntity" name="TranslateEntityRequest" message="tns:TranslateEntityRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TranslateEntityResponse" name="TranslateEntityResponse" message="tns:TranslateEntityResponse" />
    </wsdl:operation>
    <wsdl:operation name="SummarizeTicket">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeTicket" name="SummarizeTicketRequest" message="tns:SummarizeTicketRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeTicketResponse" name="SummarizeTicketResponse" message="tns:SummarizeTicketResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSummarizeTicketPrompt">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeTicketPrompt" name="GetSummarizeTicketPromptRequest" message="tns:GetSummarizeTicketPromptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeTicketPromptResponse" name="GetSummarizeTicketPromptResponse" message="tns:GetSummarizeTicketPromptResponse" />
    </wsdl:operation>
    <wsdl:operation name="SummarizeContact">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeContact" name="SummarizeContactRequest" message="tns:SummarizeContactRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeContactResponse" name="SummarizeContactResponse" message="tns:SummarizeContactResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSummarizeContactPrompt">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeContactPrompt" name="GetSummarizeContactPromptRequest" message="tns:GetSummarizeContactPromptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeContactPromptResponse" name="GetSummarizeContactPromptResponse" message="tns:GetSummarizeContactPromptResponse" />
    </wsdl:operation>
    <wsdl:operation name="SummarizeSale">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeSale" name="SummarizeSaleRequest" message="tns:SummarizeSaleRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeSaleResponse" name="SummarizeSaleResponse" message="tns:SummarizeSaleResponse" />
    </wsdl:operation>
    <wsdl:operation name="GetSummarizeSalePrompt">
      <wsdl:input wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeSalePrompt" name="GetSummarizeSalePromptRequest" message="tns:GetSummarizeSalePromptRequest" />
      <wsdl:output wsaw:Action="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeSalePromptResponse" name="GetSummarizeSalePromptResponse" message="tns:GetSummarizeSalePromptResponse" />
    </wsdl:operation>
  </wsdl:portType>
  <wsdl:binding name="BasicHttpBinding_AI" type="tns:AI">
    <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
    <wsdl:operation name="SummarizeText">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeText" style="document" />
      <wsdl:input name="SummarizeTextRequest">
        <soap:header message="tns:SummarizeTextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SummarizeTextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SummarizeTextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SummarizeTextResponse">
        <soap:header message="tns:SummarizeTextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SummarizeTextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SummarizeTextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SummarizeTextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="ExpandText">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/ExpandText" style="document" />
      <wsdl:input name="ExpandTextRequest">
        <soap:header message="tns:ExpandTextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:ExpandTextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:ExpandTextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="ExpandTextResponse">
        <soap:header message="tns:ExpandTextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:ExpandTextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:ExpandTextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:ExpandTextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="RephraseText">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/RephraseText" style="document" />
      <wsdl:input name="RephraseTextRequest">
        <soap:header message="tns:RephraseTextRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:RephraseTextRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:RephraseTextRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="RephraseTextResponse">
        <soap:header message="tns:RephraseTextResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:RephraseTextResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:RephraseTextResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:RephraseTextResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetTrainingStatus">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetTrainingStatus" style="document" />
      <wsdl:input name="GetTrainingStatusRequest">
        <soap:header message="tns:GetTrainingStatusRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetTrainingStatusRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetTrainingStatusRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetTrainingStatusResponse">
        <soap:header message="tns:GetTrainingStatusResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetTrainingStatusResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetTrainingStatusResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetTrainingStatusResponse_Headers" part="TimeZone" use="literal" />
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
    <wsdl:operation name="TrainCategoryGuesser">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TrainCategoryGuesser" style="document" />
      <wsdl:input name="TrainCategoryGuesserRequest">
        <soap:header message="tns:TrainCategoryGuesserRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TrainCategoryGuesserRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TrainCategoryGuesserRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TrainCategoryGuesserResponse">
        <soap:header message="tns:TrainCategoryGuesserResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TrainCategoryGuesserResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TrainCategoryGuesserResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TrainCategoryGuesserResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetChatbotResponse">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotResponse" style="document" />
      <wsdl:input name="GetChatbotResponseRequest">
        <soap:header message="tns:GetChatbotResponseRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetChatbotResponseRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetChatbotResponseRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetChatbotResponseResponse">
        <soap:header message="tns:GetChatbotResponseResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetChatbotResponseResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetChatbotResponseResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetChatbotResponseResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetChatbotPromptSuggestions">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetChatbotPromptSuggestions" style="document" />
      <wsdl:input name="GetChatbotPromptSuggestionsRequest">
        <soap:header message="tns:GetChatbotPromptSuggestionsRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetChatbotPromptSuggestionsRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetChatbotPromptSuggestionsRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetChatbotPromptSuggestionsResponse">
        <soap:header message="tns:GetChatbotPromptSuggestionsResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetChatbotPromptSuggestionsResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetChatbotPromptSuggestionsResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetChatbotPromptSuggestionsResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
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
    <wsdl:operation name="TranslateEntity">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/TranslateEntity" style="document" />
      <wsdl:input name="TranslateEntityRequest">
        <soap:header message="tns:TranslateEntityRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:TranslateEntityRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:TranslateEntityRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="TranslateEntityResponse">
        <soap:header message="tns:TranslateEntityResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:TranslateEntityResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:TranslateEntityResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:TranslateEntityResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SummarizeTicket">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeTicket" style="document" />
      <wsdl:input name="SummarizeTicketRequest">
        <soap:header message="tns:SummarizeTicketRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SummarizeTicketRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SummarizeTicketRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SummarizeTicketResponse">
        <soap:header message="tns:SummarizeTicketResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SummarizeTicketResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SummarizeTicketResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SummarizeTicketResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSummarizeTicketPrompt">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeTicketPrompt" style="document" />
      <wsdl:input name="GetSummarizeTicketPromptRequest">
        <soap:header message="tns:GetSummarizeTicketPromptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSummarizeTicketPromptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSummarizeTicketPromptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSummarizeTicketPromptResponse">
        <soap:header message="tns:GetSummarizeTicketPromptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSummarizeTicketPromptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSummarizeTicketPromptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSummarizeTicketPromptResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SummarizeContact">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeContact" style="document" />
      <wsdl:input name="SummarizeContactRequest">
        <soap:header message="tns:SummarizeContactRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SummarizeContactRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SummarizeContactRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SummarizeContactResponse">
        <soap:header message="tns:SummarizeContactResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SummarizeContactResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SummarizeContactResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SummarizeContactResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSummarizeContactPrompt">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeContactPrompt" style="document" />
      <wsdl:input name="GetSummarizeContactPromptRequest">
        <soap:header message="tns:GetSummarizeContactPromptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSummarizeContactPromptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSummarizeContactPromptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSummarizeContactPromptResponse">
        <soap:header message="tns:GetSummarizeContactPromptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSummarizeContactPromptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSummarizeContactPromptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSummarizeContactPromptResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="SummarizeSale">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/SummarizeSale" style="document" />
      <wsdl:input name="SummarizeSaleRequest">
        <soap:header message="tns:SummarizeSaleRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:SummarizeSaleRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:SummarizeSaleRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="SummarizeSaleResponse">
        <soap:header message="tns:SummarizeSaleResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:SummarizeSaleResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:SummarizeSaleResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:SummarizeSaleResponse_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:output>
    </wsdl:operation>
    <wsdl:operation name="GetSummarizeSalePrompt">
      <soap:operation soapAction="http://www.superoffice.net/ws/crm/NetServer/Services88/AI/GetSummarizeSalePrompt" style="document" />
      <wsdl:input name="GetSummarizeSalePromptRequest">
        <soap:header message="tns:GetSummarizeSalePromptRequest_Headers" part="ApplicationToken" use="literal" />
        <soap:header message="tns:GetSummarizeSalePromptRequest_Headers" part="Credentials" use="literal" />
        <soap:header message="tns:GetSummarizeSalePromptRequest_Headers" part="TimeZone" use="literal" />
        <soap:body use="literal" />
      </wsdl:input>
      <wsdl:output name="GetSummarizeSalePromptResponse">
        <soap:header message="tns:GetSummarizeSalePromptResponse_Headers" part="ExceptionInfo" use="literal" />
        <soap:header message="tns:GetSummarizeSalePromptResponse_Headers" part="ExtraInfo" use="literal" />
        <soap:header message="tns:GetSummarizeSalePromptResponse_Headers" part="Succeeded" use="literal" />
        <soap:header message="tns:GetSummarizeSalePromptResponse_Headers" part="TimeZone" use="literal" />
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

