---
title: GET Document/{id}/Command
id: v1DocumentEntity_GetDocumentCommands
---

# GET Document/{id}/Command

```http
GET /api/v1/Document/{documentId}/Command
```

Get a list of custom commands valid for the specific document at this time.

This information should not be cached by clients, as it may change between documents and over time.




| Path Part | Type | Description |
|-----------|------|-------------|
| documentId | int32 | SuperOffice document ID **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| allowedReturnTypes | array |  List of return types that the client is prepared to handle, in case the document plugin needs to request additional processing.&lt;br/&gt;Standard allowed return types include 'None', 'Message', 'SoProtocol', 'CustomGui', 'Other'.&lt;br/&gt;An empty array implies that the client places no restriction on possible return action requests.&lt;br/&gt;In this context the parameter is used to filter the returned command list, so that commands that require return actions not supported, will not be included by the document plugin. |

```http
GET /api/v1/Document/{documentId}/Command?allowedReturnTypes=Message
```


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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string |  |
| DisplayName | string |  |
| DisplayTooltip | string |  |
| IconHint | string |  |
| ReturnType | string |  |

## Sample Request

```http!
GET /api/v1/Document/{documentId}/Command
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Haag-Botsford",
    "DisplayName": "Harris Inc and Sons",
    "DisplayTooltip": "laborum",
    "IconHint": "quidem",
    "ReturnType": "CustomGui"
  },
  {
    "Name": "Haag-Botsford",
    "DisplayName": "Harris Inc and Sons",
    "DisplayTooltip": "laborum",
    "IconHint": "quidem",
    "ReturnType": "CustomGui"
  }
]
```