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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 21 Feb 2016 16:55:29 G2T

{
  "PersonId": 326,
  "Firstname": "Karlie",
  "MiddleName": "King LLC",
  "Lastname": "Spencer",
  "Mrmrs": "velit",
  "Title": "neque",
  "UpdatedDate": "2016-02-21T16:55:29.8460341+01:00",
  "CreatedDate": "2001-09-25T16:55:29.8460341+02:00",
  "BirthDate": "2009-04-04T16:55:29.8460341+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "eum",
      "StrippedValue": "corporis",
      "Description": "Down-sized tangible product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 741
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "corporis",
      "Description": "Down-sized tangible product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 741
        }
      }
    }
  ],
  "Description": "Enhanced value-added contingency",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "animi",
      "StrippedValue": "rerum",
      "Description": "Cross-group tertiary customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 533
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "rerum",
      "Description": "Cross-group tertiary customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 533
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "corporis",
      "StrippedValue": "hic",
      "Description": "Configurable bandwidth-monitored migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 85
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "hic",
      "Description": "Configurable bandwidth-monitored migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 85
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "eos",
      "StrippedValue": "expedita",
      "Description": "Versatile clear-thinking help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 589
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "expedita",
      "Description": "Versatile clear-thinking help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 589
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quis",
      "StrippedValue": "doloremque",
      "Description": "Inverse logistical conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 49
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "doloremque",
      "Description": "Inverse logistical conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 49
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "iure",
      "StrippedValue": "sed",
      "Description": "Synergized static strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 411
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "sed",
      "Description": "Synergized static strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 411
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
      "Id": 473,
      "Name": "Hand, Schoen and Hodkiewicz",
      "ToolTip": "Voluptatem et quo perferendis animi eos sit.",
      "Deleted": false,
      "Rank": 745,
      "Type": "eum",
      "ColorBlock": 547,
      "IconHint": "ad",
      "Selected": false,
      "LastChanged": "2021-05-25T16:55:29.848077+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fugiat",
      "StyleHint": "alias",
      "Hidden": true,
      "FullName": "Odell Hamill",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 154
        }
      }
    }
  ],
  "PersonNumber": "1739106",
  "FullName": "Madelynn Rolfson",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "architecto",
      "StrippedValue": "quis",
      "Description": "Switchable value-added moderator",
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
      "Value": "architecto",
      "StrippedValue": "quis",
      "Description": "Switchable value-added moderator",
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
  "FormalName": "Reilly Group",
  "Address": null,
  "Post3": "explicabo",
  "Post2": "dolores",
  "Post1": "iure",
  "Kanalname": "autem",
  "Kanafname": "odit",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "similique",
  "ActiveInterests": 558,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 306,
  "DbiKey": "quo",
  "DbiLastModified": "1998-08-21T16:55:29.8500872+02:00",
  "DbiLastSyncronized": "2003-04-22T16:55:29.8500872+02:00",
  "SentInfo": 530,
  "ShowContactTickets": 478,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "labore",
      "StrippedValue": "cumque",
      "Description": "Enhanced logistical capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 785
        }
      }
    },
    {
      "Value": "labore",
      "StrippedValue": "cumque",
      "Description": "Enhanced logistical capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 785
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "quia",
      "StrippedValue": "inventore",
      "Description": "Cross-group attitude-oriented data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 466
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "inventore",
      "Description": "Cross-group attitude-oriented data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 466
        }
      }
    }
  ],
  "Source": 489,
  "ActiveErpLinks": 265,
  "ShipmentTypes": [
    {
      "Id": 890,
      "Name": "Hilpert-Mueller",
      "ToolTip": "Sit dolores commodi explicabo quae.",
      "Deleted": true,
      "Rank": 221,
      "Type": "illo",
      "ColorBlock": 999,
      "IconHint": "eum",
      "Selected": true,
      "LastChanged": "1997-02-10T16:55:29.8500872+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ducimus",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Talon Harber",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 696
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 272,
      "Comment": "aut",
      "Registered": "2001-07-29T16:55:29.8511116+02:00",
      "RegisteredAssociateId": 793,
      "Updated": "2012-05-22T16:55:29.8511116+02:00",
      "UpdatedAssociateId": 263,
      "LegalBaseId": 590,
      "LegalBaseKey": "rerum",
      "LegalBaseName": "Stiedemann, Gusikowski and Olson",
      "ConsentPurposeId": 801,
      "ConsentPurposeKey": "commodi",
      "ConsentPurposeName": "Kuphal Group",
      "ConsentSourceId": 941,
      "ConsentSourceKey": "consequatur",
      "ConsentSourceName": "Considine, Hackett and Runolfsdottir",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 259
        }
      }
    }
  ],
  "BounceEmails": [
    "ferne.cummings@goyette.ca",
    "isidro@champlin.name"
  ],
  "ActiveStatusMonitorId": 224,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Eileen Renner"
  },
  "ExtraFields": {
    "ExtraFields1": "tempore",
    "ExtraFields2": "architecto"
  },
  "CustomFields": {
    "CustomFields1": "amet",
    "CustomFields2": "cum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 33
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```