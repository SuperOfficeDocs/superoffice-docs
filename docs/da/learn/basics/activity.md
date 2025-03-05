---
uid: help-da-activity
title: Aktiviteter
description: Aktiviteter i SuperOffice CRM
author: SuperOffice RnD
date: 01.17.2025
version: 10.5
keywords: aktivitet
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Aktiviteter

![Aktiviteter i SuperOffice CRM -screenshot][img3]

## Typer

Der findes to hovedtyper af aktiviteter – dokumenter og opfølgninger. Derudover vises udsendelser, formularindsendelser og chatposter i detaljekortet **Aktiviteter**.

* [Opfølgninger][1]
  * <i class="ph ph-calendar-blank" aria-hidden="true"></i> Møde (aftale)
  * <i class="ph ph-calendar-blank" aria-hidden="true"></i> Opfølgning (samtale)
  * <i class="ph ph-calendar-check" aria-hidden="true"></i> Skal udføres (opgave)
* [Dokumenter][4]
  * <i class="ph ph-files" aria-hidden="true"></i> Dokument (breve og andre dokumenter)
  * <i class="ph ph-at" aria-hidden="true"></i> E-mail
* <i class="ph ph-target" aria-hidden="true"></i> [Udsendelser][3] (masseudsendelser via flettedokument, e-mail eller SMS)
* <i class="ph ph-chat-teardrop-text" aria-hidden="true"></i> [Chatposter][12]
* <i class="ph ph-rows" aria-hidden="true"></i> Formularindsendelser

## Hvor finder jeg aktiviteter?

[Detaljekortet Aktiviteter][18] er tilgængeligt i skærmbillederne Firma, Person, Projekt, Salg og Dagbog.

> [!NOTE]
> Aktiviteter vises også i de [forskellige visninger][7] i skærmbilledet Dagbog.

## <a id="view"></a>Vis aktiviteter

De viste aktiviteter afhænger af de filtre, du vælger nederst på detaljekortet. Du kan vise alle aktiviteter eller kun en bestemt type. Klik på **Filter**-knappen (<i class="ph ph-funnel" aria-hidden="true"></i>) for at [filtrere aktiviteter][17] efter dato og bruger.

![Detaljekortet Aktiviteter viser filtreringsmuligheder for forskellige posttyper -screenshot][img4]

## Kolonner

Aktivitetslisten indeholder følgende oplysninger:

* Den første kolonne angiver, om aktiviteten er **Udført**. Et flueben (<i class="ph ph-check" aria-hidden="true"></i>) betyder, at aktiviteten er afsluttet, mens en tom boks betyder, at den ikke er udført.

* Kolonnen **Kategori** viser ikoner, der angiver aktivitetstypen, for eksempel en kalender for et møde. Disse ikoner afspejler teksten i kolonnen **Type**.

* De øvrige kolonner viser forskellig information om aktiviteten. Hvis ikke al tekst i et felt er synlig, kan du holde musen over feltet for at få vist en infoboks.

## Opret aktivitet

Du kan oprette aktiviteter via menuen **Ny** i toplinjen eller ved at klikke på knappen **Tilføj** i detaljekortet.

## <a id="delete"></a>Slet aktivitet

Du kan slette aktiviteter fra ethvert skærmbillede, hvor de vises:

1. Vælg én eller flere aktiviteter, du vil slette.

2. Højreklik på den eller de valgte aktiviteter, og vælg **Slet**.

3. Når du bliver bedt om at bekræfte sletningen, klikker du på **Ja**.

[!include[Deleting items](../includes/tip-deletion.md)]

## Præferencer <i class="ph ph-user-circle" aria-label="Kontaktikon"></i>

Når en aktivitet er afsluttet, fjernes den fra aktivitetslisten dagen efter. Som standard viser detaljekortet **Aktiviteter** opgaver, som ikke er udført pr. dags dato.

### Vis fremtidige opgaver

1. Gå til **Personlige indstillinger** > **Præferencer**.
2. Vælg **Funktioner**, og find indstillingen **Vis dage forude**.
3. Angiv, hvor mange dage frem du ønsker at se aktiviteter. For eksempel vil indtastning af "7" her vise opgaver for den næste uge.

### Fjern aktivitet fra listen, når den er udført

1. Gå til **Personlige indstillinger** > **Præferencer**.
2. Vælg **Visuelle effekter**.
3. Opdater [præferencen][2] **Fjern afsluttede aktiviteter**.

### Fremhæv forfaldne aktiviteter

Hvis en aktivitet vises med rød tekst, betyder det, at dens forfaldsdato er passeret. For at ændre denne indstilling:

1. Gå til **Personlige indstillinger** > **Præferencer**.
2. Vælg **Funktioner**.
3. Opdater præferencen **Marker forfaldne aktiviteter**.

## Relateret indhold

* [Filtrer aktiviteter][17]
* [Ændr status til Udført for en aktivitet][10]
* [Tilføj opfølgning (møde, opgave, samtale)][8]
* [Ring til personer][11]
* [Arbejd med dokumenter][4]
* [Skriv en e-mail][5]
* [Detaljekortet Aktiviteter][18]

<!-- Referenced links -->
[1]: ../../diary/learn/follow-ups.md
[2]: ../getting-started/preferences.md
[3]: ../../marketing/mailing/learn/index.md
[4]: ../../document/learn/index.md
[5]: ../../email/learn/compose.md
[7]: ../../diary/learn/index.md
[8]: ../../diary/learn/create-follow-up.md
[10]: ../../diary/learn/change-completed-status.md
[11]: ../../contact/learn/dial.md
[12]: ../../chat/learn/index.md
[17]: ../section-tabs/filter.md
[18]: ../section-tabs/activities-tab.md

<!-- Referenced images -->
[img3]: ../../../media/loc/en/diary/activities-detail.png
[img4]: ../../../media/loc/en/learn/activities-filter.png
