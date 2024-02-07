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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "voluptas",
    "value": {}
  },
  {
    "op": "add",
    "path": "voluptas",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 901,
  "Firstname": "Mallie",
  "MiddleName": "Keeling-Schowalter",
  "Lastname": "Quigley",
  "Mrmrs": "iure",
  "Title": "eaque",
  "UpdatedDate": "2013-09-15T16:55:29.8820174+02:00",
  "CreatedDate": "1998-12-23T16:55:29.8820174+01:00",
  "BirthDate": "2016-01-04T16:55:29.8820174+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "consequatur",
      "StrippedValue": "ipsa",
      "Description": "Synergistic value-added model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 921
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "ipsa",
      "Description": "Synergistic value-added model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 921
        }
      }
    }
  ],
  "Description": "Pre-emptive analyzing budgetary management",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "earum",
      "Description": "Universal value-added emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 539
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "earum",
      "Description": "Universal value-added emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 539
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quod",
      "StrippedValue": "officia",
      "Description": "Stand-alone regional extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 879
        }
      }
    },
    {
      "Value": "quod",
      "StrippedValue": "officia",
      "Description": "Stand-alone regional extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 879
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quidem",
      "StrippedValue": "optio",
      "Description": "Cross-platform full-range initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 840
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "optio",
      "Description": "Cross-platform full-range initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 840
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "fugiat",
      "StrippedValue": "provident",
      "Description": "Switchable empowering parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 586
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "provident",
      "Description": "Switchable empowering parallelism",
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
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "voluptatem",
      "Description": "Object-based empowering functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 653
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "voluptatem",
      "Description": "Object-based empowering functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 653
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
      "Id": 851,
      "Name": "Shanahan-Homenick",
      "ToolTip": "Voluptatem quos nesciunt ut non exercitationem est.",
      "Deleted": true,
      "Rank": 961,
      "Type": "porro",
      "ColorBlock": 459,
      "IconHint": "velit",
      "Selected": true,
      "LastChanged": "2004-10-13T16:55:29.8830183+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "ullam",
      "Hidden": false,
      "FullName": "Andre Koepp",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 967
        }
      }
    }
  ],
  "PersonNumber": "632516",
  "FullName": "Twila Hyatt",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "in",
      "Description": "Cloned disintermediate challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 460
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "in",
      "Description": "Cloned disintermediate challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 460
        }
      }
    }
  ],
  "FormalName": "Corwin LLC",
  "Address": null,
  "Post3": "illo",
  "Post2": "ut",
  "Post1": "tempore",
  "Kanalname": "porro",
  "Kanafname": "molestiae",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "dolores",
  "ActiveInterests": 934,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 189,
  "DbiKey": "aut",
  "DbiLastModified": "1996-12-14T16:55:29.8859976+01:00",
  "DbiLastSyncronized": "2009-10-01T16:55:29.8859976+02:00",
  "SentInfo": 530,
  "ShowContactTickets": 943,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nostrum",
      "StrippedValue": "autem",
      "Description": "Up-sized high-level adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 454
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "autem",
      "Description": "Up-sized high-level adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 454
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "asperiores",
      "StrippedValue": "mollitia",
      "Description": "Optional methodical open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 435
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "mollitia",
      "Description": "Optional methodical open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 435
        }
      }
    }
  ],
  "Source": 702,
  "ActiveErpLinks": 368,
  "ShipmentTypes": [
    {
      "Id": 891,
      "Name": "Murray, Gerlach and Sawayn",
      "ToolTip": "Aut doloremque quia.",
      "Deleted": true,
      "Rank": 520,
      "Type": "aliquam",
      "ColorBlock": 745,
      "IconHint": "sit",
      "Selected": false,
      "LastChanged": "2017-09-18T16:55:29.8859976+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "deserunt",
      "StyleHint": "repellendus",
      "Hidden": false,
      "FullName": "Camren Casper",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 886
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 531,
      "Comment": "dolorem",
      "Registered": "2021-06-13T16:55:29.8859976+02:00",
      "RegisteredAssociateId": 672,
      "Updated": "2005-08-22T16:55:29.8859976+02:00",
      "UpdatedAssociateId": 899,
      "LegalBaseId": 617,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Nicolas, Wiegand and Jacobson",
      "ConsentPurposeId": 306,
      "ConsentPurposeKey": "blanditiis",
      "ConsentPurposeName": "Johnson, Beier and Kassulke",
      "ConsentSourceId": 761,
      "ConsentSourceKey": "dignissimos",
      "ConsentSourceName": "Fahey, O'Kon and McGlynn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 75
        }
      }
    }
  ],
  "BounceEmails": [
    "madison.nitzsche@gibson.us",
    "bernhard.kilback@batz.biz"
  ],
  "ActiveStatusMonitorId": 557,
  "UserDefinedFields": {
    "SuperOffice:1": "Adell O'Connell",
    "SuperOffice:2": "Uriah Langosh"
  },
  "ExtraFields": {
    "ExtraFields1": "ex",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "quibusdam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 518
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```