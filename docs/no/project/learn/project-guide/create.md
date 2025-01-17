---
uid: help-no-project-guide-create
title: Opprette ny prosjektguide
description: Slik lager du en ny prosjektguide i SuperOffice
author: SuperOffice RnD
so.date: 02.23.2023
keywords: prosjekt, guide, arbeidsflyt
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance

language: no
---

# Opprette ny prosjektguide

[!include[Must be admin](../../../learn/includes/req-admin.md)]

I Innstillinger og vedlikehold definerer du hvilke prosjekttyper som skal være tilordnet en prosjektguide, og hvilke statuser og aktiviteter prosjektguidene skal inneholde. Hvordan en prosjektguide ser ut, kan derfor variere, men nedenfor finner du et eksempel på hvordan et prosjekt med en prosjektguide kan se ut.

Du kan for eksempel ha en prosjekttype som heter **Konferanse**. Denne prosjekttypen kan være tilknyttet en prosjektguide som kan ha følgende statuser, oppfølginger og dokumenter:

| Status | Oppfølginger | Dokumenter |
|---|---|---|
| Planlagt | Planleggingsmøte (Møte inne) | Konferanseprogram (Notat) |
| Under arbeid | Opprett liste over prosjektdeltakere (Oppgave); Konferanse (Møte ute)) | Konferanseinvitasjon (Brev) |
| Lukking | Evalueringsmøte (Møte inne) | Evalueringsrapport (Notat) |

Denne prosedyren viser deg hvordan du lager en prosjektguide helt fra bunnen av.

1. Definer [statusene](#create-stage) som skal være med i prosjektguiden.
2. Definer [prosjekttypen](#create-type) (med tilhørende statuser) som prosjektguiden skal tilknyttes.
3. Utform [prosjektguiden](#create-guide).

![Gå til Arbeidsflyt-seksjonen og opprett dine egne prosjektrutiner i SuperOffice CRM -screenshot][img2]

## <a id="create-stage" />Opprette statuser for prosjektguiden

En prosjektguide må være knyttet til en prosjekttype, som igjen består av flere statuser. [Slik oppretter du en status][2].

En prosjektguide for et prosjekt av typen Konferanse kan for eksempel ha statusene Planlagt, Under arbeid og Lukking.

Gå til neste prosedyre for å knytte statusene til en prosjekttype.

## <a id="create-type" />Opprette prosjekttype for prosjektguiden

En prosjektguide må være knyttet til en prosjekttype. [Slik oppretter du en prosjekttype][3].

Eksempel på prosjekttyper: "Konferanse", "Kampanje", "Internt".

1. Merk av for **Denne prosjekttypen er tilknyttet en guide**.
1. Velg minst to statuser.
1. Gå til neste prosedyre for å opprette prosjektguiden.

## <a id="create-guide" />Opprette en prosjektguide

Når du har opprettet statuser og angitt en prosjekttype med prosjektguide, kan du utforme selve prosjektguiden. Det gjør du ved å legge til oppfølginger og/eller dokumenter for hver status i prosjektguiden.

1. Klikk på **Arbeidsflyt**-knappen i navigatoren (![ikon][img1]).

2. Velg fanen **Prosjektguide**.

3. Velg prosjekttypen du vil opprette prosjektguide for, i listen **Prosjekttype**. Statusene som er valgt for denne prosjekttypen, vises i listen nedenfor.

    > [!NOTE]
    > Hvis det ikke er definert at prosjekttypen skal ha prosjektguide, klikker du på **Klikk her for å tilknytte guide** nederst i bildet.
    >
    > Hvis det ikke er angitt statuser for prosjekttypen, klikker du på **Klikk her for å legge til statuser** nederst i bildet. Du kan også redigere prosjekttypen ved å klikke på **Rediger**-knappen øverst.

4. Merk ønsket status i listen. Detaljene for statusen vises nederst i bildet.

5. [Legg til én eller flere oppfølginger](#add-fo-status) for den valgte statusen.

    > [!NOTE]
    >Du trenger ikke legge til et dokument for hver status, men du bør legge til minst én oppfølging for hver status.

6. [Legg til ett eller flere dokumenter for den valgte statusen](#add-doc-status).

7. Gjenta trinn 4 til 6 for hver status du vil legge til oppfølginger og dokumenter for.

Endringene lagres automatisk. Prosjektguiden vises nå i SuperOffice CRM, hvis det blir opprettet et prosjekt med prosjekttypen valgt i trinn B.

## <a id="add-fo-status" />Legge til oppfølging for en status

1. Velg ønsket prosjekttype og status som beskrevet ovenfor.

2. Klikk på **Legg til** under **Foreslåtte oppfølginger i denne statusen**.

3. I dialogboksen **Foreslått oppfølging** skriver du inn navnet på oppfølgingen i feltet **Navn**. Dette bør være et beskrivende navn for oppfølgingen.

4. Skriv inn hva hensikten med oppfølgingen er, i feltet **Målsetningen med denne oppfølgingen**. Denne teksten vises når du holder musepekeren over oppfølgingen på detaljkortet **Prosjektguide** i SuperOffice CRM.

    > [!NOTE]
    > Noen av alternativene nedenfor er av logiske årsaker ikke aktuelle for den første oppfølgingen i en prosjektguide.

5. Merk av for **Overfør oppfølgingen til en prosjektdeltaker** hvis du vil gjøre det mulig å tildele denne oppfølgingen til en av prosjektdeltakerne. Når prosjektansvarlig oppretter oppfølgingen i SuperOffice CRM, kan vedkommende velge en av medarbeiderne sine som eier av oppfølgingen.

6. Merk av for **Milepæloppfølging** for å angi oppfølgingen som en milepæl.

7. Velg en type for oppfølgingen i listen **Oppfølgingstype**.

8. I feltet **Startdato** angir du når oppfølgingen skal starte, antall dager fra i dag.

9. I feltet **Varighet** angir du hvor lenge oppfølgingen skal vare. Formatet er *0t00m*.

10. I feltet **Standardbeskrivelse av oppfølgingen** skriver du inn en beskrivelse for oppfølgingen.

    > [!TIP]
    > Brukeren kan endre informasjonen ovenfor etter behov.

11. Klikk på **Lagre**.

12. Gjenta prosedyren hvis du vil legge til flere oppfølginger i denne eller andre statuser.

### Eksempel på oppfølging

**Prosjekttype**: Konferanse
**Status**: Planlagt
**Navn** på oppfølging: Planleggingsmøte
**Målsetningen med denne oppfølgingen**: Hold et møte for å planlegge konferansen og sette opp et konferanseprogram.
**Oppfølgingstype**: Møte inne
**Varighet**: 1 time
**Standardbeskrivelse**:

Planleggingsmøte:

- Hva bør konferansen inneholde?
- Deltakere?
- Foredragsholdere?
- Hvor?

## <a id="add-doc-status" />Legge til dokument for en status

1. Velg ønsket prosjekttype og status som beskrevet ovenfor.
2. Klikk på **Legg til** under **Foreslåtte dokumenter i denne statusen**.
3. I dialogboksen **Foreslått dokument** skriver du inn navnet på dokumentet i feltet **Navn**. Dette bør være et beskrivende navn for dokumentet.
4. Skriv inn hva hensikten med dokumentet er, i feltet **Målsetningen med dette dokumentet**. Denne teksten vises når du holder musepekeren over dokumentet på detaljkortet **Prosjektguide** i SuperOffice CRM.
5. Velg ønsket mal i feltet **Mal** (se også [Dokument - Mal][4]).
6. Skriv inn overskriften som skal brukes i dokumentet, i feltet **Standardoverskrift**.
7. Skriv eventuelt inn en referanse i feltet **Vår ref.**. For eksempel en [malvariabel][1] for prosjektnummer, prosjektnavn eller et annet felt som har med prosjektet å gjøre.
8. Klikk på **Lagre**.
9. Gjenta prosedyren hvis du vil legge til flere dokumenter i denne eller andre statuser.

### Eksempel på et dokument

**Prosjekttype**: Konferanse
**Status**: Planlagt
**Navn** på dokument: Konferanseprogram
**Målsetning med denne prosjektstatusen**: Sett opp et program for konferansen.
**Mal**: Merk
**Standardoverskrift**: Konferanseprogram

## Relatert

* [Redigere prosjektguide][5]
* [Deaktivere prosjektguide][6]

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/from-project-card.html
[2]: ../../../admin/lists/learn/project-status.md
[3]: ../../../admin/lists/learn/project-type.md
[4]: ../../../admin/lists/learn/document-template.md
[5]: edit.md
[6]: deactivate.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-workflow-active.png
[img2]: ../../../../media/loc/en/project/create-project-guide.png
