---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
generated: true
content_type: reference
---

# POST Project

```http
POST /api/v1/Project
```

Creates a new ProjectEntity


Calls the Project agent service SaveProjectEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Project?$select=name,department,category/id
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

## Request Body: newEntity 

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

### Response body: ProjectEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 80,
  "Name": "Bailey LLC",
  "ProjectNumber": "1118618",
  "ProjectMembers": [
    {
      "ProjectmemberId": 870,
      "ContactId": 602,
      "ProjectId": 487,
      "ContactName": "Dickinson-Mertz",
      "ContactDepartment": "",
      "ProjectName": "Pfannerstill LLC",
      "EmailId": 74,
      "EmailAddress": "zander_rath@jakubowski.com",
      "CountryId": 899,
      "Firstname": "Brody",
      "MiddleName": "Kris-Denesik",
      "Lastname": "White",
      "PersonId": 900,
      "Mrmrs": "aut",
      "ProjectMemberTypeName": "Schiller-Lehner",
      "Phone": "1-918-102-1301",
      "PhoneId": 779,
      "ProjectMemberTypeId": 21,
      "EmailAddressName": "constantin.huels@kris.com",
      "Comment": "qui",
      "FullName": "Dr. Thea Raleigh Klein DDS"
    }
  ],
  "Urls": [
    {
      "Value": "fugit",
      "StrippedValue": "aperiam",
      "Description": "Universal background support"
    },
    {
      "Value": "fugit",
      "StrippedValue": "aperiam",
      "Description": "Universal background support"
    }
  ],
  "CreatedDate": "2020-06-06T03:47:00.1755649+02:00",
  "UpdatedDate": "2020-04-20T03:47:00.1755649+02:00",
  "Description": "Robust maximized firmware",
  "Postit": "minima",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Secured tertiary groupware",
  "ActiveStatusMonitorId": 570,
  "Links": [
    {
      "EntityName": "Effertz, Dickens and Abernathy",
      "Id": 103,
      "Description": "Ameliorated high-level challenge",
      "ExtraInfo": "reprehenderit",
      "LinkId": 589
    },
    {
      "EntityName": "Effertz, Dickens and Abernathy",
      "Id": 103,
      "Description": "Ameliorated high-level challenge",
      "ExtraInfo": "reprehenderit",
      "LinkId": 589
    }
  ],
  "ActiveLinks": 964,
  "Completed": true,
  "NextMilestoneDate": "2020-06-26T03:47:00.1755649+02:00",
  "NmdAppointmentId": 761,
  "EndDate": "2016-11-18T03:47:00.1755649+01:00",
  "ActiveErpLinks": 532,
  "UserDefinedFields": {
    "SuperOffice:1": "Tobin McClure",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "at",
    "ExtraFields2": "consequuntur"
  },
  "CustomFields": {
    "CustomFields1": "odio",
    "CustomFields2": "velit"
  },
  "PublishEventDate": "2008-05-02T03:47:00.1755649+02:00",
  "PublishTo": "2025-01-09T03:47:00.1755649+01:00",
  "PublishFrom": "2015-11-07T03:47:00.1755649+01:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 663,
  "Name": "Bergstrom-Jacobson",
  "ProjectNumber": "694070",
  "ProjectMembers": [
    {
      "ProjectmemberId": 26,
      "ContactId": 781,
      "ProjectId": 550,
      "ContactName": "Stark, Huels and Boyle",
      "ContactDepartment": "",
      "ProjectName": "Jones, O'Keefe and Jacobi",
      "EmailId": 487,
      "EmailAddress": "camron_satterfield@gutkowski.uk",
      "CountryId": 889,
      "Firstname": "Tia",
      "MiddleName": "Lemke, Emard and Rohan",
      "Lastname": "Gleason",
      "PersonId": 555,
      "Mrmrs": "voluptatem",
      "ProjectMemberTypeName": "DuBuque, Wyman and Simonis",
      "Phone": "365-291-8633 x751",
      "PhoneId": 984,
      "ProjectMemberTypeId": 752,
      "EmailAddressName": "keyshawn@ziemannhintz.us",
      "Comment": "ex",
      "FullName": "Alysha Senger",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 313
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sunt",
      "StrippedValue": "voluptas",
      "Description": "Function-based hybrid adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 658
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "voluptas",
      "Description": "Function-based hybrid adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 658
        }
      }
    }
  ],
  "CreatedDate": "2001-03-08T03:47:00.1755649+01:00",
  "UpdatedDate": "2009-06-16T03:47:00.1755649+02:00",
  "Description": "Open-source regional matrix",
  "Postit": "ipsum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Cross-group leading edge definition",
  "ActiveStatusMonitorId": 476,
  "Links": [
    {
      "EntityName": "Senger-Labadie",
      "Id": 834,
      "Description": "Assimilated systematic moderator",
      "ExtraInfo": "doloremque",
      "LinkId": 923,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    }
  ],
  "ActiveLinks": 240,
  "Completed": false,
  "NextMilestoneDate": "2001-03-04T03:47:00.1755649+01:00",
  "NmdAppointmentId": 703,
  "EndDate": "2024-04-23T03:47:00.1755649+02:00",
  "ActiveErpLinks": 452,
  "UserDefinedFields": {
    "SuperOffice:1": "Arielle Abshire V",
    "SuperOffice:2": "291254954"
  },
  "ExtraFields": {
    "ExtraFields1": "eligendi",
    "ExtraFields2": "quisquam"
  },
  "CustomFields": {
    "CustomFields1": "adipisci",
    "CustomFields2": "sed"
  },
  "PublishEventDate": "2001-12-19T03:47:00.1755649+01:00",
  "PublishTo": "2025-05-14T03:47:00.1755649+02:00",
  "PublishFrom": "2016-07-12T03:47:00.1755649+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 925
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```