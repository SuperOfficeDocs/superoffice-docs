---
title: POST Agents/Audience/SaveAudienceLayoutEntity
uid: v1AudienceAgent_SaveAudienceLayoutEntity
---

# POST Agents/Audience/SaveAudienceLayoutEntity

```http
POST /api/v1/Agents/Audience/SaveAudienceLayoutEntity
```

Updates the existing AudienceLayoutEntity or creates a new AudienceLayoutEntity if the id parameter is empty








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

## Request Body: entity 

The AudienceLayoutEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AudienceLayoutId | Integer | The Id of the Audience layout |
| InstanceLayout | String | The web part layout as a serialized string |
| InstanceName | String | Name of the layout instance |
| CreatedDate | String | The date and time the Audience layout was created  in UTC. |
| UpdatedDate | String | The date and time the Audience layout was last updated  in UTC. |
| CreatedBy | Associate | Name of the person that created the Audience layout |
| UpdatedBy | Associate | Name of the person that last updated the Audience layout |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: AudienceLayoutEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| AudienceLayoutId | int32 | The Id of the Audience layout |
| InstanceLayout | string | The web part layout as a serialized string |
| InstanceName | string | Name of the layout instance |
| CreatedDate | date-time | The date and time the Audience layout was created  in UTC. |
| UpdatedDate | date-time | The date and time the Audience layout was last updated  in UTC. |
| CreatedBy | Associate | Name of the person that created the Audience layout |
| UpdatedBy | Associate | Name of the person that last updated the Audience layout |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Audience/SaveAudienceLayoutEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 475,
  "InstanceLayout": "architecto",
  "InstanceName": "Lemke, Mayer and Huels",
  "CreatedDate": "2018-09-24T17:37:16.8772416+02:00",
  "UpdatedDate": "2021-12-02T17:37:16.8772416+01:00",
  "CreatedBy": null,
  "UpdatedBy": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 39,
  "InstanceLayout": "nihil",
  "InstanceName": "Pfeffer, Wilkinson and Wisoky",
  "CreatedDate": "1996-11-20T17:37:16.8802418+01:00",
  "UpdatedDate": "1997-04-19T17:37:16.8802418+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 75
    }
  }
}
```