---
title: POST Agents/Person/GetPersonEntity
uid: v1PersonAgent_GetPersonEntity
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
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=913
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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| CreatedBy |  | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position |  | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy |  | The person that last updated the person object |
| Contact |  | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country |  | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address |  | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate |  | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category |  | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business |  | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate |  | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo |  | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Person/GetPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 964,
  "Firstname": "Rowan",
  "MiddleName": "Wiegand LLC",
  "Lastname": "McCullough",
  "Mrmrs": "enim",
  "Title": "eaque",
  "UpdatedDate": "2018-02-01T11:10:27.3774566+01:00",
  "CreatedDate": "1997-01-01T11:10:27.3774566+01:00",
  "BirthDate": "2001-02-20T11:10:27.3774566+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "eos",
      "StrippedValue": "porro",
      "Description": "Synergistic contextually-based ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 713
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "porro",
      "Description": "Synergistic contextually-based ability",
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
  "Description": "Open-architected clear-thinking local area network",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "suscipit",
      "Description": "Networked secondary concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 498
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "suscipit",
      "Description": "Networked secondary concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 498
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "sequi",
      "Description": "Future-proofed bandwidth-monitored productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 762
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "sequi",
      "Description": "Future-proofed bandwidth-monitored productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 762
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "tempora",
      "Description": "Pre-emptive foreground pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 961
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "tempora",
      "Description": "Pre-emptive foreground pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 961
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ut",
      "StrippedValue": "minima",
      "Description": "Persevering explicit application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 494
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "minima",
      "Description": "Persevering explicit application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 494
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "officia",
      "StrippedValue": "voluptas",
      "Description": "Optimized client-driven support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 703
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "voluptas",
      "Description": "Optimized client-driven support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 703
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
      "Id": 424,
      "Name": "Rogahn-Ferry",
      "ToolTip": "Voluptates est quae.",
      "Deleted": true,
      "Rank": 621,
      "Type": "et",
      "ColorBlock": 485,
      "IconHint": "autem",
      "Selected": false,
      "LastChanged": "2003-07-13T11:10:27.379453+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "autem",
      "Hidden": true,
      "FullName": "Gloria Bradtke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 389
        }
      }
    }
  ],
  "PersonNumber": "1278604",
  "FullName": "Shanny Brock Weimann MD",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "aliquid",
      "StrippedValue": "tenetur",
      "Description": "Persistent demand-driven task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 732
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "tenetur",
      "Description": "Persistent demand-driven task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 732
        }
      }
    }
  ],
  "FormalName": "Hilpert, Quitzon and Bins",
  "Address": null,
  "Post3": "in",
  "Post2": "explicabo",
  "Post1": "ducimus",
  "Kanalname": "qui",
  "Kanafname": "repellendus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "aperiam",
  "ActiveInterests": 523,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 809,
  "DbiKey": "quia",
  "DbiLastModified": "2012-12-17T11:10:27.3824534+01:00",
  "DbiLastSyncronized": "2004-12-30T11:10:27.3824534+01:00",
  "SentInfo": 190,
  "ShowContactTickets": 821,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quia",
      "StrippedValue": "est",
      "Description": "User-centric tangible neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 89
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "est",
      "Description": "User-centric tangible neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 89
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "quia",
      "StrippedValue": "dolor",
      "Description": "Triple-buffered client-server artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 392
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "dolor",
      "Description": "Triple-buffered client-server artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 392
        }
      }
    }
  ],
  "Source": 382,
  "ActiveErpLinks": 111,
  "ShipmentTypes": [
    {
      "Id": 454,
      "Name": "Kuhic-Weimann",
      "ToolTip": "Quo aut ut eos quibusdam qui omnis ut.",
      "Deleted": false,
      "Rank": 519,
      "Type": "earum",
      "ColorBlock": 577,
      "IconHint": "explicabo",
      "Selected": true,
      "LastChanged": "2005-08-03T11:10:27.3834532+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "tempore",
      "StyleHint": "quia",
      "Hidden": true,
      "FullName": "Mr. Katlyn Diamond Dibbert Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 52
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 95,
      "Comment": "minima",
      "Registered": "2018-07-23T11:10:27.3834532+02:00",
      "RegisteredAssociateId": 850,
      "Updated": "2012-11-28T11:10:27.3834532+01:00",
      "UpdatedAssociateId": 382,
      "LegalBaseId": 424,
      "LegalBaseKey": "repellat",
      "LegalBaseName": "Leffler Group",
      "ConsentPurposeId": 48,
      "ConsentPurposeKey": "possimus",
      "ConsentPurposeName": "Schimmel-Ruecker",
      "ConsentSourceId": 445,
      "ConsentSourceKey": "laborum",
      "ConsentSourceName": "Harber, Feeney and Leffler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 425
        }
      }
    }
  ],
  "BounceEmails": [
    "stanford@stark.uk",
    "ida_sipes@fisher.info"
  ],
  "ActiveStatusMonitorId": 155,
  "UserDefinedFields": {
    "SuperOffice:1": "Jeremy Gerlach",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquam",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "iusto",
    "CustomFields2": "tempore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 337
    }
  }
}
```
