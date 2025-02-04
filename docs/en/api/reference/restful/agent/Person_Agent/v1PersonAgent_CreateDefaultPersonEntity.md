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
| CreatedByFormId | int32 | The form id of the form that created the person |
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
  "PersonId": 930,
  "Firstname": "Tanya",
  "MiddleName": "Erdman, Goodwin and Tromp",
  "Lastname": "Marquardt",
  "Mrmrs": "ullam",
  "Title": "alias",
  "UpdatedDate": "2009-08-19T13:13:23.3989026+02:00",
  "CreatedDate": "2011-08-10T13:13:23.3989026+02:00",
  "BirthDate": "1999-09-27T13:13:23.3989026+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "minus",
      "StrippedValue": "eos",
      "Description": "Assimilated 3rd generation orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 355
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "eos",
      "Description": "Assimilated 3rd generation orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 355
        }
      }
    }
  ],
  "Description": "Public-key upward-trending leverage",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "debitis",
      "Description": "Multi-lateral explicit Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 667
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "debitis",
      "Description": "Multi-lateral explicit Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 667
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptate",
      "StrippedValue": "repellat",
      "Description": "Customizable incremental installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 585
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "repellat",
      "Description": "Customizable incremental installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 585
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "praesentium",
      "StrippedValue": "officiis",
      "Description": "Progressive national data-warehouse",
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
      "Value": "praesentium",
      "StrippedValue": "officiis",
      "Description": "Progressive national data-warehouse",
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
  "OfficePhones": [
    {
      "Value": "est",
      "StrippedValue": "facilis",
      "Description": "Streamlined fresh-thinking projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 774
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "facilis",
      "Description": "Streamlined fresh-thinking projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 774
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "vitae",
      "Description": "Up-sized dedicated implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 522
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "vitae",
      "Description": "Up-sized dedicated implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 522
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
      "Id": 61,
      "Name": "Upton Group",
      "ToolTip": "Omnis non quisquam.",
      "Deleted": false,
      "Rank": 233,
      "Type": "suscipit",
      "ColorBlock": 292,
      "IconHint": "in",
      "Selected": false,
      "LastChanged": "2009-02-22T13:13:23.3989026+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "asperiores",
      "StyleHint": "quos",
      "Hidden": true,
      "FullName": "Payton Schultz",
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
  "PersonNumber": "1541967",
  "FullName": "Johnny Champlin",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "fuga",
      "StrippedValue": "quos",
      "Description": "Upgradable 6th generation solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 483
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "quos",
      "Description": "Upgradable 6th generation solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 483
        }
      }
    }
  ],
  "FormalName": "Bailey Inc and Sons",
  "Address": null,
  "Post3": "accusamus",
  "Post2": "beatae",
  "Post1": "illo",
  "Kanalname": "et",
  "Kanafname": "exercitationem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "dolorem",
  "ActiveInterests": 695,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 465,
  "DbiKey": "occaecati",
  "DbiLastModified": "2021-03-24T13:13:23.3989026+01:00",
  "DbiLastSyncronized": "2000-09-15T13:13:23.3989026+02:00",
  "SentInfo": 65,
  "ShowContactTickets": 558,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "rem",
      "StrippedValue": "numquam",
      "Description": "Visionary multi-tasking workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 434
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "numquam",
      "Description": "Visionary multi-tasking workforce",
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
  "InternetPhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "aspernatur",
      "Description": "Focused value-added support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 887
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "aspernatur",
      "Description": "Focused value-added support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 887
        }
      }
    }
  ],
  "Source": 704,
  "ActiveErpLinks": 917,
  "ShipmentTypes": [
    {
      "Id": 274,
      "Name": "Pollich-Anderson",
      "ToolTip": "Alias eos odit excepturi sunt.",
      "Deleted": false,
      "Rank": 104,
      "Type": "enim",
      "ColorBlock": 900,
      "IconHint": "repellat",
      "Selected": false,
      "LastChanged": "2012-04-26T13:13:23.3989026+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sequi",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Mrs. Jewel Welch III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 825
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 278,
      "Comment": "corporis",
      "Registered": "2000-12-28T13:13:23.3989026+01:00",
      "RegisteredAssociateId": 757,
      "Updated": "2008-10-25T13:13:23.3989026+02:00",
      "UpdatedAssociateId": 876,
      "LegalBaseId": 44,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Swaniawski, Walter and Smitham",
      "ConsentPurposeId": 419,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "Von Group",
      "ConsentSourceId": 34,
      "ConsentSourceKey": "sint",
      "ConsentSourceName": "Howe, Hoppe and Gleichner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 661
        }
      }
    }
  ],
  "BounceEmails": [
    "ubaldo@morarflatley.com",
    "leanne.mayert@jacobson.biz"
  ],
  "ActiveStatusMonitorId": 516,
  "CreatedByFormId": 279,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Luther Sylvia Boyle",
    "SuperOffice:2": "Florine Nitzsche"
  },
  "ExtraFields": {
    "ExtraFields1": "aperiam",
    "ExtraFields2": "quaerat"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "totam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 59
    }
  }
}
```