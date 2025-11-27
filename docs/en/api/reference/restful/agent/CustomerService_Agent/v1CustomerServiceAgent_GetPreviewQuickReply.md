---
title: POST Agents/CustomerService/GetPreviewQuickReply
uid: v1CustomerServiceAgent_GetPreviewQuickReply
generated: true
content_type: reference
---

# POST Agents/CustomerService/GetPreviewQuickReply

```http
POST /api/v1/Agents/CustomerService/GetPreviewQuickReply
```

Get a quick reply from its quick reply id


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomerService/GetPreviewQuickReply?$select=name,department,category/id
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

QuickReplyId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuickReplyId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PreviewQuickReply

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | The short name of the quick reply |
| UpdatedByFullName | string | Full name of associate last updating this quick reply |
| Updated | date-time | Date/time this quick reply was last updated. |
| HtmlBody | string | Quick reply body in HTML format. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/agent/request/v1CustomerServiceAgent_GetPreviewQuickReply.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1CustomerServiceAgent_GetPreviewQuickReply.md)]