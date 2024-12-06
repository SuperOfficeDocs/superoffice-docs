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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 945,
  "Name": "Greenholt, Cummings and Kuhlman",
  "ProjectNumber": "1219212",
  "ProjectMembers": [
    {
      "ProjectmemberId": 772,
      "ContactId": 173,
      "ProjectId": 635,
      "ContactName": "Rogahn, Skiles and Kunze",
      "ContactDepartment": "",
      "ProjectName": "Jakubowski-Kihn",
      "EmailId": 587,
      "EmailAddress": "shanna@graham.name",
      "CountryId": 382,
      "Firstname": "Donavon",
      "MiddleName": "Blick-Brakus",
      "Lastname": "Bayer",
      "PersonId": 35,
      "Mrmrs": "vel",
      "ProjectMemberTypeName": "Predovic-Eichmann",
      "Phone": "(318)897-0864 x293",
      "PhoneId": 781,
      "ProjectMemberTypeId": 69,
      "EmailAddressName": "connie_flatley@ryan.biz",
      "Comment": "voluptatem",
      "FullName": "Parker Considine"
    }
  ],
  "Urls": [
    {
      "Value": "magni",
      "StrippedValue": "eos",
      "Description": "Cross-group stable matrices"
    },
    {
      "Value": "magni",
      "StrippedValue": "eos",
      "Description": "Cross-group stable matrices"
    }
  ],
  "CreatedDate": "2022-05-05T10:17:55.8790557+02:00",
  "UpdatedDate": "2001-05-19T10:17:55.8790557+02:00",
  "Description": "Polarised asynchronous framework",
  "Postit": "illo",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Centralized grid-enabled internet solution",
  "ActiveStatusMonitorId": 95,
  "Links": [
    {
      "EntityName": "Wehner, Wilkinson and Schmeler",
      "Id": 939,
      "Description": "Face to face client-driven hub",
      "ExtraInfo": "mollitia",
      "LinkId": 879
    },
    {
      "EntityName": "Wehner, Wilkinson and Schmeler",
      "Id": 939,
      "Description": "Face to face client-driven hub",
      "ExtraInfo": "mollitia",
      "LinkId": 879
    }
  ],
  "ActiveLinks": 546,
  "Completed": false,
  "NextMilestoneDate": "2003-03-29T10:17:55.8790557+01:00",
  "NmdAppointmentId": 835,
  "EndDate": "2020-03-22T10:17:55.8790557+01:00",
  "ActiveErpLinks": 820,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "mollitia",
    "ExtraFields2": "illum"
  },
  "CustomFields": {
    "CustomFields1": "numquam",
    "CustomFields2": "sit"
  },
  "PublishEventDate": "2013-05-12T10:17:55.8790557+02:00",
  "PublishTo": "2011-12-18T10:17:55.8790557+01:00",
  "PublishFrom": "2020-07-03T10:17:55.8790557+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 597,
  "Name": "Rodriguez, Larson and Sauer",
  "ProjectNumber": "1291181",
  "ProjectMembers": [
    {
      "ProjectmemberId": 643,
      "ContactId": 91,
      "ProjectId": 634,
      "ContactName": "Veum-Tremblay",
      "ContactDepartment": "",
      "ProjectName": "Hane-Prohaska",
      "EmailId": 249,
      "EmailAddress": "katherine_stroman@uptongleichner.name",
      "CountryId": 667,
      "Firstname": "Shanie",
      "MiddleName": "Wilkinson-Dach",
      "Lastname": "Osinski",
      "PersonId": 503,
      "Mrmrs": "eaque",
      "ProjectMemberTypeName": "Willms Group",
      "Phone": "775-475-5339",
      "PhoneId": 952,
      "ProjectMemberTypeId": 240,
      "EmailAddressName": "oren@borergoyette.com",
      "Comment": "ea",
      "FullName": "Roy Kuhic",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 668
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quos",
      "StrippedValue": "natus",
      "Description": "Synergized mobile challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 957
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "natus",
      "Description": "Synergized mobile challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 957
        }
      }
    }
  ],
  "CreatedDate": "2020-08-23T10:17:55.8790557+02:00",
  "UpdatedDate": "2016-02-16T10:17:55.8790557+01:00",
  "Description": "Diverse object-oriented extranet",
  "Postit": "rerum",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "De-engineered impactful pricing structure",
  "ActiveStatusMonitorId": 208,
  "Links": [
    {
      "EntityName": "Dietrich LLC",
      "Id": 919,
      "Description": "De-engineered grid-enabled moratorium",
      "ExtraInfo": "sint",
      "LinkId": 481,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    }
  ],
  "ActiveLinks": 930,
  "Completed": false,
  "NextMilestoneDate": "2023-07-01T10:17:55.8790557+02:00",
  "NmdAppointmentId": 399,
  "EndDate": "2016-03-01T10:17:55.8790557+01:00",
  "ActiveErpLinks": 10,
  "UserDefinedFields": {
    "SuperOffice:1": "Deron Beer",
    "SuperOffice:2": "Queen Nicolas"
  },
  "ExtraFields": {
    "ExtraFields1": "quam",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "eos"
  },
  "PublishEventDate": "2002-08-19T10:17:55.8790557+02:00",
  "PublishTo": "2004-12-20T10:17:55.8790557+01:00",
  "PublishFrom": "2019-03-20T10:17:55.8790557+01:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 987
    }
  }
}
```