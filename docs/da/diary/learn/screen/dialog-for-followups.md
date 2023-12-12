---
uid: help-da-dialog-for-followups
title: Dialogboks til opfølgninger
description: Dialogboks til opfølgninger
author: SuperOffice RnD
so.date: 06.29.2022
keywords: dagbog, opfølgning
so.topic: reference
language: da
---

# Dialogboksen for opfølgninger

Uanset hvilken [type af opfølgning][1] du arbejder med, vil du se dialogboksen til opfølgning. Det faktiske navn på denne dialogboks varierer afhængigt af typen af opfølgning – Aftale, Opgave eller Samtale – men felterne er de samme i hvert tilfælde. Felterne i dialogboksen, og hvordan du bruger dem, er beskrevet nedenfor.

Dialogboksen består af en hoveddel med generelle oplysninger om opfølgningen samt fem faner med ekstra oplysninger:

* Beskrivelse
* Detaljer
* Deltagere
* Links
* Mere

## Oplysninger om opfølgningen

Hoveddelen indeholder følgende grundlæggende oplysninger om opfølgningen:

### Type

Hvis du klikker på pilen ved siden af dette felt (![ikon][img2] ), får du vist en foruddefineret liste, hvor du kan vælge en opfølgningstype, for eksempel møde eller udgående telefonsamtale. Du kan også søge efter typer ved at skrive i dette felt.

> [!NOTE]
> Feltet **Type** bestemmer, hvilken type opfølgning det drejer sig om: aftale, opgave eller samtale.

## Videomøde

Klik på ![ikon][img3] her for at opsætte et [videomøde][9]. Ikonet ændres til ![ikon][img4].

### Firma

Her skriver du navnet på det firma, som er knyttet til opfølgningen (valgfrit). Hvis du ikke kan huske hele navnet, kan du søge direkte fra dette felt.

### Kontaktperson

Hvis du klikker på pilen efter dette felt, åbnes en liste over de personer, som er registreret på firmaet. Hvis der ikke er valgt et firma, ser du en liste over personer, der ikke er knyttet til et firma. Du kan søge direkte fra dette felt.

### Projekt

Skriv navnet på det projekt, som opfølgningen er knyttet til. Hvis du ikke kan huske hele navnet, kan du søge direkte fra dette felt.

> [!NOTE]
> I feltet **Projekt** kan du angive et vilkårligt projekt i SuperOffice CRM, uanset hvilket firma opfølgningen er tilknyttet.

### Salg

Her skriver du navnet på eventuelt salg, som opfølgningen er knyttet til. Hvis du ikke kan huske hele navnet, kan du søge direkte fra dette felt.

### Tidszonevælger

Hvis dit SuperOffice har [tidszoner][10] slået til, kan du vælge, hvilken tidszone opfølgningen skal oprettes i. Tidszonerne vises efter land, og du kan søge både efter land og by direkte i tidszonefeltet.

### Start/Slut/Frist/Varighed

I felterne **Start** og **Slut** (for aftaler og samtaler)**/Frist** (for opgaver) kan du indtaste dato og eventuelt klokkeslæt for henholdsvis opfølgningsstarttidspunkt og opfølgningssluttidspunkt/-frist. Hvis du angiver et klokkeslæt, justeres indholdet i feltet **Varighed** automatisk derefter.

> [!TIP]
> Hvis opfølgningen kommer i konflikt med en anden eller har flere deltagere, vises feltet **Første ledige**, hvor første ledige mødetidspunkt vises.

### Hele dagen

Hvis du markerer **Hele dagen**, indstilles tidspunktet for aftalen til det tidsrum, som er angivet som en standardarbejdsdag.

> [!TIP]
> Du kan angive standardindstillingen for land i dialogboksen [Præferencer][13]. Vælg **Dagbog**, og angiv det ønskede tidspunkt for **Dagen starter** og **Dagen slutter**.

### Placering

Her kan du vælge den adresse, som opfølgningen skal foregå på. Dette felt er som standard tomt, men hvis du klikker på pilen ![ikon][img2] ved siden af feltet, vises to poster i en liste. Den ene er brugerens firma, og den anden er det firma, der skal følges op på.

Hvis du har angivet en ressourcetype **Sted** (f.eks. et mødelokale) som en deltager på fanen **Deltagere**, vises ressourcen også i dette rullefelt.

> [!TIP]
> Du kan også skrive en separat adresse for stedet.

Ikon for ![Udført][img5] ![ikon][img6]

Marker her, når [opfølgningen er udført.][11]

### Opgave

![ikon][img1]

Klik på denne knap for at få adgang til relevante opgaver, der kan udføres på den aktive post. Eksempler: Slette, Udskrive, Sende som e-mail, Tildele til og Annullere møde. I Indstillinger og vedligeholdelse kan du også definere egne opgaver og tilføje dem under knappen **Opgave**.

### Registreret/Sidst ændret

Disse felter viser datoen for, hvornår opfølgningen første gang blev registreret, og hvornår den sidst blev ændret. De viser også, hvem som udførte handlingerne.

> [!TIP]
> Hvis du holder musemarkøren over denne tekst, vises der en infoboks med yderligere oplysninger om, hvornår opfølgningen blev oprettet og eventuelt sidst ændret.

## Fanen Beskrivelse

På denne fane kan du indtaste en beskrivelse af opfølgningen. Du kan bruge denne facilitet til fritekstsøgning. Beskrivelsen må ikke være længere end 2048 tegn.

## Fanen Detaljer

Fanen **Detaljer** indeholder detaljerede oplysninger om opfølgningen.

### Gentagelse

I dette felt angiver du, om opfølgningen gentages. Klik på ordet **Aldrig** til højre for feltet **Gentagelse** hvis [aftalen skal gentages][4] med jævne mellemrum. Hvis en opfølgning gentages, vises et ikon ![ikon][img1] øverst til venstre i hoveddelen af dialogen.

### Prioritet

Angiv prioriteten for opfølgningen her. Hvis du klikker på pilen, vises en liste med standardindstillingerne høj, middel og lav prioritet. [!include[SM](../../../learn/includes/are-defined-sm.md)]

### Alarm

For notifikation om opfølgningen, markér **Alarm**. Hvis der er angivet[en alarm for en opfølgning][5], vises et ikon ![ikon][img2] øverst til venstre i hoveddelen af dialogen.

### Ejer

Angiv, hvem der ejer opfølgningen. Standard er den bruger, der aktuelt er logget ind. Hvis du klikker på navnet ud for feltet **Ejer** kan du overføre aftalen til en anden SuperOffice-bruger. Dialogboksen **Overfør til** vises. Under feltet **Tildel denne opfølgning til** er der en liste, hvor du kan vælge den ønskede brugergruppe. Vælg den ønskede bruger, og klik på **OK** for at gemme ændringerne og lukke dialogen.

> [!NOTE]
> Hvis en bruger allerede er optaget på det pågældende tidspunkt, vises ordet **KONFLIKT** i **feltet Status** . Hvis du vil skjule brugere med konflikter, skal du markere **afkrydsningsfeltet Skjul konflikt** nederst i dialogboksen.

### Vis som

Marker **Ledig** eller **Optaget** i feltet **Vis som** for at angive, om du er tilgængelig for andre, mens aftalen pågår. Hvis du vælger **Ledig**, kan du have andre opfølgninger samtidigt, for eksempel hvis du reserverede størstedelen af dagen til at arbejde på et projekt, men du stadig har tid til korte møder.

### Synlig for

Klik i feltet **Synlig for** for at få vist en liste, hvor du kan vælge, om opfølgningen skal være synligt for alle brugere, kun synlig for den bruger, der er defineret som ejer eller synlig for alle brugere i en af de brugergrupper, som ejeren tilhører.

> [!NOTE]
> Hvis du indstiller synlighed til Kun ejer, vises posten med kursiv på fanen **Aktiviteter** i sektionen.

Denne indstilling er kun tilgængelig, hvis **Fortrolige aktiviteter** er aktiveret for den aktuelle bruger i Indstillinger og vedligeholdelse.

### Udgiv (kræver separat licens)

Marker denne, om du ønsker, at opfølgningen skal være synlig for eksterne brugere.

## Fanen Deltagere

Denne fane indeholder en [liste over deltagere][6] i opfølgningen. Registrerede deltagere er markeret med en prik.

Hvis du klikker på knappen **Vis som gruppe** ![ikon][img7] nederst til højre på fanen **Deltagere** åbnes fanen **Vis** i dagbogen og giver dig en oversigt over [dagbøgerne for de inviterede medarbejdere][7] (SuperOffice-brugere).

## Fanen Links

Denne fane indeholder oplysninger om URL-adresser, aktiviteter (dokumenter og opfølgninger), projekter og salg, som er[tilknyttet til den aktuelle opfølgning][8]. Hvis der er registreret noget på denne fane, vises der en prik ved siden af **Links**.

## Fanen Mere

Denne fane viser alle [brugerdefinerede felter][14], der er konfigureret i Indstillinger og vedligeholdelse. Hvis ikke konfigureret, vises denne fane ikke.

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
