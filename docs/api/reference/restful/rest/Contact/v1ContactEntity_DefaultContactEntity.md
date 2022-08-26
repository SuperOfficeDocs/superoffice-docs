---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
---

# GET Contact/default

```http
GET /api/v1/Contact/default
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Contact agent service CreateDefaultContactEntity.







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

Response body: 

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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 17 Mar 2012 11:10:52 G3T

{
  "ContactId": 214,
  "Name": "Erdman-Daugherty",
  "Department": "",
  "OrgNr": "1108165",
  "Number1": "738463",
  "Number2": "661935",
  "UpdatedDate": "2012-03-17T11:10:52.62216+01:00",
  "CreatedDate": "1997-04-08T11:10:52.62216+02:00",
  "Emails": [
    {
      "Value": "similique",
      "StrippedValue": "ut",
      "Description": "Secured coherent product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 27
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "ut",
      "Description": "Secured coherent product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 27
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 297,
      "Name": "Murphy-Schmitt",
      "ToolTip": "Aperiam atque quasi maiores voluptatem.",
      "Deleted": true,
      "Rank": 884,
      "Type": "occaecati",
      "ColorBlock": 597,
      "IconHint": "minima",
      "Selected": false,
      "LastChanged": "2020-02-19T11:10:52.62216+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rem",
      "StyleHint": "dolores",
      "Hidden": true,
      "FullName": "Mr. Adelia Rosalind Zulauf Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 890
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "ea",
      "Description": "Optional coherent website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 92
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "ea",
      "Description": "Optional coherent website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 92
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "autem",
      "StrippedValue": "in",
      "Description": "Public-key content-based data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 347
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "in",
      "Description": "Public-key content-based data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 347
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "maiores",
      "StrippedValue": "excepturi",
      "Description": "Progressive methodical data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 411
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "excepturi",
      "Description": "Progressive methodical data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 411
        }
      }
    }
  ],
  "Description": "Phased neutral workforce",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "distinctio",
      "PersonId": 99,
      "Mrmrs": "voluptas",
      "Firstname": "Pedro",
      "Lastname": "Buckridge",
      "MiddleName": "Ziemann-Berge",
      "Title": "aut",
      "Description": "Balanced empowering migration",
      "Email": "guy_medhurst@wintheiser.co.uk",
      "FullName": "Eunice Eichmann",
      "DirectPhone": "065-217-4440 x05052",
      "FormalName": "Klein-Christiansen",
      "CountryId": 805,
      "ContactId": 738,
      "ContactName": "Mayer Inc and Sons",
      "Retired": 214,
      "Rank": 417,
      "ActiveInterests": 393,
      "ContactDepartment": "",
      "ContactCountryId": 745,
      "ContactOrgNr": "1020132",
      "FaxPhone": "1-121-112-0807 x8816",
      "MobilePhone": "1-222-579-0871",
      "ContactPhone": "1-447-198-1705",
      "AssociateName": "Hermiston LLC",
      "AssociateId": 948,
      "UsePersonAddress": true,
      "ContactFax": "consectetur",
      "Kanafname": "unde",
      "Kanalname": "quis",
      "Post1": "sit",
      "Post2": "et",
      "Post3": "nihil",
      "EmailName": "vernie_bogan@goodwinleannon.name",
      "ContactFullName": "Demario Tillman",
      "ActiveErpLinks": 664,
      "TicketPriorityId": 627,
      "SupportLanguageId": 272,
      "SupportAssociateId": 134,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 746
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quam",
  "Xstop": false,
  "ActiveInterests": 28,
  "GroupId": 605,
  "ActiveStatusMonitorId": 458,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 956,
  "DbiAgentId": 909,
  "DbiLastSyncronized": "2001-06-11T11:10:52.6261694+02:00",
  "DbiKey": "adipisci",
  "DbiLastModified": "1998-01-09T11:10:52.6261694+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 805,
  "ActiveErpLinks": 15,
  "BounceEmails": [
    "lon@larson.com",
    "marcelino@leffler.us"
  ],
  "Domains": [
    "consequuntur",
    "soluta"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1221865835",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "soluta",
    "ExtraFields2": "ex"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 634
    }
  }
}
```