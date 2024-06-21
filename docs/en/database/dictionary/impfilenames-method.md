---
title: ImpFileNames method
uid: impfilenames_method
description: Continuous database ImpFileNames method
author: Tony Yates
date: 06.23.2017
keywords: database
topic: concept
---

# ImpFileNames method

**IMP files** are a means to populate a table with priming data once the `DictionaryStep` has completed performing any schema changes defined in the `Structure` method.

The sole purpose of `ImpFileNames()` is to return a list of filenames containing data that Continuous Database will discover and import.

```csharp
public override List<string> ImpFileNames()
{
  // these are the .IMP files
  return new List<string>
  {
    @"I_ChatRoom.imp",
  };
}
```

Dictionary steps can provide IMP files is one of two ways:

* As a physical file located in the same location as the executing assembly.
* As an embedded resource in the same assembly as the DictionaryStep.

If using the physical file means, understand the resource resolver will begin in the executing directory, and then look for a folder called *ImpFiles*. It expects to find your imp files inside this folder. That said, Embedded resource files are the preferred method, and must be structured in the following way.

![x][img1]

To ensure your IMP files are embedded as a resource select the file to display the IMP file properties, then set the Build Action property to Embedded Resource.

![x][img2]

When compiled, the embedded resource file is a structure in the following format:

`ProjectName.ImpFiles.DictionaryName._StepNumber.Files.Filename.imp`

In a de-compiler, the embedded resource will appear in the assembly *Resources* folder.

![x][img3]

While embedded resource files are the preferred way to supply priming data, it’s also possible to discover IMP files that exist in the current directory from which the application applying the step resides. The advantage of embedded resources is easy deployment: there is only one file, the compiled assembly, that is needed; and thus the chance of deployment failures due to missing IMP files is eliminated.

> [!WARNING]
> If you are using Visual Basic, or some .NET language other than C#, know that the compiler might not embed resources the same as shown above. We know that the Visual Compiler ignores the folders when naming the embedded resource.

Below is an image of a Visual Basic project with an embedded resource with the same folder structure as shown above.

**Visual Basic *Project* folder structure:**

![x][img4]

When compiled, the Visual Basic compiler writes the resources differently than the C# compiler.

**Compiled Visual Basic resources:**

![x][img5]

To solve this, if you are using Visual Basic projects to manage your dictionary steps, you must change the filename so that it is written in such a way that Continuous Database can discover it.

By changing the name of the file, regardless of the folder structure, the embedded resource will be named accordingly.

![x][img6]

As seen in the following image, the folder structure didn’t matter and the filename matches that which the Continuous Database resource resolver can find.

![x][img7]

As stated earlier, we believe embedded resources are the best way to manage your import files.

## Internationalization and localization

Tables can be populated with language-specific data from IMP files that are in language-specific folders.

The folder structure must be the same as before, where IMP files are placed in a folder called *Files*, only now there must be a language-code named subfolder where the preferred IMP files reside.

The language-specific file structure becomes:

`ProjectName.ImpFiles.DictionaryName._StepNumber.Files.LangCode.Filename.imp`

![x][img8]

Looking at the image with language folders, you can see two language-specific folders with two IMP files in each, one for Danish and one for US English.

During execution, the pipeline determines which file is used based on which language was selected during the installation of SuperOffice. During an installation, or upgrade to SuperOffice 8.1, SuperOffice inserts what the preferred language is as a record in the `ProductVersion table`.

| ProductionVersion | ownerName | codeName | version |
| `productVersion_id` | SuperOffice | databaselanguage | US |

With this information, the underlying database management routine knows from which folder the correct language-specific data is used.

When `ImpFileNames` returns a list of IMP filenames, the preferred language is used to search first for a folder with a name that matches, and contains a file with that name. Files with a matching name in the language folder take precedence. Therefore, if an IMP file with the same name resides in both the language folder and root Files folder, only the one that resides in the language folder is used.

[Learn more about IMP file format][1]

<!-- Referenced links -->
[1]: imp-file-format.md

<!-- Referenced images -->
[img1]: media/image008.png
[img2]: media/image009.png
[img3]: media/image010.png
[img4]: media/image011.png
[img5]: media/image012.png
[img6]: media/image013.png
[img7]: media/image014.png
[img8]: media/image015.png
