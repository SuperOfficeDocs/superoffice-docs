---
title: PATCH Person/{id}
uid: v1PersonEntity_PatchPersonEntity
generated: true
---

# PATCH Person/{id}

```http
PATCH /api/v1/Person/{id}
```

Update a PersonEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.


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



Calls the {SuperOffice.CRM.Services.IPersonAgent} service SavePersonEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PersonEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Person/{id}?$select=name,department,category/id
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

PersonEntity  updated.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity  updated. |
| 404 | PersonEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because PersonEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: PersonEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| CreatedByFormId | int32 | The form id of the form that created the person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PATCH /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "atque",
    "value": {}
  },
  {
    "op": "add",
    "path": "atque",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 249,
  "Firstname": "Patsy",
  "MiddleName": "Konopelski-Will",
  "Lastname": "Smitham",
  "Mrmrs": "ut",
  "Title": "omnis",
  "UpdatedDate": "2000-08-22T10:18:00.4730845+02:00",
  "CreatedDate": "2005-02-09T10:18:00.4730845+01:00",
  "BirthDate": "2021-02-18T10:18:00.4730845+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "rem",
      "StrippedValue": "velit",
      "Description": "Implemented mission-critical attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "velit",
      "Description": "Implemented mission-critical attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    }
  ],
  "Description": "Implemented directional implementation",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ut",
      "StrippedValue": "occaecati",
      "Description": "Cloned leading edge conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 862
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "occaecati",
      "Description": "Cloned leading edge conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 862
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "optio",
      "StrippedValue": "totam",
      "Description": "Re-contextualized solution-oriented Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 11
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "totam",
      "Description": "Re-contextualized solution-oriented Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 11
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "qui",
      "StrippedValue": "tempora",
      "Description": "Digitized holistic framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 632
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "tempora",
      "Description": "Digitized holistic framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 632
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "incidunt",
      "StrippedValue": "repellendus",
      "Description": "Polarised fresh-thinking support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 82
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "repellendus",
      "Description": "Polarised fresh-thinking support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 82
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "rerum",
      "StrippedValue": "dolore",
      "Description": "Centralized cohesive complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 707
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "dolore",
      "Description": "Centralized cohesive complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 707
        }
      }
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 720,
      "Name": "Murphy LLC",
      "ToolTip": "Ea voluptatem vel rem delectus aut.",
      "Deleted": true,
      "Rank": 297,
      "Type": "debitis",
      "ColorBlock": 224,
      "IconHint": "tempore",
      "Selected": true,
      "LastChanged": "2005-09-21T10:18:00.4730845+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "magnam",
      "Hidden": true,
      "FullName": "Alayna Bruen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    }
  ],
  "PersonNumber": "997112",
  "FullName": "Anita Zboncak",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "laborum",
      "StrippedValue": "nemo",
      "Description": "Persevering methodical synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 40
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "nemo",
      "Description": "Persevering methodical synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 40
        }
      }
    }
  ],
  "FormalName": "Nitzsche Group",
  "Address": null,
  "Post3": "dolorem",
  "Post2": "deleniti",
  "Post1": "qui",
  "Kanalname": "et",
  "Kanafname": "ab",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 874,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 941,
  "DbiKey": "distinctio",
  "DbiLastModified": "2007-12-16T10:18:00.4730845+01:00",
  "DbiLastSyncronized": "2018-06-06T10:18:00.4730845+02:00",
  "SentInfo": 756,
  "ShowContactTickets": 90,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "in",
      "StrippedValue": "ipsa",
      "Description": "Total mission-critical attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 220
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "ipsa",
      "Description": "Total mission-critical attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 220
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "animi",
      "StrippedValue": "eaque",
      "Description": "Object-based context-sensitive encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 12
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "eaque",
      "Description": "Object-based context-sensitive encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 12
        }
      }
    }
  ],
  "Source": 395,
  "ActiveErpLinks": 634,
  "ShipmentTypes": [
    {
      "Id": 213,
      "Name": "McCullough Group",
      "ToolTip": "Minus impedit distinctio.",
      "Deleted": true,
      "Rank": 853,
      "Type": "voluptatibus",
      "ColorBlock": 490,
      "IconHint": "nemo",
      "Selected": true,
      "LastChanged": "2013-01-31T10:18:00.4730845+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vero",
      "StyleHint": "est",
      "Hidden": true,
      "FullName": "Norberto Mayer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 440
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 417,
      "Comment": "officiis",
      "Registered": "2018-12-02T10:18:00.4730845+01:00",
      "RegisteredAssociateId": 104,
      "Updated": "2002-03-09T10:18:00.4730845+01:00",
      "UpdatedAssociateId": 441,
      "LegalBaseId": 134,
      "LegalBaseKey": "maxime",
      "LegalBaseName": "Luettgen, Champlin and Hodkiewicz",
      "ConsentPurposeId": 67,
      "ConsentPurposeKey": "molestiae",
      "ConsentPurposeName": "Wolf, Ullrich and Kirlin",
      "ConsentSourceId": 15,
      "ConsentSourceKey": "est",
      "ConsentSourceName": "Mills, Crona and Lehner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 586
        }
      }
    }
  ],
  "BounceEmails": [
    "flo@keeblerhane.ca",
    "lera_brown@rathpfannerstill.info"
  ],
  "ActiveStatusMonitorId": 380,
  "CreatedByFormId": 72,
  "UserDefinedFields": {
    "SuperOffice:1": "1106543099",
    "SuperOffice:2": "Mrs. Mylene Eichmann"
  },
  "ExtraFields": {
    "ExtraFields1": "cum",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "quos",
    "CustomFields2": "cumque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 498
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```