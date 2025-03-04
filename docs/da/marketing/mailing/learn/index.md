---
uid: help-da-mailing
title: Arbejde med udsendelser
description: Arbejde med udsendelser
keywords: Marketing, udsendelse
author: SuperOffice RnD, Jeanette Small Strøm
date: 02.26.2024
version: 10
topic: concept
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Arbejde med udsendelser

En udsendelse håndteres normalt i to trin:

* [Forberedelse og afsendelse af mailing][1]
* [Opfølgning på den afsendte mailing](#after)

## Udsendelsestype

* E-mail
* SMS
* Dokument
* Formularbesvarelse

> [!NOTE]
> E-mailudsendelser (og formularbesvarelser) er de typer udsendelser, der har flest funktioner. Funktioner som f.eks. [sporede links][7] og [tilmeldingslinks][6] er ikke tilgængelige i SMS-udsendelser og dokumentudsendelser.

## Definér dit mål

For at sikre, at din mailudsendelse bliver en succes, skal du først og fremmest nå ud til de rigtige mennesker. Jo mere du kan indsnævre din målgruppe, jo større er dine chancer for, at det rigtige budskab når ud til den rigtige person.

Hvad vil du opnå med din mailudsendelse? Vil du gerne:

* Skaffe flere kundeemner?
* Sælge flere nye produkter eller tjenester til dine eksisterende kunder?
* Øge dine kunders loyalitet og fastholde dem?
* Informere om nye udviklinger, milepæle eller forslag?

I SuperOffice CRM er der mange måder at oprette en stabil [målliste][8] på. Du kan anvende udvalg, projekter eller en enkelt kontakt, der er gemt i systemet. Alle kontakter, der endnu ikke er tilgængelige i SuperOffice CRM-databasen, kan tilføjes ved at importere en Excel-liste, forudsat at du har deres samtykke til, at du må sende dem  marketingmeddelelser fra din virksomhed.

Du kan også oprette en mailingliste ved hjælp af [online webformularer][5]. Ikke alene kan du fange nye kundeemner blandt de besøgende på dit websted, der udfylder en webformular, men du kan også bruge webformularer til at invitere folk til at abonnere eller tilmelde sig forskellige mailudsendelser.

Få mere at vide om, hvordan du [opretter og bruger webformularer i Marketing][4].

## Modtagere

Du kan tilføje modtagere fra flere kilder.

> [!NOTE]
> Når du tilføjer modtagere, er det udelukkende personer med en gyldig e-mailadresse (eller gyldigt mobiltelefonnummer, når der er tale om SMS-udsendelser), der bliver føjet til listen **Modtagere**.

Importerede modtagere, der IKKE findes i SuperOffice-databasen, vil kun bestå af et navn og en e-mail-adresse (eller bare en e-mail-adresse). Dette betyder, at kun skabelonvariablerne **\[\[customer.name\]\]** og/eller **\[\[customer.email\]\]** kan bruges for disse modtagere. For at undgå tomme variabler i dine udsendelser, skal du sørge for først at gå ind på [forhåndsvisning af udsendelsen][3].

## At knytte en udsendelse til et udtræk eller et projekt

Du kan knytte udsendelsen til et udtræk og/eller et projekt, så du kan holde styr på alle udsendelser i forbindelse med dine udtræk og projekter. Udsendelserne er listet i fanen **Udsendelser** i fanebladet **Udvalg**, og i **Handlinger** i **Projekter** i SuperOffice CRM.

> [!NOTE]
> Hvis du tilføjer et udtræk, bliver alle kontakter i udtrækket eller projektet tilføjet som modtagere af udsendelsen. Hvis du tilføjer både et udtræk og et projekt, er det kun kontakter fra udtrækket, der tilføjes som modtagere.

Eksempel: Hvis du sender flere udsendelser for at gøre opmærksom på en event, kan du tilføje disse udsendelser til et udvalg ved navn "Event 2015", så du får en komplet liste over alle udsendelser i relation til denne event. Hvis du opretter et projekt til din event, kan du på samme måde gemme en liste over projektrelaterede udsendelser under fanebladet **Handlinger**.

## Betydningen af e-maillevering

E-mailmarkedsføring er en omkostningseffektiv marketingstrategi, der kan resultere i [høj afkastning af investering][20]. Men for at få mest muligt ud af dette marketingværktøj skal dine e-mails nå frem til din målgruppes indbakke, ikke deres SPAM-mappe.

Forestil dig dette scenarie: Du har omhyggeligt skabt en e-mailkampagne med førsteklasses indhold og design, trykket på send-knappen og får lidt til ingen respons. Din åbningsrate er skuffende, og der er mange bounces, eller endnu værre, du bliver markeret som spam.

**E-maillevering** er afgørende, fordi det afgør, om dine e-mails rent faktisk når frem til abonnenternes indbakker eller ej. Hvis de ikke leveres, vil de ikke blive set eller læst af din målgruppe, hvilket betyder tabte muligheder og mindre succesfulde e-mailmarkedsføringskampagner. Se vores [bedste praksisser][9].

## <a id="after"></a>Hvordan kan jeg følge op udsendelser?

Når din mail er sendt ud, er det altid spændende at se, hvor godt den klarede sig, så du kan se, om alt dit hårde arbejde har været det værd. Det er også en fantastisk mulighed for at tjekke og forbedre kvaliteten af de oplysninger, der er registreret i din CRM-database.

* Du kan [se statistik][2] på mailudsendelsen og få oplysninger om eventuelle problemer.
* Du kan [tilføje modtagere til udvalg og projekter][12] for at arbejde videre med dem.
* Du kan [tjekke og rette mailadresserne på ikke-leverede mails][11].
* Du kan [se, hvem der har klikket på de sporbare links][14], du har indsat i beskeden.
* Du kan administrere mailadresserne på afviste mails, der er returneret på grund af permanente fejl, eller som er blevet [afvist][13] flere gange.

<!-- Referenced links -->
[1]: create/index.md
[3]: create/send-test-email.md
[2]: view-statistics.md
[4]: ../../forms/learn/create.md
[6]: ../../editor/learn/add-unsubscribe-link.md
[9]: ../../learn/best-practices.md
[8]: ../../recipients/learn/index.md
[11]: ../../recipients/learn/look-at-recipient-list.md
[12]: ../../recipients/learn/look-at-recipient-list.md#add-recipients
[13]: ../../recipients/learn/manage-bounces.md
[14]: ../../tracked-links/learn/explore-clicks.md
[7]: ../../tracked-links/learn/index.md
[5]: https://www.superoffice.co.uk/resources/articles/integrated-web-forms/
[20]: https://www.superoffice.com/blog/email-marketing-strategy/

<!-- Referenced images -->