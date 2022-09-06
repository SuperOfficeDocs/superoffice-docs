---
title: POST Agents/Person/GetSalesRep
uid: v1PersonAgent_GetSalesRep
---

# POST Agents/Person/GetSalesRep

```http
POST /api/v1/Agents/Person/GetSalesRep
```

Returns the sales representative for an external user.

If this method is accessed with anonymous authentication the external user is recognized by contact and name, or by email, or phone number. If the external user is recognized as an CRM5 user (internal or external) the input fields can be left blank.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetSalesRep?$select=name,department,category/id
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

ContactName, PersonFirstname, PersonLastname, EmailAddress, PhoneNumber

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactName | string |  |
| PersonFirstname | string |  |
| PersonLastname | string |  |
| EmailAddress | string |  |
| PhoneNumber | string |  |

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
POST /api/v1/Agents/Person/GetSalesRep
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Connelly LLC",
  "PersonFirstname": "Nettie",
  "PersonLastname": "Leffler",
  "EmailAddress": "myrtis@murazik.name",
  "PhoneNumber": "1271056"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 998,
  "Firstname": "Wilburn",
  "MiddleName": "Douglas Inc and Sons",
  "Lastname": "McDermott",
  "Mrmrs": "modi",
  "Title": "vitae",
  "UpdatedDate": "2021-10-18T11:10:27.4124248+02:00",
  "CreatedDate": "2021-09-27T11:10:27.4124248+02:00",
  "BirthDate": "2001-09-23T11:10:27.4124248+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sit",
      "StrippedValue": "numquam",
      "Description": "Multi-tiered empowering interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "numquam",
      "Description": "Multi-tiered empowering interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    }
  ],
  "Description": "Business-focused upward-trending hardware",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "excepturi",
      "StrippedValue": "explicabo",
      "Description": "Ergonomic bifurcated middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 773
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "explicabo",
      "Description": "Ergonomic bifurcated middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 773
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "at",
      "StrippedValue": "similique",
      "Description": "Intuitive content-based standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 596
        }
      }
    },
    {
      "Value": "at",
      "StrippedValue": "similique",
      "Description": "Intuitive content-based standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 596
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "eum",
      "Description": "Virtual neutral strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 835
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "eum",
      "Description": "Virtual neutral strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 835
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quaerat",
      "StrippedValue": "dicta",
      "Description": "Visionary attitude-oriented circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "dicta",
      "Description": "Visionary attitude-oriented circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ut",
      "StrippedValue": "ipsum",
      "Description": "User-friendly responsive customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 613
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "ipsum",
      "Description": "User-friendly responsive customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 613
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
      "Id": 714,
      "Name": "Gleichner, Beahan and Stokes",
      "ToolTip": "Vero optio cupiditate quo.",
      "Deleted": true,
      "Rank": 806,
      "Type": "amet",
      "ColorBlock": 275,
      "IconHint": "molestiae",
      "Selected": false,
      "LastChanged": "2000-11-28T11:10:27.4144248+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "rerum",
      "Hidden": false,
      "FullName": "Jo Roberts",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 2
        }
      }
    }
  ],
  "PersonNumber": "1698746",
  "FullName": "Ms. Mandy Treutel DDS",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "vel",
      "StrippedValue": "quas",
      "Description": "Switchable national focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 453
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "quas",
      "Description": "Switchable national focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 453
        }
      }
    }
  ],
  "FormalName": "Pfannerstill, Cremin and Cole",
  "Address": null,
  "Post3": "et",
  "Post2": "dicta",
  "Post1": "id",
  "Kanalname": "rerum",
  "Kanafname": "reprehenderit",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sunt",
  "ActiveInterests": 644,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 765,
  "DbiKey": "alias",
  "DbiLastModified": "2017-07-23T11:10:27.4164251+02:00",
  "DbiLastSyncronized": "2020-01-29T11:10:27.4164251+01:00",
  "SentInfo": 344,
  "ShowContactTickets": 648,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quis",
      "StrippedValue": "voluptatem",
      "Description": "Organic optimizing superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "voluptatem",
      "Description": "Organic optimizing superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "quaerat",
      "StrippedValue": "aut",
      "Description": "Up-sized discrete open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 511
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "aut",
      "Description": "Up-sized discrete open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 511
        }
      }
    }
  ],
  "Source": 915,
  "ActiveErpLinks": 439,
  "ShipmentTypes": [
    {
      "Id": 803,
      "Name": "Morar, Goyette and Feest",
      "ToolTip": "Veniam maxime laudantium voluptatem.",
      "Deleted": false,
      "Rank": 867,
      "Type": "consequatur",
      "ColorBlock": 713,
      "IconHint": "magnam",
      "Selected": false,
      "LastChanged": "1999-03-18T11:10:27.4174248+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quas",
      "StyleHint": "magnam",
      "Hidden": false,
      "FullName": "Mr. Fritz Emiliano Gerhold IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 693
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 233,
      "Comment": "ut",
      "Registered": "2000-05-27T11:10:27.4204605+02:00",
      "RegisteredAssociateId": 773,
      "Updated": "2020-11-14T11:10:27.4204605+01:00",
      "UpdatedAssociateId": 292,
      "LegalBaseId": 257,
      "LegalBaseKey": "odit",
      "LegalBaseName": "King Inc and Sons",
      "ConsentPurposeId": 800,
      "ConsentPurposeKey": "vitae",
      "ConsentPurposeName": "Breitenberg-Senger",
      "ConsentSourceId": 846,
      "ConsentSourceKey": "sed",
      "ConsentSourceName": "Hamill-Terry",
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
  "BounceEmails": [
    "reggie.hand@jast.uk",
    "llewellyn.rippin@kertzmanngleichner.uk"
  ],
  "ActiveStatusMonitorId": 848,
  "UserDefinedFields": {
    "SuperOffice:1": "Lillie Nigel Gerhold III",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "accusamus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 836
    }
  }
}
```
