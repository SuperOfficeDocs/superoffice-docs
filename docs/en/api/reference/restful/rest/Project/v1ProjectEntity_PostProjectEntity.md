---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
generated: true
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 925,
  "Name": "Cremin Group",
  "ProjectNumber": "1110461",
  "ProjectMembers": [
    {
      "ProjectmemberId": 66,
      "ContactId": 629,
      "ProjectId": 772,
      "ContactName": "Becker Group",
      "ContactDepartment": "",
      "ProjectName": "Stracke LLC",
      "EmailId": 124,
      "EmailAddress": "makenna@beier.info",
      "CountryId": 584,
      "Firstname": "Sigurd",
      "MiddleName": "Gleason, Cruickshank and Mertz",
      "Lastname": "Pagac",
      "PersonId": 196,
      "Mrmrs": "aspernatur",
      "ProjectMemberTypeName": "Hackett, Willms and Schmidt",
      "Phone": "1-398-074-2826 x0580",
      "PhoneId": 2,
      "ProjectMemberTypeId": 110,
      "EmailAddressName": "marcelina_gibson@nolan.us",
      "Comment": "et",
      "FullName": "Brody Fay Sr."
    }
  ],
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "qui",
      "Description": "Function-based zero administration flexibility"
    },
    {
      "Value": "sint",
      "StrippedValue": "qui",
      "Description": "Function-based zero administration flexibility"
    }
  ],
  "CreatedDate": "2019-03-05T16:55:29.9266352+01:00",
  "UpdatedDate": "2014-01-29T16:55:29.9266352+01:00",
  "Description": "Devolved context-sensitive success",
  "Postit": "autem",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "De-engineered clear-thinking functionalities",
  "ActiveStatusMonitorId": 821,
  "Links": [
    {
      "EntityName": "Mitchell-Bins",
      "Id": 822,
      "Description": "Persevering multi-tasking benchmark",
      "ExtraInfo": "quis",
      "LinkId": 159
    },
    {
      "EntityName": "Mitchell-Bins",
      "Id": 822,
      "Description": "Persevering multi-tasking benchmark",
      "ExtraInfo": "quis",
      "LinkId": 159
    }
  ],
  "ActiveLinks": 458,
  "Completed": false,
  "NextMilestoneDate": "2000-08-12T16:55:29.9286368+02:00",
  "NmdAppointmentId": 979,
  "EndDate": "2022-03-05T16:55:29.9286368+01:00",
  "ActiveErpLinks": 935,
  "UserDefinedFields": {
    "SuperOffice:1": "983924081",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "distinctio",
    "ExtraFields2": "eaque"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "facere"
  },
  "PublishEventDate": "2021-10-21T16:55:29.9286368+02:00",
  "PublishTo": "1996-10-27T16:55:29.9286368+01:00",
  "PublishFrom": "2019-01-13T16:55:29.9286368+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 545,
  "Name": "Robel-Stokes",
  "ProjectNumber": "754214",
  "ProjectMembers": [
    {
      "ProjectmemberId": 309,
      "ContactId": 553,
      "ProjectId": 457,
      "ContactName": "Brown Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Auer Group",
      "EmailId": 159,
      "EmailAddress": "felipa.mills@dicki.ca",
      "CountryId": 935,
      "Firstname": "Raven",
      "MiddleName": "Nader, Labadie and Robel",
      "Lastname": "Lindgren",
      "PersonId": 482,
      "Mrmrs": "illum",
      "ProjectMemberTypeName": "Schowalter-Crist",
      "Phone": "(778)345-0278",
      "PhoneId": 603,
      "ProjectMemberTypeId": 939,
      "EmailAddressName": "ollie.powlowski@wilkinson.us",
      "Comment": "soluta",
      "FullName": "Johann Runte PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 438
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "enim",
      "Description": "Proactive zero defect architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 469
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "enim",
      "Description": "Proactive zero defect architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 469
        }
      }
    }
  ],
  "CreatedDate": "2011-01-18T16:55:29.9315243+01:00",
  "UpdatedDate": "2019-03-06T16:55:29.9315243+01:00",
  "Description": "Fundamental global firmware",
  "Postit": "quia",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "De-engineered reciprocal software",
  "ActiveStatusMonitorId": 631,
  "Links": [
    {
      "EntityName": "Gerhold-Balistreri",
      "Id": 418,
      "Description": "Implemented encompassing process improvement",
      "ExtraInfo": "et",
      "LinkId": 744,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 115
        }
      }
    }
  ],
  "ActiveLinks": 654,
  "Completed": false,
  "NextMilestoneDate": "2019-06-22T16:55:29.9326149+02:00",
  "NmdAppointmentId": 914,
  "EndDate": "1998-12-17T16:55:29.9326149+01:00",
  "ActiveErpLinks": 655,
  "UserDefinedFields": {
    "SuperOffice:1": "1861027140",
    "SuperOffice:2": "Helga Predovic"
  },
  "ExtraFields": {
    "ExtraFields1": "impedit",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "cupiditate"
  },
  "PublishEventDate": "2006-12-07T16:55:29.9326149+01:00",
  "PublishTo": "2021-07-13T16:55:29.9326149+02:00",
  "PublishFrom": "2020-12-14T16:55:29.9326149+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 647
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```