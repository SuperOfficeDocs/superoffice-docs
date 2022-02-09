---
title: PUT BatchTask/{Id}
id: v1Batch_UpdateBatchTask
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


## Response: object

BatchTaskInfo contains information about one batch task.



Carrier object for BatchTaskInfo.
Services for the BatchTaskInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IBatchAgent">Batch Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
PUT /api/v1/BatchTask/{Id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Id": 122,
  "Name": "Sauer-Russel",
  "AssociateId": 907,
  "DetailsTable": 35,
  "DetailsRecord": 972,
  "IsSystemTask": false,
  "IsInternalTask": false,
  "ParameterObject": {
    "ParameterObject1": "magnam",
    "ParameterObject2": "fugiat"
  },
  "LastStarted": "2009-11-16T18:25:51.328106+01:00",
  "Created": "2001-05-28T18:25:51.328106+02:00",
  "StartCount": 243,
  "DatabaseSerialNumber": "1413032",
  "Context": "tempora",
  "Result": "molestiae",
  "State": "All",
  "Description": "Profit-focused contextually-based groupware",
  "Response": "sint",
  "Request": "sint",
  "ProgressDescription": "Balanced interactive utilisation",
  "ProgressPercent": 234,
  "FileName": "Borer-Gerhold"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 387,
  "Name": "Schinner-Runolfsson",
  "AssociateId": 332,
  "DetailsTable": 392,
  "DetailsRecord": 385,
  "IsSystemTask": false,
  "IsInternalTask": true,
  "ParameterObject": {
    "ParameterObject1": "occaecati",
    "ParameterObject2": "enim"
  },
  "LastStarted": "1996-04-04T18:25:51.3291057+02:00",
  "Created": "1995-11-03T18:25:51.3291057+01:00",
  "StartCount": 254,
  "DatabaseSerialNumber": "1165074",
  "Context": "nemo",
  "Result": "fuga",
  "State": "All",
  "Description": "Integrated dedicated collaboration",
  "Response": "neque",
  "Request": "non",
  "ProgressDescription": "Reverse-engineered systematic orchestration",
  "ProgressPercent": 325,
  "FileName": "Graham LLC",
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
      "FieldLength": 867
    }
  }
}
```