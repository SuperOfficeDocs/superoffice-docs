---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ChangeCountry?$select=name,department,category/id
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

ContactEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 353
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 903,
  "Name": "Schuppe, D'Amore and Hoeger",
  "Department": "benchmark sexy systems",
  "OrgNr": "1034279",
  "Number1": "1064020",
  "Number2": "1655373",
  "UpdatedDate": "1998-01-25T11:22:37.7273455+01:00",
  "CreatedDate": "1999-03-07T11:22:37.7273455+01:00",
  "Emails": [
    {
      "Value": "ducimus",
      "StrippedValue": "voluptatem",
      "Description": "Multi-lateral client-driven product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "voluptatem",
      "Description": "Multi-lateral client-driven product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 293,
      "Name": "Kutch, Zemlak and Wolf",
      "ToolTip": "Sed quo et et quasi itaque dignissimos.",
      "Deleted": false,
      "Rank": 834,
      "Type": "sit",
      "ColorBlock": 803,
      "IconHint": "quam",
      "Selected": true,
      "LastChanged": "2004-08-20T11:22:37.7273455+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "temporibus",
      "StyleHint": "beatae",
      "Hidden": true,
      "FullName": "Mr. Aiyana Keshaun Hintz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 164
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "qui",
      "Description": "Grass-roots zero defect service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 784
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "qui",
      "Description": "Grass-roots zero defect service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 784
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "consectetur",
      "Description": "Universal bottom-line algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 615
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "consectetur",
      "Description": "Universal bottom-line algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 615
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "molestiae",
      "StrippedValue": "iure",
      "Description": "Quality-focused motivating definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 605
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "iure",
      "Description": "Quality-focused motivating definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 605
        }
      }
    }
  ],
  "Description": "Reverse-engineered full-range challenge",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "omnis",
      "PersonId": 577,
      "Mrmrs": "voluptatem",
      "Firstname": "Leonie",
      "Lastname": "Wintheiser",
      "MiddleName": "Kovacek Inc and Sons",
      "Title": "quae",
      "Description": "Triple-buffered empowering extranet",
      "Email": "marilyne.berge@deckow.uk",
      "FullName": "Rhoda Abbott Jr.",
      "DirectPhone": "889.371.8650",
      "FormalName": "Vandervort, Lueilwitz and Rosenbaum",
      "CountryId": 549,
      "ContactId": 19,
      "ContactName": "Monahan LLC",
      "Retired": 665,
      "Rank": 908,
      "ActiveInterests": 706,
      "ContactDepartment": "",
      "ContactCountryId": 290,
      "ContactOrgNr": "885335",
      "FaxPhone": "(686)478-9608 x905",
      "MobilePhone": "(614)252-9907",
      "ContactPhone": "1-714-297-3188",
      "AssociateName": "Ward LLC",
      "AssociateId": 851,
      "UsePersonAddress": true,
      "ContactFax": "et",
      "Kanafname": "molestiae",
      "Kanalname": "voluptatibus",
      "Post1": "reiciendis",
      "Post2": "ullam",
      "Post3": "aspernatur",
      "EmailName": "owen@bayer.co.uk",
      "ContactFullName": "Mrs. Bertrand Keeling MD",
      "ActiveErpLinks": 958,
      "TicketPriorityId": 671,
      "SupportLanguageId": 317,
      "SupportAssociateId": 883,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 312
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "deleniti",
  "Xstop": false,
  "ActiveInterests": 827,
  "GroupId": 812,
  "ActiveStatusMonitorId": 320,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 720,
  "DbiAgentId": 300,
  "DbiLastSyncronized": "2020-04-22T11:22:37.7273455+02:00",
  "DbiKey": "necessitatibus",
  "DbiLastModified": "2023-01-03T11:22:37.7273455+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 176,
  "ActiveErpLinks": 359,
  "BounceEmails": [
    "elta@miller.name",
    "jermain@harber.us"
  ],
  "Domains": [
    "quod",
    "corporis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "260159158",
    "SuperOffice:2": "236200116"
  },
  "ExtraFields": {
    "ExtraFields1": "iure",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "quis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 465
    }
  }
}
```