---
title: POST Agents/Configuration/SaveAndPublish
uid: v1ConfigurationAgent_SaveAndPublish
---

# POST Agents/Configuration/SaveAndPublish

```http
POST /api/v1/Agents/Configuration/SaveAndPublish
```

Save the incomming draft and publish

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/SaveAndPublish?$select=name,department,category/id
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

## Response

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
POST /api/v1/Agents/Configuration/SaveAndPublish
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDelta": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConfigurableScreenDeltaId": 434,
  "Name": "Botsford Group",
  "Description": "Reverse-engineered 24 hour Graphic Interface",
  "DeltaJson": "sit",
  "DeltaType": "CustomFields",
  "DeltaState": "Draft",
  "RecipeId": "cum",
  "UpdatedDate": "2021-11-15T11:10:26.2075244+01:00",
  "CreatedDate": "2001-03-31T11:10:26.2075244+02:00",
  "UpdatedBy": null,
  "CreatedBy": null,
  "AppliesToIds": [
    274,
    989
  ],
  "AppliesToKey": "magni",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 270
    }
  }
}
```
