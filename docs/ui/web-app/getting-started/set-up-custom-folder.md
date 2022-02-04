---
title: How to use custom config files (and folder)
uid: webapp_custom_config
description: How to use custom config files (and folder)
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: howto
so.client: web
so.envir: onsite
---

# How to use custom config files (and folder)

Customizing the web client is all made possible by modifying application XML SuperOffice Markup Language (SOML) files. To begin, it's as easy as navigating to the applications *App_Data* folder and opening one of the *.config* files that requires customizing. From click-actions to UI windows there are virtually limitless client customization capabilities.

With regards to modifying existing application files, there are downsides to this approach. The config files are replaced whenever you repair, re-install, or upgrade the application. This means that any changes you make, all direct customizations, disappear.

To avoid having to manually patch these files, you can place your customization in a separate folder. This folder won’t be touched by the installer – leaving your customizations in place during an upgrade.

These override files are then discovered and incorporated at runtime. The **client configuration provider** solves this problem.

You should never add your own config files to the standard configuration path. Always use your own custom path. You should also separate your own custom paths from other modifications as well.

> [!NOTE]
> This folder will **mirror** the *App_Data* folder (including sub-folders), allowing you to override it with your custom files.

To set up your custom folder:

1. Add a custom path to the *web.config* file.
2. Turn off caching.
3. Create a new folder to hold your custom files.

> [!TIP]
> While developing you should always turn off caching.

## Web.config

You need to add a custom path to the [ClientConfigurationProvider section][1] in the *web.config* file. The key must start with "CustomPath". Multiple entries are allowed, but the key must be unique.

```XML
<ClientConfigurationProvider>
  <add key="CacheConfigurations" value="false" />
  <add key="FilePath" value="C:\\Program Files\\SuperOffice\\SuperOffice CRM.web\\Example\\App\_Data" />
  <add key="CacheConfigurations" value="false" />
</ClientConfigurationProvider>
```

1. Locate the **ClientConfiguratonProvider** section.

2. Add the following line to set you path:

    ```xml
    <add key="CustomPath" value="C:\\Program Files\\SuperOffice\\SuperOffice CRM.web\\Example\\App\_Custom" />
    ```

3. Turn off caching:

    ```xml
    <add key="CacheConfigurations" value="false" />
    ```

## Custom folder

1. Create a new folder to hold your custom files.
2. Inside, replicate the sub-folders of *App_Data*.

For example, *App_Data* contains a *WebClient* folder. Therefore your *App_Custom* folder must contain a corresponding *WebClient* folder. The *WebClient* folder contains a *Web* folder that contains the config files. Your *App_Custom\WebClient* folder needs to have a *Web* folder for your custom config files.

![01][img1]

**Pattern:**

`c:\MyPath\MyFiles\[applicationname]\[instancename]\[mynamedfolder]\Myconfig.config`

For example, based on a standard installation of the web client:

`C:\MyPath\MyFiles1\WebClient\Web\CustomSeven\SoCustomSevenPage.config`
`C:\MyPath\MyFiles2\WebClient\Web\CustomSeven\SoCustomSevenPage.config`

### Sub-folders

Inside the custom path directory, there must be a structured set of folders following the convention:

`<CustomPath>[applicationname][instancename]\`

Where **applicationname** and **instancename** defaults are WebClient and Web, which may or may not be explicitly defined in the `Client` element.

```xml
<Client applicationname="WebClient" instancename="Web">
  ...
</Client>
```

This default application configuration folder *App_Data* has the same structure and is where all standard configuration files are installed. The *.config files in these folders make up the entire structure of the web client.

![Web client configuration folder][img2]

Inside the *WebClient\Web* folders, the structure is not important. All sub-folders are searched for configuration files, so it's up to your personal preference. The following approaches demonstrate a few possibilities.

**Approach 1:**

```text
C:\WebClient\Common\WebClient\Web\SoApplicationConfiguration.config
C:\WebClient\Common\WebClient\Web\SoArchiveLists.merge
C:\WebClient\Common\WebClient\Web\SoMenuConfiguration.config
```

**Approach 2:**

```text
C:\WebFeature\MyFiles\WebClient\Web\Inventory\SoCustomInventoryPage.config
C:\WebFeature\MyFiles\WebClient\Web\Inventory\SoCustomInventoryDialog.config
C:\WebFeature\MyFiles\WebClient\Web\Inventory\SoCustomInventoryMenus.merge
```

**Approach 3:**

```text
C:\Thirdparty\MyFiles\WebClient\Web\Pages\SoThirdPartyPage.config
C:\Thirdparty\MyFiles\WebClient\Web\Pages\SoCustomContactPage.merge
C:\Thirdparty\MyFiles\WebClient\Web\Dialogs\SoThirdPartyDialogPage.config
C:\Thirdparty\MyFiles\WebClient\Web\Scripts\CustomScripts.js
```

## Custom config files

You can now place your customized config files into this folder, and SuperOFfice will load the custom config files instead of the standard config files **if they are present**.

The files placed in the custom folder will automatically be preferred by the web-client over the standard configuration files. All ".config" files will override existing files in the client. All ".merge" files will be merged into the standard configuration files specified within the merge file.

You can only replace files – you can’t replace parts of a config file – so you still need to check if there are changes you want to merge over from the standard config files after an upgrade – but hopefully, that is easier than patching in your changes every time there is an upgrade.

<!-- Referenced links -->
[1]: ../../../../data-access/docs/netserver/config/clientconfigurationprovider.md

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/web-client-configuration-file-folders.png
