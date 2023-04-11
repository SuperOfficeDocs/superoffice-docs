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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 25 Mar 2023 15:29:29 G3T

{
  "ProjectId": 617,
  "Name": "Heaney-Nolan",
  "ProjectNumber": "1096943",
  "ProjectMembers": [
    {
      "ProjectmemberId": 981,
      "ContactId": 715,
      "ProjectId": 119,
      "ContactName": "Hauck, Kub and Little",
      "ContactDepartment": "",
      "ProjectName": "Quigley Group",
      "EmailId": 535,
      "EmailAddress": "adolphus_cole@schneider.com",
      "CountryId": 355,
      "Firstname": "Mollie",
      "MiddleName": "Armstrong LLC",
      "Lastname": "Abernathy",
      "PersonId": 101,
      "Mrmrs": "hic",
      "ProjectMemberTypeName": "Sauer-Pfeffer",
      "Phone": "324.017.1999",
      "PhoneId": 78,
      "ProjectMemberTypeId": 840,
      "EmailAddressName": "tomas@glover.com",
      "Comment": "quas",
      "FullName": "Norwood Stanton",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 426
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "optio",
      "StrippedValue": "sit",
      "Description": "Phased background local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 613
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "sit",
      "Description": "Phased background local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 613
        }
      }
    }
  ],
  "CreatedDate": "1998-05-30T15:29:29.9366964+02:00",
  "UpdatedDate": "2023-03-25T15:29:29.9366964+01:00",
  "Description": "Cross-platform bifurcated superstructure",
  "Postit": "at",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Front-line composite structure",
  "ActiveStatusMonitorId": 128,
  "Links": [
    {
      "EntityName": "Grant, Eichmann and Hauck",
      "Id": 92,
      "Description": "Organic actuating support",
      "ExtraInfo": "vitae",
      "LinkId": 945,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 603
        }
      }
    }
  ],
  "ActiveLinks": 142,
  "Completed": true,
  "NextMilestoneDate": "2005-09-09T15:29:29.9391616+02:00",
  "NmdAppointmentId": 866,
  "EndDate": "2008-02-21T15:29:29.9391616+01:00",
  "ActiveErpLinks": 34,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Eunice Reynolds"
  },
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "inventore"
  },
  "PublishEventDate": "2012-06-23T15:29:29.9396656+02:00",
  "PublishTo": "2010-01-21T15:29:29.9396656+01:00",
  "PublishFrom": "2000-08-25T15:29:29.9396656+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 611
    }
  }
}
```