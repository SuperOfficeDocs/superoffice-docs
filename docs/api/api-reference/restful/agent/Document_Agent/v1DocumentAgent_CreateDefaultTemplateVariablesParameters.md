---
title: POST Agents/Document/CreateDefaultTemplateVariablesParameters
id: v1DocumentAgent_CreateDefaultTemplateVariablesParameters
---

# POST Agents/Document/CreateDefaultTemplateVariablesParameters

```http
POST /api/v1/Agents/Document/CreateDefaultTemplateVariablesParameters
```

Set default values into a new TemplateVariablesParameters.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Parameters specifying source and properties for template variable substitution.



Carrier object for TemplateVariablesParameters.
Services for the TemplateVariablesParameters Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDocumentAgent">Document Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceInput | string | Source string to parse for template variables. Such variables must have delimiters corresponding to the standard for the given generator encoding.Non-text source data (such as the binary content of a .doc file) should be passed in as Base64. |
| Encoding | string | Encoding of source string. Non-text formats such as MsWord or Excel should be Base64 encoded in the source string. |
| CultureName | string | Name of culture to be used for culture-sensitive data, such as dates or multi-language texts. Use a blank string to accept current culture that is set on the server. |
| ContactId | int32 | Identifier for a contact |
| PersonId | int32 | Identifier for a person |
| ProjectId | int32 | Identifier for a project |
| SelectionId | int32 | Identifier for a selection |
| AppointmentId | int32 | Identifier for an appointment |
| DocumentId | int32 | Identifier for a document |
| SaleId | int32 | Identifier for a sale |
| QuoteLineId | int32 | Quote line id |
| QuoteAlternativeId | int32 | Quote alternative id |
| ProductKey | string | Product key |
| CustomTags | array | Array with custom tags and values. Array may be of unlimited height, but need to be exactly 2 in width. |
| DocumentEntity |  | Custom document entity to use for data retrieval. Useful for unsaved data.  DocumentEntity.DocumentId need to match the DocumentId specified in separate property. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Document/CreateDefaultTemplateVariablesParameters
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SourceInput": "qui",
  "Encoding": "Html",
  "CultureName": "en",
  "ContactId": 531,
  "PersonId": 417,
  "ProjectId": 875,
  "SelectionId": 129,
  "AppointmentId": 946,
  "DocumentId": 967,
  "SaleId": 437,
  "QuoteLineId": 287,
  "QuoteAlternativeId": 513,
  "ProductKey": "sed",
  "CustomTags": [
    [
      {}
    ],
    [
      {}
    ]
  ],
  "DocumentEntity": {
    "DocumentId": 515,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "doloribus",
    "Header": "consequatur",
    "Name": "Pagac Group",
    "OurRef": "qui",
    "YourRef": "est",
    "CreatedDate": "2017-09-16T16:48:29.3778937+02:00",
    "UpdatedDate": "2002-09-12T16:48:29.3778937+02:00",
    "Description": "Multi-tiered scalable projection",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "1994-12-07T16:48:29.3778937+01:00",
    "ExternalRef": "asperiores",
    "Completed": "Completed",
    "ActiveLinks": 270,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 633,
    "Snum": 876,
    "UserDefinedFields": {
      "SuperOffice:1": "Mr. Jackeline Pacocha",
      "SuperOffice:2": "1065850189"
    },
    "ExtraFields": {
      "ExtraFields1": "earum",
      "ExtraFields2": "architecto"
    },
    "CustomFields": {
      "CustomFields1": "corrupti",
      "CustomFields2": "mollitia"
    },
    "PublishEventDate": "2017-01-04T16:48:29.3788937+01:00",
    "PublishTo": "1994-08-26T16:48:29.3788937+02:00",
    "PublishFrom": "2005-06-16T16:48:29.3788937+02:00",
    "IsPublished": false,
    "VisibleFor": [
      {},
      {}
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 162
      }
    }
  },
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
      "FieldLength": 246
    }
  }
}
```