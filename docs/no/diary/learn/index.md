---
uid: help-no-diary
title: Dagbok
description: SuperOffice-dagboken er hjertet i CRM-systemet ditt. Disse veiledningene hjelper deg med å navigere og arbeide i dagboken.
keywords: åpne dagbok, dagbokskjerm, kalender, Aktiviteter-fanen, aktiviteter, oppgaveliste, oppfølging, dagbok
author: Bergfrid Dias
date: 02.05.2025
version: 10.5.2
topic: concept
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Dagbok

Dagboken er hjertet i SuperOffice CRM og brukes til å administrere [oppfølginger][1] (møter, oppgaver og samtaler). Den består av en kalender og en oppgaveliste som hjelper deg med å holde oversikt og være produktiv.

![Dagbok-bilde som viser en ukekalender og oppgaveliste -screenshot][img1]

Dagboken kombinerer følgende nøkkelkomponenter:

* **Kalender:** Viser aktiviteter planlagt for spesifikke datoer og tidspunkter. Den fungerer som en digital planbok med separate sider for hver dag, uke og måned.
* **Oppgaveliste:** Viser aktiviteter uten spesifikke tidspunkter, for eksempel samtaler og oppgaver. Denne fungerer som en gjøremålsliste.

Med fleksible visninger sikrer dagboken sømløst samarbeid og lar deg planlegge dagen, uken eller måneden på en effektiv måte.

## <a id="open"></a>Åpne dagboken

For å åpne dagboken, klikk på **Dagbok** i navigatoren og velg en tidsperiode fra listen, eller klikk **I dag** eller **Denne uken** for å gå til gjeldende dag eller uke. Ditt navn vises øverst til høyre i fanen.

Oppfølginger vises i dagboken som fargede tidsblokker, som representerer type og varighet. Hver blokk inneholder detaljer som firma, type og agenda. Dobbeltklikk en oppfølging for å åpne den.

Følgende symboler gir visuelle indikasjoner på oppfølgingens detaljer eller mulige handlinger:

| Symbol | Beskrivelse | Les mer |
|:-:|---|---|
| <i class="ph ph-arrows-clockwise" aria-label="Repeterende oppfølging"></i> | Dette er en repeterende oppfølging. | [Opprette repeterende oppfølginger][8] |
| <i class="ph ph-user-circle" aria-label="Flere deltakere"></i> | Oppfølgingen har flere deltakere. | [Invitere medarbeidere til en oppfølging][11] |
| <i class="ph ph-check" aria-label="Fullført oppfølging"></i> | Oppfølgingen er fullført. | [Endre Utført-status for en aktivitet][7] |
| <i class="ph ph-bell" aria-label="Alarm på oppfølging"></i> | Oppfølgingen har en aktiv alarm. | |
| <i class="ph ph-question" aria-label="Ubesvarte invitasjoner"></i> | Det er ubesvarte invitasjoner til denne oppfølgingen. | [Status for invitasjoner][10] |
| <i class="ph ph-video-camera" aria-label="Videomøte"></i> | Denne oppfølgingen er et videomøte. Høyreklikk på oppfølgingen og velg **Bli med i møte** for å delta. | [Arbeide med videomøter][6] |

Administratorer definerer oppfølgingstyper og deres farger i **Innstillinger og vedlikehold**.

## <a id="nav"></a>Navigere i dagboken

Du kan enkelt bevege deg mellom datoer og tidsperioder i dagboken:

* Velg fanen **Dag**, **Uke** eller **Måned** for å endre detaljnivået i kalenderen. Overskriften oppdateres for å vise valgt dag, uke eller måned.

* Bruk **Forrige** og **Neste**-knappene (<i class="ph ph-caret-circle-left" aria-hidden="true"></i><i class="ph ph-caret-circle-right" aria-hidden="true"></i>) for å bla fremover eller bakover.

* For raskt å hoppe til en bestemt dato, uke eller måned:
  * Klikk på en bestemt dato for å åpne **Dag**-fanen for denne datoen.
  * Klikk på et ukenummer for å vise den uken i **Uke**-fanen.
  * Klikk på en måned (tilgjengelig i sidepanelet) for å bytte til **Måned**-fanen.

* Klikk **I dag** eller **Denne uken** for å gå tilbake til gjeldende dag eller uke.

## <a id="tabs"></a>Faner i dagboken

Dagboken har fire hovedkalendervisninger. Bruk disse fanene for å bytte mellom ulike perspektiver:

<!-- markdownlint-disable MD051 -->
### [Fanen Dag](#tab/day)

**Dag-fanen** viser én dag om gangen med timeintervaller langs venstre kant. Denne visningen er ideell for å administrere timeplanen din time for time.

![Dagbokskjermen, fanen Dag -screenshot][img2]

Viktige funksjoner:

* Naviger enkelt mellom datoer ved å bruke knappen **I dag** eller knappene **Forrige** og **Neste** (<i class="ph ph-caret-circle-left" aria-hidden="true"></i><i class="ph ph-caret-circle-right" aria-hidden="true"></i>).

* Legg til eller flytt oppfølginger ved å dra og slippe dem på tidslinjen.

### [Fanen Uke](#tab/week)

**Uke-fanen** viser én uke av gangen, der dagene vises som kolonner og timene som rader.

![Dagbokskjermen, fanen Uke -screenshot][img3]

Viktige funksjoner:

* Få rask tilgang til en bestemt dag ved å klikke på dagsoverskriften.
* Se overlappende oppfølginger tydelig i samme tidsblokk.

> [!TIP]
> Hvis du vil endre hvilken dag som starter uken (søndag eller mandag), gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige innstillinger** > **Preferanser**.

### [Fanen Måned](#tab/month)

**Måned-fanen** gir en oversikt over alle oppfølginger planlagt for en gitt måned.

![Dagbokskjermen, fanen Måned -screenshot][img4]

Viktige funksjoner:

* Hold musepekeren over oppfølginger for å vise flere detaljer.
* Klikk på en dato for å gå til **Dag**-fanen for mer informasjon.

### [Fanen Oversikt](#tab/view)

**Oversikt-fanen** lar deg vise og administrere gruppeplaner samt sjekke tilgjengelighet.

![Dagbokskjermen, fanen Oversikt -screenshot][img5]

Viktige funksjoner:

* **Gruppeoversikter:** Kombiner timeplanene til flere brukere eller ressurser i én visning. Velg en forhåndsdefinert gruppe fra listen (<i class="ph ph-caret-down" aria-label="Nedtrekksikon"></i>) eller opprett og administrer tilpassede gruppeoversikter ved hjelp av **Oppgave**-menyen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>).

* **Visningsmoduser:** Bytt mellom side-ved-side-visning og planleggingsrutenettet ved å bruke veksleknappene (<i class="ph ph-columns" aria-label="Kolonner"></i>/<i class="ph ph-rows" aria-label="Rader"></i>) øverst til høyre.

For detaljerte trinn om hvordan du oppretter og administrerer gruppeoversikter, se [Gruppeoversikt][2].

> [!TIP]
> Når du er i en gruppeoversikt, kan du opprette oppfølginger for andre direkte i kalenderen.

***
<!-- markdownlint-enable MD051 -->

Nederst til venstre i kalenderen finner du et felt for å velge en [tidssone][20], hvis tidssoner er aktivert.

## <a id="section-tabs"></a>Detaljkortene i Dagbok-bildet

Den nedre delen av dagbokskjermen består av detaljkort som sammen utgjør oppgavelisten din. Disse inkluderer:

* **Aktiviteter:** Fungerer som en oppgaveliste og viser oppfølginger som ikke er tildelt spesifikke tidspunkter for den valgte medarbeideren. Se [detaljkortet Aktiviteter][12].

* **Salg:** Gir en oversikt over salgsfremdrift og planlagte aktiviteter knyttet til salg for den valgte medarbeideren. Den legger vekt på oppfølging og administrasjon av kommende oppgaver. Se [detaljkortet Salg][13].

Dagbokens detaljkort kan enten vises *under* kalenderen eller som en femte kalendervisning – **Oppgaveliste**-fanen – avhengig av dine innstillinger.

Når de vises *under* kalenderen (klassisk visning), forblir detaljkortene synlige uansett hvilken dagbokfane som er valgt. Dette lar deg effektivt forhåndsvise salg eller oppfølginger i sidepanelet mens du planlegger i kalenderen. Når de vises *inne i* kalenderen som en egen fane (ny visning), frigjør du mer plass til kalenderen.

![Dagbokskjerm med detaljkortene inne i Oppgaveliste-fanen -screenshot][img6]

## Sidepanelet i dagboken

[Sidepanelet][17] er plassert på høyre side av dagbokskjermen og gir rask tilgang til tilleggsverktøy som månedskalenderen, forhåndsvisning av oppfølginger eller SuperOffice Copilot.

Når du velger en dato, uke eller måned i sidepanelet, oppdateres dagboken for å matche valget. På samme måte oppdateres sidepanelet når du navigerer gjennom dagboken.

## Personlige preferanser

Du kan tilpasse dagboken slik at den passer din arbeidsflyt:

1. Gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige innstillinger** > **Preferanser**.

1. Velg **Standardverdier** og juster innstillinger som:
    * Varighet og type for nye møter.
    * Tittel for nye oppgaver.
    * Maksimalt antall oppfølginger som skal vises i **Dag**-visningen.

1. Velg **Dagbok** og juster innstillinger som:
    * Standard alarmtidspunkter.
    * Start- og sluttidspunkter for heldagsaktiviteter.
    * Første dag i uken (søndag eller mandag).
    * Om oppgavelisten skal vises under dagboken eller som en egen fane.

1. Velg **Funksjoner** og juster innstillinger som:
    * Vis ukenumre i kalendere.
    * Antall dager fremover som elementer skal vises i detaljkortene **Aktiviteter** og **Salg**.
    * Markér forfalte aktiviteter.

1. Velg **Visuelle effekter** og juster innstillinger som:
    * Fjern fullførte aktiviteter.
    * Verktøytips.

1. Klikk på **Lagre** for å bruke endringene.

![Personlige preferanser for dagboken -screenshot][img7]

## Effektivitetstips

* Få tilgang til en annen brukers eller en ressurs sin dagbok for å sjekke tilgjengelighet eller opprette oppfølginger direkte. For en kombinert visning av flere dagbøker, opprett en [gruppeoversikt][2].

* Minimer forstyrrelser ved å skjule sidepanelet og/eller navigatoren ved hjelp av veksleknappen (<i class="ph ph-sidebar-simple" aria-hidden="true"></i>).

* Bruk dagboken til å vise, redigere og slette [aktiviteter][16] etter behov, slik at timeplanen din alltid er oppdatert.

* Knytt regelmessig aktiviteter til en kontakt eller et firma for å opprettholde en tydelig oversikt over teamets interaksjoner og sikre smidig samarbeid.

* Bruk de faste detaljkortene under kalenderen til å forhåndsvise og administrere salg eller oppgaver mens du navigerer i dagboken.

* Bytt mellom side-ved-side-visning og planleggingsrutenettet i **Oversikt**-fanen for å velge den layouten som passer best for planleggingen din.

> [!TIP]
> Bruk menyen **Preferanser** for å tilpasse dagbokoppsettet, justere tidsinnstillinger eller aktivere funksjoner som alarmer for oppfølginger.

## Relatert innhold

* [Opprette eller kopiere en oppfølging (møte, oppgave)][5]
* [Planlegge repeterende oppfølginger][8]
* [Invitere medarbeidere til en oppfølging][10]
* [Redigere eller slette oppfølging][3]
* [Endre sluttidspunkt for en oppfølging][4]
* [Bli med i videomøter][6]
* [Skrive ut oppfølginger][14]
* [Legge til kobling til dokument, salg, prosjekt eller nettsted][15]
* [Håndtere oppfølginger via API][50]

<!-- Refererte lenker -->
[1]: follow-ups.md
[2]: group-view.md
[3]: edit-follow-up.md
[4]: edit-follow-up.md#change-end
[5]: create-follow-up.md
[6]: video-meetings.md
[7]: change-completed-status.md
[8]: recurrence/create.md
[10]: invitation/index.md#status
[11]: invitation/add-attendee.md
[12]: ../../learn/section-tabs/activities-tab.md
[13]: ../../learn/section-tabs/sales-tab.md
[14]: ../../learn/basics/print.md
[15]: ../../learn/basics/links.md
[16]: ../../learn/basics/activity.md
[17]: ../../learn/getting-started/main-screen/side-panel.md
[20]: ../../globalization-and-localization/learn/time-zones.md
[50]: ../../../en/diary/reference/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/diary/diary.png
[img2]: ../../../media/loc/en/diary/day-plan.png
[img3]: ../../../media/loc/en/diary/week-plan.png
[img4]: ../../../media/loc/en/diary/month-plan.png
[img5]: ../../../media/loc/en/diary/view-tab.png
[img6]: ../../../media/loc/en/diary/activities-list.png
[img7]: ../../../media/loc/en/diary/preferences.png
