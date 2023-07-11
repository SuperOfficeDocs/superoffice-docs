---
uid: help-sv-mailing-tracked-links
title: Spårade länkar
description: En länk som du inkluderar i ett utskick kan användas för att spåra svar från dina befintliga och potentiella kunder. När mottagarna av ditt utskick klickar på länken utförs en åtgärd. 
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marknadsföring
so.topic: concept
language: sv
---

# Spårade länkar

[!include[Requirement](includes/req-marketing.md)]

Målet med ditt nyhetsbrev eller din e-postkampanj avgör vilka länkar du ska använda. Varje mål har sin egen uppmaning som utlöser ett svar från mottagaren som du vill spåra. På så sätt kan du följa upp dina mottagare efter att du har fått alla resultat.

Om du till exempel klickar på en länk kan du öppna en ny webbplats eller uppdatera mottagarens kontaktkort. Åtgärden kan också lägga till ett serviceärende i Service och på detaljkortet Ärende på kontaktkortet. Användningen av länkar är endast tillgänglig för användare som prenumererar på marknadsföringsplanen.

Innan du påbörjar själva utskicket kan du ställa in de länkar du kommer att använda ofta i dina utskick. När du har ställt in dem kan du använda dem om och om igen, vilket gör att du kan spara tid. De vanligaste länkarna att använda är till exempel:

* Sidor för avregistrering
* Kontaktformulär
* Sociala mediekanaler

![I fönstret Länkegenskaper kan du lägga till länkar som du vill spåra -screenshot][img4]

Du kan inkludera spårbara länkar (URL-adresser) i meddelanden. Med hjälp av dessa kan du se hur många mottagare som har klickat på dem.

URL-adresserna måste vara unika för varje mottagare så att du kan vara säker på att det är olika mottagare som har klickat på dem och inte samma mottagare som har klickat flera gånger. Dessutom måste URL-adresserna peka mot SuperOffice-servern så att besökarna kan räknas innan de omdirigeras till den faktiska URL-adressen. Detta sköter programmet automatiskt när du väljer vilka URL-adresser i meddelandet som du vill spåra.

På fliken **Spårade länkar** har du följande alternativ:

| Ikon | Alternativ | Läs mer |
|---|---|---|
| ![ikon][img2] | Lägga till | [Skapa en ny länk][1] |
| ![ikon][img3] | Lägg till mapp | [Skapa en mapp][5] för dina länkar |
| Länk | Klicka på en länk om du vill öppna skärmen **Visa länk**. | [Jobba med spårade länkar efter utskicket][2] |
| ![ikon][img1] | Meny | Klicka på menyknappen bredvid en länk för att få tillgång till fler alternativ. |

Menyalternativ:

* **Visa**. [Så här jobbar du med spårade länkar efter utskicket][2].
* **Redigera**. [Så här skapar du spårade länkar][1].
* **Återställ**. [Så här nollställer du räknare för länkar][2].
* **Flytta till mall**. Används för att flytta länken till en annan mapp.
* **Ta bort**. Tar bort länken.

## Vilka länkar spårar jag?

Om du vill [visa alla länkar i ett utskick][4] kan du öppna utskicket i visningsläge och välja fliken **Spårade länkar**.

## <a id="google" />Google Analytics

När du konfigurerar ett utskick har du möjlighet att använda Google Analytics som spårningssystem. Med inställningen i utskick kan du definiera en mer exakt spårning av e-postmeddelanden med hjälp av de tillhandahållna fälten, vilket ger mer detaljerade Google Channel-rapporter.

Google Analytics är den mest populära programvaran för digital analys som finns tillgänglig. Genom att spåra hur webbplatsbesökare hittar och använder din webbplats ger tjänsten ditt företag användbara insikter som hjälper dig att nå ökad framgång för dina marknadsföringsstrategier online.

Som standard identifierar Google Analytics inte besökare som kommer från specifika utskick. Du måste lägga till en tagg i länkarna i ditt e-postmeddelande för att kunna:

* Identifiera vilka länkar dina mottagare har klickat på,
* Se vilka webbsidor de besökte efter att de hamnade på din webbplats.

När du lägger till en länk till din webbplats i ditt utskick utan tagg kan du se att dina besökare kommer från ett utskick, men du vet inte vilket specifikt utskick. Det gör att du inte vet hur mottagarna av specifika utskick agerar på din webbplats.

Google Analytics-funktionen i SuperOffice Marknadsföring identifierar dina utskick i rapporterna. Genom att lägga till en unik tagg till alla länkar du använder i ditt utskick kommer Google Analytics att känna igen ditt utskick som källan varifrån webbplatsbesökarna kommer. Google Analytics ger dig också insikt i besökarnas sökväg på din webbplats.

**Medel**: "E-post" det förvalda mediet i automatiserade UTM-taggar. Det innebär att spårade länkar i utskick som skickas från SuperOffice finns i Google Channel-rapporter under "E-postadresser" (i motsats till "annat").

**Källa** och **Kampanj**: Dessa fält identifierar just detta utskick som källan, och möjliggör en mer exakt spårning och rapportering i Google.

## Relaterat innehåll

* [Inkludera länkar som du vill kunna spåra][3]
* [Lägg till prenumerationslänkar][4]
* [Simple Google Analytics e-mail tracking][6] – blogg
* [Definiera länkningsåtgärder][7]

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
