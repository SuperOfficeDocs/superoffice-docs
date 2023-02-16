---
title: POST Agents/Person/GetMyPerson
uid: v1PersonAgent_GetMyPerson
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

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
  "PersonId": 660,
  "Firstname": "Leila",
  "MiddleName": "Beer LLC",
  "Lastname": "Heathcote",
  "Mrmrs": "rerum",
  "Title": "delectus",
  "UpdatedDate": "2015-02-23T14:19:03.79575+01:00",
  "CreatedDate": "2016-06-28T14:19:03.79575+02:00",
  "BirthDate": "2003-03-22T14:19:03.79575+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "accusantium",
      "StrippedValue": "repellat",
      "Description": "Multi-tiered eco-centric product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 253
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "repellat",
      "Description": "Multi-tiered eco-centric product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 253
        }
      }
    }
  ],
  "Description": "Future-proofed incremental service-desk",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "a",
      "StrippedValue": "ut",
      "Description": "Reduced human-resource data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 877
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "ut",
      "Description": "Reduced human-resource data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 877
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "beatae",
      "StrippedValue": "quisquam",
      "Description": "Synchronised 24/7 forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 152
        }
      }
    },
    {
      "Value": "beatae",
      "StrippedValue": "quisquam",
      "Description": "Synchronised 24/7 forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 152
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "asperiores",
      "StrippedValue": "consequatur",
      "Description": "Fundamental scalable hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 268
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "consequatur",
      "Description": "Fundamental scalable hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 268
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "natus",
      "StrippedValue": "qui",
      "Description": "Self-enabling dedicated functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 738
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "qui",
      "Description": "Self-enabling dedicated functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 738
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "eum",
      "StrippedValue": "quia",
      "Description": "Devolved attitude-oriented open architecture",
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
      "Value": "eum",
      "StrippedValue": "quia",
      "Description": "Devolved attitude-oriented open architecture",
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
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 232,
      "Name": "Bergnaum-Labadie",
      "ToolTip": "Aperiam inventore hic possimus vitae veniam et.",
      "Deleted": true,
      "Rank": 667,
      "Type": "id",
      "ColorBlock": 77,
      "IconHint": "impedit",
      "Selected": true,
      "LastChanged": "2008-07-29T14:19:03.79575+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Ms. Domenic Ritchie DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 651
        }
      }
    }
  ],
  "PersonNumber": "1457702",
  "FullName": "Eriberto Muller",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "eveniet",
      "StrippedValue": "dolorem",
      "Description": "Persistent maximized open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "dolorem",
      "Description": "Persistent maximized open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    }
  ],
  "FormalName": "Mertz Inc and Sons",
  "Address": null,
  "Post3": "rem",
  "Post2": "blanditiis",
  "Post1": "ut",
  "Kanalname": "omnis",
  "Kanafname": "omnis",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ea",
  "ActiveInterests": 394,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 618,
  "DbiKey": "rerum",
  "DbiLastModified": "2002-01-21T14:19:03.79575+01:00",
  "DbiLastSyncronized": "2021-12-12T14:19:03.79575+01:00",
  "SentInfo": 962,
  "ShowContactTickets": 826,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "atque",
      "StrippedValue": "vel",
      "Description": "Sharable maximized conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "vel",
      "Description": "Sharable maximized conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "sint",
      "StrippedValue": "a",
      "Description": "Digitized web-enabled focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 25
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "a",
      "Description": "Digitized web-enabled focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 25
        }
      }
    }
  ],
  "Source": 870,
  "ActiveErpLinks": 328,
  "ShipmentTypes": [
    {
      "Id": 297,
      "Name": "Kihn Inc and Sons",
      "ToolTip": "Asperiores itaque.",
      "Deleted": false,
      "Rank": 245,
      "Type": "perferendis",
      "ColorBlock": 87,
      "IconHint": "quaerat",
      "Selected": false,
      "LastChanged": "2012-03-19T14:19:03.79575+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "itaque",
      "StyleHint": "iure",
      "Hidden": true,
      "FullName": "Chelsey Clare Hilpert Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 83
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 106,
      "Comment": "vel",
      "Registered": "2013-01-30T14:19:03.79575+01:00",
      "RegisteredAssociateId": 1001,
      "Updated": "1996-09-25T14:19:03.79575+02:00",
      "UpdatedAssociateId": 903,
      "LegalBaseId": 80,
      "LegalBaseKey": "nostrum",
      "LegalBaseName": "Gusikowski Inc and Sons",
      "ConsentPurposeId": 836,
      "ConsentPurposeKey": "nisi",
      "ConsentPurposeName": "Gorczany, Ritchie and Hills",
      "ConsentSourceId": 217,
      "ConsentSourceKey": "voluptas",
      "ConsentSourceName": "Schneider-Kuphal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 267
        }
      }
    }
  ],
  "BounceEmails": [
    "susana@watsicarippin.co.uk",
    "claudie_dickens@jakubowski.com"
  ],
  "ActiveStatusMonitorId": 749,
  "UserDefinedFields": {
    "SuperOffice:1": "1634992828",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "magnam"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 10
    }
  }
}
```