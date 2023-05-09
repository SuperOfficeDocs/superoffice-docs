---
title: GET Project/default
uid: v1ProjectEntity_DefaultProjectEntity
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
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 10 Sep 2010 03:51:33 G9T

{
  "ProjectId": 867,
  "Name": "Jewess Inc and Sons",
  "ProjectNumber": "818811",
  "ProjectMembers": [
    {
      "ProjectmemberId": 863,
      "ContactId": 259,
      "ProjectId": 51,
      "ContactName": "Konopelski, Leffler and Cormier",
      "ContactDepartment": "",
      "ProjectName": "Veum Inc and Sons",
      "EmailId": 603,
      "EmailAddress": "winnifred@hartmann.ca",
      "CountryId": 218,
      "Firstname": "Mohamed",
      "MiddleName": "Gerhold-Weissnat",
      "Lastname": "Jaskolski",
      "PersonId": 131,
      "Mrmrs": "repellat",
      "ProjectMemberTypeName": "Fahey Inc and Sons",
      "Phone": "(870)187-7723 x336",
      "PhoneId": 712,
      "ProjectMemberTypeId": 891,
      "EmailAddressName": "mollie@krajcik.us",
      "Comment": "dolores",
      "FullName": "Santino Klein",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 929
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "mollitia",
      "StrippedValue": "ea",
      "Description": "Open-architected clear-thinking approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 23
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "ea",
      "Description": "Open-architected clear-thinking approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 23
        }
      }
    }
  ],
  "CreatedDate": "2000-05-01T03:51:33.8178024+02:00",
  "UpdatedDate": "2010-09-10T03:51:33.8178024+02:00",
  "Description": "Customer-focused background protocol",
  "Postit": "itaque",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Future-proofed bi-directional data-warehouse",
  "ActiveStatusMonitorId": 957,
  "Links": [
    {
      "EntityName": "Pacocha-Gaylord",
      "Id": 856,
      "Description": "Intuitive intermediate migration",
      "ExtraInfo": "accusamus",
      "LinkId": 607,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 414
        }
      }
    }
  ],
  "ActiveLinks": 912,
  "Completed": true,
  "NextMilestoneDate": "2004-04-06T03:51:33.8178024+02:00",
  "NmdAppointmentId": 722,
  "EndDate": "1996-06-10T03:51:33.8178024+02:00",
  "ActiveErpLinks": 871,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Dejon Bauch"
  },
  "ExtraFields": {
    "ExtraFields1": "atque",
    "ExtraFields2": "consectetur"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "maxime"
  },
  "PublishEventDate": "2021-08-31T03:51:33.8178024+02:00",
  "PublishTo": "2005-05-28T03:51:33.8178024+02:00",
  "PublishFrom": "2013-11-29T03:51:33.8178024+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 946
    }
  }
}
```