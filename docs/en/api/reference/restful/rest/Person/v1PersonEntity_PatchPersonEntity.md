---
title: PATCH Person/{id}
uid: v1PersonEntity_PatchPersonEntity
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

## Request Body: changes string

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
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PATCH /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "animi",
    "value": {}
  },
  {
    "op": "add",
    "path": "animi",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 274,
  "Firstname": "Cecil",
  "MiddleName": "Schulist, Lesch and Kemmer",
  "Lastname": "Schroeder",
  "Mrmrs": "et",
  "Title": "voluptatem",
  "UpdatedDate": "2014-07-14T15:29:29.8816971+02:00",
  "CreatedDate": "2002-09-23T15:29:29.8816971+02:00",
  "BirthDate": "1997-03-25T15:29:29.8816971+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "provident",
      "StrippedValue": "nemo",
      "Description": "Digitized interactive frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 834
        }
      }
    },
    {
      "Value": "provident",
      "StrippedValue": "nemo",
      "Description": "Digitized interactive frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 834
        }
      }
    }
  ],
  "Description": "Centralized optimal extranet",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "neque",
      "StrippedValue": "ut",
      "Description": "Upgradable background definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 6
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "ut",
      "Description": "Upgradable background definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 6
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nobis",
      "StrippedValue": "et",
      "Description": "Exclusive 6th generation synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 286
        }
      }
    },
    {
      "Value": "nobis",
      "StrippedValue": "et",
      "Description": "Exclusive 6th generation synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 286
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "laboriosam",
      "StrippedValue": "occaecati",
      "Description": "Stand-alone context-sensitive matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 156
        }
      }
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "occaecati",
      "Description": "Stand-alone context-sensitive matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 156
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "fugit",
      "StrippedValue": "perspiciatis",
      "Description": "Customizable reciprocal encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 854
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "perspiciatis",
      "Description": "Customizable reciprocal encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 854
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptate",
      "StrippedValue": "ab",
      "Description": "Sharable optimizing moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 262
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "ab",
      "Description": "Sharable optimizing moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 262
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
      "Id": 221,
      "Name": "Zemlak-Schowalter",
      "ToolTip": "Dolore accusamus nostrum perspiciatis quidem quos.",
      "Deleted": false,
      "Rank": 864,
      "Type": "aut",
      "ColorBlock": 381,
      "IconHint": "necessitatibus",
      "Selected": false,
      "LastChanged": "2008-01-07T15:29:29.8851977+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Narciso Veum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 930
        }
      }
    }
  ],
  "PersonNumber": "808576",
  "FullName": "Geovanni Christiansen",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "pariatur",
      "StrippedValue": "omnis",
      "Description": "Operative bottom-line software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 996
        }
      }
    },
    {
      "Value": "pariatur",
      "StrippedValue": "omnis",
      "Description": "Operative bottom-line software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 996
        }
      }
    }
  ],
  "FormalName": "Maggio LLC",
  "Address": null,
  "Post3": "eum",
  "Post2": "nisi",
  "Post1": "accusamus",
  "Kanalname": "sit",
  "Kanafname": "minima",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "perspiciatis",
  "ActiveInterests": 771,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 417,
  "DbiKey": "eaque",
  "DbiLastModified": "1996-03-02T15:29:29.8876974+01:00",
  "DbiLastSyncronized": "2006-02-22T15:29:29.8876974+01:00",
  "SentInfo": 863,
  "ShowContactTickets": 753,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "recusandae",
      "StrippedValue": "culpa",
      "Description": "Assimilated fault-tolerant customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 948
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "culpa",
      "Description": "Assimilated fault-tolerant customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 948
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "at",
      "StrippedValue": "aut",
      "Description": "Self-enabling value-added help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 176
        }
      }
    },
    {
      "Value": "at",
      "StrippedValue": "aut",
      "Description": "Self-enabling value-added help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 176
        }
      }
    }
  ],
  "Source": 530,
  "ActiveErpLinks": 302,
  "ShipmentTypes": [
    {
      "Id": 899,
      "Name": "Lebsack, Sauer and Kris",
      "ToolTip": "Omnis dolores dolores minima cupiditate animi.",
      "Deleted": true,
      "Rank": 999,
      "Type": "dolores",
      "ColorBlock": 919,
      "IconHint": "ipsum",
      "Selected": true,
      "LastChanged": "2008-12-30T15:29:29.8882033+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "aut",
      "Hidden": false,
      "FullName": "Verla Parisian",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 905
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 384,
      "Comment": "qui",
      "Registered": "1996-08-06T15:29:29.8882033+02:00",
      "RegisteredAssociateId": 725,
      "Updated": "1999-01-07T15:29:29.8882033+01:00",
      "UpdatedAssociateId": 20,
      "LegalBaseId": 871,
      "LegalBaseKey": "deserunt",
      "LegalBaseName": "Schoen LLC",
      "ConsentPurposeId": 650,
      "ConsentPurposeKey": "perspiciatis",
      "ConsentPurposeName": "O'Keefe LLC",
      "ConsentSourceId": 168,
      "ConsentSourceKey": "veniam",
      "ConsentSourceName": "Lesch Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 459
        }
      }
    }
  ],
  "BounceEmails": [
    "kianna.labadie@herzogjakubowski.us",
    "nicolette_rogahn@hilpertsimonis.biz"
  ],
  "ActiveStatusMonitorId": 212,
  "UserDefinedFields": {
    "SuperOffice:1": "Melvina Goyette",
    "SuperOffice:2": "Prof. Kip Erna Leuschke III"
  },
  "ExtraFields": {
    "ExtraFields1": "maiores",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "velit",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 647
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```