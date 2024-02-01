---
title: GET Person/{id}
uid: v1PersonEntity_GetPersonEntity
generated: true
---

# GET Person/{id}

```http
GET /api/v1/Person/{id}
```

Gets a PersonEntity object.


Calls the Person agent service GetPersonEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the PersonEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Person/{id}?$select=name,department,category/id
GET /api/v1/Person/{id}?fk=True
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

PersonEntity found.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity found. |
| 304 | PersonEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

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
GET /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 04 Jun 2021 23:04:04 G6T

{
  "PersonId": 181,
  "Firstname": "Berta",
  "MiddleName": "Mante-Greenholt",
  "Lastname": "Purdy",
  "Mrmrs": "laborum",
  "Title": "nisi",
  "UpdatedDate": "2021-06-04T23:04:04.2945166+02:00",
  "CreatedDate": "2015-02-19T23:04:04.2945166+01:00",
  "BirthDate": "1999-11-02T23:04:04.2945166+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sunt",
      "StrippedValue": "eos",
      "Description": "Optional 5th generation success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 482
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "eos",
      "Description": "Optional 5th generation success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 482
        }
      }
    }
  ],
  "Description": "Advanced responsive service-desk",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "excepturi",
      "StrippedValue": "eius",
      "Description": "Phased regional local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 731
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "eius",
      "Description": "Phased regional local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 731
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "facilis",
      "Description": "Networked composite budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 183
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "facilis",
      "Description": "Networked composite budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 183
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quae",
      "StrippedValue": "omnis",
      "Description": "Business-focused real-time orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 355
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "omnis",
      "Description": "Business-focused real-time orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 355
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "assumenda",
      "StrippedValue": "pariatur",
      "Description": "Synergized motivating system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 381
        }
      }
    },
    {
      "Value": "assumenda",
      "StrippedValue": "pariatur",
      "Description": "Synergized motivating system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 381
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ex",
      "StrippedValue": "sit",
      "Description": "Automated asynchronous core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 332
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "sit",
      "Description": "Automated asynchronous core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 332
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
      "Id": 606,
      "Name": "Durgan, Cummings and Farrell",
      "ToolTip": "Nostrum dolore debitis quia voluptatem recusandae porro.",
      "Deleted": true,
      "Rank": 654,
      "Type": "quas",
      "ColorBlock": 779,
      "IconHint": "incidunt",
      "Selected": false,
      "LastChanged": "2017-05-02T23:04:04.2965164+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Theo Swaniawski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 147
        }
      }
    }
  ],
  "PersonNumber": "1550610",
  "FullName": "Forest Wisozk",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "dignissimos",
      "StrippedValue": "est",
      "Description": "Persevering web-enabled neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "est",
      "Description": "Persevering web-enabled neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    }
  ],
  "FormalName": "Lubowitz LLC",
  "Address": null,
  "Post3": "explicabo",
  "Post2": "consequatur",
  "Post1": "ullam",
  "Kanalname": "vitae",
  "Kanafname": "natus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "est",
  "ActiveInterests": 733,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 704,
  "DbiKey": "laboriosam",
  "DbiLastModified": "1996-09-29T23:04:04.2995177+02:00",
  "DbiLastSyncronized": "2021-01-15T23:04:04.2995177+01:00",
  "SentInfo": 481,
  "ShowContactTickets": 17,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "alias",
      "StrippedValue": "et",
      "Description": "Sharable 24 hour definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 419
        }
      }
    },
    {
      "Value": "alias",
      "StrippedValue": "et",
      "Description": "Sharable 24 hour definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 419
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "aliquam",
      "StrippedValue": "earum",
      "Description": "Vision-oriented needs-based concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 846
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "earum",
      "Description": "Vision-oriented needs-based concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 846
        }
      }
    }
  ],
  "Source": 368,
  "ActiveErpLinks": 815,
  "ShipmentTypes": [
    {
      "Id": 806,
      "Name": "Stark Group",
      "ToolTip": "Facilis et sunt.",
      "Deleted": false,
      "Rank": 214,
      "Type": "vitae",
      "ColorBlock": 103,
      "IconHint": "reprehenderit",
      "Selected": false,
      "LastChanged": "2015-08-18T23:04:04.3000182+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "inventore",
      "StyleHint": "ipsum",
      "Hidden": true,
      "FullName": "Regan Beier",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 477
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 550,
      "Comment": "perspiciatis",
      "Registered": "2015-09-18T23:04:04.3000182+02:00",
      "RegisteredAssociateId": 193,
      "Updated": "1999-12-28T23:04:04.3000182+01:00",
      "UpdatedAssociateId": 169,
      "LegalBaseId": 1001,
      "LegalBaseKey": "repellendus",
      "LegalBaseName": "Hilll, Stark and Spencer",
      "ConsentPurposeId": 288,
      "ConsentPurposeKey": "nihil",
      "ConsentPurposeName": "Ritchie, Dach and Spencer",
      "ConsentSourceId": 179,
      "ConsentSourceKey": "sunt",
      "ConsentSourceName": "Klein LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 234
        }
      }
    }
  ],
  "BounceEmails": [
    "kristin@runte.biz",
    "jody.koelpin@dooleyoconnell.info"
  ],
  "ActiveStatusMonitorId": 968,
  "UserDefinedFields": {
    "SuperOffice:1": "Khalid Macejkovic",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "recusandae",
    "CustomFields2": "at"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 951
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```