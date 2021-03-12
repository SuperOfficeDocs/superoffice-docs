---
# Mandatory fields.
title: run_scripts       # (Required) Very important for SEO.
description: Three ways to deploy and run scripts # (Required) Important for SEO.
author: Tony Yates
so.date: 04.15.2009
keywords:
so.topic: howto                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite              # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# Three ways to deploy and run scripts

## Single function

The simplest form of scripting is the single function script. This is accomplished by adding a text file that contains a single method declaration with the correct extension (.cs or .vb) into the scripting folder. The following code demonstrates this technique. The example demonstrates manipulating the name and department of the contact after it is retrieved from the database, but before it is returned to the client.

**Example AfterGetContactEntity single function script:**

```csharp
public static void AfterGetContactEntity(int contactId, ref ContactEntity contact, ref object state)
{
    contact.Name += "(added by script)";
    contact.Department += "(ScriptDemo)";
}
```

## Full class

Another option is to write a full class and deploy it as a file. This allows you to structure your code better, as well as the option to refer to other assemblies.

When writing a full class file, you must add the keyword `$FullClass` at the top of the file. You can also add references to other assemblies that contain types used by this class by adding the `$ReferencedAssembly` keyword; followed by the full path to the referenced assembly. You must also have a `static void Main` method. This is a framework requirement.

**A full class example that demonstrates changing the name and department of a contact:**

```csharp
//$FullClass
//$ReferencedAssembly: C:\\MyAssemblies\\SuperOffice.Services.dll
using System;
using System.Text;
using System.Windows.Forms;
using SuperOffice.CRM.Services;
namespace MyScriptClass
{
    public static class CSharpScript
    {
        static void Main() { }
        public static void BeforeGetContactEntity(int contactId, ref object state)
        {
            //Do  Magic Here
        }
        public static void AfterGetContactEntity(int contactId, ref ContactEntity contact, ref object state)
        {
            contact.Name += "(Magic)";
            contact.Department += "(Scripted)";
        }
    }
}
```

## Assembly

Neither single function files, nor class files, are easy to debug. To be able to debug your scripts you must pre-compile them into a standalone assembly. As long as the versions referred to in your assembly comply with the running SuperOffice web version all you need to do is drop the DLL into the script folder. By adding the pdb file as well, debugging should be a piece of cake.

## Permissions

Just as a reminder, you will need to ensure that the IIS process has read permissions on the scripting folder. That is generally the ASP.NET and Network Service accounts. In most cases, setting the `APPPOOL\YourAppPoolName` permissions will work.

The image below demonstrates setting the `apppool` permissions.

![x][img3]

## Video References

* [Scripting in the Web World][1]
* [Web Client and Interactive NetServer Web Service Scripts][2]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/developer/videos/video-player/?videoId=138
[2]: https://community.superoffice.com/en/developer/videos/video-player/?videoId=841

<!-- Referenced images -->
[img1]: media/netserverservicescripting_750.png
[img2]: media/scriptingsetup.png
[img3]: media/permissions2.png
