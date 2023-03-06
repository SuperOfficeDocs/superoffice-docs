---
title: POST Agents/DocumentMigration/GetForDateRange
uid: v1DocumentMigrationAgent_GetForDateRange
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DocumentPluginId": 346,
  "MinDate": "2013-06-13T14:19:03.3727451+02:00",
  "MaxDate": "2014-01-13T14:19:03.3727451+01:00",
  "IncludeEmails": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "NumDocumentsOmitted": 742,
  "NumDocumentsAlreadyMigrated": 671,
  "Documents": [
    {
      "DocumentId": 793,
      "ContactId": 810,
      "PersonId": 236,
      "SaleId": 896,
      "ProjectId": 785,
      "DocTmplId": 850,
      "AssociateId": 760,
      "UserGroupId": 954,
      "VisibleForId": 982
    }
  ],
  "Associates": [
    {
      "AssociateId": 403,
      "EmailAddress": "velda_hodkiewicz@quitzonabshire.info"
    },
    {
      "AssociateId": 403,
      "EmailAddress": "velda_hodkiewicz@quitzonabshire.info"
    }
  ]
}
```