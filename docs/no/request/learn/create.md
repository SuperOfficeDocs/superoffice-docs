---
uid: help-no-request-create
title: Opprette en sak
description: Opprette en sak
keywords: opprett sak, legg til sak, ny sak, saksdetaljer, melding, sak
author: Bergfrid Dias
date: 03.11.2025
version: 10.5.3
topic: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: no
---

# Opprette en sak

En sak kan komme inn i systemet via en e-post fra kunden, eller du kan registrere den manuelt via bildet **Ny sak**. Dette er aktuelt hvis en kunde kommer med en henvendelse via telefon.

## Trinn

1. Klikk **Ny** i toppraden, og velg **Sak**.

    Alternativt, hvis du er i detaljkortet **Saker** for en person, kan du klikke på **Legg til** for å opprette en sak med personen forhåndsutfylt.

1. I feltet **Tittel** gir du saken et beskrivende navn.

1. Legg til en person i feltet **Søk etter person** (hvis ikke forhåndsutfylt). Begynn å skrive navnet (eller telefonnummeret), og velg fra resultatene.
    * Du kan eventuelt hoppe over dette trinnet og legge til personen senere.

1. Bruk panelet **Egenskaper** til høyre for å tildele og prioritere saken.

    * Velg **Sakstype**, **Status**, **Eier**, **Kategori**, **Prioritet** og andre egenskaper.

    > [!NOTE]
    > Sakstypen påvirker standardverdier, samt tilgjengelige statuser og prioriteringer.

1. Gå til fanen **Meldinger** for å skrive inn saksmeldingen:

    * I feltet **Til** legger du til mottakeren(e). Begynn å skrive navnet eller e-postadressen, og velg dem fra listen.
    * Valgfritt: Klikk **Kopi/Blindkopi** for å legge til mottakere som kopi eller blindkopi.
    * Skriv inn meldingsteksten, legg til vedlegg eller sett inn svarmaler.

    > [!NOTE]
    > Standardsignaturen for saker legges til meldingen. Du kan redigere signaturen direkte i meldingen eller endre din standard [e-postsignatur][11].

1. Gå til fanen **Detaljer** for eventuelt å knytte saken til et eksisterende salg eller prosjekt.

1. Klikk **Send** for å lagre og sende saken.

![Saksegenskaper og melding for en ny sak -screenshot][img1]

## <a id="fields"></a>Viktige felt forklart

<a id="message"></a><a id="details"></a>
Følgende felt er tilgjengelige i Saks-bildet. Noen fylles ut automatisk, mens andre krever manuell inndata.

> [!NOTE]
> Felt og oppsett kan variere basert på [Skjermdesigner][10]-konfigurasjoner og andre UI-tilpasninger.

<!-- markdownlint-disable-file MD051 -->
### [Meldinger-fanen](#tab/messages)

Her skriver og håndterer du saksmeldingen.

* Legg til mottakere i feltet **Til**.
  * Mottakere legges automatisk til som sakspersoner. Den første mottakeren blir primærkontakt for saken.
  * Du kan legge til flere mottakere og endre rekkefølgen ved å klikke og dra.
  * Hvis du vil inkludere en mottaker uten å registrere vedkommende som person, kan du skrive inn e-postadressen.
  * La feltet være tomt hvis du ikke vil sende meldingen.
* Klikk **Kopi/Blindkopi** for å legge til flere mottakere.
* Inkluder meldingstekst, vedlegg, [svarmaler][2] eller FAQ-oppføringer.
* Bruk **Intern/Ekstern** for å bestemme om kunden skal se meldingen i kundesenteret.
* Bruk tidtakeren for å registrere tid brukt på saken.

Meldingseditoren fungerer som et tekstbehandlingsprogram og gir mulighet for formatering og innholdstilpasning.

| Symbol | Handling | Beskrivelse |
|:-:|---|---|
| <i class="ph ph-text-a-underline"></i> | Verktøylinje | Vis/skjul tekstformateringsalternativer. |
| <i class="ph ph-paperclip"></i> | Vedlegg | Legg til filer eller CRM-dokumenter i meldingen. |
| <i class="ph ph-article"></i> | Sett inn | [Sett inn en svarmal][2], FAQ-oppføring, tidligere melding eller vedlegg. |

#### Vedlegg

For å legge til filer eller CRM-dokumenter:

1. Klikk på <i class="ph ph-paperclip" aria-label="Attachments"></i>. Et **Vedlegg**-felt vises under **Til**-feltet.
1. Legg til vedlegg på én av disse måtene:
    * Klikk **Last opp filer (eller dra hit)** for å velge en fil fra datamaskinen din.
    * Dra og slipp filer i **Vedlegg**-feltet.
    * Klikk **Velg et CRM-dokument** for å velge en fil lagret i SuperOffice CRM.

#### Sett inn

For å legge til ekstra innhold i meldingen:

1. Klikk <i class="ph ph-article" aria-label="Insert"></i>.
1. Velg hva du vil sette inn:
    * **Svarmal:** Sett inn forhåndsskrevet tekst.
    * **FAQ-oppføring:** Legg til en kunnskapsbase-artikkel.
    * **Tidligere melding:** Gjenbruk tekst fra tidligere kommunikasjon.
    * **Vedlegg:** Legg ved en fil direkte.
1. Hvis svarmaler er tilgjengelige på flere språk, kan du velge språk.

#### Medgått tid

Tidtaker starter automatisk når du oppretter saken. Du kan stoppe den ved å klikke på <i class="ph ph-pause" aria-label="Pause"></i>, og starte den igjen med <i class="ph ph-play" aria-label="Play"></i>. Se [Registrere medgått tid][3] for mer informasjon.

### [Detaljer-fanen](#tab/details)

Fanen **Detaljer** inneholder tilleggsinformasjon om saken. Her finner du informasjon som når saken ble opprettet, når den sist ble endret, avsluttet eller besvart, når den ble lest av eieren eller personen, og ekstra felt. Denne informasjonen oppdateres automatisk i løpet av sakens levetid, men det er noen felt som kan redigeres når saken opprettes:

* **Relasjon:** Knytt saken til en annen relatert sak.
* **Tilgangsnivå:** Juster synligheten for saken. Endringer her reflekteres automatisk i **Egenskaper**-panelet.
* **Salg/Prosjekt:** Koble saken til et eksisterende salg eller prosjekt.
* **Ekstrafelt:** Ytterligere [brukerdefinerte felt][16] basert på organisasjonens oppsett.

### [Egenskaper-panelet](#tab/properties)

**Egenskaper-panelet** brukes til å kategorisere og tildele saken.

* **Sakstype:** Bestemmer standardverdier og statusalternativer.
* **Status:** Angi **Åpen**, **Avsluttet** (utført, lukket) eller **Utsatt** (med spesifisert oppfølgingstid).
* **Eier:** Tildel saken til deg selv, en annen bruker, eller la den være ufordelt.
  * **(Automatisk tildelt):** Systemet fordeler saken etter reglene.
  * **(Ufordelt):** Kategorimedlemmer deler ansvaret.
* **Kategori:** Velg relevant kategori.
* **Prioritet:** Angi **Lav**, **Medium** eller **Høy**, eller la systemet bestemme (f.eks. basert på [eskaleringsnivåer][9]).
* **Tilgangsnivå:** Sett som **Ekstern** (synlig for kunden via SuperOffice Kundesenter) eller **Intern** (skjult for kunden).
* **Emneknagger:** [Legg til relevante emneknagger][4] for enklere organisering.

***

## Autolagring

Når du jobber med en sak og plutselig mottar en mer presserende sak, må du legge fra deg saken du jobber med, for å løse den prioriterte saken.

Autolagringsfunksjonen lagrer automatisk endringene dine helt til du klikker på **Send** eller forkaster endringene i saken.
Autolagret informasjon lagres lokalt i nettleseren din, slik at dataene dine til og med overlever nettleserkrasj, omstart, avlogging og pålogging.

Autolagringsfunksjonen aktiveres som standard når du viser og redigerer saker og svarer / svarer til alle.

### Begrensninger

* Automatisk lagrede data overføres ikke fra én datamaskin til en annen. Dette betyr at du ikke kan begynne å svare på en sak på jobben, og deretter fortsette hjemme.
* Automatisk lagrede data vil ikke bli delt mellom to forskjellige nettlesere.
* Autolagringsfunksjonen er en nyttig funksjon, men bør ikke erstatte korrekt lagring av arbeidet ditt.

## Relatert innhold

* [Redigere e-postsignatur][11]
* [Bruke emneknagger i saker][4]
* [Malvariabler][18]
* [Opprette svarmal][19]

<!-- Refererte lenker -->
[2]: reply.md#reply-templ
[3]: reply.md#time-spent
[4]: tags.md
[9]: ../admin/priority/escalation-levels.md
[10]: ../../ui/screen-designer/learn/index.md
[11]: ../../learn/getting-started/edit-email-signature.md
[16]: ../../custom-objects/admin/create-extra-field.md
[18]: ../reply-templates/learn/template-variables.md
[19]: ../reply-templates/learn/index.md

<!-- Refererte bilder -->
[img1]: ../../../media/loc/en/request/create-request.png
