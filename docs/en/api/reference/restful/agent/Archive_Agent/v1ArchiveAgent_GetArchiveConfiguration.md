---
title: POST Agents/Archive/GetArchiveConfiguration
uid: v1ArchiveAgent_GetArchiveConfiguration
generated: true
---

# POST Agents/Archive/GetArchiveConfiguration

```http
POST /api/v1/Agents/Archive/GetArchiveConfiguration
```

Get the configuration for one archive.


The configuration is keyed by a combination of archive provider name and gui name. The archive provider name must match an archive provider plugin; the gui name is an arbitrary string used to distinguish multiple occurrences of the same underlying provider in a gui.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/GetArchiveConfiguration?$select=name,department,category/id
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

GuiName, ProviderName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| GuiName | String |  |
| ProviderName | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ArchiveConfiguration

| Property Name | Type |  Description |
|----------------|------|--------------|
| ArchiveColumnInfo | array |  |
| ArchiveEntityInfo | array |  |
| ArchiveOrderByInfo | array |  |
| OwnerKeys | string | The actual ownership information for the configuration that was retrieved |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Archive/GetArchiveConfiguration
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "GuiName": "Altenwerth, Ernser and Crooks",
  "ProviderName": "Sipes-Doyle"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumnInfo": [
    {
      "DisplayName": "Keebler, Mann and Weissnat",
      "DisplayTooltip": "quisquam",
      "DisplayType": "consequuntur",
      "CanOrderBy": false,
      "Name": "Ernser LLC",
      "CanRestrictBy": true,
      "RestrictionType": "architecto",
      "RestrictionListName": "Jewess, Collier and Gutmann",
      "IsVisible": false,
      "ExtraInfo": "voluptas",
      "Width": "qui",
      "IconHint": "deserunt",
      "HeadingIconHint": "illum"
    }
  ],
  "ArchiveEntityInfo": [
    {
      "Id": 388,
      "Name": "Stroman Inc and Sons",
      "ToolTip": "Corporis quaerat amet omnis aut ipsam possimus pariatur.",
      "Deleted": false,
      "Rank": 454,
      "Type": "corrupti",
      "ColorBlock": 710,
      "IconHint": "quidem",
      "Selected": false,
      "LastChanged": "2023-05-05T14:13:39.3442417+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ratione",
      "StyleHint": "hic",
      "Hidden": false,
      "FullName": "Ms. Alvena Axel Beer Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 298
        }
      }
    }
  ],
  "ArchiveOrderByInfo": [
    {
      "Name": "Hane LLC",
      "Direction": "ASC"
    },
    {
      "Name": "Hane LLC",
      "Direction": "ASC"
    }
  ],
  "OwnerKeys": "excepturi",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 360
    }
  }
}
```