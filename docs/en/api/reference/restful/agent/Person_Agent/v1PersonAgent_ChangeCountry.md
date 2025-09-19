---
title: POST Agents/Person/ChangeCountry
uid: v1PersonAgent_ChangeCountry
generated: true
content_type: reference
---

# POST Agents/Person/ChangeCountry

```http
POST /api/v1/Agents/Person/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format for this entity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/ChangeCountry?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

PersonEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonEntity | PersonEntity |  |
| ToCountryId | Integer |  |

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
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | int32 | Refinement of categories of lead type. Empty if the category is not a lead type. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonEntity": null,
  "ToCountryId": 329
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 886,
  "Firstname": "Florine",
  "MiddleName": "Crist, Lakin and Rath",
  "Lastname": "Johnston",
  "Mrmrs": "rerum",
  "Title": "id",
  "UpdatedDate": "2022-10-01T03:41:53.8244717+02:00",
  "CreatedDate": "2020-08-21T03:41:53.8244717+02:00",
  "BirthDate": "2025-01-28T03:41:53.8244717+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quod",
      "StrippedValue": "praesentium",
      "Description": "Sharable background instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 127
        }
      }
    },
    {
      "Value": "quod",
      "StrippedValue": "praesentium",
      "Description": "Sharable background instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 127
        }
      }
    }
  ],
  "Description": "Organized 4th generation circuit",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "dolor",
      "StrippedValue": "explicabo",
      "Description": "Multi-lateral contextually-based frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 286
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "explicabo",
      "Description": "Multi-lateral contextually-based frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 286
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "dolorum",
      "Description": "Adaptive high-level toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 365
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "dolorum",
      "Description": "Adaptive high-level toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 365
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "ut",
      "StrippedValue": "dolores",
      "Description": "Extended zero tolerance migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 998
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "dolores",
      "Description": "Extended zero tolerance migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 998
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "in",
      "Description": "Configurable value-added budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 812
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "in",
      "Description": "Configurable value-added budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 812
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "perferendis",
      "StrippedValue": "aperiam",
      "Description": "Virtual encompassing moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 360
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "aperiam",
      "Description": "Virtual encompassing moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 360
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
      "Id": 207,
      "Name": "Ferry, Bauch and Bergnaum",
      "ToolTip": "Beatae in.",
      "Deleted": false,
      "Rank": 459,
      "Type": "nemo",
      "ColorBlock": 394,
      "IconHint": "quidem",
      "Selected": true,
      "LastChanged": "2023-02-04T03:41:53.8244717+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "minima",
      "Hidden": false,
      "FullName": "Dr. Hollie Tyrel Metz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 495
        }
      }
    }
  ],
  "PersonNumber": "1198138",
  "FullName": "Savannah Brooklyn Morissette II",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "temporibus",
      "StrippedValue": "quidem",
      "Description": "Cloned mission-critical contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 856
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "quidem",
      "Description": "Cloned mission-critical contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 856
        }
      }
    }
  ],
  "FormalName": "Moen-Schuster",
  "Address": null,
  "Post3": "magni",
  "Post2": "velit",
  "Post1": "sed",
  "Kanalname": "expedita",
  "Kanafname": "dolore",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "tenetur",
  "ActiveInterests": 470,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 560,
  "DbiKey": "aperiam",
  "DbiLastModified": "2024-12-23T03:41:53.8244717+01:00",
  "DbiLastSyncronized": "2003-10-30T03:41:53.8244717+01:00",
  "SentInfo": 496,
  "ShowContactTickets": 354,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "alias",
      "StrippedValue": "sequi",
      "Description": "Profit-focused real-time frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 185
        }
      }
    },
    {
      "Value": "alias",
      "StrippedValue": "sequi",
      "Description": "Profit-focused real-time frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 185
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "in",
      "StrippedValue": "recusandae",
      "Description": "Total explicit methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 160
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "recusandae",
      "Description": "Total explicit methodology",
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
  "Source": 285,
  "ActiveErpLinks": 698,
  "ShipmentTypes": [
    {
      "Id": 839,
      "Name": "Trantow Group",
      "ToolTip": "Doloribus illo unde in ullam quis dolorem ut.",
      "Deleted": true,
      "Rank": 11,
      "Type": "omnis",
      "ColorBlock": 358,
      "IconHint": "exercitationem",
      "Selected": false,
      "LastChanged": "2003-05-06T03:41:53.8244717+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "provident",
      "StyleHint": "sapiente",
      "Hidden": false,
      "FullName": "Scotty Langworth",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 387
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 61,
      "Comment": "ut",
      "Registered": "2018-03-01T03:41:53.8244717+01:00",
      "RegisteredAssociateId": 742,
      "Updated": "2005-01-08T03:41:53.8244717+01:00",
      "UpdatedAssociateId": 768,
      "LegalBaseId": 116,
      "LegalBaseKey": "alias",
      "LegalBaseName": "Kerluke, Tromp and Bechtelar",
      "ConsentPurposeId": 872,
      "ConsentPurposeKey": "sed",
      "ConsentPurposeName": "Stark-Hermiston",
      "ConsentSourceId": 777,
      "ConsentSourceKey": "aperiam",
      "ConsentSourceName": "Hauck Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 737
        }
      }
    }
  ],
  "BounceEmails": [
    "francisca.feeney@bartell.biz",
    "randall@daniel.com"
  ],
  "ActiveStatusMonitorId": 52,
  "CreatedByFormId": 829,
  "UtmParameters": null,
  "LeadstatusId": 701,
  "UserDefinedFields": {
    "SuperOffice:1": "887659572",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "facilis",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 410
    }
  }
}
```