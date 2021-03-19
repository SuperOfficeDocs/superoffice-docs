<properties generated="1" SortOrder="990" />

# AssociateType Enum

Associate type

* NoPersonBit = 1
* AnonymousBit = 2
* NoCalenderBit = 4
* NoSentryBit = 8
* Employee = 0
* Resource = 1
* ExternalPerson = 4
* System = 13
* Anonymous = 7

## Usage
* [associate](associate.md).type - Employees, resources and other users - except for External persons
* [AssociateHistory](AssociateHistory.md).type - Historical information about associates that have been deleted. Most references are NOT declared as foreign keys; this is a historical table that should not be updated when further changes occur in the database

