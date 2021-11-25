---
title: POST Agents/Audience/GetConfigParameter
id: v1AudienceAgent_GetConfigParameter
---

# POST Agents/Audience/GetConfigParameter

```http
POST /api/v1/Agents/Audience/GetConfigParameter
```

Gets an Audience configuration parameter belonging to a given Audience layout with the specified configuration parameter name







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Audience/GetConfigParameter?$select=name,department,category/id
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

LayoutName, ParameterName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| LayoutName | string |  |
| ParameterName | string |  |


## Response: object

An Audience configuration parameter, used for handling Audience application or Web part settings.



Carrier object for AudienceConfigParameter.
Services for the AudienceConfigParameter Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAudienceAgent">Audience Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| AudienceLayoutId | int32 | The id of the Audience layout this configuration setting belongs to |
| Name | string | The name of the configuration parameter |
| Value | string | The value of the configuration parameter |
| CreatedDate | date-time | The date and time the configuration parameter was created  in UTC. |
| UpdatedDate | date-time | The date and time the configuration parameter was last updated  in UTC. |
| CreatedBy | string | Name of the person that created the configuration parameter |
| UpdatedBy | string | Name of the person that last updated the configuration parameter |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Audience/GetConfigParameter
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "LayoutName": "Farrell, Huels and Moen",
  "ParameterName": "Larson Group"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 188,
  "Name": "Kub-Mosciski",
  "Value": "ad",
  "CreatedDate": "1994-10-24T18:28:48.1295425+02:00",
  "UpdatedDate": "2004-09-04T18:28:48.1295425+02:00",
  "CreatedBy": "enim",
  "UpdatedBy": "cumque",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "e-enable transparent infrastructures"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 966
    }
  }
}
```