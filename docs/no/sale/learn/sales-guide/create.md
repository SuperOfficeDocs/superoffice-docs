---
uid: help-no-sales-guide-create
title: Opprette ny salgsguide
description: Slik lager du en salgsguide i SuperOffice
author: SuperOffice RnD
so.date: 06.29.2022
keywords: salg, guide
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: no
---

# Opprette ny salgsguide

[!include[Must be admin](../../../learn/includes/req-admin.md)]

Denne prosedyren viser deg hvordan du lager en salgsguide helt fra bunnen av.

1. Definer [fasene](#create-stages) som skal være med i salgsguiden.
2. Definer [salgstypen](#create-type) (med tilhørende faser) som salgsguiden skal tilknyttes.
3. Utform [salgsguiden](#create-guide).

## <a id="create-stages" />Opprette faser for salgsguiden

En salgsguide må være knyttet til en salgstype, som igjen består av flere faser. [Slik oppretter du faser][2].

En salgsguide for salg til nye kunder kan for eksempel bestå av fasene "Første møte", "Tilbud" og "Kontraktssignering".

Gå til neste prosedyre for å knytte fasene til en salgstype.

## <a id="create-type" />Opprette salgstype for salgsguiden

En salgsguide må være knyttet til en salgstype. [Slik oppretter du en salgstype][3].

Eksempel på salgstyper: "Salg til ny kunde", "Salg til eksisterende kunde", "Kryssalg til eksisterende kunde".

1. Merk av for **Denne salgstypen er tilknyttet en guide**.
1. Velg minst to faser.
1. Gå til neste prosedyre for å opprette salgsguiden.

## <a id="create-guide" />Opprette en salgsguide

Når du har opprettet faser og angitt en salgstype for salgsguiden, kan du utforme selve salgsguiden ved å legge til oppfølginger og/eller dokumenter for hver fase.

1. Klikk på **Arbeidsflyt**-knappen i navigatoren (![ikon][img1]).

2. Velg fanen **Salgsguide**.

3. Velg salgstypen du vil opprette salgsguide for, i listen øverst. Fasene som er valgt for denne salgstypen, vises nedenfor.

    * Hvis det ikke er definert at salgstypen skal ha en salgsguide, klikker du på **Klikk her for å tilknytte guide** nederst i bildet.

    * Hvis det ikke er angitt faser for salgstypen, klikker du på **Klikk her for å legge til faser** nederst i bildet. Du kan også redigere salgstypen ved å klikke på **Rediger**-knappen øverst.

4. Merk ønsket fase i listen. Detaljene for fasen vises nederst i bildet.

5. [Legg til én eller flere oppfølginger](#add-fo-stage) for den valgte fasen.

    Du trenger ikke å legge til et dokument for hver fase, men du bør legge til minst én oppfølging for hver fase.

6. [Legg til ett eller flere dokumenter](#add-doc-stage) for den valgte fasen.

7. Gjenta trinn 4 til 6 for hver fase du vil legge til oppfølginger og dokumenter for.

Endringene lagres automatisk. Salgsguiden vises nå i SuperOffice CRM, hvis det blir opprettet et salg med salgstypen valgt i trinn B.

## <a id="add-fo-stage" />Legge til oppfølging for en fase

1. Velg ønsket salgstype og fase som beskrevet ovenfor.

2. Klikk på **Legg til** under **Foreslåtte oppfølginger i denne fasen**.

3. I dialogboksen **Foreslått oppfølging** skriver du inn navnet på oppfølgingen i feltet **Navn**. Dette bør være et beskrivende navn for oppfølgingen.

4. I feltet **Formålet med denne oppfølgingen** skriver du inn teksten som skal brukes som hjelpetekst for oppfølgingen i detaljkortet **Salgsguide** i SuperOffice CRM.

    > [!NOTE]
    > Noen av alternativene nedenfor er av logiske årsaker ikke aktuelle for den første oppfølgingen i en salgsguide.

5. Merk av for **Foreslå denne oppfølgingen automatisk** hvis du vil at SuperOffice CRM skal foreslå denne oppfølgingen når forrige oppfølging (i denne eller forrige fase) er merket som utført.

6. Velg en type for oppfølgingen i listen **Oppfølgingstype**.

7. I feltet **Startdato** angir du hvor mange dager det skal være mellom forrige oppfølging og denne oppfølgingen.

8. I feltet **Varighet** angir du hvor lenge oppfølgingen skal vare. Formatet er *0 t 00 m*.

9. I feltet **Standardbeskrivelse av oppfølgingen** skriver du inn en beskrivelse for oppfølgingen.

    > [!TIP]
    > Brukeren kan endre informasjonen ovenfor etter behov.

10. Klikk på **Lagre**.

11. Gjenta prosedyren hvis du vil legge til flere oppfølginger i denne eller andre faser.

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

## <a id="add-doc-stage" />Legge til et dokument for en fase

1. Velg ønsket salgstype og fase som beskrevet ovenfor.

2. Klikk på **Legg til** under **Foreslåtte dokumenter i denne fasen**.

3. I dialogboksen **Foreslått dokument** skriver du inn navnet på dokumentet i feltet **Navn**. Dette bør være et beskrivende navn for dokumentet.

4. I feltet **Formålet med dette dokumentet** skriver du inn teksten som skal brukes som hjelpetekst for dokumentet i detaljkortet **Salgsguide**.

5. Velg ønsket mal i feltet **Mal** (se også [Dokument – Mal][4]).

6. Skriv inn overskriften som skal brukes i dokumentet, i feltet **Standardoverskrift**.

7. Skriv eventuelt inn en referanse i feltet **Vår ref.**. For eksempel en [malvariabel][1] for salgsnummer, salgstittel eller et annet felt som har med salget å gjøre.

8. Klikk på **Lagre**.

9. Gjenta prosedyren hvis du vil legge til flere dokumenter i denne eller andre faser.

### Eksempel på et dokument

**Salgstype**: Salg til ny kunde
**Fase**: Første møte
**Navn** på dokument: Møtebekreftelse
**Formål med dette salgstrinnet**: Send en e-post med møtebekreftelse og dato/klokkeslett til alle deltakerne for det første møtet.
**Mal**: E-post
**Standardoverskrift**: Møtebekreftelse (første møte)

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/for-sales.html
[2]: ../../../admin/lists/learn/sale-stage.md
[3]: ../../../admin/lists/learn/sale-type.md
[4]: ../../../admin/lists/learn/document-template.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-workflow-active.png
