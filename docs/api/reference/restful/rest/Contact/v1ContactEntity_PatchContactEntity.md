---
title: PATCH Contact/{id}
uid: v1ContactEntity_PatchContactEntity
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

## Request Body: changes string

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations).

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |

## Response

ContactEntity  updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity  updated. |
| 404 | ContactEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |

Response body:

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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |
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
    "path": "sed",
    "value": {}
  },
  {
    "op": "add",
    "path": "sed",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 266,
  "Name": "Krajcik, Bartell and Koss",
  "Department": "",
  "OrgNr": "1345479",
  "Number1": "812375",
  "Number2": "574094",
  "UpdatedDate": "2007-07-26T11:10:52.6941739+02:00",
  "CreatedDate": "1996-07-14T11:10:52.6941739+02:00",
  "Emails": [
    {
      "Value": "molestiae",
      "StrippedValue": "est",
      "Description": "Total full-range monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 341
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "est",
      "Description": "Total full-range monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 341
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 181,
      "Name": "Emmerich Inc and Sons",
      "ToolTip": "Inventore qui laborum aut impedit vel quia.",
      "Deleted": false,
      "Rank": 826,
      "Type": "delectus",
      "ColorBlock": 646,
      "IconHint": "magni",
      "Selected": false,
      "LastChanged": "2010-10-13T11:10:52.6941739+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "error",
      "Hidden": false,
      "FullName": "Noe Kassulke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "veritatis",
      "StrippedValue": "culpa",
      "Description": "Multi-tiered high-level architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 290
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "culpa",
      "Description": "Multi-tiered high-level architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 290
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "harum",
      "StrippedValue": "eum",
      "Description": "Open-source user-facing matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 773
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "eum",
      "Description": "Open-source user-facing matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 773
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ullam",
      "StrippedValue": "non",
      "Description": "Progressive web-enabled ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 737
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "non",
      "Description": "Progressive web-enabled ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 737
        }
      }
    }
  ],
  "Description": "Operative coherent flexibility",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ea",
      "PersonId": 242,
      "Mrmrs": "aut",
      "Firstname": "Vita",
      "Lastname": "Bernier",
      "MiddleName": "Pfannerstill Inc and Sons",
      "Title": "possimus",
      "Description": "Visionary holistic leverage",
      "Email": "sedrick@harrishansen.us",
      "FullName": "Erna Ebert",
      "DirectPhone": "280-135-3368 x645",
      "FormalName": "Thiel, Hilll and Bogisich",
      "CountryId": 596,
      "ContactId": 545,
      "ContactName": "Jakubowski-Weber",
      "Retired": 43,
      "Rank": 226,
      "ActiveInterests": 776,
      "ContactDepartment": "",
      "ContactCountryId": 668,
      "ContactOrgNr": "1251896",
      "FaxPhone": "228-009-9961",
      "MobilePhone": "731.575.3979",
      "ContactPhone": "(120)299-5351 x6242",
      "AssociateName": "Quitzon LLC",
      "AssociateId": 618,
      "UsePersonAddress": true,
      "ContactFax": "ut",
      "Kanafname": "quis",
      "Kanalname": "quam",
      "Post1": "tenetur",
      "Post2": "quia",
      "Post3": "ut",
      "EmailName": "orrin@deckowgreenfelder.ca",
      "ContactFullName": "Abagail Huel I",
      "ActiveErpLinks": 547,
      "TicketPriorityId": 140,
      "SupportLanguageId": 566,
      "SupportAssociateId": 851,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 938
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "officiis",
  "Xstop": true,
  "ActiveInterests": 979,
  "GroupId": 918,
  "ActiveStatusMonitorId": 549,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 671,
  "DbiAgentId": 1002,
  "DbiLastSyncronized": "2016-09-21T11:10:52.6991739+02:00",
  "DbiKey": "facere",
  "DbiLastModified": "2001-09-02T11:10:52.6991739+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 179,
  "ActiveErpLinks": 333,
  "BounceEmails": [
    "alexandro.lesch@lang.name",
    "jaquan@white.us"
  ],
  "Domains": [
    "optio",
    "iste"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Ms. Leonor Walter II"
  },
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "aspernatur"
  },
  "CustomFields": {
    "CustomFields1": "optio",
    "CustomFields2": "id"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 600
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```
