---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: mapping_so_user_to_ad_v_7_1       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Jens M. Glattetre             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide
so.date: 30 Mar 2012
# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Mapping SuperOffice users to Active Directory in 7.0 SR3 and 7.1

The new implementation is based on searching in the Active Directory – rather than first looking up all groups and then loading all users in the selected group. A set of additional configuration options has been added as well. This configuration is required when the user executing SoAdmin has limited rights to the domain or if there is a complex domain infrastructure in place. This will typically be the case in large organizations, organizations with multiple domain controllers, when using hosting providers or in Citrix environments.

This advanced configuration has to be tweaked manually in the SuperOffice.config file. These settings are not added by default when installing the Windows client, so they have to be added manually.

The SuperOffice.config is a SuperOffice NetServer .NET Application Configuration file. Always keep a copy of your SuperOffice.config file before editing and using a tool like Notepad++ that gives syntax highlighting for XML files is always recommended when editing these files. The editor must be run as administrator when User Account Control (UAC) is enabled.

![image][img1]

The SoAdmin.exe administration client uses user-administration implemented within NetServer. This implementation is plug-in based and the plug-in implementing the Active Directory support is called ActiveDirectoryCredentialPlugin. Two areas of the SuperOffice.config file need to be modified to provide a detailed configuration for this plugin.

The first part is to declare the existence of this configuration section. This has to be added within the SuperOffice `<sectionGroup>` declaration. A new section group security and a new section `ActiveDirectoryCredentialPlugin` have to be added.

```xml
<sectionGroup name="Security">
  <section name="ActiveDirectoryCredentialPlugin"
           type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
</sectionGroup>
```

![image][img2]

Secondly, the actual configuration has to be added as well.

![image][img3]

| Key | Description |
|-----|-------------|
| Domain | The domain to use when looking up users. A value for this need to be provided when this is different from the domain of the logged-in user. The domain needs to be provided when logging in as a local user. |
| User | The user to use when looking up in this domain. This is required when the logged-in user has insufficient privileges on the domain. |
| Password | Required when providing user. |
| Container | Introduced in 7.1 RC, see explanation below. |

SuperOffice NetServer uses the Microsoft .NET library System.DirectoryServices.AccountManagement when searching Active Directory. The minimum required permissions to Active Directory is Read and List content. The best way to verify that the right permissions are available is to use the ADSI Edit Snap-in to MMC.

![image][img4]

You can select the root note of Active Directory, Properties, Advanced, and Effective Permissions, select the user that is accessing Active Directory and verify that the user has List content and Read permissions.

![image][img5]

SuperOffice 7.1 (from RC and beyond) has additional improvements. Some of the error messages are replaced by warnings logged by NetServer. Support for specifying container is introduced as well.

Logging warnings to a file must be turned on to see the warnings produced by NetServer. Logging warnings to file should be the first action if a problem with Active Directory integration is observed.

The first step is to make sure that `LogWarning` is turned on

![image][img6]

Then the logging to file needs to be turned on to a folder where the logged-in user has write permissions.

![image][img7]

If something goes wrong like if an invalid user is specified, a log file with today’s date will be produced.

![image][img8]

The error message returned from the system will be in this file:

```text
Level: Warning
At: 14:58:50
Element:
Message: Logon failure: unknown user name or bad password.
```

Customers have experienced situations with complex domain infrastructures where the Container property has to be specified as well – even if the user is to access the domain at the root level. The Container can also be used to limit the surface area of Active Directory made available to SoAdmin.

Limiting users to a particular organization unit can be an example of this.

![image][img9]

By specifying the full name of this Organization Unit in the SuperOffice.config file, searches will be restricted to this node.

![image][10]

<!-- Referenced images -->
[img1]: media/1642-1987.jpg
[img2]: media/1644-1989.jpg
[img3]: media/1646-1991.jpg
[img4]: media/1648-1993.jpg
[img5]: media/1650-1995.jpg
[img6]: media/1652-1997.jpg
[img7]: media/1654-1999.jpg
[img8]: media/1656-2001.jpg
[img9]: media/1658-2003.jpg
[img10]: media/1660-2005.jpg