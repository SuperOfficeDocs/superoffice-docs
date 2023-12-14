---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 623
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 668,
  "Name": "Barton-Kohler",
  "Department": "",
  "OrgNr": "1300677",
  "Number1": "527705",
  "Number2": "1183520",
  "UpdatedDate": "2009-12-27T13:57:11.9174299+01:00",
  "CreatedDate": "1999-10-18T13:57:11.9174299+02:00",
  "Emails": [
    {
      "Value": "a",
      "StrippedValue": "quis",
      "Description": "Automated contextually-based knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 76
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "quis",
      "Description": "Automated contextually-based knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 76
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 193,
      "Name": "Cartwright Group",
      "ToolTip": "In adipisci necessitatibus accusantium fugit.",
      "Deleted": false,
      "Rank": 668,
      "Type": "sunt",
      "ColorBlock": 157,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2022-05-19T13:57:11.9174299+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nobis",
      "StyleHint": "cupiditate",
      "Hidden": false,
      "FullName": "Dr. Alfred Schimmel IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 167
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vitae",
      "StrippedValue": "repellat",
      "Description": "Reactive clear-thinking circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 869
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "repellat",
      "Description": "Reactive clear-thinking circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 869
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "inventore",
      "Description": "Polarised zero administration flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 721
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "inventore",
      "Description": "Polarised zero administration flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 721
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "aut",
      "Description": "Re-engineered web-enabled intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 682
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "aut",
      "Description": "Re-engineered web-enabled intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 682
        }
      }
    }
  ],
  "Description": "Automated bi-directional standardization",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "fugiat",
      "PersonId": 936,
      "Mrmrs": "nobis",
      "Firstname": "Forest",
      "Lastname": "Vandervort",
      "MiddleName": "Rau-Weimann",
      "Title": "consequatur",
      "Description": "Multi-tiered next generation Graphic Interface",
      "Email": "maybell@west.us",
      "FullName": "Melody Boyer",
      "DirectPhone": "408.782.7379",
      "FormalName": "Kreiger, Wisoky and Murphy",
      "CountryId": 822,
      "ContactId": 239,
      "ContactName": "Bayer Group",
      "Retired": 977,
      "Rank": 292,
      "ActiveInterests": 30,
      "ContactDepartment": "",
      "ContactCountryId": 558,
      "ContactOrgNr": "853619",
      "FaxPhone": "(216)750-3655",
      "MobilePhone": "1-479-757-2958 x70994",
      "ContactPhone": "972-203-7641",
      "AssociateName": "Mohr-Wuckert",
      "AssociateId": 984,
      "UsePersonAddress": false,
      "ContactFax": "est",
      "Kanafname": "at",
      "Kanalname": "dolorum",
      "Post1": "nihil",
      "Post2": "cum",
      "Post3": "impedit",
      "EmailName": "giovanni@keeblerruecker.uk",
      "ContactFullName": "Destin Kunde",
      "ActiveErpLinks": 754,
      "TicketPriorityId": 722,
      "SupportLanguageId": 727,
      "SupportAssociateId": 888,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 635
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ad",
  "Xstop": false,
  "ActiveInterests": 81,
  "GroupId": 782,
  "ActiveStatusMonitorId": 868,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 813,
  "DbiAgentId": 777,
  "DbiLastSyncronized": "2012-11-21T13:57:11.9174299+01:00",
  "DbiKey": "eum",
  "DbiLastModified": "2007-05-14T13:57:11.9174299+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 623,
  "ActiveErpLinks": 72,
  "BounceEmails": [
    "xavier.grimes@klocko.biz",
    "matteo_eichmann@kris.us"
  ],
  "Domains": [
    "eligendi",
    "hic"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "204916797",
    "SuperOffice:2": "Faustino Deckow"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "unde"
  },
  "CustomFields": {
    "CustomFields1": "nobis",
    "CustomFields2": "autem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 212
    }
  }
}
```