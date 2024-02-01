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

## Sample request

```http!
POST /api/v1/Agents/Person/GetMyPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 995,
  "Firstname": "Filomena",
  "MiddleName": "Hermiston, O'Keefe and McKenzie",
  "Lastname": "Beer",
  "Mrmrs": "ipsam",
  "Title": "est",
  "UpdatedDate": "2013-02-04T23:03:56.4386226+01:00",
  "CreatedDate": "2022-08-02T23:03:56.4386226+02:00",
  "BirthDate": "2021-12-06T23:03:56.4386226+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ipsa",
      "StrippedValue": "laboriosam",
      "Description": "Operative well-modulated algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 612
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "laboriosam",
      "Description": "Operative well-modulated algorithm",
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
  "Description": "Centralized national benchmark",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Right-sized scalable orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Right-sized scalable orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "nihil",
      "Description": "User-friendly context-sensitive info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 519
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "nihil",
      "Description": "User-friendly context-sensitive info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 519
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "deleniti",
      "StrippedValue": "et",
      "Description": "Synergistic dynamic budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    },
    {
      "Value": "deleniti",
      "StrippedValue": "et",
      "Description": "Synergistic dynamic budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "iste",
      "StrippedValue": "minus",
      "Description": "Multi-lateral background utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 596
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "minus",
      "Description": "Multi-lateral background utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 596
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "harum",
      "StrippedValue": "voluptatem",
      "Description": "Team-oriented multimedia local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 899
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "voluptatem",
      "Description": "Team-oriented multimedia local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 899
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
      "Id": 162,
      "Name": "Pfeffer-Volkman",
      "ToolTip": "Eius rerum ipsam voluptas odit.",
      "Deleted": false,
      "Rank": 445,
      "Type": "commodi",
      "ColorBlock": 326,
      "IconHint": "odio",
      "Selected": false,
      "LastChanged": "2006-04-18T23:03:56.441125+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "error",
      "StyleHint": "temporibus",
      "Hidden": false,
      "FullName": "Prof. Leanna Yost I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 919
        }
      }
    }
  ],
  "PersonNumber": "1180396",
  "FullName": "Leonora Bernier",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "voluptatem",
      "Description": "Reduced regional firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 252
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "voluptatem",
      "Description": "Reduced regional firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 252
        }
      }
    }
  ],
  "FormalName": "Zieme-Schmeler",
  "Address": null,
  "Post3": "consequuntur",
  "Post2": "voluptatem",
  "Post1": "quae",
  "Kanalname": "sunt",
  "Kanafname": "sit",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "illum",
  "ActiveInterests": 283,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 75,
  "DbiKey": "sit",
  "DbiLastModified": "2002-12-12T23:03:56.4441223+01:00",
  "DbiLastSyncronized": "2019-10-14T23:03:56.4441223+02:00",
  "SentInfo": 181,
  "ShowContactTickets": 597,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "nobis",
      "Description": "Re-contextualized non-volatile benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 2
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "nobis",
      "Description": "Re-contextualized non-volatile benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 2
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "qui",
      "StrippedValue": "aspernatur",
      "Description": "Monitored tertiary utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 296
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "aspernatur",
      "Description": "Monitored tertiary utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 296
        }
      }
    }
  ],
  "Source": 746,
  "ActiveErpLinks": 134,
  "ShipmentTypes": [
    {
      "Id": 504,
      "Name": "Collins Group",
      "ToolTip": "Qui eligendi.",
      "Deleted": false,
      "Rank": 112,
      "Type": "quo",
      "ColorBlock": 876,
      "IconHint": "atque",
      "Selected": false,
      "LastChanged": "2013-01-26T23:03:56.4446227+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vitae",
      "StyleHint": "doloribus",
      "Hidden": true,
      "FullName": "Lilly Homenick",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 769
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 852,
      "Comment": "tenetur",
      "Registered": "1998-07-24T23:03:56.4446227+02:00",
      "RegisteredAssociateId": 972,
      "Updated": "2005-03-11T23:03:56.4446227+01:00",
      "UpdatedAssociateId": 268,
      "LegalBaseId": 352,
      "LegalBaseKey": "omnis",
      "LegalBaseName": "Schroeder LLC",
      "ConsentPurposeId": 129,
      "ConsentPurposeKey": "exercitationem",
      "ConsentPurposeName": "Connelly-Hoppe",
      "ConsentSourceId": 147,
      "ConsentSourceKey": "atque",
      "ConsentSourceName": "Hammes LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 309
        }
      }
    }
  ],
  "BounceEmails": [
    "carlee@hilpert.uk",
    "eliane.hettinger@kris.ca"
  ],
  "ActiveStatusMonitorId": 397,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "sequi"
  },
  "CustomFields": {
    "CustomFields1": "fugit",
    "CustomFields2": "fugit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 949
    }
  }
}
```