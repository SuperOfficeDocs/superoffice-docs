---
uid: help-nl-settings-free-text-search
title: Configureren van zoeken op vrije tekst
description: Configureren van  zoeken op vrije tekst
keywords: zoeken op vrije tekst
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: nl
redirect_from:
  - /nl/admin/options/learn/freetext-search/enable
  - /nl/admin/options/learn/freetext-search/configure
  - /nl/admin/options/learn/freetext-search/index
  - /nl/search-options/admin/index
---

# Configureren van zoeken op vrije tekst

Met de functie Vrije-tekstzoekbewerking van SuperOffice CRM kunnen gebruikers overal in de toepassing zoeken naar tekst. Dit kan gaan om tekst die zij zelf hebben toegevoegd aan de database, bijvoorbeeld bedrijfsnamen, afdelingen, en tekst uit de schermen Contactpersoon en Document.

Met het tabblad **Vrije-tekstzoekbewerking** in Instellingen en onderhoud kunt u precies bepalen op welke manier dit werkt in SuperOffice CRM.

## Deactiveren van zoeken op vrije tekst (lokaal)

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Schakel het selectievakje **Zoeken op vrije tekst inschakelen** uit.

Standaard is zoeken op vrije tekst ingeschakeld. Als uw organisatie systeembronnen wil besparen die worden gebruikt voor het bijwerken van de vrije-tekstindex bij nieuwe gegevens, kunt u het selectievakje **Zoeken op vrije tekst inschakelen** uitschakelen. Hierdoor wordt het veld voor vrije-tekstzoekbewerking in SuperOffice CRM onsite uitgeschakeld. De vrije tekst-zoekfunctie kan niet worden gedeactiveerd voor online-/cloud-versies.

## Zoekcriteria opgeven voor een zoekopdracht in vrije tekst

U kunt zoekcriteria opgeven voor zowel losse woorden (bijvoorbeeld *Peter*) als voor fragmenten die bestaan uit meerdere woorden (bijvoorbeeld *Jan Peter Brouwers*).

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Controleer of zoeken op vrije tekst is ingeschakeld.

1. Schakel een van de volgende opties in voor **Operator voor zoeken naar één woord**:

    * **Start met**: wanneer u deze optie kiest, kan de zoekopdracht *pet* bijvoorbeeld *Peter* en *Petersen* als resultaat geven.
    * **Bevat**: wanneer u deze optie kiest, kan de zoekopdracht *eter* bijvoorbeeld *Peter* en *Petersen* als resultaat geven.
    * **100% overeenkomst**: wanneer u deze optie kiest, geeft de zoekopdracht *Peter* als resultaat enkel *Peter*.

    > [!NOTE]
    > de optie **100% overeenkomst** vergt tijdens een zoekbewerking de minste systeembronnen, de optie **Bevat** vergt de meeste.

1. Schakel een van de volgende opties in voor **Operator voor zoeken naar meerdere woorden**:
    * **Start met**: wanneer u deze optie kiest, kan de zoekopdracht *pet* bijvoorbeeld *Peter Brouwers* als resultaat geven.
    * **Bevat**: wanneer u deze optie kiest, kan de zoekopdracht *pet* bijvoorbeeld *Jan Peter Brouwers* en *Erik Petersen* als resultaat geven.
    * **100% overeenkomst**: wanneer u deze optie kiest, geeft de zoekopdracht *Jan Peter Brouwers* als resultaat enkel *Jan Peter Brouwers*.

    > [!NOTE]
    > wanneer u zoekt op fragmenten van meerdere woorden, wordt er gezocht naar alle woorden samen.

## Gerelateerde inhoud

* [Stopwoorden toevoegen][3]
* [Een vrije-tekstindex opnieuw genereren][4]

<!-- Referenced links -->
[3]: stopwords.md
[4]: regenerate-index.md

<!-- Referenced images -->
