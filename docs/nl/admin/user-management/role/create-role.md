---
uid: help-nl-role-create
title: Rol maken
description: Rol maken
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
redirect_from: /nl/admin/user-management/learn/role/create-role
language: nl
---

# Een rol maken

[!include[Requirement](../includes/note-anon-req.md)]

1. [!include[Open Roles](../includes/open-roles.md)]

1. Selecteer een van de volgende tabbladen:

    * **Medewerkers**: hier kunt u rollen toevoegen voor medewerkers binnen uw bedrijf.
    * **Extern**:  Hier kunt u rollen toevoegen voor externe gebruikers (alleen lokaal).

    > [!NOTE]
    > Er is slechts een enkele rol voor anonieme gebruikers en u kunt geen nieuwe rol maken. Zie [Rechten voor anonieme gebruikers bewerken][8].

1. Klik op **Toevoegen** onder de lijst.

1. Voer in het dialoogvenster **Nieuwe rol maken** een naam in voor de rol in het veld **Rolnaam**.

1. Voer een beschrijving van de rol in het veld **Beschrijving** in.

1. Selecteer een van de volgende opties:

    * Klik op <i class="ph ph-caret-down" aria-label="Chevron"></i> naast het vak **Rechten kopiëren van** en selecteer de rol waarop u de nieuwe rol wilt baseren.
    * Klik op <i class="ph ph-caret-down" aria-label="Chevron"></i> en selecteer **Beginnen met blanco rechten** om een geheel nieuwe rol te maken.

1. Klik op **Opslaan**. De nieuwe rol wordt weergegeven in de lijst **Rollen**.

1. Klik op de rolnaam in de lijst om de rechten van de rol weer te geven op het tabblad **Gegevensrechten**.

1. [Voer de gegevensrechten in op het tabblad **Gegevensrechten**][7].

1. Rollen maken voor medewerkers: Klik op het tabblad **Functionele rechten**.

    Via dit tabblad kunt u bepalen welke functies beschikbaar moeten zijn voor de rol, bijvoorbeeld samenvoegbewerkingen, publiceren, selecties exporteren en beheerdersrechten in Instellingen en onderhoud.

    > [!TIP]
    > Plaats de muisaanwijzer op een recht om informatie erover weer te geven.

1. Stel de [functionele rechten][6] van de rol in:

    [!include[How to set functional rights](../includes/add-remove-right.md)]

    De wijzigingen worden automatisch opgeslagen.

## Gerelateerde inhoud

* [Gebruikers toevoegen][5]
* [Rollen bewerken][4]

<!-- Referenced links -->
[4]: update-role.md
[5]: ../add-associate.md
[6]: functional-rights.md
[7]: set-data-rights-for-role.md
[8]: ../onsite/other-users.md#rights
