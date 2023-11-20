---
title: POST Agents/CustomerService/GetParsedTemplate
uid: v1CustomerServiceAgent_GetParsedTemplate
generated: true
---

# POST Agents/CustomerService/GetParsedTemplate

```http
POST /api/v1/Agents/CustomerService/GetParsedTemplate
```

Get a specific langauge version of the reply template, and run this trough the parser







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomerService/GetParsedTemplate?$select=name,department,category/id
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

ReplyTemplateId, LanguageId, PersonId, TicketId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ReplyTemplateId | Integer |  |
| LanguageId | Integer |  |
| PersonId | Integer |  |
| TicketId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ReplyTemplateParsed

| Property Name | Type |  Description |
|----------------|------|--------------|
| ReplyTemplateId | int32 | The primary key (auto-incremented) |
| PlainParsed | string | The plain text version of the reply template, and if applicable parsed with customer and ticket data |
| HtmlParsed | string | The HTML version of the reply template, and if applicable parsed with customer and ticket data |
| Attachments | array | Meta data for the connected attachments |
| Subject | string | The subject for this reply template |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/CustomerService/GetParsedTemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ReplyTemplateId": 407,
  "LanguageId": 114,
  "PersonId": 936,
  "TicketId": 339
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ReplyTemplateId": 153,
  "PlainParsed": "laudantium",
  "HtmlParsed": "assumenda",
  "Attachments": [
    {
      "AttachmentId": 817,
      "Name": "Murphy Inc and Sons",
      "ContentType": "expedita",
      "AttSize": 132,
      "InlineImage": true,
      "ContentId": "quas",
      "AuthKey": "deleniti",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 549
        }
      }
    }
  ],
  "Subject": "in",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 746
    }
  }
}
```