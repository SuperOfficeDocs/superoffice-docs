---
uid: help-no-project-guide-create
title: Opprett en ny prosjektguide
description: Slik oppretter du en ny prosjektguide i SuperOffice
keywords: opprett prosjektguide, ny prosjektguide, prosjektguide, guide, arbeidsflyt, prosjekt
author: SuperOffice RnD
date: 01.03.2025
version: 10
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
---

# Opprett en ny prosjektguide

[!include[Må være administrator](../../learn/includes/req-admin.md)]

I **Innstillinger og vedlikehold** definerer du hvilke prosjekttyper som skal være tilknyttet en prosjektguide, og hvilke statuser og aktiviteter prosjektguidene skal inneholde. Hvordan en prosjektguide ser ut kan derfor variere.

For eksempel kan du ha en prosjekttype kalt **Konferanse**. Denne prosjekttypen kan være knyttet til en prosjektguide som inneholder følgende statuser, oppfølginger og dokumenter:

| Status | Oppfølginger | Dokumenter |
|---|---|---|
| Planlagt | Planleggingsmøte (Møte inne) | Konferanseprogram (Notat) |
| Under arbeid | Opprett liste over prosjektdeltakere (Oppgave); Konferanse (Møte ute) | Konferanseinvitasjon (Brev) |
| Lukking | Evalueringsmøte (Møte inne) | Evalueringsrapport (Notat) |

Denne veiledningen viser hvordan du oppretter en prosjektguide fra bunnen av.

1. Definer [statusene](#create-stage) som skal inkluderes i prosjektguiden.
2. Definer [prosjekttypen](#create-type) (med tilhørende statuser) som prosjektguiden skal knyttes til.
3. Utform [prosjektguiden](#create-guide).

![Gå til Arbeidsflyt-seksjonen og opprett dine egne prosjektrutiner i SuperOffice CRM -screenshot][img2]

## <a id="create-stage"></a>Opprett statuser for prosjektguiden

En prosjektguide må være knyttet til en prosjekttype, som igjen består av flere statuser. [Slik oppretter du en status][2].

For eksempel kan en prosjektguide for et konferanseprosjekt ha statusene **Planlagt**, **Under arbeid** og **Lukking**.

Gå til neste trinn for å koble statusene til en prosjekttype.

## <a id="create-type"></a>Opprett en prosjekttype for prosjektguiden

En prosjektguide må være knyttet til en prosjekttype. [Slik oppretter du en prosjekttype][3].

Eksempler på prosjekttyper: "Konferanse", "Kampanje", "Internt".

1. Merk av for **Denne prosjekttypen er tilknyttet en guide**.
1. Velg minst to statuser.
1. Gå til neste trinn for å opprette prosjektguiden.

## <a id="create-guide"></a>Opprett en prosjektguide

Når du har opprettet statuser og angitt en prosjekttype for prosjektguiden, kan du utforme selve prosjektguiden ved å legge til oppfølginger og/eller dokumenter for hver status.

1. Klikk <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Arbeidsflyt** i navigatoren.

2. Gå til fanen **Prosjektguide**.

3. I listen **Prosjekttype**, velg prosjekttypen du vil opprette en prosjektguide for. Statusene som er valgt for denne prosjekttypen, vises i listen over.

    > [!NOTE]
    > Hvis prosjekttypen ikke er satt opp med en prosjektguide, klikk linken **Klikk her for å aktivere guide** nederst på skjermen.
    >
    > Hvis det ikke er definert statuser for prosjekttypen, klikk linken **Klikk her for å legge til statuser** nederst på skjermen. Du kan også redigere prosjekttypen ved å klikke **Rediger** øverst.

4. Velg ønsket status i listen. Statusens detaljer vises nederst på skjermen.

5. [Legg til en eller flere oppfølginger for statusen](#add-fo-status).

    > [!NOTE]
    > Du trenger ikke legge til et dokument for hver status, men du bør legge til minst én oppfølging for hver status.

6. [Legg til ett eller flere dokumenter for statusen](#add-doc-status).

7. Gjenta trinn 4-6 for hver status du vil legge til oppfølginger og dokumenter for.

Endringene lagres automatisk. Prosjektguiden vil nå være tilgjengelig i SuperOffice CRM når et prosjekt opprettes med prosjekttypen valgt i trinn 2.

## <a id="add-fo-status"></a>Legg til en oppfølging for en status

1. Velg ønsket prosjekttype og status som beskrevet ovenfor.

2. Klikk på **Legg til** under **Foreslåtte oppfølginger i denne status**.

3. I dialogboksen **Foreslått oppfølging**, skriv inn navnet på oppfølgingen i feltet **Navn**. Dette bør være et beskrivende navn.

4. Skriv inn formålet med oppfølgingen i feltet **Målsetningen med denne oppfølgingen**. Denne teksten vises når du holder musepekeren over oppfølgingen i detaljkortet **Prosjektguide** i SuperOffice CRM.

    > [!NOTE]
    > Noen av alternativene nedenfor er av logiske årsaker ikke aktuelle for den første oppfølgingen i en prosjektguide.

5. Merk av for **Overfør oppfølgingen til en prosjektdeltaker** for å kunne tildele oppfølgingen til en av prosjektdeltakerne. Når prosjektansvarlig oppretter oppfølgingen i SuperOffice CRM, kan vedkommende velge en av medarbeiderne sine som eier av oppfølgingen.

6. Merk av for **Milepæloppfølging** hvis oppfølgingen skal defineres som en milepæl.

7. Velg en type for oppfølgingen i listen **Oppfølgingstype**.

8. I feltet **Startdato**, angi når oppfølgingen skal starte (antall dager fra i dag).

9. I feltet **Varighet**, angi hvor lenge oppfølgingen skal vare (format: *0t00m*).

10. I feltet **Standardbeskrivelse av oppfølgingen**, skriv inn en beskrivelse.

    > [!TIP]
    > Brukeren kan endre informasjonen ovenfor etter behov.

11. Klikk **Lagre**.

12. Gjenta denne prosedyren for å legge til flere oppfølginger.

### Eksempel på en oppfølging

* **Prosjekttype**: Konferanse
* **Status**: Planlagt
* **Navn på oppfølging**: Planleggingsmøte
* **Målsetningen med oppfølgingen**: Hold et møte for å planlegge konferansen og sette opp et program.
* **Oppfølgingstype**: Møte inne
* **Varighet**: 1 time
* **Standardbeskrivelse**:

Planleggingsmøte:

\- Hva bør konferansen inneholde?
\- Deltakere?
\- Foredragsholdere?
\- Hvor?

## <a id="add-doc-status"></a>Legg til et dokument for en status

1. Velg ønsket prosjekttype og status som beskrevet ovenfor.
2. Klikk **Legg til** under **Foreslåtte dokumenter i denne status**.
3. I dialogboksen **Foreslått dokument**, skriv inn dokumentets navn i feltet **Navn**. Dette bør være et beskrivende navn for dokumentet.
4. Skriv inn formålet med dokumentet i feltet **Målsetningen med dette dokumentet**. Denne teksten vises når du holder musepekeren over dokumentet på detaljkortet **Prosjektguide** i SuperOffice CRM.
5. Velg ønsket [mal][4] i feltet **Mal**.
6. Skriv inn en overskrift i feltet **Standardoverskrift**.
7. Eventuellt, angi en referanse i feltet **Vår ref.**, for eksempel en [malvariabel][1] for prosjektnummer, -tittelm eller et annet felt som har med prosjektet å gjøre.
8. Klikk **Lagre**.
9. Gjenta prosedyren for å legge til flere dokumenter.

### Eksempel på et dokument

* **Prosjekttype**: Konferanse
* **Status**: Planlagt
* **Navn**: Konferanseprogram
* **Målsetning**: Utforme et program for konferansen.
* **Mal**: Notat
* **Standardoverskrift**: Konferanseprogram

## Relaterte innhold

* [Redigere eller deaktivere en prosjektguide][5]

<!-- Refererte lenker -->
[1]: ../../document/templates/variables/from-project-card.md
[2]: project-status.md
[3]: project-type.md
[4]: ../../document/templates/learn/index.md
[5]: edit-project-guide.md

<!-- Refererte bilder -->
[img2]: ../../../media/loc/en/project/create-project-guide.png
