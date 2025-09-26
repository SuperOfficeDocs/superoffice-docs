---
uid: help-sv-mailing
title: Arbeta med utskick
description: Arbeta med utskick
keywords: Marknadsföring
author: SuperOffice Product and Engineering, Jeanette Small Strøm
date: 09.26.2025
version: 10.5
content_type: concept
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
redirect_from: /sv/marketing/mailing/learn/follow-up/index
language: sv
---

# Arbeta med utskick

Ett utskick hanteras vanligtvis i två steg:

* [Förbereda och skicka utskicket][1]
* [Följa upp det genomförda utskicket](#after)

## Utskickstyper

* E-post
* SMS
* Dokument
* Formulärsvar

> [!NOTE]
> E-postutskick och formulärsvar är de mest funktionsrika av utskickstyperna. Funktioner som [spårade länkar][7] och [prenumerationslänkar][6] är inte tillgängliga i SMS-utskick och dokumentutskick.

## Definiera ditt mål

För att säkerställa att ditt utskick blir framgångsrikt behöver du först och främst nå ut till rätt personer. Ju mer du kan avgränsa din målgrupp, desto större är dina chanser att rätt budskap når rätt person.

Vad vill du uppnå med ditt utskick? Vill du:

* Få fler potentiella kunder?
* Sälja fler nya produkter eller tjänster till dina befintliga kunder?
* Förbättra kundlojaliteten och behålla kunder?
* Informera om ny utveckling, milstolpar eller erbjudanden?

SuperOffice CRM erbjuder många sätt att skapa en gedigen [mållista][8]. Du kan använda urval, projekt eller en enskild kontakt i systemet. Alla kontakter som ännu inte är tillgängliga i SuperOffice CRM-databasen kan läggas till genom att importera en Excel-lista, förutsatt att du har deras samtycke till att ditt företag skickar marknadsföringsmeddelanden.

Du kan också bygga en e-postlista med hjälp av [online-webbformulär][5]. Du kan inte bara fånga upp nya potentiella kunder bland besökarna på din webbplats som fyller i ett webbformulär, utan du kan också använda webbformulär för att bjuda in människor att prenumerera på eller registrera sig för olika utskick.

Läs mer om hur du [skapar och använder webbformulär i Marknadsföring][4].

## Mottagare

Du kan lägga till mottagare från flera källor.

> [!NOTE]
> När du lägger till mottagare läggs bara kontakter med en giltig e-postadress (eller ett giltigt mobiltelefonnummer, om det gäller SMS-utskick) till i listan **Mottagare**.

Importerade mottagare som INTE hittas i SuperOffice-databasen består endast av ett namn och en e-postadress (eller bara en e-postadress). Det innebär att endast mallvariablerna **\[\[customer.name\]\]** och/eller **\[\[customer.email\]\]** fungerar för dessa mottagare. För att undvika tomma variabler i dina utskick bör du alltid [förhandsgranska utskicket][3] först.

## Koppla ett utskick till urval eller projekt

Du kan koppla utskicket till ett urval och/eller ett projekt för att hålla reda på alla utskick relaterade till dina urval och projekt. Utskicken listas på detaljkortet **Utskick** i **Urval** samt på detaljkortet **Aktiviteter** i **Projekt** i SuperOffice CRM.

> [!NOTE]
> Om du lägger till ett urval eller ett projekt läggs alla kontakter i urvalet eller projektet till som mottagare i utskicket. Om du lägger till både ett urval och ett projekt läggs bara kontakterna från urvalet till som mottagare.

Exempel: Om du skickar ut flera utskick för att göra reklam för ett visst evenemang kan du lägga till dessa utskick i ett urval kallat "Evenemang 2015" för att på så sätt få en komplett lista över alla utskick för evenemanget. Och om du skapar ett projekt för evenemanget kan du på liknande sätt ha en lista över alla projektrelaterade utskick på detaljkortet **Aktiviteter**.

## Betydelsen av e-postleverans

E-postmarknadsföring är en kostnadseffektiv marknadsföringsstrategi som kan resultera i [hög avkastning på investeringen][20]. Men för att få ut mesta möjliga av detta marknadsföringsverktyg måste dina e-postmeddelanden nå fram till målgruppens inkorgar, inte deras skräppostmapp.

Föreställ dig detta scenario: du har noggrant skapat en e-postkampanj med förstklassigt innehåll och design, tryckt på skicka-knappen och får lite till ingen respons. Din öppningsfrekvens är nedslående, och det finns många studsar eller, ännu värre, du blir märkt som skräppost.

**E-postleverans** är viktig eftersom det avgör om dina e-postmeddelanden faktiskt når abonnenternas inkorgar eller inte. Om de inte levereras kommer de inte att ses eller läsas av din målgrupp, vilket innebär förlorade möjligheter och lägre framgång för dina e-postmarknadsföringskampanjer. Kolla in våra [bästa praxis][9].

## <a id="after"></a>Hur gör jag för att följa upp utskick?

När ditt utskick är skickat är det alltid spännande att se hur bra det har presterat. För att se om allt ditt hårda arbete har lönat sig. Det är också ett utmärkt tillfälle att kontrollera och förbättra kvaliteten på den information som registreras i din CRM-databas.

* [Visa statistik][2] för utskicket och få information om eventuella problem som uppstod.
* [Lägg till mottagare i urval och projekt][12] för vidare behandling.
* [Kontrollera och e korrigera e-postadresserna för de meddelanden som inte har kunnat levereras][11].
* Se [vem som har klickat på de spårbara länkar][14] som du har lagt in i meddelandet.
* Hantera e-postadresser som returnerades på grund av permanenta fel eller [som returnerades][13] flera gånger.

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
