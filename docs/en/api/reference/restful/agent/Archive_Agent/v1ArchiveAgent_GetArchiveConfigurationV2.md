---
title: POST Agents/Archive/GetArchiveConfigurationV2
uid: v1ArchiveAgent_GetArchiveConfigurationV2
generated: true
---

# POST Agents/Archive/GetArchiveConfigurationV2

```http
POST /api/v1/Agents/Archive/GetArchiveConfigurationV2
```

Get the configuration for one archive.


The configuration is keyed by a combination of archive provider name (plus optional context), gui name, and optional table binding. The archive provider name must match an archive provider plugin; the gui name is an arbitrary string used to distinguish multiple occurrences of the same underlying provider in a gui.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/GetArchiveConfigurationV2?$select=name,department,category/id
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

GuiName, ProviderName, Context, OwnerKeys 

| Property Name | Type |  Description |
|----------------|------|--------------|
| GuiName | String |  |
| ProviderName | String |  |
| Context | String |  |
| OwnerKeys | String |  |

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
POST /api/v1/Agents/Archive/GetArchiveConfigurationV2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "GuiName": "Keebler, McLaughlin and Wehner",
  "ProviderName": "Dibbert, Conn and Blick",
  "Context": "earum",
  "OwnerKeys": "qui"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumnInfo": [
    {
      "DisplayName": "Kirlin-Gleason",
      "DisplayTooltip": "consequuntur",
      "DisplayType": "deleniti",
      "CanOrderBy": false,
      "Name": "Grady, Pagac and Crooks",
      "CanRestrictBy": false,
      "RestrictionType": "doloremque",
      "RestrictionListName": "Batz-Flatley",
      "IsVisible": false,
      "ExtraInfo": "voluptas",
      "Width": "eveniet",
      "IconHint": "possimus",
      "HeadingIconHint": "veritatis"
    }
  ],
  "ArchiveEntityInfo": [
    {
      "Id": 583,
      "Name": "Bartell-Shanahan",
      "ToolTip": "Qui sed incidunt voluptatem commodi harum.",
      "Deleted": true,
      "Rank": 572,
      "Type": "tempora",
      "ColorBlock": 819,
      "IconHint": "suscipit",
      "Selected": true,
      "LastChanged": "2007-08-18T04:22:25.9653503+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "facilis",
      "StyleHint": "molestiae",
      "Hidden": false,
      "FullName": "Alivia Demetrius Wuckert I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 889
        }
      }
    }
  ],
  "ArchiveOrderByInfo": [
    {
      "Name": "Grimes, Schimmel and Bednar",
      "Direction": "ASC"
    },
    {
      "Name": "Grimes, Schimmel and Bednar",
      "Direction": "ASC"
    }
  ],
  "OwnerKeys": "maxime",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 982
    }
  }
}
```