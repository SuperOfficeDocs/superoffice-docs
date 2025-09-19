---
title: POST Agents/Project/CreateDefaultProjectEntity
uid: v1ProjectAgent_CreateDefaultProjectEntity
generated: true
content_type: reference
---

# POST Agents/Project/CreateDefaultProjectEntity

```http
POST /api/v1/Agents/Project/CreateDefaultProjectEntity
```

Loading default values into a new ProjectEntity.








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

### Response body: ProjectEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  Use MDO List name "associate" to get list items. |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  Use MDO List name "projectstatus" to get list items. |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  Use MDO List name "projecttype" to get list items. |
| HasImage | bool | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | string | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for project |
| Links | array | List of all elements linked to the project |
| ActiveLinks | int32 | Number of active links to documents, other appointments, and such |
| Completed | bool | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | date-time | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | int32 | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | date-time | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Project/CreateDefaultProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 948,
  "Name": "Johns, Feeney and Pfannerstill",
  "ProjectNumber": "1752143",
  "ProjectMembers": [
    {
      "ProjectmemberId": 265,
      "ContactId": 330,
      "ProjectId": 175,
      "ContactName": "Brakus, Torp and Nader",
      "ContactDepartment": "",
      "ProjectName": "Murray, Shanahan and Reichel",
      "EmailId": 950,
      "EmailAddress": "melissa@corkery.info",
      "CountryId": 742,
      "Firstname": "Litzy",
      "MiddleName": "Sanford-Vandervort",
      "Lastname": "Turner",
      "PersonId": 738,
      "Mrmrs": "fugit",
      "ProjectMemberTypeName": "Simonis-Mueller",
      "Phone": "1-713-113-7796 x2861",
      "PhoneId": 880,
      "ProjectMemberTypeId": 574,
      "EmailAddressName": "raul@durgan.uk",
      "Comment": "voluptatem",
      "FullName": "Giovanni Adams",
      "Registered": "2024-06-11T03:41:53.886968+02:00",
      "Updated": "2008-12-25T03:41:53.886968+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 645
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "adipisci",
      "Description": "Cloned client-driven intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 175
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "adipisci",
      "Description": "Cloned client-driven intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 175
        }
      }
    }
  ],
  "CreatedDate": "2017-06-05T03:41:53.886968+02:00",
  "UpdatedDate": "2008-01-29T03:41:53.886968+01:00",
  "Description": "Seamless methodical contingency",
  "Postit": "iste",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Programmable bi-directional workforce",
  "ActiveStatusMonitorId": 186,
  "Links": [
    {
      "EntityName": "Pfeffer-Connelly",
      "Id": 984,
      "Description": "Self-enabling directional process improvement",
      "ExtraInfo": "itaque",
      "LinkId": 837,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 582
        }
      }
    }
  ],
  "ActiveLinks": 194,
  "Completed": false,
  "NextMilestoneDate": "2001-08-26T03:41:53.886968+02:00",
  "NmdAppointmentId": 801,
  "EndDate": "2008-06-19T03:41:53.886968+02:00",
  "ActiveErpLinks": 194,
  "UserDefinedFields": {
    "SuperOffice:1": "Mollie Yost",
    "SuperOffice:2": "Tabitha Steuber I"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "ipsum"
  },
  "PublishEventDate": "2004-03-08T03:41:53.886968+01:00",
  "PublishTo": "2006-11-01T03:41:53.886968+01:00",
  "PublishFrom": "2020-06-01T03:41:53.886968+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 801
    }
  }
}
```