---
uid: help-no-activity
title: Aktiviteter
description: Aktiviteter i SuperOffice CRM
keywords: aktivitet
author: SuperOffice RnD
date: 01.29.2025
version: 10.5
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Aktiviteter

![Aktiviteter i SuperOffice CRM -screenshot][img3]

## Typer

Det finnes to hovedtyper aktiviteter – dokumenter og oppfølginger. I tillegg vises utsendelser, skjemainnsendinger og chatoppføringer på detaljkortet **Aktiviteter**.

* [Oppfølginger][1]
  * <i class="ph ph-calendar-blank" aria-hidden="true"></i> Møte (avtale)
  * <i class="ph ph-calendar-blank" aria-hidden="true"></i> Oppfølging (samtale)
  * <i class="ph ph-calendar-check" aria-hidden="true"></i> Oppgave
* [Dokumenter][4]
  * <i class="ph ph-files" aria-hidden="true"></i> Dokument (brev og andre dokumenter)
  * <i class="ph ph-at" aria-hidden="true"></i> E-post
* <i class="ph ph-target" aria-hidden="true"></i> [Utsendelser][3] (masseutsendelser via flettedokument, e-post eller SMS)
* <i class="ph ph-chat-teardrop-text" aria-hidden="true"></i> [Chatoppføringer][12]
* <i class="ph ph-rows" aria-hidden="true"></i> Skjemainnsendinger

## Hvor finner jeg aktiviteter?

[Aktivitetsfanen][18] er tilgjengelig i skjermene for Firma, Person, Prosjekt, Salg og Dagbok.

> [!NOTE]
> Aktiviteter vises også i de [forskjellige visningene][7] i Dagbok-skjermen.

## <a id="view"></a>Vise aktiviteter

Hvilke aktiviteter som vises, avhenger av filtrene du velger nederst i fanen. Du kan vise alle aktiviteter eller bare én type. Klikk på **Filter**-knappen (<i class="ph ph-funnel" aria-hidden="true"></i>) for å [filtrere aktiviteter][17] etter dato og bruker.

![Aktivitetsfanen viser filteralternativer for ulike posttyper -screenshot][img4]

## Kolonner

Kolonnene i aktivitetslisten inneholder følgende informasjon:

* Den første kolonnen angir om en aktivitet er **Utført**. En hake (<i class="ph ph-check" aria-hidden="true"></i>) betyr at aktiviteten er fullført, mens en tom boks betyr at den ikke er fullført.

* **Kategori**-kolonnen viser ikoner som angir aktivitetstype, for eksempel en kalender for et møte. Disse ikonene gjenspeiler teksten i **Type**-kolonnen.

* De andre kolonnene i aktivitetslisten viser ulike opplysninger om aktiviteten. Hvis ikke all tekst i et felt er synlig, kan du holde musepekeren over feltet for å se den i en infoboks.

## Opprette aktivitet

Du oppretter aktiviteter ved hjelp av **Ny**-menyen i toppraden eller ved å klikke på knappen **Legg til** i aktivitetsfanen.

## <a id="delete"></a>Slette aktivitet

Du kan slette aktiviteter fra hvilken som helst skjerm der de vises:

1. Velg én eller flere aktiviteter du vil slette.
2. Høyreklikk på de valgte aktivitetene og velg **Slett**.
3. Klikk på **Ja** for å bekrefte slettingen.

[!include[Deleting items](../includes/tip-deletion.md)]

## Preferanser <i class="ph ph-user-circle" aria-label="Personsymbol"></i>

Når en aktivitet er fullført, fjernes den fra aktivitetslisten dagen etter. Som standard viser **Aktivitetsfanen** oppgaver som ikke er fullført per dags dato.

### Vise fremtidige oppgaver

1. Gå til **Personlige innstillinger** > **Preferanser**.
2. Velg **Funksjoner** og finn alternativet **Vis dager fremover**.
3. Angi hvor mange dager fremover du vil vise oppgaver. For eksempel vil verdien 7 vise oppgaver for den neste uken.

### Fjern aktivitet fra listen når den er fullført

1. Gå til **Personlige innstillinger** > **Preferanser**.
2. Velg **Visuelle effekter**.
3. Oppdater **Fjern fullførte aktiviteter** [preferansen][2].

### Marker forfalte aktiviteter

Hvis en aktivitet er markert med rød skrift, betyr det at den planlagte datoen er passert. For å endre denne innstillingen:

1. Gå til **Personlige innstillinger** > **Preferanser**.
2. Velg **Funksjoner**.
3. Oppdater innstillingen **Marker forfalte aktiviteter**.

## Relatert innhold

* [Filtrere aktiviteter][17]
* [Endre fullført-status for en aktivitet][10]
* [Legge til oppfølginger][8]
* [Ringe til personer][11]
* [Arbeide med dokumenter][4]
* [Skrive en e-post][5]
* [Detaljkortet Aktiviteter][18] (Aktivitetsfanen)

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
