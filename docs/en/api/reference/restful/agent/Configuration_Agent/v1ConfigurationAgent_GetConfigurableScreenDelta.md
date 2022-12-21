---
title: POST Agents/Configuration/GetConfigurableScreenDelta
uid: v1ConfigurationAgent_GetConfigurableScreenDelta
---

# POST Agents/Configuration/GetConfigurableScreenDelta

```http
POST /api/v1/Agents/Configuration/GetConfigurableScreenDelta
```

Gets a ConfigurableScreenDelta object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| configurableScreenDeltaId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/GetConfigurableScreenDelta?configurableScreenDeltaId=424
POST /api/v1/Agents/Configuration/GetConfigurableScreenDelta?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConfigurableScreenDeltaId | int32 |  |
| Name | string |  |
| Description | string |  |
| DeltaJson | string |  |
| DeltaType | string |  |
| DeltaState | string |  |
| RecipeId | string |  |
| UpdatedDate | date-time |  |
| CreatedDate | date-time |  |
| UpdatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| CreatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| AppliesToIds | array |  |
| AppliesToKey | string |  |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Configuration/GetConfigurableScreenDelta
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDeltaId": 842,
  "Name": "Reynolds-Mohr",
  "Description": "Total actuating internet solution",
  "DeltaJson": "quisquam",
  "DeltaType": "CustomFields",
  "DeltaState": "Draft",
  "RecipeId": "earum",
  "UpdatedDate": "1997-11-01T02:49:43.8566571+01:00",
  "CreatedDate": "2019-02-12T02:49:43.8566571+01:00",
  "UpdatedBy": null,
  "CreatedBy": null,
  "AppliesToIds": [
    656,
    907
  ],
  "AppliesToKey": "iure",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 772
    }
  }
}
```