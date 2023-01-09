---
title: POST Agents/Audience/SaveConfigParameter
uid: v1AudienceAgent_SaveConfigParameter
---

# POST Agents/Audience/SaveConfigParameter

```http
POST /api/v1/Agents/Audience/SaveConfigParameter
```

Saves an Audience configuration parameter belonging to a Audience layout







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Audience/SaveConfigParameter?$select=name,department,category/id
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

LayoutName, ConfigParameter 

| Property Name | Type |  Description |
|----------------|------|--------------|
| LayoutName | String |  |
| ConfigParameter | AudienceConfigParameter | An Audience configuration parameter, used for handling Audience application or Web part settings. <para /> Carrier object for AudienceConfigParameter. Services for the AudienceConfigParameter Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAudienceAgent">Audience Agent</see>. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: AudienceConfigParameter

| Property Name | Type |  Description |
|----------------|------|--------------|
| AudienceLayoutId | int32 | The id of the Audience layout this configuration setting belongs to |
| Name | string | The name of the configuration parameter |
| Value | string | The value of the configuration parameter |
| CreatedDate | date-time | The date and time the configuration parameter was created  in UTC. |
| UpdatedDate | date-time | The date and time the configuration parameter was last updated  in UTC. |
| CreatedBy | string | Name of the person that created the configuration parameter |
| UpdatedBy | string | Name of the person that last updated the configuration parameter |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Audience/SaveConfigParameter
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "LayoutName": "Aufderhar-Hahn",
  "ConfigParameter": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 169,
  "Name": "Mohr LLC",
  "Value": "rerum",
  "CreatedDate": "2012-04-21T17:37:16.8812422+02:00",
  "UpdatedDate": "1996-01-06T17:37:16.8812422+01:00",
  "CreatedBy": "a",
  "UpdatedBy": "soluta",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 335
    }
  }
}
```