---
title: POST Agents/DocumentMigration/CreateDefaultDocumentMigrationItemList
uid: v1DocumentMigrationAgent_CreateDefaultDocumentMigrationItemList
---

# POST Agents/DocumentMigration/CreateDefaultDocumentMigrationItemList

```http
POST /api/v1/Agents/DocumentMigration/CreateDefaultDocumentMigrationItemList
```

Set default values into a new DocumentMigrationItemList.


NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The DocumentMigration agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for SuperOffice-internal apps.







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/DocumentMigration/CreateDefaultDocumentMigrationItemList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "NumDocumentsOmitted": 334,
  "NumDocumentsAlreadyMigrated": 535,
  "Documents": [
    {
      "DocumentId": 866,
      "ContactId": 795,
      "PersonId": 100,
      "SaleId": 28,
      "ProjectId": 614,
      "DocTmplId": 579,
      "AssociateId": 679,
      "UserGroupId": 229,
      "VisibleForId": 384
    }
  ],
  "Associates": [
    {
      "AssociateId": 334,
      "EmailAddress": "fiona.weissnat@flatleymosciski.name"
    },
    {
      "AssociateId": 334,
      "EmailAddress": "fiona.weissnat@flatleymosciski.name"
    }
  ]
}
```