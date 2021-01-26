---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: cdd_steps       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Dictionary steps # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:            # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Dictionary steps

A dictionary step is responsible for defining a list of schema changes and optionally importing priming data. Schema changes are actions, such as a new table, new fields in an existing table, new indexes and many more.

![Database model][img1]

Each dictionary step is uniquely identified by its **name** and **step number** combination. While the name is generally associated with a product name or feature, the step number is usually equal to an iteration. The step number is used to indicate in which order each dictionary step is applied to the database model to ensure includes all necessary changes a present and accounted for.

The dictionary step **description** should represent a general description of what changes are performed by the dictionary step.

## Examples

Let’s look at an example. Suppose a vendor called Uno creates a dictionary step that adds a string field to the contact table that is to be 25 characters in length. As seen in the figure below, the initial dictionary step number to perform that action is defined as having a StepNumber set to 1. Next, suppose Uno decides to change the string field property to support 255 characters in length. The third-party must then define a new dictionary step that sets the StepNumber to 2.

![x][img2]

A second example is when there are 2 third-party integrations that make database schema changes. In addition to the previously mentioned Uno, third-party Duo comes along and adds a field to the contact table. Duo’s dictionary step must be uniquely named and the step number is then 1.

![x][img3]

The dictionary step state property is used to indicate whether this dictionary step is an *InDevelopment* or *Released* state.

> [!NOTE]
> Third-parties must respect each other and only change tables and fields they themselves have created. Third parties should also do their best to prevent field naming collisions and use a suitable prefix for their tables and fields.

The process of making changes to the database is called **Application of dictionary steps**. Since dictionary steps contain actions such as "Add field" or "Add table", applying them means making that change – simultaneously – to the database model and the physical database. The steps themselves are not stored in the database (only their names and numbers, for tracking purposes).

A dictionary step can only be applied once; steps with the same name are applied strictly consecutively (no gaps); each chain of steps that share a name has to start with step 1.

The result of applying steps is a changed database schema, and a corresponding DatabaseModel that describes that schema, so the code can know what the database now looks like.

## Implementation

So far, the explanation of a dictionary step has only included the concept of what it is and how it contributes towards smooth evolutionary database design. So how are they defined? On one hand, there is the definition of the dictionary step, and on the other there is the implementation.

In terms of API dependencies, third-parties must create a .NET assembly that references two SuperOffice assemblies for Continuous Database:

* SuperOffice.CD.DSL.dll
* SuperOffice.CD.DSL.Implementation.dll

Third-parties must create a class decorated with a `DictionaryAttribute` attribute, and the class must inherit from the base class `DictionaryStep`. Both the `DictionaryAttribute` and `DictionaryStep` base class are defined in *SuperOffice.CD.DSL.dll*.

A third-party is expected to override and implement at least one of three primary methods:

| Method | Description |
|---|---|
| Structure | tables are created, modified or dropped in the database and model. |
| ImpFileNames | performs priming data import after Structure is complete. |
| CustomPriming | performs unique priming data actions or data transformations after ImpFileNames is complete, using direct SQL statements. |

![x][img4]

Below is an example DictionaryStep that overrides the `Structure` and `ImpFileNames`.

CDD Example Step

[!code-csharp[CS](includes/dictionary-step.cs)]

Only implement the methods that have actual content, i.e. do not create empty overrides as that leads to degraded performance during upgrades.

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
