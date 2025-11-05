---
title: PUT BatchTask/{Id}
uid: v1Batch_UpdateBatchTask
generated: true
content_type: reference
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
  "Id": 244,
  "Name": "Schmitt-Schneider",
  "AssociateId": 179,
  "DetailsTable": 411,
  "DetailsRecord": 914,
  "IsSystemTask": true,
  "IsInternalTask": false,
  "ParameterObject": {
    "ParameterObject1": "nam",
    "ParameterObject2": "asperiores"
  },
  "LastStarted": "2010-04-05T02:30:53.0380235+02:00",
  "Created": "2003-10-09T02:30:53.0380235+02:00",
  "StartCount": 172,
  "DatabaseSerialNumber": "639254",
  "Context": "accusantium",
  "Result": "cum",
  "State": "All",
  "Description": "Exclusive value-added secured line",
  "Response": "magnam",
  "Request": "aut",
  "ProgressDescription": "Re-contextualized even-keeled artificial intelligence",
  "ProgressPercent": 139,
  "FileName": "Turner LLC",
  "CancellationBehaviour": "CanCancel"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 261,
  "Name": "Jones, Spencer and Ruecker",
  "AssociateId": 520,
  "DetailsTable": 423,
  "DetailsRecord": 830,
  "IsSystemTask": false,
  "IsInternalTask": false,
  "ParameterObject": {
    "ParameterObject1": "aut",
    "ParameterObject2": "ducimus"
  },
  "LastStarted": "2023-07-04T02:30:53.0380235+02:00",
  "Created": "2001-08-06T02:30:53.0380235+02:00",
  "StartCount": 327,
  "DatabaseSerialNumber": "923069",
  "Context": "molestiae",
  "Result": "quia",
  "State": "All",
  "Description": "Profit-focused asynchronous knowledge base",
  "Response": "molestias",
  "Request": "corrupti",
  "ProgressDescription": "User-friendly system-worthy project",
  "ProgressPercent": 398,
  "FileName": "Beier Inc and Sons",
  "CancellationBehaviour": "CanCancel",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 760
    }
  }
}
```