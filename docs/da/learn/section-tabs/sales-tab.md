---
uid: help-da-section-tab-sales
title: Salg-fanen
description: Lær hvordan du administrerer og ser salgsinformation i Salg-detaljekortet i SuperOffice CRM, herunder tilføjelse af salg, filtrering og opfølgning på salgsaktiviteter på tværs af firmaer, personer og projekter.
keywords: Salgs-fanen, Salgsfanen, fanen Salg, detaljekortet Salg, detaljekort, salgsarkiv
author: Bergfrid Skaara Dias
date: 02.25.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Salgsfanen

Detaljekortet **Salg** i SuperOffice CRM giver brugere mulighed for at se og administrere [salgsinformation][1] relateret til specifikke enheder såsom firmaer, personer, projekter og dagbog. Det viser en liste over alle salg, der er knyttet til en enhed, hvilket gør det nemt at holde styr på aktiviteter i kontekst og få dybere indsigt i salgsydeevne og kommende handlinger.

![Detaljekortet Salg -screenshot][img1]

## Tilgængelighed af Salgsfanen

Detaljekortet **Salg** er tilgængeligt for:

| Enhed | Beskrivelse af detaljekortet |
|---|---|
| [Firma][9] | Viser alle salg knyttet til firmaet. |
| [Person][10] | Viser salg knyttet til personen, herunder detaljer som status, beløb og næste trin. |
| [Dagbog][11] | Giver et overblik over salg med vægt på planlagte aktiviteter og salgsfremgang. |
| [Projekt][13] | Viser salg knyttet til projektet og fremhæver relaterede aktiviteter og kommende opfølgninger. |

## <a id="columns"></a>Kolonner i Salgsfanen

Detaljekortet **Salg** indeholder følgende kolonner til at vise nøgleinformation om hvert salg:

| Kolonne | Beskrivelse |
|---|---|
| Udført | Afkrydsningsfelt, der angiver, om salget er gennemført. Et afkrydset felt (<i class="ph ph-check" aria-hidden="true"></i>) betyder udført, mens et tomt felt betyder, at det stadig er i gang. |
| Statusikon | Viser den aktuelle [status for salget][4], f.eks. solgt, tabt eller udsat. |
| Salgsdato | Datoen knyttet til salget, som kan være estimeret, solgt eller tabt dato. |
| Beløb | Salgets økonomiske værdi. |
| Fase | Den nuværende fase af salgsprocessen. |
| Næste aktivitet | Dato for næste planlagte opfølgning eller salgsaktivitet. Datoen repræsenterer den ældste opfølgning, der endnu ikke er afsluttet. For at få flere detaljer eller identificere den næste opfølgning skal du dobbeltklikke på salget for at åbne Salgs-skærmen. Opfølgningen kan ses i detaljekortet **Aktiviteter** for salget. |
| Navn | Navnet på salget. |
| Ejer | Personen tilknyttet salget. |
| Firma | Firmaet, som salget er knyttet til. |
| Bruger-ID | Brugeren, der har registreret salget. |
| ERP-rabat | Viser rabatoplysninger, hvis SuperOffice CRM er forbundet med et ERP-system. |

[!include[Conf. columns](../includes/tip-configure-columns.md)]

## Se salg i Salg-fanen

1. Gå til den relevante skærm, som f.eks. Firma, Person, Projekt eller Dagbog.

1. Klik på detaljekortet **Salg** for at se alle salg, der er knyttet til enheden.

1. Dobbeltklik på et salg i listen for at åbne Salg-skærmen og se detaljeret information.

### Filtrer salg

Du kan filtrere listen over salg efter dato, bruger eller gruppe ved at klikke på **Filter**-knappen (<i class="ph ph-funnel" aria-hidden="true"></i>). Dette hjælper dig med at fokusere på specifikke salgsaktiviteter, der kræver opmærksomhed.

### Inkluder interessenter

For at inkludere salg, hvor det aktuelle firma eller personen er involveret som en [interessent][3], markér **Medtag interessenter** nederst på detaljekortet. Dette giver et bredere overblik over alle salgsaktiviteter relateret til enheden.

## Salgsassistent

Detaljekortet **Salg** fungerer som en **salgsassistent** for at hjælpe dig med at holde styr på igangværende salgsaktiviteter. Det fungerer som en salgsorienteret opgaveliste, og giver et overblik over:

* **Uafsluttede salg:** Alle igangværende salg, hvor salgsdatoen falder inden for det definerede visningsområde.

* **Planlagte salgsaktiviteter:** Alle salg med planlagte aktiviteter for et specifikt antal dage frem.

    > [!NOTE]
    > Antallet af dage frem er brugerdefineret. For at ændre denne indstilling, gå til **Personlige indstillinger** > **Præferencer** > **Funktioner** > **Vis kommende dage**.

* **Forfaldne aktiviteter:** Alle salg med aktiviteter, der har overskredet deres slutdato (slutdato tidligere end i dag). Disse salg er markeret med rødt for nem identifikation.

* **Udsatte salg:** Hvis et salg er markeret som [stoppet][4] og har en genåbningsdato, vil denne dato overskrive datoen i feltet **Næste aktivitet** og blive vist i kolonnen **Næste aktivitet**.

Denne visning hjælper brugerne med at holde styr på igangværende handlinger, så intet falder igennem, hvilket forbedrer salgsstyringen.

## Tilføj salg

For at oprette et nyt salg direkte fra detaljekortet **Salg**:

1. Vælg **Tilføj** for at åbne salgsoprettelsesdialogen.

1. Indtast salgsdetaljerne: Udfyld de nødvendige felter og klik **Gem**.

## Yderligere tips

* **Hurtig navigation:** Brug [Navigatoren][7] for hurtigt at skifte mellem forskellige enheder og deres tilsvarende **Salg**-faner.

## Relateret indhold

* [Hvordan tilføjer man et salg][2]
* [Administrere interessenter i salg][3]
* [Filtrer aktiviteter og salg][8]
* [Gruppér kolonner og opsummér beløb][5]

<!-- Referenced links -->
[1]: ../../sale/learn/index.md
[2]: ../../sale/learn/create.md
[3]: ../../sale/learn/stakeholders/index.md
[4]: ../../sale/learn/update.md#stalled
[5]: configure-columns.md#calculate
[7]: ../getting-started/main-screen/navigator.md
[8]: filter.md
[9]: ../../company/learn/index.md#section-tabs
[10]: ../../contact/learn/index.md#section-tabs
[11]: ../../diary/learn/index.md#section-tabs
[13]: ../../project/learn/index.md#section-tabs

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/sale-detail.png
