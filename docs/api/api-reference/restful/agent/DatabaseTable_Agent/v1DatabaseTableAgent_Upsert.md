---
title: POST Agents/DatabaseTable/Upsert
id: v1DatabaseTableAgent_Upsert
---

# POST Agents/DatabaseTable/Upsert

```http
POST /api/v1/Agents/DatabaseTable/Upsert
```

Insert or update rows



## Online Restricted: ## The DatabaseTable agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/DatabaseTable/Upsert?$select=name,department,category/id
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

TableName, Columns, Keys, DeleteUnmatched, Data 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TableName | string |  |
| Columns | array |  |
| Keys | array |  |
| DeleteUnmatched | bool |  |
| Data | array |  |


## Response: object

Information about the results of a mass-update operation



Carrier object for MassOperationResult.
Services for the MassOperationResult Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDatabaseTableAgent">DatabaseTable Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Success | bool | Did the operation succeed |
| Message | string | Any message from the method; blank if success |
| Inserts | int32 | Number of rows inserted |
| Updates | int32 | Number of rows updated |
| Deletes | int32 | Number of rows deleted |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/DatabaseTable/Upsert
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TableName": "Eichmann, Gutmann and Cormier",
  "Columns": [
    "quo",
    "natus"
  ],
  "Keys": [
    "debitis",
    "et"
  ],
  "DeleteUnmatched": false,
  "Data": [
    [
      {}
    ],
    [
      {}
    ]
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Success": false,
  "Message": "nobis",
  "Inserts": 946,
  "Updates": 728,
  "Deletes": 764,
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
      "FieldLength": 906
    }
  }
}
```