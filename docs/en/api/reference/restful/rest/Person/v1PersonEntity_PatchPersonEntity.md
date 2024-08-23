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
    "path": "quaerat",
    "value": {}
  },
  {
    "op": "add",
    "path": "quaerat",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 28,
  "Firstname": "Marcel",
  "MiddleName": "Schimmel, Marks and O'Keefe",
  "Lastname": "Collier",
  "Mrmrs": "ipsa",
  "Title": "modi",
  "UpdatedDate": "2001-01-04T13:28:31.7885906+01:00",
  "CreatedDate": "2007-08-19T13:28:31.7885906+02:00",
  "BirthDate": "2008-07-03T13:28:31.7885906+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Extended logistical matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 520
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Extended logistical matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 520
        }
      }
    }
  ],
  "Description": "Multi-lateral encompassing complexity",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "fugiat",
      "StrippedValue": "incidunt",
      "Description": "Programmable dedicated parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 797
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "incidunt",
      "Description": "Programmable dedicated parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 797
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "numquam",
      "StrippedValue": "aut",
      "Description": "Networked static functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 302
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "aut",
      "Description": "Networked static functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 302
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "blanditiis",
      "StrippedValue": "provident",
      "Description": "Pre-emptive bi-directional secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 665
        }
      }
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "provident",
      "Description": "Pre-emptive bi-directional secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 665
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "vitae",
      "Description": "Business-focused intangible project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 49
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "vitae",
      "Description": "Business-focused intangible project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 49
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "architecto",
      "Description": "Horizontal zero administration initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 450
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "architecto",
      "Description": "Horizontal zero administration initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 450
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
      "Id": 920,
      "Name": "Abernathy LLC",
      "ToolTip": "Facilis qui iure.",
      "Deleted": true,
      "Rank": 577,
      "Type": "quod",
      "ColorBlock": 764,
      "IconHint": "temporibus",
      "Selected": false,
      "LastChanged": "2003-09-22T13:28:31.8042094+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ullam",
      "StyleHint": "non",
      "Hidden": true,
      "FullName": "Mrs. Enrique Murphy V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 170
        }
      }
    }
  ],
  "PersonNumber": "1691634",
  "FullName": "Tierra Myles Haley DDS",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "consequatur",
      "Description": "Function-based coherent orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "consequatur",
      "Description": "Function-based coherent orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    }
  ],
  "FormalName": "Swift-Anderson",
  "Address": null,
  "Post3": "rerum",
  "Post2": "est",
  "Post1": "non",
  "Kanalname": "reprehenderit",
  "Kanafname": "quos",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "placeat",
  "ActiveInterests": 844,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 650,
  "DbiKey": "saepe",
  "DbiLastModified": "2018-05-23T13:28:31.8042094+02:00",
  "DbiLastSyncronized": "2004-07-22T13:28:31.8042094+02:00",
  "SentInfo": 83,
  "ShowContactTickets": 792,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quibusdam",
      "StrippedValue": "dolor",
      "Description": "Re-contextualized directional project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "dolor",
      "Description": "Re-contextualized directional project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "illum",
      "StrippedValue": "ratione",
      "Description": "Persevering heuristic implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "ratione",
      "Description": "Persevering heuristic implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    }
  ],
  "Source": 848,
  "ActiveErpLinks": 532,
  "ShipmentTypes": [
    {
      "Id": 779,
      "Name": "Hilpert, Bauch and Veum",
      "ToolTip": "Quibusdam sunt laborum nam blanditiis.",
      "Deleted": true,
      "Rank": 340,
      "Type": "molestiae",
      "ColorBlock": 559,
      "IconHint": "culpa",
      "Selected": true,
      "LastChanged": "2011-09-09T13:28:31.8042094+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "culpa",
      "StyleHint": "vel",
      "Hidden": true,
      "FullName": "Miss Modesto Micaela Miller",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 460,
      "Comment": "dolor",
      "Registered": "2010-12-08T13:28:31.8042094+01:00",
      "RegisteredAssociateId": 601,
      "Updated": "2015-05-16T13:28:31.8042094+02:00",
      "UpdatedAssociateId": 874,
      "LegalBaseId": 236,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Keebler, Romaguera and Pacocha",
      "ConsentPurposeId": 926,
      "ConsentPurposeKey": "sint",
      "ConsentPurposeName": "Pollich, Wuckert and Lockman",
      "ConsentSourceId": 929,
      "ConsentSourceKey": "autem",
      "ConsentSourceName": "Wilderman, Grady and Jones",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 312
        }
      }
    }
  ],
  "BounceEmails": [
    "bill@hansen.biz",
    "curtis@walsh.name"
  ],
  "ActiveStatusMonitorId": 833,
  "CreatedByFormId": 823,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "2066362081"
  },
  "ExtraFields": {
    "ExtraFields1": "optio",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "quae",
    "CustomFields2": "sit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 703
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```