---
title: POST Agents/Person/ChangeCountry
uid: v1PersonAgent_ChangeCountry
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
| PersonEntity |  |  |
| ToCountryId | int32 |  |


## Response: 

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
POST /api/v1/Agents/Person/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonEntity": null,
  "ToCountryId": 287
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 300,
  "Firstname": "Bartholome",
  "MiddleName": "Cartwright Inc and Sons",
  "Lastname": "Gibson",
  "Mrmrs": "quo",
  "Title": "neque",
  "UpdatedDate": "1999-01-09T02:49:44.8278376+01:00",
  "CreatedDate": "1996-12-28T02:49:44.8278376+01:00",
  "BirthDate": "2019-02-28T02:49:44.8278376+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "eum",
      "StrippedValue": "qui",
      "Description": "Ameliorated global moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 473
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "qui",
      "Description": "Ameliorated global moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 473
        }
      }
    }
  ],
  "Description": "Up-sized upward-trending functionalities",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "provident",
      "StrippedValue": "exercitationem",
      "Description": "Robust directional interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 625
        }
      }
    },
    {
      "Value": "provident",
      "StrippedValue": "exercitationem",
      "Description": "Robust directional interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 625
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "molestiae",
      "StrippedValue": "et",
      "Description": "Cross-group empowering time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 931
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "et",
      "Description": "Cross-group empowering time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 931
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "placeat",
      "StrippedValue": "fugit",
      "Description": "Focused incremental framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    },
    {
      "Value": "placeat",
      "StrippedValue": "fugit",
      "Description": "Focused incremental framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Configurable system-worthy knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Configurable system-worthy knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "id",
      "StrippedValue": "sit",
      "Description": "Automated holistic solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 952
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "sit",
      "Description": "Automated holistic solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 952
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
      "Id": 623,
      "Name": "Conn-Bernhard",
      "ToolTip": "Aut culpa id repellendus.",
      "Deleted": true,
      "Rank": 175,
      "Type": "optio",
      "ColorBlock": 651,
      "IconHint": "aliquam",
      "Selected": false,
      "LastChanged": "2010-09-13T02:49:44.8278376+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quas",
      "StyleHint": "nemo",
      "Hidden": false,
      "FullName": "Martine Lindgren I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    }
  ],
  "PersonNumber": "944892",
  "FullName": "Mrs. Stephon Christiansen",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "voluptates",
      "Description": "Distributed responsive capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 611
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "voluptates",
      "Description": "Distributed responsive capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 611
        }
      }
    }
  ],
  "FormalName": "McLaughlin LLC",
  "Address": null,
  "Post3": "nihil",
  "Post2": "incidunt",
  "Post1": "sed",
  "Kanalname": "dolorum",
  "Kanafname": "incidunt",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sed",
  "ActiveInterests": 137,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 389,
  "DbiKey": "assumenda",
  "DbiLastModified": "2011-08-08T02:49:44.8278376+02:00",
  "DbiLastSyncronized": "2001-04-11T02:49:44.8278376+02:00",
  "SentInfo": 338,
  "ShowContactTickets": 909,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "qui",
      "StrippedValue": "est",
      "Description": "Open-source multi-state flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 757
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "est",
      "Description": "Open-source multi-state flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 757
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "possimus",
      "StrippedValue": "consequatur",
      "Description": "Re-contextualized value-added migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 501
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "consequatur",
      "Description": "Re-contextualized value-added migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 501
        }
      }
    }
  ],
  "Source": 611,
  "ActiveErpLinks": 705,
  "ShipmentTypes": [
    {
      "Id": 329,
      "Name": "Gottlieb, Lubowitz and Kertzmann",
      "ToolTip": "Odio omnis sequi.",
      "Deleted": false,
      "Rank": 225,
      "Type": "quam",
      "ColorBlock": 956,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "1998-04-27T02:49:44.8278376+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolor",
      "StyleHint": "molestiae",
      "Hidden": true,
      "FullName": "Delbert Bechtelar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 295
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 595,
      "Comment": "non",
      "Registered": "2013-07-24T02:49:44.8278376+02:00",
      "RegisteredAssociateId": 332,
      "Updated": "2007-10-17T02:49:44.8278376+02:00",
      "UpdatedAssociateId": 409,
      "LegalBaseId": 287,
      "LegalBaseKey": "itaque",
      "LegalBaseName": "Kunde-Beatty",
      "ConsentPurposeId": 178,
      "ConsentPurposeKey": "id",
      "ConsentPurposeName": "Bartoletti-Nienow",
      "ConsentSourceId": 446,
      "ConsentSourceKey": "consequuntur",
      "ConsentSourceName": "McGlynn-Harvey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 787
        }
      }
    }
  ],
  "BounceEmails": [
    "tomasa@aufderhar.co.uk",
    "newell@hilll.uk"
  ],
  "ActiveStatusMonitorId": 567,
  "UserDefinedFields": {
    "SuperOffice:1": "1638552584",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "voluptatem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 679
    }
  }
}
```