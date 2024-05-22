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
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "harum",
    "value": {}
  },
  {
    "op": "add",
    "path": "harum",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 632,
  "Name": "Eichmann-Effertz",
  "Department": "",
  "OrgNr": "895336",
  "Number1": "1426058",
  "Number2": "1357725",
  "UpdatedDate": "2006-03-13T12:57:42.2764202+01:00",
  "CreatedDate": "2002-08-07T12:57:42.2764202+02:00",
  "Emails": [
    {
      "Value": "alias",
      "StrippedValue": "ducimus",
      "Description": "Networked high-level matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 219
        }
      }
    },
    {
      "Value": "alias",
      "StrippedValue": "ducimus",
      "Description": "Networked high-level matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 219
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 106,
      "Name": "Murphy, Stehr and Kozey",
      "ToolTip": "Ut saepe.",
      "Deleted": true,
      "Rank": 763,
      "Type": "esse",
      "ColorBlock": 386,
      "IconHint": "at",
      "Selected": false,
      "LastChanged": "2017-10-08T12:57:42.2764202+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "quis",
      "Hidden": false,
      "FullName": "Cleora Zulauf",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 957
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ea",
      "StrippedValue": "ea",
      "Description": "Object-based intangible system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 795
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "ea",
      "Description": "Object-based intangible system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 795
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "rerum",
      "StrippedValue": "dolor",
      "Description": "Adaptive actuating algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 605
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "dolor",
      "Description": "Adaptive actuating algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 605
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quam",
      "StrippedValue": "aut",
      "Description": "Networked fault-tolerant Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 841
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "aut",
      "Description": "Networked fault-tolerant Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 841
        }
      }
    }
  ],
  "Description": "Realigned actuating utilisation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "amet",
      "PersonId": 469,
      "Mrmrs": "eum",
      "Firstname": "Bernita",
      "Lastname": "Kuvalis",
      "MiddleName": "Weber, Sawayn and Johnston",
      "Title": "odio",
      "Description": "Upgradable 6th generation strategy",
      "Email": "pearlie@haleykuhlman.biz",
      "FullName": "Olaf Gusikowski",
      "DirectPhone": "846.008.7682",
      "FormalName": "VonRueden, Greenholt and Wiegand",
      "CountryId": 183,
      "ContactId": 337,
      "ContactName": "Moore, Carroll and Kling",
      "Retired": 643,
      "Rank": 987,
      "ActiveInterests": 898,
      "ContactDepartment": "",
      "ContactCountryId": 177,
      "ContactOrgNr": "601615",
      "FaxPhone": "145.624.0241 x83014",
      "MobilePhone": "980-859-4064 x190",
      "ContactPhone": "558-637-1619",
      "AssociateName": "Denesik Inc and Sons",
      "AssociateId": 345,
      "UsePersonAddress": false,
      "ContactFax": "voluptatum",
      "Kanafname": "cumque",
      "Kanalname": "suscipit",
      "Post1": "iste",
      "Post2": "reiciendis",
      "Post3": "velit",
      "EmailName": "ardella@manncummerata.com",
      "ContactFullName": "Kaela Willms",
      "ActiveErpLinks": 839,
      "TicketPriorityId": 867,
      "SupportLanguageId": 163,
      "SupportAssociateId": 849,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 618
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "temporibus",
  "Xstop": false,
  "ActiveInterests": 364,
  "GroupId": 325,
  "ActiveStatusMonitorId": 481,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 748,
  "DbiAgentId": 530,
  "DbiLastSyncronized": "2015-07-18T12:57:42.2764202+02:00",
  "DbiKey": "aut",
  "DbiLastModified": "2011-12-11T12:57:42.2764202+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 654,
  "ActiveErpLinks": 747,
  "BounceEmails": [
    "heath@wardfadel.co.uk",
    "jess@daugherty.uk"
  ],
  "Domains": [
    "quasi",
    "ipsa"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Jarred Reina Monahan MD",
    "SuperOffice:2": "Fidel Hilpert"
  },
  "ExtraFields": {
    "ExtraFields1": "doloribus",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "dolores",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 509
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```