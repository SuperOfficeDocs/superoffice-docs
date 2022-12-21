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

Response body: 

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
| CreatedBy |  | The person that created the project |
| UpdatedBy |  | The person that last updated the project |
| Associate |  | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus |  | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType |  | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| TableRight |  |  |
| FieldProperties | object |  |

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
Last-Modified: Fri, 08 Sep 2017 02:49:51 G9T

{
  "ProjectId": 807,
  "Name": "McCullough, Farrell and DuBuque",
  "ProjectNumber": "238571",
  "ProjectMembers": [
    {
      "ProjectmemberId": 651,
      "ContactId": 350,
      "ProjectId": 676,
      "ContactName": "Bogan, Prohaska and Murphy",
      "ContactDepartment": "implement strategic deliverables",
      "ProjectName": "Fadel-Mann",
      "EmailId": 489,
      "EmailAddress": "edd.lehner@weissnat.info",
      "CountryId": 930,
      "Firstname": "Ericka",
      "MiddleName": "O'Reilly, Fritsch and Nicolas",
      "Lastname": "Turcotte",
      "PersonId": 557,
      "Mrmrs": "incidunt",
      "ProjectMemberTypeName": "Aufderhar-Kuvalis",
      "Phone": "(642)287-4442 x1761",
      "PhoneId": 195,
      "ProjectMemberTypeId": 50,
      "EmailAddressName": "keely@keeling.com",
      "Comment": "eum",
      "FullName": "Haskell Schoen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 928
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "distinctio",
      "Description": "Exclusive well-modulated circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 419
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "distinctio",
      "Description": "Exclusive well-modulated circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 419
        }
      }
    }
  ],
  "CreatedDate": "1998-08-26T02:49:51.3234448+02:00",
  "UpdatedDate": "2017-09-08T02:49:51.3234448+02:00",
  "Description": "Focused tertiary superstructure",
  "Postit": "et",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Intuitive actuating solution",
  "ActiveStatusMonitorId": 918,
  "Links": [
    {
      "EntityName": "Ullrich, Mante and Kerluke",
      "Id": 396,
      "Description": "Virtual leading edge interface",
      "ExtraInfo": "nisi",
      "LinkId": 543,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 319
        }
      }
    }
  ],
  "ActiveLinks": 996,
  "Completed": false,
  "NextMilestoneDate": "2015-02-20T02:49:51.3234448+01:00",
  "NmdAppointmentId": 90,
  "EndDate": "1995-07-26T02:49:51.3234448+02:00",
  "ActiveErpLinks": 612,
  "UserDefinedFields": {
    "SuperOffice:1": "486375363",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "commodi",
    "ExtraFields2": "facilis"
  },
  "CustomFields": {
    "CustomFields1": "fuga",
    "CustomFields2": "rerum"
  },
  "PublishEventDate": "2000-04-14T02:49:51.3234448+02:00",
  "PublishTo": "2006-06-10T02:49:51.3234448+02:00",
  "PublishFrom": "2012-07-30T02:49:51.3234448+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 793
    }
  }
}
```