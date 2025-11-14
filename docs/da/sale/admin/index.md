---
uid: help-da-sale-configuration
title: Administration af salgstyper, faser og guider
description: Lær, hvordan du administrerer salgsarbejdsgange i SuperOffice CRM med salgstyper, faser og guider. Konfigurer disse værktøjer i Indstillinger og vedligeholdelse for at standardisere sporing, opgaver og dokumentation.
keywords: salgsguide, salgsfase, salgstype, arbejdsgang, salg
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
language: da
index: true
---

# Administration af salgstyper, faser og guider

SuperOffice CRM giver administratorer værktøjer til at standardisere salgsarbejdsgange via **salgstyper**, **faser** og **guider**. Disse funktioner sikrer ensartet sporing af salg, opgavehåndtering og dokumenthåndtering i teamet.

Brug skærmene **Arbejdsgang** og **Lister** i **Indstillinger og vedligeholdelse** til at konfigurere og administrere disse komponenter.

## Centrale begreber og placeringer

| Term | Definition | Placering i Indstillinger og vedligeholdelse |
|---|---|---|
| Salgstype | Kategoriserer salg (f.eks. "Ny kunde" eller "Fornyelse") og knytter dem til faser og guider. | **Lister** > **Salg - Type, Faser, Tilbud** |
| Salgsfase | Sporer salgets fase (f.eks. "Tilbud" eller "Kontraktskrivning"). Defineres pr. salgstype. | **Lister** > **Salg - Fase** |
| Salgsguide | Et arbejdsgangsværktøj, der knytter faser til specifikke opfølgninger og dokumenter. | **Arbejdsgang** > **Salgsguide** |
| Valuta | En listeforekomst, der definerer tilgængelige valutaer for salgsbeløb, inklusive valutakurs og enhed. | **Lister** > **Generelt – Valuta** |
| Basisvaluta | Den primære valuta, der bruges til systemberegninger og valutakurser. | **Præferencer** > **Globale præferencer** > **System** > **Ledende valuta** |

## Tilpasning af dine salgslister

SuperOffice CRM er designet til at understøtte de salgstyper, der er almindelige for de fleste virksomheder, men der er stadig firmaer, der måske ønsker at oprette deres egne.

Afhængigt af hvilken type branche dit firma er i, kan du skræddersy systemet ved at oprette de salgslister, du har brug for.

Se på følgende lister for at se, om du vil ændre dem eller ej:

* Salg – Kilde
* Salg – Fase
* Salg – Typekategori
* Salg – Type, Faser, Tilbud

## Hvad vil du gøre?

* [Tilføj en salgsfase][3]: Definer og administrer salgsfaser som "Første møde" eller "Afslutning."
* [Tilføj en salgstype][4]: Opret kategorier som "Prospekt" og tildel relevante faser.
* [Opret en ny salgsguide][1]: Design arbejdsgange med opfølgninger og dokumenter for salgstyper.
* [Rediger eller deaktiver en salgsguide][2]: Opdater arbejdsgange eller deaktiver guider for specifikke salgstyper.
* [Administrer valutaer][5]: Tilføj valutaer eller ændr basisvalutaen, der bruges i salg.

Disse værktøjer giver administratorer mulighed for at tilpasse salgsarbejdsgange og sikre effektivitet og konsistens på tværs af teamet.

<!-- Referenced links -->
[1]: create-sales-guide.md
[2]: edit-sales-guide.md
[3]: sale-stage.md
[4]: sale-type.md
[5]: add-currency.md
