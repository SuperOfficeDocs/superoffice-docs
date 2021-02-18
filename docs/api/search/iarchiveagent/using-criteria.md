---
# Mandatory fields.
title: iarchiveagent_multi_criteria
description: How to use multiple criteria with the IArchiveAgent
author: {github-id}             # Your GitHub alias.
keywords: 
so.topic: howto                # article, howto, reference, concept, guide
so.date:
so.category: 
so.area: api-services

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to use multiple criteria with the IArchiveAgent

We have previously seen [how to set a single archive restriction][1] to limit the number of rows returned by the agent.

The following code segment was used to set a condition to display `Person` information such as `fullName`, `firstName`, and `personNumber` of those who have a `ContactId`, equal to 2.

[!code-csharp[CS](includes/iarchiveagent-person.cs?range=14)]

Since the `ArchiveAgent` method requires an array of `ArchiveRestrictionInfo` we would have to create an array of the specific type as above and we may include as many restrictions to the array as we want.

For example, if we want to retrieve a list of persons whose `ContactId` is equal to 2 and whose `fullName` begins with "U" the above statement can be modified:

```csharp
ArchiveRestrictionInfo[] archiveRest = new ArchiveRestrictionInfo[2];
archiveRest[0] = new ArchiveRestrictionInfo("contactid", "=", "2");
archiveRest[1] = new ArchiveRestrictionInfo("fullName", "begins", "U");
```

In this case, the output will be rows that match both the above restrictions. It is possible to add any number of restrictions on which the archive result should be based on.

## Output

The output after execution is something similar to this:

```text
personId        firstName contactId           personNumber  academic  position  fullName
[I:210]         Chandana  [I:124]             10214                           Chandana Dushamali
[I:211]         Manoj     [I:124]             10215                           Manoj Udayanage
[I:212]         Chrishani [I:124]             10216                           Chrishani Bannahakke
[I:213]         Asanga    [I:124]             10217                           Asanga Buthpitiya
[I:214]         Thusitha  [I:124]             10218                           Thusitha Asiri
[I:215]         Ravindra  [I:124]             10219                           Ravindra Perera
[I:216]         Chamini   [I:124]             10220                           Chamini Rangedara
```

<!-- Referenced links -->
[1]: iarchiveagent.md
