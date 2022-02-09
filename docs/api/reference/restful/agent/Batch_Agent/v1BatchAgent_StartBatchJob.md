---
title: POST Agents/Batch/StartBatchJob
id: v1BatchAgent_StartBatchJob
---

# POST Agents/Batch/StartBatchJob

```http
POST /api/v1/Agents/Batch/StartBatchJob
```

Start a batch job based on BatchTaskInfo.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Batch/StartBatchJob?$select=name,department,category/id
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


## Response: int32



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: int32


## Sample Request

```http!
POST /api/v1/Agents/Batch/StartBatchJob
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "BatchTaskInfo": {
    "Id": 624,
    "Name": "Ankunding LLC",
    "AssociateId": 368,
    "DetailsTable": 454,
    "DetailsRecord": 2,
    "IsSystemTask": false,
    "IsInternalTask": false,
    "ParameterObject": {
      "ParameterObject1": "omnis",
      "ParameterObject2": "delectus"
    },
    "LastStarted": "2005-06-06T18:28:48.1425438+02:00",
    "Created": "2019-08-26T18:28:48.1425438+02:00",
    "StartCount": 445,
    "DatabaseSerialNumber": "1116185",
    "Context": "quo",
    "Result": "cum",
    "State": "All",
    "Description": "Balanced upward-trending conglomeration",
    "Response": "illum",
    "Request": "ut",
    "ProgressDescription": "Reduced attitude-oriented open architecture",
    "ProgressPercent": 722,
    "FileName": "Lemke, Miller and Upton"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

440
```