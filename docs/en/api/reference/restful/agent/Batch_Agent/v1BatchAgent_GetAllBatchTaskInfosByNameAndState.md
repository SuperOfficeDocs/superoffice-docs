---
title: POST Agents/Batch/GetAllBatchTaskInfosByNameAndState
uid: v1BatchAgent_GetAllBatchTaskInfosByNameAndState
generated: true
---

# POST Agents/Batch/GetAllBatchTaskInfosByNameAndState

```http
POST /api/v1/Agents/Batch/GetAllBatchTaskInfosByNameAndState
```

Get an array of system and user BatchTaskInfo for the provided task name and state.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Batch/GetAllBatchTaskInfosByNameAndState?$select=name,department,category/id
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

TaskName, State 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TaskName | String |  |
| State | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | Id of the task. |
| Name | string | Name of the task. |
| AssociateId | int32 | Task owner. If it is a System task, AssociateId = 0. |
| DetailsTable | int32 | Id of table with more information about the task. |
| DetailsRecord | int32 | Record Id of a row in the DetailsTable containing more info about the task. |
| IsSystemTask | bool | If IsSystemTask is true, the task is not initiated by an associate. |
| IsInternalTask | bool | If IsInternalTask is true, this task will not add a trace to the database. |
| ParameterObject | object | ParameterObject will be serialized to a binary blob and saved in the BinaryObject table. The link to the BinaryObject will be set using DetailsTable and DetailsRecord. |
| LastStarted | date-time | When was the task last started. |
| Created | date-time | Task creation time. |
| StartCount | int32 | Maps to the startcount field in the batchtask table. |
| DatabaseSerialNumber | string | Serial number of the database the task is to run on. |
| Context | string | Context for the executing task. |
| Result | string | Maps to the result field in the batchtask table. |
| State | string | BatchTaskState of the task. |
| Description | string | Description of the task. |
| Response | string | Maps to the response field in the batchtask table. |
| Request | string | Maps to the request field in the batchtask table. |
| ProgressDescription | string | Descriptive text for the current stage |
| ProgressPercent | int32 | Task progress, in percent of estimated total |
| FileName | string | The filename related to the batchtask. |
| CancellationBehaviour | string | Indicate if the task can be stopped. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Batch/GetAllBatchTaskInfosByNameAndState
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TaskName": "O'Reilly Group",
  "State": "All"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 798,
    "Name": "Schamberger-Conroy",
    "AssociateId": 465,
    "DetailsTable": 502,
    "DetailsRecord": 625,
    "IsSystemTask": false,
    "IsInternalTask": true,
    "ParameterObject": {
      "ParameterObject1": "soluta",
      "ParameterObject2": "autem"
    },
    "LastStarted": "2021-03-15T13:13:59.5314453+01:00",
    "Created": "2023-01-03T13:13:59.5314453+01:00",
    "StartCount": 824,
    "DatabaseSerialNumber": "868019",
    "Context": "vitae",
    "Result": "commodi",
    "State": "All",
    "Description": "Cross-group systemic moderator",
    "Response": "esse",
    "Request": "nihil",
    "ProgressDescription": "Progressive neutral emulation",
    "ProgressPercent": 418,
    "FileName": "Kihn, Sawayn and Mraz",
    "CancellationBehaviour": "CanCancel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 328
      }
    }
  }
]
```