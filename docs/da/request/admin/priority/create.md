---
uid: help-da-request-priority-create
title: Opret prioritet
description: Opret prioritet
keywords: sag, prioritet, opret prioritet, tilføj prioritet, ny prioritet, eskaleringshændelser, eskaleringskæde
author: Hanne Gunnarsson
date: 03.07.2025
version: 10.5.2
topic: howto
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Opret sagsprioritet

Standardprioriteterne, der følger med systemet, er **Høj**, **Middel** og **Lav**. Du kan imidlertid både oprette nye prioriteter og redigere indstillingerne for eksisterende prioriteter.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Trin

1. I Indstillinger og vedligeholdelse, klik på knappen **Sager** i navigatoren, og vælg fanen **Prioriteter**.

1. Klik på knappen **Tilføj**.

1. Indtast et beskrivende navn i feltet **Prioritetsnavn**.

1. På fanen **Egenskaber** kan du angive følgende oplysninger:

    * Ekstern
    * Anvend som standard
    * Deadline
    * Slettet

    Du kan finde flere oplysninger om hvert felt under [Prioritetsindstillinger](#priority-settings).

1. Under **Tidsramme** skal du angive, hvilken tidsramme der skal gælde for sagsbehandlingen.

    * Angiv tidsintervaller for hver dag i ugen.

    * Du kan også angive dage, der skal udelades i feltet **Helligdage (dag/måned)**. Vælg **Medtag år** for at medtage året i disse datoer.

1. På fanen **Eskaleringshændelser** skal du angive, hvordan eskaleringskæden skal reagere ved forskellige hændelser i sagen. Muligheder:

    * Sag læst af ejer
    * Skiftet ejer (manuelt)
    * Nye oplysninger
    * Sag afsluttet
    * Ændret prioritet

        > [!NOTE]
        > Hvis du vælger **Fortsæt**, går sagen til samme niveau i eskaleringskæden som før ændringen. Med andre ord bliver tidspunkterne ikke brugt, hvis der er en ændring, kun niveauet.

    * Ny sag
    * Eskaler sager i henhold til tidsramme

    Du kan finde flere detaljer om hver mulighed under [Indstillinger for eskalering](#escalation-options).

1. Klik på **Gem**. Prioriteten oprettes. Nu kan du f.eks. [knytte eskaleringsniveauer til denne prioritet][1].

## <a id="priority-settings"></a>Prioritetsindstillinger

| Indstilling | Beskrivelse |
|---|---|
| Navn | Angiv et beskrivende navn på prioriteten. |
| Slettet | Er prioriteten aktiv (normal) eller slettet (ikke tilgængelig).|
| Eksternt | Hvis du markerer denne, vil prioriteten være tilgængelig fra SuperOffice Customer Centre. |
| Anvend som standard | Hvis du markerer denne, vil denne prioritet blive valgt som standard. |
| Deadline | Angiv den frist, som sager med denne prioritet bør have. Denne værdi beregnes ud fra tidsrammen for prioriteten og gemmes for hver sag. Resultatværdien angiver, når sagens tidsfrist udløber. |
| Tidsramme | Tidsintervaller for hver ugedag, der gælder for sagsbehandling. |
| Helligdage (dag/måned) | Dage, der skal udelukkes fra tidsrammen. Det bruges normalt til feriedage, hvor det ikke er ønskeligt, at sager skal eskaleres. Formatet er en kommasepareret liste med dag/måned. Hvis du f.eks. vil ekskludere 25. og 26. december, skal du indtaste følgende: 25/12, 26/12. Du kan også tilføje datoer ved hjælp af datofeltet nedenfor. |
| Medtag år | Hvis du markerer dette, medtages året i feriedatoerne. |
| Eskaler sager i henhold til tidsramme | Hvis afkrydsningsfeltet er markeret, eskaleres sager med denne prioritet kun inden for prioritetens definerede tidsramme. Eskaleringen 'fryses' i perioder, der er uden for den tidsramme, der er angivet på fanen **Tidsramme**. |

## <a id="escalation-options"></a>Indstillinger for eskalering

| Mulighed | Beskrivelse |
|---|---|
| Sag læst af ejer | Hvis du markerer denne, styres eskaleringskæden som angivet i rullemenuen til højre, når en sag læses af ejeren. I alle rullemenuerne på denne fane kan du vælge mellem handlingerne: **Stop**, **Fortsæt** og **Genstart**. |
| Skiftet ejer (manuelt) | Hvis du markerer denne, styres eskaleringskæden som angivet i rullemenuen til højre, når en sag manuelt skifter ejer. |
| Nye oplysninger | Hvis du markerer denne, styres eskaleringskæden som angivet i rullemenuen til højre, når der kommer nye informationer til en sag. F.eks. at kunden eller brugeren tilføjer en ny meddelelse i sagen. |
| Sag afsluttet | Hvis du markerer denne, styres eskaleringskæden som angivet i rullemenuen til højre, når en sag afsluttes. |
| Ændret prioritet | Hvis du markerer denne, styres eskaleringskæden som angivet i rullemenuen til højre, når prioriteten for en sag erstattes med denne prioritet. |
| Ny sag | Hvis du markerer denne, styres eskaleringskæden som angivet i rullemenuen til højre, når en ny sag med denne prioritet kommer ind i systemet. |

<!-- Referenced links -->
[1]: escalation-levels.md

<!-- Referenced images -->
