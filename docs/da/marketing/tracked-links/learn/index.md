---
uid: help-da-mailing-tracked-links
title: Sporede links
description: Et link, der sættes ind i en mailudsendelse, kan bruges til at spore besvarelser fra både eksisterende og potentielle kunder. Når modtagerne af din mailudsendelse klikker på linket, aktiveres en handling.
author: SuperOffice RnD
keywords: Marketing
date: 11.19.2024
version: 10.3.12
topic: concept
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Sporede links

De links, som du bruger i dit nyhedsbrev eller e-mailkampagne, bestemmes af dine mål. Hver mål har en unik opfordring til handling, der udløser en respons fra modtageren, som du kan spore. Dette gør det muligt for dig at følge op med dine modtagere, når du har modtaget alle svarene.

For eksempel kan et linkklik åbne en ny hjemmeside eller opdatere en modtagers kontaktkort. Det kan også tilføje en [Service-sag][8].

Du kan oprette ofte brugte links, selv før du opretter indhold. Dette giver dig mulighed for at genbruge disse links og spare tid. Almindeligt anvendte links inkluderer:

* Afmeldelseslink
* Kontaktformularer
* Kanaler til sociale medier

![På skærmbilledet for indstillinger af links kan du tilføje links, du vil spore -screenshot][img4].

URL'erne skal være unikke for hver enkelt modtager, så du kan være sikker på, at det var forskellige modtagere, der klikkede på linket, og ikke den samme, der klikkede flere gange. Derudover skal URL-adresser pege på SuperOffice-serveren, så de kan tælles, før de omdirigeres til den oprindelige URL-adresse. Dette klarer programmet automatisk, når du vælger, hvilke af URL-adresserne i meddelelsen, du ønsker at spore.

## Hvilke links bliver sporet?

For at se alle links i en mailudsendelse, skal du åbne udsendelsen i visningstilstand og vælge fanen **Sporede links**.

## Fanen Sporede links

I fanebladet **Sporede links** har du følgende valgmuligheder:

| Ikon | Mulighed | Læs mere |
|:-:|---|---|
| <i class="ph ph-plus" aria-label="Plus"></i> | Tilføj | [Opret et nyt link][1], [Definer linkhandlinger][7] |
| <i class="ph ph-folder" aria-label="Folder"></i> | Tilføj mappe | [Opret en mappe][5] til dine links |
| Link | Klik på et link for at åbne **Visning af link** -screenshott. | [Arbejde med sporede links efter udsendelsen][2] |
| <i class="ph ph-list" aria-label="Task menu"></i> | Menu | Klik på knappen ud for et link for at få adgang til flere indstillinger: |

Menuindstillinger:

* [**Vis**][2]
* [**Rediger**][1]
* [**Nulstil**][10] (linktællere)
* **Flyt til mappe** (flytter linket til en anden mappe)
* **Slet**

## <a id="ex"></a>Eksempler på brug

Sporbare links kan bruges på forskellige måder:

* **Svar**: Optag hvert modtagerklik på et link, som f.eks. en ny produktside, for at måle interesse på tværs af flere udsendelser.

* **Prospektliste**: For en lancering af et nyt produkt kan modtagere vise interesse ved at klikke på linket "Send mig mere info". Klikkere kan tilføjes til et [statisk udtræk][9] til at håndtere den videre kontakt med disse kunder.

* **CRM-opfølgning**: Generer i stedet for en prospektliste en opgave eller møde for hvert linkklik og tildel det til en salgsmedarbejder eller kundekontakt. For eksempel kan et klik på linket "Kontakt mig" generere en opfølgning med "Udgående telefonopkald".

* **Afmelding**: Indsæt en [afmeldingslink][4] i indholdsredigeringsværktøjet for at stoppe en bestemt type udsendelse. Alternativt kan kunder afmelde sig fra individuelle modtagerlister.

    Tilføj et link (f.eks. "Klik her, hvis du ikke længere ønsker at modtage vores nyhedsbreve") for at fjerne kunder fra modtagerlisten. Hvis et nyhedsbrev kun sendes til kontakter med interesse for "Nyhedsbrev", kan denne interesse fjernes for linkklikkerne.

    > [!TIP]
    > Overvåg afmeldinger ved at tilføje linkklikkerne til et separat udtræk, f.eks. "Nyhedsbrev 2024 - afmeldte abonnementer". Flere handlinger kan tilføjes det samme link.

* **Book konsulent**: Til en større produktopdatering, tilføj et link til kunderne for at booke en konsulent. Hvert linkklik registrerer en ny Service-sag, tildelt til kategorien "Konsulent". Kunden modtager feedback om, at de vil blive kontaktet af en konsulent.

> [!NOTE]
> Disse eksempler fungerer lige så godt for almindelige links, men i så fald registreres kun klik for den enkelte udsendelse.

## <a id="google"></a>Google Analytics

Når du konfigurerer en udsendelse, har du mulighed for at bruge Google Analytics som sporingssystem. I indstillingerne af mailudsendelser har du mulighed ved hjælp af specifikke felter at definere en mere præcis sporing af dine e-mails, så du får mere detaljerede rapporter fra Google Channel.

Google Analytics er den mest populære software til dataanalyse. Ved at spore, hvordan besøgende finder og bruger dit websted, får din virksomhed nyttige indsigter, der hjælper dig med at forbedre effekten af dine markedsføringsstrategier for onlinemarketing.

Som standard identificerer Google Analytics ikke besøgende, der tilgår sitet via specifikke mailudsendelser. Du skal tilføje et tag til linkene i din e-mail for at kunne:

* Se, hvilke links dine modtagere har klikket på
* se, hvilke sider de har besøgt, da de landede på dit websted

Når du linker til dit websted i en mailudsendelse og ikke bruger tags, kan du se, at dine besøgende kommer fra en mailudsendelse, men du ved ikke præcist hvilken. Resultatet bliver, at du ikke får viden om, hvordan modtagerne af de specifikke mailudsendelser bruger dit websted.

Google Analytics-funktionen i SuperOffice Marketing identificerer dine mailudsendelser i rapporterne. Ved at tilføje et unikt tag til alle de links, du indsætter i din mailudsendelse, vil Google Analytics kunne identificere den konkrete udsendelse som kilden, hvorfra de besøgende tilgår webstedet. Google Analytics giver dig også indsigt i de besøgendes vej rundt på dit websted.

**Medie**: "E-mail" er det foruddefinerede medie til automatiserede UTM-tags. Det betyder, at sporede links i mails sendt fra SuperOffice vil kunne findes i rapporter fra Google Channel under "Emails" (i stedet for under "Andet").

**Kilde** og **Kampagne**: Disse felter identificerer denne specifikke udsendelse som kilde og giver mulighed for en mere præcis sporing og rapportering i Google.

## Relateret indhold

* [Medtage links, du vil spore][3]
* [Tilføje abonnement-links][4]
* [Enkel e-mailsporing med Google Analytics][6]

<!-- Referenced links -->
[1]: create-links.md
[2]: explore-clicks.md
[7]: define-link-actions.md
[6]: ga-tutorial.md
[10]: reset-counter.md
[3]: ../../editor/learn/add-tracked-link-to-msg.md
[4]: ../../editor/learn/add-unsubscribe-link.md
[5]: ../../learn/create-folder.md
[8]: ../../../request/learn/index.md
[9]: ../../../search-options/selection/learn/static-selections.md

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/marketing/link-properties.png
