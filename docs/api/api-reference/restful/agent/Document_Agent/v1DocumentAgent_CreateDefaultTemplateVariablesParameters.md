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
  "SourceInput": "voluptatum",
  "Encoding": "Html",
  "CultureName": "sv",
  "ContactId": 723,
  "PersonId": 716,
  "ProjectId": 503,
  "SelectionId": 161,
  "AppointmentId": 633,
  "DocumentId": 135,
  "SaleId": 431,
  "QuoteLineId": 550,
  "QuoteAlternativeId": 980,
  "ProductKey": "nisi",
  "CustomTags": [
    [
      {}
    ],
    [
      {}
    ]
  ],
  "DocumentEntity": {
    "DocumentId": 977,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "quaerat",
    "Header": "repudiandae",
    "Name": "Howell, Romaguera and Lindgren",
    "OurRef": "autem",
    "YourRef": "laborum",
    "CreatedDate": "2018-10-22T18:28:48.851928+02:00",
    "UpdatedDate": "2018-10-15T18:28:48.851928+02:00",
    "Description": "Streamlined coherent implementation",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "2013-11-27T18:28:48.851928+01:00",
    "ExternalRef": "ut",
    "Completed": "Completed",
    "ActiveLinks": 518,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 898,
    "Snum": 506,
    "UserDefinedFields": {
      "SuperOffice:1": "316096575",
      "SuperOffice:2": "519641431"
    },
    "ExtraFields": {
      "ExtraFields1": "aut",
      "ExtraFields2": "fugiat"
    },
    "CustomFields": {
      "CustomFields1": "ipsa",
      "CustomFields2": "qui"
    },
    "PublishEventDate": "2004-04-18T18:28:48.851928+02:00",
    "PublishTo": "1995-03-01T18:28:48.851928+01:00",
    "PublishFrom": "2002-01-27T18:28:48.851928+01:00",
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
        "FieldType": "System.Int32",
        "FieldLength": 889
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
      "FieldLength": 688
    }
  }
}
```