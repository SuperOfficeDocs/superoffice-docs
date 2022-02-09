---
title: POST Agents/CustomerService/GetParsedTemplate
id: v1CustomerServiceAgent_GetParsedTemplate
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
| ReplyTemplateId | int32 |  |
| LanguageId | int32 |  |
| PersonId | int32 |  |
| TicketId | int32 |  |


## Response: object

Reply template with parsed text. Represent one language version of reply template



Carrier object for ReplyTemplateParsed.
Services for the ReplyTemplateParsed Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICustomerServiceAgent">CustomerService Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ReplyTemplateId | int32 | The primary key (auto-incremented) |
| PlainParsed | string | The plain text version of the reply template, and if applicable parsed with customer and ticket data |
| HtmlParsed | string | The HTML version of the reply template, and if applicable parsed with customer and ticket data |
| Attachments | array | Meta data for the connected attachments |
| Subject | string | The subject for this reply template |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/CustomerService/GetParsedTemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ReplyTemplateId": 252,
  "LanguageId": 340,
  "PersonId": 603,
  "TicketId": 267
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ReplyTemplateId": 342,
  "PlainParsed": "nisi",
  "HtmlParsed": "qui",
  "Attachments": [
    {
      "AttachmentId": 618,
      "Name": "Dickinson LLC",
      "ContentType": "incidunt",
      "AttSize": 455,
      "InlineImage": false,
      "ContentId": "est",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 319
        }
      }
    }
  ],
  "Subject": "rerum",
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
      "FieldLength": 982
    }
  }
}
```