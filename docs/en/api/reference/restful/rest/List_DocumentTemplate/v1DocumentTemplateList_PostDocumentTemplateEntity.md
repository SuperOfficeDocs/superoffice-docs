---
title: POST List/DocumentTemplate/Items
uid: v1DocumentTemplateList_PostDocumentTemplateEntity
---

# POST List/DocumentTemplate/Items

```http
POST /api/v1/List/DocumentTemplate/Items
```

Create a new DocumentTemplateEntity list item


Calls the List agent service SaveDocumentTemplateEntity.







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: newEntity 

The DocumentTemplateEntity to be created. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentTemplateId | Integer | Primary key |
| Name | String | The template list item |
| Tooltip | String | Tooltip or other description |
| SaveInDb | Integer | 1 = save document records in DB; otherwise not. |
| Filename | String | Relative to TemplatePath, or extref for other document plugins. i.e URL or full path. |
| DefaultOref | String | Processed via tag substitution to give document reference |
| RecordType | String | 1 = app, 2 = doc, 3 = email, 4 = fax, 5 = phone, 6 = todo - see EAppntRecordTypes |
| Deleted | Boolean | True if deleted |
| Direction | String | 1 = incoming, 2 = outgoing, see EAppntDirection |
| AutoeventId | Integer | Which document plugin is responsible for the documents generated from this template |
| IntentId | Integer | What is the intention of this document (used by SAINT) |
| IsDefaultPublished | Boolean | Published to external persons |
| Rank | Integer | Rank order |
| LoadTemplateFromPlugin | Integer | Which document plugin is responsible for this template's contents |
| MimeType | String | The mime type |
| IsInUseInGuides | Boolean | True if the template is in use in a project or sales guide |
| DocumentTypeKey | Integer | The document type to use when creating a blank document. Plugin-specific. Used when not creating template from a local file. |
| QuoteDocType | String | The role this document plays in the Quote system, if any |
| PrivacyDocType | String | Indicator that this document template has a functional role, related to privacy/GDPR |
| EmailSubject | String | Subject to use if document template is an email. |
| IncludeSignature | Boolean | True if the email signature should be added in bottom of mail if this an email template |
| ShowCurrents | Boolean | True if when using this template there should be shown a place for editing current choices of person, compant, sale, project etc |
| SenderEmailMode | String | If email template, when DocType is Privacy or quote email, it is possible to make sender address like our contact, or our support contact, or always one address |
| SenderEmailAddress | String | If email template, default senderaddress when template is of type quote email or privacy email. |
| InvitationDocType | String | Type for sending email meeting invitation. Not an invitation type template = 0, New = 1, Changed = 2, Cancelled = 3 |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: DocumentTemplateEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentTemplateId | int32 | Primary key |
| Name | string | The template list item |
| Tooltip | string | Tooltip or other description |
| SaveInDb | int32 | 1 = save document records in DB; otherwise not. |
| Filename | string | Relative to TemplatePath, or extref for other document plugins. i.e URL or full path. |
| DefaultOref | string | Processed via tag substitution to give document reference |
| RecordType | string | 1 = app, 2 = doc, 3 = email, 4 = fax, 5 = phone, 6 = todo - see EAppntRecordTypes |
| Deleted | bool | True if deleted |
| Direction | string | 1 = incoming, 2 = outgoing, see EAppntDirection |
| AutoeventId | int32 | Which document plugin is responsible for the documents generated from this template |
| IntentId | int32 | What is the intention of this document (used by SAINT) |
| IsDefaultPublished | bool | Published to external persons |
| Rank | int32 | Rank order |
| LoadTemplateFromPlugin | int32 | Which document plugin is responsible for this template's contents |
| MimeType | string | The mime type |
| IsInUseInGuides | bool | True if the template is in use in a project or sales guide |
| DocumentTypeKey | int32 | The document type to use when creating a blank document. Plugin-specific. Used when not creating template from a local file. |
| QuoteDocType | string | The role this document plays in the Quote system, if any |
| PrivacyDocType | string | Indicator that this document template has a functional role, related to privacy/GDPR |
| EmailSubject | string | Subject to use if document template is an email. |
| IncludeSignature | bool | True if the email signature should be added in bottom of mail if this an email template |
| ShowCurrents | bool | True if when using this template there should be shown a place for editing current choices of person, compant, sale, project etc |
| SenderEmailMode | string | If email template, when DocType is Privacy or quote email, it is possible to make sender address like our contact, or our support contact, or always one address |
| SenderEmailAddress | string | If email template, default senderaddress when template is of type quote email or privacy email. |
| InvitationDocType | string | Type for sending email meeting invitation. Not an invitation type template = 0, New = 1, Changed = 2, Cancelled = 3 |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/List/DocumentTemplate/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentTemplateId": 682,
  "Name": "Jaskolski-Hagenes",
  "Tooltip": "vel",
  "SaveInDb": 932,
  "Filename": "facere",
  "DefaultOref": "fugiat",
  "RecordType": "Appointment",
  "Deleted": false,
  "Direction": "Incoming",
  "AutoeventId": 807,
  "IntentId": 987,
  "IsDefaultPublished": false,
  "Rank": 888,
  "LoadTemplateFromPlugin": 871,
  "MimeType": "dolor",
  "IsInUseInGuides": false,
  "DocumentTypeKey": 333,
  "QuoteDocType": "ConfirmationLines",
  "PrivacyDocType": "None",
  "EmailSubject": "kelli_stokes@beatty.biz",
  "IncludeSignature": true,
  "ShowCurrents": false,
  "SenderEmailMode": "UseDefaultSender",
  "SenderEmailAddress": "kayli@schuppe.biz",
  "InvitationDocType": "Cancelled"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentTemplateId": 343,
  "Name": "Stokes, Armstrong and O'Kon",
  "Tooltip": "tenetur",
  "SaveInDb": 33,
  "Filename": "sed",
  "DefaultOref": "repudiandae",
  "RecordType": "Appointment",
  "Deleted": true,
  "Direction": "Incoming",
  "AutoeventId": 516,
  "IntentId": 60,
  "IsDefaultPublished": false,
  "Rank": 267,
  "LoadTemplateFromPlugin": 156,
  "MimeType": "et",
  "IsInUseInGuides": false,
  "DocumentTypeKey": 613,
  "QuoteDocType": "ConfirmationLines",
  "PrivacyDocType": "None",
  "EmailSubject": "coy@shanahan.biz",
  "IncludeSignature": false,
  "ShowCurrents": false,
  "SenderEmailMode": "UseDefaultSender",
  "SenderEmailAddress": "ayla@steuberdooley.biz",
  "InvitationDocType": "Cancelled",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 480
    }
  }
}
```