---
title: POST Agents/List/SaveResourceEntity
id: v1ListAgent_SaveResourceEntity
---

# POST Agents/List/SaveResourceEntity

```http
POST /api/v1/Agents/List/SaveResourceEntity
```

Updates the existing ResourceEntity or creates a new ResourceEntity if the id parameter is empty








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

The ResourceEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ResourceId | int32 | Primary key |
| Name | string | Initials, also login name, possibly database user name |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| Deleted | bool | If true, the resource is deleted. |
| IsLocation | bool | If true the resource is a location |
| LocationAddress | string | Address of location, if this is a resource that is a location |


## Response: object

The resource entity contains resource information



Carrier object for ResourceEntity.
Services for the ResourceEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ResourceId | int32 | Primary key |
| Name | string | Initials, also login name, possibly database user name |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| Deleted | bool | If true, the resource is deleted. |
| IsLocation | bool | If true the resource is a location |
| LocationAddress | string | Address of location, if this is a resource that is a location |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/List/SaveResourceEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ResourceId": 417,
  "Name": "Reilly, Cruickshank and Greenfelder",
  "Rank": 902,
  "Tooltip": "animi",
  "Deleted": false,
  "IsLocation": false,
  "LocationAddress": "et"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ResourceId": 45,
  "Name": "Becker, Farrell and Beer",
  "Rank": 106,
  "Tooltip": "expedita",
  "Deleted": true,
  "IsLocation": false,
  "LocationAddress": "iure",
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
      "FieldLength": 179
    }
  }
}
```