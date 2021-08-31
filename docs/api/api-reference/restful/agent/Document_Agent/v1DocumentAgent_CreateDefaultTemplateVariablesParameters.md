---
title: CreateDefaultTemplateVariablesParameters
id: v1DocumentAgent_CreateDefaultTemplateVariablesParameters
---

# CreateDefaultTemplateVariablesParameters

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
  "SourceInput": "totam",
  "Encoding": "Html",
  "CultureName": "sv",
  "ContactId": 842,
  "PersonId": 600,
  "ProjectId": 285,
  "SelectionId": 763,
  "AppointmentId": 904,
  "DocumentId": 18,
  "SaleId": 258,
  "QuoteLineId": 416,
  "QuoteAlternativeId": 521,
  "ProductKey": "voluptatum",
  "CustomTags": [
    [
      {}
    ],
    [
      {}
    ]
  ],
  "DocumentEntity": {
    "DocumentId": 49,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "voluptate",
    "Header": "reiciendis",
    "Name": "Funk-Wunsch",
    "OurRef": "alias",
    "YourRef": "deleniti",
    "CreatedDate": "2007-08-31T14:58:03.9514603+02:00",
    "UpdatedDate": "2014-09-15T14:58:03.9514603+02:00",
    "Description": "Intuitive neutral artificial intelligence",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "2018-03-25T14:58:03.9514603+02:00",
    "ExternalRef": "perferendis",
    "Completed": "Completed",
    "ActiveLinks": 159,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 865,
    "Snum": 691,
    "UserDefinedFields": {
      "SuperOffice:1": "Tess Brown",
      "SuperOffice:2": "False"
    },
    "ExtraFields": {
      "ExtraFields1": "quam",
      "ExtraFields2": "ea"
    },
    "CustomFields": {
      "CustomFields1": "consequatur",
      "CustomFields2": "corrupti"
    },
    "PublishEventDate": "2004-08-24T14:58:03.9514603+02:00",
    "PublishTo": "2017-01-07T14:58:03.9514603+01:00",
    "PublishFrom": "2002-03-26T14:58:03.9514603+01:00",
    "IsPublished": true,
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
        "FieldType": "System.String",
        "FieldLength": 317
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
      "FieldType": "System.String",
      "FieldLength": 892
    }
  }
}
```