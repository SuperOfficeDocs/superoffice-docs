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
GET /api/v1/Person/{id}?fk=False
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
GET /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 26 Sep 2006 10:30:32 G9T

{
  "PersonId": 914,
  "Firstname": "Nickolas",
  "MiddleName": "Crona Inc and Sons",
  "Lastname": "Macejkovic",
  "Mrmrs": "hic",
  "Title": "molestias",
  "UpdatedDate": "2006-09-26T10:30:32.119926+02:00",
  "CreatedDate": "2020-11-17T10:30:32.119926+01:00",
  "BirthDate": "2007-04-10T10:30:32.119926+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "enim",
      "StrippedValue": "aut",
      "Description": "Self-enabling systematic forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 21
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "aut",
      "Description": "Self-enabling systematic forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 21
        }
      }
    }
  ],
  "Description": "Balanced needs-based artificial intelligence",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "est",
      "StrippedValue": "nihil",
      "Description": "Open-source asynchronous methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 786
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "nihil",
      "Description": "Open-source asynchronous methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 786
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "cupiditate",
      "Description": "Reduced 24 hour superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 687
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "cupiditate",
      "Description": "Reduced 24 hour superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 687
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "doloremque",
      "StrippedValue": "quasi",
      "Description": "Enhanced fresh-thinking parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 566
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "quasi",
      "Description": "Enhanced fresh-thinking parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 566
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "nesciunt",
      "StrippedValue": "fuga",
      "Description": "Robust 24 hour structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 489
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "fuga",
      "Description": "Robust 24 hour structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 489
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "iusto",
      "StrippedValue": "eaque",
      "Description": "Virtual human-resource implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "eaque",
      "Description": "Virtual human-resource implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 155
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
      "Id": 947,
      "Name": "Reilly, Predovic and Altenwerth",
      "ToolTip": "Omnis ut labore aut quia laudantium ratione.",
      "Deleted": false,
      "Rank": 699,
      "Type": "illo",
      "ColorBlock": 100,
      "IconHint": "ad",
      "Selected": false,
      "LastChanged": "2004-08-26T10:30:32.1355523+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laborum",
      "StyleHint": "accusantium",
      "Hidden": false,
      "FullName": "Barrett Altenwerth",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 14
        }
      }
    }
  ],
  "PersonNumber": "1687460",
  "FullName": "Trudie Kirlin",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "dolorum",
      "StrippedValue": "natus",
      "Description": "Sharable impactful collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 364
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "natus",
      "Description": "Sharable impactful collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 364
        }
      }
    }
  ],
  "FormalName": "Schulist, Berge and Block",
  "Address": null,
  "Post3": "omnis",
  "Post2": "eius",
  "Post1": "dolor",
  "Kanalname": "nemo",
  "Kanafname": "nemo",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quibusdam",
  "ActiveInterests": 527,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 328,
  "DbiKey": "in",
  "DbiLastModified": "2016-03-23T10:30:32.1355523+01:00",
  "DbiLastSyncronized": "1996-10-19T10:30:32.1355523+02:00",
  "SentInfo": 400,
  "ShowContactTickets": 480,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quis",
      "StrippedValue": "sint",
      "Description": "Stand-alone contextually-based process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "sint",
      "Description": "Stand-alone contextually-based process improvement",
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
  "InternetPhones": [
    {
      "Value": "quibusdam",
      "StrippedValue": "sit",
      "Description": "Horizontal fresh-thinking interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "sit",
      "Description": "Horizontal fresh-thinking interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 920
        }
      }
    }
  ],
  "Source": 358,
  "ActiveErpLinks": 984,
  "ShipmentTypes": [
    {
      "Id": 351,
      "Name": "White LLC",
      "ToolTip": "Et quisquam aut sint adipisci dolor.",
      "Deleted": false,
      "Rank": 573,
      "Type": "incidunt",
      "ColorBlock": 914,
      "IconHint": "praesentium",
      "Selected": false,
      "LastChanged": "1998-10-02T10:30:32.1355523+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "at",
      "StyleHint": "beatae",
      "Hidden": false,
      "FullName": "Shea Brakus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 123,
      "Comment": "aliquid",
      "Registered": "2007-06-06T10:30:32.1355523+02:00",
      "RegisteredAssociateId": 846,
      "Updated": "1999-09-18T10:30:32.1355523+02:00",
      "UpdatedAssociateId": 551,
      "LegalBaseId": 282,
      "LegalBaseKey": "quibusdam",
      "LegalBaseName": "Conn-Becker",
      "ConsentPurposeId": 746,
      "ConsentPurposeKey": "temporibus",
      "ConsentPurposeName": "Kuvalis, Lakin and Rogahn",
      "ConsentSourceId": 761,
      "ConsentSourceKey": "omnis",
      "ConsentSourceName": "Kling, Senger and Kreiger",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 562
        }
      }
    }
  ],
  "BounceEmails": [
    "mallory@koepp.uk",
    "ricky_larkin@wisoky.co.uk"
  ],
  "ActiveStatusMonitorId": 120,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Makenna Lebsack II",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptates",
    "ExtraFields2": "dignissimos"
  },
  "CustomFields": {
    "CustomFields1": "necessitatibus",
    "CustomFields2": "ratione"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 638
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```