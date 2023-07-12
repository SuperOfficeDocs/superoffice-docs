---
uid: help-da-mailing-tracked-links
title: Sporede links
description: "Et link, der sættes ind i en mailudsendelse, kan bruges til at spore besvarelser fra både eksisterende og potentielle kunder. Når modtagerne af din mailudsendelse klikker på linket, aktiveres en handling." 
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: concept
language: da
---

# Sporede links

[!include[Requirement](includes/req-marketing.md)]

Formålet med dit nyhedsbrev eller din e-mailkampagne er det der afgør, hvilke links du skal bruge. Hvert formål vil udløse en bestemt respons fra den modtager, du ønsker at spore. På den måde kan du følge op på dine modtagere, så snart du har modtaget alle svarene.

For eksempel kan et klik på et link åbne en ny hjemmeside eller opdatere din modtagers kontaktoplysninger. Handlingen kan også oprette en service-sag i Service og i fanen Sag på visitkortet. Brugen af links er kun tilgængelig for brugere, der abonnerer på Marketingplanen.

Før du iværksætter den egentlige mailudsendelse, kan du sætte de links ind, som du ofte bruger i dine mailudsendelser. Når du har konfigureret dem, kan du bruge dem igen og igen, hvilket hjælper dig med at spare tid. De links, der er mest almindelige at bruge, er f.eks:

* Afmeldelseslink
* Kontaktformularer
* Kanaler til sociale medier

![På skærmbilledet for indstillinger af links kan du tilføje links, du vil spore -screenshot][img4].

Du kan i en meddelelse medtage links (URL-adresser), som du kan spore. Med andre ord kan du se, hvor mange modtagere der har klikket på dem.

URL'erne skal være unikke for hver enkelt modtager, så du kan være sikker på, at det var forskellige modtagere, der klikkede på linket, og ikke den samme, der klikkede flere gange. Derudover skal URL-adresser pege på SuperOffice-serveren, så de kan tælles, før de omdirigeres til den oprindelige URL-adresse. Dette klarer programmet automatisk, når du vælger, hvilke af URL-adresserne i meddelelsen, du ønsker at spore.

I fanebladet **Sporede links** har du følgende valgmuligheder:

| Ikon | Mulighed | Læs mere |
|---|---|---|
| ![Ikon][img2] | Tilføj | [Opret et nyt link][1] |
| ![Ikon][img3] | Tilføj mappe | [Opret en mappe][5] til dine links |
| Link | Klik på et link for at åbne **Visning af link** -skærmbilledet. | [Arbejde med sporede links efter udsendelsen][2] |
| ![Ikon][img1] | Menu | Klik på knappen ud for et link for at få adgang til flere indstillinger: |

Menuindstillinger:

* **Vis**. [Sådan arbejder du med sporede links efter mailudsendelsen][2].
* **Rediger**. [Sådan opretter du sporede links][1].
* **Nulstil**. [Sådan nulstiller du linktællere][2].
* **Flyt til mappe**. Bruges til at flytte linket til en anden mappe.
* **Slet**. Sletter linket.

## Hvilke links bliver sporet?

For at [se alle links i en mailudsendelse][4], skal du åbne udsendelsen i visningstilstand og vælge fanen **Sporede links**.

## <a id="google" />Google Analytics

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
* [Enkel e-mailsporing med Google Analytics][6] - blog
* [Definer linkhandlinger][7]

<!-- Referenced links -->
[1]: create-links.md
[2]: explore-clicks.md
[3]: add-tracked-link-to-msg.md
[4]: ../../mailing/learn/create/add-unsubscribe-link.md
[5]: ../../learn/create-folder.md
[6]: https://community.superoffice.com/en/technical/blogs/archive/simple-google-analytics-email-tracking/
[7]: define-link-actions.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-menu.png
[img2]: ../../../../media/icons/btn-add.png
[img3]: ../../../../../common/icons/folder.png
[img4]: ../../../../media/loc/en/marketing/link-properties.png
