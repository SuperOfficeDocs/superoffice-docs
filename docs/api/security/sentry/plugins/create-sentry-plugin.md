---
title: create_sentry_plugin
description: Create a Sentry plugin
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
so.envir: onsite
---

# Create your own Sentry plugin

In NetServer there are many [built-in sentry mechanisms][1] like contact sentry, person sentry, and project sentry. Our intention here is to develop our own sentry mechanisms on top of what already is in NetServer.

## Example objective and data

The example aims to modify the contact sentry right if the department name of a contact ends with an underscore. For example, if the department name of a given contact looks like this `XYZ Department_` then we change the sentry rights.

To make this easy to follow we will make read-only companies not owned by the current user, whose department name ends in an underscore.

| Name, Department | Owner | Result |
|---|---|---|
| SuperOffice, Research | You | No change |
| SuperOffice, Research_ |You | Read-only |
| SuperOffice, HQ | Me | No change |
| SuperOffice, HQ_ | Me | No change |

## Code

[!code-csharp[CS](includes/basic-sentry-plugin.cs)]

## Walk-through

The example is a bit long and complex, but if we analyze it carefully, we can understand what it is trying to do.

First, we make our whole class a sentry plugin for the contact sentry. This class will act as a Plugin and enhance the standard NetServer contact sentry mechanism.

### ModifyTableRight

The most important method is the `ModifyTableRight` method. NetServer will pass in a `TableRights` object as the parameter. This object is the rights object that we intend modify according to the rules that we have defined.

In `ModifyTableRight()`, we first retrieve the department name using the `GetFieldValue` helper method that we have developed. The `GetFieldValue` method will use the `QueryInfo` method that we have developed to cast the sentry type that we have set in the `Init` method of the class to a `ContactSentryQueryInfo` type.

Using `ContactSentryQueryInfo`, we can obtain any field info of the `MainTable` that exists within `ContactSentryQueryInfo`.

In the sample code, we have retrieved the department field info object and pass it to the `GetFieldValue` method. So this method will return us the field value. Now we have the value of the department field.

Then we will check whether the field is empty, the value ends with `_`, and the logged-in user is not the owner of the record. The owner of the record will anyway have full rights to the record, changing that will not be logical. If these conditions are satisfied, we go ahead and modify the rights of the rights object that we received as a parameter. Here we make them all read-only. Now we have developed a sentry mechanism that will be triggered only if the department value ends with an underscore.

## ModifySelect

Notice that we have developed another class called `SentryPluginQueryTableUpdaterContact` which implements the `IsentryPluginQueryTableUpdater interface`.

The only method that we have to implement in this interface is the `ModifySelect` method. We have marked this class as a `SentryPluginQueryTableUpdater` for the contact object using attributes. Now NetServer knows that we have developed `SentryPluginQueryTableUpdater` for the contact entity. So the moment that we try to retrieve a contact entity, this method will get fired and our extra field will be added to the sentry SQL.

We have to cast the `TableInfo` object that we receive to the type we want - in this case, `ContactTableInfo`.

Then we can add our extra field to sentry SQL. In fact, out of all the methods in the above class, this is the method that will be fired first. We can understand this well when we get into the explanation of the calling program of this Plugin.

## ModifyFieldRights

The next important method is `ModifyFieldRights` method which accepts a `FieldRights` object as the parameter. Here what we can restrict access to the individual fields of the contact object. In this case we don’t do anything special, but the same principle applies as for the `TableRights`. You modify the collection passed in as a parameter with new values for the fields you want to restrict.

The rest of the methods that appear in the above class are helper methods.

Now that we have understood our Plugin, [let's look at how we can use this][2].

<!-- Referenced links -->
[1]: ../index.md
[2]: use-sentry-plugin.md
