---
title: POST Agents/List/SetDocumentTemplateStream
id: v1ListAgent_SetDocumentTemplateStream
---

# POST Agents/List/SetDocumentTemplateStream

```http
POST /api/v1/Agents/List/SetDocumentTemplateStream
```

Store a document template from its stream.

Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SetDocumentTemplateStream?$select=name,department,category/id
```


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

## Request Body: request  

DocumentTemplateEntity, Stream, LanguageCode, PluginId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentTemplateEntity |  | The template a document is based on is stored in the SO_arc\template folder on the server. This will return the name as displayed in the GUI, and not the physical document name, of the template the document object is based on. <para /> Carrier object for DocumentTemplateEntity. Services for the DocumentTemplateEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>. |
| Stream | byte |  |
| LanguageCode | string |  |
| PluginId | int32 |  |


## Response: object

The template a document is based on is stored in the SO_arc\template folder on the server. This will return the name as displayed in the GUI, and not the physical document name, of the template the document object is based on.



Carrier object for DocumentTemplateEntity.
Services for the DocumentTemplateEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
POST /api/v1/Agents/List/SetDocumentTemplateStream
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocumentTemplateEntity": {
    "DocumentTemplateId": 604,
    "Name": "Dooley-Wunsch",
    "Tooltip": "labore",
    "SaveInDb": 978,
    "Filename": "adipisci",
    "DefaultOref": "vel",
    "RecordType": "Appointment",
    "Deleted": false,
    "Direction": "Incoming",
    "AutoeventId": 164,
    "IntentId": 191,
    "IsDefaultPublished": true,
    "Rank": 387,
    "LoadTemplateFromPlugin": 613,
    "MimeType": "quis",
    "IsInUseInGuides": false,
    "DocumentTypeKey": 115,
    "QuoteDocType": "ConfirmationLines",
    "PrivacyDocType": "None",
    "EmailSubject": "beulah.hahn@wuckert.us",
    "IncludeSignature": false,
    "ShowCurrents": true,
    "SenderEmailMode": "UseDefaultSender",
    "SenderEmailAddress": "kristopher@schulistlind.info",
    "InvitationDocType": "Cancelled"
  },
  "Stream": "GIF89....File contents as raw bytes...",
  "LanguageCode": "nihil",
  "PluginId": 810
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentTemplateId": 250,
  "Name": "Hoppe, Howe and Kertzmann",
  "Tooltip": "enim",
  "SaveInDb": 126,
  "Filename": "perspiciatis",
  "DefaultOref": "velit",
  "RecordType": "Appointment",
  "Deleted": true,
  "Direction": "Incoming",
  "AutoeventId": 936,
  "IntentId": 625,
  "IsDefaultPublished": true,
  "Rank": 414,
  "LoadTemplateFromPlugin": 746,
  "MimeType": "sed",
  "IsInUseInGuides": true,
  "DocumentTypeKey": 593,
  "QuoteDocType": "ConfirmationLines",
  "PrivacyDocType": "None",
  "EmailSubject": "helen@gaylordhowell.biz",
  "IncludeSignature": true,
  "ShowCurrents": false,
  "SenderEmailMode": "UseDefaultSender",
  "SenderEmailAddress": "buford@legros.biz",
  "InvitationDocType": "Cancelled",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "synthesize sexy synergies"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 723
    }
  }
}
```