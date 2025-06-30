---
uid: help-nl-automation-macro-create
title: Een macro maken - voorbeeld van SuperOffice
description: Voorbeeld van het maken van een macro in SuperOffice.
author: SuperOffice RnD
date: 03.16.2023
keywords: script, macro
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Een macro maken - voorbeeld van SuperOffice

Veel bedrijven krijgen vaak verzoeken met betrekking tot facturering. Dergelijke verzoeken moeten rechtstreeks naar de boekhouding gaan. In plaats van elk verzoek te bewerken en de categorie en gebruiker te wijzigen, kunnen we een macro maken die al deze acties uitvoert. De macro kan worden toegewezen aan de knop **Taak** in het scherm Verzoek. Factuurvragen kunnen dus met slechts één klik aan de boekhouding worden gedelegeerd.

> [!TIP]
> Als u dit proces volledig wilt automatiseren, kunt u een e-mailfilter maken dat zoekt op het woord 'factuur' in het e-mailonderwerp en vervolgens de macro uitvoeren om het verzoek toe te wijzen aan de juiste afdeling.

We maken nu een macro gebaseerd op het bovenstaande voorbeeld.

## Stappen

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Selecteer <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** en het tabblad voor **Macro's en script**. Voer een van de volgende handelingen uit:
    * Een nieuwe macro maken: Klik op **Nieuwe macro**.
    * Een bestaande macro bewerken: Klik op de macronaam.

1. Op het tabblad **Informatie** voert u "Verzoek verzenden naar boekhouding" in het veld **Naam** in en typt u een beschrijving in het onderstaande veld.

1. Schakel de optie **Nieuw menu** in om de macro beschikbaar te maken voor de knop **Taak** in het scherm Bedrijf, het scherm Persoon, het scherm Verzoek of het tabblad **Bericht**.

1. Ga naar het tabblad **Acties** en selecteer **Actietype kiezen** > **Een verzoek wijzigen**.

1. Schakel **Categorie** in en selecteer een categorie in de lijst (bijvoorbeeld *Boekhouding*).

1. Vink **Eigenaar** aan en selecteer een gebruiker.

    > [!TIP]
    > U kunt **Automatisch toegewezen** selecteren om het systeem volgens de huidige regels voor de verdeling te laten verdelen.

1. Activeer **Intern bericht** en schrijf een kort standaardbericht naar de boekhouding over de reden waarom ze dit verzoek hebben ontvangen.

1. Klik op **OK** wanneer u klaar bent.

## Gerelateerde inhoud

* [Meer informatie over geavanceerde macrofuncties en triggers][1]

<!-- Referenced links -->
[1]: trigger.md
