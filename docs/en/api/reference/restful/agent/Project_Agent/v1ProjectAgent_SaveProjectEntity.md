---
title: POST Agents/Project/SaveProjectEntity
uid: v1ProjectAgent_SaveProjectEntity
generated: true
---

# POST Agents/Project/SaveProjectEntity

```http
POST /api/v1/Agents/Project/SaveProjectEntity
```

Updates the existing ProjectEntity or creates a new ProjectEntity if the id parameter is empty








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

## Request Body: entity 

The ProjectEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer | Primary key |
| Name | String | Project name |
| ProjectNumber | String | Automatically generated number |
| ProjectMembers | Array | The persons which are members of the project |
| Urls | Array | The project's internet adresses |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Last updated date  in UTC. |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | Boolean | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | String | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for project |
| Links | Array | List of all elements linked to the project |
| ActiveLinks | Integer | Number of active links to documents, other appointments, and such |
| Completed | Boolean | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | String | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | Integer | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | String | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | Integer | The number of active erp links |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |

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
POST /api/v1/Agents/Project/SaveProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 203,
  "Name": "Herzog, Toy and Mohr",
  "ProjectNumber": "156543",
  "ProjectMembers": [
    {
      "ProjectmemberId": 596,
      "ContactId": 482,
      "ProjectId": 555,
      "ContactName": "Carroll Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Ullrich-Gusikowski",
      "EmailId": 305,
      "EmailAddress": "avis@schmidt.ca",
      "CountryId": 376,
      "Firstname": "Tiara",
      "MiddleName": "Terry-Muller",
      "Lastname": "Walter",
      "PersonId": 103,
      "Mrmrs": "ut",
      "ProjectMemberTypeName": "Kihn-Kris",
      "Phone": "521-947-2009 x005",
      "PhoneId": 688,
      "ProjectMemberTypeId": 940,
      "EmailAddressName": "libbie_schmidt@ebert.ca",
      "Comment": "labore",
      "FullName": "Augustus Moen"
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "distinctio",
      "Description": "Stand-alone 24/7 encoding"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "distinctio",
      "Description": "Stand-alone 24/7 encoding"
    }
  ],
  "CreatedDate": "2007-04-27T10:30:24.3237103+02:00",
  "UpdatedDate": "2004-04-01T10:30:24.3237103+02:00",
  "Description": "Configurable non-volatile time-frame",
  "Postit": "sit",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Diverse holistic open system",
  "ActiveStatusMonitorId": 858,
  "Links": [
    {
      "EntityName": "Herman, Dickinson and Berge",
      "Id": 392,
      "Description": "Team-oriented composite adapter",
      "ExtraInfo": "nihil",
      "LinkId": 824
    },
    {
      "EntityName": "Herman, Dickinson and Berge",
      "Id": 392,
      "Description": "Team-oriented composite adapter",
      "ExtraInfo": "nihil",
      "LinkId": 824
    }
  ],
  "ActiveLinks": 554,
  "Completed": false,
  "NextMilestoneDate": "2005-06-23T10:30:24.3237103+02:00",
  "NmdAppointmentId": 978,
  "EndDate": "2001-12-19T10:30:24.3237103+01:00",
  "ActiveErpLinks": 829,
  "UserDefinedFields": {
    "SuperOffice:1": "Jade Mills",
    "SuperOffice:2": "1904211263"
  },
  "ExtraFields": {
    "ExtraFields1": "laudantium",
    "ExtraFields2": "provident"
  },
  "CustomFields": {
    "CustomFields1": "assumenda",
    "CustomFields2": "vel"
  },
  "PublishEventDate": "2009-11-26T10:30:24.3237103+01:00",
  "PublishTo": "2011-07-16T10:30:24.3237103+02:00",
  "PublishFrom": "2008-12-28T10:30:24.3237103+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 381,
  "Name": "Terry Inc and Sons",
  "ProjectNumber": "804708",
  "ProjectMembers": [
    {
      "ProjectmemberId": 845,
      "ContactId": 270,
      "ProjectId": 922,
      "ContactName": "Schultz-Bartoletti",
      "ContactDepartment": "",
      "ProjectName": "DuBuque, Schmidt and Hirthe",
      "EmailId": 553,
      "EmailAddress": "camren_brakus@flatleycasper.name",
      "CountryId": 398,
      "Firstname": "Carley",
      "MiddleName": "Kunze, Quigley and Mills",
      "Lastname": "Torp",
      "PersonId": 36,
      "Mrmrs": "quia",
      "ProjectMemberTypeName": "Ziemann-Labadie",
      "Phone": "(213)342-6186",
      "PhoneId": 340,
      "ProjectMemberTypeId": 761,
      "EmailAddressName": "henriette_rath@buckridge.info",
      "Comment": "exercitationem",
      "FullName": "Jaron Adelia Dibbert MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 835
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "eius",
      "Description": "Digitized maximized archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 689
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "eius",
      "Description": "Digitized maximized archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 689
        }
      }
    }
  ],
  "CreatedDate": "2010-10-14T10:30:24.3237103+02:00",
  "UpdatedDate": "1998-07-14T10:30:24.3237103+02:00",
  "Description": "Future-proofed zero tolerance conglomeration",
  "Postit": "laborum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Enhanced homogeneous ability",
  "ActiveStatusMonitorId": 977,
  "Links": [
    {
      "EntityName": "Hintz Group",
      "Id": 710,
      "Description": "Virtual directional superstructure",
      "ExtraInfo": "velit",
      "LinkId": 885,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 458
        }
      }
    }
  ],
  "ActiveLinks": 525,
  "Completed": false,
  "NextMilestoneDate": "2008-06-02T10:30:24.3237103+02:00",
  "NmdAppointmentId": 198,
  "EndDate": "2007-03-29T10:30:24.3237103+02:00",
  "ActiveErpLinks": 247,
  "UserDefinedFields": {
    "SuperOffice:1": "Kiarra Stanton",
    "SuperOffice:2": "Summer Berge"
  },
  "ExtraFields": {
    "ExtraFields1": "quas",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "vel"
  },
  "PublishEventDate": "2023-04-29T10:30:24.3237103+02:00",
  "PublishTo": "2013-05-14T10:30:24.3237103+02:00",
  "PublishFrom": "2014-11-07T10:30:24.3237103+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 385
    }
  }
}
```