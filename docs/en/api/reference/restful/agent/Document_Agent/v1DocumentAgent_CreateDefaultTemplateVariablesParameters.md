---
title: POST Agents/Document/CreateDefaultTemplateVariablesParameters
uid: v1DocumentAgent_CreateDefaultTemplateVariablesParameters
generated: true
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TemplateVariablesParameters

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
| TicketId | int32 | Identifier for ticket |
| DocumentEntity | DocumentEntity | Custom document entity to use for data retrieval. Useful for unsaved data.  DocumentEntity.DocumentId need to match the DocumentId specified in separate property. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Document/CreateDefaultTemplateVariablesParameters
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SourceInput": "architecto",
  "Encoding": "Html",
  "CultureName": "sv",
  "ContactId": 119,
  "PersonId": 792,
  "ProjectId": 269,
  "SelectionId": 281,
  "AppointmentId": 154,
  "DocumentId": 954,
  "SaleId": 122,
  "QuoteLineId": 802,
  "QuoteAlternativeId": 381,
  "ProductKey": "rerum",
  "CustomTags": [
    [
      {}
    ],
    [
      {}
    ]
  ],
  "TicketId": 752,
  "DocumentEntity": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 893
    }
  }
}
```