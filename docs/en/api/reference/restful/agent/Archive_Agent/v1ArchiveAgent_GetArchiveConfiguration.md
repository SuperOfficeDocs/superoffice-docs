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
  "GuiName": "Pfannerstill-Boyer",
  "ProviderName": "Kohler Group"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumnInfo": [
    {
      "DisplayName": "Nitzsche, Gusikowski and Marks",
      "DisplayTooltip": "sunt",
      "DisplayType": "ipsam",
      "CanOrderBy": false,
      "Name": "Bosco, Homenick and Dicki",
      "CanRestrictBy": false,
      "RestrictionType": "assumenda",
      "RestrictionListName": "Nicolas-Cremin",
      "IsVisible": true,
      "ExtraInfo": "qui",
      "Width": "sit",
      "IconHint": "quis",
      "HeadingIconHint": "dolor"
    }
  ],
  "ArchiveEntityInfo": [
    {
      "Id": 834,
      "Name": "Bosco, Crona and Roob",
      "ToolTip": "Qui aspernatur id ipsum.",
      "Deleted": false,
      "Rank": 40,
      "Type": "corporis",
      "ColorBlock": 546,
      "IconHint": "beatae",
      "Selected": false,
      "LastChanged": "2014-05-07T23:03:54.9611427+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "ut",
      "Hidden": true,
      "FullName": "Miss Hayley Libby Schaefer Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 304
        }
      }
    }
  ],
  "ArchiveOrderByInfo": [
    {
      "Name": "Reilly Inc and Sons",
      "Direction": "ASC"
    },
    {
      "Name": "Reilly Inc and Sons",
      "Direction": "ASC"
    }
  ],
  "OwnerKeys": "commodi",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 384
    }
  }
}
```