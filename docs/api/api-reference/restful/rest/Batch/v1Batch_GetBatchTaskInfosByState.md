---
title: GET BatchTask/{state}
id: v1Batch_GetBatchTaskInfosByState
---

# GET BatchTask/{state}

```http
GET /api/v1/BatchTask/{state}
```

Gets an array of BatchTaskInfo with state defined by a BatchTaskState.






| Path Part | Type | Description |
|-----------|------|-------------|
| state | Enum: Unknown, New, Aquired, Started, Succeeded, Failed, SucceededManualCleanup, All | The BatchTaskState to get batch tasks for. **Required** |



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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/BatchTask/{state}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 832,
    "Name": "Auer, Gaylord and Spencer",
    "AssociateId": 702,
    "DetailsTable": 40,
    "DetailsRecord": 947,
    "IsSystemTask": false,
    "IsInternalTask": true,
    "ParameterObject": {
      "ParameterObject1": "ipsam",
      "ParameterObject2": "et"
    },
    "LastStarted": "2010-09-20T15:05:42.9696325+02:00",
    "Created": "2012-05-05T15:05:42.9696325+02:00",
    "StartCount": 268,
    "DatabaseSerialNumber": "651269",
    "Context": "quisquam",
    "Result": "consectetur",
    "State": "All",
    "Description": "Operative clear-thinking firmware",
    "Response": "et",
    "Request": "magni",
    "ProgressDescription": "Optimized composite standardization",
    "ProgressPercent": 332,
    "FileName": "Mitchell Inc and Sons",
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
        "FieldType": "System.String",
        "FieldLength": 600
      }
    }
  }
]
```