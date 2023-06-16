---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 300
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 23,
  "Name": "McClure, Kiehn and Satterfield",
  "Department": "",
  "OrgNr": "890659",
  "Number1": "1197239",
  "Number2": "668771",
  "UpdatedDate": "2002-11-18T16:00:40.4300225+01:00",
  "CreatedDate": "2022-06-23T16:00:40.4300225+02:00",
  "Emails": [
    {
      "Value": "non",
      "StrippedValue": "voluptatibus",
      "Description": "Face to face human-resource flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 670
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "voluptatibus",
      "Description": "Face to face human-resource flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 670
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 624,
      "Name": "Mueller, Schmidt and Tromp",
      "ToolTip": "Impedit quia id placeat est porro.",
      "Deleted": true,
      "Rank": 734,
      "Type": "ullam",
      "ColorBlock": 804,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "1999-04-27T16:00:40.4300225+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "error",
      "Hidden": false,
      "FullName": "Ms. Leopoldo Devonte Carroll PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 64
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "in",
      "StrippedValue": "qui",
      "Description": "Face to face user-facing internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 264
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "qui",
      "Description": "Face to face user-facing internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 264
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ut",
      "StrippedValue": "nostrum",
      "Description": "User-centric 3rd generation info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 415
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "nostrum",
      "Description": "User-centric 3rd generation info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 415
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "itaque",
      "StrippedValue": "quod",
      "Description": "De-engineered logistical structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 483
        }
      }
    },
    {
      "Value": "itaque",
      "StrippedValue": "quod",
      "Description": "De-engineered logistical structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 483
        }
      }
    }
  ],
  "Description": "Multi-lateral 6th generation forecast",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "non",
      "PersonId": 380,
      "Mrmrs": "dolorum",
      "Firstname": "Elliott",
      "Lastname": "Schmitt",
      "MiddleName": "Reichert LLC",
      "Title": "sed",
      "Description": "Optional secondary definition",
      "Email": "alvis@lemke.us",
      "FullName": "Hector Von",
      "DirectPhone": "946.637.9339 x3165",
      "FormalName": "Schowalter Group",
      "CountryId": 255,
      "ContactId": 876,
      "ContactName": "Watsica, Parisian and Schmeler",
      "Retired": 434,
      "Rank": 914,
      "ActiveInterests": 253,
      "ContactDepartment": "",
      "ContactCountryId": 676,
      "ContactOrgNr": "1070694",
      "FaxPhone": "1-178-738-5805",
      "MobilePhone": "946-261-4984",
      "ContactPhone": "805.672.9138",
      "AssociateName": "Olson-Kiehn",
      "AssociateId": 29,
      "UsePersonAddress": true,
      "ContactFax": "ut",
      "Kanafname": "quo",
      "Kanalname": "aliquid",
      "Post1": "ea",
      "Post2": "consequuntur",
      "Post3": "rerum",
      "EmailName": "ezra_morissette@gradyquitzon.uk",
      "ContactFullName": "Mrs. Zaria Alexandre Kertzmann",
      "ActiveErpLinks": 426,
      "TicketPriorityId": 121,
      "SupportLanguageId": 470,
      "SupportAssociateId": 575,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 982
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "dolores",
  "Xstop": true,
  "ActiveInterests": 713,
  "GroupId": 861,
  "ActiveStatusMonitorId": 860,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 759,
  "DbiAgentId": 772,
  "DbiLastSyncronized": "2004-10-22T16:00:40.4300225+02:00",
  "DbiKey": "nesciunt",
  "DbiLastModified": "2020-09-29T16:00:40.4300225+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 502,
  "ActiveErpLinks": 136,
  "BounceEmails": [
    "kristin@osinski.us",
    "forest_beier@kutch.ca"
  ],
  "Domains": [
    "doloremque",
    "sint"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1137538582",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "ad",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "quidem",
    "CustomFields2": "omnis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 537
    }
  }
}
```