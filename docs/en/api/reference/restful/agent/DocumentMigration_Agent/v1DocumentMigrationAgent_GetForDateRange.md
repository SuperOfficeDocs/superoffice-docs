---
title: POST Agents/DocumentMigration/GetForDateRange
uid: v1DocumentMigrationAgent_GetForDateRange
generated: true
---

# POST Agents/DocumentMigration/GetForDateRange

```http
POST /api/v1/Agents/DocumentMigration/GetForDateRange
```

Gets a migration summary for documents in the provided date-rage


## Online Restricted: ## The DocumentMigration agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for SuperOffice-internal apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/DocumentMigration/GetForDateRange?$select=name,department,category/id
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

DocumentPluginId, MinDate, MaxDate, IncludeEmails 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentPluginId | Integer |  |
| MinDate | String |  |
| MaxDate | String |  |
| IncludeEmails | Boolean |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: DocumentMigrationItemList

| Property Name | Type |  Description |
|----------------|------|--------------|
| NumDocumentsOmitted | int32 | Total amount of documents within the selection criteria, which has been omitted from the migration. |
| NumDocumentsAlreadyMigrated | int32 | Documents already migrated to the requested documentplugin. |
| Documents | array | List of documents to be migrated. |
| Associates | array | List of associates whose documents will be migrated. |

## Sample request

```http!
POST /api/v1/Agents/DocumentMigration/GetForDateRange
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DocumentPluginId": 735,
  "MinDate": "2022-08-02T10:30:23.7199314+02:00",
  "MaxDate": "2011-10-22T10:30:23.7199314+02:00",
  "IncludeEmails": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "NumDocumentsOmitted": 924,
  "NumDocumentsAlreadyMigrated": 773,
  "Documents": [
    {
      "DocumentId": 67,
      "ContactId": 230,
      "PersonId": 100,
      "SaleId": 898,
      "ProjectId": 930,
      "DocTmplId": 816,
      "AssociateId": 474,
      "UserGroupId": 573,
      "VisibleForId": 57
    }
  ],
  "Associates": [
    {
      "AssociateId": 85,
      "EmailAddress": "elyssa@okuneva.co.uk"
    },
    {
      "AssociateId": 85,
      "EmailAddress": "elyssa@okuneva.co.uk"
    }
  ]
}
```