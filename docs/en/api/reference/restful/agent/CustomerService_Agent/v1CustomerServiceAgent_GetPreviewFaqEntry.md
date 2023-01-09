---
title: POST Agents/CustomerService/GetPreviewFaqEntry
uid: v1CustomerServiceAgent_GetPreviewFaqEntry
---

# POST Agents/CustomerService/GetPreviewFaqEntry

```http
POST /api/v1/Agents/CustomerService/GetPreviewFaqEntry
```

Get a faq entry from its faq entry id







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomerService/GetPreviewFaqEntry?$select=name,department,category/id
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

KbEntryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| KbEntryId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PreviewFaqEntry

| Property Name | Type |  Description |
|----------------|------|--------------|
| Title | string | The title of this entry. |
| RegisteredByFullName | string | Full name of associate that created this faq entry |
| Updated | date-time | Date/time this faq entry was last updated. |
| Question | string | The question for this entry. |
| Answer | string | The answer for this entry. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/CustomerService/GetPreviewFaqEntry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "KbEntryId": 318
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Title": "numquam",
  "RegisteredByFullName": "Danielle Welch",
  "Updated": "2022-07-05T17:37:17.3502415+02:00",
  "Question": "temporibus",
  "Answer": "ab",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 477
    }
  }
}
```