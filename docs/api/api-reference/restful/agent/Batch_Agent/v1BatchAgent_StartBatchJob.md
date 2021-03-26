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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "BatchTaskInfo": {
    "Id": 97,
    "Name": "Stracke-Daugherty",
    "AssociateId": 357,
    "DetailsTable": 676,
    "DetailsRecord": 147,
    "IsSystemTask": true,
    "IsInternalTask": false,
    "ParameterObject": {
      "ParameterObject1": "consequuntur",
      "ParameterObject2": "sit"
    },
    "LastStarted": "2010-03-13T16:48:28.7791986+01:00",
    "Created": "2002-07-02T16:48:28.7791986+02:00",
    "StartCount": 407,
    "DatabaseSerialNumber": "643870",
    "Context": "libero",
    "Result": "quisquam",
    "State": "All",
    "Description": "Diverse high-level application",
    "Response": "vitae",
    "Request": "aut",
    "ProgressDescription": "Public-key dedicated pricing structure",
    "ProgressPercent": 590
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

563
```