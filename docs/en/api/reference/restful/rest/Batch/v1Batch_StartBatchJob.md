---
title: POST BatchTask
uid: v1Batch_StartBatchJob
---

# POST BatchTask

```http
POST /api/v1/BatchTask
```

Start a batch job based on BatchTaskInfo.








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

## Request Body: batchTaskInfo  

Use BatchTaskInfo to describe the new batch job. 

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


## Response: int32

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: int32


## Sample request

```http!
POST /api/v1/BatchTask
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Id": 674,
  "Name": "Gerhold Inc and Sons",
  "AssociateId": 920,
  "DetailsTable": 98,
  "DetailsRecord": 303,
  "IsSystemTask": false,
  "IsInternalTask": false,
  "ParameterObject": {
    "ParameterObject1": "aperiam",
    "ParameterObject2": "corporis"
  },
  "LastStarted": "1999-01-09T02:49:51.6710218+01:00",
  "Created": "1998-03-31T02:49:51.6710218+02:00",
  "StartCount": 619,
  "DatabaseSerialNumber": "690319",
  "Context": "occaecati",
  "Result": "molestiae",
  "State": "All",
  "Description": "Synergized incremental focus group",
  "Response": "cumque",
  "Request": "odio",
  "ProgressDescription": "Cross-platform responsive policy",
  "ProgressPercent": 587,
  "FileName": "Hackett Group"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

111
```