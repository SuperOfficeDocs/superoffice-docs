---
title: POST Agents/ErpSync/GetDefaultValueInfo
uid: v1ErpSyncAgent_GetDefaultValueInfo
generated: true
---

# POST Agents/ErpSync/GetDefaultValueInfo

```http
POST /api/v1/Agents/ErpSync/GetDefaultValueInfo
```

Get information about default value for an ERP field


## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ErpSync/GetDefaultValueInfo?$select=name,department,category/id
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

ErpFieldId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpFieldId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ErpSyncDefaultValue

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpFieldId | int32 | Primary key |
| DefaultValue | string | Default value, stored using CultureDataFormatter format if it is not a string |
| HasFirstSyncDefaultValue | bool | Should a default value be set on first sync |
| FirstSyncDefaultValue | string | The default value to be set, can be blank |
| PromptUser | bool | Should the field be shown in the first-sync GUI; independent of whether a default value should be set |
| Mandatory | bool | Should the user be forced to set a value (the Erp Connector may declare fields mandatory as well) |
| ErpFieldKey | string | The ERP field key |
| FieldType | string | Field type |
| ListName | string | The ERP list name, if the field has a list of values supplied by the ERP Connector |
| Access | string | Access restrictions for the field |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/ErpSync/GetDefaultValueInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ErpFieldId": 98
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ErpFieldId": 529,
  "DefaultValue": "unde",
  "HasFirstSyncDefaultValue": false,
  "FirstSyncDefaultValue": "itaque",
  "PromptUser": true,
  "Mandatory": false,
  "ErpFieldKey": "et",
  "FieldType": "Checkbox",
  "ListName": "Runte Inc and Sons",
  "Access": "Mandatory",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 854
    }
  }
}
```