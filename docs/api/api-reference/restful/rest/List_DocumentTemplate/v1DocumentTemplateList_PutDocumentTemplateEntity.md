---
title: PUT List/DocumentTemplate/Items/{id}
id: v1DocumentTemplateList_PutDocumentTemplateEntity
---

# PUT List/DocumentTemplate/Items/{id}

```http
PUT /api/v1/List/DocumentTemplate/Items/{id}
```

Updates the existing DocumentTemplateEntity

Calls the List agent service SaveDocumentTemplateEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of DocumentTemplateEntity to be saved. **Required** |



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

## Request Body: entity  

The details of DocumentTemplateEntity to be saved. 

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


## Response: object

The template a document is based on is stored in the SO_arc\template folder on the server. This will return the name as displayed in the GUI, and not the physical document name, of the template the document object is based on.



Carrier object for DocumentTemplateEntity.
Services for the DocumentTemplateEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
PUT /api/v1/List/DocumentTemplate/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocumentTemplateId": 747,
  "Name": "Durgan Group",
  "Tooltip": "iusto",
  "SaveInDb": 611,
  "Filename": "aut",
  "DefaultOref": "eveniet",
  "RecordType": "Appointment",
  "Deleted": false,
  "Direction": "Incoming",
  "AutoeventId": 589,
  "IntentId": 989,
  "IsDefaultPublished": true,
  "Rank": 319,
  "LoadTemplateFromPlugin": 428,
  "MimeType": "quisquam",
  "IsInUseInGuides": false,
  "DocumentTypeKey": 750,
  "QuoteDocType": "ConfirmationLines",
  "PrivacyDocType": "None",
  "EmailSubject": "chasity.okuneva@jacobsjacobs.co.uk",
  "IncludeSignature": true,
  "ShowCurrents": true,
  "SenderEmailMode": "UseDefaultSender",
  "SenderEmailAddress": "ivy_smith@stroman.us",
  "InvitationDocType": "Cancelled"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentTemplateId": 920,
  "Name": "McLaughlin-Hilll",
  "Tooltip": "labore",
  "SaveInDb": 651,
  "Filename": "provident",
  "DefaultOref": "sequi",
  "RecordType": "Appointment",
  "Deleted": false,
  "Direction": "Incoming",
  "AutoeventId": 431,
  "IntentId": 547,
  "IsDefaultPublished": true,
  "Rank": 739,
  "LoadTemplateFromPlugin": 40,
  "MimeType": "tenetur",
  "IsInUseInGuides": true,
  "DocumentTypeKey": 317,
  "QuoteDocType": "ConfirmationLines",
  "PrivacyDocType": "None",
  "EmailSubject": "erika@murazikanderson.ca",
  "IncludeSignature": false,
  "ShowCurrents": true,
  "SenderEmailMode": "UseDefaultSender",
  "SenderEmailAddress": "brandyn.schowalter@quitzonmuller.info",
  "InvitationDocType": "Cancelled",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 800
    }
  }
}
```