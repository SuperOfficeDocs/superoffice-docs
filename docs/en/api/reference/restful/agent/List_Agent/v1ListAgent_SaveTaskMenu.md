---
title: POST Agents/List/SaveTaskMenu
uid: v1ListAgent_SaveTaskMenu
generated: true
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
| ProgId | String | String key that can be used to uniquely retrieve the task menu; particularly useful for partners and others who do not wish to store database ID's |
| Deleted | Boolean | True if deleted |

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
| ProgId | string | String key that can be used to uniquely retrieve the task menu; particularly useful for partners and others who do not wish to store database ID's |
| Deleted | bool | True if deleted |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/SaveTaskMenu
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TaskMenuId": 687,
  "Name": "Bosco, Kling and Johns",
  "Tooltip": "et",
  "TableName": "King Group",
  "Area": "possimus",
  "UrlOrSoprotocol": "http://www.example.com/",
  "TaskType": "CrmScript",
  "CrmScriptId": 881,
  "ShowInClient": "Mobile",
  "ArchiveBehaviour": "InArchives",
  "Rank": 848,
  "Encoding": "ANSI",
  "ProgId": "qui",
  "Deleted": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TaskMenuId": 97,
  "Name": "Mayert, Kuvalis and Emard",
  "Tooltip": "numquam",
  "TableName": "Ferry, Marks and Yundt",
  "Area": "dolorum",
  "UrlOrSoprotocol": "http://www.example.com/",
  "TaskType": "CrmScript",
  "CrmScriptId": 610,
  "ShowInClient": "Mobile",
  "ArchiveBehaviour": "InArchives",
  "Rank": 749,
  "Encoding": "ANSI",
  "ProgId": "odit",
  "Deleted": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 357
    }
  }
}
```