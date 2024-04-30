---
title: POST Agents/Person/CreateDefaultPersonEntity
uid: v1PersonAgent_CreateDefaultPersonEntity
generated: true
---

# POST Agents/Person/CreateDefaultPersonEntity

```http
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
```

Set default values into a new PersonEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

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

## Sample request

```http!
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 397,
  "Firstname": "Timothy",
  "MiddleName": "Stroman, Hackett and O'Conner",
  "Lastname": "Tromp",
  "Mrmrs": "dolores",
  "Title": "molestiae",
  "UpdatedDate": "2011-08-09T11:44:33.9627604+02:00",
  "CreatedDate": "2007-10-11T11:44:33.9627604+02:00",
  "BirthDate": "2023-01-30T11:44:33.9627604+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "vel",
      "StrippedValue": "odit",
      "Description": "Customizable fault-tolerant process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 906
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "odit",
      "Description": "Customizable fault-tolerant process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 906
        }
      }
    }
  ],
  "Description": "Triple-buffered impactful matrices",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "velit",
      "StrippedValue": "voluptatibus",
      "Description": "Seamless demand-driven core",
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
      "Value": "velit",
      "StrippedValue": "voluptatibus",
      "Description": "Seamless demand-driven core",
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
  "Faxes": [
    {
      "Value": "molestias",
      "StrippedValue": "similique",
      "Description": "Triple-buffered bi-directional artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 290
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "similique",
      "Description": "Triple-buffered bi-directional artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 290
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quos",
      "StrippedValue": "nulla",
      "Description": "Mandatory heuristic ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 872
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "nulla",
      "Description": "Mandatory heuristic ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 872
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "qui",
      "StrippedValue": "pariatur",
      "Description": "Distributed fault-tolerant archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 55
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "pariatur",
      "Description": "Distributed fault-tolerant archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 55
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "vel",
      "StrippedValue": "possimus",
      "Description": "Sharable actuating conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 259
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "possimus",
      "Description": "Sharable actuating conglomeration",
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
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 335,
      "Name": "Schroeder Group",
      "ToolTip": "Velit eos voluptates odio exercitationem dolorem autem.",
      "Deleted": false,
      "Rank": 153,
      "Type": "numquam",
      "ColorBlock": 844,
      "IconHint": "non",
      "Selected": false,
      "LastChanged": "2015-02-14T11:44:33.9783821+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "architecto",
      "StyleHint": "tempora",
      "Hidden": false,
      "FullName": "Bethany Smith",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 358
        }
      }
    }
  ],
  "PersonNumber": "859490",
  "FullName": "Eric Abshire",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "aliquam",
      "StrippedValue": "non",
      "Description": "Phased responsive matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 21
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "non",
      "Description": "Phased responsive matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 21
        }
      }
    }
  ],
  "FormalName": "Hammes LLC",
  "Address": null,
  "Post3": "nesciunt",
  "Post2": "vitae",
  "Post1": "ipsa",
  "Kanalname": "sunt",
  "Kanafname": "laboriosam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "eos",
  "ActiveInterests": 703,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 675,
  "DbiKey": "ad",
  "DbiLastModified": "2016-10-18T11:44:33.9783821+02:00",
  "DbiLastSyncronized": "2007-03-29T11:44:33.9783821+02:00",
  "SentInfo": 122,
  "ShowContactTickets": 472,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "eveniet",
      "StrippedValue": "praesentium",
      "Description": "Innovative executive groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 91
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "praesentium",
      "Description": "Innovative executive groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 91
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Horizontal bi-directional attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 31
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Horizontal bi-directional attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 31
        }
      }
    }
  ],
  "Source": 245,
  "ActiveErpLinks": 118,
  "ShipmentTypes": [
    {
      "Id": 789,
      "Name": "Gutkowski Group",
      "ToolTip": "Et commodi sit neque voluptatem id corporis.",
      "Deleted": false,
      "Rank": 774,
      "Type": "suscipit",
      "ColorBlock": 119,
      "IconHint": "esse",
      "Selected": false,
      "LastChanged": "2009-05-14T11:44:33.9783821+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "amet",
      "StyleHint": "repellat",
      "Hidden": true,
      "FullName": "Mackenzie DuBuque",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 160
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 317,
      "Comment": "sed",
      "Registered": "2018-07-08T11:44:33.9783821+02:00",
      "RegisteredAssociateId": 299,
      "Updated": "2016-02-18T11:44:33.9783821+01:00",
      "UpdatedAssociateId": 336,
      "LegalBaseId": 991,
      "LegalBaseKey": "dolor",
      "LegalBaseName": "Stark, Kozey and Kunde",
      "ConsentPurposeId": 303,
      "ConsentPurposeKey": "molestiae",
      "ConsentPurposeName": "Schmitt LLC",
      "ConsentSourceId": 64,
      "ConsentSourceKey": "harum",
      "ConsentSourceName": "Hudson Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 723
        }
      }
    }
  ],
  "BounceEmails": [
    "kiarra@gerlach.name",
    "gertrude@lueilwitz.com"
  ],
  "ActiveStatusMonitorId": 543,
  "UserDefinedFields": {
    "SuperOffice:1": "Vinnie Windler",
    "SuperOffice:2": "Karley Ferry"
  },
  "ExtraFields": {
    "ExtraFields1": "iure",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "id"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 697
    }
  }
}
```