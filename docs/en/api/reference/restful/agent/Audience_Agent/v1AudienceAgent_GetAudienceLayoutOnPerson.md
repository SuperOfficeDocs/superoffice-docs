---
title: POST Agents/Audience/GetAudienceLayoutOnPerson
uid: v1AudienceAgent_GetAudienceLayoutOnPerson
generated: true
---

# POST Agents/Audience/GetAudienceLayoutOnPerson

```http
POST /api/v1/Agents/Audience/GetAudienceLayoutOnPerson
```

Gets the Audience layout belonging to the person specified.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Audience/GetAudienceLayoutOnPerson?$select=name,department,category/id
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

PersonId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer |  |

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Audience/GetAudienceLayoutOnPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 106
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 992,
  "InstanceLayout": "occaecati",
  "InstanceName": "Grimes Group",
  "CreatedDate": "2020-01-07T16:32:38.1959817+01:00",
  "UpdatedDate": "2008-02-11T16:32:38.1959817+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 892
    }
  }
}
```