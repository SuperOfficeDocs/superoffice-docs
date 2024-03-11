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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "optio",
    "value": {}
  },
  {
    "op": "add",
    "path": "optio",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 945,
  "Name": "Pfeffer-Bode",
  "Department": "",
  "OrgNr": "224080",
  "Number1": "1061473",
  "Number2": "1067345",
  "UpdatedDate": "2022-11-14T14:23:54.9915278+01:00",
  "CreatedDate": "2008-07-12T14:23:54.9915278+02:00",
  "Emails": [
    {
      "Value": "nemo",
      "StrippedValue": "saepe",
      "Description": "Grass-roots transitional productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 483
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "saepe",
      "Description": "Grass-roots transitional productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 483
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 466,
      "Name": "Mayer-Reynolds",
      "ToolTip": "Deserunt accusantium qui.",
      "Deleted": true,
      "Rank": 515,
      "Type": "deserunt",
      "ColorBlock": 932,
      "IconHint": "dolores",
      "Selected": false,
      "LastChanged": "2010-08-28T14:23:54.9915278+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quibusdam",
      "StyleHint": "reprehenderit",
      "Hidden": false,
      "FullName": "Dr. Alexzander Brennan Mertz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 524
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "facere",
      "StrippedValue": "laborum",
      "Description": "Expanded content-based concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 710
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "laborum",
      "Description": "Expanded content-based concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 710
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "temporibus",
      "StrippedValue": "unde",
      "Description": "Implemented zero tolerance website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 217
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "unde",
      "Description": "Implemented zero tolerance website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 217
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "reiciendis",
      "Description": "Robust static emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 64
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "reiciendis",
      "Description": "Robust static emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 64
        }
      }
    }
  ],
  "Description": "Intuitive solution-oriented open architecture",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "velit",
      "PersonId": 457,
      "Mrmrs": "molestiae",
      "Firstname": "Alysha",
      "Lastname": "Cole",
      "MiddleName": "Kreiger Inc and Sons",
      "Title": "repellendus",
      "Description": "Synchronised contextually-based workforce",
      "Email": "kaci.mclaughlin@schmitt.co.uk",
      "FullName": "Mr. Colt Britney Batz II",
      "DirectPhone": "458-085-2783 x14521",
      "FormalName": "Murray, King and Weimann",
      "CountryId": 37,
      "ContactId": 514,
      "ContactName": "Russel, Erdman and Nolan",
      "Retired": 1002,
      "Rank": 843,
      "ActiveInterests": 409,
      "ContactDepartment": "",
      "ContactCountryId": 64,
      "ContactOrgNr": "582812",
      "FaxPhone": "(135)337-0245 x8942",
      "MobilePhone": "734-680-8702 x1056",
      "ContactPhone": "1-223-489-7391 x044",
      "AssociateName": "Abbott, Pagac and Lebsack",
      "AssociateId": 259,
      "UsePersonAddress": true,
      "ContactFax": "beatae",
      "Kanafname": "accusamus",
      "Kanalname": "corporis",
      "Post1": "soluta",
      "Post2": "ullam",
      "Post3": "sit",
      "EmailName": "virginie@rohan.ca",
      "ContactFullName": "Mr. Erwin Janick Lakin Sr.",
      "ActiveErpLinks": 389,
      "TicketPriorityId": 479,
      "SupportLanguageId": 930,
      "SupportAssociateId": 584,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 746
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "unde",
  "Xstop": false,
  "ActiveInterests": 158,
  "GroupId": 327,
  "ActiveStatusMonitorId": 235,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 8,
  "DbiAgentId": 92,
  "DbiLastSyncronized": "2006-12-09T14:23:54.9915278+01:00",
  "DbiKey": "recusandae",
  "DbiLastModified": "2006-02-22T14:23:54.9915278+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 741,
  "ActiveErpLinks": 306,
  "BounceEmails": [
    "presley@kerluke.ca",
    "zelma_bradtke@jacobson.biz"
  ],
  "Domains": [
    "quidem",
    "corporis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Rozella Abernathy",
    "SuperOffice:2": "Grover Jerde"
  },
  "ExtraFields": {
    "ExtraFields1": "natus",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "assumenda",
    "CustomFields2": "dicta"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 714
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```