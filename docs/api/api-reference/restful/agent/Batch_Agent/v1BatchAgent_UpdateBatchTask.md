---
title: POST Agents/Batch/UpdateBatchTask
id: v1BatchAgent_UpdateBatchTask
---

# POST Agents/Batch/UpdateBatchTask

```http
POST /api/v1/Agents/Batch/UpdateBatchTask
```

Update information about a BatchTask.

Only the following properties can be updated: State, Description, Response and Request.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Batch/UpdateBatchTask?$select=name,department,category/id
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

BatchTaskInfo 

| Property Name | Type |  Description |
|----------------|------|--------------|
| BatchTaskInfo |  | BatchTaskInfo contains information about one batch task. <para /> Carrier object for BatchTaskInfo. Services for the BatchTaskInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IBatchAgent">Batch Agent</see>. |


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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Batch/UpdateBatchTask
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "BatchTaskInfo": {
    "Id": 189,
    "Name": "Bins, Yost and Johns",
    "AssociateId": 98,
    "DetailsTable": 214,
    "DetailsRecord": 95,
    "IsSystemTask": true,
    "IsInternalTask": true,
    "ParameterObject": {
      "ParameterObject1": "aut",
      "ParameterObject2": "in"
    },
    "LastStarted": "2014-10-13T16:48:28.7801984+02:00",
    "Created": "2001-05-19T16:48:28.7801984+02:00",
    "StartCount": 775,
    "DatabaseSerialNumber": "1303795",
    "Context": "quisquam",
    "Result": "et",
    "State": "All",
    "Description": "Upgradable grid-enabled product",
    "Response": "aperiam",
    "Request": "repellendus",
    "ProgressDescription": "Profound high-level open architecture",
    "ProgressPercent": 932
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 475,
  "Name": "Wiegand Group",
  "AssociateId": 101,
  "DetailsTable": 533,
  "DetailsRecord": 406,
  "IsSystemTask": true,
  "IsInternalTask": false,
  "ParameterObject": {
    "ParameterObject1": "sunt",
    "ParameterObject2": "ipsa"
  },
  "LastStarted": "2004-01-30T16:48:28.7801984+01:00",
  "Created": "2013-05-22T16:48:28.7801984+02:00",
  "StartCount": 110,
  "DatabaseSerialNumber": "519584",
  "Context": "nihil",
  "Result": "amet",
  "State": "All",
  "Description": "Multi-tiered next generation collaboration",
  "Response": "et",
  "Request": "illum",
  "ProgressDescription": "Fundamental cohesive success",
  "ProgressPercent": 452,
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
      "FieldLength": 452
    }
  }
}
```