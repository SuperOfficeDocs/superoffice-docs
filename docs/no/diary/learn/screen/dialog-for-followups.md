---
uid: help-no-dialog-for-followups
title: Dialogboks for oppfølging
description: Dialogboks for oppfølging
author: SuperOffice RnD
so.date: 06.29.2022
keywords: dagbok, oppfølging
so.topic: reference
language: no
---

# Dialogboksen for oppfølginger

Uansett hva [slags oppfølging][1] du skal jobbe med, vil du få se dialogboksen for oppfølginger. Det faktiske navnet på denne dialogboksen varierer avhengig av typen oppfølging – Avtale, Oppgave, eller Samtale – men feltene er like i hvert tilfelle. Nedenfor finner du en beskrivelse av feltene i dialogboksen og hvordan du bruker dem.

Dialogboksen består av en hovedseksjon med generell informasjon om oppfølgingen, og fem faner med tilleggsinformasjon:

* Beskrivelse
* Detaljer
* Deltakere
* Koblinger
* Mer

## Informasjon om oppfølgingen

Hovedseksjonen inneholder følgende grunnleggende informasjon om oppfølgingen:

### Type

Klikk på pilen ![ikon][img2] ved siden av dette feltet for å vise en forhåndsdefinert liste over oppfølgingstyper å velge mellom, for eksempel et møte eller utgående samtale. Du kan også søke etter typer ved å skrive i dette feltet.

> [!NOTE]
>**Type**-feltet bestemmer hvilken type oppfølging det er snakk om: avtale, oppgave eller samtale.

## Videomøte

Klikk på ![icon][img3] for å sette opp et [videomøte][9]. Ikonet endres til ![icon][img4].

### Firma

Her skriver du inn navnet på firmaet som er knyttet til oppfølgingen (valgfritt). Hvis du ikke husker hele navnet, kan du søke direkte fra dette feltet.

### Person

Hvis du klikker på pilen ved siden av dette feltet, får du frem en liste over personer som er registrert på firmaet. Hvis ingen firma er valgt, vil du se en liste over personer som ikke er knyttet til et firma. Du kan søke direkte fra dette feltet.

### Prosjekt

Skriv inn navnet på prosjektet som oppfølgingen er knyttet til. Hvis du ikke husker hele navnet, kan du søke direkte fra dette feltet.

> [!NOTE]
> I **Prosjekt**-feltet, kan du spesifisere hvilket som helst prosjekt i SuperOffice CRM, uavhengig av hvilket firma oppfølgingen er knyttet til.

### Salg

Skriv inn navnet på salget (hvis noen) som oppfølgingen er knyttet til. Hvis du ikke husker hele navnet, kan du søke direkte fra dette feltet.

### Tidssonevelger

Hvis SuperOffice har [tidssoner][10] slått på, kan du velge hvilken tidssone oppfølgingen skal opprettes i. Tidssonene vises etter land, og du kan søke både etter land og by direkte i tidssonefeltet.

### Start / Slutt / Frist / Varighet

Skriv inn en dato og eventuelt et klokkeslett i **Start**-feltet og **Slutt**-feltet (for avtaler og samtaler) eller **Frist**-feltet (for oppgaver), for henholdsvis oppfølgingsstart og oppfølgingsslutt/tidsfrist. Hvis du angir klokkeslett, justeres innholdet i feltet **Varighet** automatisk.

> [!TIP]
> Hvis oppfølgingen er i konflikt med en annen eller har flere deltakere, vises feltet **Første tilgjengelige** som viser det første tilgjengelige møtetidspunktet.

### Hele dagen

Hvis du velger **Hele dagen**, settes tidspunktet for avtalen til perioden som er angitt som standard arbeidsdag.

> [!TIP]
> Disse standardverdiene er spesifisert i dialogboksen [Preferanser][13] dialog. Velg **Dagbok**, og angi ønskede klokkeslett for **Dagen starter** og **Dagen slutter**.

### Sted

Her kan du velge adressen der oppfølgingen skal foregå. Som standard er dette feltet tomt, men hvis du klikker ![pil-ikonet][img2] ved siden av feltet, vises to oppføringer i en liste. Det ene er brukerens firma og det andre er firmaet som skal følge opp.

Hvis du angav en ressurs av typen **Sted** (for eksempel et møterom) som en deltaker på detaljkortet **Deltakere** vises ressursen også i denne listen.

> [!TIP]
> Du kan også skrive inn en egen adresse for stedet.

Fullført![icon][img5] ![icon][img6]

Sjekk her når [oppfølgingen er fullført][11].

### Oppgave

![icon][img1]

Klikk på denne knappen for å få tilgang til relevante oppgaver som kan utføres i den aktive oppføringen. Eksempler: Slett, skriv ut, Send som e-post, Tilordne til og Avlys møte. I Innstillinger og vedlikehold kan du også definere dine egne oppgaver og legge dem til under **Oppgave**-knappen.

### Registrert/Sist endret

Disse feltene viser datoen for når oppfølgingen første gang ble registrert, og når den sist ble endret. De viser også hvem som utførte handlingene.

> [!TIP]
> Hvis du holder musepekeren over denne teksten, vises det en infoboks med mer informasjon om når oppfølgingen ble opprettet og sist endret.

## Fanen Beskrivelse

I denne fanen kan du legge inn en beskrivelse av oppfølgingen. Du kan bruke denne funksjonen til fritekstsøk. Beskrivelsen kan ikke være lenger enn 2048 tegn.

## Fanen Detaljer

Fanen **Detaljer** inneholder detaljert informasjon om oppfølgingen.

### Gjentakelse

I dette feltet angir du om oppfølgingen gjentas. Klikk på ordet **Aldri** til høyre for **Gjentakelse-feltet** hvis du vil at [avtalen skal gjentas][4] med jevne mellomrom. Hvis en oppfølging repeteres, vises et ikon ![icon][img1] øverst til venstre i hovedseksjon av dialogboksen.

### Prioritet

Her angir du hvordan du vil prioritere oppfølgingen. Klikk på pilen for å vise en liste med standardalternativene av høy, middels og lav prioritet. [!include[SM](../../../learn/includes/are-defined-sm.md)]

### Alarm

Hvis du vil ha en varslingsmelding om oppfølgingen, velger du **Alarm**. Hvis en [alarm er angitt][5] for en oppfølging, blir et ikon ![icon][img2] vist øverst til venstre i hovedseksjonen av dialogboksen.

### Eier

Angi hvem som eier oppfølgingen. Standard er brukeren som for øyeblikket er logget inn. Hvis du klikker på navnet ved siden av feltet **Eier**, kan du overføre avtalen til en annen SuperOffice-bruker. Dialogboksen **Tildel til** åpnes. Under feltet **Tilordne denne oppfølgingen til** er det en liste der du kan velge ønsket brukergruppe. Velg ønsket bruker og klikk **OK** for å lagre endringene og lukke dialogboksen.

> [!NOTE]
> Hvis en bruker allerede er opptatt på det aktuelle tidspunktet, vises ordet **KONFLIKT** i **Status**-feltet . Hvis du vil skjule brukere med konflikter, velger du **Skjul konflikt** nederst i dialogboksen.

### Vis som

Velg **Ledig** eller **Opptatt** i **Vis som**-feltet for å angi om du er tilgjengelig for andre mens avtalen pågår. Hvis du velger **Ledig**, kan du ha andre oppfølginger samtidig, for eksempel hvis du reserverte mesteparten av dagen til å jobbe med et prosjekt, men at du fortsatt har tid til korte møter.

### Synlig for

Klikk **Synlig for**-feltet for å vise en liste der du kan velge om oppfølgingen skal være synlig for alle brukere, synlig bare for brukeren som er definert som eier, eller synlig for alle brukere i en av brukergruppene som eieren tilhører.

> [!NOTE]
> Hvis du angir synlighet til bare eier, vises oppføringen i kursiv på detaljkortet **Aktiviteter**.

Dette alternativet er bare tilgjengelig hvis **konfidensielle aktiviteter** er aktivert for gjeldende bruker i Innstillinger og vedlikehold.

### Publiser (krever separat lisens)

Velg hvis du vil at oppfølgingen skal vises for eksterne brukere.

## Fanen Deltakere

Denne fanen inneholder en [liste over deltakere][6] i oppfølgingen. Påmeldte deltakere er markert med en prikk.

Hvis du klikker på **Vis som gruppe**-knappen ![icon][img7] nederst til høyre på **Deltakere**-fanen, vil **Vis**-fanen i dagboken åpnes med en oversikt over [dagbøkene til de inviterte medarbeiderne][7] (SuperOffice-brukere).

## Fanen Koblinger

Denne fanen inneholder informasjon om nettadresser, aktiviteter (dokumenter og oppfølginger), prosjekter og salg som er [knyttet til den aktuelle oppfølgingen][8] . Hvis det er registrert noe i denne fanen, vises det en prikk ved siden av **Koblinger**.

## Fanen Mer

Denne fanen viser eventuelle [egendefinerte felt][14] som er konfigurert i Innstillinger og vedlikehold. Hvis ikke konfigurert, vises ikke denne fanen.

<!-- Referenced links -->
[1]: ../follow-ups.md
[4]: ../recurrence/index.md
[5]: ../set-alarm.md
[6]: ../invitation/index.md
[7]: ../other-diaries.md
[8]: ../linking-documents-to-follow-ups.md
[9]: ../video-meetings.md
[10]: ../../../globalization-and-localization/learn/time-zones.md
[11]: ../change-completed-status.md
[13]: ../../../learn/getting-started/preferences.md
[14]: ../../../custom-objects/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-menu.png
[img2]: ../../../../../common/icons/dropdown-icon.png
[img3]: ../../../../../common/icons/videocall-off.png
[img4]: ../../../../../common/icons/videocall.png
[img5]: ../../../../media/icons/followup-not-completed.png
[img6]: ../../../../media/icons/followup-completed.png
[img7]: ../../../../../common/icons/diary-participants.png
