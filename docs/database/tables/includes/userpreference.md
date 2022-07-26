<!-- markdownlint-disable-file MD041 -->
### Values needed to access the UserPreference tables

This table must have special values that are not easy to guess correctly. They are listed below with a description of how to use them.

The User preference override level is the level at which a particular preference is defined.

| Levels | ID | Comment |
|---|---|---|
| Undefined | 0 | Undefined value (error) |
| Hard default | 1 | Default value used if no other value has been specified. Hard-coded default, owner_id == 0 |
| System wide | 2 | Value valid for all databases under this licence, owner_id == 0 |
| Database | 3 | Valid for all users of this database, owner_id = travelcurrent.current_id |
| Group | 4 | Valid for all users that are members of this group, owner_id = UserGroup.Id |
| Individual | 5 | Valid for this associate only, owner_id = associate.id |
| PC | 6 | Valid for this PC only, not connected to user. (Note: stored in the Registry, not in the database) |
