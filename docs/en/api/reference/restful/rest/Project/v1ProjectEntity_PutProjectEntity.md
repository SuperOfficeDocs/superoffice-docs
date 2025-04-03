---
title: PUT Project/{id}
uid: v1ProjectEntity_PutProjectEntity
generated: true
---

# PUT Project/{id}

```http
PUT /api/v1/Project/{id}
```

Updates the existing ProjectEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Project/{id}?$select=name,department,category/id
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

ProjectEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity updated. |
| 412 | Update stopped because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 109,
  "Name": "Paucek, Stehr and Bogisich",
  "ProjectNumber": "1264026",
  "ProjectMembers": [
    {
      "ProjectmemberId": 551,
      "ContactId": 173,
      "ProjectId": 705,
      "ContactName": "Heathcote Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Leannon Group",
      "EmailId": 148,
      "EmailAddress": "sydnie_gutkowski@macejkovic.name",
      "CountryId": 198,
      "Firstname": "Danny",
      "MiddleName": "Hackett, Kreiger and Williamson",
      "Lastname": "Goyette",
      "PersonId": 920,
      "Mrmrs": "in",
      "ProjectMemberTypeName": "Kub Group",
      "Phone": "640.520.5981",
      "PhoneId": 813,
      "ProjectMemberTypeId": 924,
      "EmailAddressName": "judge@ryantreutel.co.uk",
      "Comment": "vel",
      "FullName": "Pink Ryan"
    }
  ],
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "maiores",
      "Description": "Progressive explicit pricing structure"
    },
    {
      "Value": "nihil",
      "StrippedValue": "maiores",
      "Description": "Progressive explicit pricing structure"
    }
  ],
  "CreatedDate": "2008-10-13T14:28:27.0395655+02:00",
  "UpdatedDate": "2011-10-26T14:28:27.0395655+02:00",
  "Description": "Open-architected mission-critical algorithm",
  "Postit": "voluptas",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Streamlined contextually-based archive",
  "ActiveStatusMonitorId": 312,
  "Links": [
    {
      "EntityName": "Dibbert, Bayer and Stracke",
      "Id": 616,
      "Description": "Compatible dynamic encoding",
      "ExtraInfo": "dolores",
      "LinkId": 323
    },
    {
      "EntityName": "Dibbert, Bayer and Stracke",
      "Id": 616,
      "Description": "Compatible dynamic encoding",
      "ExtraInfo": "dolores",
      "LinkId": 323
    }
  ],
  "ActiveLinks": 465,
  "Completed": false,
  "NextMilestoneDate": "2006-08-08T14:28:27.0395655+02:00",
  "NmdAppointmentId": 873,
  "EndDate": "2014-02-01T14:28:27.0395655+01:00",
  "ActiveErpLinks": 920,
  "UserDefinedFields": {
    "SuperOffice:1": "Elijah Dooley",
    "SuperOffice:2": "1411976552"
  },
  "ExtraFields": {
    "ExtraFields1": "odio",
    "ExtraFields2": "cumque"
  },
  "CustomFields": {
    "CustomFields1": "laborum",
    "CustomFields2": "iste"
  },
  "PublishEventDate": "2022-04-15T14:28:27.0395655+02:00",
  "PublishTo": "2003-11-24T14:28:27.0395655+01:00",
  "PublishFrom": "2012-06-17T14:28:27.0395655+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 863,
  "Name": "Gerlach-Sauer",
  "ProjectNumber": "817553",
  "ProjectMembers": [
    {
      "ProjectmemberId": 635,
      "ContactId": 501,
      "ProjectId": 550,
      "ContactName": "Daugherty, Wiegand and Ondricka",
      "ContactDepartment": "",
      "ProjectName": "Towne, Crooks and Braun",
      "EmailId": 268,
      "EmailAddress": "mya@ferry.biz",
      "CountryId": 247,
      "Firstname": "Garland",
      "MiddleName": "Koss Inc and Sons",
      "Lastname": "Robel",
      "PersonId": 742,
      "Mrmrs": "vel",
      "ProjectMemberTypeName": "Abbott, Morissette and Dietrich",
      "Phone": "(478)594-2446",
      "PhoneId": 215,
      "ProjectMemberTypeId": 509,
      "EmailAddressName": "mitchel@smith.ca",
      "Comment": "nemo",
      "FullName": "Caleb Hartmann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 339
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "numquam",
      "Description": "Secured global model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 329
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "numquam",
      "Description": "Secured global model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 329
        }
      }
    }
  ],
  "CreatedDate": "2005-09-27T14:28:27.0395655+02:00",
  "UpdatedDate": "2009-02-06T14:28:27.0395655+01:00",
  "Description": "Organic content-based collaboration",
  "Postit": "sunt",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Diverse 4th generation success",
  "ActiveStatusMonitorId": 30,
  "Links": [
    {
      "EntityName": "Braun-Schiller",
      "Id": 30,
      "Description": "Reverse-engineered holistic focus group",
      "ExtraInfo": "dicta",
      "LinkId": 55,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 418
        }
      }
    }
  ],
  "ActiveLinks": 61,
  "Completed": true,
  "NextMilestoneDate": "2005-08-21T14:28:27.0395655+02:00",
  "NmdAppointmentId": 669,
  "EndDate": "2010-03-15T14:28:27.0395655+01:00",
  "ActiveErpLinks": 178,
  "UserDefinedFields": {
    "SuperOffice:1": "Esperanza Douglas",
    "SuperOffice:2": "Mr. Yvette Bayer I"
  },
  "ExtraFields": {
    "ExtraFields1": "corrupti",
    "ExtraFields2": "magnam"
  },
  "CustomFields": {
    "CustomFields1": "quidem",
    "CustomFields2": "ea"
  },
  "PublishEventDate": "2018-01-04T14:28:27.0395655+01:00",
  "PublishTo": "2003-09-27T14:28:27.0395655+02:00",
  "PublishFrom": "2007-03-08T14:28:27.0395655+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 702
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```