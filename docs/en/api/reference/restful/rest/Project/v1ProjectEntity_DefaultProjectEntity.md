---
title: GET Project/default
uid: v1ProjectEntity_DefaultProjectEntity
generated: true
---

# GET Project/default

```http
GET /api/v1/Project/default
```

Set default values into a new ProjectEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Project agent service CreateDefaultProjectEntity.







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
GET /api/v1/Project/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 24 Oct 2005 10:18:00 G10T

{
  "ProjectId": 968,
  "Name": "Trantow-Hoeger",
  "ProjectNumber": "416704",
  "ProjectMembers": [
    {
      "ProjectmemberId": 823,
      "ContactId": 662,
      "ProjectId": 664,
      "ContactName": "Spinka-Dooley",
      "ContactDepartment": "",
      "ProjectName": "Torp Inc and Sons",
      "EmailId": 235,
      "EmailAddress": "domenica@barrowsjohns.uk",
      "CountryId": 290,
      "Firstname": "Jerald",
      "MiddleName": "Nienow Group",
      "Lastname": "Schimmel",
      "PersonId": 660,
      "Mrmrs": "et",
      "ProjectMemberTypeName": "Huels-Cassin",
      "Phone": "1-466-261-6330",
      "PhoneId": 648,
      "ProjectMemberTypeId": 681,
      "EmailAddressName": "alvah@rutherfordjaskolski.us",
      "Comment": "id",
      "FullName": "Zachariah Alena Marvin Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 875
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "soluta",
      "Description": "Implemented bandwidth-monitored algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 775
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "soluta",
      "Description": "Implemented bandwidth-monitored algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 775
        }
      }
    }
  ],
  "CreatedDate": "2020-08-30T10:18:00.4887104+02:00",
  "UpdatedDate": "2005-10-24T10:18:00.4887104+02:00",
  "Description": "Universal tangible synergy",
  "Postit": "sapiente",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Profound empowering Graphic Interface",
  "ActiveStatusMonitorId": 644,
  "Links": [
    {
      "EntityName": "Braun, Gleichner and Prosacco",
      "Id": 227,
      "Description": "Decentralized analyzing matrices",
      "ExtraInfo": "voluptatum",
      "LinkId": 153,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 772
        }
      }
    }
  ],
  "ActiveLinks": 536,
  "Completed": false,
  "NextMilestoneDate": "2012-12-24T10:18:00.4887104+01:00",
  "NmdAppointmentId": 267,
  "EndDate": "2011-04-13T10:18:00.4887104+02:00",
  "ActiveErpLinks": 426,
  "UserDefinedFields": {
    "SuperOffice:1": "1019707762",
    "SuperOffice:2": "815625852"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquid",
    "ExtraFields2": "tempora"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2006-02-27T10:18:00.4887104+01:00",
  "PublishTo": "2024-07-16T10:18:00.4887104+02:00",
  "PublishFrom": "2015-05-03T10:18:00.4887104+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 576
    }
  }
}
```