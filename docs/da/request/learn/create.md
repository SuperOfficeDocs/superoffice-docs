---
uid: help-da-request-create
title: Opret en sag
description: Lær, hvordan du opretter en ny sag i SuperOffice.
keywords: opret sag, ny sag, sagsdetaljer, sagsegenskaber, meddelelse, sagsbehandling
author: Bergfrid Dias
date: 03.11.2025
version: 10.5.3
topic: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: da
---

# Opret en sag

En sag kan komme ind i systemet via en e-mail fra kunden, eller du kan registrere den manuelt via skærmbilledet **Ny sag**. Dette er relevant, hvis en kunde kontakter dig via telefon.

## Trin

1. Klik på **Ny** i toplinjen, og vælg **Sag**.

    Alternativt, hvis du er i detaljekortet **Sager** for en kontakt, kan du klikke på **Tilføj** for at oprette en sag med personen forudfyldt.

1. I feltet **Titel** skal du angive et beskrivende navn for sagen.

1. Tilføj en person i feltet **Søg efter person** (hvis ikke forudfyldt). Begynd at skrive navnet (eller telefonnummeret), og vælg fra resultaterne.
    * Valgfrit: Du kan springe dette trin over og tilføje personen senere.

1. Brug panelet **Egenskaber** til højre til at tildele og prioritere sagen.

    * Vælg **Sagstype**, **Status**, **Ejer**, **Kategori**, **Prioritet** og andre egenskaber.

    > [!NOTE]
    > Sagstypen påvirker standardværdier og tilgængelige statusser og prioriteter.

1. Gå til fanen **Meddelelser** for at skrive selve sagen:

    * I feltet **Til** tilføjes modtager(e). Begynd at skrive personens navn eller e-mailadresse, og vælg dem fra listen.
    * Valgfrit: Klik på **Cc/Bcc** for at tilføje modtagere som kopi eller blind kopi.
    * Indtast selve meddelelsen, vedhæft filer, eller indsæt svarskabeloner.

    > [!NOTE]
    > Standardsignaturen for sager føjes automatisk til meddelelsen. Du kan redigere signaturen direkte i meddelelsen eller opdatere din [e-mail-signatur][11].

1. Gå til fanen **Detaljer** for at knytte sagen til et eksisterende salg eller projekt (valgfrit).

1. Klik på **Send** for at gemme og sende sagen.

![Egenskaber og meddelelse i en ny sag -screenshot][img1]

## <a id="fields"></a>Vigtige felter forklaret

<a id="message"></a><a id="details"></a>
Følgende felter er tilgængelige i skærmbilledet Sag. Nogle felter udfyldes automatisk, mens andre kræver input.

> [!NOTE]
> Felter og layout kan variere afhængigt af [Screen designer][10]-konfigurationer og andre UI-tilpasninger.

<!-- markdownlint-disable-file MD051 -->
### [Fanen Meddelelser](#tab/messages)

Her kan du skrive og administrere selve sagen.

* Tilføj modtagere i feltet **Til**.
  * Modtagere tilføjes automatisk som personer i sagen. Den første modtager bliver hovedpersonen.
  * Tilføj flere modtagere, og omarranger dem ved at trække og slippe.
  * For at inkludere en modtager uden at registrere dem som kontakt, indtast e-mailadressen. De vil modtage meddelelsen, men ikke fremgå som person i sagen.
  * Lad feltet være tomt, hvis du ikke vil sende meddelelsen.
* Klik på **Cc/Bcc** for at tilføje yderligere modtagere som kopi eller blind kopi.
* Indsæt en meddelelsestekst, vedhæft filer, eller brug [svarskabeloner][2] og FAQ-indlæg.
* Brug **Intern/Ekstern** til at bestemme, om kontakten kan se meddelelsen i kundecenteret.
* Brug timeren til at spore tidsforbruget på sagen.

Meddelelseseditoren fungerer som en tekstbehandler, så du kan skrive, formatere og forbedre dine meddelelser. Her er de vigtigste værktøjer og deres funktioner:

| Ikon | Handling | Beskrivelse |
|:-:|---|---|
| <i class="ph ph-text-a-underline" aria-label="Vis/skjul værktøjslinje"></i> | Værktøjslinje | Vis eller skjul formateringsmuligheder. |
| <i class="ph ph-paperclip" aria-label="Vedhæft"></i> | Vedhæftninger | Tilføj filer eller CRM-dokumenter til sagen. |
| <i class="ph ph-article" aria-label="Indsæt"></i> | Indsæt | [Indsæt en svarskabelon][2], FAQ-indlæg, tidligere meddelelse eller vedhæftet fil. |

#### Vedhæftninger

For at vedhæfte filer eller CRM-dokumenter:

1. Klik på <i class="ph ph-paperclip" aria-label="Vedhæft"></i>. Et **Vedhæftninger**-felt vises under **Til**-feltet.
1. Tilføj vedhæftninger på én af følgende måder:
    * Klik på **Upload filer (eller træk her)** for at vælge en fil fra din computer.
    * Træk og slip filer i **Vedhæftninger**-feltet.
    * Klik på **Vælg et CRM-dokument** for at vælge en fil gemt i SuperOffice CRM.

#### Indsæt

For at tilføje ekstra indhold til meddelelsen:

1. Klik på <i class="ph ph-article" aria-label="Indsæt"></i>.
1. Vælg, hvad der skal tilføjes:
    * **Svarskabelon:** Indsæt en foruddefineret tekst.
    * **FAQ-post:** Tilføj et relevant vidensbase-indlæg.
    * **Tidligere meddelelse:** Genbrug tekst fra en tidligere sag.
    * **Vedhæftning:** Vedhæft en fil direkte.
1. Hvis svarskabeloner findes på flere sprog, kan du vælge et sprog.

#### Registrering af tid

Uret starter automatisk, når du opretter sagen. Du kan stoppe det ved at klikke på <i class="ph ph-pause" aria-label="Pause"></i> og genstarte ved at klikke på <i class="ph ph-play" aria-label="Start"></i>. For mere info, se [Registrer tidsforbrug][3].

### [Fanen Detaljer](#tab/details)

Fanen **Detaljer** indeholder yderligere informationer om sagen. Her finder du informationer som, hvornår sagen blev oprettet, hvornår den sidst blev ændret, lukket eller besvaret, hvornår den blev læst af ejeren eller personen og ekstra felter. Disse oplysninger opdateres automatisk, mens sagen behandles. Dog er der nogle felter, som kan redigeres ved oprettelse af en sag:

* **Relation:** Link denne sag til en anden, hvis den relaterer sig til en eksisterende sag.
* **Adgangsniveau:** En alternativ måde at indstille synligheden af sagen. Ændringer her afspejles automatisk i **Egenskaber**-panelet.
* **Salg/Projekt:** Knyt sagen til et eksisterende salg eller projekt.
* **Ekstra felter:** Yderligere [tilpassede felter][16], afhængigt af din organisations opsætning.

### [Panelet Egenskaber](#tab/properties)

Panelet **Egenskaber** giver dig mulighed for at kategorisere og tildele sagen.

* **Sagstype:** Bestemmer standardværdier og tilgængelige statusser.
* **Status:** Indstil til **Aktiv** (under behandling), **Afsluttet** (fuldført) eller **Udsat** (med angivet dato for genåbning).
* **Ejer:** Tildel sagen til dig selv, en anden bruger, eller lad den være ufordelt.
  * **(Automatisk tildelt):** Systemet tildeler sagen efter gældende regler.
  * **(Ufordelt):** Ansvar deles mellem kategoriens medlemmer.
* **Kategori:** Vælg den relevante kategori for sagen.
* **Prioritet:** Indstil til **Lav**, **Middel** eller **Høj**, eller lad systemet bestemme (f.eks. baseret på [eskaleringsniveauer][9]).
* **Adgangsniveau:** Indstil til **Ekstern** (synlig for personen) eller **Intern** (skjult for personen).
* **Tags:** [Tilføj relevante tags][4] for nem organisering og søgning senere.

***

## Automatisk gemning

Hvis du arbejder på en sag og pludselig skal håndtere en mere presserende opgave, kan du forlade sagen, uden at miste dine ændringer.

Autosave-funktionen gemmer automatisk ændringer, indtil du klikker **Send** eller vælger at annullere.
Autosavede data gemmes lokalt i din browser, så de overlever et browsernedbrud, genstart, logout og login.

Funktionen er som standard aktiveret ved visning og redigering af sager samt ved besvarelse.

### Begrænsninger

* Automatisk gemte data overføres ikke fra én computer til en anden. Det betyder, at du ikke kan begynde at svare på en sag på arbejdet og derefter fortsætte derhjemme.
* Automatisk gemte data deles ikke mellem to forskellige browsere.
* Funktionen til automatisk gemning er en nyttig funktion, men bør ikke erstatte gemning af dit arbejde på den rigtige måde.

## Relateret indhold

* [Rediger e-mail-signatur][11]
* [Brug af tags i sager][4]
* [Svarskabelon-variabler][18]
* [Opret svarskabelon][19]

<!-- Referenced links -->
[2]: reply.md#reply-templ
[3]: reply.md#time-spent
[4]: tags.md
[9]: ../admin/priority/escalation-levels.md
[10]: ../../ui/screen-designer/learn/index.md
[11]: ../../learn/getting-started/edit-email-signature.md
[16]: ../../custom-objects/admin/create-extra-field.md
[18]: ../reply-templates/learn/template-variables.md
[19]: ../reply-templates/learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/create-request.png
