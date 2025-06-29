---
title: POST Agents/Find/GetDefaultDesiredColumnsFromRestrictions
uid: v1FindAgent_GetDefaultDesiredColumnsFromRestrictions
generated: true
---

# POST Agents/Find/GetDefaultDesiredColumnsFromRestrictions

```http
POST /api/v1/Agents/Find/GetDefaultDesiredColumnsFromRestrictions
```

Calculate the default desired columns, i.


e., the result columns for a given search. The search is defined by a provider name and a set of restrictions. This is the algorithm that is used by the Find service method.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/GetDefaultDesiredColumnsFromRestrictions?$select=name,department,category/id
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

ProviderName, Restrictions 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProviderName | String |  |
| Restrictions | Array |  |

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
POST /api/v1/Agents/Find/GetDefaultDesiredColumnsFromRestrictions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Grady, Koelpin and Becker",
  "Restrictions": [
    {
      "Name": "Bayer Inc and Sons",
      "Operator": "totam",
      "Values": [
        "itaque",
        "quia"
      ],
      "DisplayValues": [
        "dolor",
        "perferendis"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 895,
      "InterOperator": "And",
      "UniqueHash": 518
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DisplayName": "Rice Inc and Sons",
    "DisplayTooltip": "exercitationem",
    "DisplayType": "est",
    "CanOrderBy": true,
    "Name": "Ankunding, Jenkins and Feeney",
    "CanRestrictBy": false,
    "RestrictionType": "qui",
    "RestrictionListName": "Effertz Inc and Sons",
    "IsVisible": false,
    "ExtraInfo": "ex",
    "Width": "repellendus",
    "IconHint": "pariatur",
    "HeadingIconHint": "reiciendis"
  }
]
```