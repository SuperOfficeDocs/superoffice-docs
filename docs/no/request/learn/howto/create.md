---
uid: help-no-request-create
author: Hanne Gunnarsson
title: Opprette en sak
description: Opprette en sak
so.date: 02.20.2023
keywords: sak
so.topic: howto
so.audience: person
so.audience.tooltip: SuperOffice Service
language: no
---

# Opprette en sak

En sak kan komme inn i systemet via en e-postmelding fra kunden, eller du kan registrere den manuelt via bildet **Ny sak**. Det kan være aktuelt hvis en kunde kommer med en henvendelse via telefon.

## Arbeidsflyt

1. Velg **Ny** > **Sak**.

1. Gi saken et beskrivende navn i feltet **Tittel**.

1. Legg til en person i feltet **Søk etter person**.
   Vil du ikke legge til en person? Du kan opprette en sak uten å legge til en person og legge til denne informasjonen senere, hvis du har det travelt.

1. Når du oppretter en ny sak, har feltet **Til** følgende bruksområder:

    * Som standard er personene som opprettes her, også personer for den nye saken.
    * Hvis du angir mer enn én person, settes den første personen som primærkontakt for saken. Du kan klikke og dra personene for å endre rekkefølgen.

    I feltet **Person** (Søk etter person) begynner du å skrive inn navnet (eller telefonnummeret) til personen. I listen over søkeresultater bruker du pil opp / pil ned på tastaturet til å velge en person, og trykker deretter på **ENTER**. Eller bruk markøren til å velge personen.

    Du kan også angi en e-postadresse hvis du vil legge til en mottaker uten å registrere vedkommende i systemet. I så fall legges han/hun ikke til som person for saken.
    </details>

    > [!NOTE]
    > Du kan la dette feltet stå tomt hvis du ikke vil sende meldingen til noen.

1. Valgfritt: Klikk på knappen **Kopi til /Blindkopi til** helt til høyre for å legge til personer som kopi eller blindkopi.

1. Gå til panelet **Egenskaper** på høyre side av skjermen, og skriv inn informasjon slik at saken tildeles og prioriteres riktig.

   * I listeboksen **Status** velger du ett av følgende:
     * **Åpne**: Velg dette hvis saken er under arbeid.
     * **Avsluttet**: Velg dette hvis saken er utført.
     * **Utsatt**: Hvis du vil utsette behandlingen av denne saken, velger du dette alternativet og angir en dato og et klokkeslett i feltet **Angitt** eller et forhåndsinnstilt klokkeslett i listen nedenfor. På denne datoen og dette klokkeslettet settes saken til **Åpen** igjen.

   * I feltet **Eier** velger du ett av følgende alternativer:
     * Hvis du vil tildele saken til en bestemt person, velger du ønsket navn. Velg ditt eget navn for å tildele saken til deg selv.
     * **(Automatisk tildelt)**: Hvis du velger dette alternativet, fordeler systemet saken etter gjeldende fordelingsregler.
     * **(Ufordelt)**: Du kan også velge å ikke tildele saken. Da blir medlemmene av den aktuelle kategorien ansvarlige for å behandle saken.

   * I feltet **Kategori** velger du kategorien du vil ha, fra listen som vises.

   * I listeboksen **Prioritet** kan du velge mellom **Lav**, **Medium** og **Høy**, eller du kan angi at systemet skal tildele prioritet automatisk. Det kan f.eks. gjøres på grunnlag av [eskaleringsnivåer][3] som er angitt for ulike personer og firmaer.

   * I listeboksen **Tilgangsnivå for sak** kan du velge blant følgende alternativer:
     * **Ekstern**: Velg dette alternativet hvis personen skal ha tilgang til saken via SuperOffice Kundesenter.
     * **Internt**: Velg dette hvis personen ikke skal ha tilgang til saken. Saken blir oppført i SuperOffice Kundesenter, men personen kan ikke vise saksdetaljer eller meldinger.

   * [Velg relevante emneknagger][4] for denne saken i listen **Emneknagger**.

1. I fanen **Meldinger** skriver du inn selve [meldingen](#message) du vil legge til i saken.

1. Klikk på **Send** for å sende og lagre saken.

## <a id="message" />Melding

> [!NOTE]
> Hvis du vil sende meldingen til noen, legger du til mottakere i **Til**-feltet under fanene. For å gjøre meldingen tilgjengelig for personen via SuperOffice Kundesenter, må du angi tilgangsnivået (for meldingen) til **Eksternt**.

Her kan du skrive inn selve meldingen du vil legge til i saken. Dette fungerer på samme måte som når du skriver inn tekst i et tekstbehandlingsprogram. Du kan også legge til vedlegg, [svarmaler][2] og FAQ-er i meldingen.

Nederst i bildet finner du dessuten følgende alternativer:

* ![ikon][img1] – Klikk her for å vise eller skjule verktøylinjen i meldingsredigereren
* ![ikon][img2] – Klikk her for å vise alternativer for vedlegg. Her kan du legge til relevante dokumenter som vedlegg i saken.
  * Klikk på **Last opp filer (eller dra og slipp her)** for å bla til og legge til en fil fra en disk eller server.
  * Dra og slipp en fil fra Windows Utforsker til feltet for vedlegg.
  * Klikk på **Velg et CRM-dokument** for å velge et dokument i SuperOffice CRM.
* **Lim inn**: Klikk på listeknappen ![ikon][img3], og velg hva du vil sette inn i meldingen. Du kan legge til en svarmal, en FAQ-oppføring, en tidligere melding eller et vedlegg. Valgfritt: Du kan også [legge til svarmaler på andre språk][7]. Velg et språk i språklisten. Hvis tilgjengelig, settes teksten inn på det valgte språket. Ellers brukes standardspråket.
* **Intern/ekstern**: Her kan du velge **Ekstern** hvis personen skal ha tilgang til meldingen via SuperOffice Kundesenter, eller **Intern** hvis personen ikke skal ha tilgang til meldingen.
* **Medgått tid**: Her kan du registrere hvor mye tid som er brukt på behandling av meldingen. Klokken begynner automatisk når du oppretter saken. Du kan stoppe klokken ved å klikke på stoppknappen ![ikon][img4], og du kan også starte klokken på nytt ved å klikke på startknappen ![ikon][img5]. Klikk på knappen ![ikon][img6] (**Velg tidsperiode**) for å registrere tiden som er brukt.

> [!NOTE]
> Standard sakssignatur vil bli lagt til i meldingen. Du kan redigere signaturen direkte i meldingen eller redigere din standard [e-postsignatur][1].

## <a id="details" />Detaljer

Fanen **Detaljer** inneholder ytterligere detaljer om saken. Her finner du informasjon som når saken ble opprettet, når den sist ble endret, avsluttet eller besvart, når den ble lest av eieren eller personen, og ekstra felt. Denne informasjonen oppdateres automatisk i løpet av sakens levetid, men det er noen felt som kan redigeres når saken opprettes:

* **Relasjon**: Her kan du velge å knytte saken til en annen sak, hvis den nye saken er relatert til en eksisterende sak.
* **Tilgangsnivå**: Dette er en annen måte å angi tilgangsnivået for saken på. Dette kan også gjøres på **Egenskaper**-panelet. Hvis du endrer tilgangsnivået her, endres det automatisk på **Egenskaper**-panelet også.
* **Salg**: Her kan du knytte saken til et eksisterende salg ved å søke etter salget du ønsker, eller velge det fra listen.
* **Prosjekt**: Her kan du knytte saken til et eksisterende prosjekt ved å søke etter prosjektet du ønsker, eller velge det fra listen.

## Autolagring

Når du jobber med en sak og plutselig mottar en mer presserende sak, må du legge fra deg saken du jobber med, for å løse den prioriterte saken.

Autolagringsfunksjonen lagrer automatisk endringene dine helt til du klikker på **Send** eller forkaster endringene i saken.
Autolagret informasjon lagres lokalt i nettleseren din, slik at dataene dine til og med overlever nettleserkrasj, omstart, avlogging og pålogging.

Autolagringsfunksjonen aktiveres som standard når du viser og redigerer saker og svarer / svarer til alle.

### Begrensninger

* Automatisk lagrede data overføres ikke fra én datamaskin til en annen. Dette betyr at du ikke kan begynne å svare på en sak på jobben, og deretter fortsette hjemme.
* Automatisk lagrede data vil ikke bli delt mellom to forskjellige nettlesere.
* Autolagringsfunksjonen er en nyttig funksjon, men bør ikke erstatte korrekt lagring av arbeidet ditt.

## Detaljer

Denne fanen inneholder eventuelle ekstrafelt som er definert for saker. Dette vil variere fra firma til firma.

## Hva vil du gjøre nå?

* [Redigere melding][5]
* [Behandle saker][8]
* [Redigere e-postsignatur][1]
* [Eskaleringsnivå][3]
* [Bruke emneknagger i saker][4]
* [Legge til svarmaler i meldinger][2]
* [Opprette svarmal][9]
* [Opprette ny språkversjon av svarmal][7]

<!-- Referenced links -->
[1]: ../../../learn/getting-started/edit-email-signature.md
[2]: reply.md#reply-templ
[3]: ../priority/escalation-levels.md
[4]: ../tags.md
[5]: edit-message.md
[7]: ../../reply-templates/learn/new-language.md
[8]: ../index.md
[9]: ../../reply-templates/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/format-font.png
[img2]: ../../../../../common/icons/attachments-theme.png
[img3]: ../../../../../common/icons/copy-paste-icon.png
[img4]: ../../../../../common/icons/stop.png
[img5]: ../../../../../common/icons/play.png
[img6]: ../../../../../common/icons/timespan.png
