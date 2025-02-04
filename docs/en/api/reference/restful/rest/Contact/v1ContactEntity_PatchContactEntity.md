---
title: PATCH Contact/{id}
uid: v1ContactEntity_PatchContactEntity
generated: true
---

# PATCH Contact/{id}

```http
PATCH /api/v1/Contact/{id}
```

Update a ContactEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.


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



Calls the {SuperOffice.CRM.Services.IContactAgent} service SaveContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Contact/{id}?$select=name,department,category/id
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

## Request Body: changes 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | String | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | String | The property names to modify.  "/users/0/email", "/users/-", |
| value | Object | New/Replaced value - string or object. |

## Response:

ContactEntity  updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity  updated. |
| 404 | ContactEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PATCH /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "iste",
    "value": {}
  },
  {
    "op": "add",
    "path": "iste",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 384,
  "Name": "Mayer, Jacobi and Muller",
  "Department": "",
  "OrgNr": "1699585",
  "Number1": "994271",
  "Number2": "1309662",
  "UpdatedDate": "1999-10-03T13:13:31.5582689+02:00",
  "CreatedDate": "1999-03-02T13:13:31.5582689+01:00",
  "Emails": [
    {
      "Value": "sequi",
      "StrippedValue": "porro",
      "Description": "Face to face static focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "porro",
      "Description": "Face to face static focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 456,
      "Name": "Bashirian LLC",
      "ToolTip": "Repellendus dolorem fugit.",
      "Deleted": false,
      "Rank": 520,
      "Type": "maiores",
      "ColorBlock": 478,
      "IconHint": "nesciunt",
      "Selected": true,
      "LastChanged": "2011-07-21T13:13:31.5582689+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nobis",
      "StyleHint": "harum",
      "Hidden": true,
      "FullName": "Ms. Loma Genoveva Buckridge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 249
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "laudantium",
      "StrippedValue": "consequuntur",
      "Description": "Team-oriented mission-critical throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 207
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "consequuntur",
      "Description": "Team-oriented mission-critical throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 207
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "non",
      "StrippedValue": "iusto",
      "Description": "Advanced stable projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 920
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "iusto",
      "Description": "Advanced stable projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 920
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "corrupti",
      "StrippedValue": "odio",
      "Description": "Sharable multi-tasking project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 669
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "odio",
      "Description": "Sharable multi-tasking project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 669
        }
      }
    }
  ],
  "Description": "Innovative empowering Graphical User Interface",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aliquid",
      "PersonId": 755,
      "Mrmrs": "iure",
      "Firstname": "Alejandrin",
      "Lastname": "Cummerata",
      "MiddleName": "Bartoletti, Brown and Pacocha",
      "Title": "sapiente",
      "Description": "Quality-focused heuristic hardware",
      "Email": "jackeline.aufderhar@rau.name",
      "FullName": "Ms. Blanca Mariah Lesch Jr.",
      "DirectPhone": "1-147-025-3443 x5975",
      "FormalName": "Morar Group",
      "CountryId": 49,
      "ContactId": 644,
      "ContactName": "Yost, Reynolds and Smitham",
      "Retired": 968,
      "Rank": 928,
      "ActiveInterests": 506,
      "ContactDepartment": "",
      "ContactCountryId": 253,
      "ContactOrgNr": "1266004",
      "FaxPhone": "1-825-886-9207",
      "MobilePhone": "323.105.1045",
      "ContactPhone": "776-244-5655 x473",
      "AssociateName": "Sauer LLC",
      "AssociateId": 88,
      "UsePersonAddress": true,
      "ContactFax": "voluptas",
      "Kanafname": "ut",
      "Kanalname": "sunt",
      "Post1": "dicta",
      "Post2": "doloribus",
      "Post3": "qui",
      "EmailName": "thalia@bruen.name",
      "ContactFullName": "Miss Sharon Khalid Nicolas DVM",
      "ActiveErpLinks": 770,
      "TicketPriorityId": 526,
      "SupportLanguageId": 685,
      "SupportAssociateId": 707,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 53
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ut",
  "Xstop": true,
  "ActiveInterests": 455,
  "GroupId": 481,
  "ActiveStatusMonitorId": 790,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 801,
  "DbiAgentId": 990,
  "DbiLastSyncronized": "2015-08-25T13:13:31.5582689+02:00",
  "DbiKey": "ut",
  "DbiLastModified": "2024-11-30T13:13:31.5582689+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 324,
  "ActiveErpLinks": 837,
  "BounceEmails": [
    "tatum_wisozk@jones.biz",
    "eleazar.dare@ernser.ca"
  ],
  "Domains": [
    "ullam",
    "magnam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Avis Lockman PhD",
    "SuperOffice:2": "Earnest Schroeder"
  },
  "ExtraFields": {
    "ExtraFields1": "vitae",
    "ExtraFields2": "corporis"
  },
  "CustomFields": {
    "CustomFields1": "laboriosam",
    "CustomFields2": "quia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 625
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```