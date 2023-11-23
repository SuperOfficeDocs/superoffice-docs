---
title: POST Agents/Archive/GetAvailableColumns
uid: v1ArchiveAgent_GetAvailableColumns
generated: true
---

# POST Agents/Archive/GetAvailableColumns

```http
POST /api/v1/Agents/Archive/GetAvailableColumns
```

Return list of all columns supported by an archive provider.


See also GetArchiveConfiguration.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/GetAvailableColumns?$select=name,department,category/id
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

ProviderName, Context 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProviderName | String |  |
| Context | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| DisplayName | string | The column name to show, can be a resource identifier string |
| DisplayTooltip | string | The column tooltip, used in the column list and in the column headings |
| DisplayType | string | Type of column, so that the archive knows how to display it (actual display values are always strings, invariant-culture formatted). This name can contain resource tags. |
| CanOrderBy | bool | Can this column be used for sorting? |
| Name | string | Unique identity of this column (in this particular context); the name to be used when requesting the column from a provider, setting restrictions or order by criteria |
| CanRestrictBy | bool | Can this column be used as a restriction |
| RestrictionType | string | The data type of the restriction; use this to retrieve the legal operators for the restriction |
| RestrictionListName | string | If the restriction data type is 'list', this property contains the name of the SoList so that choices can be shown |
| IsVisible | bool | Is this column visible to the user in configuration dialogs etc |
| ExtraInfo | string | Example: "navigator" -&gt; Should this column be mapped to a hyperlinked navigator text type? |
| Width | string | The width specification, if the column info has been extended with GUI-based information. It is either "n%" or "nc", where n is an integer. Percent-formatted fields grow and shrink; number-of-characters formatted fields have constant width when the whole archive width changes. |
| IconHint | string | Icon hint corresponding to the display name; this icon hint is used in the configuration dialog and other places where we 'talk about' the columns of the archive. The actual heading of the archive may also contain icons in lieu of textual names, the icon hint for that is specified in {SuperOffice.CRM.ArchiveLists.ArchiveColumnInfo.HeadingIconHint} and is a different one. |
| HeadingIconHint | string | Icon hint for the archive heading only. If this is a nonempty string, the archive header should use this icon and ignore the {SuperOffice.CRM.ArchiveLists.ArchiveColumnInfo.DisplayName}. Otherwise, the DisplayName should be used as the heading. |

## Sample request

```http!
POST /api/v1/Agents/Archive/GetAvailableColumns
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Pfeffer Inc and Sons",
  "Context": "dignissimos"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DisplayName": "Durgan, Hamill and Reinger",
    "DisplayTooltip": "blanditiis",
    "DisplayType": "molestias",
    "CanOrderBy": false,
    "Name": "Wolf Inc and Sons",
    "CanRestrictBy": true,
    "RestrictionType": "delectus",
    "RestrictionListName": "Abshire-Halvorson",
    "IsVisible": true,
    "ExtraInfo": "nemo",
    "Width": "voluptas",
    "IconHint": "molestiae",
    "HeadingIconHint": "debitis"
  }
]
```