---
uid: help-nl-role-edit
title: Rol bijwerken
description: Een rol bewerken.
keywords: rol, gebruikersbeheer
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: 
  - /nl/admin/user-management/learn/role/editing-role
  - /nl/admin/user-management/learn/role/deleting-role
language: nl
---

# Rol bijwerken

[!include[Requirement](../includes/note-anon-req.md)]

Om een [rol][3] bij te werken of te verwijderen, selecteer je eerst de rol op het tabblad **Medewerkers** of **Externe**.

1. [!include[Open Roles](../includes/open-roles.md)]

1. Kies het tabblad **Medewerkers** of **Extern**.

    [De rol voor anonieme gebruikers bewerken.][1]

1. Dubbelklik in de lijst op de rol die u wilt bewerken.

## Een rol bewerken

1. In het dialoogvenster **Nieuwe rol maken** kunt u de naam en de beschrijving van de rol wijzigen. Klik vervolgens op **Opslaan**.

1. [Bewerk de rechten van de rol.][4]

1. Rollen bewerken voor medewerkers: ga naar het tabblad **Functionele rechten** en bewerk de functionele rechten van de rol.

    [!include[How to set functional rights](../includes/add-remove-right.md)]

    De wijzigingen worden automatisch opgeslagen.

## Een rol verwijderen

Wanneer u een rol verwijdert, moet u de gebruikers met die rol verplaatsen naar een andere rol. U moet er dan ook voor zorgen dat de gebruikers de juiste toegang hebben tot de rol waarnaar u ze verplaatst.

> [!NOTE]
> Je kunt de rol voor anonieme gebruikers of de systeemgebruikersrol (**Gebruikersniveau 0**) niet verwijderen.
>
> **U kunt de verwijdering van een rol niet ongedaan maken.**

1. Met de rol geselecteerd, klik op **Verwijd.**.

    Is de knop Verwijderen uitgeschakeld (grijs)? U kunt de rol waartoe u zelf behoort niet verwijderen. Als er nog maar één rol over is, kunt u deze niet verwijderen.

1. Klik in het dialoogvenster **Rol verwijderen** op <i class="ph ph-caret-down" aria-label="Chevron"></i> naast het veld **Alle gebruikers met deze rol toewijzen aan** en selecteer een andere rol voor de gebruikers van de rol die u wilt verwijderen.

1. Klik op **Verwijd.**.

    * De rol wordt verwijderd uit de lijst.

<!-- Referenced links -->
[1]: ../onsite/other-users.md#rights
[3]: index.md
[4]: set-data-rights-for-role.md
