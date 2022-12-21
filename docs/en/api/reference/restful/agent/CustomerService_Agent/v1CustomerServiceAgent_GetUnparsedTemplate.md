---
title: POST Agents/CustomerService/GetUnparsedTemplate
uid: v1CustomerServiceAgent_GetUnparsedTemplate
---

# POST Agents/CustomerService/GetUnparsedTemplate

```http
POST /api/v1/Agents/CustomerService/GetUnparsedTemplate
```

Get a specific langauge version of the reply template.


No parsing is performed.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomerService/GetUnparsedTemplate?$select=name,department,category/id
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

ReplyTemplateId, LanguageId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ReplyTemplateId | int32 |  |
| LanguageId | int32 |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ReplyTemplateId | int32 | The primary key (auto-incremented) |
| PlainParsed | string | The plain text version of the reply template, and if applicable parsed with customer and ticket data |
| HtmlParsed | string | The HTML version of the reply template, and if applicable parsed with customer and ticket data |
| Attachments | array | Meta data for the connected attachments |
| Subject | string | The subject for this reply template |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/CustomerService/GetUnparsedTemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ReplyTemplateId": 624,
  "LanguageId": 564
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ReplyTemplateId": 624,
  "PlainParsed": "enim",
  "HtmlParsed": "repellat",
  "Attachments": [
    {
      "AttachmentId": 781,
      "Name": "Kautzer-Braun",
      "ContentType": "consequatur",
      "AttSize": 366,
      "InlineImage": false,
      "ContentId": "aut",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 740
        }
      }
    }
  ],
  "Subject": "blanditiis",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 273
    }
  }
}
```