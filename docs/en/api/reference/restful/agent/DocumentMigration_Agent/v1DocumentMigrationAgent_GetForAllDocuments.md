---
title: POST Agents/DocumentMigration/GetForAllDocuments
uid: v1DocumentMigrationAgent_GetForAllDocuments
generated: true
---

# POST Agents/DocumentMigration/GetForAllDocuments

```http
POST /api/v1/Agents/DocumentMigration/GetForAllDocuments
```

Gets a migration summary for all documents stored in CRM.


Warning: Expensive!


## Online Restricted: ## The DocumentMigration agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for SuperOffice-internal apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/DocumentMigration/GetForAllDocuments?$select=name,department,category/id
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

DocumentPluginId, IncludeEmails 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentPluginId | Integer |  |
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
POST /api/v1/Agents/DocumentMigration/GetForAllDocuments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentPluginId": 660,
  "IncludeEmails": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "NumDocumentsOmitted": 253,
  "NumDocumentsAlreadyMigrated": 100,
  "Documents": [
    {
      "DocumentId": 998,
      "ContactId": 560,
      "PersonId": 273,
      "SaleId": 872,
      "ProjectId": 888,
      "DocTmplId": 57,
      "AssociateId": 155,
      "UserGroupId": 371,
      "VisibleForId": 569
    }
  ],
  "Associates": [
    {
      "AssociateId": 557,
      "EmailAddress": "erwin@schinnerdeckow.info"
    },
    {
      "AssociateId": 557,
      "EmailAddress": "erwin@schinnerdeckow.info"
    }
  ]
}
```