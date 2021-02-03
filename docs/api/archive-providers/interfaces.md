---
# Mandatory fields.
title: archive_provider_interface       # (Required) Very important for SEO.
description: Interface definition and composition # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Interface definition and composition

The high-level interfaces for the archive provider system are shown in the following figure.

![archive provider system high-level interfaces][img1]

There are several points to make about this diagram (which, incidentally, is sometimes used to test prospective new developers):

* The `IArchiveProvider` interface is the one that the outside world relates to. As the names suggest, it defines an archive provider as something that has rows, columns, and entities.

* Internally, the interface is composed of fragments or aspects, that each define a smaller piece of functionality. The reason for this way of defining interfaces is that different aspects are useful in different contexts. For example, it is meaningful to talk about columns without talking about rows in some cases.

* In the diagram, the leftmost column consists of the basic aspects, which do not inherit from anything else. Each interface defines one independent kind of functionality that various components of the provider system implement.

* The center-right column defines interfaces that are implemented by concrete classes. Note that in addition to inheriting various left-side aspects, these interfaces also add some properties and methods of their own. This is because the center-right interfaces are meant to represent something it is useful to implement, while the left-side interfaces are more abstract and are meant to be independent of implementation - they hide that which the client does not need to know, while the center-right interfaces add stuff that any reasonable implementation requires.

* It is quite possible to write a class that implements `IArchiveProvider` directly, with or without the use of various helper classes. Such implementations exist, both internally and externally. However, most concrete archive providers use NetServer to access the SuperOffice database through queries - and for those, the `IArchiveQueryProvider` and `IArchiveMultyQueryProvider` interfaces are more useful as an implementation basis.

* `IArchiveExtend` captures the extensibility dimension of the archive provider system. An archive provider can **extend another** provider, by implementing the `IArchiveProviderDoesExtent` interface. This works if the parent provider itself implements `IArchiveProviderExtensible`, which makes available the hooks needed to modify the parents' query.

* A component that implements `IArchiveExtender` is itself extensible, extends some parent provider, and (through `IArchiveHasColumns`) adds columns to the final data set of the complete provider. This interface is the basis for the vast majority of the current code.

* Finally, everything except for the left-hand column inherits the `IPlugin` interface, signaling that these are NetServer plugins. The essence here is that the SuperOffice-written code is not privileged relative to partner extensions, and the whole system is from the ground up designed to be extensible, internally and externally.

**Continue reading:** [Data classes][1]

<!-- Referenced links -->
[1]: data-classes.md

<!-- Referenced images -->
[img1]: media/image001.jpg
