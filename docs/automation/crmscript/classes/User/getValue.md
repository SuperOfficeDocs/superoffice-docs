---
title: crmscript_ref_User_getValue_String_colName
description: User.getValue(String colName)
intellisense: User.getValue
keywords: getValue(String)
so.topic: reference
---


Gets the value of a given column.




###Parameter:###


 - String with column name




###Possible values:###


 - id: Integer, The primary key (auto-incremented)
 - loginname: String, The unique loginname for this user.
 - username: String, The unique username for this user.
 - password: String, The encrypted password for this user.
 - firstname: String, The firstname for this user.
 - middlename: String, The middlename for this user.
 - lastname: String, The lastname for this user.
 - email: String, The email address for this user.
 - status: Integer, The status (enum) for this user. 1 is Active, 2 is Not Present, 3 is deleted
 - signature: String, The users signature.
 - language: String, A string indicating the user's language ("no" or "en").
 - flags: Integer, A bitmask indicating flags for this entry.
 - lastCategory: Integer, The last chosen category for this user when posting tickets. category.id
 - pictureId: Integer, The attachment id of the picture for this user.
 - defaultUser: Integer, The default user to set on new tickets in this category (1=automatically, 2=unasigned, 3=the owner
 - initials: String, Obsolete field, cannot be removed because of not null error on older systems
 - group: Integer, The group id of the primary group which this user belongs to
 - role: Integer, The role id of the role this user belongs to
 - associateId: Integer, The corresponding associate id for this user
 - ownerCompany: Integer, the contact id of the owning company of the users' connected person entity.
 - x_* The extrafield with the given database field name.


Returns a string with value in given column


