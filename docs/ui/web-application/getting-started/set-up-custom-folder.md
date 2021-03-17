---
title: webapp_custom_config
description: How to use custom config files (and folder)
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: howto
so.client: web
so.envir: onsite
---

# How to use custom config files (and folder)

The config files are updated whenever you repair, re-install, or upgrade the application. This means that any changes you make disappear. To avoid having to manually patch these files, you can place your customization in a separate folder. This folder won’t be touched by the installer – leaving your customizations in place during an upgrade.

> [!NOTE]
> This folder will **mirror** the *App_Data* folder (including sub-folders), allowing you to override it with your custom files.

1. Add a custom path to the *web.config* file.
2. Create a new folder to hold your custom files.

## Web.config

You need to add a custom path to the client config provider section in the *web.config* file.

```XML
<ClientConfigurationProvider>
  <add key="CacheConfigurations" value="false" />
  <add key="FilePath" value="C:\\Program Files\\SuperOffice\\SuperOffice CRM.web\\Example\\App\_Data" />
</ClientConfigurationProvider>
```

1. Locate the **ClientConfiguratonProvider** section.
2. Add the following line:
    `<add key="CustomPath" value="C:\\Program Files\\SuperOffice\\SuperOffice CRM.web\\Example\\App\_Custom" />`

## Custom folder

1. Create a new folder to hold your custom files.
2. Inside, replicate the sub-folders of *App_Data*.

For example, *App_Data* contains a *WebClient* folder. Therefore your *App_Custom* folder must contain a corresponding *WebClient* folder. The *WebClient* folder contains a *Web* folder that contains the config files. Your *App_Custom\WebClient* folder needs to have a *Web* folder for your custom config files.

![01][img1]

## Custom config files

You can now place your customized config files into this folder, and SuperOFfice will load the custom config files instead of the standard config files **if they are present**.

You can only replace files – you can’t replace parts of a config file – so you still need to check if there are changes you want to merge over from the standard config files after an upgrade – but hopefully, that is easier than patching in your changes every time there is an upgrade.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/image001.jpg
