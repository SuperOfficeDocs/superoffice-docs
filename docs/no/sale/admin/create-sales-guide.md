---
uid: help-no-sales-guide-create
title: Opprette en ny salgsguide
description: Slik lager du en salgsguide i SuperOffice
keywords: opprette salgsguide, ny salgsguide, salgsguide, guide, arbeidsflyt, salg
author: Bergfrid Dias
date: 02.03.2025
version: 10.5.2
topic: howto
license: salespremium
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
---

# Opprette en ny salgsguide

[!include[Må være administrator](../../learn/includes/req-admin.md)]

I **Innstillinger og vedlikehold** kan du definere hvilke salgstyper som skal tilknyttes en salgsguide, samt hvilke faser og aktiviteter salgsguidene skal inneholde. Utseendet til en salgsguide kan derfor variere.

Den beste måten å definere din egen arbeidsflyt på er først og fremst å diskutere og bli enige om beste praksis i salgsprosessen. Du kan opprette flere salgstyper med guider hvis firmaet ditt bruker mer enn én salgsprosess. For eksempel kan du ha en salgstype med guide for kundeemner, en for eksisterende kunder og en for langsiktige salgsprosesser som inneholder mange faser og aktiviteter.

Denne veiledningen viser deg hvordan du oppretter en salgsguide fra bunnen av.

1. Definer [faser](#create-stages) som skal inngå i salgsguiden.
2. Definer [salgstypen](#create-type) (med tilknyttede faser) som salgsguiden skal kobles til.
3. Utform [salgsguiden](#create-guide).

## <a id="create-stages"></a>Opprette faser for salgsguiden

En salgsguide må være knyttet til en salgstype, som igjen består av flere faser. [Slik oppretter du faser][2].

For eksempel kan en salgsguide for salg til nye kunder inkludere fasene **Første møte**, **Tilbud** og **Kontraktssignering**.

Gå til neste trinn for å koble fasene til en salgstype.

## <a id="create-type"></a>Opprette en salgstype for salgsguiden

En salgsguide må være knyttet til en salgstype. [Slik oppretter du en salgstype][3].

Eksempler på salgstyper: "Salg til ny kunde", "Salg til eksisterende kunde", "Kryssalg til eksisterende kunde".

1. Merk av for **Denne salgstypen er tilknyttet en guide**.
1. Velg minst to faser.
1. Gå til neste trinn for å opprette salgsguiden.

## <a id="create-guide"></a>Opprette en salgsguide

Etter at du har opprettet faser og definert en salgstype for salgsguiden, kan du designe selve guiden ved å legge til oppfølginger og/eller dokumenter for hver fase.

1. Klikk på <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Arbeidsflyt** i navigatoren.

2. Velg fanen **Salgsguide**.

3. I listen øverst velger du salgstypen du vil opprette en salgsguide for. De tilknyttede fasene vises nedenfor.

    * Hvis salgstypen ikke er satt opp med en salgsguide, klikk på **Klikk her for å aktivere guide**.

    * Hvis det ikke er definert faser for salgstypen, klikk på **Klikk her for å legge til faser**. Du kan også redigere salgstypen ved å klikke på **Rediger**-knappen øverst.

4. Velg ønsket fase i listen. Fasedetaljene vises nederst i bildet.

5. [Legg til én eller flere oppfølginger](#add-fo-stage) for den valgte fasen.

    Du trenger ikke å legge til et dokument for hver fase, men det anbefales å ha minst én oppfølging per fase.

6. [Legg til ett eller flere dokumenter](#add-doc-stage) for den valgte fasen.

7. Gjenta trinn 4-6 for hver fase du vil legge til oppfølginger og dokumenter for.

Endringene lagres automatisk. Salgsguiden blir nå synlig i SuperOffice CRM når det opprettes et salg med den valgte salgstypen.

## <a id="add-fo-stage"></a>Legge til en oppfølging for en fase

1. Velg ønsket salgstype og fase som beskrevet ovenfor.

2. Klikk på **Legg til** under **Foreslåtte oppfølginger i denne fasen**.

3. I dialogboksen **Foreslått oppfølging** skriver du inn et beskrivende navn for oppfølgingen i feltet **Navn**.

4. I feltet **Formålet med denne oppfølgingen** skriver du inn en hjelpetekst som vises i detaljkortet **Salgsguide** i SuperOffice CRM.

    > [!NOTE]
    > Noen av alternativene nedenfor er ikke relevante for den første oppfølgingen i en salgsguide.

5. Merk av for **Foreslå denne oppfølgingen automatisk** hvis du vil at SuperOffice CRM skal foreslå denne oppfølgingen når den forrige oppfølgingen (i denne eller forrige fase) er merket som utført.

6. Velg en type for oppfølgingen i listen **Oppfølgingstype**.

7. I feltet **Startdato** angir du hvor mange dager det skal være mellom forrige oppfølging og denne.

8. I feltet **Varighet** angir du hvor lenge oppfølgingen skal vare (format: *0 t 00 m*).

9. I feltet **Standardbeskrivelse av oppfølgingen** kan du legge inn en forhåndsdefinert beskrivelse.

    > [!TIP]
    > Brukeren kan endre infoen over etter behov.

10. Klikk på **Lagre**.

11. Gjenta prosedyren for å legge til flere oppfølginger i denne eller andre faser.

### Eksempel på oppfølging

**Salgstype**: Salg til ny kunde
**Fase**: Første møte
**Navn** på oppfølging: Første møte
**Formål med denne oppfølgingen**: Se på behovene til den potensielle kunden, og vurdere om produktet ditt kan dekke kundens behov
**Oppfølgingstype**: Kundemøte
**Varighet**: 1 time
**Standardtekst**:

Agenda for første møte:

\- Informasjon om kundens virksomhet og organisasjon
\- Behov, ønsker, problemer
\- Firmapresentasjon
\- Annet

## <a id="add-doc-stage"></a>Legge til et dokument for en fase

1. Velg ønsket salgstype og fase som beskrevet ovenfor.

2. Klikk på **Legg til** under **Foreslåtte dokumenter i denne fasen**.

3. I dialogboksen **Foreslått dokument** skriver du inn et beskrivende navn for dokumentet i feltet **Navn**.

4. I feltet **Formålet med dette dokumentet** skriver du inn hjelpeteksten som vises i detaljkortet **Salgsguide**.

5. Velg ønsket [mal][4] i feltet **Mal**.

6. Skriv inn en **Standardoverskrift** for dokumentet.

7. Angi eventuelt en referanse i feltet **Vår ref.** (for eksempel en [malvariabel][1] for salgstittel eller salgsnummer).

8. Klikk på **Lagre**.

9. Gjenta prosedyren hvis du vil legge til flere dokumenter i denne eller andre faser.

### Eksempel på et dokument

**Salgstype**: Salg til ny kunde
**Fase**: Første møte
**Navn** på dokument: Møtebekreftelse
**Formål med dette salgstrinnet**: Send en e-post med møtebekreftelse og dato/klokkeslett til alle deltakerne for det første møtet.
**Mal**: E-post
**Standardoverskrift**: Møtebekreftelse (første møte)

<!-- Refererte lenker -->
[1]: ../../document/templates/variables/for-sales.md
[2]: sale-stage.md
[3]: sale-type.md
[4]: ../../document/templates/learn/index.md
