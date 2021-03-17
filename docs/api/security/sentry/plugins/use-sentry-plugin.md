---
title: use_sentry_plugin
description: Use a Sentry plugin
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
so.envir: onsite
---

# Using the basic Sentry plugin

For us to use [the plugin that we have developed][1], first we have to tell NetServer that we have a Plugin that will add to the existing functionality. We have to do this through the config file of our application.

Below is the section that we have to modify in the config file.

```XML
<Factory>
  <DynamicLoad>
    <add key="SentryPlugin" value="C:\\TestApps\\Sentry Plugin\\Sentry
    Plugin\\bin\\Debug\\Sentry Plugin.dll" />
  </DynamicLoad>
</Factory>
```

This tells NetServer that there is Plugin and where the DLL is located. When NetServer loads its DLLs, our Plugin DLL will also be loaded.

The sentry rules will automatically be applied to NetServer and passed along to the client. SuperOffice will respond to the changed table-rights by disabling the **Edit** button.

## Code

[!code-csharp[CS](includes/use-basic-plugin.cs)]

## Walk-through

Here we can see that we have not done anything special to turn on the sentry plugin. We have created a contact entity and filled some basic properties. We have given a department name that ends with `_` **so that our Plugin will be activated**.

Here we have logged in with a particular user and as per NetServer standards, the creating user will be the owner of the record.

Then we have retrieved `TableRight` object for the contact entity. This is where our Plugin will be fired and our logic goes into action. If we can remember in our Plugin we do not modify the rights if the logged.-in user is the owner of the record so now our logic will not be executed. The normal NetServer defined sentry rules will apply.

Now if we check for the rights of the table, it should be `HasUpdate` true. Below is a screenshot of the watch window of the Visual Studio IDE for the variables `hasUpdate` and `info`. As we can see `hasUpdate` is true.

![01][img1]
Now let’s log in with a different user and retrieve the earlier created contact entity. When we check the update rights we get picture like this:

![02][img2]

Here we can see that `hasUpdate` is false. This is because our logic has gone into action and it has modified the rights of the table.

What happens behind the scene is: when we retrieve the saved contact entity, the NetServer sentry mechanism will get fired. The sentry mechanism will execute our plugins. The first method that will get executed in our Plugin will be `ModifySelect`, since when we retrieve a contact entity NetServer will start executing its own sentry systems. It will gather the columns that are needed for sentry and since we have said that we want to modify and add the department column to its sentry column list it will do so. Then it will jump on to the `ModifyTableRights` method and execute its logic. So now the logged-in user is not the owner of the record and the department name ends with `_` it will modify the rights and give us only read rights.

Now to verify things, let's log in with the owner of the record again in this case user **SAL0**. The picture will change to this:

![03][img3]

So now we can see that our logic is working and we can add our own sentry mechanism on top of what NetServer already has.

<!-- Referenced links -->
[1]: create-sentry-plugin.md

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/image002.jpg
[img3]: media/image003.jpg
