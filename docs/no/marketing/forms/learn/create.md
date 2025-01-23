---
uid: help-no-form-create
title: Opprette et nytt skjema
description: Lær hvordan du kan opprette et nettskjema i denne veiledningen.
keywords: skjema, webskjema, nettskjema, påmelding
author: SuperOffice RnD
date: 02.29.2024
version: 10
topic: howto
language: no
audience: person
audience_tooltip: SuperOffice Marketing
---

# Opprette et nytt skjema

Nettskjemaer gjør det enklere å samhandle med kunder og potensielle kunder via websiden eller kundesenteret. Du har tre alternativer: opprett et skjema fra bunnen av, lag og bruk en tilpasset skjemamal, eller velg en gratis mal fra **Online Template Library** i SuperOffice Marketing.

Se denne videoen for å lære hvordan du kan lage et nettskjema (videolengde - 7:49) eller følg fremgangsmåten nedenfor.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/18m6Dx1t9wI]

## Opprette nytt (fra bunnen av)

1. Gå til fanen **Skjemaer**.
2. Hvis nødvendig, klikk på **Legg til mappe** for å [opprette en mappe for skjemaet][8].
3. Klikk på **Skjema**-knappen under **Opprett nytt** på høyre side av skjermen.
4. I dialogboksen **Rediger skjema**, skriv inn et beskrivende **Skjemanavn**.
5. [Fyll ut feltene](#fields) som beskrevet nedenfor. Husk å klikke på **Bruk nå** regelmessig for å lagre arbeidet ditt. Skjemaet lagres ikke automatisk.
6. Klikk på **Lagre** når du er ferdig.

![Set properties for new contact me form -screenshot][img15]

## Opprette nytt skjema basert på skjemamal

1. Velg fanen **Skjemamaler**.
2. Klikk på **Alle maler**.
3. Klikk på <i class="ph ph-list" aria-label="Task menu"></i> menyknappen ved siden av malen du vil bruke.
4. Velg **Kopier til nytt skjema**. Malen åpnes i dialogboksen **Rediger skjema**.
5. [Aktivere og publisere skjemaet][2].

## <a id="multi-page"></a>Opprette skjema med flere sider

For å øke brukervennligheten og lette lesbarheten, vurder å dele et skjema med mange felt inn i flere sider. Brukere kan navigere gjennom skjemaet ved hjelp av **Neste**- og **Forrige**-knappene, og en fremdriftslinje kan legges til for å indikere gjenværende felt.

1. Opprett et skjema som beskrevet ovenfor.
2. Velg **Felt** fra venstremenyen (i dialogboksen).
3. Klikk på **Legg til**-knappen (<i class="ph ph-plus" aria-hidden="true"></i>).
4. I vinduet **Legg til element** velger du **Vis elementer**.
5. Velg **Seksjon** og klikk på **Legg til** . Vinduet lukkes og en seksjon legges til i skjemaet. Du kan også se seksjonen i forhåndsvisningen av skjemaet.
6. Klikk på ![ikonet][img3] øverst i seksjonen og dra det til ønsket posisjon i skjemaet. Feltene over og under seksjonen vil være på to separate sider i skjemaet.
7. Klikk på **Bruk nå** når du er ferdig.
8. Gjenta trinn 2–7 for å legge til en annen seksjon.

> [!TIP]
> Du kan legge til en fremdriftsindikator i skjemaet, slik at brukeren kan se hvor mye som gjenstår å fylle ut. Gå til kategorien **Stil**, klikk på avmerkingsboksen ved siden av **Farge**, på fremdriftsindikatoren, og velg en farge.

## <a id="fields"></a>Fylle ut skjemafelt

[!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

### Egenskaper

* **Mappe**: Velg hvor skjemaet skal plasseres, eller [opprett en ny mappe][8].

* **Beskrivelse**: Forklar formålet med dette skjemaet. Denne teksten er bare synlig internt.

* **Språk**: Velg språket som skal brukes i skjemaet.

* **Administreres av**: Valgfritt. Velg en brukergruppe for å begrense tilgangen til dette skjemaet. Bare medlemmer av den valgte brukergruppen kan behandle innsendinger fra dette skjemaet og motta varsler om innsendinger.

* **Deaktiver skjema automatisk**: Valgfritt. I noen tilfeller bør skjemaet bare være aktivt til en bestemt dato eller til et bestemt antall svar er mottatt. Hvis noen prøver å få tilgang til et inaktivt skjema, blir de omdirigert til siden for det inaktive skjemaet. Du kan kombinere disse alternativene.

  * **Inntil**: Velg en dato. Skjemaet deaktiveres på denne datoen.
  * **Maks**: Angi antall svar. Skjemaet vil bli deaktivert etter at angitt antall svar er mottatt.

* **Bruk Google Analytics**: Velg dette alternativet for å spore skjemaet og koble det til [Google Analytics][1] (hvis det er konfigurert for websiden din). I feltet under dette alternativet kan du angi sporings-ID for Google Analytics for dette skjemaet.

### Legge til felt i skjemaet

I kategorien **Felt** legger du til feltene som skal brukes i skjemaet. Når du legger til og redigerer felt, oppdateres forhåndsvisningen automatisk.

1. Velg **Felt** fra venstremenyen. Som standard blir feltet **Person - navn** og **OK**-knappen lagt til i det nye skjemaet.

2. Klikk på **Legg til**-knappen (<i class="ph ph-plus" aria-hidden="true"></i>).

3. I vinduet **Legg til element** velger du en av følgende feltkategorier:

    * **SuperOffice-elementer**: Felt som er koblet til SuperOffice-data, for eksempel personnavn, land, e-postadresse og så videre. Avhengig av felttypen kan verdier fra innsendte skjemaer enten erstatte eksisterende verdier (for eksempel land eller tittel) eller legges til det relevante SuperOffice-feltet (for eksempel mobiltelefon).

    * **Skjemaelementer**: Felt for å angi tekst eller dato, felt for å velge verdier (lister, avmerkingsbokser og alternativknapper) og felt for opplasting av filer.

    * **Visningselementer**: Seksjoner, tekster og bilder. Bruk seksjoner til å opprette [skjemaer med flere sider](#multi-page).

4. Velg et felt fra listen.

5. Klikk på **Legg til**. Vinduet lukkes, og feltet legges til skjemaet og forhåndsvisningen av skjemaet.

6. Klikk på ![icon][img3] øverst i feltet og dra det til ønsket posisjon i skjemaet.

7. Velg feltet, og rediger eventuelt feltnavnet. Det opprinnelige feltnavnet vises alltid øverst til høyre i feltet.

8. Du kan også redigere disse innstillingene (valgfritt):

    * I feltet **Plassholder** kan du skrive kort hva som skal angis i feltet.

    * Merk av for **Obligatorisk** hvis dette feltet skal fylles ut. Skjemaet kan ikke sendes hvis det ikke er fylt ut obligatoriske felt.

    * Klikk på **Avanserte alternativer** (<i class="ph ph-gear" aria-hidden="true"></i>) for å vise **Identifikator**-feltet der du kan legge til en ID for feltet. Dette er en unik ID for dette feltet, og den blir ikke endret selv om navn/ledetekst eller språk for feltet endres. På denne måten kan du sørge for at koblinger til dette feltet ikke brytes etter publisering av skjemaet.

    * Velg **Full bredde** hvis du vil at det valgte feltet skal ha samme bredde som skjemaet.

9. Rediger eventuelle andre [alternativer i feltet][4] etter behov.

10. Klikk på **Bruk nå** når du er ferdig.

11. Gjenta trinn 2–10 for å legge til et nytt felt. Du kan også klikke på **Dupliser felt** (<i class="ph ph-copy" aria-hidden="true"></i>) for å opprette en kopi av et felt.

### Stil

Velg **Stil** fra venstremenyen for å definere utseendet til skjemaet. For eksempel, antall kolonner, plassering av feltnavn, kantlinjer, bakgrunn, skriftfarge/størrelse og skjemastørrelse.

Forhåndsvisningen til høyre oppdateres automatisk når du endrer innstillingene. Hvis du ikke angir høyden og bredden på skjemaet, tilpasses skjemaet automatisk til skjermstørrelsen (stasjonær datamaskin, nettbrett eller mobiltelefon).

> [!TIP]
> Du kan legge til en fremdriftsindikator i skjemaet, slik at brukeren kan se hvor mye som gjenstår å fylle ut. Klikk på avmerkingsboksen ved siden av **Fremdriftsindikator**, og velg en farge. Fremdriftsindikatoren vises nederst i skjemaet. Se også [Opprette skjemaer med flere sider](#multi-page).

### Aktiver dobbel opt-in (valgfritt)

Dobbel opt-in (bekreftelse) er et ekstra trinn i skjemainnsendingsprosessen som vil garantere at folk sender inn riktig e-postadresse.

Se denne videoen for å lære hvordan du bruker funksjonen for dobbel opt-in på webskjemaet ditt (videolengde - 3:45), eller følg trinnene nedenfor.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/o7mkk3n7zuw]

**Trinn:**

1. Klikk på **Aktiver dobbel opt-in**.

2. I fanen**Melding** skriver du inn teksten som skal vises etter at skjemaet er sendt.

3. I **E-post**-fanen oppretter du e-postbekreftelsen som sendes til personene som sender skjemaet.

    1. **Overskrift**: Skriv inn overskriften for e-postbekreftelsen.

    2. **Avsenderadresse**: Skriv inn e-postadressen som skal vises, i **Fra**-feltet i e-postbekreftelsen.

    3. **Bekreftelsestekst**: Skriv inn brødteksten i e-posten.

    4. Velg **Sett inn bekreftelseslenke** (<i class="ph ph-arrow-square-out" aria-hidden="true"></i>) fra verktøylinjen (klikk <i class="ph ph-text-a-underline" aria-label="Show toolbar"></i> for å vise). Bekreftelseskoblingen settes inn i brødteksten. Hvis du vil redigere koblingen, klikker du på den og velger **Rediger kobling** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>).

4. Klikk på **Bruk nå** når du er ferdig.

Hvis dobbel pålogging er aktivert for et skjema, har alle innsendinger for dette skjemaet status **Venter på bekreftelse** til e-postadressen er bekreftet.

> [!NOTE]
> Husk å legge til **Person - e-post**-feltet i **Felt**-kategorien.

### Takkeside

Når en person fyller ut og sender inn et skjema, bør du takke dem og la dem få vite hva som vil skje videre. Det er alltid hyggelig å si takk. Folk setter stor pris på det.

Bruk "Takk"-siden til å promotere andre produkter eller arrangementer, og lenk til relevante deler av nettsiden din. Dette hever kundeopplevelsen og fremmer kundelojalitet.

Se denne videoen for å lære hvordan du legger til en "Takk"-side i webskjemaet (videolengde - 1:48), eller følg trinnene nedenfor.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/xaVXR-Ltfuo]

Velg ett av følgende alternativer:

* **Videresend til ekstern webside:** Skriv inn koblingen til websiden med mer informasjon.
* **Vis denne meldingen:** Skriv inn teksten som skal vises.

### Side for inaktivt skjema

Hvis en person åpner et skjema som er inaktivt, kan du enten omdirigere vedkommende til en annen nettside eller vise en melding.

* **Videresend til eksternt websted:** Angi koblingen til nettstedet.
* **Vis denne meldingen:** Skriv inn teksten som skal vises.

### Handlinger

Her kan du [definere hva som skjer når noen sender inn et skjemasvar][3].

* Varsle om innsendinger ved å opprette saker
* Hvordan skal en skjemainnsending behandles?
* Hva skal skje når skjemaet behandles?

## Hva vil du gjøre nå?

* [Publisere skjemaer][2]

<!-- Referenced links -->
[1]: ../../tracked-links/learn/ga-tutorial.md
[2]: publish.md
[3]: define-form-actions.md
[4]: field-options.md
[8]: ../../learn/create-folder.md

<!-- Referenced images -->
[img3]: ../../../../media/icons/marketing-and-forms/move-field.png
[img15]: ../../../../media/loc/en/marketing/contact-me-form-properties.png
