---
uid: help-nl-freetext-search-configure
title: Zoekcriteria opgeven
description: Zoekcriteria opgeven
author: Bergfrid Dias
date: 03.24.2023
keywords: vrije tekst, zoeken
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Zoekcriteria opgeven voor een zoekopdracht in vrije tekst

U kunt zoekcriteria opgeven voor zowel losse woorden (bijvoorbeeld *Peter*) als voor fragmenten die bestaan uit meerdere woorden (bijvoorbeeld *Jan Peter Brouwers*).

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Controleer of [zoeken op vrije tekst is ingeschakeld][1].

1. Schakel een van de volgende opties in voor **Operator voor zoeken naar Ã©Ã©n woord**:

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

<!-- Referenced links -->
[1]: enable.md

<!-- Referenced images -->
