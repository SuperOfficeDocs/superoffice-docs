---
title: POST Agents/Person/GetMyPerson
uid: v1PersonAgent_GetMyPerson
generated: true
---

# POST Agents/Person/GetMyPerson

```http
POST /api/v1/Agents/Person/GetMyPerson
```

Gets the person info belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetMyPerson?$select=name,department,category/id
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
POST /api/v1/Agents/Person/GetMyPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 976,
  "Firstname": "Cathryn",
  "MiddleName": "Walsh-Lynch",
  "Lastname": "Walker",
  "Mrmrs": "modi",
  "Title": "iusto",
  "UpdatedDate": "2018-01-16T11:44:34.0252656+01:00",
  "CreatedDate": "2016-09-03T11:44:34.0252656+02:00",
  "BirthDate": "2001-02-10T11:44:34.0252656+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dignissimos",
      "StrippedValue": "rerum",
      "Description": "Distributed systemic toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 159
        }
      }
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "rerum",
      "Description": "Distributed systemic toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 159
        }
      }
    }
  ],
  "Description": "Programmable stable alliance",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "dicta",
      "StrippedValue": "optio",
      "Description": "Profound solution-oriented middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "optio",
      "Description": "Profound solution-oriented middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "sit",
      "Description": "Distributed fault-tolerant challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 162
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "sit",
      "Description": "Distributed fault-tolerant challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 162
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "magni",
      "StrippedValue": "repellat",
      "Description": "Customizable high-level conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 117
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "repellat",
      "Description": "Customizable high-level conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 117
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "commodi",
      "StrippedValue": "et",
      "Description": "Centralized zero administration encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 347
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "et",
      "Description": "Centralized zero administration encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 347
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "nobis",
      "Description": "Monitored bottom-line utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 567
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "nobis",
      "Description": "Monitored bottom-line utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 567
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
      "Id": 480,
      "Name": "Hand, Dibbert and Brekke",
      "ToolTip": "Perferendis aut tenetur ut aut voluptatem minus suscipit.",
      "Deleted": true,
      "Rank": 953,
      "Type": "repellendus",
      "ColorBlock": 409,
      "IconHint": "eveniet",
      "Selected": true,
      "LastChanged": "2013-07-05T11:44:34.0252656+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "deserunt",
      "StyleHint": "enim",
      "Hidden": false,
      "FullName": "Lupe Muller",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 480
        }
      }
    }
  ],
  "PersonNumber": "697695",
  "FullName": "Mr. Austen Noemie Terry",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "repellat",
      "Description": "Centralized full-range ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 791
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "repellat",
      "Description": "Centralized full-range ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 791
        }
      }
    }
  ],
  "FormalName": "Abbott, Kovacek and Hammes",
  "Address": null,
  "Post3": "ut",
  "Post2": "consequatur",
  "Post1": "fugit",
  "Kanalname": "quae",
  "Kanafname": "et",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptatem",
  "ActiveInterests": 329,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 474,
  "DbiKey": "qui",
  "DbiLastModified": "1999-07-07T11:44:34.0252656+02:00",
  "DbiLastSyncronized": "2017-05-24T11:44:34.0252656+02:00",
  "SentInfo": 202,
  "ShowContactTickets": 625,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "optio",
      "StrippedValue": "quisquam",
      "Description": "Customizable 6th generation monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 968
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "quisquam",
      "Description": "Customizable 6th generation monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 968
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "mollitia",
      "StrippedValue": "eos",
      "Description": "Public-key 24/7 strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 653
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "eos",
      "Description": "Public-key 24/7 strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 653
        }
      }
    }
  ],
  "Source": 385,
  "ActiveErpLinks": 653,
  "ShipmentTypes": [
    {
      "Id": 857,
      "Name": "Tremblay-Rau",
      "ToolTip": "Nostrum ut nesciunt tempora omnis laboriosam aut facere.",
      "Deleted": true,
      "Rank": 600,
      "Type": "a",
      "ColorBlock": 771,
      "IconHint": "nihil",
      "Selected": true,
      "LastChanged": "2014-07-29T11:44:34.0252656+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officiis",
      "StyleHint": "voluptatibus",
      "Hidden": true,
      "FullName": "Selina Ward",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 612
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 793,
      "Comment": "error",
      "Registered": "2008-09-26T11:44:34.0252656+02:00",
      "RegisteredAssociateId": 478,
      "Updated": "2021-06-11T11:44:34.0252656+02:00",
      "UpdatedAssociateId": 314,
      "LegalBaseId": 55,
      "LegalBaseKey": "non",
      "LegalBaseName": "Bartell Inc and Sons",
      "ConsentPurposeId": 829,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "Bruen-McDermott",
      "ConsentSourceId": 489,
      "ConsentSourceKey": "fugiat",
      "ConsentSourceName": "Konopelski Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 434
        }
      }
    }
  ],
  "BounceEmails": [
    "elissa@thompson.biz",
    "ezequiel.jacobson@tromp.com"
  ],
  "ActiveStatusMonitorId": 607,
  "UserDefinedFields": {
    "SuperOffice:1": "1580843791",
    "SuperOffice:2": "Prof. Jeremie Bartholome Wisoky IV"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "vero"
  },
  "CustomFields": {
    "CustomFields1": "similique",
    "CustomFields2": "asperiores"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 167
    }
  }
}
```