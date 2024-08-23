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
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 324
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 685,
  "Name": "Bogan Group",
  "Department": "productize distributed functionalities",
  "OrgNr": "758328",
  "Number1": "44314",
  "Number2": "312275",
  "UpdatedDate": "2012-10-26T13:28:22.3042799+02:00",
  "CreatedDate": "1998-12-30T13:28:22.3042799+01:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "quia",
      "Description": "Mandatory multimedia interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 752
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "quia",
      "Description": "Mandatory multimedia interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 752
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 618,
      "Name": "Hoppe-Leffler",
      "ToolTip": "Ab omnis earum incidunt dolores illo quam et.",
      "Deleted": false,
      "Rank": 286,
      "Type": "aut",
      "ColorBlock": 789,
      "IconHint": "molestias",
      "Selected": false,
      "LastChanged": "2022-06-28T13:28:22.3042799+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "culpa",
      "StyleHint": "officiis",
      "Hidden": false,
      "FullName": "Mrs. Judy Hayes MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 846
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "magnam",
      "StrippedValue": "dolores",
      "Description": "Centralized static orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 594
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "dolores",
      "Description": "Centralized static orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 594
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "provident",
      "StrippedValue": "facere",
      "Description": "Proactive bottom-line website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 756
        }
      }
    },
    {
      "Value": "provident",
      "StrippedValue": "facere",
      "Description": "Proactive bottom-line website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 756
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "suscipit",
      "StrippedValue": "quas",
      "Description": "Organic intangible extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 562
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "quas",
      "Description": "Organic intangible extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 562
        }
      }
    }
  ],
  "Description": "Profound motivating leverage",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "vel",
      "PersonId": 513,
      "Mrmrs": "maxime",
      "Firstname": "Ernestine",
      "Lastname": "Adams",
      "MiddleName": "Zulauf, Schimmel and Rowe",
      "Title": "soluta",
      "Description": "Diverse 24/7 methodology",
      "Email": "watson_boyle@macejkovicvandervort.uk",
      "FullName": "Grayce O'Connell",
      "DirectPhone": "163-848-6557",
      "FormalName": "Purdy LLC",
      "CountryId": 332,
      "ContactId": 264,
      "ContactName": "O'Kon Inc and Sons",
      "Retired": 759,
      "Rank": 503,
      "ActiveInterests": 434,
      "ContactDepartment": "",
      "ContactCountryId": 880,
      "ContactOrgNr": "1104740",
      "FaxPhone": "(014)981-0268",
      "MobilePhone": "150-443-6533",
      "ContactPhone": "393.634.9208",
      "AssociateName": "Abbott Inc and Sons",
      "AssociateId": 92,
      "UsePersonAddress": false,
      "ContactFax": "alias",
      "Kanafname": "quisquam",
      "Kanalname": "tempore",
      "Post1": "voluptas",
      "Post2": "eveniet",
      "Post3": "non",
      "EmailName": "isabella@considine.ca",
      "ContactFullName": "Ms. Leda Hilll IV",
      "ActiveErpLinks": 910,
      "TicketPriorityId": 754,
      "SupportLanguageId": 465,
      "SupportAssociateId": 332,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 654
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": false,
  "ActiveInterests": 141,
  "GroupId": 816,
  "ActiveStatusMonitorId": 782,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 661,
  "DbiAgentId": 906,
  "DbiLastSyncronized": "2007-01-24T13:28:22.3042799+01:00",
  "DbiKey": "libero",
  "DbiLastModified": "2003-06-20T13:28:22.3042799+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 716,
  "ActiveErpLinks": 824,
  "BounceEmails": [
    "althea_conn@wisozkbraun.biz",
    "aisha.fay@haley.uk"
  ],
  "Domains": [
    "necessitatibus",
    "voluptatum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1767610939",
    "SuperOffice:2": "1368102107"
  },
  "ExtraFields": {
    "ExtraFields1": "perspiciatis",
    "ExtraFields2": "nostrum"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 8
    }
  }
}
```