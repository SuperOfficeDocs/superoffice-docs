---
title: POST Agents/Batch/GetSystemBatchTaskInfosByName
uid: v1BatchAgent_GetSystemBatchTaskInfosByName
---

# POST Agents/Batch/GetSystemBatchTaskInfosByName

```http
POST /api/v1/Agents/Batch/GetSystemBatchTaskInfosByName
```

Get an array of system BatchTaskInfo for the provided task name.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Batch/GetSystemBatchTaskInfosByName?$select=name,department,category/id
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

TaskName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TaskName | String |  |

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Batch/GetSystemBatchTaskInfosByName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TaskName": "Morissette, Sipes and Boyle"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 246,
    "Name": "Gleichner-Jacobson",
    "AssociateId": 549,
    "DetailsTable": 933,
    "DetailsRecord": 286,
    "IsSystemTask": false,
    "IsInternalTask": false,
    "ParameterObject": {
      "ParameterObject1": "consectetur",
      "ParameterObject2": "amet"
    },
    "LastStarted": "2007-09-16T14:19:02.7750538+02:00",
    "Created": "2013-11-24T14:19:02.7750538+01:00",
    "StartCount": 652,
    "DatabaseSerialNumber": "1223608",
    "Context": "impedit",
    "Result": "qui",
    "State": "All",
    "Description": "Assimilated bi-directional encoding",
    "Response": "modi",
    "Request": "exercitationem",
    "ProgressDescription": "Configurable bifurcated circuit",
    "ProgressPercent": 852,
    "FileName": "Pfeffer, Schoen and Lang",
    "CancellationBehaviour": "CanCancel",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 63
      }
    }
  }
]
```