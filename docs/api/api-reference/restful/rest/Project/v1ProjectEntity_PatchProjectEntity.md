---
title: PATCH Project/{id}
id: v1ProjectEntity_PatchProjectEntity
---

# PATCH Project/{id}

```http
PATCH /api/v1/Project/{id}
```

Update a ProjectEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IProjectAgent} service SaveProjectEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Project/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object

The Project Service. The service implements all services working with the Project object



ProjectEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity  updated. |
| 404 | ProjectEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

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
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "fuga",
    "value": {
      "value1": {
        "PrimaryKey": 2438,
        "EntityName": "sale",
        "saleId": 2438,
        "contactId": 8630,
        "name": "West, Konopelski and Feil"
      },
      "value2": {
        "PrimaryKey": 2552,
        "EntityName": "person",
        "personId": 2552,
        "fullName": "Bernhard Ziemann"
      }
    }
  },
  {
    "op": "add",
    "path": "fuga",
    "value": {
      "value1": {
        "PrimaryKey": 2438,
        "EntityName": "sale",
        "saleId": 2438,
        "contactId": 8630,
        "name": "West, Konopelski and Feil"
      },
      "value2": {
        "PrimaryKey": 2552,
        "EntityName": "person",
        "personId": 2552,
        "fullName": "Bernhard Ziemann"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ProjectEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 637,
  "Name": "Simonis LLC",
  "ProjectNumber": "1127040",
  "ProjectMembers": [
    {
      "ProjectmemberId": 788,
      "ContactId": 931,
      "ProjectId": 622,
      "ContactName": "Lynch-Gleichner",
      "ContactDepartment": "",
      "ProjectName": "Langworth LLC",
      "EmailId": 30,
      "EmailAddress": "raymond@labadie.ca",
      "CountryId": 206,
      "Firstname": "Augustus",
      "MiddleName": "Langworth-Reichert",
      "Lastname": "Gleichner",
      "PersonId": 809,
      "Mrmrs": "in",
      "ProjectMemberTypeName": "West, Rippin and Stark",
      "Phone": "857.257.2537 x35524",
      "PhoneId": 870,
      "ProjectMemberTypeId": 296,
      "EmailAddressName": "madie.kilback@reynolds.us",
      "Comment": "qui",
      "FullName": "Nya Howe",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 526
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vel",
      "StrippedValue": "odit",
      "Description": "Reduced foreground knowledge user",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 75
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "odit",
      "Description": "Reduced foreground knowledge user",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 75
        }
      }
    }
  ],
  "CreatedDate": "2004-09-06T15:05:42.4766684+02:00",
  "UpdatedDate": "2007-03-18T15:05:42.4766684+01:00",
  "Description": "Synergistic intangible knowledge base",
  "Postit": "vitae",
  "CreatedBy": {
    "AssociateId": 644,
    "Name": "Corkery-Torphy",
    "PersonId": 611,
    "Rank": 64,
    "Tooltip": "magni",
    "Type": "AnonymousAssociate",
    "GroupIdx": 783,
    "FullName": "Hugh Mraz",
    "FormalName": "Mayer Group",
    "Deleted": true,
    "EjUserId": 57,
    "UserName": "Schmeler Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 18
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 155,
    "Name": "Renner Inc and Sons",
    "PersonId": 282,
    "Rank": 339,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 916,
    "FullName": "Gaylord Hagenes",
    "FormalName": "Daugherty Group",
    "Deleted": false,
    "EjUserId": 321,
    "UserName": "Wuckert, Gottlieb and Kulas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 507
      }
    }
  },
  "Associate": {
    "AssociateId": 478,
    "Name": "Ferry-Dare",
    "PersonId": 834,
    "Rank": 617,
    "Tooltip": "accusamus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 931,
    "FullName": "Terrence Schmeler",
    "FormalName": "Koss-Borer",
    "Deleted": false,
    "EjUserId": 180,
    "UserName": "Hirthe Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 288
      }
    }
  },
  "ProjectStatus": {
    "Id": 492,
    "Value": "consequuntur",
    "Tooltip": "expedita",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 776
      }
    }
  },
  "ProjectType": {
    "Id": 862,
    "Value": "odit",
    "Tooltip": "vitae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 749
      }
    }
  },
  "HasImage": true,
  "ImageDescription": "Front-line neutral interface",
  "ActiveStatusMonitorId": 329,
  "Links": [
    {
      "EntityName": "Dicki-Mante",
      "Id": 803,
      "Description": "Ameliorated fault-tolerant hub",
      "ExtraInfo": "harum",
      "LinkId": 279,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    }
  ],
  "ActiveLinks": 136,
  "Completed": false,
  "NextMilestoneDate": "2000-05-11T15:05:42.4776671+02:00",
  "NmdAppointmentId": 850,
  "EndDate": "2008-07-18T15:05:42.4776671+02:00",
  "ActiveErpLinks": 26,
  "UserDefinedFields": {
    "SuperOffice:1": "1667979814",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "eaque",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "distinctio",
    "CustomFields2": "ut"
  },
  "PublishEventDate": "1999-11-17T15:05:42.4786672+01:00",
  "PublishTo": "2004-09-09T15:05:42.4786672+02:00",
  "PublishFrom": "2006-09-19T15:05:42.4786672+02:00",
  "IsPublished": true,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 64
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```