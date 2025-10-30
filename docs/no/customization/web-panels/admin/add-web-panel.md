---
uid: help-no-add-web-panel
title: Legg til webpanel
description: Slik legger du til elementer i webpanellisten i Innstillinger og vedlikehold.
keywords: webpanel, listen GUI - Webpanel
author: digitaldiina
date: 11.04.2025
version: 11.6
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
content_type: howto
language: no
index: true
redirect_from: /no/admin/lists/learn/web-panel-add-item
---

# Legg til webpanel

[!include[Must be admin](../../../learn/includes/req-admin.md)]

Webpaneler defineres i listen **GUI - Webpanel**, som du kan administrere i **Innstillinger og vedlikehold** under **Lister**. Hvor webpanelet ditt vises bestemmes av *Synlig i*. Innholdet i webpanelet ditt bestemmes av URL-adressen.

## Trinn

1. Velg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Velg **GUI - Webpanel** fra rullegardinmenyen. Fanen **Elementer** viser alle eksisterende webpaneler.

1. Klikk **Legg til** for å åpne dialogboksen **Rediger listeelement**.

1. Skriv inn etiketten som skal vises i SuperOffice CRM, i feltet **Navn**. *(Obligatorisk)*

    * Legg eventuelt inn en beskrivelse av forekomsten i feltet **Beskrivelse**. Les om [Oversettelse][3].

1. I **URL-feltet** angir du URL-adressen, for eksempel en webside eller en serverbasert HTML-fil. For detaljer om støttede URL-typer, se [Bruke HTTP vs HTTPS-nettadresser](#https).

    * I feltet **URL-format**, velg *Ingen*, *ANSI*, eller *Unicode*.

1. I feltet **Vindusnavn**, angi det påkrevde navnet på nettleservinduet der URL-adressen skal åpnes. Hvis du har lagt til ett eller flere vindusnavn tidligere og ønsker å bruke det samme om igjen, kan du klikke i feltet og velge navn fra listen. Du kan også skrive inn et nytt navn direkte i feltet. Det endelige vindusnavnet vises nedenfor med strek under.

1. I listeboksen **Synlig i**, velg hvor webpanelet skal vises i SuperOffice CRM.

1. Under **Tilgjengelig på**, velg ett eller begge alternativer:
    * **SuperOffice CRM for Web**
    * **Mobile CRM**

1. (Valgfritt) Slik styrer du hvordan panelet skal oppføre seg:

    * Velg **Last alltid innhold på nytt ved fanebytte** hvis innholdet skal oppdateres hver gang brukeren bytter fane.
    * Velg **Ikke last innhold på nytt ved navigering til hovedkort** for å bufre innhold under kortnavigering.
    * Velg **Vis kobling for å åpne i nytt vindu** hvis panelet også skal åpnes i et nytt nettleservindu.

1. (Valgfritt) Klikk på **Ikon**-listen for å velge et ikon for webpanelet.

1. Klikk **Lagre** for å lagre endringene eller **Avbryt** for å forkaste dem.

## Etter lagring

Når elementet er lagret, kan du:

* Endre rekkefølgen på elementer ved hjelp av pilknappene til venstre for listen (<i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).

* Spesifisere ytterligere innstillinger for hvert element:
  * Hvilke [brukergrupper elementet er synlig for][7].
  * Hvilken [overskrift][6] det skal vises under.

## <a id="fields"></a>Referanse

| Innstilling | Beskrivelse |
|---|---|
| Navn | UI-etikett |
| Vindusnavn | ID for panelet, brukt i HTML-en som lastes inn i panelene. Må være unik, bruk prefiks |
| Beskrivelse | Verktøytips-tekst |
| URL | Plassering av nettside |
| [URL-koding][2] | Ingen, ANSI eller Unicode |
| Synlig i | Visningsplassering. Du kan velge mellom paneler, dialogbokser, menyer, knapperad eller sidepanelplasseringer. For en fullstendig liste over visningsalternativer, se [Visningsplasseringer for nettleserfaner][8]. |
| Tilgjengelig på | Enhetstype (web, mobil) - hvor du vil at URL-adressen skal være tilgjengelig |

### <a id="https"></a>Bruke HTTP vs HTTPS-nettadresser

[!include[HTTPS restriction](../../includes/web-panels-and-https.md)]

### Bruke malvariabler

Hvis du legger til en URL-adresse, kan det være nyttig å bruke malvariabler for det aktive firmaet, for eksempel for å hente informasjon fra andre applikasjoner via en URL. URL-adressen må spesifisere parametere, som i dette fiktive eksempelet: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn er her malvariabelen for organisasjonsnummeret, men andre variabler som firmanavn &lt;name&gt;, firmatelefonnummer &lt;cpho&gt;, kontaktnavn &lt;attn&gt; kan også brukes.

## Legg til webpanel i Service (utdatert)

I Service kalles webpaneler for **ekstra nettleserfaner**. Du kan legge til samme type innhold som for [ekstra menyer][4].

1. Logg inn i SuperOffice Service.
1. Gå til hamburgermenyen, velg **Systemdesign**, og deretter **Webpaneler**.
1. Pek på ønsket visningsplassering, og klikk på **Nytt webpanel**.
1. Skriv inn en UI-etikett (faneteksten).
1. Velg enten **Bruk URL** eller **Bruk skjermbilde**, og angi relevante detaljer.
1. Velg hvor det nye menyelementet skal settes inn i listen **Posisjon** (0 = øverst).
1. Klikk på **OK**.
1. Test resultatet.

## Relatert innhold

* [Legg til et oppgavemenyvalg][1]
* [Grunnprogrammer og URL-parametere][5]

<!-- Referenced links -->
[1]: ../../admin/add-items-to-task-menu.md
[2]: url-encoding.md
[3]: ../../../localization/learn/translate-fields.md
[4]: ../../../ui/blogic/learn/extra-menus/index.md
[5]: ../../../../en/ui/blogic/url-parameters.md
[6]: ../../../admin/lists/headings.md
[7]: ../../../admin/lists/user-group-filtering.md
[8]: index.md

<!-- Referenced images -->