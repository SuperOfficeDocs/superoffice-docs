---
title: POST Agents/List/SaveTaskMenu
uid: v1ListAgent_SaveTaskMenu
---

# POST Agents/List/SaveTaskMenu

```http
POST /api/v1/Agents/List/SaveTaskMenu
```

Updates the existing TaskMenu or creates a new TaskMenu if the id parameter is empty








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

## Request Body: entity 

The TaskMenu to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TaskMenuId | Integer | Primary key |
| Name | String | The list item |
| Tooltip | String | Tooltip or other description |
| TableName | String | The name of entity that this task item can be used at |
| Area | String | Can be Task or other that can identify which menu recipe to merge the item into |
| UrlOrSoprotocol | String | The url or soprotocol |
| TaskType | String | Type of task item Url, SoProtocol or CRMScript. |
| CrmScriptId | Integer | The CRMScript or Macro which will be run task item is selected. |
| ShowInClient | String | Show task list item in which clients (web, mobile) |
| ArchiveBehaviour | String | None, rightclick on, multiselect |
| Rank | Integer | Rank order |
| Encoding | String | Encoding for url |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TaskMenu

| Property Name | Type |  Description |
|----------------|------|--------------|
| TaskMenuId | int32 | Primary key |
| Name | string | The list item |
| Tooltip | string | Tooltip or other description |
| TableName | string | The name of entity that this task item can be used at |
| Area | string | Can be Task or other that can identify which menu recipe to merge the item into |
| UrlOrSoprotocol | string | The url or soprotocol |
| TaskType | string | Type of task item Url, SoProtocol or CRMScript. |
| CrmScriptId | int32 | The CRMScript or Macro which will be run task item is selected. |
| ShowInClient | string | Show task list item in which clients (web, mobile) |
| ArchiveBehaviour | string | None, rightclick on, multiselect |
| Rank | int32 | Rank order |
| Encoding | string | Encoding for url |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/List/SaveTaskMenu
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TaskMenuId": 56,
  "Name": "King-Rath",
  "Tooltip": "quisquam",
  "TableName": "Mohr-Mueller",
  "Area": "porro",
  "UrlOrSoprotocol": "http://www.example.com/",
  "TaskType": "CrmScript",
  "CrmScriptId": 140,
  "ShowInClient": "Mobile",
  "ArchiveBehaviour": "InArchives",
  "Rank": 120,
  "Encoding": "ANSI"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TaskMenuId": 834,
  "Name": "McDermott Inc and Sons",
  "Tooltip": "accusamus",
  "TableName": "Adams-Marquardt",
  "Area": "est",
  "UrlOrSoprotocol": "http://www.example.com/",
  "TaskType": "CrmScript",
  "CrmScriptId": 629,
  "ShowInClient": "Mobile",
  "ArchiveBehaviour": "InArchives",
  "Rank": 980,
  "Encoding": "ANSI",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 321
    }
  }
}
```