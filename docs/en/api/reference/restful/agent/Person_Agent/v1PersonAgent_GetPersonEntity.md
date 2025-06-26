---
title: POST Agents/Person/GetPersonEntity
uid: v1PersonAgent_GetPersonEntity
generated: true
---

# POST Agents/Person/GetPersonEntity

```http
POST /api/v1/Agents/Person/GetPersonEntity
```

Gets a PersonEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| personEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=628
POST /api/v1/Agents/Person/GetPersonEntity?$select=name,department,category/id
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
| CreatedByFormId | int32 | The form id of the form that created the person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/GetPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 607,
  "Firstname": "Jarrett",
  "MiddleName": "Kohler-Mayert",
  "Lastname": "Homenick",
  "Mrmrs": "iste",
  "Title": "inventore",
  "UpdatedDate": "2001-07-06T03:45:23.6704491+02:00",
  "CreatedDate": "2018-05-08T03:45:23.6704491+02:00",
  "BirthDate": "2012-06-17T03:45:23.6704491+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "atque",
      "StrippedValue": "saepe",
      "Description": "Assimilated didactic moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 664
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "saepe",
      "Description": "Assimilated didactic moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 664
        }
      }
    }
  ],
  "Description": "Reverse-engineered logistical analyzer",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ut",
      "StrippedValue": "provident",
      "Description": "Progressive contextually-based contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 763
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "provident",
      "Description": "Progressive contextually-based contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 763
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "sequi",
      "Description": "Universal next generation interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 351
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "sequi",
      "Description": "Universal next generation interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 351
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sapiente",
      "StrippedValue": "nihil",
      "Description": "Progressive assymetric encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 193
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "nihil",
      "Description": "Progressive assymetric encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 193
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "voluptas",
      "Description": "Managed bifurcated artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 918
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "voluptas",
      "Description": "Managed bifurcated artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 918
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "placeat",
      "Description": "Open-architected background Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 941
        }
      }
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "placeat",
      "Description": "Open-architected background Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 941
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
      "Id": 873,
      "Name": "Jacobi Inc and Sons",
      "ToolTip": "Qui nemo.",
      "Deleted": true,
      "Rank": 760,
      "Type": "et",
      "ColorBlock": 827,
      "IconHint": "quas",
      "Selected": false,
      "LastChanged": "2019-06-16T03:45:23.6704491+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Josiane Aufderhar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 158
        }
      }
    }
  ],
  "PersonNumber": "1238127",
  "FullName": "Golden Calista Hauck I",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "praesentium",
      "StrippedValue": "nulla",
      "Description": "Inverse modular superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "nulla",
      "Description": "Inverse modular superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    }
  ],
  "FormalName": "Leuschke, Nikolaus and Murray",
  "Address": null,
  "Post3": "sapiente",
  "Post2": "quo",
  "Post1": "quam",
  "Kanalname": "dolorum",
  "Kanafname": "sed",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "deleniti",
  "ActiveInterests": 469,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 922,
  "DbiKey": "aspernatur",
  "DbiLastModified": "2002-09-13T03:45:23.6704491+02:00",
  "DbiLastSyncronized": "2023-07-12T03:45:23.6704491+02:00",
  "SentInfo": 200,
  "ShowContactTickets": 805,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "similique",
      "StrippedValue": "dignissimos",
      "Description": "Persistent client-server process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 970
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "dignissimos",
      "Description": "Persistent client-server process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 970
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "similique",
      "StrippedValue": "qui",
      "Description": "Pre-emptive radical moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 778
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "qui",
      "Description": "Pre-emptive radical moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 778
        }
      }
    }
  ],
  "Source": 687,
  "ActiveErpLinks": 87,
  "ShipmentTypes": [
    {
      "Id": 371,
      "Name": "Terry-Stoltenberg",
      "ToolTip": "Quae praesentium illo.",
      "Deleted": false,
      "Rank": 267,
      "Type": "quasi",
      "ColorBlock": 66,
      "IconHint": "ratione",
      "Selected": false,
      "LastChanged": "2010-01-23T03:45:23.6704491+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "est",
      "Hidden": true,
      "FullName": "Mr. Sebastian Bednar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 713
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 221,
      "Comment": "autem",
      "Registered": "2005-10-09T03:45:23.6704491+02:00",
      "RegisteredAssociateId": 331,
      "Updated": "1999-05-22T03:45:23.6704491+02:00",
      "UpdatedAssociateId": 476,
      "LegalBaseId": 787,
      "LegalBaseKey": "amet",
      "LegalBaseName": "Hintz, Ullrich and Tromp",
      "ConsentPurposeId": 477,
      "ConsentPurposeKey": "molestiae",
      "ConsentPurposeName": "Hahn, Kessler and Oberbrunner",
      "ConsentSourceId": 853,
      "ConsentSourceKey": "laborum",
      "ConsentSourceName": "West-Thompson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 682
        }
      }
    }
  ],
  "BounceEmails": [
    "lottie@ornmuller.ca",
    "nicholas_hahn@larson.us"
  ],
  "ActiveStatusMonitorId": 292,
  "CreatedByFormId": 935,
  "UserDefinedFields": {
    "SuperOffice:1": "1590383665",
    "SuperOffice:2": "Krystel Kassulke"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "officiis",
    "CustomFields2": "nemo"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 23
    }
  }
}
```