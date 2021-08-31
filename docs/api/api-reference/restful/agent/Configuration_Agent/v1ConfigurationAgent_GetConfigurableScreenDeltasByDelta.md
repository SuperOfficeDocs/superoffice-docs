---
title: GetConfigurableScreenDeltasByDelta
id: v1ConfigurationAgent_GetConfigurableScreenDeltasByDelta
---

# GetConfigurableScreenDeltasByDelta

```http
POST /api/v1/Agents/Configuration/GetConfigurableScreenDeltasByDelta
```

This method will return a configurablescreen delta matching the properties received from the incomming delta







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/GetConfigurableScreenDeltasByDelta?$select=name,department,category/id
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

ConfigurableScreenDelta 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConfigurableScreenDelta |  |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConfigurableScreenDeltaId | int32 |  |
| Name | string |  |
| Description | string |  |
| DeltaJson | string |  |
| DeltaType | string |  |
| DeltaState | string |  |
| RecipeId | string |  |
| UserGroupId | int32 |  |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Configuration/GetConfigurableScreenDeltasByDelta
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDelta": {
    "ConfigurableScreenDeltaId": 573,
    "Name": "Dooley-Feil",
    "Description": "Sharable eco-centric methodology",
    "DeltaJson": "similique",
    "DeltaType": "CustomFields",
    "DeltaState": "Draft",
    "RecipeId": "rem",
    "UserGroupId": 22
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ConfigurableScreenDeltaId": 584,
    "Name": "Lemke, Nitzsche and Hermiston",
    "Description": "Self-enabling 24/7 instruction set",
    "DeltaJson": "vero",
    "DeltaType": "CustomFields",
    "DeltaState": "Draft",
    "RecipeId": "totam",
    "UserGroupId": 686,
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
]
```