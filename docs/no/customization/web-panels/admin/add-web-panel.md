---
uid: help-no-add-web-panel
title: Legg til webpanel
description: Slik legger du til elementer i webpanellisten i Innstillinger og vedlikehold.
keywords: webpanel, listen GUI - Webpanel
author: digitaldiina
date: 10.13.2025
version: 11.5
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

Webpaneler er definert i listen **GUI - Webpanel**, som du kan administrere i **Innstillinger og vedlikehold** under **Lister**.

## Trinn

1. Velg <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lister** i navigatoren.

1. Velg **GUI - Webpanel** fra rullegardinmenyen. Fanen **Elementer** viser alle eksisterende webpaneler.

1. Klikk **Legg til** for å åpne dialogboksen **Rediger listeelement**.

1. Skriv inn ønsket navn på forekomsten i feltet **Navn**. *(Obligatorisk)*

    * Dette navnet vises når du legger inn URL-adressen i SuperOffice CRM.

1. I **URL-feltet** angir du URL-adressen, for eksempel en webside eller en serverbasert HTML-fil. [Bruke HTTP vs HTTPS-nettadresser](#https)

1. I feltet **Vindusnavn** angir du det påkrevde navnet på nettleservinduet der URL-adressen skal åpnes. Hvis du har lagt til ett eller flere vindusnavn tidligere og ønsker å bruke det samme om igjen, kan du klikke i feltet og velge navn fra listen. Du kan også skrive inn et nytt navn direkte i feltet. Det endelige vindusnavnet vises nedenfor med strek under.

1. I listeboksen **Synlig i** velger du hvor nettadressen skal være tilgjengelig i SuperOffice CRM.
    * **Sidepanel**: Velg dette alternativet for å gjøre URL-adressen tilgjengelig i sidepanelene i SuperOffice CRM.

    * **Knapperad**: Velg dette alternativet for å gjøre URL-adressen tilgjengelig som en knapp i knapperaden.

    * **Navigatorknapp**: Velg dette alternativet for å gjøre nettadressen tilgjengelig som en knapp i navigatoren i SuperOffice CRM.

    * **Panel**: Velg [et alternativ i denne listen](#options) for å gjøre nettadressen tilgjengelig som et panel / en fane i SuperOffice CRM.

    * **Dialog**: Velg et [alternativ i denne listen](#options) for å gjøre URL-adressen tilgjengelig i en dialogboks.

    * **Meny**: Velg et [alternativ i denne listen](#options) for å gjøre URL-adressen tilgjengelig fra en av menyene i SuperOffice CRM.

1. I listeboksen **URL-format** kan du velge om [URL-adressen][2] skal være ANSI eller Unicode (eller uten format).

1. Under **Vis** merker du av for de linjene som skal være tilgjengelige i nettleservinduet som URL-adressen åpnes i: menylinje, knapperad, adresselinje og statuslinje.

1. Under **Tilgjengelig på** velger du hvor du vil at URL-adressen skal være tilgjengelig. Du kan velge flere av disse alternativene samtidig.
    * **SuperOffice CRM for Web**: Når du bruker Web-versjonen av SuperOffice CRM.
    * **Mobile CRM**: Når du bruker mobilversjonen av SuperOffice CRM.

    Ekstra innstillinger:
    * **Last alltid innhold på nytt** ved fanebytte.
    * **Vis kobling** for å åpne i nytt vindu.

1. Klikk på **Ikon**-listen for å velge et ikon for webpanelet.

1. Legg eventuelt inn en beskrivelse av forekomsten i feltet **Beskrivelse**. Les om [Oversettelse][3].

1. Klikk **Lagre** for å lagre endringene eller **Avbryt** for å forkaste dem.

> [!TIP]
> Når du legger til en URL-adresse, kan det være nyttig å bruke malvariabler for aktivt firma, for eksempel for å hente informasjon fra andre applikasjoner via URL. URL-adressen må angi parametere, for eksempel slik: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn her er malvariabelen for organisasjonsnummeret, men andre variabler som firmanavn &lt;name&gt;, firmatelefonnummer &lt;cpho&gt; og navn på personen &lt;attn&gt;, kan også brukes.

## <a id="options"></a>Alternativer

### Panel

* **Firmakort**, **Personkort**, **Prosjektkort**, **Utvalgskort** og **Salgskort**: Det legges inn en snarvei til URL-adressen øverst i fanen **www** i bildene Firma, Person, Prosjekt, Utvalg og Salg. Når du klikker på snarveien i SuperOffice CRM, vises den aktuelle nettsiden i et lite vindu med rullefelt i fanen. Der er det også mulig å klikke på **Åpne i eget vindu** for å åpne nettsiden i et frittstående nettleservindu.

* **Webpanel**: URL-adressen legges til i webpanelet i SuperOffice CRM. Dermed kan adressen åpnes som en Internett-side. Hvis det er definert flere URL-adresser for webpanelet, vises de som faner til høyre i webpanelet. Webpanelet åpnes ved å klikke på SuperOffice-logoen øverst til venstre i SuperOffice CRM.

* Detaljkort i Firma-, Person-, Prosjekt- og Salg-bildet: URL-adressen legges til som et ekstra detaljkort i Firma/Person/Prosjekt/Lær/Salg-bildet. Når du velger detaljkortet i SuperOffice CRM, åpnes URL-adressen. Der er det også mulig å klikke på **Åpne i eget vindu** for å åpne nettsiden i et frittstående nettleservindu.

### Dialogboks

* **Dialogboksen for oppfølginger**: Det legges inn en snarvei til URL-adressen øverst i fanen **www** i dialogboksen **Oppfølging**. Der er det også mulig å klikke på **Åpne i eget vindu** for å åpne nettsiden i et frittstående nettleservindu.

* **Dialogboksen Dokument/Tilbud/Produkt**: Det legges inn en snarvei til URL-adressen øverst i fanen **www** i disse dialogboksene.

### Meny

* **Verktøykassemeny**: URL-adressen vises når brukeren klikker på **Verktøy**-knappen (<i class="ph ph-wrench" aria-hidden="true"></i>) i navigatoren eller velger **Andre applikasjoner** i SuperOffice CRM.

* **Vis-menyen**: URL-adressen vises når brukeren velger **Andre applikasjoner** i SuperOffice CRM.

## <a id="fields"></a>Referanse

| Innstilling | Beskrivelse |
|---|---|
| Navn | UI-etikett |
| Vindusnavn | ID for panelet, brukt i HTML-en som lastes inn i panelene. Må være unik, bruk prefiks |
| Beskrivelse | Verktøytips-tekst |
| URL | Plassering av nettside |
| URL-koding | Ingen, ANSI eller Unicode |
| Synlig i | Visningsplassering |
| Tilgjengelig på | Enhetstype (web, mobil) |
| Vis | Om menylinjen, verktøylinjen, adresselinjen og/eller statuslinjen skal vises |

## <a id="https"></a>Bruke HTTP vs HTTPS-nettadresser

[!include[HTTPS restriction](../../../admin/lists/learn/includes/web-panels-and-https.md)]

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
[1]: ../../../admin/lists/learn/add-items-to-task-menu.md
[2]: url-encoding.md
[3]: ../../../localization/learn/translate-fields.md
[4]: ../../../ui/blogic/learn/extra-menus/index.md
[5]: ../../../../en/ui/blogic/url-parameters.md

<!-- Referenced images -->