---
uid: help-nl-user-other
title: Andere gebruikers beheren
description: Anonieme gebruikers en systeemgebruikers beheren (op locatie)
keywords: anonieme gebruiker, systeemgebruiker, Andere gebruikers
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
deployment: onsite
platform: web
index: true
redirect_from: 
  - /nl/admin/user-management/learn/other-users
  - /nl/admin/user-management/learn/role/edit-rights-for-anonymous-users
language: nl
---

# Anonieme gebruikers en systeemgebruikers beheren (op locatie)

* **Systeemgebruiker**: Systeemgebruikers kunnen zich via toepassingen van derden bij het systeem aanmelden en hebben alle rechten.
* **Anoniem**: Anonieme gebruikers hebben rechten op basis van de [rol voor anonieme gebruikers](#rights). Normaalgesproken is het niet nodig meer dan een anonieme gebruiker in te stellen.

> [!NOTE]
> Anonieme gebruikers en systeemgebruikers hebben de [SuperOffice Expander Services][1]-systeemlicentie nodig en kan worden beheerd op het tabblad **Andere gebruikers**.
>
> 1. Selecteer <i class="ph ph-user" aria-hidden="true"></i> **Gebruikers** in de Navigator.
> 1. Selecteer het tabblad **Andere gebruikers**. De weergegeven lijst bevat bestaande anonieme gebruikers en systeemgebruikers.

## Anonieme gebruiker of systeemgebruiker toevoegen

1. klik op **Toevoegen** onder de lijst.

1. Voer een ID in het veld **Gebruikers-ID** in.

1. Typ desgewenst een wachtwoord voor de gebruiker in het veld **Wachtwoord**.

1. Typ, voorzover van toepassing, een beschrijving van de gebruiker in het vak **Beschrijving**.

1. Selecteer **Type**: **Systeemgebruiker** of **Anoniem**

1. Selecteer **Actief** rechts van **Aanmelden** om de gebruiker te activeren.

1. Klik op **Opslaan**. De gebruiker wordt nu toegevoegd aan de lijst.

## Anoniem gebruiker of systeemgebruiker bewerken

1. Dubbelklik in de lijst op de gebruiker die u wilt bewerken.

1. Breng de gewenste wijzigingen aan in het dialoogvenster dat wordt weergegeven.

1. Klik op **Opslaan** om af te sluiten.

## <a id="rights"></a>Rechten voor anonieme gebruikers bewerken (lokaal)

Er is slechts een enkele rol voor anonieme gebruikers en alleen de gegevensrechten voor die rol kunnen worden bewerkt.

1. [!include[Open Roles](../includes/open-roles.md)]

1. Selecteer het tabblad **Anoniem**.

1. [Voer de gegevensrechten in op het tabblad **Gegevensrechten**][2].

De wijzigingen worden automatisch opgeslagen.

## Aanmeldrechten wijzigen voor andere gebruikers

Als een anonieme gebruiker of een systeemgebruiker geen aanmeldrechten meer mag hebben, kunt u die rechten verwijderen. De externe gebruiker wordt niet verwijderd maar gedefinieerd als inactief, zodat deze desgewenst later weer kan worden geactiveerd.

### Een gebruiker deactiveren

1. Selecteer in de lijst de actieve gebruiker voor wie u de aanmeldrechten wilt verwijderen en klik op **Aanmelding verwijderen** onder de lijst.

    Deze gebruiker kan zich nu niet meer bij het systeem aanmelden.

### Een gebruiker activeren

1. Dubbelklik in de lijst op de gebruiker die u wilt activeren.
1. Selecteer **Actief** rechts van **Aanmelden** om de gebruiker te activeren.
1. Klik op **Opslaan**. Deze gebruiker kan zich vervolgens bij het systeem aanmelden.

## Anonieme gebruiker of systeemgebruiker verwijderen

1. Selecteer de gebruiker die u wilt verwijderen.
1. Klik op de knop **Verwijderen**. De gebruiker wordt verwijderd uit de lijst.

<!-- Referenced links -->
[1]: ../../license/expander-services.md
[2]: ../role/set-data-rights-for-role.md
