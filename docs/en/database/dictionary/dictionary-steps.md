---
title: Dictionary steps
uid: cdd_steps
description: Dictionary steps
date: 06.23.2017
keywords: database
topic: concept
# envir:
# client:
---

# Dictionary steps

A dictionary step is responsible for defining a list of schema changes and optionally importing priming data. Schema changes are actions, such as a new table, new fields in an existing table, new indexes, and many more.

![Database model][img1]

Each dictionary step is uniquely identified by its **name** and **step number** combination. While the name is generally associated with a product name or feature, the step number is usually equal to an iteration. The step number is used to indicate in which order each dictionary step is applied to the database model to ensure includes all necessary changes a present and accounted for.

The dictionary step **description** should represent a general description of what changes are performed by the dictionary step.

## Examples

Let’s look at an example: Suppose a vendor called Uno creates a dictionary step that adds a string field to the contact table that is to be 25 characters in length. As seen in the figure below, the initial dictionary step number to perform that action is defined as having a `StepNumber` set to 1. Next, suppose Uno decides to change the string field property to support 255 characters in length. The third-party must then define a new dictionary step that sets the `StepNumber` to 2.

![x][img2]

A second example is when there are 2 third-party integrations that make database schema changes. In addition to the previously mentioned Uno, third-party Duo comes along and adds a field to the contact table. Duo’s dictionary step must be uniquely named and the step number is then 1.

![x][img3]

The dictionary step state property is used to indicate whether this dictionary step is an *InDevelopment* or *Released* state.

> [!NOTE]
> Third-parties must respect each other and only change tables and fields they have created themselves. Third parties should also do their best to prevent field naming collisions and use a suitable prefix for their tables and fields.

## Apply steps

The process of making changes to the database is called **Application of dictionary steps**. Since dictionary steps contain actions such as "Add field" or "Add table", applying them means making that change – simultaneously – to the database model and the physical database. The steps themselves are not stored in the database (only their names and numbers, for tracking purposes).

* A dictionary step can only be applied once.
* Steps with the same name are applied strictly consecutively (no gaps).
* Each chain of steps that share a name has to start with step 1.

The result of applying steps is a changed database schema, and a corresponding `DatabaseModel` that describes that schema, so the code can know what the database now looks like.

## Uninstall

**Uninstalling** a `DictionaryStepInfo` from the model is accomplished by creating a `DictionaryStep` with the `StepNumber` set to `Integer.MaxValue`, or 2147483647. It's your responsibility to implement the class and completely remove all structural changes every made by your dictionary step.

## Step implementation

So far, the explanation of a dictionary step has only included the concept of what it is and how it contributes towards smooth evolutionary database design. So how are they defined? On one hand, there is the definition of the dictionary step, and on the other hand, there is the implementation.

In terms of API dependencies, third-parties must **create a .NET assembly** that references 2 SuperOffice assemblies for Continuous Database:

* *SuperOffice.CD.DSL.dll*
* *SuperOffice.CD.DSL.Implementation.dll*

![x][img6]

Soon, there will be a NuGet package called `SuperOffice.ContinuousDatabase` to obtain these assemblies. Until then, just get them from the `SuperOffice.NetServer.Core` package, or any installation of SuperOffice (Win, Web, or web services).

Third-parties must create a class decorated with a `DictionaryAttribute` attribute, and the class must inherit from the base class `DictionaryStep`. Both the `DictionaryAttribute` and `DictionaryStep` base class are defined in *SuperOffice.CD.DSL.dll*.

A third-party is expected to override and implement at least one of three primary methods:

| Method | Description |
|---|---|
| `Structure` | tables are created, modified, or dropped in the database and model. |
| `ImpFileNames` | performs priming data import after Structure is complete. |
| `CustomPriming` | performs unique priming data actions or data transformations after `ImpFileNames` is complete, using direct SQL statements. |

![x][img4]

> [!NOTE]
> Only implement the methods that have actual content: don't create empty overrides as that leads to degraded performance during upgrades.

### Example

Below is an example DictionaryStep that overrides the `Structure` and `ImpFileNames`.

[!code-csharp[CS](includes/dictionary-step.cs)]

## What can I change ?

The DictionaryStep is conceptually a pipeline to:

* Perform schema changes.
* Add priming data.
* Transform table data.

![x][img5]

While none of the methods are required, each routine presents an opportunity to make database changes. Whether physical schema changes, priming data-related, or simply data transformation in the database, actions done in the pipeline are a means to ensure an agile and evolutionary database design.

<!-- Referenced images -->
[img1]: media/image003.png
[img2]: media/step-1.png
[img3]: media/step-2.png
[img4]: media/image006.png
[img5]: media/image007.png
[img6]: media/cdd-architecture.png
