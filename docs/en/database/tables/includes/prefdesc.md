<!-- markdownlint-disable-file MD041 -->
### Value for field 'accessflags' in table 'prefdesc'

This enumeration consists of flag values that can be combined

| accessflags | ID | Comment |
|---|---|---|
| Unknown | 0 | Unknown - used when initializing |
| WizardMode |  1 | Wizard mode is password-protected and only accessible to SuperOffice personnel. |
| Level0 | 2 | Preference settable only by CRM superuser |
| adminGUI | 4 | Show preference in SOADMIN GUI |
| CRMGUI | 8 | Show preference in CRM GUI |

### Value for field 'valueType' in table 'prefdesc'

| valueType | ID | Comment |
|---|---|---|
| Unknown | 0 | Unknown - used when initializing |
| Number |  1 | Preference value is a number |
| Text | 2 | Preference value is a text (max len 99 characters) |
| Bool | 3 | Preference value is Boolean |
| ListOfValues | 4 | Preference value is a list of separate value |
| ListTableRef | 5 | Preference value is a record ID in the given MDO list table |
| TimeList | 6 | Preference value is a time, value is seconds since midnight (28800 = 08:00) |
| ContactID | 7 | Preference value is a contact ID |
| PersonID | 8 | Preference value is a person ID |
| ProjectID | 9 | Preference value is a project ID |
| SelectionID | 10 | Preference value is a selection ID |
| PosSize | 11 | Obsolete: Windows position and size |
| TimeZone | 12 | TimeZone location |
