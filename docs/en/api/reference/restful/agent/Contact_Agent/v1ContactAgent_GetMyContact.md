---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 6,
  "Name": "Volkman, Kautzer and Wyman",
  "Department": "",
  "OrgNr": "1012292",
  "Number1": "565150",
  "Number2": "595940",
  "UpdatedDate": "2024-07-29T12:01:27.4940057+02:00",
  "CreatedDate": "2001-04-07T12:01:27.4940057+02:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "adipisci",
      "Description": "Open-architected system-worthy benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 571
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "adipisci",
      "Description": "Open-architected system-worthy benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 571
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 895,
      "Name": "Herman, Wilderman and Hahn",
      "ToolTip": "Eligendi dolores dignissimos sunt id ut amet.",
      "Deleted": false,
      "Rank": 308,
      "Type": "omnis",
      "ColorBlock": 127,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "1999-06-20T12:01:27.4940057+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequuntur",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Ms. Benny Senger DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 574
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aperiam",
      "StrippedValue": "nesciunt",
      "Description": "Quality-focused static architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 122
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "nesciunt",
      "Description": "Quality-focused static architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 122
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quam",
      "StrippedValue": "repudiandae",
      "Description": "Diverse mobile knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 44
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "repudiandae",
      "Description": "Diverse mobile knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 44
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "veniam",
      "StrippedValue": "ipsa",
      "Description": "Operative dedicated capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "ipsa",
      "Description": "Operative dedicated capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    }
  ],
  "Description": "Multi-tiered 4th generation secured line",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "beatae",
      "PersonId": 417,
      "Mrmrs": "dolor",
      "Firstname": "Kade",
      "Lastname": "Rutherford",
      "MiddleName": "Stiedemann Inc and Sons",
      "Title": "vel",
      "Description": "User-centric interactive monitoring",
      "Email": "danny_leffler@stroman.ca",
      "FullName": "Hubert Weimann",
      "DirectPhone": "463.897.1988",
      "FormalName": "Bednar-Vandervort",
      "CountryId": 164,
      "ContactId": 485,
      "ContactName": "Bartell-Stroman",
      "Retired": 863,
      "Rank": 236,
      "ActiveInterests": 328,
      "ContactDepartment": "",
      "ContactCountryId": 598,
      "ContactOrgNr": "1153056",
      "FaxPhone": "(948)327-4533",
      "MobilePhone": "106.205.7690",
      "ContactPhone": "423-687-5934 x954",
      "AssociateName": "Olson, Mohr and Carter",
      "AssociateId": 851,
      "UsePersonAddress": false,
      "ContactFax": "laboriosam",
      "Kanafname": "praesentium",
      "Kanalname": "dolor",
      "Post1": "omnis",
      "Post2": "voluptas",
      "Post3": "nobis",
      "EmailName": "derrick_smith@luettgenhudson.ca",
      "ContactFullName": "Gaylord Ebert",
      "ActiveErpLinks": 845,
      "TicketPriorityId": 86,
      "SupportLanguageId": 489,
      "SupportAssociateId": 502,
      "CategoryName": "VIP Customer",
      "PersonNumber": "535861",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 433
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "velit",
  "Xstop": false,
  "ActiveInterests": 123,
  "GroupId": 45,
  "ActiveStatusMonitorId": 983,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 256,
  "DbiAgentId": 140,
  "DbiLastSyncronized": "2000-09-26T12:01:27.4940057+02:00",
  "DbiKey": "enim",
  "DbiLastModified": "2010-10-19T12:01:27.4940057+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 763,
  "ActiveErpLinks": 971,
  "BounceEmails": [
    "corrine_sipes@volkmanjohns.uk",
    "sam.walter@rogahn.com"
  ],
  "Domains": [
    "voluptatem",
    "neque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Chloe Kamren Heidenreich",
    "SuperOffice:2": "Miss Eloy Oda Roberts DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "autem",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "quidem",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 794
    }
  }
}
```