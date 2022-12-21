---
title: POST Agents/ErpSync/SaveDefaultValueInfo
uid: v1ErpSyncAgent_SaveDefaultValueInfo
---

# POST Agents/ErpSync/SaveDefaultValueInfo

```http
POST /api/v1/Agents/ErpSync/SaveDefaultValueInfo
```

Save information about a default value for an ERP field




## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ErpSync/SaveDefaultValueInfo?$select=name,department,category/id
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

ErpSyncDefaultValue 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpSyncDefaultValue |  | Contains default value information for one ERP field <para /> Carrier object for ErpSyncDefaultValue. Services for the ErpSyncDefaultValue Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IErpSyncAgent">ErpSync Agent</see>. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/ErpSync/SaveDefaultValueInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ErpSyncDefaultValue": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ErpFieldId": 988,
  "DefaultValue": "est",
  "HasFirstSyncDefaultValue": false,
  "FirstSyncDefaultValue": "numquam",
  "PromptUser": true,
  "Mandatory": false,
  "ErpFieldKey": "sequi",
  "FieldType": "Checkbox",
  "ListName": "Stiedemann, Hauck and Nikolaus",
  "Access": "Mandatory",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 895
    }
  }
}
```