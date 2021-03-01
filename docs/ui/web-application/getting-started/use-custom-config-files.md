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

# Config file customization

The CRM.web config files are updated whenever you repair or re-install or upgrade the CRM.web application. This means that any changes you make disappear.

To avoid having to manually patch the CRM.web config files, you can place your customization in a separate folder. This folder won’t be touched by the installer – leaving your customizations in place during an upgrade.

## Web.config

You need to add a custom path to the client config provider section in the *web.config* file.

```XML
<ClientConfigurationProvider>
  <add key="CacheConfigurations" value="false" />
  <add key="FilePath" value="C:\\Program Files\\SuperOffice\\SuperOffice CRM.web\\Example\\App\_Data" />
</ClientConfigurationProvider>
```

Add this line to the `ClientConfiguratonProvider`:

`<add key="CustomPath" value="C:\\Program Files\\SuperOffice\\SuperOffice CRM.web\\Example\\App\_Custom" />`

## Custom folder

Make a new folder to hold your custom files – this folder will mirror the *App_Data* folder, allowing you to override *App_Data* with your own custom files.

For example, *App_Data* contains a *WebClient* folder. Therefore your *App_Custom* folder must contain a corresponding *WebClient* folder.

The *WebClient* folder contains a *Web* folder that contains the config files. Your *App_Custom\WebClient* folder needs to have a Web folder for your custom config files.

![01][img1]

## Custom config files

You can now place your customized config files into this folder – and the CRM.web will load the custom config files instead of the standard config files if they are present.

You can only replace files – you can’t replace parts of a config file – so you still need to check if there are changes you want to merge over from the standard config files after an upgrade – but hopefully, that is easier than patching in your changes every time there is an upgrade.

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image001.jpg
