---
title: POST Agents/List/CreateDefaultTaskMenu
uid: v1ListAgent_CreateDefaultTaskMenu
---

# POST Agents/List/CreateDefaultTaskMenu

```http
POST /api/v1/Agents/List/CreateDefaultTaskMenu
```

Set default values into a new TaskMenu.


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
POST /api/v1/Agents/List/CreateDefaultTaskMenu
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TaskMenuId": 449,
  "Name": "West-Schinner",
  "Tooltip": "sed",
  "TableName": "Schowalter-Treutel",
  "Area": "ut",
  "UrlOrSoprotocol": "http://www.example.com/",
  "TaskType": "CrmScript",
  "CrmScriptId": 571,
  "ShowInClient": "Mobile",
  "ArchiveBehaviour": "InArchives",
  "Rank": 902,
  "Encoding": "ANSI",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 881
    }
  }
}
```