---
title: PUT BatchTask/{Id}
uid: v1Batch_UpdateBatchTask
generated: true
---

# PUT BatchTask/{Id}

```http
PUT /api/v1/BatchTask/{Id}
```

Update information about a BatchTask.


Only the following properties can be updated: State, Description, Response and Request.





| Path Part | Type | Description |
|-----------|------|-------------|
| Id | string |  **Required** |



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

The updated information to save. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | Integer | Id of the task. |
| Name | String | Name of the task. |
| AssociateId | Integer | Task owner. If it is a System task, AssociateId = 0. |
| DetailsTable | Integer | Id of table with more information about the task. |
| DetailsRecord | Integer | Record Id of a row in the DetailsTable containing more info about the task. |
| IsSystemTask | Boolean | If IsSystemTask is true, the task is not initiated by an associate. |
| IsInternalTask | Boolean | If IsInternalTask is true, this task will not add a trace to the database. |
| ParameterObject | Object | ParameterObject will be serialized to a binary blob and saved in the BinaryObject table. The link to the BinaryObject will be set using DetailsTable and DetailsRecord. |
| LastStarted | String | When was the task last started. |
| Created | String | Task creation time. |
| StartCount | Integer | Maps to the startcount field in the batchtask table. |
| DatabaseSerialNumber | String | Serial number of the database the task is to run on. |
| Context | String | Context for the executing task. |
| Result | String | Maps to the result field in the batchtask table. |
| State | String | BatchTaskState of the task. |
| Description | String | Description of the task. |
| Response | String | Maps to the response field in the batchtask table. |
| Request | String | Maps to the request field in the batchtask table. |
| ProgressDescription | String | Descriptive text for the current stage |
| ProgressPercent | Integer | Task progress, in percent of estimated total |
| FileName | String | The filename related to the batchtask. |
| CancellationBehaviour | String | Indicate if the task can be stopped. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: BatchTaskInfo

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
PUT /api/v1/BatchTask/{Id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Id": 826,
  "Name": "Lind, Cartwright and Lemke",
  "AssociateId": 140,
  "DetailsTable": 128,
  "DetailsRecord": 317,
  "IsSystemTask": true,
  "IsInternalTask": false,
  "ParameterObject": {
    "ParameterObject1": "dolore",
    "ParameterObject2": "neque"
  },
  "LastStarted": "2014-03-11T03:45:28.7952992+01:00",
  "Created": "1999-04-23T03:45:28.7952992+02:00",
  "StartCount": 428,
  "DatabaseSerialNumber": "1332604",
  "Context": "ullam",
  "Result": "quos",
  "State": "All",
  "Description": "Managed explicit architecture",
  "Response": "itaque",
  "Request": "ducimus",
  "ProgressDescription": "Reactive object-oriented budgetary management",
  "ProgressPercent": 568,
  "FileName": "Gerhold-Feil",
  "CancellationBehaviour": "CanCancel"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 116,
  "Name": "Kerluke-Goyette",
  "AssociateId": 493,
  "DetailsTable": 982,
  "DetailsRecord": 340,
  "IsSystemTask": true,
  "IsInternalTask": false,
  "ParameterObject": {
    "ParameterObject1": "aliquid",
    "ParameterObject2": "est"
  },
  "LastStarted": "2005-06-20T03:45:28.7952992+02:00",
  "Created": "2023-04-28T03:45:28.7952992+02:00",
  "StartCount": 3,
  "DatabaseSerialNumber": "527947",
  "Context": "magni",
  "Result": "omnis",
  "State": "All",
  "Description": "Customer-focused next generation contingency",
  "Response": "ut",
  "Request": "sed",
  "ProgressDescription": "Business-focused multi-state access",
  "ProgressPercent": 398,
  "FileName": "Kshlerin Group",
  "CancellationBehaviour": "CanCancel",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 90
    }
  }
}
```